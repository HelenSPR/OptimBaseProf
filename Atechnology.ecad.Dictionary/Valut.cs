// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.Valut
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using System;
using System.Data;

namespace Atechnology.ecad.Dictionary
{
    public class Valut : IConvertible
    {
        public string shortname = "";
        public int idvalut;
        public string name;
        private bool isShort;

        public Valut()
        {
        }

        public Valut(int i, string n)
        {
            this.idvalut = i;
            this.name = n;
        }

        public Valut(DataRow dr)
        {
            this.idvalut = (int)dr["idvalut"];
            if (dr.Table.Columns.Contains("name"))
                this.name = dr["name"].ToString();
            this.shortname = dr["shortname"].ToString();
            this.isShort = true;
        }

        public override string ToString()
        {
            if (!this.isShort)
                return this.name;
            return this.shortname;
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
            return this.idvalut;
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return (long)this.idvalut;
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
            if (!this.isShort)
                return this.name;
            return this.shortname;
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType(this.isShort ? (object)this.shortname : (object)this.name, conversionType);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return (ushort)0;
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(this.idvalut);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return 0UL;
        }
    }
}
