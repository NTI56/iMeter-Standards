using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ComponentStandard.UI
{
    /// <summary>
    /// Interface of a UI control
    /// </summary>
    public interface ICoeditorUIControl
    {
        /// <summary>
        /// Need to be set to true if setting is changed.
        /// </summary>
        bool IsSettingChanged { get; }

        /// <summary>
        /// Setting
        /// </summary>
        XmlDocument Setting { get; set; }

        /// <summary>
        /// When set to true, no data changing should be allowed.
        /// </summary>
        bool ReadOnly { get; set; }

        /// <summary>
        /// Minimum UI size
        /// </summary>
        Size MinimumSize { get; }
        /// <summary>
        /// Maximum UI size
        /// </summary>
        Size MaximumSize { get; }
        /// <summary>
        /// Preferred UI size
        /// </summary>
        Size PreferredSize { get; }

        /// <summary>
        /// Check whether all settings are valid
        /// </summary>
        /// <param name="popup">Allow window popped up</param>
        /// <returns>True: all settings are valid. False: otherwise.</returns>
        bool Validate(bool popup);
    }
}
