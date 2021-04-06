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
    public enum LogLevel
    {
        [XmlEnum("")]
        [EnumMember]
        Unknown = 0,

        [XmlEnum("Critical")]
        [EnumMember]
        Critical = 4,
        [XmlEnum("Warning")]
        [EnumMember]
        Warning = 3,
        [XmlEnum("Informational")]
        [EnumMember]
        Informational = 2,
        [XmlEnum("Debugging")]
        [EnumMember]
        Debugging = 1
    }
}
