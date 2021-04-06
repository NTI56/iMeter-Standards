using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Override
{
    [Serializable]
    [DataContract]
    public enum OverrideType
    {
        [XmlEnum("")]
        [EnumMember]
        Unknown = 0,
        [XmlEnum("Name")]
        [EnumMember]
        Name = 1,
        [XmlEnum("Description")]
        [EnumMember]
        Description = 2,
        [XmlEnum("Filter")]
        [EnumMember]
        Filter = 3,
        [XmlEnum("Alerter")]
        [EnumMember]
        Alerter = 4
    }
}
