using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace NTI.iMeter.InternetTransferringEntities
{
    [Serializable]
    [DataContract]
    [XmlInclude(typeof(SerializedDataInteger))]
    [XmlInclude(typeof(SerializedDataUnsignedInteger))]
    [XmlInclude(typeof(SerializedDataString))]
    [XmlInclude(typeof(SerializedDataBoolean))]
    [XmlInclude(typeof(SerializedDataDateTime))]
    [XmlInclude(typeof(SerializedDataDecimal))]
    [XmlInclude(typeof(SerializedDataStrongCustomizedType))]
    public class ClientOutputData
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public DataType DataType { get; set; }
        [DataMember]
        public Guid? StrongCustomizedTypeTypeId { get; set; }

        [DataMember]
        public Guid ExpandedVariableId { get; set; }
        [DataMember]
        public string ExpandedPath { get; set; }
        [DataMember]
        public string ExpandedIdPath { get; set; }

        [DataMember]
        public SerializedDataCompressed SerializedData { get; set; }

        [DataMember]
        public Guid? ProcessorId { get; set; }
        [DataMember]
        public Guid? ProcessorOutputId { get; set; }
        [DataMember]
        public string ProcessorOutputIndices { get; set; }
    }
}
