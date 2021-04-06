using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting.Crawler
{
	[Serializable]
	[DataContract]
	public class CrawlerDefinition : Entity
	{
		private ObservableCollection<Guid> _sequencerIds = new ObservableCollection<Guid>();

		[DataMember]
		public ObservableCollection<Guid> SequencerIds
		{
			get { return _sequencerIds; }
			set
			{
				if (Equals(value, _sequencerIds)) return;
				BeforePropertySet();
				_sequencerIds = value;
				AfterPropertySet();
			}
		}
	}
}
