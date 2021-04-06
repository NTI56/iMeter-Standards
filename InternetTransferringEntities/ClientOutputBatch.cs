using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace NTI.iMeter.InternetTransferringEntities
{
    [Serializable]
    [DataContract]
    [XmlInclude(typeof(CrawlerOutputBatch))]
    [XmlInclude(typeof(WeaverOutputBatch))]
    [XmlInclude(typeof(SerializedDataInteger))]
    [XmlInclude(typeof(SerializedDataUnsignedInteger))]
    [XmlInclude(typeof(SerializedDataString))]
    [XmlInclude(typeof(SerializedDataBoolean))]
    [XmlInclude(typeof(SerializedDataDateTime))]
    [XmlInclude(typeof(SerializedDataDecimal))]
    [XmlInclude(typeof(SerializedDataStrongCustomizedType))]
    public abstract class ClientOutputBatch
    {
        //[DataMember]
        //public Guid Id { get; set; }

        [DataMember]
        public DateTime TrustedTime { get; set; }

        [DataMember]
        public DateTime SortTime { get; set; }
        [DataMember]
        public int BackdatedSortNumber { get; set; }

        [DataMember]
        public ClientOutputData[] DataPackages { get; set; }
    }

    [Serializable]
    [DataContract]
    public class CrawlerOutputBatch : ClientOutputBatch
    {
        [DataMember]
        public DateTime CaptureStarted { get; set; }
        [DataMember]
        public DateTime CaptureEnded { get; set; }
        [DataMember]
        public long? CrawlerLocalTimeOffsetTick { get; set; }

        [DataMember]
        public string CrawlerName { get; set; }
        [DataMember]
        public string CrawlerClientName { get; set; }
        [DataMember]
        public Guid CrawlerHostId { get; set; }

        [DataMember]
        public Guid? TrustedTimeSourceExpandedVariableId { get; set; }
        [DataMember]
        public string TrustedTimeSourceExpandedVariablePath { get; set; }
    }

    [Serializable]
    [DataContract]
    public class WeaverOutputBatch : ClientOutputBatch
    {
        [DataMember]
        public int WeaverWave { get; set; }
    }
}
