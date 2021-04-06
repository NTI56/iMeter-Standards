using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Optimized
{
    [Serializable]
    [DataContract]
    public class ChannelReadingBlock
    {
        //[DataMember]
        //public Guid InputDefinitionId { get; set; }

        [DataMember]
        public Guid BlockId { get; set; }

        [DataMember]
        public int StartIndex { get; set; }
        [DataMember]
        public int Length { get; set; }

        [DataMember]
        public Collection<ConverterSelectedOutput> Jobs { get; set; } = new Collection<ConverterSelectedOutput>();

        public void BuildOptimizedData(Dictionary<Guid, ExpandedVariable> indexedExpandedVariables, Dictionary<Guid, IdWithPointer> indexedConverters)
        {
            foreach (var job in Jobs)
            {
                job.Converter = indexedConverters[job.ConverterId];
                job.ExpandedVariable = indexedExpandedVariables[job.ExpandedVariableId];
            }
        }
    }
}
