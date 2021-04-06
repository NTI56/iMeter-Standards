using NTI.iMeter.ProjectSetting.Override;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace NTI.iMeter.ProjectSetting.Type
{
	[XmlInclude(typeof(OverrideBase))]
	[XmlInclude(typeof(NameOverride))]
	[XmlInclude(typeof(DescriptionOverride))]
	[XmlInclude(typeof(FilterOverride))]
	[XmlInclude(typeof(AlerterOverride))]

	[XmlInclude(typeof(BasicTypeDefinition))]
	[XmlInclude(typeof(StructureTypeDefinition))]
	[XmlInclude(typeof(StrongCustomizedTypeDefinition))]
	[Serializable]
	[DataContract]
	public abstract class TypeDefinitionBase : Entity
	{
		private uint _memoryLength;

		[XmlIgnore]
		public abstract TypeDefinitionType Type { get; }

		[DataMember]
		public uint MemoryLength
		{
			get { return _memoryLength; }
			set
			{
				if (value == _memoryLength) return;
				BeforePropertySet();
				_memoryLength = value;
				AfterPropertySet();
			}
		} //0: Auto
	}
}
