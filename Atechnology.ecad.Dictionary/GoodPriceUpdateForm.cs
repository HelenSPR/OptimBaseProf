// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodPriceUpdateForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad.Calc;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class GoodPriceUpdateForm : AtUserControl
    {
        private IContainer components;
        public Panel panel1;
        private Button cmdUpdatePrice;
        private Button button3;
        private Button button2;
        private Button button1;
        public GridControl gridControl1;
        public GridView gridView1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private DataSet ds;
        private DataTable table_goodpricegroup;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private GridColumn colidgoodpricegroup;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colprice1;
        private RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private GridColumn colprice2;
        private RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        public Panel panel2;
        private Button button4;
        private Button button5;
        private DataColumn dataColumn6;
        private GridColumn col_s;
        private DataColumn dataColumn7;
        private GridColumn colprice1toprice2;
        private RepositoryItemCalcEdit repositoryItemCalcEdit3;

        public GoodPriceUpdateForm()
        {
            this.InitializeComponent();
            this.FormClosing += new FormClosing(this.GoodPriceUpdateForm_FormClosing);
            this.LoadFromBase();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = (IContainer)new Container();
            this.panel1 = new Panel();
            this.cmdUpdatePrice = new Button();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.gridControl1 = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_goodpricegroup = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.gridView1 = new GridView();
            this.colidgoodpricegroup = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colprice1 = new GridColumn();
            this.repositoryItemCalcEdit1 = new RepositoryItemCalcEdit();
            this.colprice2 = new GridColumn();
            this.repositoryItemCalcEdit2 = new RepositoryItemCalcEdit();
            this.col_s = new GridColumn();
            this.colprice1toprice2 = new GridColumn();
            this.repositoryItemCalcEdit3 = new RepositoryItemCalcEdit();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.panel1.SuspendLayout();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_goodpricegroup.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemCalcEdit1.BeginInit();
            this.repositoryItemCalcEdit2.BeginInit();
            this.repositoryItemCalcEdit3.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.cmdUpdatePrice);
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(876, 33);
            this.panel1.TabIndex = 3;
            this.cmdUpdatePrice.FlatStyle = FlatStyle.Flat;
            this.cmdUpdatePrice.Location = new Point(12, 5);
            this.cmdUpdatePrice.Name = "cmdUpdatePrice";
            this.cmdUpdatePrice.Size = new Size(118, 23);
            this.cmdUpdatePrice.TabIndex = 3;
            this.cmdUpdatePrice.Text = "Обновить цены";
            this.cmdUpdatePrice.Click += new EventHandler(this.cmdUpdatePrice_Click);
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(789, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(708, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(627, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "goodpricegroup";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(0, 0);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemCalcEdit1,
        (RepositoryItem) this.repositoryItemCalcEdit2,
        (RepositoryItem) this.repositoryItemCalcEdit3
      });
            this.gridControl1.Size = new Size(876, 362);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(125, 48);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(124, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(124, 22);
            this.toolStripMenuItem2.Text = "Удалить";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.ds.DataSetName = "ds";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_goodpricegroup
      });
            this.table_goodpricegroup.Columns.AddRange(new DataColumn[7]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7
      });
            this.table_goodpricegroup.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodpricegroup"
        }, 1 != 0)
      });
            this.table_goodpricegroup.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_goodpricegroup.TableName = "goodpricegroup";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idgoodpricegroup";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "price1";
            this.dataColumn4.DataType = typeof(double);
            this.dataColumn5.ColumnName = "price2";
            this.dataColumn5.DataType = typeof(double);
            this.dataColumn6.ColumnName = "_s";
            this.dataColumn6.DataType = typeof(bool);
            this.dataColumn6.DefaultValue = (object)false;
            this.dataColumn7.ColumnName = "price1toprice2";
            this.dataColumn7.DataType = typeof(double);
            this.gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.BorderStyle = BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new GridColumn[7]
      {
        this.colidgoodpricegroup,
        this.colname,
        this.colcomment,
        this.colprice1,
        this.colprice2,
        this.col_s,
        this.colprice1toprice2
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colidgoodpricegroup.Caption = "#";
            this.colidgoodpricegroup.FieldName = "idgoodpricegroup";
            this.colidgoodpricegroup.Name = "colidgoodpricegroup";
            this.colidgoodpricegroup.OptionsColumn.AllowEdit = false;
            this.colidgoodpricegroup.Visible = true;
            this.colidgoodpricegroup.VisibleIndex = 6;
            this.colidgoodpricegroup.Width = 51;
            this.colname.Caption = "Наименование группы";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 203;
            this.colcomment.Caption = "Описание";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 5;
            this.colcomment.Width = 383;
            this.colprice1.Caption = "Коэф. прих. цены";
            this.colprice1.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit1;
            this.colprice1.FieldName = "price1";
            this.colprice1.Name = "colprice1";
            this.colprice1.Visible = true;
            this.colprice1.VisibleIndex = 3;
            this.colprice1.Width = 105;
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            this.colprice2.Caption = "Коэф. расх. цены";
            this.colprice2.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit2;
            this.colprice2.FieldName = "price2";
            this.colprice2.Name = "colprice2";
            this.colprice2.Visible = true;
            this.colprice2.VisibleIndex = 4;
            this.colprice2.Width = 102;
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            this.col_s.AppearanceHeader.Options.UseTextOptions = true;
            this.col_s.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            this.col_s.FieldName = "_s";
            this.col_s.Name = "col_s";
            this.col_s.Visible = true;
            this.col_s.VisibleIndex = 0;
            this.col_s.Width = 25;
            this.colprice1toprice2.Caption = "Коэф. Ц1-Ц2";
            this.colprice1toprice2.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit3;
            this.colprice1toprice2.FieldName = "price1toprice2";
            this.colprice1toprice2.Name = "colprice1toprice2";
            this.colprice1toprice2.Visible = true;
            this.colprice1toprice2.VisibleIndex = 2;
            this.colprice1toprice2.Width = 91;
            this.repositoryItemCalcEdit3.AutoHeight = false;
            this.repositoryItemCalcEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit3.Name = "repositoryItemCalcEdit3";
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n4";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n4";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(876, 33);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(789, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отменить";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.OK;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(708, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выбрать";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "GoodPriceUpdateForm";
            this.Size = new Size(876, 428);
            this.Text = "Группы переоценки";
            this.panel1.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_goodpricegroup.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemCalcEdit1.EndInit();
            this.repositoryItemCalcEdit2.EndInit();
            this.repositoryItemCalcEdit3.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void GoodPriceUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) > 0 && MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.SaveToBase();
            this.col_s.Visible = true;
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from goodpricegroup where deleted is null";
            this.db.adapter.Fill(this.table_goodpricegroup);
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDatatable2(this.table_goodpricegroup))
                return false;
            this.table_goodpricegroup.AcceptChanges();
            return true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_goodpricegroup.NewRow();
            this.table_goodpricegroup.Rows.Add(row);
            row["idgoodpricegroup"] = (object)dbconn.GetGenId("gen_goodpricegroup");
            row["price1"] = (object)1;
            row["price2"] = (object)1;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds.Clear();
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdUpdatePrice_Click(object sender, EventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) > 0)
                this.SaveToBase();
            DataRow[] dr_event = this.table_goodpricegroup.Select("_s = 1");
            if (dr_event.Length == 0)
                return;
            Goods.CancelUpdatePrice = false;
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Перед переоценкой материалов", dr_event, false);
            if (!Goods.CancelUpdatePrice)
            {
                foreach (DataRow dataRow in dr_event)
                    this.db.ExecuteFunction("good_pricegroup_refresh " + dataRow["idgoodpricegroup"].ToString());
            }
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.После переоценки материалов", dr_event, false);
            Goods.Reload();
        }

        public void IsDialog()
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.gridView1.OptionsBehavior.Editable = false;
            this.col_s.Visible = false;
        }
    }
}
