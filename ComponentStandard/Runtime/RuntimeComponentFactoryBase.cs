using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.Runtime
{
    /// <summary>
    /// Runtime component factory base
    /// </summary>
    public abstract class RuntimeComponentFactoryBase
    {
        /// <summary>
        /// Component id. Should be unique and constant for each component.
        /// </summary>
        public abstract Guid Id { get; }
        /// <summary>
        /// Component type
        /// </summary>
        public abstract ComponentType ComponentType { get; }
        /// <summary>
        /// Supported setting versions. Set to null when all versions of settings are supported.
        /// </summary>
        public abstract IReadOnlyCollection<Guid> SupportedSettingVersions { get; }

        /// <summary>
        /// Whether this runtime is thread safe.
        /// </summary>
        public abstract bool IsThreadSafe { get; }
    }
}
