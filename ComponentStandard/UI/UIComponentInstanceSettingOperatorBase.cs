using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ComponentStandard.UI
{
    /// <summary>
    /// UI component instance setting operator base.
    /// </summary>
    public abstract class UIComponentInstanceSettingOperatorBase
    {
        /// <summary>
        /// Check whether all settings are valid
        /// </summary>
        /// <returns>True: all settings are valid. False: otherwise.</returns>
        public abstract bool ValidateSetting();
    }
}
