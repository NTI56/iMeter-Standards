using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Type
{
    [Serializable]
    [DataContract]
    public enum TypeDefinitionType
    {
        [XmlEnum("")]
        [EnumMember]
        Unknown = 0,
        [XmlEnum("Basic")]
        [EnumMember]
        Basic = 1,
        [XmlEnum("Structure")]
        [EnumMember]
        Structure = 2,
        [XmlEnum("StrongCustomized")]
        [EnumMember]
        StrongCustomized = 3
    }
}
