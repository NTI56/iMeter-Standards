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
    public class ExpandedVariable
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string ExpandedIdPath { get; set; } //Guid[index].Guid[index].Guid.Guid.Guid[index]....
        [DataMember]
        public string ExpandedPath { get; set; } //Name[index].Name[index].Name.Name.Name[index]....
        [DataMember]
        public DataType DataType { get; set; }
        [DataMember]
        public Guid? StrongCustomizedTypeTypeId { get; set; }
        [DataMember]
        public Guid? StrongCustomizedTypeSettingId { get; set; }

        [DataMember]
        public Guid? AlerterId { get; set; }
        [DataMember]
        public Guid? FilterId { get; set; }

        [DataMember]
        public bool IsLatestValueRequired { get; set; }

        [XmlIgnore]
        [IgnoreDataMember]
        public IdWithPointer Filter { get; internal set; }
        [XmlIgnore]
        [IgnoreDataMember]
        public AlerterPointer Alerter { get; internal set; }
        [XmlIgnore]
        [IgnoreDataMember]
        public IdWithPointer StrongCustomizedType { get; internal set; }
    }
}
