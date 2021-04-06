using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.StrongCustomizedType
{
    /// <summary>
    /// Instance setting operator for strong customized type
    /// </summary>
    public abstract class StrongCustomizedTypeUIComponentInstanceSettingOperatorBase : UIComponentInstanceSettingOperatorBase
    {
        /// <summary>
        /// Strong customized type id
        /// </summary>
        public abstract Guid TypeId { get; }

        /// <summary>
        /// Preferred converter UI component id in the same library
        /// </summary>
        public abstract Guid? PreferredConverterUIComponentId { get; }

        /// <summary>
        /// Supported serializing method
        /// </summary>
        public abstract StrongCustomizedTypeSerializationType SerializationType { get; }

        /// <summary>
        /// Whether this type can act as time source for sequencer. If true, ISequencerTimeSource must be implemented by the type class of this strong customized type.
        /// </summary>
        public abstract bool IsSequencerTimeSource { get; }
    }
}
