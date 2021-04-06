using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting.Processor
{
	[Serializable]
	[DataContract]
	public class ProcessorWaveDefinition : Entity
	{
		private ObservableCollection<ProcessorDefinition> _processors = new ObservableCollection<ProcessorDefinition>();

		[DataMember]
		public ObservableCollection<ProcessorDefinition> Processors
		{
			get { return _processors; }
			set
			{
				if (Equals(value, _processors)) return;
				BeforePropertySet();
				_processors = value;
				AfterPropertySet();
			}
		}
	}
}
