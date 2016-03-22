// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodTypeForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
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
    public class GoodTypeForm : AtUserControl
    {
        private IContainer components;
        private Button button3;
        private Button button2;
        private Button button1;
        public GridControl gridControl1;
        private GridView gridView1;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private DataSet ds;
        private DataTable table_goodtype;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colnumpos;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private GridColumn colnumpos2;
        private GridColumn colnumpos3;
        private Panel panel2;
        protected Panel panel1;
        private Button button5;
        private Button button4;

        public Button DefaultButton
        {
            get
            {
                return this.button4;
            }
        }

        public Button CancelButton
        {
            get
            {
                return this.button5;
            }
        }

        public GoodTypeForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.GoodTypeForm_FormClosing);
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
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.gridControl1 = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_goodtype = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.gridView1 = new GridView();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colnumpos = new GridColumn();
            this.colnumpos2 = new GridColumn();
            this.colnumpos3 = new GridColumn();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.panel1.SuspendLayout();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_goodtype.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemComboBox1.BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(704, 33);
            this.panel1.TabIndex = 1;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(617, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(536, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(455, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "goodtype";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(0, 0);
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemComboBox1
      });
            this.gridControl1.Size = new Size(704, 370);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem3
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(154, 76);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(153, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(153, 22);
            this.toolStripMenuItem2.Text = "Дублировать";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(150, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(153, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.ds.DataSetName = "ds";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_goodtype
      });
            this.table_goodtype.Columns.AddRange(new DataColumn[6]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6
      });
            this.table_goodtype.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodtype"
        }, 1 != 0)
      });
            this.table_goodtype.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_goodtype.TableName = "goodtype";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idgoodtype";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "numpos";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "numpos2";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "numpos3";
            this.dataColumn6.DataType = typeof(int);
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
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
            this.gridView1.Columns.AddRange(new GridColumn[5]
      {
        this.colname,
        this.colcomment,
        this.colnumpos,
        this.colnumpos2,
        this.colnumpos3
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colname.Caption = "Наименование типа";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 3;
            this.colname.Width = 366;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 4;
            this.colcomment.Width = 371;
            this.colnumpos.Caption = "№пп";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 0;
            this.colnumpos.Width = 60;
            this.colnumpos2.Caption = "№пп 2";
            this.colnumpos2.FieldName = "numpos2";
            this.colnumpos2.Name = "colnumpos2";
            this.colnumpos2.Visible = true;
            this.colnumpos2.VisibleIndex = 1;
            this.colnumpos2.Width = 65;
            this.colnumpos3.Caption = "№пп 3";
            this.colnumpos3.FieldName = "numpos3";
            this.colnumpos3.Name = "colnumpos3";
            this.colnumpos3.Visible = true;
            this.colnumpos3.VisibleIndex = 2;
            this.colnumpos3.Width = 70;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(704, 33);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.OK;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(536, 4);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Выбрать";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.Cancel;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(617, 4);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Отменить";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "GoodTypeForm";
            this.Size = new Size(704, 436);
            this.Text = "Типы материалов";
            this.panel1.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_goodtype.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemComboBox1.EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.table_goodtype.Clear();
            this.table_goodtype.AcceptChanges();
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from goodtype where deleted is null";
            this.db.adapter.Fill(this.table_goodtype);
        }

        public override bool SaveToBase()
        {
            return this.db.SaveDatatableAndAccept2(this.table_goodtype);
        }

        private void GoodTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_goodtype.NewRow();
            row["idgoodtype"] = (object)dbconn.GetGenId("gen_goodtype");
            row["name"] = (object)"Новая группа";
            this.table_goodtype.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["idgoodtype"] = (object)dbconn.GetGenId("gen_goodtype");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow1 == null || Goods.ds == null || Goods.ds.good == null)
                return;
            string filterExpression = string.Format("idgoodtype = {0} OR idgoodtype2 = {0}", dataRow1["idgoodtype"]);
            DataRow[] dataRowArray = Goods.ds.good.Select(filterExpression);
            if (dataRowArray.Length > 0 && MessageBox.Show(string.Format("Имеются материалы с удаляемым типов, типы будут обнулены.{0}Продолжить?", (object)Environment.NewLine), "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (DataRow dataRow2 in dataRowArray)
                {
                    if (dataRow2["idgoodtype"] == dataRow1["idgoodtype"])
                        dataRow2["idgoodtype"] = (object)DBNull.Value;
                    if (dataRow2["idgoodtype2"] == dataRow1["idgoodtype"])
                        dataRow2["idgoodtype2"] = (object)DBNull.Value;
                }
            }
            dataRow1.Delete();
        }

        public void IsDialog()
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.gridView1.OptionsSelection.MultiSelect = true;
        }
    }
}
