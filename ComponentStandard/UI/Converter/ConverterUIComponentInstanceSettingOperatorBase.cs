using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Converter
{
    /// <summary>
    /// Instance setting operator for condition
    /// </summary>
    public abstract class ConverterUIComponentInstanceSettingOperatorBase : UIComponentInstanceSettingOperatorBase
    {
        /// <summary>
        /// Outputs of this converter
        /// </summary>
        public abstract IEnumerable<ConverterOutputDefinition> Outputs { get; }
        /// <summary>
        /// Required length of original byte array
        /// </summary>
        public abstract int RequiredByteArrayLength { get; }
    }
}
