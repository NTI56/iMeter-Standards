using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace NTI.iMeter.InternetTransferringEntities
{
    [Serializable]
    [DataContract]
    [XmlInclude(typeof(SerializedDataInteger))]
    [XmlInclude(typeof(SerializedDataUnsignedInteger))]
    [XmlInclude(typeof(SerializedDataString))]
    [XmlInclude(typeof(SerializedDataBoolean))]
    [XmlInclude(typeof(SerializedDataDateTime))]
    [XmlInclude(typeof(SerializedDataDecimal))]
    [XmlInclude(typeof(SerializedDataStrongCustomizedType))]
    public abstract class SerializedDataCompressed
    {
        public abstract SerializedData ToSerializedData();
        public abstract override string ToString();
        public abstract byte[] ToRaw();

        static T ConvertFromReferenceType<T>(object value) where T : class
        {
            if (value == DBNull.Value)
                return null;
            else
                return (T)value;
        }

        public static SerializedDataCompressed FromSerializedData(SerializedData data, DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Boolean:
                    return new SerializedDataBoolean() { Boolean = data.RawBig == 1 };
                case DataType.DateTime:
                    return new SerializedDataDateTime() { DateTime = DateTime.FromBinary(data.RawBig.Value) };
                case DataType.Decimal:
                    return new SerializedDataDecimal() { Decimal = decimal.Parse(data.RawString) };
                case DataType.Integer:
                    return new SerializedDataInteger() { Long = data.RawBig.Value };
                case DataType.String:
                    return new SerializedDataString() { String = data.RawString };
                case DataType.UnsignedInteger:
                    return new SerializedDataUnsignedInteger() { Decimal = data.RawDecimal.Value };
                case DataType.StrongCustomizedType:
                    return new SerializedDataStrongCustomizedType() { SerializedByteArray = data.RawData, SerializedString = data.RawString };
                default:
                    throw new NotSupportedException();
            }
        }

        public static SerializedDataCompressed FromDataReader(DbDataReader reader, int rawBigIndex, int rawDecimalIndex, int rawStringIndex, int rawDataIndex,
            DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Boolean:
                    return new SerializedDataBoolean() { Boolean = (long)reader[rawBigIndex] == 1 };
                case DataType.DateTime:
                    return new SerializedDataDateTime() { DateTime = DateTime.FromBinary((long)reader[rawBigIndex]) };
                case DataType.Decimal:
                    return new SerializedDataDecimal() { Decimal = decimal.Parse((string)reader[rawStringIndex]) };
                case DataType.Integer:
                    return new SerializedDataInteger() { Long = (long)reader[rawBigIndex] };
                case DataType.String:
                    return new SerializedDataString() { String = (string)reader[rawStringIndex] };
                case DataType.UnsignedInteger:
                    return new SerializedDataUnsignedInteger() { Decimal = (decimal)reader[rawDecimalIndex] };
                case DataType.StrongCustomizedType:
                    return new SerializedDataStrongCustomizedType() { SerializedString = ConvertFromReferenceType<string>(reader[rawStringIndex]), SerializedByteArray = ConvertFromReferenceType<byte[]>(reader[rawDataIndex]) };
                default:
                    throw new NotSupportedException();
            }
        }
    }

    [Serializable]
    [DataContract]
    public class SerializedDataInteger : SerializedDataCompressed
    {
        [DataMember]
        public long Long { get; set; }

        public override byte[] ToRaw()
        {
            return BitConverter.GetBytes(Long);
        }

        public override SerializedData ToSerializedData()
        {
            return new SerializedData() { RawBig = Long };
        }

        static readonly string stringFormat = Properties.Resources.FormatSerializedInteger;
        public override string ToString()
        {
            return string.Format(stringFormat, Long);
        }
    }

    [Serializable]
    [DataContract]
    public class SerializedDataUnsignedInteger : SerializedDataCompressed
    {
        [DataMember]
        public decimal Decimal { get; set; }

        public override byte[] ToRaw()
        {
            ulong value = (ulong)Decimal;
            return BitConverter.GetBytes(value);
        }

        public override SerializedData ToSerializedData()
        {
            return new SerializedData() { RawDecimal = Decimal };
        }

        static readonly string stringFormat = Properties.Resources.FormatSerializedUnsignedInteger;
        public override string ToString()
        {
            ulong value = (ulong)Decimal;
            return string.Format(stringFormat, value);
        }
    }

    [Serializable]
    [DataContract]
    public class SerializedDataString : SerializedDataCompressed
    {
        [DataMember]
        public string String { get; set; }

        public override byte[] ToRaw()
        {
            return Encoding.Unicode.GetBytes(String);
        }

        public override SerializedData ToSerializedData()
        {
            return new SerializedData() { RawString = String };
        }

        static readonly string stringFormat = Properties.Resources.FormatSerializedString;
        public override string ToString()
        {
            return string.Format(stringFormat, String);
        }
    }

    [Serializable]
    [DataContract]
    public class SerializedDataBoolean : SerializedDataCompressed
    {
        [DataMember]
        public bool Boolean { get; set; }

        public override byte[] ToRaw()
        {
            if (Boolean) return new byte[] { 1 };
            else return new byte[] { 0 };
        }

        public override SerializedData ToSerializedData()
        {
            return new SerializedData() { RawBig = Boolean ? 1 : 0 };
        }

        static readonly string stringTrue = Properties.Resources.ValueSerializedBooleanTrue;
        static readonly string stringFalse = Properties.Resources.ValueSerializedBooleanFalse;

        public override string ToString()
        {
            if (Boolean) return stringTrue;
            else return stringFalse;
        }
    }

    [Serializable]
    [DataContract]
    public class SerializedDataDateTime : SerializedDataCompressed
    {
        [DataMember]
        public DateTime DateTime { get; set; }

        public override byte[] ToRaw()
        {
            return BitConverter.GetBytes(DateTime.ToBinary());
        }

        public override SerializedData ToSerializedData()
        {
            return new SerializedData() { RawTime = DateTime, RawBig = DateTime.ToBinary() };
        }

        static readonly string stringFormat = Properties.Resources.FormatSerializedDateTime;
        public override string ToString()
        {
            return string.Format(stringFormat, DateTime);
        }
    }

    [Serializable]
    [DataContract]
    public class SerializedDataDecimal : SerializedDataCompressed
    {
        [DataMember]
        public decimal Decimal { get; set; }

        public override byte[] ToRaw()
        {
            var total = decimal.GetBits(Decimal);
            byte[] result = new byte[16];
            var x = BitConverter.GetBytes(total[0]);
            Array.Copy(x, result, 4);
            x = BitConverter.GetBytes(total[1]);
            Array.Copy(x, 0, result, 4, 4);
            x = BitConverter.GetBytes(total[2]);
            Array.Copy(x, 0, result, 8, 4);
            x = BitConverter.GetBytes(total[3]);
            Array.Copy(x, 0, result, 12, 4);
            return result;
        }

        public override SerializedData ToSerializedData()
        {
            return new SerializedData() { RawDecimal = Decimal, RawString = Decimal.ToString() };
        }

        static readonly string stringFormat = Properties.Resources.FormatSerializedDecimal;
        public override string ToString()
        {
            return string.Format(stringFormat, Decimal);
        }
    }

    [Serializable]
    [DataContract]
    public class SerializedDataStrongCustomizedType : SerializedDataCompressed
    {
        [DataMember]
        public string SerializedString { get; set; }
        [DataMember]
        public byte[] SerializedByteArray { get; set; }
        public override SerializedData ToSerializedData()
        {
            return new SerializedData() { RawString = SerializedString, RawData = SerializedByteArray };
        }

        static readonly string stringFormat = Properties.Resources.FormatSerializedStrongCustomizedTypeInString;
        static readonly string stringByteArray = Properties.Resources.ValueSerializedStrongCustomizedTypeInByteArray;
        static readonly string stringEmpty = Properties.Resources.ValueSerializedStrongCustomizedTypeEmpty;

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(SerializedString))
            {
                return string.Format(stringFormat, SerializedString);
            }
            else if (SerializedByteArray != null && SerializedByteArray.Length > 0)
            {
                return stringByteArray;
            }
            else
            {
                return stringEmpty;
            }
        }

        public override byte[] ToRaw()
        {
            if (!string.IsNullOrEmpty(SerializedString))
            {
                return Encoding.Unicode.GetBytes(SerializedString);
            }
            else if (SerializedByteArray != null && SerializedByteArray.Length > 0)
            {
                return SerializedByteArray;
            }
            else
            {
                return null;
            }
        }
    }
}
