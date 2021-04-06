using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Processor
{
    /// <summary>
    /// Output event trigger mode
    /// </summary>
    public enum ProcessorOutputEventTriggeringMode
    {
        /// <summary>
        /// Allow user selection
        /// </summary>
        Default,
        /// <summary>
        /// Force to use event trigger while writting
        /// </summary>
        Forced,
        /// <summary>
        /// Force not to use event trigger while writting
        /// </summary>
        Avoided,
        /// <summary>
        /// Force to use event trigger while writting by default, allow user selection
        /// </summary>
        ForcedByDefault,
        /// <summary>
        /// Force not to use event trigger while writting by default, allow user selection
        /// </summary>
        AvoidedByDefault
    }
}
