using FootballStarz.Classes;
using FootballStarz.Interfaces;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace FootballStarz.Services
{
    public class FBSContainerService : IFBSContainerService                 // service against a cached blob property List
    {                                                                       // actual image blobs rendered thru Azure URL
        private readonly List<FBSBlob> blobCache = new List<FBSBlob>();

 
        public async Task<String> GetCachedImageUrl( String Image  )
        {
            await FBSBlobCache.Instance.FillCacheFromAzure();               // Populating the blob property list ONCE if not yet done

            var findBlob = FBSBlobCache.Instance.BlobCache.Find(n=>n.BlobName!.EndsWith(Image));
        
            return findBlob!.BlobPath + findBlob.ContainerName! + "/" + findBlob.BlobName;
        
        }
 
    }
}
