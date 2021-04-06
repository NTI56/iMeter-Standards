using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    /// <summary>
    /// The creator of each value package
    /// </summary>
    [DataContract]
    public enum ValuePackageCreatorType
    {
        /// <summary>
        /// Value package which is created by one processor
        /// </summary>
        [EnumMember]
        Weaver,
        /// <summary>
        /// Value package which is created by one crawler
        /// </summary>
        [EnumMember]
        Crawler,
        /// <summary>
        /// Value package which is created by system
        /// </summary>
        [EnumMember]
        System
    }
}
