using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    /// <summary>
    /// Variable reader. Non-generic type is only used as contract.
    /// </summary>
    public interface IVariableReader
    {
        /// <summary>
        /// Will be raised when new data arrived.
        /// </summary>
        event EventHandler ValuePackageChanged;

        /// <summary>
        /// Stop reading more data.
        /// </summary>
        void StopReading();
        /// <summary>
        /// Pause event until time specified. Time is system processing time.
        /// </summary>
        /// <param name="timeToResume">time specified</param>
        void PauseEventUntil(DateTime timeToResume);

        /// <summary>
        /// Data time offset. To set this value, use SetValueTimeOffset method.
        /// </summary>
        TimeSpan ValueTimeOffset { get; }

        /// <summary>
        /// Set the data offset by set the time of the next data.
        /// </summary>
        /// <remarks>
        /// The data from that time will be fed immediately, no matter whether the data is processed previously.
        /// </remarks> 
        /// <param name="timeSpan">The time offset of the next data. Set to 0 when need to reset the reader processing time to the same as system processing time.</param>
        void SetValueTimeOffset(TimeSpan timeSpan);
    }

    /// <summary>
    /// Variable reader.
    /// </summary>
    /// <typeparam name="T">Type of data</typeparam>
    public interface IVariableReader<T> : IVariableReader
    {
        /// <summary>
        /// Value package of data
        /// </summary>
        ValuePackage<T> ValuePackage { get; }

        /// <summary>
        /// Fetch data in time range.
        /// </summary>
        /// <param name="timePeriod">Time period for data fetching.
        /// <para />The <code>StartTime</code> will be set to the startup time of recording database if the requested time is sooner than.
        /// <para />The <code>EndTime</code> will be set to the shutdown time of recording database if the requested time is latter than.</param>
        /// <returns>Data packages in the time range specified</returns>
        IEnumerable<ValuePackage<T>> FetchValuePackages(TimePeriod timePeriod);

        /// <summary>
        /// Fetch latest data packages from different sources.
        /// </summary>
        /// <returns>Latest data packages from different sources</returns>
        IEnumerable<ValuePackage<T>> FetchLatestValuePackages();
    }
}
