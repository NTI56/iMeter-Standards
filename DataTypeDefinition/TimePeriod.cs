using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    [Serializable]
    [DataContract]
    public class TimePeriod
    {
        /// <summary>
        /// The start time of this period
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// The end time of this period
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
