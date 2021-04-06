using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Override
{
	[Serializable]
	[DataContract]
	public class AlerterOverride : OverrideBase
	{
		private AlerterComponentPointer _alerter;

		[XmlIgnore]
		public override OverrideType Type => OverrideType.Alerter;

		[DataMember]
		public AlerterComponentPointer Alerter
		{
			get { return _alerter; }
			set
			{
				if (Equals(value, _alerter)) return;
				BeforePropertySet();
				_alerter = value;
				AfterPropertySet();
			}
		}
	}
}
