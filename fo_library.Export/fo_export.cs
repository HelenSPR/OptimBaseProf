using Atechnology.DBConnections2;
using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Model;
using fo_library.CalculateModel;
using fo_library.Export.OptimizationExporters;
using fo_library.Export.Properties;
using fo_library.Export.SupplyExporters;
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

namespace fo_library.Export
{
    public class fo_export
    {

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
                command.CommandText = "SELECT name, dtdoc FROM supplydoc WHERE idsupplydoc = @idsupplydoc";
                command.Parameters.AddWithValue("@idsupplydoc", supplyDocumentId);

                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                supplyDocName = (string)datatable.Rows[0]["name"];
                supplyDocDate = (DateTime)datatable.Rows[0]["dtdoc"];
            }


            List<IDocExporter> exporters = new List<IDocExporter>();

        //    exporters.Add(new CrystalitSupplyExporter(supplyDocumentId));
        //    exporters.Add(new TsvetoslavSupplyExporter(supplyDocumentId));
            exporters.Add(new TbmSupplyExporter(supplyDocumentId));

            foreach (IDocExporter exporter in exporters)
            {
                exporter.DocName = supplyDocName;
                exporter.DocDate = supplyDocDate;
                exporter.FileDirecoryName = fbDialog.SelectedPath;

                exporter.Export();
            }



        }

        public static void SupplyGlassPackExport(int supplyDocumentId)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            fbDialog.SelectedPath = "c:\\test";
            //if (fbDialog.ShowDialog() != DialogResult.OK)
               // return;

            // -- Информация по контрагенту фабрики окон
            Contractor contractor = Contractor.GetContractor();

            // -- Информация по документу
            string supplyDocName = string.Empty;
            DateTime supplyDocDate;

            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = "SELECT comment, dtdoc FROM supplydoc WHERE idsupplydoc = @idsupplydoc";
                command.Parameters.AddWithValue("@idsupplydoc", supplyDocumentId);

                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                supplyDocName = (string)datatable.Rows[0]["comment"];
                supplyDocDate = (DateTime)datatable.Rows[0]["dtdoc"];
            }


            List<IDocExporter> exporters = new List<IDocExporter>();

            exporters.Add(new StisGlassPackStandartExporter(supplyDocumentId));
            exporters.Add(new StisGlassPackNonStandartExporter(supplyDocumentId));
            exporters.Add(new StisGlasspackNonStandartSketchExporter(supplyDocumentId));

            foreach (IDocExporter exporter in exporters)
            {
                exporter.DocName = supplyDocName;
                exporter.DocDate = supplyDocDate;
                exporter.FileDirecoryName = fbDialog.SelectedPath;

                exporter.Export();
            }

         
        }


        public static void SupplyGlassPackSetFoAttributes(DataSet dataSet)
        {

            DataTable glassPackDt = dataSet.Tables[0];
            DataTable constructionDt = dataSet.Tables[1];

            // Создать колонку с флагом.
            DataColumn standartColumn = glassPackDt.Columns.Add("fo_attributes", typeof(System.Int32));


            var glasses = constructionDt
                            .AsEnumerable()
                            .SelectMany(row =>
                                {
                                    byte[] classBytes = row.Field<byte[]>("m_class");

                                    Construction constr = new Construction();
                                    constr.Load(classBytes);

                                    return constr.GlassList.Select(gp => new
                                    {
                                        GlassPack = gp
                                            ,
                                        IdOrderItem = row.Field<int>("idorderitem")
                                    });

                                });


            glassPackDt.AsEnumerable()
                .Join(glasses,
                gpRow => new // Ключ для соединения стеклопакетов из dataRow
                {
                    IdOrderItem = gpRow.Field<int>("idorderitem")
                    ,
                    ModelPart = gpRow.Field<string>("modelpart")
                },
                gp => new    // Ключ для соединения стеклопакетов из Glass
                {
                    IdOrderItem = gp.IdOrderItem
                   ,
                    ModelPart = gp.GlassPack.Part
                },
                (gpRow, gp) =>
                {
                    GlassCalculate.GlassAttributeFlags flag = GlassCalculate.GetGlassPackAttributes(gp.GlassPack);

                    int intFlag = (int)flag;

                    gpRow["fo_attributes"] = intFlag;

                    return (int?)null;
                }).ToArray(); // Join - отложенная опреция, ToArray - не отложенаая. Вызов ToArray приветдет к исполнению кода из Join.

        }



        public static void OptimizedMainProfileExport(string idoptimdocs)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            //if (dialog.ShowDialog() != DialogResult.OK)
               // return;

           // string folderName = dialog.SelectedPath;
            string folderName = "C:\\MyProject\\! FO_LIBRARY 2\\TEST FILEs\\";


            DataSet dataSet = new DataSet();
            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = "fo_optim_main_prof_by_idoptimdocs";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idoptimdocs", idoptimdocs);

                adapter.Fill(dataSet);
            }

            // Документы оптимизации
            DataTable optimDocumnetTable = dataSet.Tables[0];

            // Загатовки
            DataTable optimDocPicTable = dataSet.Tables[1];

            // Напилиные балки
            DataTable beamTable = dataSet.Tables[2];


            Dictionary<int, clsModel> idorderitemClsModel = new Dictionary<int, clsModel>();


            foreach (DataRow row in dataSet.Tables[3].Rows)
            {
                byte[] modelByteArray = Atechnology.Components.ZipArchiver.UnZip2((byte[])row[1]);
                idorderitemClsModel.Add((int)row[0], new clsModel(modelByteArray));
            }

            List<Tuple<DataRow, string>> beemDataRow_leafNumber = new List<Tuple<DataRow, string>>();

            DataTable beemDataTable = dataSet.Tables[2];
            beemDataTable.Columns.Add("FieldNumber");


            int idorderitem = -1;




            SawWorkpiece piece;
            // Создать документы и заполнить их
            foreach (DataRow docRow in optimDocumnetTable.Rows)
            {

                SawDocument docWriter = new SawDocument(docRow);


                //string docText = string.Format("L,{0},CUT", docRow["docname"]);

                // Загатовки(картинки) для напиловки
                IEnumerable<DataRow> picRows = optimDocPicTable.AsEnumerable()
                    .Where(pr => pr.Field<int>("idoptimdoc") == docWriter.IdOptimDoc);

                IEnumerable<DataRow> beamRows = beamTable.AsEnumerable()
                                                .Where(br => br.Field<int>("idoptimdoc") == docWriter.IdOptimDoc)
                                                .OrderBy(br => br.Field<string>("manufact_name"));




                // -- Цикл по заготовкам(картинкам оптимизации) внутри документа
                foreach (DataRow picRow in picRows)
                {
                    int idoptimdocpic = (int)picRow["idoptimdocpic"];
                    piece = new SawWorkpiece(picRow);

                    docWriter.AddPicWriter(piece);

                }


                IEnumerable<DataRow> beemRows = dataSet.Tables[2]
                                                   .AsEnumerable()
                                                   .Where(br => br.Field<int>("idoptimdoc") == docWriter.IdOptimDoc)
                                                   .OrderBy(br => br.Field<string>("manufact_name"));// Упорядочить по manufactname.
                // Необходимо для того, чтобы балки(Рам, Створок и Импостов)
                // из одного заказа упаковывались в свои тележки в одинаковой последовательности.


                clsModel clsModel = null;

                // Цикл по напиленым балкам
                foreach (DataRow beemRow in beemRows)
                {
                    // Получить модель для дальнейшего извлечения балки.
                    idorderitem = (int)beemRow["idorderitem"];
                    clsModel = idorderitemClsModel[idorderitem];

                    SawBeam sawBeam = new SawBeam(beemRow, clsModel);
                    sawBeam.IsRemark = true;

                    docWriter.AddBeamWriter(sawBeam);

                }

                docWriter.FillDocument(folderName);



            }


        }

        public static void OptimizedMainProfileExport(int idoptimdoc)
        {
            string query = @"
SELECT
	optimdoc.idoptimdoc
FROM optimdoc
WHERE optimdoc.iddocoper = 57
AND optimdoc.deleted IS NULL
AND LEFT(optimdoc.comment, 6) = (SELECT LEFT(optimdoc.comment, 6) FROM optimdoc WHERE idoptimdoc = @idoptimdoc)";
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand(query, dbinit.db))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@idoptimdoc", idoptimdoc);

                adapter.Fill(dataTable);
            }

            string idoptimdocs = string.Join(",", dataTable.AsEnumerable().Select(r => r.Field<int>("idoptimdoc").ToString()).ToArray());

           
            OptimizedMainProfileExport(idoptimdocs);
        }
    }
}
