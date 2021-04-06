using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Device
{
    public class DeviceBlock
    {
        /// <summary>
        /// Block id
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Name for displaying
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Minimum of the address
        /// </summary>
        public int MinimumAddress { get; }
        /// <summary>
        /// Length of the block
        /// </summary>
        public int Length { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Block id</param>
        /// <param name="name">Name for displaying</param>
        /// <param name="minimumAddress">Minimum of the address</param>
        /// <param name="length">Length of the block</param>
        public DeviceBlock(Guid id, string name, int minimumAddress, int length)
        {
            Id = id;
            Name = name;
            MinimumAddress = minimumAddress;
            Length = length;
        }
    }
}
