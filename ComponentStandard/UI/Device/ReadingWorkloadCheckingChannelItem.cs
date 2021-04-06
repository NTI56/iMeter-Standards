using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Device
{
    /// <summary>
    /// Workload for one channel
    /// </summary>
    public class ReadingWorkloadCheckingChannelItem
    {
        /// <summary>
        /// Item id for result referring
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Channel id
        /// </summary>
        public Guid ChannelId { get; }
        /// <summary>
        /// Sequncers linked to this channel
        /// </summary>
        public IReadOnlyList<ReadingWorkloadCheckingSequencerItem> Sequencers { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Item id for result referring</param>
        /// <param name="channelId">Channel id</param>
        /// <param name="sequencers">Sequncers linked to this channel</param>
        public ReadingWorkloadCheckingChannelItem(Guid id, Guid channelId,
            params ReadingWorkloadCheckingSequencerItem[] sequencers)
            : this(id, channelId, (IReadOnlyList<ReadingWorkloadCheckingSequencerItem>)sequencers)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Item id for result referring</param>
        /// <param name="channelId">Channel id</param>
        /// <param name="sequencers">Sequncers linked to this channel</param>
        public ReadingWorkloadCheckingChannelItem(Guid id, Guid channelId,
            IReadOnlyList<ReadingWorkloadCheckingSequencerItem> sequencers)
        {
            Id = id;
            ChannelId = channelId;
            Sequencers = sequencers;
        }
    }
}
