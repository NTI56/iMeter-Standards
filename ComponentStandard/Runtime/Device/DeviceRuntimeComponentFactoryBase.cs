﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ComponentStandard.Runtime.Device
{
    /// <summary>
    /// Factory base for device runtime component
    /// </summary>
    public abstract class DeviceRuntimeComponentFactoryBase : RuntimeComponentFactoryBase
    {
        /// <summary>
        /// Create a runtime.
        /// </summary>
        /// <param name="setting">Setting generated by UI component</param>
        /// <returns>Device runtime</returns>
        public abstract DeviceRuntimeComponentBase CreateRuntime(XmlDocument setting);

        public sealed override ComponentType ComponentType => ComponentType.Device;
    }
}
