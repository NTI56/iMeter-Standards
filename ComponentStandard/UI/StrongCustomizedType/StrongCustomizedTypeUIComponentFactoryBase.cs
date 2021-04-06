using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ComponentStandard.UI.StrongCustomizedType
{
    /// <summary>
    /// UI component factory for strong customized type
    /// </summary>
    public abstract class StrongCustomizedTypeUIComponentFactoryBase : UIComponentFactoryBase, ICreateControlWithoutTypeSpecified
    {
        public sealed override ComponentType ComponentType => ComponentType.StrongCustomizedType;

        /// <summary>
        /// Create an operator based on setting generated from UI control
        /// </summary>
        /// <param name="setting">Setting generated from UI control</param>
        /// <returns>Operator</returns>
        public abstract StrongCustomizedTypeUIComponentInstanceSettingOperatorBase CreateInstanceSettingOperator(
            XmlDocument setting);


        /// <summary>
        /// Create the UI control instance
        /// </summary>
        /// <returns>UI control instance</returns>
        public abstract ICoeditorUIControl CreateControl();


        //public override sealed object CreateGenericInstance(IGenericCreator creator)
        //{
        //    return creator.CreateGenericInstance<StrongCustomizedTypeUIComponentFactoryBase>();
        //}
    }
}
