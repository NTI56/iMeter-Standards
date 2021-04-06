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
	public class ProcessorInput : DataItem
	{
		private Guid _inputDefinitionId;
		private bool _isLatestValuesRequired;
		private string _fullIdPath;

		[DataMember]
		public Guid InputDefinitionId
		{
			get { return _inputDefinitionId; }
			set
			{
				if (value.Equals(_inputDefinitionId)) return;
				BeforePropertySet();
				_inputDefinitionId = value;
				AfterPropertySet();
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
		public bool IsLatestValuesRequired
		{
			get { return _isLatestValuesRequired; }
			set
			{
				if (Equals(value, _isLatestValuesRequired)) return;
				BeforePropertySet();
				_isLatestValuesRequired = value;
				AfterPropertySet();
			}
		}

		//range for each index. e.g: 0-5,8,9-12
	}
}
