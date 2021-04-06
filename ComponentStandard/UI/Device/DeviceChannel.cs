using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Device
{
    public class DeviceChannel
    {
        /// <summary>
        /// Channel id
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Name for displaying
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Maximum reading block size of for one reading job
        /// </summary>
        public long MaximumReadingSize { get; }

        /// <summary>
        /// Maximum free spaces can be read and dropped for optimizing
        /// </summary>
        public long MaximumFreeSpacesForOptimizing { get; }

        /// <summary>
        /// The minimum precision of timer tick in milliseconds
        /// </summary>
        public int BaseTimerTick { get; }

        /// <summary>
        /// Whether need to check working load
        /// </summary>
        public bool ReadingWorkloadCheckingRequired { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Channel id</param>
        /// <param name="name">Name for displaying</param>
        /// <param name="maximumReadingSize">Maximum reading block size of for one reading job</param>
        /// <param name="maximumFreeSpacesForOptimizing">Maximum free spaces can be read and dropped for optimizing</param>
        /// <param name="baseTimerTick">The minimum precision of timer tick in milliseconds</param>
        /// <param name="readingWorkloadCheckingRequired">Whether need to check working load</param>
        public DeviceChannel(Guid id, string name, long maximumReadingSize, long maximumFreeSpacesForOptimizing, int baseTimerTick, bool readingWorkloadCheckingRequired)
        {
            Id = id;
            Name = name;
            MaximumReadingSize = maximumReadingSize;
            MaximumFreeSpacesForOptimizing = maximumFreeSpacesForOptimizing;
            BaseTimerTick = baseTimerTick;
            ReadingWorkloadCheckingRequired = readingWorkloadCheckingRequired;
        }


    }
}
