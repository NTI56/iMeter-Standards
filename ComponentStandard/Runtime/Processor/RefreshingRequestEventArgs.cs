using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.Runtime.Processor
{
    public class RefreshingRequestEventArgs : EventArgs
    {
        public DateTime RefreshingTime { get; }

        public object State { get; }

        public RefreshingRequestEventArgs(DateTime refreshingTime, object state) : base()
        {
            RefreshingTime = refreshingTime;
            State = state;
        }
    }
}
