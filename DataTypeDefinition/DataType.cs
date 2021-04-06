using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter
{
    [DataContract]
    [Serializable]
    public enum DataType
    {
        [EnumMember]
        [XmlEnum]
        StrongCustomizedType,
        [EnumMember]
        [XmlEnum]
        Integer,
        [EnumMember]
        [XmlEnum]
        UnsignedInteger,
        [EnumMember]
        [XmlEnum]
        String,
        [EnumMember]
        [XmlEnum]
        Decimal,
        [EnumMember]
        [XmlEnum]
        Boolean,
        [EnumMember]
        [XmlEnum]
        DateTime
    }
}
