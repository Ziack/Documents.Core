﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DocumentManager.Core.Schema
{
    [Serializable]
    public class SelectedItem : IConvertible, IXmlSerializable
    {
        public string Text { get; set; }
        public dynamic Value { get; set; }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(this.Value, provider);
        }

        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(this.Value, provider);
        }

        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(this.Text, provider);
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime(this.Value, provider);
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(this.Value, provider);
        }

        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(this.Value, provider);
        }

        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(this.Value, provider);
        }

        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(this.Value, provider);
        }

        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(this.Value, provider);
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(this.Value, provider);
        }

        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(this.Value, provider);
        }

        public string ToString(IFormatProvider provider)
        {
            return Convert.ToString(this.Text, provider);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotSupportedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(this.Value, provider);
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(this.Value, provider);
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(this.Value, provider);
        }

        public override string ToString()
        {
            return Convert.ToString(this.Value);
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            reader.Read();

            this.Text = reader.ReadElementContentAsString("Text", reader.NamespaceURI);
            this.Value = reader.ReadElementContentAsObject("Value", reader.NamespaceURI);

            reader.ReadEndElement();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("Text", Text);
            writer.WriteElementString("Value", Convert.ToString(Value));
        }
    }
}
