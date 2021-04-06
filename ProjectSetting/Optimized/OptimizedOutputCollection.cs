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
    public class OptimizedOutputCollection
    {
        [DataMember]
        public Collection<Guid> ExpandedVariableIds { get; set; } = new Collection<Guid>();
    }
}
