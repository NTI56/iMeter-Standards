using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.Runtime.StrongCustomizedType
{
    /// <summary>
    /// Optional interface for Strong Customized Type.
    /// Must be implemented only if this strong customized type is designed to act as time source for sequencers.
    /// </summary>
    public interface ISequencerTimeSource
    {
        /// <summary>
        /// Get datetime from the instance of strong customized type as trusted obtained time.
        /// </summary>
        /// <returns>Datetime to be set as trusted obtained time</returns>
        DateTime GetDateTime(); 
    }
}
