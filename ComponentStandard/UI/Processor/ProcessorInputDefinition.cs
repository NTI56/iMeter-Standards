using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Processor
{
	/// <summary>
	/// Processor input
	/// </summary>
	public abstract class ProcessorInputDefinition
	{
		/// <summary>
		/// Input id. Should be unique and constant for each input.
		/// </summary>
		public abstract Guid Id { get; }
		/// <summary>
		/// Output name
		/// </summary>
		public abstract string Name { get; }
		/// <summary>
		/// Output description
		/// </summary>
		public abstract string Description { get; }

		/// <summary>
		/// Whether this input is must required.
		/// </summary>
		public abstract bool Required { get; }

		/// <summary>
		/// Supported data types
		/// </summary>
		public abstract IEnumerable<DataType> SupportedTypes { get; }
		/// <summary>
		/// Supported strong customized types. To enable this, DataType.StrongCustomizedType must be provided in SupportedTypes.
		/// </summary>
		public abstract IEnumerable<Guid> SupportedStrongCustomizedTypes { get; }
		/// <summary>
		/// Array rank required. 0 for non-array.
		/// </summary>
		public abstract int ArrayRankRequired { get; }

		/// <summary>
		/// User selected data type for this instance of component. This will be specified before calling CheckArrayLength. Will set to null when no input variable is selected.
		/// </summary>
		public abstract DataType? SelectedDataType { get; set; }

		/// <summary>
		/// User selected strong customized type id for this instance of component. This will be specified before calling CheckArrayLength only when SelectedDataType is set to StrongCustomizedType.
		/// </summary>
		public abstract Guid? SelectedStrongCustomizedTypeTypeId { get; set; }

        /// <summary>
        /// Check array length
        /// </summary>
        /// <param name="lengths">Length of each rank of the array. Null for non-array.</param>
        /// <returns></returns>
        public abstract bool CheckArrayLength(int[] lengths);

		/// <summary>
		/// Whether latter data processing is required.
		/// </summary>
		public abstract bool IsLatterDataProcessingSupported { get; }

		/// <summary>
		/// Maximum time span required for latter data processing
		/// </summary>
		public abstract TimeSpan LatterDataProcessingMaxTimeSpan { get; }


		/// <summary>
		/// Whether latest value packages should be prepared for this processor
		/// </summary>
		public abstract bool IsLatestValuesRequired { get; }
	}
}
