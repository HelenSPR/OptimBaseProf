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

namespace fo_library.Export.SupplyExporters
{
    class TsvetoslavSupplyExporter : SupplyExporterExcel
    {

        internal TsvetoslavSupplyExporter(int supplyDocId) : base(supplyDocId) { }

        protected override string FileName
        {
            get { return "Tsvetoslav"; }
        }

        public override void Export()
        {
            Contractor contractor = Contractor.GetContractor();

            // -- Заполняем информацию по подоконникам
            DataSet tsvetoslav = new DataSet("Tsvetoslav");
            using(SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = @"SELECT
	--g.marking
	 g.name AS name
    , sdp.comment AS manufact_name
	, sdp.width
	, sdp.thick
	, sdp.qu
	, c.name AS color_name
FROM  supplydocpos AS sdp
INNER JOIN good AS g ON sdp.idgood = g.idgood
INNER JOIN orderitem AS oi ON sdp.idorderitem = oi.idorderitem
INNER JOIN color AS c ON oi.idcolorout = c.idcolor
WHERE sdp.idsupplydoc = @idsupplydoc
AND g.idcustomer = 43300 -- Поставщик Цветослав
AND sdp.deleted IS NULL
AND g.idgoodtype = 13

SELECT
    g.name AS name
    , c.name AS color_name
    , SUM(sdp.qu) AS quantity
FROM supplydocpos AS sdp
INNER JOIN good AS g ON sdp.idgood = g.idgood
INNER JOIN orderitem AS oi ON sdp.idorderitem = oi.idorderitem
INNER JOIN color AS c ON oi.idcolorout = c.idcolor
WHERE sdp.idsupplydoc = @idsupplydoc
AND g.idcustomer = 43300
AND sdp.deleted IS NULL
AND g.idgoodtype2 = 13
GROUP BY g.name, c.name";
                command.Parameters.AddWithValue("@idsupplydoc", supplyDocumentId);

                adapter.Fill(tsvetoslav);

                File.WriteAllBytes(FullFileName, Resources.TsvetoslavWindowsillSupplyTemplate);

                Excel.Application excelapp = new Excel.Application();
                excelapp.Visible = true;
                Excel.Workbook excelappworkbook = excelapp.Workbooks.Open(FullFileName);
                Excel.Sheets excelsheets = excelappworkbook.Worksheets;
                Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);


                excelworksheet.Cells[1, 3] = contractor.Inn;
                excelworksheet.Cells[1, 4] = contractor.Name;

                excelworksheet.Cells[4, 3] = contractor.Address;

                excelworksheet.Cells[6, 4] = DocName;

                int firstExcelRow = 9;
                int currentExcelRow = 0;
                int rowNumber = 0;

                foreach (DataRow row in tsvetoslav.Tables[0].Rows)
                {
                    currentExcelRow = firstExcelRow + rowNumber++;
                    string name = (string)row["name"];

                    int width = (int)row["width"];

                    int lenght = (int)row["thick"];

                    int count = Convert.ToInt32(row["qu"]);

                    //string marking = (string)row["marking"];

                    string manufactName = (string)row["manufact_name"];

                    string color = (string)row["color_name"];


                    color = color.Substring(0, color.IndexOf(' ') + 1);
                    excelworksheet.Cells[currentExcelRow, 1] = rowNumber;
                    excelworksheet.Cells[currentExcelRow, 2] = name;

                    ((Excel.Range)excelworksheet.Cells[currentExcelRow, 3]).NumberFormat = "@";
                    excelworksheet.Cells[currentExcelRow, 3] = color;
                    excelworksheet.Cells[currentExcelRow, 4] = width;
                    excelworksheet.Cells[currentExcelRow, 5] = lenght;
                    excelworksheet.Cells[currentExcelRow, 6] = count;
                    excelworksheet.Cells[currentExcelRow, 7] = manufactName;
                }

                foreach (DataRow row in tsvetoslav.Tables[1].Rows)
                {
                    currentExcelRow = firstExcelRow + rowNumber++;
                    string name = (string)row["name"];
                    string color = (string)row["color_name"];
                    int count = Convert.ToInt32(row["quantity"]);

                    color = color.Substring(0, color.IndexOf(' ') + 1);

                    excelworksheet.Cells[currentExcelRow, 1] = rowNumber;
                    excelworksheet.Cells[currentExcelRow, 2] = name;

                    ((Excel.Range)excelworksheet.Cells[currentExcelRow, 3]).NumberFormat = "@";
                    excelworksheet.Cells[currentExcelRow, 3] = color;
                    excelworksheet.Cells[currentExcelRow, 6] = count;
                }
            }
        }
    }
}
