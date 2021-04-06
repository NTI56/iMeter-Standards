using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting
{
    public interface IEntity
    {
        [DataMember]
        string Description { get; set; }
        [DataMember]
        Guid Id { get; set; }
        [DataMember]
        string Name { get; set; }
    }
}
