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
    public class OptimizedVariableCollection
    {
	    [DataMember]
	    public Collection<AlerterPointer> Alerters { get; set; } = new Collection<AlerterPointer>();

	    [DataMember]
	    public Collection<IdWithPointer> Filters { get; set; } = new Collection<IdWithPointer>();
		[DataMember]
		public Collection<IdWithPointer> StrongCustomizedTypes { get; set; } = new Collection<IdWithPointer>();

	    [DataMember]
	    public Collection<ExpandedVariable> ExpandedVariables { get; set; } = new Collection<ExpandedVariable>();


        [XmlIgnore]
        [IgnoreDataMember]
        public Dictionary<Guid, ExpandedVariable> IndexedExpandedVariables { get; private set; }

        public void BuildOptimizedData()
        {
            var indexedAlerters = new Dictionary<Guid, AlerterPointer>(Alerters.Count());
            foreach(var item in Alerters)
            {
                indexedAlerters.Add(item.Id, item);
            }

            var indexedFilters = new Dictionary<Guid, IdWithPointer>(Filters.Count());
            foreach (var item in Filters)
            {
                indexedFilters.Add(item.Id, item);
            }

            var indexedStrongCustomizedTypes = new Dictionary<Guid, IdWithPointer>(StrongCustomizedTypes.Count());
            foreach(var item in StrongCustomizedTypes)
            {
                indexedStrongCustomizedTypes.Add(item.Id, item);
            }

            var result = new Dictionary<Guid, ExpandedVariable>();
            foreach (var item in ExpandedVariables)
            {
                result.Add(item.Id, item);
                if (item.AlerterId.HasValue) item.Alerter = indexedAlerters[item.AlerterId.Value];
                if (item.FilterId.HasValue) item.Filter = indexedFilters[item.FilterId.Value];
                if (item.StrongCustomizedTypeSettingId.HasValue) item.StrongCustomizedType = indexedStrongCustomizedTypes[item.StrongCustomizedTypeSettingId.Value];
            }
            IndexedExpandedVariables = result;
        }
    }
}
