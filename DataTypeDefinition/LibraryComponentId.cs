using System;
using System.Runtime.Serialization;

namespace NTI.iMeter
{
	/// <summary>
	///     Reference a component which is represented uniquely by a combination of <see cref="LibraryId" /> and
	///     <see cref="ComponentId" />.
	/// </summary>
	[Serializable]
	[DataContract]
	public struct LibraryComponentId : IEquatable<LibraryComponentId>
	{
		public static bool operator ==(LibraryComponentId left, LibraryComponentId right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(LibraryComponentId left, LibraryComponentId right)
		{
			return !left.Equals(right);
		}

		/// <summary>
		///     Get the associated library ID for a component reference.
		/// </summary>
		[DataMember]
		public Guid LibraryId { get; }

		/// <summary>
		///     Get the associated component ID for a component reference.
		/// </summary>
		[DataMember]
		public Guid ComponentId { get; }

		public LibraryComponentId(Guid libraryId, Guid componentId)
		{
			LibraryId = libraryId;
			ComponentId = componentId;
		}

		/// <inheritdoc />
		public bool Equals(LibraryComponentId other)
		{
			return LibraryId.Equals(other.LibraryId) && ComponentId.Equals(other.ComponentId);
		}


		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return obj is LibraryComponentId other && Equals(other);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return LibraryId.GetHashCode() ^ ComponentId.GetHashCode();
		}

		/// <summary>
		/// Deconstruction method used for C# 7.0 deconstruction syntax.
		/// </summary>
		/// <param name="libraryId">The output library ID value.</param>
		/// <param name="componentId">The output component ID value.</param>
		public void Deconstruct(out Guid libraryId, out Guid componentId)
		{
			libraryId = LibraryId;
			componentId = ComponentId;
		}
	}
}