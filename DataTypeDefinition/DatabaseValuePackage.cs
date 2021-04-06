using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    [Serializable]
    [DataContract]
    public class DatabaseValuePackage
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public Guid ExpandedVariableId { get; set; }
        [DataMember]
        public string ExpandedPath { get; set; }
        [DataMember]
        public string ExpandedIdPath { get; set; }
        [DataMember]
        public DataType DataType { get; set; }
        [DataMember]
        public Guid? StrongCustomizedTypeTypeId { get; set; }
        [DataMember]
        public SerializedData SerializedData { get; set; }
        [DataMember]
        public Guid? ProcessorId { get; set; }
        [DataMember]
        public Guid? ProcessorOutputId { get; set; }
        [DataMember]
        public string ProcessorOutputIndices { get; set; }
    }
}
