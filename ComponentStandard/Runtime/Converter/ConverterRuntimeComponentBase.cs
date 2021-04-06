using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.Runtime.Converter
{
    /// <summary>
    /// Runtime component base for converter. Non-generic type is only used as contract.
    /// </summary>
    public abstract class ConverterRuntimeComponentBase : IDisposableRuntime
    {
        /// <summary>
        /// Dispose this runtime.
        /// </summary>
        public abstract void DisposeRuntime();

        /// <summary>
        /// Convert specified output from binary data. Caution: Nothing should be changed within parameter data.
        /// </summary>
        /// <param name="data">Binary source data</param>
        /// <param name="start">Start index of the binary</param>
        /// <returns>Converted data.</returns>
        public abstract ValuePackageSlim<T> Convert<T>(byte[] data, int start);
    }
}
