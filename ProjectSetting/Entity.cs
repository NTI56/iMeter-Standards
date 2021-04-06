using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting
{
	/// <summary>
	/// Provide basic implementation for <see cref="IEntity"/> interface with data related features.
	/// </summary>
	[Serializable]
	[DataContract]
	[DebuggerDisplay("Name = {" + nameof(Name) + "}")]
	public class Entity : DataItem, IEntity
	{
		private string _description;
		private Guid _id;
		private string _name;

		/// <summary>
		/// Generate a new ID.
		/// </summary>
		public Entity()
		{
			// Automatically generate a new ID.
			Id = Guid.NewGuid();
		}

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

		[DataMember]
		public Guid Id
		{
			get { return _id; }
			set
			{
				if (value.Equals(_id)) return;
				BeforePropertySet();
				_id = value;
				AfterPropertySet();
			}
		}

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
