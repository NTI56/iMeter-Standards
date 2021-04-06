using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting
{
    [Serializable]
    [DataContract]
    public enum MemoryOffsetMode
    {
        [XmlEnum("")]
        [EnumMember]
        Unknown = 0,
        [XmlEnum("FromBeginning")]
        [EnumMember]
        FromBeginning = 1,
        [XmlEnum("FromTheEndOfThePrevious")]
        [EnumMember]
        FromTheEndOfThePrevious = 2
    }
}
