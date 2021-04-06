using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI
{
    public interface ISupportedTypesForFiltering
    { 
        /// <summary>
        /// Supported types for filtering
        /// </summary>
        IEnumerable<DataType> SupportedTypesForFiltering { get; }
        /// <summary>
        /// Supported strong customized types for filtering. To enable this, DataType.StrongCustomizedType must be provided in SupportedTypesForFiltering.
        /// </summary>
        IEnumerable<Guid> SupportedStrongCustomizedTypesForFiltering { get; }
    }
}
