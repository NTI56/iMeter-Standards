using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Device
{
	/// <summary>
	/// Instance setting operator for device
	/// </summary>
	public abstract class DeviceUIComponentInstanceSettingOperatorBase : UIComponentInstanceSettingOperatorBase
	{
		/// <summary>
		/// All channels defined.
		/// </summary>
		public abstract IEnumerable<DeviceChannel> Channels { get; }
		/// <summary>
		/// All blocks defined.
		/// </summary>
		public abstract IEnumerable<DeviceBlock> Blocks { get; }

		/// <summary>
		/// Check workloads
		/// </summary>
		/// <param name="items">Workloads</param>
		/// <returns>Result of checking</returns>
		public abstract IReadOnlyList<ReadingWorkloadCheckingFailed> CheckWorkload(
		   IReadOnlyList<ReadingWorkloadCheckingChannelItem> items);
	}
}
