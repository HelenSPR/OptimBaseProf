// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodBufferUtils
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using System.ComponentModel;

namespace Atechnology.ecad.Dictionary
{
    public class GoodBufferUtils
    {
        public enum GoodBufferType
        {
            [Description("резерв")]
            Reserve,
            [Description("в наличии")]
            Available,
            [Description("использован")]
            Used,
        }
    }
}
