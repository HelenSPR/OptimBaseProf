using Atechnology.DBConnections2;
using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Model;
using fo_library.CalculateModel;
using fo_library.Names;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace FastExport
{
    public class FastExport
    {
        // заявка на подоконники
        // Выгрузка подоконников Кристалита
        public static void SupplyWindowsillExport(int supplyDocumentId)
        {

            FolderBrowserDialog fbDialog = new FolderBrowserDialog();

            if (fbDialog.ShowDialog() != DialogResult.OK)
                return;

            // -- Информация по контрагенту фабрики окон
            Contractor contractor = Contractor.GetContractor();

            // -- Информация по документу
            string supplyDocName = string.Empty;
            DateTime supplyDocDate;

            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = "SELECT name, dtdoc FROM supplydoc WHERE idsupplydoc = @idsupplydoc AND deleted == null";
                command.Parameters.AddWithValue("@idsupplydoc", supplyDocumentId);

                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                supplyDocName = (string)datatable.Rows[0]["name"];
                supplyDocDate = (DateTime)datatable.Rows[0]["dtdoc"];
            }


            List<IDocExporter> exporters = new List<IDocExporter>();

            exporters.Add(new CrystalitSupplyExporter(supplyDocumentId));

            foreach (IDocExporter exporter in exporters)
            {
                exporter.DocName = supplyDocName;
                exporter.DocDate = supplyDocDate;
                exporter.FileDirecoryName = fbDialog.SelectedPath;

                exporter.Export();
            }
        }

        // Заявка на подоконники ВСЕХ производителей
        public static void GetAllWindowsillExport(int supplyDocumentId)
        {

            FolderBrowserDialog fbDialog = new FolderBrowserDialog();

            if (fbDialog.ShowDialog() != DialogResult.OK)
                return;

            // -- Информация по контрагенту фабрики окон
            Contractor contractor = Contractor.GetContractor();

            // -- Информация по документу
            string supplyDocName = string.Empty;
            DateTime supplyDocDate;

            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = "SELECT name, dtdoc FROM supplydoc WHERE idsupplydoc = @idsupplydoc";
                command.Parameters.AddWithValue("@idsupplydoc", supplyDocumentId);

                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                supplyDocName = (string)datatable.Rows[0]["name"];
                supplyDocDate = (DateTime)datatable.Rows[0]["dtdoc"];
            }


            List<IDocExporter> exporters = new List<IDocExporter>();

            exporters.Add(new CrystalitSupplyExporter(supplyDocumentId));
            exporters.Add(new TsvetoslavSupplyExporter(supplyDocumentId));
            exporters.Add(new TbmSupplyExporter(supplyDocumentId));

            foreach (IDocExporter exporter in exporters)
            {
                exporter.DocName = supplyDocName;
                exporter.DocDate = supplyDocDate;
                exporter.FileDirecoryName = fbDialog.SelectedPath;

                exporter.Export();
            }


        }
    }
}
