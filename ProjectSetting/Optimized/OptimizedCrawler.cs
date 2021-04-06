using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Optimized
{
    [Serializable]
    [DataContract]
    public class OptimizedCrawler
    {
        [DataMember]
        public string CrawlerName { get; set; }

        [DataMember]
        public Collection<ChannelReadingJob> ChannelReadingJobs { get; set; } = new Collection<ChannelReadingJob>();
    }
}
