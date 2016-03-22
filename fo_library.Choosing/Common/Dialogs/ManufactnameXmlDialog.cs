using Atechnology.DBConnections2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fo_library.Choosing.Common
{
    class ManufactnameXmlDialog : IChoosingOrdersIdDialogView
    {
        public System.Windows.Forms.DialogResult ShowDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML-Документы(*.xml)|*.xml|Все файлы(*.*)|*.*";

            DialogResult dr = openFileDialog.ShowDialog();

            if (dr != DialogResult.OK)
                return dr;
            else
            {
                TaskNumber = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                XElement xElement = XElement.Load(openFileDialog.FileName);

                if (xElement.Name == "ManufactNameList" && xElement.Elements("ManufactName").Count() > 0)
                {
                    string[] manufaсtNames = xElement.Elements("ManufactName").Select(e => e.Value).ToArray();

                    string validationMessage = fo_library.Validation.Validator.ManufactNumbersValidate(manufaсtNames);
                    if (string.IsNullOrEmpty(validationMessage))
                    {
                        // Установить значение идентификаторов заказов
                        SetOrderIdArray(manufaсtNames);

                        // Небыло не одного косяка с номерами производственных заданий
                        return DialogResult.OK;
                    }
                    else
                    {
                        // Установить значение идентификаторов заказов
                        SetOrderIdArray(manufaсtNames);

                        // Были косяки с номерами производственных заданий
                        // Предложить пользователю дилог: продолжить выполнение операции?
                        return MessageBox.Show(validationMessage + "\r\n\r\nПродолжить выполнение операции?", "Внимание!", MessageBoxButtons.YesNo);
                    }
                }
                else
                {
                    MessageBox.Show("Файл не соответствуюет установленому формату xml-файла");
                    return DialogResult.Abort;
                }
            }
        }

        // Установка идентификаторов заказов(При использовании в 
        // дальнейшем паттерна Стратегия убрать этот метод в класс "Показвыатель диалога")
        private void SetOrderIdArray(string[] manufactNames)
        {
            string mnIn = "'" + string.Join("','", manufactNames) + "'";

            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.CommandText = @"

SELECT o.idorder
FROM fo_manufact_names AS mn
INNER JOIN orders AS o ON mn.fo_agreename = o.agreename
                    AND mn.fo_iddocoper = o.iddocoper
WHERE mn.fo_notrelevant IS NULL
    AND o.deleted IS NULL
    AND mn.fo_manufactname IN(" + mnIn + ")";
                command.Connection = dbinit.db;

                adapter.Fill(table);
            }

            OrderIdArray = new int[table.Rows.Count];


            for (int i = 0; i < OrderIdArray.Length; i++)
            {
                OrderIdArray[i] = (int)table.Rows[i][0];
            }
        }

        public int[] OrderIdArray
        {
            get;
            private set;
        }

        public string TaskNumber
        {

            get;
            private set;
        }
    }
}
