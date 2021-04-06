using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    /// <summary>
    /// Variable writer. Non-generic type is only used as contract.
    /// </summary>
    public interface IVariableWriter
    {
    }

    /// <summary>
    /// Variable writer.
    /// </summary>
    /// <typeparam name="T">Type of data</typeparam>
    public interface IVariableWriter<T> : IVariableWriter
    {
        /// <summary>
        /// Whether writing with event triggering is allowed
        /// </summary>
        bool IsWritingWithEventTriggeringAllowed { get; }

        /// <summary>
        /// Whether writing without event triggering is allowed
        /// </summary>
        bool IsWritingWithoutEventTriggeringAllowed { get; }

        /// <summary>
        /// Write a data to variable. If <code>IsWritingWithEventTriggeringAllowed</code> is set to true, write with event triggering and return true (preferred); if <code>IsWritingWithoutEventTriggeringAllowed</code> is set to true, write without event triggering and return false; otherwise, throw an exception.
        /// </summary>
        /// <param name="value">Writing method</param>
        /// <returns></returns>
        bool WriteWithEventTriggeringPreferred(T value);

        /// <summary>
        /// Write a data to variable. If <code>IsWritingWithoutEventTriggeringAllowed</code> is set to true, write without event triggering and return true (preferred); if <code>IsWritingWithEventTriggeringAllowed</code> is set to true, write with event triggering and return false; otherwise, throw an exception.
        /// </summary>
        /// <param name="value">Writing method</param>
        /// <returns></returns>
        bool WriteWithoutEventTriggeringPreferred(T value);

        /// <summary>
        /// Write a data to variable with event triggering.
        /// </summary>
        /// <param name="value">Data</param>
        void WriteWithEventTriggering(T value);

        /// <summary>
        /// Write a data to variable without event triggering.
        /// </summary>
        /// <param name="value">Data</param>
        void WriteWithoutEventTriggering(T value);
    }
}
