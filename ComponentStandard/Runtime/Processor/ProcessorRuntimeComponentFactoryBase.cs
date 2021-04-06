﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ComponentStandard.Runtime.Processor
{
    /// <summary>
    /// Factory base for processor runtime component
    /// </summary>
    public abstract class ProcessorRuntimeComponentFactoryBase : RuntimeComponentFactoryBase
    {
        /// <summary>
        /// Create a runtime.
        /// </summary>
        /// <param name="setting">Setting generated by UI component</param>
        /// <returns>Processor runtime</returns>
        public abstract ProcessorRuntimeComponentBase CreateRuntime(XmlDocument setting);

        public sealed override ComponentType ComponentType => ComponentType.Processor;
    }
}