using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NTI.iMeter.InternetTransferringEntities
{
    [DataContract]
    public class ProjectQueryResponse
    {
        [DataMember]
        public Guid ProjectId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public List<ProjectVersionInfo> ProjectVersions { get; set; }
    }

    [DataContract]
    public class ProjectVersionInfo
    {
        [DataMember]
        public string User { get; set; }
        [DataMember]
        public string Version { get; set; }
        [DataMember]
        public DateTime UploadTimeUtc { get; set; }
        [DataMember]
        public Guid VersionId { get; set; }
        [DataMember]
        public int FileSize { get; set; }
    }
}
