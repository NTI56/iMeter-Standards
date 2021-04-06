using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ComponentStandard.UI
{
    /// <summary>
    /// UI component factory base
    /// </summary>
    public abstract class UIComponentFactoryBase
    {
        /// <summary>
        /// Component id. Should be unique and constant for each component.
        /// </summary>
        public abstract Guid Id { get; }

        /// <summary>
        /// Component name
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// Component description
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Component type
        /// </summary>
        public abstract ComponentType ComponentType { get; }
        /// <summary>
        /// Address of image located in Resources for displaying as a big icon
        /// </summary>
        public abstract string BigPictureAddress { get; }
        /// <summary>
        /// Address of image located in Resources for displaying as a small icon at the beginning of detailed information line
        /// </summary>
        public abstract string SmallPictureAddress { get; }

        /// <summary>
        /// Runtime target
        /// </summary>
        public abstract RuntimeTargetPoint RuntimeTargetPoint { get; }

        /// <summary>
        /// Extra files for running UI of this component. Used for packaging process.
        /// </summary>
        public abstract IReadOnlyCollection<string> ExtraUIFiles { get; }

        /// <summary>
        /// Extra files for running this component. Used for packaging process.
        /// </summary>
        public abstract IReadOnlyCollection<string> ExtraRuntimeFiles { get; }

        /// <summary>
        /// All superseded components
        /// </summary>
        public abstract IReadOnlyCollection<LibraryComponentId> SupersededComponentIds { get; }

        /// <summary>
        /// Convert (upgrade) the setting from the superseded component to the current.
        /// </summary>
        /// <param name="supersededComponentId">The source of the setting</param>
        /// <param name="setting">Setting generated form the source component</param>
        /// <returns>Setting document converted for this component</returns>
        public abstract XmlDocument ConvertSetting(LibraryComponentId supersededComponentId, XmlDocument setting);

        /// <summary>
        /// Dispose the UI control created from CreateControl.
        /// </summary>
        /// <param name="control">UI control instance to be disposed</param>
        public abstract void DisposeControl(ICoeditorUIControl control);

        /// <summary>
        /// Get the brief information for displaying based on the setting provided.
        /// </summary>
        /// <param name="setting">Setting created by UI control</param>
        /// <returns>A string contains brief information</returns>
        public abstract string GetBrief(XmlDocument setting);

        /// <summary>
        /// Whether this component has a setting control. CreateControl method should be prepared while set to true.
        /// </summary>
        public abstract bool HasSettingControl { get; }

        /// <summary>
        /// Get the default setting document.
        /// </summary>
        /// <returns>Default setting document</returns>
        public abstract XmlDocument GetDefaultSetting();


        //public abstract object CreateGenericInstance(IGenericCreator creator);
    }
}
