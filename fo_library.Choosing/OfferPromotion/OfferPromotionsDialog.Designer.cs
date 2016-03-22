namespace fo_library.Choosing.OfferPromotion
{
    partial class OfferPromotionsDialog
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
            this._ContextMenuStripDataGridViewOfferPromotions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьАкциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.offerPromotionDataSet = new fo_library.Choosing.OfferPromotion.OfferPromotionDataSet();
            this.fo_offer_promotionsTableAdapter = new fo_library.Choosing.OfferPromotion.OfferPromotionDataSetTableAdapters.fo_offer_promotionsTableAdapter();
            this._BtnOK = new System.Windows.Forms.Button();
            this._BtnApply = new System.Windows.Forms.Button();
            this._BtnCancel = new System.Windows.Forms.Button();
            this._ContextMenuStripDataGridViewOfferPromotions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerPromotionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // _ContextMenuStripDataGridViewOfferPromotions
            // 
            this._ContextMenuStripDataGridViewOfferPromotions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАкциюToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.удалитьToolStripMenuItem1});
            this._ContextMenuStripDataGridViewOfferPromotions.Name = "_ContextMenuStripDataGridViewOfferPromotions";
            this._ContextMenuStripDataGridViewOfferPromotions.Size = new System.Drawing.Size(155, 76);
            // 
            // добавитьАкциюToolStripMenuItem
            // 
            this.добавитьАкциюToolStripMenuItem.Name = "добавитьАкциюToolStripMenuItem";
            this.добавитьАкциюToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьАкциюToolStripMenuItem.Text = "Добавить";
            this.добавитьАкциюToolStripMenuItem.Click += new System.EventHandler(this.AddOfferPromotionToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Редактировать";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.EditingOfferPromotionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Image = global::fo_library.Choosing.Properties.Resources.delete_icon;
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.DeleteOfferPromotionToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 299);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Акции:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this._ContextMenuStripDataGridViewOfferPromotions;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(445, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Акции";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "fo_offer_promotions";
            this.bindingSource1.DataSource = this.offerPromotionDataSet;
            // 
            // offerPromotionDataSet
            // 
            this.offerPromotionDataSet.DataSetName = "OfferPromotionDataSet";
            this.offerPromotionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fo_offer_promotionsTableAdapter
            // 
            this.fo_offer_promotionsTableAdapter.ClearBeforeFill = true;
            // 
            // _BtnOK
            // 
            this._BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._BtnOK.Location = new System.Drawing.Point(387, 332);
            this._BtnOK.Name = "_BtnOK";
            this._BtnOK.Size = new System.Drawing.Size(75, 23);
            this._BtnOK.TabIndex = 5;
            this._BtnOK.Text = "OK";
            this._BtnOK.UseVisualStyleBackColor = true;
            this._BtnOK.Click += new System.EventHandler(this._BtnOK_Click);
            // 
            // _BtnApply
            // 
            this._BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnApply.Location = new System.Drawing.Point(306, 332);
            this._BtnApply.Name = "_BtnApply";
            this._BtnApply.Size = new System.Drawing.Size(75, 23);
            this._BtnApply.TabIndex = 6;
            this._BtnApply.Text = "Применить";
            this._BtnApply.UseVisualStyleBackColor = true;
            this._BtnApply.Click += new System.EventHandler(this._BtnApply_Click);
            // 
            // _BtnCancel
            // 
            this._BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._BtnCancel.Location = new System.Drawing.Point(225, 332);
            this._BtnCancel.Name = "_BtnCancel";
            this._BtnCancel.Size = new System.Drawing.Size(75, 23);
            this._BtnCancel.TabIndex = 7;
            this._BtnCancel.Text = "Отмена";
            this._BtnCancel.UseVisualStyleBackColor = true;
            // 
            // OfferPromotionsDialog
            // 
            this.AcceptButton = this._BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._BtnCancel;
            this.ClientSize = new System.Drawing.Size(476, 367);
            this.Controls.Add(this._BtnCancel);
            this.Controls.Add(this._BtnApply);
            this.Controls.Add(this._BtnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "OfferPromotionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Рекламные акции КП";
            this.Load += new System.EventHandler(this.OfferPromotionsDialog_Load);
            this._ContextMenuStripDataGridViewOfferPromotions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerPromotionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip _ContextMenuStripDataGridViewOfferPromotions;
        private System.Windows.Forms.ToolStripMenuItem добавитьАкциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private OfferPromotionDataSetTableAdapters.fo_offer_promotionsTableAdapter fo_offer_promotionsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private OfferPromotionDataSet offerPromotionDataSet;
        private System.Windows.Forms.Button _BtnOK;
        private System.Windows.Forms.Button _BtnApply;
        private System.Windows.Forms.Button _BtnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}