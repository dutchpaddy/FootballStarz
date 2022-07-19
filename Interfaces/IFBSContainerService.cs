using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using FootballStarz.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStarz.Interfaces
{
    public interface IFBSContainerService
    {
        public Task<String> GetCachedImageUrl(String key);
        
    }
}
