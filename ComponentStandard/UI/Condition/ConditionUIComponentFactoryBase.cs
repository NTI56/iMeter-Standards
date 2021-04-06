using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ComponentStandard.UI.Condition
{
    /// <summary>
    /// UI component factory for condition
    /// </summary>
    public abstract class ConditionUIComponentFactoryBase : UIComponentFactoryBase, ICreateControlWithTypeSpecified, ISupportedTypesForFiltering
    {
        public sealed override ComponentType ComponentType => ComponentType.Condition;

        /// <summary>
        /// Supported types for filtering
        /// </summary>
        public abstract IEnumerable<DataType> SupportedTypesForFiltering { get; }
        /// <summary>
        /// Supported strong customized types for filtering. To enable this, DataType.StrongCustomizedType must be provided in SupportedTypesForFiltering.
        /// </summary>
        public abstract IEnumerable<Guid> SupportedStrongCustomizedTypesForFiltering { get; }

        /// <summary>
        /// Create an operator based on setting generated from UI control
        /// </summary>
        /// <param name="setting">Setting generated from UI control</param>
        /// <returns>Operator</returns>
        public abstract ConditionUIComponentInstanceSettingOperatorBase CreateInstanceSettingOperator(
            XmlDocument setting);

        /// <summary>
        /// Create the UI control instance based on system built-in data type. Setting should be compatible with the data type specified.
        /// </summary>
        /// <param name="selectedDataType">Data type of user selected type or variable</param>
        /// <returns>UI control instance</returns>
        public abstract ICoeditorUIControl CreateControl(DataType selectedDataType);

        /// <summary>
        /// Create the UI control instance based on strong customized type. Setting should be compatible with the data type specified.
        /// </summary>
        /// <param name="selectedStrongCustomizedTypeTypeId">Type id of the strong customized type specified</param>
        /// <returns>UI control instance</returns>
        public abstract ICoeditorUIControl CreateControl(Guid selectedStrongCustomizedTypeTypeId);

        //public override sealed object CreateGenericInstance(IGenericCreator creator)
        //{
        //    return creator.CreateGenericInstance<ConditionUIComponentFactoryBase>();
        //}
    }
}