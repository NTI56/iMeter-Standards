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
	public class ProcessorOutput : DataItem
	{
		private Guid _outputDefinitionId;
		private bool _isAllowedWithEventTriggering;
		private bool _isAllowedWithoutEventTriggering;
		private bool _preservingRequired;
		private string _fullIdPath;

		[DataMember]
		public Guid OutputDefinitionId
		{
			get { return _outputDefinitionId; }
			set
			{
				if (value.Equals(_outputDefinitionId)) return;
				_outputDefinitionId = value;
				OnPropertyChanged(nameof(OutputDefinitionId));
			}
		}

		[DataMember]
		public string FullIdPath
		{
			get { return _fullIdPath; }
			set
			{
				if (value == _fullIdPath) return;
				BeforePropertySet();
				_fullIdPath = value;
				AfterPropertySet();
			}
		}


		[DataMember]
		public bool IsAllowedWithEventTriggering
		{
			get { return _isAllowedWithEventTriggering; }
			set
			{
				if (value == _isAllowedWithEventTriggering) return;
				BeforePropertySet();
				_isAllowedWithEventTriggering = value;
				AfterPropertySet();
			}
		}

		[DataMember]
		public bool IsAllowedWithoutEventTriggering
		{
			get { return _isAllowedWithoutEventTriggering; }
			set
			{
				if (value == _isAllowedWithoutEventTriggering) return;
				BeforePropertySet();
				_isAllowedWithoutEventTriggering = value;
				AfterPropertySet();
			}
		}

		[DataMember]
		public bool PreservingRequired
		{
			get { return _preservingRequired; }
			set
			{
				if (value == _preservingRequired) return;
				BeforePropertySet();
				_preservingRequired = value;
				AfterPropertySet();
			}
		}
	}
}
