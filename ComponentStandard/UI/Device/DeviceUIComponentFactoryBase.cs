using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ComponentStandard.UI.Device
{
    /// <summary>
    /// UI component factory for device
    /// </summary>
    public abstract class DeviceUIComponentFactoryBase : UIComponentFactoryBase, ICreateControlWithoutTypeSpecified
    {

        public sealed override ComponentType ComponentType => ComponentType.Device;

        /// <summary>
        /// Create an operator based on setting generated from UI control
        /// </summary>
        /// <param name="setting">Setting generated from UI control</param>
        /// <returns>Operator</returns>
        public abstract DeviceUIComponentInstanceSettingOperatorBase CreateInstanceSettingOperator(
                          XmlDocument setting);

        /// <summary>
        /// Create the UI control instance
        /// </summary>
        /// <returns>UI control instance</returns>
        public abstract ICoeditorUIControl CreateControl();

        //public override sealed object CreateGenericInstance(IGenericCreator creator)
        //{
        //    return creator.CreateGenericInstance<DeviceUIComponentFactoryBase>();
        //}
    }
}
