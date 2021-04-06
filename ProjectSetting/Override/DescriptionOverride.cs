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
	public class DescriptionOverride : OverrideBase
	{
		private string _description;

		[XmlIgnore]
		public override OverrideType Type => OverrideType.Description;

		[DataMember]
		public string Description
		{
			get { return _description; }
			set
			{
				if (value == _description) return;
				BeforePropertySet();
				_description = value;
				AfterPropertySet();
			}
		}
	}
}
