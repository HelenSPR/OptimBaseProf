using Atechnology.DBConnections2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fo_library.Choosing.Common
{
    public partial class ManufactnameFormDialog : Form, IChoosingOrdersIdDialogView
    {

        private ManufactAgreeNameCollection nameCollection;
        public ManufactnameFormDialog()
        {
            InitializeComponent();
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



        private void ManufactnameFormDialog_Load(object sender, EventArgs e)
        {

            nameCollection = new ManufactAgreeNameCollection(bindingSource1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML-Документы(*.xml)|*.xml|Все файлы(*.*)|*.*";

            DialogResult dr = openFileDialog.ShowDialog();

            if (dr != DialogResult.OK)
                return;

            XElement xElement = XElement.Load(openFileDialog.FileName);

            if (xElement.Name == "ManufactNameList" && xElement.Elements("ManufactName").Count() > 0)
            {
                string[] manufaсtNames = xElement.Elements("ManufactName").Select(mn => mn.Value).ToArray();

                string validationMessage = fo_library.Validation.Validator.ManufactNumbersValidate(manufaсtNames);
                if (
                    string.IsNullOrEmpty(validationMessage)
                    || MessageBox.Show(validationMessage + "\r\n\r\nПродолжить выполнение операции?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes
                    )
                {


                    nameCollection.AddByManufactNames(manufaсtNames);



                }
            }
            else
            {
                MessageBox.Show("Файл не соответствуюет установленому формату xml-файла");
                return;
            }
        }

        private void _BtnOk_Click(object sender, EventArgs e)
        {
            if (nameCollection.Names.Count == 0)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            else
            {
                OrderIdArray = nameCollection.Names
                    .Select<ManufactAgreeName, int>(n => n.IdOrder)
                    .Distinct<int>() // Вернуть только уникальные идентификаторы.
                    .ToArray<int>();

                TaskNumber = textBox1.Text;
            }

        }




        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {


            var currentName = bindingSource1.Current as ManufactAgreeName;

            // Номер договора или производственный номер пустые, значит валидация не прошла.
            if (currentName != null)
            {
                if (string.IsNullOrEmpty(currentName.AgreeName))
                {
                    if (currentName.ManufactName != null)
                    {
                        MessageBox.Show(string.Format("Проверьте правильность введенного 'производственного номера'. Введенный номер: {0}. Для отмены ввода нажмите Esc.", currentName.ManufactName));
                        e.Cancel = true;
                    }
                }
                if (string.IsNullOrEmpty(currentName.ManufactName))
                {
                    if (currentName.AgreeName != null)
                    {
                        MessageBox.Show(string.Format("Проверьте правильность введенного 'номера договора'. Введенный номер: {0}. Для отмены ввода нажмите Esc.", currentName.AgreeName));
                        e.Cancel = true;
                    }
                }


            }
        }




    }
}
