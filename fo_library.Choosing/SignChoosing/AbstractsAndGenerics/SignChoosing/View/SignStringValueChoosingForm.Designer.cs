namespace fo_library.Choosing
{
    partial class SignStringValueChoosingForm
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
            this.components = new System.ComponentModel.Container();
            this._BindingSourceSignValues = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._BtnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourceSignValues)).BeginInit();
            this.SuspendLayout();
            // 
            // _BindingSourceSignValues
            // 
            this._BindingSourceSignValues.DataSource = typeof(string);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this._BindingSourceSignValues;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(513, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // _BtnOk
            // 
            this._BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._BtnOk.Location = new System.Drawing.Point(432, 81);
            this._BtnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._BtnOk.Name = "_BtnOk";
            this._BtnOk.Size = new System.Drawing.Size(100, 28);
            this._BtnOk.TabIndex = 1;
            this._BtnOk.Text = "OK";
            this._BtnOk.UseVisualStyleBackColor = true;
            this._BtnOk.Click += new System.EventHandler(this._BtnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // SignStringValueChoosingView
            // 
            this.AcceptButton = this._BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 140);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._BtnOk);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignStringValueChoosingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignStringValueChoosingView";
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourceSignValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource _BindingSourceSignValues;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button _BtnOk;
        private System.Windows.Forms.Label label1;
    }
}