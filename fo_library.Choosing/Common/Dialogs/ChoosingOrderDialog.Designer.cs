namespace fo_library.Choosing.Common
{
    partial class ChoosingOrderDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._BtnOk = new System.Windows.Forms.Button();
            this._BtnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "По номеру договора";
            // 
            // _BtnOk
            // 
            this._BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._BtnOk.Location = new System.Drawing.Point(153, 55);
            this._BtnOk.Name = "_BtnOk";
            this._BtnOk.Size = new System.Drawing.Size(75, 23);
            this._BtnOk.TabIndex = 2;
            this._BtnOk.Text = "Выбрать";
            this._BtnOk.UseVisualStyleBackColor = true;
            this._BtnOk.Click += new System.EventHandler(this._BtnOk_Click);
            // 
            // _BtnChoose
            // 
            this._BtnChoose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._BtnChoose.Location = new System.Drawing.Point(12, 55);
            this._BtnChoose.Name = "_BtnChoose";
            this._BtnChoose.Size = new System.Drawing.Size(75, 23);
            this._BtnChoose.TabIndex = 3;
            this._BtnChoose.Text = "Отмена";
            this._BtnChoose.UseVisualStyleBackColor = true;
            // 
            // ChoosingOrderDialog
            // 
            this.AcceptButton = this._BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._BtnChoose;
            this.ClientSize = new System.Drawing.Size(237, 90);
            this.Controls.Add(this._BtnChoose);
            this.Controls.Add(this._BtnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosingOrderDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _BtnOk;
        private System.Windows.Forms.Button _BtnChoose;
    }
}