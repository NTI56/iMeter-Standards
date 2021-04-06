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
    public class OptimizedDefinition
    {
	    [DataMember]
	    public OptimizedVariableCollection Variables { get; set; } = new OptimizedVariableCollection();

        [DataMember]
        public IdWithPointer[] Converters { get; set; }

        [DataMember]
        public OptimizedCrawler[] Crawlers { get; set; }

        [DataMember]
        public OptimizedProcessorWave[] ProcessorWaves { get; set; }

        [DataMember]
        public OptimizedOutputCollection Outputs { get; set; }
    }
}
