// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.Measure
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using System;

namespace Atechnology.ecad.Dictionary
{
    public class Measure : IConvertible
    {
        private int _idmeasure;
        private string _shortname;
        private string _name;

        public int Idmeasure
        {
            get
            {
                return this._idmeasure;
            }
            set
            {
                this._idmeasure = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string Shortname
        {
            get
            {
                return this._shortname;
            }
            set
            {
                this._shortname = value;
            }
        }

        public Measure()
        {
        }

        public Measure(int idmeasure, string name, string shortname)
        {
            this._idmeasure = idmeasure;
            this._name = name;
            this._shortname = shortname;
        }

        public override string ToString()
        {
            return this._shortname;
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
            return this._idmeasure;
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return (long)this._idmeasure;
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
            return this._shortname;
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((object)this._shortname, conversionType);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return (ushort)0;
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(this._idmeasure);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return 0UL;
        }
    }
}
