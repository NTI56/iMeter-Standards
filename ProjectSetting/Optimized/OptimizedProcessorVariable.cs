using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting.Optimized
{
    [Serializable]
    [DataContract]
    public class OptimizedProcessorVariable
    {
        [DataMember]
        public Guid ExpandedVariableId { get; set; }

	    [DataMember]
	    public Collection<OptimizedProcessorVariableReaderLink> Readers { get; set; } =
		    new Collection<OptimizedProcessorVariableReaderLink>();

        [DataMember]
        public Collection<OptimizedProcessorVariableWriterLink> Writers { get; set; } = new Collection<OptimizedProcessorVariableWriterLink>();
    }

    [Serializable]
    [DataContract]
    public class OptimizedProcessorVariableReaderLink
    {
        [DataMember]
        public Guid ProcessorDefinitionId { get; set; }

        [DataMember]
        public Guid ProcessorInputId { get; set; }

        [DataMember]
        public int[] ProcessorInputIndex { get; set; } //Null for non-array

        [DataMember]
        public bool IsLatestValuesRequired { get; set; }
    }

    [Serializable]
    [DataContract]
    public class OptimizedProcessorVariableWriterLink
    {
        [DataMember]
        public Guid ProcessorDefinitionId { get; set; }

        [DataMember]
        public Guid ProcessorOutputId { get; set; }

        [DataMember]
        public int[] ProcessorOutputIndex { get; set; } //Null for non-array

        [DataMember]
        public string ProcessorOutputIndices { get; set; } //Serialized indices, for saving to database only

        [DataMember]
        public bool IsAllowedWithEventTriggering { get; set; }
        [DataMember]
        public bool IsAllowedWithoutEventTriggering { get; set; }
        [DataMember]
        public bool PreservingRequired { get; set; }
    }
}
