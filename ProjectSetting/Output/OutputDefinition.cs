using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting.Output
{
	[Serializable]
	[DataContract]
	public class OutputDefinition : Entity
	{
		private string _fullIdPath;

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
	}
}
