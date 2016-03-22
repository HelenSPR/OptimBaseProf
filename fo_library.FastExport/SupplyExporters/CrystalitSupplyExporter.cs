using Atechnology.DBConnections2;
//using fo_library.FastExport.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace FastExport
{
    internal class CrystalitSupplyExporter : SupplyExporterExcel
    {
        internal CrystalitSupplyExporter(int supplyDocId) : base(supplyDocId) { }

        public override void Export()
        {
            Contractor contractor = Contractor.GetContractor();

            // -- Заполняется информация по подоконникам Crystalit.
          
            DataSet dataset = new DataSet("Crystalit");
         

            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = @"fo_GetSupplySillForExport";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idsupplydoc", supplyDocumentId);

                adapter.Fill(dataset);

                File.WriteAllBytes(FullFileName, fo_library.FastExport.Properties.Resources.SupplyWindowsillTemplate);

                Excel.Application excelapp = new Excel.Application();
                excelapp.Visible = true;
                Excel.Workbook excelappworkbook = excelapp.Workbooks.Open(FullFileName);
                Excel.Sheets excelsheets = excelappworkbook.Worksheets;
                Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

                excelworksheet.Cells[1, 3] = contractor.Inn;
                excelworksheet.Cells[1, 4] = contractor.Name;
                excelworksheet.Cells[4, 3] = contractor.Address;

                ((Excel.Range)excelworksheet.Cells[1, 9]).NumberFormat = "@";
                excelworksheet.Cells[1, 9] = DocName;

                excelworksheet.Cells[2, 9] = DocDate;


                int firstExcelRow = 7;
                int currentExcelRow = 0;
                int rowNumber = 0;
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    currentExcelRow = firstExcelRow + rowNumber++;
                    // -- Получение артикля и цвета из "нашего" артикля
                    string rowMarking = (string)row["marking"];
                    string marking = string.Empty;
                    string color = string.Empty;
                    if (rowMarking.IndexOf("-") > 0)
                    {
                         marking = rowMarking.Substring(0, rowMarking.LastIndexOf("-"));
                         color = rowMarking.Substring(rowMarking.LastIndexOf("-") + 1);
                    }
                    else if (rowMarking.IndexOf("(") > 0)
                    {
                        marking = rowMarking.Substring(0, rowMarking.LastIndexOf("("));
                        color = rowMarking.Substring(rowMarking.LastIndexOf("(") + 1);
                        color = color.TrimEnd(')');
                    }
                    else
                        marking = rowMarking;
                    
                    

                    // -- Наименование материал
                    string name = (string)row["name"];

                    // -- Ширина
                    int width = (int)row["width"];

                    // -- Длина
                    int length = (int)row["thick"];

                    // -- Кол-во
                    int count = 1;

                    // -- Штрих код
                    string barCode = (string)row["bar_code"];

                    // -- Номер производственного задания
                    string manufactname = (string)row["manufact_name"];

                    // -- "Номер в заказе"
                    int orderNN = Convert.ToInt32(row["order_nn"]);


                    // -- Общее количество в заказе
                    int orderCount = Convert.ToInt32(row["order_count"]);

                    excelworksheet.Cells[currentExcelRow, 1] = rowNumber;
                    excelworksheet.Cells[currentExcelRow, 2] = marking;
                    ((Excel.Range)excelworksheet.Cells[currentExcelRow, 3]).NumberFormat = "@";
                    excelworksheet.Cells[currentExcelRow, 3] = color;
                    excelworksheet.Cells[currentExcelRow, 4] = name;
                    excelworksheet.Cells[currentExcelRow, 5] = width;
                    excelworksheet.Cells[currentExcelRow, 7] = length;
                    excelworksheet.Cells[currentExcelRow, 8] = count;
                    excelworksheet.Cells[currentExcelRow, 9] = string.Concat(barCode, "|", manufactname, " ", orderNN, "/", orderCount);
                }

                foreach (DataRow row in dataset.Tables[1].Rows)
                {
                    currentExcelRow = firstExcelRow + rowNumber++;

                    string name = (string)row["name"];
                    string marking = (string)row["marking"];
                    string bar_code = (string)row["bar_code"];
                    int order_count = (int)Convert.ToDouble(row["order_count"].ToString());
                    excelworksheet.Cells[currentExcelRow, 1] = rowNumber;
                    excelworksheet.Cells[currentExcelRow, 2] = marking;
                    excelworksheet.Cells[currentExcelRow, 4] = name;
                    excelworksheet.Cells[currentExcelRow, 8] = 1;
                    excelworksheet.Cells[currentExcelRow, 9] = string.Concat(bar_code, " ", order_count); 
                }

            }
        }



        protected override string FileName
        {
            get { return "Crystalit"; }
        }
    }
}
