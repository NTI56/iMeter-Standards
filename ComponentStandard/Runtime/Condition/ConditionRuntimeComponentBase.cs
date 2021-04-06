using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ComponentStandard.Runtime.Condition
{
    /// <summary>
    /// Runtime component base for condition. Non-generic type is only used as contract.
    /// </summary>
    public abstract class ConditionRuntimeComponentBase : IDisposableRuntime
    {
        /// <summary>
        /// Dispose this runtime.
        /// </summary>
        public abstract void DisposeRuntime();

        /// <summary>
        /// Check whether the data is fit the condition
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Result</returns>
        public abstract bool Check<T>(T value);
    }
}
