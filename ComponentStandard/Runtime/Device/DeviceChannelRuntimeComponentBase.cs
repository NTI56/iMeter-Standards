using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.Runtime.Device
{
    /// <summary>
    /// Channel runtime component
    /// </summary>
    public abstract class DeviceChannelRuntimeComponentBase
    {
        /// <summary>
        /// Close channel.
        /// </summary>
        public abstract void CloseChannel();

        /// <summary>
        /// Fetch data from device.
        /// </summary>
        /// <param name="buffer">Buffer to write. Start index should be zero.</param>
        /// <param name="blockId">Block id of the device</param>
        /// <param name="offset">Offset of the block to read</param>
        /// <param name="length">Length of the data to read</param>
        /// <returns>Length of the data actually read</returns>
        public abstract int Fetch(byte[] buffer, Guid blockId, int offset, int length);

    }
}
