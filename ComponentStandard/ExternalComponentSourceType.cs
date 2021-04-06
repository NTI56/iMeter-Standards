using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard
{
    /// <summary>
    /// Component library source
    /// </summary>
    public enum ExternalComponentSourceType
    {
        /// <summary>
        /// From official. Fully trusted.
        /// </summary>
        Official,
        /// <summary>
        /// From end user. Can only be used within the projects of the same user.
        /// </summary>
        EndUser,
        /// <summary>
        /// From 3rd parties. Trusted but warning should be given.
        /// </summary>
        ThirdParty
    }
}
