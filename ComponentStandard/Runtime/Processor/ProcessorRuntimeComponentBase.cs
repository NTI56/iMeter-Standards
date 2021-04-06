using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.Runtime.Processor
{
    /// <summary>
    /// Runtime component base for processor.
    /// </summary>
    public abstract class ProcessorRuntimeComponentBase : IDisposableRuntime
    {
        /// <summary>
        /// Import a value package reader with system built-in data type.
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="inputId">Id defined in processor input</param>
        /// <param name="dataType">Data type. StrongCustomizedType will not be used.</param>
        /// <param name="variableReader">Variable reader</param>
        public abstract void ImportValuePackageReader<T>(Guid inputId, DataType dataType, IVariableReader<T> variableReader);
        /// <summary>
        /// Import a value package reader with strong customized type.
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="inputId">Id defined in processor input</param>
        /// <param name="strongCustomizedTypeTypeId">Type id of the strong customized type specified</param>
        /// <param name="variableReader">Variable reader</param>
        public abstract void ImportValuePackageReader<T>(Guid inputId, Guid strongCustomizedTypeTypeId, IVariableReader<T> variableReader);

        /// <summary>
        /// Import value package readers with system built-in data type.
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="inputId">Id defined in processor input</param>
        /// <param name="dataType">Data type. StrongCustomizedType will not be used.</param>
        /// <param name="index">Index of the input linked to this reader</param>
        /// <param name="variableReader">Variable reader</param>
        public abstract void ImportValuePackageReader<T>(Guid inputId, DataType dataType, int[] index, IVariableReader<T> variableReader);
        /// <summary>
        /// Import value package readers with strong customized type.
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="inputId">Id defined in processor input</param>
        /// <param name="strongCustomizedTypeTypeId">Type id of the strong customized type specified</param>
        /// <param name="index">Index of the input linked to this reader</param>
        /// <param name="variableReader">Variable reader</param>
        public abstract void ImportValuePackageReader<T>(Guid inputId, Guid strongCustomizedTypeTypeId, int[] index, IVariableReader<T> variableReader);

        /// <summary>
        /// Import a value package writer.
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="outputId">Id defined in processor output</param>
        /// <param name="variableWriter">Variable writer.</param>
        public abstract void ImportValuePackageWriter<T>(Guid outputId, IVariableWriter<T> variableWriter);

        /// <summary>
        /// Import value package writers.
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="outputId">Id defined in processor output</param>
        /// <param name="index">Index of the output linked to this writer</param>
        /// <param name="variableWriter">Variable writer.</param>
        public abstract void ImportValuePackageWriter<T>(Guid outputId, int[] index, IVariableWriter<T> variableWriter);

        public event EventHandler<RefreshingRequestEventArgs> RefreshingRequested;

        /// <summary>
        /// Request system to call Refresh on the time specified.
        /// </summary>
        /// <param name="refreshingTime">Time to call Refresh</param>
        /// <param name="state">State object for callback</param>
        protected void RequestRefreshing(DateTime refreshingTime, object state)
        {
            RefreshingRequested?.Invoke(this, new RefreshingRequestEventArgs(refreshingTime, state));
        }

        /// <summary>
        /// Refresh requested by <code>RequestRefresing</code>
        /// </summary>
        /// <param name="currentSystemProcessingTime">Time of current processing data of system. This time will be used in data writer too.</param>
        /// <param name="state">State object provided by <code>RequestRefresing</code></param>
        public abstract void Refresh(DateTime currentSystemProcessingTime, object state);

        /// <summary>
        /// Initialize processor runtime. This method will be called immediately after the process runtime created.
        /// </summary>
        /// <param name="previousState">State data generated from the instance of processor runtime previously</param>
        /// <param name="waveStartTime">Start time of this processor wave</param>
        /// <param name="waveEndTime">End time of this processor wave</param>
        public abstract void Initialize(byte[] previousState, DateTime waveStartTime, DateTime waveEndTime);

        /// <summary>
        /// Let processor to finish all initialization procedures. This method will be called after all readers and writers passed in. Processor instance should be prepared to get data before this method finished.
        /// </summary>
        public abstract void GetReady();

        /// <summary>
        /// Generate state data of current instance of processor runtime, for next instance initializing.
        /// </summary>
        /// <returns>State data</returns>
        public abstract byte[] GenerateState();

        /// <summary>
        /// Dispose this runtime.
        /// </summary>
        public abstract void DisposeRuntime();

        /// <summary>
        /// Time of current processing data of system. This value is based on the sort time of crawler data.
        /// </summary>
        public DateTime CurrentSystemProcessingTime { get; set; }
    }
}
