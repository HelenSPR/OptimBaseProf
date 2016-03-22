using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace fo_library.Export.SupplyExporters
{
    internal interface IDocExporter
    {
        string DocName { get; set; }
        DateTime DocDate { get; set; }
        string FileDirecoryName { get; set; }


        void Export();

    }
}
