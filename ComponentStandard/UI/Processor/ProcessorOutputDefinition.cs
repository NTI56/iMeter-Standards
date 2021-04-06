using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Processor
{
    /// <summary>
    /// Processor output
    /// </summary>
    public abstract class ProcessorOutputDefinition
    {
        /// <summary>
        /// Output id. Should be unique and constant for each output.
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
        /// Data type
        /// </summary>
        public abstract DataType DataType { get; }
        /// <summary>
        /// Strong customized type id. Effective only when DataType is set to StrongCustomizedType.
        /// </summary>
        public abstract Guid? StrongCustomizedTypeTypeId { get; }
        /// <summary>
        /// Array rank required. 0 for non-array.
        /// </summary>
        public abstract int ArrayRankRequired { get; }
        /// <summary>
        /// Check array length
        /// </summary>
        /// <param name="lengths">Length of each rank of the array. Null for non-array.</param>
        /// <returns></returns>
        public abstract bool CheckArrayLength(int[] lengths);
        /// <summary>
        /// Output event trigger mode
        /// </summary>
        public abstract ProcessorOutputEventTriggeringMode ProcessorOutputEventTriggeringMode { get; }

    }
}
