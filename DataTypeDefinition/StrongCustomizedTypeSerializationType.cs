using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    /// <summary>
    /// Serializing support of strong customized type
    /// </summary>
    [DataContract]
    public enum StrongCustomizedTypeSerializationType
    {
        /// <summary>
        /// Not supported. Cannot be save into database. Only be used within one wave of processors.
        /// </summary>
        [EnumMember]
        NotSupported,
        /// <summary>
        /// Binary serialization. IStrongCustomizedTypeBinaryBasedSerializable need to be implemented by the data type.
        /// </summary>
        [EnumMember]
        Binary,
        /// <summary>
        /// String serialization. IStrongCustomizedTypeStringBasedSerializable need to be implemented by the data type.
        /// </summary>
        [EnumMember]
        String
    }
}
