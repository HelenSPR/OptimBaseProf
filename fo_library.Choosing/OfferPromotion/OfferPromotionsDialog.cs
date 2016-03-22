using Atechnology.DBConnections2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Choosing.OfferPromotion
{
    public partial class OfferPromotionsDialog : Form
    {
        // Показывает было ли изменение в наборе данных после последнего обновления.
        private bool _isEdited = false;

        public OfferPromotionsDialog()
        {
            InitializeComponent();
        }

        private void OfferPromotionsDialog_Load(object sender, EventArgs e)
        {
            // Получить текущее соединение
            fo_offer_promotionsTableAdapter.Connection = dbinit.db;
            // Заполнить таблицу с рекламными акциями
            fo_offer_promotionsTableAdapter.Fill(offerPromotionDataSet.fo_offer_promotions);

        }

        // Контекстное меню клик на вкладке "Добавить"
        private void AddOfferPromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfferPromotionEditDialog dialog = new OfferPromotionEditDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OfferPromotionDataSet.fo_offer_promotionsRow row = offerPromotionDataSet.fo_offer_promotions.Newfo_offer_promotionsRow();

                row.name = dialog.OfferPromotionName;
                row.picture = dialog.Picture;

                offerPromotionDataSet.fo_offer_promotions.Addfo_offer_promotionsRow(row);

                _isEdited = true;
            }
        }

        // Контекстное меню клик на вкладке "Удаление"
        private void DeleteOfferPromotionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OfferPromotionDataSet.fo_offer_promotionsRow currentRow = ((DataRowView)bindingSource1.Current).Row as OfferPromotionDataSet.fo_offer_promotionsRow;

            if (currentRow != null)
            {
                if (MessageBox.Show(string.Format("Вы действительно хотите удалить акцию \"{0}\"?", currentRow.name), "Удаление Акции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    currentRow.Delete();

                    _isEdited = true;
                }
            }
        }

        // Контекстное меню клик на вкладке "Редактирование"
        private void EditingOfferPromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Вызвать диалог редактирования
            EditOfferPromotion();
        }

        // Двойной клик на dataGridView
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Вызвать диалог редкатирования
            EditOfferPromotion();
        }

        // Клик на кнопку применить
        private void _BtnApply_Click(object sender, EventArgs e)
        {
            UpdateDataSet();
        }

        // Клик на кнопку OK
        private void _BtnOK_Click(object sender, EventArgs e)
        {
            UpdateDataSet();
        }

        // Обновление набора данных
        private void UpdateDataSet()
        {
            if (_isEdited)
            {
                fo_offer_promotionsTableAdapter.Update(offerPromotionDataSet.fo_offer_promotions);
                _isEdited = false;
            }
        }

      

        // Метод вызывает диалог редактирования обработка его результатов
        private void EditOfferPromotion()
        {
            OfferPromotionDataSet.fo_offer_promotionsRow currentRow = ((DataRowView)bindingSource1.Current).Row as OfferPromotionDataSet.fo_offer_promotionsRow;

            if (currentRow != null)
            {
                OfferPromotionEditDialog dialog = new OfferPromotionEditDialog(currentRow.name, currentRow.picture);

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    currentRow.name = dialog.OfferPromotionName;

                    currentRow.picture = dialog.Picture;

                    _isEdited = true;
                }
            }
        }













    }
}
