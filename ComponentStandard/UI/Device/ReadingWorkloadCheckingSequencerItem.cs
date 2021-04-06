using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Device
{
    /// <summary>
    /// Workload for one sequencer
    /// </summary>
    public class ReadingWorkloadCheckingSequencerItem
    {
        /// <summary>
        /// Item id for result referring
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Timer tick of this sequencer
        /// </summary>
        public TimeSpan RefreshTime { get; }
        /// <summary>
        /// All lengths of all reading blocks within this sequencer
        /// </summary>
        public IReadOnlyList<int> Lengths { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Item id for result referring</param>
        /// <param name="refreshTime">Timer tick of this sequencer</param>
        /// <param name="lengths">All lengths of all reading blocks within this sequencer</param>
        public ReadingWorkloadCheckingSequencerItem(Guid id, TimeSpan refreshTime, params int[] lengths)
            : this(id, refreshTime, (IReadOnlyList<int>)lengths)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Item id for result referring</param>
        /// <param name="refreshTime">Timer tick of this sequencer</param>
        /// <param name="lengths">All lengths of all reading blocks within this sequencer</param>
        public ReadingWorkloadCheckingSequencerItem(Guid id, TimeSpan refreshTime, IReadOnlyList<int> lengths)
        {
            Id = id;
            RefreshTime = refreshTime;
            Lengths = lengths;
        }
    }
}
