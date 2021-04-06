using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting.Device
{
	[Serializable]
	[DataContract]
	public class DeviceDefinition : Entity
	{
		private int _minimumTimerTick;
		private ExternalComponentPointer _device;

		[DataMember]
		public int MinimumTimerTick
		{
			get { return _minimumTimerTick; }
			set
			{
				if (value == _minimumTimerTick) return;
				BeforePropertySet();
				_minimumTimerTick = value;
				AfterPropertySet();
			}
		} //Backup from UI provided. Check if changed when editor openning.

		[DataMember]
		public ExternalComponentPointer Device
		{
			get { return _device; }
			set
			{
				if (Equals(value, _device)) return;
				BeforePropertySet();
				_device = value;
				AfterPropertySet();
			}
		}
	}
}
