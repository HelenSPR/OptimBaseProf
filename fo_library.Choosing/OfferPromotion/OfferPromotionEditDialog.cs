using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Choosing.OfferPromotion
{
    internal partial class OfferPromotionEditDialog : Form
    {
        private bool isTxtBxEdited = false;
        private bool isPictureBxEdited = false;

        private bool isFirstNameChange = true;
        private bool isFirstPictureChange = true;
        private readonly bool isEditingMode = false;

        public string OfferPromotionName { get; private set; }
        public byte[] Picture { get; private set; }

     

        public OfferPromotionEditDialog()
        {
            InitializeComponent();
        }

        public OfferPromotionEditDialog(string offerPromotionName, byte[] image)
        {
            InitializeComponent();

            isEditingMode = true;


            textBox1.Text = offerPromotionName;

            Picture = image;

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(Picture))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }

            
        }

      

        private void SetOkBtnEnable()
        {
            if ((isTxtBxEdited && pictureBox1.Image != null) || (isPictureBxEdited && textBox1.Text.Length > 0))
                _BtnOk.Enabled = true;
            else
                _BtnOk.Enabled = false;
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isEditingMode && isFirstPictureChange)
            {
                isPictureBxEdited = false;
                isFirstPictureChange = false;
            }
            else
            {
                if (pictureBox1.Image != null)
                    isPictureBxEdited = true;
                else
                    isPictureBxEdited = false;

                SetOkBtnEnable();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OfferPromotionName = textBox1.Text;
            if (isEditingMode && isFirstNameChange)
            {
                isTxtBxEdited = false;
                isFirstNameChange = false;
            }
            else
            {
                if (textBox1.Text.Length > 0)
                    isTxtBxEdited = true;
                else
                    isTxtBxEdited = false;

                SetOkBtnEnable();
            }
        }


     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);

                pictureBox1.Image = image;

                using (MemoryStream ms = new MemoryStream())
                {

                    image.Save(ms, ImageFormat.Jpeg);

                    Picture = ms.ToArray();

                }
            }
        }
    }
}
