using Atechnology.DBConnections2;
using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Model;
//using fo_library.CalculateModel;
//using fo_library.Export.OptimizationExporters;
//using fo_library.Export.Properties;
//using fo_library.Export.SupplyExporters;
//using fo_library.Names;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace OptimBaseProf
{
    public class OptimBaseProf
    {
        public static void getOptimBaseProf(int id, string folderName)
        {
            OptimizedMainProfileExport(id, folderName);
        }

        public static void OptimizedMainProfileExport(string idoptimdocs, string folderName)
        {
            

            /*FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;
                 

            folderName = dialog.SelectedPath;*/

            //string folderName = string.Empty; folderName = "C:\\MyProject\\! FO_LIBRARY 2\\TEST FILEs\\";

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

            // Заготовки
            DataTable optimDocPicTable = dataSet.Tables[1];

            // Напиленные балки
            DataTable beamTable = dataSet.Tables[2];


            Dictionary<int, clsModel> idorderitemClsModel = new Dictionary<int, clsModel>();


            foreach (DataRow row in dataSet.Tables[3].Rows)
            {
                byte[] modelByteArray = Atechnology.Components.ZipArchiver.UnZip2((byte[])row[1]);

                /*XmlDocument document = new XmlDocument();
                try
                {
                    document.Load(new MemoryStream(modelByteArray));
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки модели", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                clsModel m = new clsModel(document);
                idorderitemClsModel.Add((int)row[0], m);*/

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
                    SawBeam sawBeam;
                    if (idorderitem > 0)
                    {
                        clsModel = idorderitemClsModel[idorderitem];

                        //SawBeam sawBeam = new SawBeam(beemRow, clsModel);
                        sawBeam = new SawBeam(beemRow, clsModel);
                        sawBeam.IsRemark = true;
                    }
                    else
                    {
                        sawBeam = new SawBeam(beemRow);
                    }


                    docWriter.AddBeamWriter(sawBeam);
                }
                docWriter.FillDocument(folderName);
            }
        }

        public static void OptimizedMainProfileExport(int idoptimdoc, string folderName)
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


            OptimizedMainProfileExport(idoptimdocs, folderName);
        }
    }
}
