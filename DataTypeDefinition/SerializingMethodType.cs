using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    [DataContract]
    public enum SerializingMethodType
    {
        [EnumMember]
        SystemType,
        [EnumMember]
        None,
        [EnumMember]
        String,
        [EnumMember]
        Binary
    }
}
