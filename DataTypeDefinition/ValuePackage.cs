using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    /// <summary>
    /// One value of a Variable. Non-generic type is only used as contract.
    /// </summary>
    public abstract class ValuePackage
    {
        /// <summary>
        /// Id of value package. Use this to avoid processing duplicate data package.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Obtained time. Source is set by sequencer.
        /// </summary>
        public DateTime TrustedObtainedTime { get; }
        /// <summary>
        /// Starting time of this capturing job in Crawler. None for data not captured by Crawler.
        /// </summary>
        public DateTime? CrawlerCapturingStartTime { get; }
        /// <summary>
        /// End time of this capturing job in Crawler. None for data not captured by Crawler.
        /// </summary>
        public DateTime? CrawlerCapturingEndTime { get; }
        /// <summary>
        /// Crawler time offset from the time server
        /// </summary>
        public long? CrawlerLocalTimeOffsetTick { get; }

        /// <summary>
        /// Crawler name. None for data not captured by Crawler.
        /// </summary>
        public string CrawlerName { get; }

        /// <summary>
        /// Crawler client name. None for data not captured by Crawler.
        /// </summary>
        public string CrawlerClientName { get; }

        /// <summary>
        /// Crawler host id. None for data not captured by Crawler.
        /// </summary>
        public Guid? CrawlerHostId { get; }
        
        /// <summary>
        /// Wave of the weaver. None for data not created from weaver.
        /// </summary>
        public int? WeaverWave { get; }

        /// <summary>
        /// Id of the processor. None for data not created from weaver.
        /// </summary>
        public Guid? ProcessorId { get; set; }

        /// <summary>
        /// Id of the processor output. None for data not created from weaver.
        /// </summary>
        public Guid? ProcessorOutputId { get; set; }

        /// <summary>
        /// Text based indicator of the processor output indices. None for data not created from weaver.
        /// </summary>
        public string ProcessorOutputIndices { get; set; }

        /// <summary>
        /// Type of creator
        /// </summary>
        public ValuePackageCreatorType CreatorType { get; }

        /// <summary>
        /// Boxed value
        /// </summary>
        public object BoxedValue => ValuePackageSlimNonGeneric.BoxedValue;

        /// <summary>
        /// Return the type of this data
        /// </summary>
        /// <returns>Type of inner data</returns>
        public Type GetValueType() => ValuePackageSlimNonGeneric.GetValueType();

        /// <summary>
        /// Serializing method of the inner data
        /// </summary>
        public SerializingMethodType SerializingMethodType => ValuePackageSlimNonGeneric.SerializingMethodType;

        public abstract ValuePackageSlim ValuePackageSlimNonGeneric { get; }

        internal ValuePackage(Guid id, DateTime trustedObtainedTime, DateTime crawlerCapturingStartTime, DateTime crawlerCapturingEndTime, long? crawlerLocalTimeOffsetTick, 
            string crawlerName, string crawlerClientName, Guid crawlerHostId)
        {
            Id = id;
            TrustedObtainedTime = trustedObtainedTime;
            CrawlerCapturingStartTime = crawlerCapturingStartTime;
            CrawlerCapturingEndTime = crawlerCapturingEndTime;
            CrawlerLocalTimeOffsetTick = crawlerLocalTimeOffsetTick;
            CrawlerName = crawlerName;
            CrawlerClientName = crawlerClientName;
            CrawlerHostId = crawlerHostId;
            CreatorType = ValuePackageCreatorType.Crawler;
        }

        internal ValuePackage(Guid id, DateTime trustedObtainedTime, int? weaverWave, Guid processorId, Guid processorOutputId, string processorOutputIndices)
        {
            Id = id;
            TrustedObtainedTime = trustedObtainedTime;
            WeaverWave = weaverWave;
            ProcessorId = processorId;
            ProcessorOutputId = processorOutputId;
            ProcessorOutputIndices = processorOutputIndices;
            CreatorType = ValuePackageCreatorType.Weaver;
        }

        internal ValuePackage()
        {
            Id = Guid.Empty;
            CreatorType = ValuePackageCreatorType.System;
        }
    }

    /// <summary>
    /// One value of a Variable.
    /// </summary>
    /// <typeparam name="T">Type of data</typeparam>
    public class ValuePackage<T> : ValuePackage
    {
        public ValuePackageSlim<T> ValuePackageSlim { get; }

        /// <summary>
        /// Value
        /// </summary>
        public T Value => ValuePackageSlim.Value;

        /// <summary>
        /// Constructor of ValuePackage for empty value.
        /// </summary>
        public ValuePackage() : base()
        { }

        /// <summary>
        /// Constructor of ValuePackage for Crawler created data.
        /// </summary>
        /// <param name="id">Id of value package</param>
        /// <param name="valuePackageSlim">Value package slim</param>
        /// <param name="trustedObtainedTime">Obtained time</param>
        /// <param name="crawlerCapturingStartTime">Starting time of this capturing job in Crawler</param>
        /// <param name="crawlerCapturingEndTime">End time of this capturing job in Crawler</param>
        /// <param name="crawlerName">Crawler name</param>
        /// <param name="crawlerClientName">Crawler client name</param>
        /// <param name="crawlerHostId">Crawler host id</param>
        /// <param name="crawlerLocalTimeOffsetTick">Crawler time offset from the time server</param>
        public ValuePackage(Guid id, ValuePackageSlim<T> valuePackageSlim,
            DateTime trustedObtainedTime, DateTime crawlerCapturingStartTime, DateTime crawlerCapturingEndTime, long? crawlerLocalTimeOffsetTick,
            string crawlerName, string crawlerClientName, Guid crawlerHostId)
            : base(id, trustedObtainedTime, crawlerCapturingStartTime, crawlerCapturingEndTime, crawlerLocalTimeOffsetTick, crawlerName, crawlerClientName, crawlerHostId)
        {
            ValuePackageSlim = valuePackageSlim;
        }

        /// <summary>
        /// Constructor of ValuePackage for Weaver created data.
        /// </summary>
        /// <param name="id">Id of value package</param>
        /// <param name="valuePackageSlim">Value package slim</param>
        /// <param name="trustedObtainedTime">Obtained time</param>
        /// <param name="weaverWave">Wave of the weaver</param>
        /// <param name="processorId">Id of the processor</param>
        /// <param name="processorOutputId">Id of the processor output</param>
        /// <param name="processorOutputIndices">Text based indicator of the processor output indices</param>
        public ValuePackage(Guid id, ValuePackageSlim<T> valuePackageSlim,
            DateTime trustedObtainedTime, int weaverWave, Guid processorId, Guid processorOutputId, string processorOutputIndices)
            : base(id, trustedObtainedTime, weaverWave, processorId, processorOutputId, processorOutputIndices)
        {
            ValuePackageSlim = valuePackageSlim;
        }

        public override ValuePackageSlim ValuePackageSlimNonGeneric => ValuePackageSlim;

        public override bool Equals(object obj)
        {
            if (obj is ValuePackage<T>)
            {
                var target = (ValuePackage<T>)obj;
                return TrustedObtainedTime == target.TrustedObtainedTime && Value.Equals(target.Value);
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Time: {0:F}\nValue: {1}\n", TrustedObtainedTime, Value);
        }
    }
}
