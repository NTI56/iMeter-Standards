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
	public class NameOverride : OverrideBase
	{
		private string _name;

		[XmlIgnore]
		public override OverrideType Type => OverrideType.Name;

		[DataMember]
		public string Name
		{
			get { return _name; }
			set
			{
				if (value == _name) return;
				BeforePropertySet();
				_name = value;
				AfterPropertySet();
			}
		}
	}
}
