using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.Runtime.StrongCustomizedType
{
    /// <summary>
    /// Runtime component base for strong customized type.
    /// </summary>
    public abstract class StrongCustomizedTypeRuntimeComponentBase : IDisposableRuntime
    {
        /// <summary>
        /// Get a new value object.
        /// </summary>
        /// <returns>New value object</returns>
        public abstract ValuePackageSlim GetNewValueObject();
        /// <summary>
        /// Deserialize a new value object from string data.
        /// </summary>
        /// <param name="data">Serialized string data</param>
        /// <returns>New value object deserialized from string data</returns>
        public abstract ValuePackageSlim GetValueObjectFromSerializedData(string data);
        /// <summary>
        /// Deserialize a new value object form binary data.
        /// </summary>
        /// <param name="data">Serialized binary data</param>
        /// <returns>New value object deserialized from binary data</returns>
        public abstract ValuePackageSlim GetValueObjectFromSerializedData(byte[] data);

        /// <summary>
        /// Dispose this runtime.
        /// </summary>
        public abstract void DisposeRuntime();
    }
}
