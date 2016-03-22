using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FastExport
{
    internal interface IDocExporter
    {
         string DocName { get; set; }
         DateTime DocDate { get; set; }
         string FileDirecoryName { get; set; }


         void Export();

    }
}
