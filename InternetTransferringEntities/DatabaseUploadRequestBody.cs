using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NTI.iMeter.InternetTransferringEntities
{
    [DataContract]
    public class DatabaseUploadRequestBody
    {
        [DataMember]
        public Guid ProjectId { get; set; }
        [DataMember]
        public Dictionary<Guid, int> FailedServers { get; set; }
    }
}
