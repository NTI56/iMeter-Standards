using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    [Serializable]
    [DataContract]
    public class SerializedData
    {
        static T ConvertFromReferenceType<T>(object value) where T : class
        {
            if (value == DBNull.Value)
                return null;
            else
                return (T)value;
        }

        [DataMember]
        public long? RawBig; //BigInt
        [DataMember]
        public decimal? RawDecimal; //Decimal(20,0)
        [DataMember]
        public string RawString; //nvarchar(max)
        [DataMember]
        public byte[] RawData; //varbinary(max)
        [DataMember]
        public DateTime? RawTime; //DateTime2(7) This will only be set for data for writing

        public static SerializedData Serialize<T>(T value, DataType dataType, SerializingMethodType serializingMethodType)
        {
            switch (dataType)
            {
                case DataType.Boolean:
                    return new SerializedData() { RawBig = (value as bool?).Value ? 1 : 0 };
                case DataType.DateTime:
                    return new SerializedData() { RawTime = value as DateTime?, RawBig = (value as DateTime?).Value.ToBinary() };
                case DataType.Decimal:
                    {
                        var obj = (value as decimal?).Value;
                        return new SerializedData()
                        {
                            RawDecimal = obj,
                            RawString = obj.ToString()
                        };
                    }
                case DataType.Integer:
                    return new SerializedData() { RawBig = value as long? };
                case DataType.String:
                    return new SerializedData() { RawString = value as string };
                case DataType.UnsignedInteger:
                    return new SerializedData() { RawDecimal = value as ulong? };
                case DataType.StrongCustomizedType:
                    switch (serializingMethodType)
                    {
                        case SerializingMethodType.Binary:
                            return new SerializedData() { RawData = ((IStrongCustomizedTypeBinaryBasedSerializable)value).Serialize() };
                        case SerializingMethodType.String:
                            return new SerializedData() { RawString = ((IStrongCustomizedTypeStringBasedSerializable)value).Serialize() };
                        default:
                            throw new NotSupportedException();
                    }
                default:
                    throw new NotSupportedException();
            }
        }

        public static SerializedData FromDataReader(DbDataReader reader, int rawBigIndex, int rawDecimalIndex, int rawStringIndex, int rawDataIndex,
            DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Boolean:
                case DataType.DateTime:
                case DataType.Integer:
                    return new SerializedData() { RawBig = (long)reader[rawBigIndex] };
                case DataType.Decimal:
                case DataType.String:
                    return new SerializedData() { RawString = (string)reader[rawStringIndex] };
                case DataType.UnsignedInteger:
                    return new SerializedData() { RawDecimal = (decimal)reader[rawDecimalIndex] };
                case DataType.StrongCustomizedType:
                    return new SerializedData() { RawString = ConvertFromReferenceType<string>(reader[rawStringIndex]), RawData = ConvertFromReferenceType<byte[]>(reader[rawDataIndex]) };
                default:
                    throw new NotSupportedException();
            }

        }

    }
}
