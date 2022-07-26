using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace FootballStarz.Classes
{
    public sealed class FBSBlobCache
    {
        FBSBlobCache() 
        {
        BlobCache = new List<FBSBlob>();
        }

        public List<FBSBlob> BlobCache;

        private static readonly object myLock = new object ();  
    
        private static FBSBlobCache instance = null;                // Singleton pattern, one run - one data
        public static FBSBlobCache Instance
        {
            get
            {
                lock (myLock)
                    {
                        if (instance == null)
                        {
                            instance = new FBSBlobCache();
                        }
                        return instance;
                    }
            }
        }

        public async Task FillCacheFromAzure()
        {
            if(this.BlobCache.Count == 0)                                              // as part of singleton, only retrieve from Azure container once.
            {
            var fbsprops = await GetFBSContainerProperties(Constants.fbsStorageAccountName, Constants.fbsStorageAccountKey, Constants.fbsBlobServiceEndpoint);
            var container = new FBSContainer(Constants.fbsStorageAccountName, fbsprops);
            var nameList = await GetBlobContainerItems(fbsprops);
            container.ContainerName = nameList[0];                                   // always takes the first container name

            this.BlobCache = await GetBlobItems(container, fbsprops);                // retrieve blob items
            }


        }

        private async Task<FBSContainerProperties> GetFBSContainerProperties(string storageAccountName, string storageAccountKey, string blobServiceEndpoint)
        {
            var fbsprops = new FBSContainerProperties();

            try
            {
                var acr = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);
                var scl = new BlobServiceClient(new Uri(blobServiceEndpoint), acr);
                var inf = await scl.GetAccountInfoAsync();

                fbsprops.AccountCredentials = acr;
                fbsprops.ServiceClient = scl;
                fbsprops.Info = inf;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }

            return fbsprops;
        }

        private async Task<List<String>> GetBlobContainerItems(FBSContainerProperties fbsprops)
        {
            var slist = new List<String>();

            await
            foreach (BlobContainerItem contnr in fbsprops.ServiceClient.GetBlobContainersAsync())
            {
                slist.Add(contnr.Name);
            }

            return slist;
        }


        private async Task<List<FBSBlob>> GetBlobItems(FBSContainer BlobContainer, FBSContainerProperties fbsprops)
        {
            var blobs = new List<FBSBlob>();

            BlobContainerClient blobcontainer = fbsprops.ServiceClient.GetBlobContainerClient(BlobContainer.ContainerName);

            await
            foreach (BlobItem blob in blobcontainer.GetBlobsAsync())
            {
                blobs.Add(
                   new FBSBlob
                   {
                       ContainerName = BlobContainer.ContainerName,
                       BlobPath = BlobContainer.Uri.ToString(),
                       BlobName = blob.Name.ToString()
                   }
                   );
            }

            return blobs;
        }

    }
}
