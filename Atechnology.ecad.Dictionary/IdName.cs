// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.IdName
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

namespace Atechnology.ecad.Dictionary
{
    public class IdName
    {
        public int Id;
        public string Name;

        public IdName(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
