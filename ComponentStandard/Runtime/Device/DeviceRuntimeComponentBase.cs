using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.Runtime.Device
{
    /// <summary>
    /// Runtime component base for device.
    /// </summary>
    public abstract class DeviceRuntimeComponentBase : IDisposableRuntime
    {
        /// <summary>
        /// Open a channel
        /// </summary>
        /// <param name="channelId">Channel id</param>
        /// <returns>Channel runtime component</returns>
        public abstract DeviceChannelRuntimeComponentBase OpenChannel(Guid channelId);

        /// <summary>
        /// Dispose this runtime.
        /// </summary>
        public abstract void DisposeRuntime();
    }
}
