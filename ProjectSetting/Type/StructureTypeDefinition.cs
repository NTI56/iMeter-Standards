using NTI.iMeter.ProjectSetting.Override;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Type
{
	[XmlInclude(typeof(NameOverride))]
	[XmlInclude(typeof(DescriptionOverride))]
	[XmlInclude(typeof(FilterOverride))]
	[XmlInclude(typeof(AlerterOverride))]
	[Serializable]
	[DataContract]
	public class StructureTypeDefinition : TypeDefinitionBase
	{
		private ObservableCollection<StructureMemberDefinition> _members = new ObservableCollection<StructureMemberDefinition>();
		private ObservableCollection<OverrideBase> _overrides = new ObservableCollection<OverrideBase>();

		[XmlIgnore]
		public override TypeDefinitionType Type => TypeDefinitionType.Structure;

		[DataMember]
		public ObservableCollection<StructureMemberDefinition> Members
		{
			get { return _members; }
			set
			{
				if (Equals(value, _members)) return;
				BeforePropertySet();
				_members = value;
				AfterPropertySet();
			}
		}

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
