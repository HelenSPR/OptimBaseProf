using Atechnology.DBConnections2;
using Atechnology.ecad.Document.Classes;
using Atechnology.ecad.Document.DataSets;
using Atechnology.winDraw.Model;
using fo_library.Validation.PositionValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Validation
{
    public static class Validator
    {
        public static void PositionValidate(OrderCalcPosition orderCalcPosition)
        {
            PositionValidator validator = new PositionValidator(orderCalcPosition);
            validator.AllVaidate();
        }

        public static string ManufactNumbersValidate(string[] manufactNames)
        {
           string manufactNamesStr = string.Join(",",manufactNames);

            DataSet dataSet = new DataSet("Validate Info");
            using(SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.CommandText = "[dbo].[fo_ManufactNamesValidate]";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@manufactNames", manufactNamesStr);
                command.Connection = dbinit.db;

                adapter.Fill(dataSet);
            }

            string validateMessage = string.Empty;

            // Более одного договора для уникального производственнго задания
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                validateMessage += "Найдено более одного договора для уникального произоводственнго номера: ";

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    validateMessage += string.Format("\r\nПр. №: {0} № заказа: {1} Тип: {2} Количество: {3}"
                        , row["manufact_name"]
                        , row["agree_name"]
                        , row["doc_name"]
                        , row["cnt"]);
                }

            }

            if (dataSet.Tables[1].Rows.Count > 0)
            {
                validateMessage += "\r\nВ windraw отсутствуют следующие заказы:";

                foreach (DataRow row in dataSet.Tables[1].Rows)
                {
                    validateMessage += string.Format("\r\nПр. №: {0} № заказа: {1} Тип: {2}"
                        , row["manufact_name"]
                        , row["agree_name"]
                        , row["doc_name"]);
                }
            }


            if (dataSet.Tables[2].Rows.Count > 0)
            {
                validateMessage += "\r\nВ windraw не заведены следующие Пр. номера:";

                foreach (DataRow row in dataSet.Tables[2].Rows)
                {
                    validateMessage += "\r\n" + (string)row["manufact_name"];
                }
            }

            return validateMessage;
        }

      
    }
}
