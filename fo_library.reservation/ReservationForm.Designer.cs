namespace fo_library.reservation
{
    partial class ReservationForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._LblDepartment = new System.Windows.Forms.Label();
            this._LblPaymentMethod = new System.Windows.Forms.Label();
            this._LblGlassCoverMethod = new System.Windows.Forms.Label();
            this._CmbBxDepartment = new System.Windows.Forms.ComboBox();
            this._BindingSourceDepartment = new System.Windows.Forms.BindingSource(this.components);
            this._CmbBxPaymentMethod = new System.Windows.Forms.ComboBox();
            this._BindingSourcePaymentMethod = new System.Windows.Forms.BindingSource(this.components);
            this._CmbBxGlassCoverObject = new System.Windows.Forms.ComboBox();
            this._BindingSourceGlassCoverObject = new System.Windows.Forms.BindingSource(this.components);
            this._CmbBxLoggiaRecomendationObject = new System.Windows.Forms.ComboBox();
            this._BindingSourceLoggiaRecomendationObject = new System.Windows.Forms.BindingSource(this.components);
            this._BtnCancel = new System.Windows.Forms.Button();
            this._BtnApply = new System.Windows.Forms.Button();
            this._LblLoggiaRecomendationMethod = new System.Windows.Forms.Label();
            this._LblApertureCountMethod = new System.Windows.Forms.Label();
            this._NumUpDownApertureCountObject = new System.Windows.Forms.NumericUpDown();
            this._LblApertureToGlazingCountMethod = new System.Windows.Forms.Label();
            this._NumUpDownApertureToGlazingCountObject = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourceDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourcePaymentMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourceGlassCoverObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourceLoggiaRecomendationObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NumUpDownApertureCountObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NumUpDownApertureToGlazingCountObject)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this._LblDepartment, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._LblPaymentMethod, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._LblGlassCoverMethod, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._CmbBxDepartment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._CmbBxPaymentMethod, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._CmbBxGlassCoverObject, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._CmbBxLoggiaRecomendationObject, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._LblLoggiaRecomendationMethod, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._LblApertureCountMethod, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._NumUpDownApertureCountObject, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this._LblApertureToGlazingCountMethod, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this._NumUpDownApertureToGlazingCountObject, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this._BtnCancel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this._BtnApply, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _LblDepartment
            // 
            this._LblDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._LblDepartment.AutoSize = true;
            this._LblDepartment.Location = new System.Drawing.Point(3, 7);
            this._LblDepartment.Name = "_LblDepartment";
            this._LblDepartment.Size = new System.Drawing.Size(176, 13);
            this._LblDepartment.TabIndex = 0;
            this._LblDepartment.Text = "DepartmentLable";
            // 
            // _LblPaymentMethod
            // 
            this._LblPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._LblPaymentMethod.AutoSize = true;
            this._LblPaymentMethod.Location = new System.Drawing.Point(3, 34);
            this._LblPaymentMethod.Name = "_LblPaymentMethod";
            this._LblPaymentMethod.Size = new System.Drawing.Size(176, 13);
            this._LblPaymentMethod.TabIndex = 2;
            this._LblPaymentMethod.Text = "PaymentMethodLable";
            // 
            // _LblGlassCoverMethod
            // 
            this._LblGlassCoverMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._LblGlassCoverMethod.AutoSize = true;
            this._LblGlassCoverMethod.Location = new System.Drawing.Point(3, 61);
            this._LblGlassCoverMethod.Name = "_LblGlassCoverMethod";
            this._LblGlassCoverMethod.Size = new System.Drawing.Size(176, 13);
            this._LblGlassCoverMethod.TabIndex = 4;
            this._LblGlassCoverMethod.Text = "GlassCoverMethodLable";
            // 
            // _CmbBxDepartment
            // 
            this._CmbBxDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._CmbBxDepartment, 2);
            this._CmbBxDepartment.DataSource = this._BindingSourceDepartment;
            this._CmbBxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CmbBxDepartment.FormattingEnabled = true;
            this._CmbBxDepartment.Location = new System.Drawing.Point(185, 3);
            this._CmbBxDepartment.Name = "_CmbBxDepartment";
            this._CmbBxDepartment.Size = new System.Drawing.Size(203, 21);
            this._CmbBxDepartment.TabIndex = 1;
            // 
            // _BindingSourceDepartment
            // 
            this._BindingSourceDepartment.DataSource = typeof(string);
            // 
            // _CmbBxPaymentMethod
            // 
            this._CmbBxPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._CmbBxPaymentMethod, 2);
            this._CmbBxPaymentMethod.DataSource = this._BindingSourcePaymentMethod;
            this._CmbBxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CmbBxPaymentMethod.FormattingEnabled = true;
            this._CmbBxPaymentMethod.Location = new System.Drawing.Point(185, 30);
            this._CmbBxPaymentMethod.Name = "_CmbBxPaymentMethod";
            this._CmbBxPaymentMethod.Size = new System.Drawing.Size(203, 21);
            this._CmbBxPaymentMethod.TabIndex = 3;
            // 
            // _BindingSourcePaymentMethod
            // 
            this._BindingSourcePaymentMethod.DataSource = typeof(string);
            // 
            // _CmbBxGlassCoverObject
            // 
            this._CmbBxGlassCoverObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._CmbBxGlassCoverObject, 2);
            this._CmbBxGlassCoverObject.DataSource = this._BindingSourceGlassCoverObject;
            this._CmbBxGlassCoverObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CmbBxGlassCoverObject.FormattingEnabled = true;
            this._CmbBxGlassCoverObject.Location = new System.Drawing.Point(185, 57);
            this._CmbBxGlassCoverObject.Name = "_CmbBxGlassCoverObject";
            this._CmbBxGlassCoverObject.Size = new System.Drawing.Size(203, 21);
            this._CmbBxGlassCoverObject.TabIndex = 5;
            // 
            // _BindingSourceGlassCoverObject
            // 
            this._BindingSourceGlassCoverObject.DataSource = typeof(string);
            // 
            // _CmbBxLoggiaRecomendationObject
            // 
            this._CmbBxLoggiaRecomendationObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._CmbBxLoggiaRecomendationObject, 2);
            this._CmbBxLoggiaRecomendationObject.DataSource = this._BindingSourceLoggiaRecomendationObject;
            this._CmbBxLoggiaRecomendationObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CmbBxLoggiaRecomendationObject.FormattingEnabled = true;
            this._CmbBxLoggiaRecomendationObject.Location = new System.Drawing.Point(185, 84);
            this._CmbBxLoggiaRecomendationObject.Name = "_CmbBxLoggiaRecomendationObject";
            this._CmbBxLoggiaRecomendationObject.Size = new System.Drawing.Size(203, 21);
            this._CmbBxLoggiaRecomendationObject.TabIndex = 7;
            // 
            // _BindingSourceLoggiaRecomendationObject
            // 
            this._BindingSourceLoggiaRecomendationObject.DataSource = typeof(string);
            // 
            // _BtnCancel
            // 
            this._BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._BtnCancel.Location = new System.Drawing.Point(232, 163);
            this._BtnCancel.Name = "_BtnCancel";
            this._BtnCancel.Size = new System.Drawing.Size(75, 23);
            this._BtnCancel.TabIndex = 10;
            this._BtnCancel.Text = "Отменить";
            this._BtnCancel.UseVisualStyleBackColor = true;
            // 
            // _BtnApply
            // 
            this._BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._BtnApply.Location = new System.Drawing.Point(313, 163);
            this._BtnApply.Name = "_BtnApply";
            this._BtnApply.Size = new System.Drawing.Size(75, 23);
            this._BtnApply.TabIndex = 11;
            this._BtnApply.Text = "Применить";
            this._BtnApply.UseVisualStyleBackColor = true;
            this._BtnApply.Click += new System.EventHandler(this._BtnApply_Click);
            // 
            // _LblLoggiaRecomendationMethod
            // 
            this._LblLoggiaRecomendationMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._LblLoggiaRecomendationMethod.AutoSize = true;
            this._LblLoggiaRecomendationMethod.Location = new System.Drawing.Point(3, 88);
            this._LblLoggiaRecomendationMethod.Name = "_LblLoggiaRecomendationMethod";
            this._LblLoggiaRecomendationMethod.Size = new System.Drawing.Size(176, 13);
            this._LblLoggiaRecomendationMethod.TabIndex = 6;
            this._LblLoggiaRecomendationMethod.Text = "LoggiaRecomendationMethodLabel";
            // 
            // _LblApertureCountMethod
            // 
            this._LblApertureCountMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._LblApertureCountMethod.AutoSize = true;
            this._LblApertureCountMethod.Location = new System.Drawing.Point(3, 114);
            this._LblApertureCountMethod.Name = "_LblApertureCountMethod";
            this._LblApertureCountMethod.Size = new System.Drawing.Size(176, 13);
            this._LblApertureCountMethod.TabIndex = 8;
            this._LblApertureCountMethod.Text = "ApertureCountMethodLabel";
            // 
            // _NumUpDownApertureCountObject
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._NumUpDownApertureCountObject, 2);
            this._NumUpDownApertureCountObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this._NumUpDownApertureCountObject.Location = new System.Drawing.Point(185, 111);
            this._NumUpDownApertureCountObject.Name = "_NumUpDownApertureCountObject";
            this._NumUpDownApertureCountObject.Size = new System.Drawing.Size(203, 20);
            this._NumUpDownApertureCountObject.TabIndex = 9;
            // 
            // _LblApertureToGlazingCountMethod
            // 
            this._LblApertureToGlazingCountMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._LblApertureToGlazingCountMethod.AutoSize = true;
            this._LblApertureToGlazingCountMethod.Location = new System.Drawing.Point(3, 140);
            this._LblApertureToGlazingCountMethod.Name = "_LblApertureToGlazingCountMethod";
            this._LblApertureToGlazingCountMethod.Size = new System.Drawing.Size(176, 13);
            this._LblApertureToGlazingCountMethod.TabIndex = 12;
            this._LblApertureToGlazingCountMethod.Text = "ApertureCountMethodLabel";
            // 
            // _NumUpDownApertureToGlazingCountObject
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._NumUpDownApertureToGlazingCountObject, 2);
            this._NumUpDownApertureToGlazingCountObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this._NumUpDownApertureToGlazingCountObject.Location = new System.Drawing.Point(185, 137);
            this._NumUpDownApertureToGlazingCountObject.Name = "_NumUpDownApertureToGlazingCountObject";
            this._NumUpDownApertureToGlazingCountObject.Size = new System.Drawing.Size(203, 20);
            this._NumUpDownApertureToGlazingCountObject.TabIndex = 13;
            // 
            // ReservationForm
            // 
            this.AcceptButton = this._BtnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._BtnCancel;
            this.ClientSize = new System.Drawing.Size(391, 198);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationForm";
            this.ShowIcon = false;
            this.Text = "Характеристики Заказа";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourceDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourcePaymentMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourceGlassCoverObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BindingSourceLoggiaRecomendationObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NumUpDownApertureCountObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NumUpDownApertureToGlazingCountObject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _LblDepartment;
        private System.Windows.Forms.Label _LblPaymentMethod;
        private System.Windows.Forms.Label _LblGlassCoverMethod;
        private System.Windows.Forms.ComboBox _CmbBxDepartment;
        private System.Windows.Forms.ComboBox _CmbBxPaymentMethod;
        private System.Windows.Forms.ComboBox _CmbBxGlassCoverObject;
        private System.Windows.Forms.BindingSource _BindingSourceDepartment;
        private System.Windows.Forms.BindingSource _BindingSourcePaymentMethod;
        private System.Windows.Forms.BindingSource _BindingSourceGlassCoverObject;
        private System.Windows.Forms.Button _BtnApply;
        private System.Windows.Forms.Button _BtnCancel;
        private System.Windows.Forms.BindingSource _BindingSourceLoggiaRecomendationObject;
        private System.Windows.Forms.Label _LblLoggiaRecomendationMethod;
        private System.Windows.Forms.ComboBox _CmbBxLoggiaRecomendationObject;
        private System.Windows.Forms.Label _LblApertureCountMethod;
        private System.Windows.Forms.NumericUpDown _NumUpDownApertureCountObject;
        private System.Windows.Forms.NumericUpDown _NumUpDownApertureToGlazingCountObject;
        private System.Windows.Forms.Label _LblApertureToGlazingCountMethod;
    }
}