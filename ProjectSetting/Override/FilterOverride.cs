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
	public class FilterOverride : OverrideBase
	{
		private ExternalComponentPointer _filter;

		[XmlIgnore]
		public override OverrideType Type => OverrideType.Filter;

		[DataMember]
		public ExternalComponentPointer Filter
		{
			get { return _filter; }
			set
			{
				if (Equals(value, _filter)) return;
				BeforePropertySet();
				_filter = value;
				AfterPropertySet();
			}
		}
	}
}
