using NTI.iMeter.ProjectSetting.Override;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Variable
{
	[XmlInclude(typeof(NameOverride))]
	[XmlInclude(typeof(DescriptionOverride))]
	[XmlInclude(typeof(FilterOverride))]
	[XmlInclude(typeof(AlerterOverride))]
	[Serializable]
	[DataContract]
	public class VariableDefinition : Entity
	{
		private Guid _typeId;
		private MemoryOffsetMode _memoryOffsetMode;
		private Guid? _deviceId;
		private Guid? _memoryBlockId;
		private int _memoryOffset;
		private string _arraySetting;
		private ObservableCollection<OverrideBase> _overrides = new ObservableCollection<OverrideBase>();

		[DataMember]
		public Guid TypeId
		{
			get { return _typeId; }
			set
			{
				if (value.Equals(_typeId)) return;
				BeforePropertySet();
				_typeId = value;
				AfterPropertySet();
			}
		}

		[DataMember]
		public MemoryOffsetMode MemoryOffsetMode
		{
			get { return _memoryOffsetMode; }
			set
			{
				if (value == _memoryOffsetMode) return;
				BeforePropertySet();
				_memoryOffsetMode = value;
				AfterPropertySet();
			}
		}

		[DataMember]
		public Guid? DeviceId
		{
			get { return _deviceId; }
			set
			{
				if (value.Equals(_deviceId)) return;
				BeforePropertySet();
				_deviceId = value;
				AfterPropertySet();
			}
		}

		[DataMember]
		public Guid? MemoryBlockId
		{
			set
			{
				if (value.Equals(_memoryBlockId)) return;
				BeforePropertySet();
				_memoryBlockId = value;
				AfterPropertySet();
			}
			get { return _memoryBlockId; }
		}

		[DataMember]
		public int MemoryOffset
		{
			set
			{
				if (value == _memoryOffset) return;
				BeforePropertySet();
				_memoryOffset = value;
				AfterPropertySet();
			}
			get { return _memoryOffset; }
		}

		[DataMember]
		public string ArraySetting
		{
			get { return _arraySetting; }
			set
			{
				if (value == _arraySetting) return;
				BeforePropertySet();
				_arraySetting = value;
				AfterPropertySet();
			}
		} //e.g.: -1-200,[5],301-350,400,405

		[DataMember]
		public ObservableCollection<OverrideBase> Overrides
		{
			get { return _overrides; }
			set
			{
				if (Equals(value, _overrides)) return;
				BeforePropertySet();
				_overrides = value;
				AfterPropertySet();
			}
		}
	}
}
