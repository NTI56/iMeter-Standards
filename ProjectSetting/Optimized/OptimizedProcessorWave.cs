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
    public class OptimizedProcessorWave
    {
	    [DataMember]
	    public Collection<OptimizedProcessorVariable> Variables { get; set; } =
		    new Collection<OptimizedProcessorVariable>();

        [DataMember]
        public Collection<IdWithPointer> Processors { get; set; } = new Collection<IdWithPointer>();
    }
}
