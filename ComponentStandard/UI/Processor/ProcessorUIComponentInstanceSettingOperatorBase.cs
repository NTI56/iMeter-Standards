using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Processor
{
	/// <summary>
	/// Instance setting operator for processor
	/// </summary>
	public abstract class ProcessorUIComponentInstanceSettingOperatorBase : UIComponentInstanceSettingOperatorBase
	{
		/// <summary>
		/// All inputs
		/// </summary>
		public abstract IEnumerable<ProcessorInputDefinition> Inputs { get; }

		/// <summary>
		/// All outputs
		/// </summary>
		public abstract IEnumerable<ProcessorOutputDefinition> Outputs { get; }
	}
}
