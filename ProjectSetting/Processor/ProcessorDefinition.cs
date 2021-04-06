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
	public class ProcessorDefinition : Entity
	{
		private ExternalComponentPointer _processor;
		private ObservableCollection<ProcessorInput> _inputs = new ObservableCollection<ProcessorInput>();
		private ObservableCollection<ProcessorOutput> _outputs = new ObservableCollection<ProcessorOutput>();

		[DataMember]
		public ExternalComponentPointer Processor
		{
			get { return _processor; }
			set
			{
				if (Equals(value, _processor)) return;
				BeforePropertySet();
				_processor = value;
				AfterPropertySet();
			}
		}

		[DataMember]
		public ObservableCollection<ProcessorInput> Inputs
		{
			get { return _inputs; }
			set
			{
				if (Equals(value, _inputs)) return;
				BeforePropertySet();
				_inputs = value;
				AfterPropertySet();
			}
		}

		[DataMember]
		public ObservableCollection<ProcessorOutput> Outputs
		{
			get { return _outputs; }
			set
			{
				if (Equals(value, _outputs)) return;
				BeforePropertySet();
				_outputs = value;
				AfterPropertySet();
			}
		}
	}
}
