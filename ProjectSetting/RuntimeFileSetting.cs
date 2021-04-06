using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting
{
    [Serializable]
    [DataContract]
    public class RuntimeFileSetting
    {
        [DataMember]
        public Guid LibraryId { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public Collection<string> ExtraRuntimeFiles { get; set; } = new Collection<string>();
    }
}
