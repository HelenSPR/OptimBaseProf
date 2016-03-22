namespace fo_library.Choosing.Common
{
    partial class ManufactnameFormDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufactnameFormDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._BtnOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._ToolStripManufactNameXmlFile = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manufactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agreeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docOperNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstrComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this._ToolStripManufactNameXmlFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this._BtnCancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._BtnOK, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 345);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _BtnCancel
            // 
            this._BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._BtnCancel.Location = new System.Drawing.Point(3, 319);
            this._BtnCancel.Name = "_BtnCancel";
            this._BtnCancel.Size = new System.Drawing.Size(75, 23);
            this._BtnCancel.TabIndex = 1;
            this._BtnCancel.Text = "Отмена";
            this._BtnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер сменного задания: ";
            // 
            // _BtnOK
            // 
            this._BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._BtnOK.Location = new System.Drawing.Point(578, 319);
            this._BtnOK.Name = "_BtnOK";
            this._BtnOK.Size = new System.Drawing.Size(75, 23);
            this._BtnOK.TabIndex = 2;
            this._BtnOK.Text = "OK";
            this._BtnOK.UseVisualStyleBackColor = true;
            this._BtnOK.Click += new System.EventHandler(this._BtnOk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(153, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufactNameDataGridViewTextBoxColumn,
            this.agreeNameDataGridViewTextBoxColumn,
            this.docOperNameDataGridViewTextBoxColumn,
            this.ConstrComment});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 284);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            // 
            // _ToolStripManufactNameXmlFile
            // 
            this._ToolStripManufactNameXmlFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this._ToolStripManufactNameXmlFile.Location = new System.Drawing.Point(0, 0);
            this._ToolStripManufactNameXmlFile.Name = "_ToolStripManufactNameXmlFile";
            this._ToolStripManufactNameXmlFile.Size = new System.Drawing.Size(656, 25);
            this._ToolStripManufactNameXmlFile.TabIndex = 4;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Из файла";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Names";
            this.bindingSource1.DataSource = typeof(fo_library.Choosing.Common.ManufactAgreeNameCollection);
            // 
            // manufactNameDataGridViewTextBoxColumn
            // 
            this.manufactNameDataGridViewTextBoxColumn.DataPropertyName = "ManufactName";
            this.manufactNameDataGridViewTextBoxColumn.HeaderText = "Пр. номер";
            this.manufactNameDataGridViewTextBoxColumn.Name = "manufactNameDataGridViewTextBoxColumn";
            // 
            // agreeNameDataGridViewTextBoxColumn
            // 
            this.agreeNameDataGridViewTextBoxColumn.DataPropertyName = "AgreeName";
            this.agreeNameDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.agreeNameDataGridViewTextBoxColumn.Name = "agreeNameDataGridViewTextBoxColumn";
            // 
            // docOperNameDataGridViewTextBoxColumn
            // 
            this.docOperNameDataGridViewTextBoxColumn.DataPropertyName = "DocOperName";
            this.docOperNameDataGridViewTextBoxColumn.HeaderText = "Тип Документа";
            this.docOperNameDataGridViewTextBoxColumn.Name = "docOperNameDataGridViewTextBoxColumn";
            this.docOperNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.docOperNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // ConstrComment
            // 
            this.ConstrComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConstrComment.DataPropertyName = "ConstrComm";
            this.ConstrComment.HeaderText = "Комментарий конструктора";
            this.ConstrComment.Name = "ConstrComment";
            this.ConstrComment.ReadOnly = true;
            // 
            // ManufactnameFormDialog
            // 
            this.AcceptButton = this._BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._BtnCancel;
            this.ClientSize = new System.Drawing.Size(656, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._ToolStripManufactNameXmlFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManufactnameFormDialog";
            this.Text = "Выбор заказов";
            this.Load += new System.EventHandler(this.ManufactnameFormDialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this._ToolStripManufactNameXmlFile.ResumeLayout(false);
            this._ToolStripManufactNameXmlFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _BtnCancel;
        private System.Windows.Forms.Button _BtnOK;
        private System.Windows.Forms.ToolStrip _ToolStripManufactNameXmlFile;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agreeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docOperNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstrComment;
    }
}