using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{

    /// <summary>
    /// Slim value package. Contains only value, without Time nor Creator data. Non-generic type is only used as contract.
    /// </summary>
    public abstract class ValuePackageSlim
    {
        /// <summary>
        /// Boxed value
        /// </summary>
        public abstract object BoxedValue { get; }

        public abstract object CreateGenericInstance(IGenericCreator creator);

        /// <summary>
        /// Return the type of this data
        /// </summary>
        /// <returns>Type of inner data</returns>
        public abstract Type GetValueType();

        /// <summary>
        /// Serializing method of the inner data
        /// </summary>
        public SerializingMethodType SerializingMethodType { get; }
        /// <summary>
        /// Data type
        /// </summary>
        public DataType DataType { get; }
        /// <summary>
        /// Type id of the strong customized type specified. Effected only when DataType=StrongCustomizedType.
        /// </summary>
        public Guid? StrongCustomizedTypeTypeId { get; }

        internal ValuePackageSlim(SerializingMethodType serializingMethodType, DataType dataType, Guid? strongCustomizedTypeTypeId)
        {
            SerializingMethodType = serializingMethodType;
            DataType = dataType;
            StrongCustomizedTypeTypeId = strongCustomizedTypeTypeId;
        }
        public abstract SerializedData Serialize();
    }

    /// <summary>
    /// Slim value package. Contains only value, without Time nor Creator data.
    /// </summary>
    /// <typeparam name="T">Type of data</typeparam>
    public class ValuePackageSlim<T> : ValuePackageSlim
    {
        /// <summary>
        /// Inner data
        /// </summary>
        public T Value { get; }

        /// <summary>
        /// Boxed value
        /// </summary>
        public override object BoxedValue => Value;

        /// <summary>
        /// Return the type of this data
        /// </summary>
        /// <returns>Type of inner data</returns>
        public override Type GetValueType()
        {
            return Value.GetType();
        }

        public override bool Equals(object obj)
        {
            if (obj is ValuePackageSlim<T>)
                return Value.Equals(((ValuePackageSlim<T>)obj).Value);
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public sealed override object CreateGenericInstance(IGenericCreator creator)
        {
            return creator.CreateGenericInstance<T>();
        }

        public override SerializedData Serialize()
        {
            return SerializedData.Serialize(Value, DataType, SerializingMethodType);
        }
        /// <summary>
        /// Constructor of ValuePackageSlim.
        /// </summary>
        /// <param name="value">Value. Cannot be null</param>
        /// <param name="serializingMethodType">Supported serializing mode</param>
        /// <param name="dataType">Data type</param>
        /// <param name="strongCustomizedTypeTypeId">Type id of the strong customized type specified. Effected only when DataType=StrongCustomizedType.</param>
        public ValuePackageSlim(T value, SerializingMethodType serializingMethodType, DataType dataType, Guid? strongCustomizedTypeTypeId) : base(serializingMethodType, dataType, strongCustomizedTypeTypeId)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        /// <summary>
        /// Constructor of ValuePackageSlim for creating a default (empty) value of strong customized type specified. This instance can only be used for passing type. Do not construct this as a return of a Converter, or an output of a Processor.
        /// </summary>
        /// <param name="serializingMethodType">Supported serializing mode</param>
        /// <param name="strongCustomizedTypeTypeId">Type id of the strong customized type specified.</param>
        public ValuePackageSlim(SerializingMethodType serializingMethodType, Guid strongCustomizedTypeTypeId) : base (serializingMethodType, DataType.StrongCustomizedType, strongCustomizedTypeTypeId)
        {
            Value = default(T);
        }
    }
}
