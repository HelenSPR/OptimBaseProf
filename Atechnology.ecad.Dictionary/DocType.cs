// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.DocType
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using System;
using System.Data;

namespace Atechnology.ecad.Dictionary
{
    public class DocType : IConvertible
    {
        public string Name;
        public string TableName;
        public DocumentType DocumentType;
        public int iddocappearance;

        public DocType(DataRow dr)
        {
            this.DocumentType = (DocumentType)dr["iddocappearance"];
            this.Name = dr["name"].ToString();
            this.TableName = dr["TableName"].ToString();
            this.iddocappearance = (int)dr["iddocappearance"];
        }

        public override string ToString()
        {
            return this.Name;
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return true;
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return (byte)0;
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            return ' ';
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            return DateTime.Now;
        }

        Decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return new Decimal(0);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return 0.0;
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return (short)0;
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return this.iddocappearance;
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return (long)this.iddocappearance;
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return (sbyte)0;
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return 0.0f;
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return this.Name;
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((object)this.Name, conversionType);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return (ushort)0;
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(this.iddocappearance);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return 0UL;
        }
    }
}
