using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Choosing.OfferPromotion
{
    public partial class OfferPromotionChoosingDialog : Form
    {

        public int FirstOfferPromotionId
        {
            get;
            private set;
        }

        public int SecondOfferPromotionId
        {
            get;
            private set;
        }

        public Image FirstImage
        {
            get;
            private set;
        }

        public Image SecondImage
        {
            get;
            private set;
        }

        public OfferPromotionChoosingDialog()
        {
            InitializeComponent();
        }

      

        private void _BtnOK_Click(object sender, EventArgs e)
        {

            // Список идентификаторов выбранных "Акций"
            List<int> offerPromotionIdList = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
              
               object checkedValue = row.Cells[_CheckeBoxColumn.Index].Value;

               bool value = checkedValue == null ? false : (bool)checkedValue;

               if (value)
               {
                   OfferPromotion.OfferPromotionDataSet.fo_offer_promotionsRow offerPromotionDataRow = row.DataBoundItem as OfferPromotion.OfferPromotionDataSet.fo_offer_promotionsRow;

                   offerPromotionIdList.Add(offerPromotionDataRow.id);
               }
            }

            // Если в списке больше двух акций, вывести предупреждение!
            // И не закрывать диалог выбора "Акций"
            if (offerPromotionIdList.Count() > 2)
            {
                MessageBox.Show("Количество акций не может быть больше двух!");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
            else if (offerPromotionIdList.Count == 2) // Количество "Акций" = 2
            {

                using (OfferPromotionDataSetTableAdapters.fo_offer_promotionsTableAdapter tableAdapter = new OfferPromotionDataSetTableAdapters.fo_offer_promotionsTableAdapter())

                using (OfferPromotionDataSet dataset = new OfferPromotionDataSet())
                {
                    tableAdapter.FillByFirstAndSecondIds(dataset.fo_offer_promotions, offerPromotionIdList[0], offerPromotionIdList[1]);

                
                    // Заполнить значения для первой акции
                    FirstOfferPromotionId = dataset.fo_offer_promotions[0].id;

                    MemoryStream ms = new MemoryStream(dataset.fo_offer_promotions[0].picture);
                    FirstImage = Image.FromStream(ms);
                    ms.Dispose();

                    // Заполнить значение для второй акции.
                    SecondOfferPromotionId = dataset.fo_offer_promotions[1].id;

                    ms = new MemoryStream(dataset.fo_offer_promotions[1].picture);
                    SecondImage = Image.FromStream(ms);
                    ms.Dispose();
                }

                // Закрыть окно с результатом диалога OK
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else if (offerPromotionIdList.Count == 1)// Количество "Акций" = 1
            {
                using (OfferPromotionDataSetTableAdapters.fo_offer_promotionsTableAdapter tableAdapter = new OfferPromotionDataSetTableAdapters.fo_offer_promotionsTableAdapter())

                using (OfferPromotionDataSet dataset = new OfferPromotionDataSet())
                {

                    tableAdapter.FillById(dataset.fo_offer_promotions, offerPromotionIdList[0]);

                    // Заполнить значения для первой акции
                    FirstOfferPromotionId = dataset.fo_offer_promotions[0].id;


                    MemoryStream ms = new MemoryStream(dataset.fo_offer_promotions[0].picture);
                    FirstImage = Image.FromStream(ms);
                    ms.Dispose();
                }

                // Закрыть окно с результатом диалога OK
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }

           
        }


        private void OfferPromotionChoosingDialog_Load(object sender, EventArgs e)
        {
            try
            {
                using (OfferPromotionDataSetTableAdapters.fo_offer_promotionsTableAdapter tableAdapter = new OfferPromotionDataSetTableAdapters.fo_offer_promotionsTableAdapter())
               
                using(OfferPromotionDataSet dataset = new OfferPromotionDataSet())
                {
                    // Отключить проверку ограничений, что бы можно было получить DataTable без
                    // картинок(picture), кот. являются обязательными!
                    dataset.EnforceConstraints = false;

                    tableAdapter.Id_Name_Fill(dataset.fo_offer_promotions);

                    bindingSource1.DataSource = dataset.fo_offer_promotions.Rows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
