using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Optimized
{
    [Serializable]
    [DataContract]
    public class ConverterSelectedOutput
    {
        [DataMember]
        public Guid ConverterId { get; set; }
        [XmlIgnore]
        [IgnoreDataMember]
        public IdWithPointer Converter { get; set; }
        [DataMember]
        public int OffsetFromReadingBlockStart { get; set; }
        [DataMember]
        public int Length { get; set; }

        [DataMember]
        public bool IsTimeSource { get; set; }
        [DataMember]
        public bool IsStrongCustomizedTypeTimeSource { get; set; }

        [DataMember]
        public Guid SelectedConverterOutputId { get; set; }
        [DataMember]
        public Guid ExpandedVariableId { get; set; }
        [XmlIgnore]
        [IgnoreDataMember]
        public ExpandedVariable ExpandedVariable { get; set; }
    }
}
