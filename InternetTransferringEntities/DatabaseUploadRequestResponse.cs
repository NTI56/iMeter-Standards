using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NTI.iMeter.InternetTransferringEntities
{

    [DataContract]
    public class DatabaseUploadRequestResponse
    {
        [DataMember]
        public Guid FileServerId { get; set; }
        [DataMember]
        public string UploadingAddress { get; set; }
    }
}
