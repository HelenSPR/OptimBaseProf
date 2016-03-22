// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.StoreDocType
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

namespace Atechnology.ecad.Dictionary
{
    public class StoreDocType
    {
        public string Name;
        public int typ;

        public StoreDocType(string _name, int _typ)
        {
            this.Name = _name;
            this.typ = _typ;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
