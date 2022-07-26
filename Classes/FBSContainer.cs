using System;
using System.Collections.Generic;


namespace FootballStarz.Classes
{
    public class FBSContainer
    {
        public FBSContainer( String storageAccountName, FBSContainerProperties fbsprops)
        {
            StorageAccountName = storageAccountName;
            AccountKind = fbsprops.Info.AccountKind.ToString();
            SkuName = fbsprops.Info.SkuName.ToString();
            Uri = fbsprops.ServiceClient.Uri.OriginalString;
            Blobs = new List<FBSBlob>();
        }

        public String StorageAccountName { get; set; }
        public String AccountKind { get; set;  }
        public String SkuName { get; set; }
        public String ContainerName { get; set; }
        public String Uri { get; set; }
        public List<FBSBlob> Blobs { get; set;  }
    }
}
