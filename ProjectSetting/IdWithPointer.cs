using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting
{
    [Serializable()]
    [DataContract]
    public class IdWithPointer
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public ExternalComponentPointer Pointer { get; set; }
    }
}
