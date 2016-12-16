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
        public static void FileGenerator/*getOptimBaseProf*/(int id, string folderName)
        {
               DataTable optimDocumnetTable = new DataTable(); 
               DataTable optimDocPicTable = new DataTable(); 
               DataTable beamTable = new DataTable(); 
               Dictionary<int, clsModel> idorderitemClsModel = new Dictionary<int,clsModel>();

               if (MessageBox.Show("Только для этого документа?", "Файлы на пилу", MessageBoxButtons.YesNo) == DialogResult.Yes)
                   GetData(id.ToString(), out optimDocumnetTable, out optimDocPicTable, out beamTable, out idorderitemClsModel);
               else
                   GetData(id, out optimDocumnetTable, out optimDocPicTable, out beamTable, out idorderitemClsModel);



               OptimizedMainProfileExport(folderName, optimDocumnetTable, optimDocPicTable, beamTable, idorderitemClsModel);   // пила
               //Welding(idorderitemClsModel, beamTable, folderName);
        }


        #region Получить данные из БД
        private static void GetData(string idoptimdocs,
                                out DataTable optimDocumnetTable, out DataTable optimDocPicTable, out DataTable beamTable, out Dictionary<int, clsModel> idorderitemClsModel)
        {

            DataSet dataSet = new DataSet();
            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = "fo_optim_main_prof_by_idoptimdocs2";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idoptimdocs", idoptimdocs);
                command.CommandTimeout = 9999999;
                adapter.Fill(dataSet);
            }

            optimDocumnetTable = dataSet.Tables[0];

            // Заготовки
            optimDocPicTable = dataSet.Tables[1];

            // Напиленные балки
            beamTable = dataSet.Tables[2];

            idorderitemClsModel = new Dictionary<int, clsModel>();

            foreach (DataRow row in dataSet.Tables[3].Rows)
            {
                byte[] modelByteArray = Atechnology.Components.ZipArchiver.UnZip2((byte[])row[1]);

                idorderitemClsModel.Add((int)row[0], new clsModel(modelByteArray));
            }

            List<Tuple<DataRow, string>> beemDataRow_leafNumber = new List<Tuple<DataRow, string>>();

            DataTable beemDataTable = dataSet.Tables[2];
            beemDataTable.Columns.Add("FieldNumber");

        }


        private static void GetData(int idoptimdocs,
                                out DataTable optimDocumnetTable, out DataTable optimDocPicTable, out DataTable beamTable, out Dictionary<int, clsModel> idorderitemClsModel)
        {
            //************************
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
                command.Parameters.AddWithValue("@idoptimdoc", idoptimdocs);

                adapter.Fill(dataTable);
            }

            string stridoptimdocs = string.Join(",", dataTable.AsEnumerable().Select(r => r.Field<int>("idoptimdoc").ToString()).ToArray());

            //************************


            DataSet dataSet = new DataSet();
            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = "fo_optim_main_prof_by_idoptimdocs2";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idoptimdocs", stridoptimdocs);
                command.CommandTimeout = 9999999;
                adapter.Fill(dataSet);
            }

            optimDocumnetTable = dataSet.Tables[0];

            // Заготовки
            optimDocPicTable = dataSet.Tables[1];

            // Напиленные балки
            beamTable = dataSet.Tables[2];

            idorderitemClsModel = new Dictionary<int, clsModel>();

            foreach (DataRow row in dataSet.Tables[3].Rows)
            {
                byte[] modelByteArray = Atechnology.Components.ZipArchiver.UnZip2((byte[])row[1]);

                idorderitemClsModel.Add((int)row[0], new clsModel(modelByteArray));
            }

            List<Tuple<DataRow, string>> beemDataRow_leafNumber = new List<Tuple<DataRow, string>>();

            DataTable beemDataTable = dataSet.Tables[2];
            beemDataTable.Columns.Add("FieldNumber");

        }

        #endregion

        #region Пила
        public static void OptimizedMainProfileExport(string folderName, /*string idoptimdocs, string folderName, DataSet dataSet, out Dictionary<int, clsModel> idorderitemClsModel*/
                            DataTable optimDocumnetTable,  DataTable optimDocPicTable,  DataTable beamTable,  Dictionary<int, clsModel> idorderitemClsModel
            )
        {
            #region
            /*DataSet dataSet = new DataSet();
            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = "fo_optim_main_prof_by_idoptimdocs2";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idoptimdocs", idoptimdocs);
                command.CommandTimeout = 9999999;
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

                idorderitemClsModel.Add((int)row[0], new clsModel(modelByteArray));
                
            }

            DataTable beemDataTable = dataSet.Tables[2];
            beemDataTable.Columns.Add("FieldNumber");
             
             */
            #endregion


            List<Tuple<DataRow, string>> beemDataRow_leafNumber = new List<Tuple<DataRow, string>>();


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


                IEnumerable<DataRow> beemRows = beamTable
                                                   .AsEnumerable()
                                                   .Where(br => br.Field<int>("idoptimdoc") == docWriter.IdOptimDoc)
                                                   .OrderBy(br => br.Field<string>("manufact_name"));// Упорядочить по manufactname.
                // Необходимо для того, чтобы балки(Рам, Створок и Импостов)
                // из одного заказа упаковывались в свои тележки в одинаковой последовательности.


                clsModel clsModel = null;

                // Цикл по напиленым балкам
                foreach (DataRow beemRow in beemRows.OrderBy(p => p.Field<string>("remaindername")))
                {
                    // Получить модель для дальнейшего извлечения балки.
                    idorderitem = (int)beemRow["idorderitem"];
                    SawBeam sawBeam;
                    clsModel = null;

                    if (idorderitem > 0 && idorderitemClsModel.TryGetValue(idorderitem, out clsModel))
                    {
                        //clsModel = idorderitemClsModel.Select( [idorderitem];

                        //SawBeam sawBeam = new SawBeam(beemRow, clsModel);
                        sawBeam = new SawBeam(beemRow, clsModel);
                        sawBeam.IsRemark = true;
                    }
                    else
                    {
                        sawBeam = new SawBeam(beemRow);
                    }
                    sawBeam.File_DocName = (string)docRow["docname"];       // название файла, в который будет производится выгрузка
                    if (sawBeam.File_DocName.IndexOf("-") > 0)
                        sawBeam.File_DocName = sawBeam.File_DocName.Substring(0, sawBeam.File_DocName.IndexOf("-"));

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


           // OptimizedMainProfileExport(idoptimdocs, folderName, out idorderitemClsModel);
        }

        #endregion

        #region Сварка
        private static void Welding(/*DataTable optimDocumnetTable,*/ Dictionary<int, clsModel> idorderitemClsModel, DataTable beamTable, string FolderName)
        {
            string Emigy = string.Empty;
            string FileName = "emigy_" + DateTime.Now.Date.ToShortDateString();
            WeldDocument_Emmegi ew = new WeldDocument_Emmegi();
            foreach (KeyValuePair<int, clsModel> kvp in idorderitemClsModel)
                Emigy += ew.GetDocument(kvp, beamTable) + "\r\n";

            WeldDocument.UnloadFile(FolderName, FileName, Emigy);

        }
        #endregion Сварка

    }
}
