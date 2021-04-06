using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI
{
    /// <summary>
    /// Point to runtime component
    /// </summary>
    public class RuntimeTargetPoint
    {
        /// <summary>
        /// Library id
        /// </summary>
        public Guid LibraryId { get; }
        /// <summary>
        /// Component id
        /// </summary>
        public Guid ComponentId { get; }

        /// <summary>
        /// Version of setting structure. Null when setting version check is not required.
        /// </summary>
        public Guid? SettingVersion { get;}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="libraryId">Library id</param>
        /// <param name="componentId">Component id</param>
        /// <param name="settingVersion">Version of setting structure. Null when setting version check is not required.</param>
        public RuntimeTargetPoint(Guid libraryId, Guid componentId, Guid? settingVersion)
        {
            LibraryId = libraryId;
            ComponentId = componentId;
            SettingVersion = settingVersion;
        }
    }
}
