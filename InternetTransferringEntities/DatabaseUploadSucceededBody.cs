using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NTI.iMeter.InternetTransferringEntities
{
    [DataContract]
    public class DatabaseUploadSucceededBody
    {
        [DataMember]
        public Guid ProjectId { get; set; }
        [DataMember]
        public Guid FileServerId { get; set; }
        [DataMember]
        public Guid FileId { get; set; }
        [DataMember]
        public long FileSize { get; set; }
    }
}
