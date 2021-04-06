using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Override
{
	[XmlInclude(typeof(NameOverride))]
	[XmlInclude(typeof(DescriptionOverride))]
	[XmlInclude(typeof(FilterOverride))]
	[XmlInclude(typeof(AlerterOverride))]
	[Serializable]
	[DataContract]
	public abstract class OverrideBase : DataItem
	{
		private string _idPath;

		[XmlIgnore]
		public abstract OverrideType Type { get; }

		[DataMember]
		public string IdPath
		{
			get { return _idPath; }
			set
			{
				if (value == _idPath) return;
				BeforePropertySet();
				_idPath = value;
				AfterPropertySet();
			}
		} //memberid.memberid[1-3,8,10-12].memberid[].memberid.....memberid   ([] = all members)
	}
}
