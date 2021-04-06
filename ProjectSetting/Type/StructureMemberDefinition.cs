using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Type
{
	[Serializable]
	[DataContract]
	public class StructureMemberDefinition : DataItem
	{
		private Guid _typeId;
		private MemoryOffsetMode _memoryOffsetMode;
		private int _memoryOffset;
		private string _arraySetting;
		private Guid _id;

		[DataMember]
		public Guid Id
		{
			get { return _id; }
			set
			{
				if (value.Equals(_id)) return;
				_id = value;
				OnPropertyChanged(nameof(Id));
			}
		}

		[DataMember]
		public Guid TypeId
		{
			get { return _typeId; }
			set
			{
				if (value.Equals(_typeId)) return;
				BeforePropertySet();
				_typeId = value;
				AfterPropertySet();
			}
		}

		[DataMember]
		public MemoryOffsetMode MemoryOffsetMode
		{
			get { return _memoryOffsetMode; }
			set
			{
				if (value == _memoryOffsetMode) return;
				BeforePropertySet();
				_memoryOffsetMode = value;
				AfterPropertySet();
			}
		}

		[DataMember]
		public int MemoryOffset
		{
			set
			{
				if (value == _memoryOffset) return;
				BeforePropertySet();
				_memoryOffset = value;
				AfterPropertySet();
			}
			get { return _memoryOffset; }
		}

		[DataMember]
		public string ArraySetting
		{
			get { return _arraySetting; }
			set
			{
				if (value == _arraySetting) return;
				BeforePropertySet();
				_arraySetting = value;
				AfterPropertySet();
			}
		} //e.g.: -1-200,[5],301-350,400,405

		/// <inheritdoc />
		protected override void GetErrors(string propertyName, IDictionary<string, string> errors)
		{
			switch (propertyName)
			{
				case nameof(MemoryOffset):

					if (MemoryOffsetMode == MemoryOffsetMode.FromBeginning && MemoryOffset < 0)
					{
						errors.Add(ErrorKeys.MemoryOffsetCannotBeNegative, "The memory offset cannot be negative when the offset mode is from beginning.");
					}
					break;
			}
		}

		/// <summary>
		/// Provide Error keys string. This class is static.
		/// </summary>
		public static class ErrorKeys
		{
			/// <summary>
			/// Error raises when <see cref="MemoryOffset"/> is negative when <see cref="MemoryOffsetMode"/> is <see cref="MemoryOffsetMode.FromBeginning"/>.
			/// </summary>
			public const string MemoryOffsetCannotBeNegative = nameof(MemoryOffsetCannotBeNegative);
		}
	}
}
