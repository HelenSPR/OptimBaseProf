using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace fo_library.Export.SupplyExporters
{
    internal abstract class SupplyExporterExcel : IDocExporter
    {
        protected int supplyDocumentId;
        internal SupplyExporterExcel(int supplyDocId)
        {
            supplyDocumentId = supplyDocId;
        }




        public virtual string FullFileName
        {
            get
            {
                return Path.Combine(FileDirecoryName, string.Concat(FileName, "-", DocName, ".xls"));
            }

        }

        protected abstract string FileName { get; }


        public string DocName
        {
            get;
            set;
        }

        public DateTime DocDate
        {
            get;
            set;
        }

        public string FileDirecoryName
        {
            get;
            set;
        }


        public abstract void Export();
    }
}
