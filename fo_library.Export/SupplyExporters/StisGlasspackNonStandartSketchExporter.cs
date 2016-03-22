using Atechnology.DBConnections2;
using fo_library.Export.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace fo_library.Export.SupplyExporters
{
    internal class StisGlasspackNonStandartSketchExporter : SupplyExporterExcel
    {
        internal StisGlasspackNonStandartSketchExporter(int supplyDocId) : base(supplyDocId) { }
        protected override string FileName
        {
            get { return "Stis_NonStandSketch"; }
        }


        public override void Export()
        {
            string commandText = "fo_supply_get_glasspacks_nonstandart_export_sketch";

            DataSet dataSet = new DataSet();

            using (SqlCommand command = new SqlCommand(commandText, dbinit.db))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idsupplydoc", supplyDocumentId);

                adapter.Fill(dataSet);
            }


            if (dataSet.Tables[0].Rows.Count == 0)
                return;

            File.WriteAllBytes(FullFileName, Resources.StisTempNonStandScketch);

            Excel.Application excelapp = new Excel.Application();
            excelapp.Visible = true;

            Excel.Workbook excelappworkbook = excelapp.Workbooks.Open(FullFileName);
            Excel.Sheets excelsheets = excelappworkbook.Worksheets;
            Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);


            int firstExcelRow = 6;
            int currentExcelRow = 0;
            int rowNumber = 0;



            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                currentExcelRow = firstExcelRow + rowNumber++;

                excelworksheet.Cells[currentExcelRow, 1] = rowNumber;
                excelworksheet.Cells[currentExcelRow, 2] = (string)row["manufactname"];
                excelworksheet.Cells[currentExcelRow, 3] = (int)row["numpos"];
                excelworksheet.Cells[currentExcelRow, 4] = (string)row["modelpart"];
                excelworksheet.Cells[currentExcelRow, 5] = string.Empty;
                excelworksheet.Cells[currentExcelRow, 6] = (string)row["glasspack_formula"];
                excelworksheet.Cells[currentExcelRow, 7] = (int)row["height"];
                excelworksheet.Cells[currentExcelRow, 8] = (int)row["width"];
                excelworksheet.Cells[currentExcelRow, 9] = (int)row["thickness"];
                excelworksheet.Cells[currentExcelRow, 10] = (decimal)row["qu"];
                excelworksheet.Cells[currentExcelRow, 11] = (string)row["square"];
                excelworksheet.Cells[currentExcelRow, 12] = (string)row["bar_code"];
                excelworksheet.Cells[currentExcelRow, 13] = (string)row["fo_number_part"];

            }

        }

    }
}
