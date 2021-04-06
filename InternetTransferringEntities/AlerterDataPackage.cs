using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NTI.iMeter.InternetTransferringEntities
{
    [Serializable]
    [DataContract]
    public class AlerterDataPackage
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public Guid? BatchId { get; set; }
        [DataMember]
        public DateTime? CaptureStarted { get; set; }
        [DataMember]
        public DateTime? CaptureEnded { get; set; }
        [DataMember]
        public string CrawlerName { get; set; }
        [DataMember]
        public string CrawlerClientName { get; set; }
        [DataMember]
        public Guid? CrawlerHostId { get; set; }
        [DataMember]
        public int? WeaverWave { get; set; }
        [DataMember]
        public DateTime TrustedTime { get; set; }
        [DataMember]
        public Guid? TrustedTimeSourceExpandedVariableId { get; set; }
        [DataMember]
        public string TrustedTimeSourceExpandedVariablePath { get; set; }
        [DataMember]
        public long? LocalTimeOffesetTick { get; set; }

        [DataMember]
        public Guid DatabaseValuePackageId { get; set; }
        [DataMember]
        public DataType DataType { get; set; }
        [DataMember]
        public Guid? StrongCustomizedTypeTypeId { get; set; }
        [DataMember]
        public string ExpandedPath { get; set; }
        [DataMember]
        public string ExpandedIdPath { get; set; }
        [DataMember]
        public Guid ExpandedVariableId { get; set; }
        [DataMember]
        public Guid? ProcessorId { get; set; }
        [DataMember]
        public Guid? ProcessorOutputId { get; set; }
        [DataMember]
        public string ProcessorOutputIndices { get; set; }
        [DataMember]
        public SerializedDataCompressed SerializedDataCompressed { get; set; }

        [IgnoreDataMember]
        public SerializedData SerializedData => SerializedDataCompressed?.ToSerializedData();

        public void SetSerializedDataCompressed(DataType dataType, SerializedData serializedData)
        {
            if (serializedData == null) SerializedDataCompressed = null;
            else SerializedDataCompressed = SerializedDataCompressed.FromSerializedData(serializedData, dataType);
        }

        [DataMember]
        public string Text { get; set; }


        static readonly string stringFormat = Properties.Resources.FormatAlertDataPackage;

        public override string ToString()
        {

            return string.Format(stringFormat, Id,
                BatchId,
                CaptureStarted, CaptureEnded, CrawlerName, CrawlerClientName, CrawlerHostId,
                WeaverWave,
                TrustedTime, TrustedTimeSourceExpandedVariableId, TrustedTimeSourceExpandedVariablePath, LocalTimeOffesetTick,
                DatabaseValuePackageId, DataType, StrongCustomizedTypeTypeId,
                ExpandedPath, ExpandedIdPath, ExpandedVariableId,
                ProcessorId, ProcessorOutputId, ProcessorOutputIndices,
                Text, SerializedDataCompressed);
        }
    }
}
