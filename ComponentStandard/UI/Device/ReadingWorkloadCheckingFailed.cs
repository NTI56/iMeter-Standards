using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Device
{
    /// <summary>
    /// Checking failed item
    /// </summary>
    public class ReadingWorkloadCheckingFailed
    {
        /// <summary>
        /// Id from ReadingWorkloadCheckingChannelItem or ReadingWorkloadCheckingSequencerItem
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Level
        /// </summary>
        public ReadingWorkloadCheckingFailedLevel Level { get; }
        /// <summary>
        /// Cause
        /// </summary>
        public ReadingWorkloadCheckingFailedCause Cause { get; }
        /// <summary>
        /// Error code for displaying
        /// </summary>
        public int? ErrorCode { get; }
        /// <summary>
        /// Text for displaying
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id from ReadingWorkloadCheckingChannelItem or ReadingWorkloadCheckingSequencerItem</param>
        /// <param name="level">Level</param>
        /// <param name="cause">Cause</param>
        /// <param name="errorCode">Error code for displaying</param>
        /// <param name="text">Text for displaying</param>
        public ReadingWorkloadCheckingFailed(Guid id, ReadingWorkloadCheckingFailedLevel level, ReadingWorkloadCheckingFailedCause cause, int? errorCode, string text)
        {
            Id = id;
            Level = level;
            ErrorCode = errorCode;
            Text = text;
        }
    }
}
