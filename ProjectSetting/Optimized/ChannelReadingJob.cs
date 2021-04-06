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
    public class ChannelReadingJob
    {
        [DataMember]
        public Guid DeviceId { get; set; }
        [DataMember]
        public Guid ChannelId { get; set; }


        [DataMember]
        public int FetchInterval { get; set; }
        [DataMember]
        public Collection<ChannelReadingBlock> Blocks { get; set; } = new Collection<ChannelReadingBlock>();

        public void BuildOptimizedData(Dictionary<Guid, ExpandedVariable> indexedExpandedVariables, Dictionary<Guid, IdWithPointer> indexedConverters)
        {
            foreach(var block in Blocks)
                block.BuildOptimizedData(indexedExpandedVariables, indexedConverters);
        }
    }
}