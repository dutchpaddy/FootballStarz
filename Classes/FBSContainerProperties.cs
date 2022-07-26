using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStarz.Classes
{
    public class FBSContainerProperties
    {
        public StorageSharedKeyCredential? AccountCredentials { get; set; }
        public BlobServiceClient? ServiceClient { get; set; }
        public AccountInfo? Info { get; set; }

    }
}
