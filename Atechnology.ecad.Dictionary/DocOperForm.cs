// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.DocOperForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class DocOperForm : AtUserControl
    {
        public int isdialog;
        private IContainer components;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private GridView gridViewDocOper;
        private DataSet ds;
        private DataTable table_docoper;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private GridColumn colname;
        private GridColumn colprefix;
        private GridColumn colsuffix;
        private GridColumn colnumpos;
        private GridColumn colcomment;
        private DataColumn dataColumn7;
        private GridColumn coldocgroup;
        private Panel panel2;
        public GridControl gridControlDocOper;
        private DataColumn dataColumn8;
        private GridColumn coldoctype;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private DataColumn dataColumn9;
        private GridColumn coltyp;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private GridColumn colagreenumpos;
        private GridColumn colagreeprefix;
        private GridColumn colagreesuffix;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit2;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private GridColumn colstoretyp_name;
        private RepositoryItemComboBox repositoryItemComboBox2;
        private DataColumn dataColumn15;
        private DataColumn dataColumn16;
        private GridColumn coladdstr;
        private GridColumn coladdint;
        public Button button4;
        public Button button5;
        private DataTable table_docappearance;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private DataColumn dataColumn19;
        private DataColumn dataColumn20;
        private DataColumn dataColumn21;
        private DataColumn dataColumn22;
        private GridColumn colindealerbase;
        private GridColumn gridColumn1;

        public DocOperForm()
        {
            this.InitializeComponent();
            this.gridViewDocOper.ActiveFilter.Clear();
            this.LoadFromBase(-1);
            this.GetDocTypes();
            this.Shown += new Shown(this.DocOperForm_Shown);
            this.gridViewDocOper.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
            this.repositoryItemComboBox1.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBox1_ParseEditValue);
            this.FormClosing += new FormClosing(this.DocOperForm_FormClosing);
            this.gridViewDocOper.KeyDown += new KeyEventHandler(this.gridView1_KeyDown);
            this.repositoryItemComboBox2.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBox2_ParseEditValue);
        }

        private void DocOperForm_Shown(object sender, EventArgs e)
        {
            if (this.Is_Dialog)
                this.gridViewDocOper.OptionsBehavior.Editable = false;
            else
                this.gridViewDocOper.OptionsBehavior.Editable = true;
        }

        private void repositoryItemComboBox2_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            StoreDocType storeDocType = (StoreDocType)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)storeDocType.Name;
            AtGrid.getDataRow((Control)this.gridControlDocOper)["storetyp"] = (object)storeDocType.typ;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.isdialog != 1 || e.KeyCode != Keys.Return)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DocOperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) <= 0)
                return;
            switch (MessageBox.Show("Сохранить изменения?", "Закрытие формы типов документов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.OK:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void repositoryItemComboBox1_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            DocType docType = (DocType)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)docType.Name;
            AtGrid.getDataRow((Control)this.gridControlDocOper)["iddocappearance"] = (object)docType.iddocappearance;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.isdialog != 1)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadFromBase(int typ)
        {
            this.table_docoper.Rows.Clear();
            if (this.isdialog == 1)
                this.db.command.CommandText = string.Concat(new object[4]
        {
          (object) "select * from dbo.f_getdocoper (",
          (object) Settings.People.idpeople,
          (object) ") where deleted is null and _grant = 1 and iddocappearance =",
          (object) typ
        });
            else
                this.db.command.CommandText = "select * from view_docoper where deleted is null";
            this.db.adapter.Fill(this.table_docoper);
        }

        public override bool SaveToBase()
        {
            if (this.table_docoper.Columns["typ"] != null)
                this.table_docoper.Columns["typ"].Prefix = "local";
            if (!this.db.SaveDatatable2(this.table_docoper))
                return false;
            this.table_docoper.AcceptChanges();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds.Clear();
            this.LoadFromBase(-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_docoper.NewRow();
            row["iddocoper"] = (object)dbconn.GetGenId("gen_docoper");
            row["name"] = (object)"Новый документ";
            row["numpos"] = (object)1;
            row["storetyp"] = (object)0;
            row["storetyp_name"] = (object)"Приход";
            row["indealerbase"] = (object)0;
            this.table_docoper.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlDocOper);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["iddocoper"] = (object)dbconn.GetGenId("gen_docoper");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlDocOper);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        public void IsDialog(int typ_doc)
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridViewDocOper.OptionsBehavior.Editable = false;
            this.gridControlDocOper.ContextMenuStrip = (ContextMenuStrip)null;
            this.isdialog = 1;
            this.LoadFromBase(typ_doc);
            this.gridViewDocOper.Columns.Remove(this.colindealerbase);
        }

        public List<DocType> GetDocTypes()
        {
            List<DocType> list = new List<DocType>();
            foreach (DataRow dr in (InternalDataCollectionBase)this.db.GetDataTable2("select * from docappearance where deleted is null").Rows)
            {
                list.Add(new DocType(dr));
                this.repositoryItemComboBox1.Items.Add((object)list[list.Count - 1]);
            }
            this.repositoryItemComboBox2.Items.Add((object)new StoreDocType("Приход", 0));
            this.repositoryItemComboBox2.Items.Add((object)new StoreDocType("Расход", 1));
            this.repositoryItemComboBox2.Items.Add((object)new StoreDocType("Перемещение", 2));
            return list;
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
            this.gridControlDocOper = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_docoper = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn15 = new DataColumn();
            this.dataColumn16 = new DataColumn();
            this.dataColumn21 = new DataColumn();
            this.dataColumn22 = new DataColumn();
            this.table_docappearance = new DataTable();
            this.dataColumn17 = new DataColumn();
            this.dataColumn18 = new DataColumn();
            this.dataColumn19 = new DataColumn();
            this.dataColumn20 = new DataColumn();
            this.gridViewDocOper = new GridView();
            this.colname = new GridColumn();
            this.colprefix = new GridColumn();
            this.colsuffix = new GridColumn();
            this.colnumpos = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.colcomment = new GridColumn();
            this.coldocgroup = new GridColumn();
            this.coldoctype = new GridColumn();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.coltyp = new GridColumn();
            this.colagreenumpos = new GridColumn();
            this.repositoryItemTextEdit2 = new AtRepositoryItemTextEdit();
            this.colagreeprefix = new GridColumn();
            this.colagreesuffix = new GridColumn();
            this.colstoretyp_name = new GridColumn();
            this.repositoryItemComboBox2 = new RepositoryItemComboBox();
            this.coladdstr = new GridColumn();
            this.coladdint = new GridColumn();
            this.colindealerbase = new GridColumn();
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.gridColumn1 = new GridColumn();
            this.panel1.SuspendLayout();
            this.gridControlDocOper.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_docoper.BeginInit();
            this.table_docappearance.BeginInit();
            this.gridViewDocOper.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemComboBox1.BeginInit();
            this.repositoryItemTextEdit2.BeginInit();
            this.repositoryItemComboBox2.BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(821, 33);
            this.panel1.TabIndex = 0;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(734, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(653, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(572, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControlDocOper.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlDocOper.DataMember = "docoper";
            this.gridControlDocOper.DataSource = (object)this.ds;
            this.gridControlDocOper.Dock = DockStyle.Fill;
            this.gridControlDocOper.EmbeddedNavigator.Name = "";
            this.gridControlDocOper.Location = new Point(0, 0);
            this.gridControlDocOper.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlDocOper.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlDocOper.MainView = (BaseView)this.gridViewDocOper;
            this.gridControlDocOper.Name = "gridControlDocOper";
            this.gridControlDocOper.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemTextEdit2,
        (RepositoryItem) this.repositoryItemComboBox2
      });
            this.gridControlDocOper.Size = new Size(821, 369);
            this.gridControlDocOper.TabIndex = 1;
            this.gridControlDocOper.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewDocOper
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem3
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(220, 76);
            this.toolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItem1.Size = new Size(219, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItem2.Size = new Size(219, 22);
            this.toolStripMenuItem2.Text = "Дублировать";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(216, 6);
            this.toolStripMenuItem3.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItem3.Size = new Size(219, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.ds.DataSetName = "ds_docoper";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[2]
      {
        this.table_docoper,
        this.table_docappearance
      });
            this.table_docoper.Columns.AddRange(new DataColumn[18]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn9,
        this.dataColumn10,
        this.dataColumn11,
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14,
        this.dataColumn15,
        this.dataColumn16,
        this.dataColumn21,
        this.dataColumn22
      });
            this.table_docoper.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "iddocoper"
        }, 1 != 0)
      });
            this.table_docoper.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_docoper.TableName = "docoper";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "iddocoper";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "prefix";
            this.dataColumn4.ColumnName = "suffix";
            this.dataColumn5.ColumnName = "numpos";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "comment";
            this.dataColumn7.ColumnName = "docgroup";
            this.dataColumn8.ColumnName = "doctype";
            this.dataColumn8.Prefix = "local";
            this.dataColumn9.ColumnName = "typ";
            this.dataColumn9.DataType = typeof(int);
            this.dataColumn10.ColumnName = "agreenumpos";
            this.dataColumn10.DataType = typeof(int);
            this.dataColumn11.ColumnName = "agreeprefix";
            this.dataColumn12.ColumnName = "agreesuffix";
            this.dataColumn13.ColumnName = "storetyp_name";
            this.dataColumn14.ColumnName = "storetyp";
            this.dataColumn14.DataType = typeof(short);
            this.dataColumn15.ColumnName = "addstr";
            this.dataColumn16.ColumnName = "addint";
            this.dataColumn16.DataType = typeof(double);
            this.dataColumn21.ColumnName = "iddocappearance";
            this.dataColumn21.DataType = typeof(int);
            this.dataColumn22.ColumnName = "indealerbase";
            this.dataColumn22.DataType = typeof(bool);
            this.table_docappearance.Columns.AddRange(new DataColumn[4]
      {
        this.dataColumn17,
        this.dataColumn18,
        this.dataColumn19,
        this.dataColumn20
      });
            this.table_docappearance.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "iddocappearance"
        }, 1 != 0)
      });
            this.table_docappearance.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn17
      };
            this.table_docappearance.TableName = "docappearance";
            this.dataColumn17.AllowDBNull = false;
            this.dataColumn17.ColumnName = "iddocappearance";
            this.dataColumn17.DataType = typeof(short);
            this.dataColumn18.ColumnName = "name";
            this.dataColumn19.ColumnName = "tablename";
            this.dataColumn20.ColumnName = "comment";
            this.gridViewDocOper.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewDocOper.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDocOper.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewDocOper.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewDocOper.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewDocOper.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewDocOper.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewDocOper.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewDocOper.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewDocOper.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDocOper.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewDocOper.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDocOper.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewDocOper.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewDocOper.BorderStyle = BorderStyles.Simple;
            this.gridViewDocOper.Columns.AddRange(new GridColumn[16]
      {
        this.gridColumn1,
        this.colname,
        this.colprefix,
        this.colsuffix,
        this.colnumpos,
        this.colcomment,
        this.coldocgroup,
        this.coldoctype,
        this.coltyp,
        this.colagreenumpos,
        this.colagreeprefix,
        this.colagreesuffix,
        this.colstoretyp_name,
        this.coladdstr,
        this.coladdint,
        this.colindealerbase
      });
            this.gridViewDocOper.GridControl = this.gridControlDocOper;
            this.gridViewDocOper.GroupPanelText = "Панель группировки";
            this.gridViewDocOper.Name = "gridViewDocOper";
            this.gridViewDocOper.OptionsCustomization.AllowFilter = false;
            this.gridViewDocOper.OptionsDetail.ShowDetailTabs = false;
            this.gridViewDocOper.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewDocOper.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewDocOper.OptionsView.ShowIndicator = false;
            this.colname.Caption = "Наименование документа";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 4;
            this.colname.Width = 186;
            this.colprefix.Caption = "Префикс";
            this.colprefix.FieldName = "prefix";
            this.colprefix.Name = "colprefix";
            this.colprefix.Visible = true;
            this.colprefix.VisibleIndex = 5;
            this.colprefix.Width = 69;
            this.colsuffix.Caption = "Суффикс";
            this.colsuffix.FieldName = "suffix";
            this.colsuffix.Name = "colsuffix";
            this.colsuffix.Visible = true;
            this.colsuffix.VisibleIndex = 7;
            this.colsuffix.Width = 69;
            this.colnumpos.Caption = "№пп";
            this.colnumpos.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 6;
            this.colnumpos.Width = 51;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n0";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 11;
            this.coldocgroup.Caption = "Группа";
            this.coldocgroup.FieldName = "docgroup";
            this.coldocgroup.Name = "coldocgroup";
            this.coldocgroup.Visible = true;
            this.coldocgroup.VisibleIndex = 3;
            this.coldoctype.Caption = "Тип документа";
            this.coldoctype.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox1;
            this.coldoctype.FieldName = "doctype";
            this.coldoctype.Name = "coldoctype";
            this.coldoctype.Visible = true;
            this.coldoctype.VisibleIndex = 1;
            this.coldoctype.Width = 66;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.coltyp.Caption = "typ";
            this.coltyp.FieldName = "typ";
            this.coltyp.Name = "coltyp";
            this.colagreenumpos.Caption = "№пп договора";
            this.colagreenumpos.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit2;
            this.colagreenumpos.FieldName = "agreenumpos";
            this.colagreenumpos.Name = "colagreenumpos";
            this.colagreenumpos.Visible = true;
            this.colagreenumpos.VisibleIndex = 9;
            this.colagreenumpos.Width = 55;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEdit2.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit2.EditFormat.FormatString = "n0";
            this.repositoryItemTextEdit2.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.colagreeprefix.Caption = "Префикс договора";
            this.colagreeprefix.FieldName = "agreeprefix";
            this.colagreeprefix.Name = "colagreeprefix";
            this.colagreeprefix.Visible = true;
            this.colagreeprefix.VisibleIndex = 8;
            this.colagreesuffix.Caption = "Суффикс договора";
            this.colagreesuffix.FieldName = "agreesuffix";
            this.colagreesuffix.Name = "colagreesuffix";
            this.colagreesuffix.Visible = true;
            this.colagreesuffix.VisibleIndex = 10;
            this.colstoretyp_name.Caption = "Тип складской";
            this.colstoretyp_name.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox2;
            this.colstoretyp_name.FieldName = "storetyp_name";
            this.colstoretyp_name.Name = "colstoretyp_name";
            this.colstoretyp_name.Visible = true;
            this.colstoretyp_name.VisibleIndex = 2;
            this.colstoretyp_name.Width = 55;
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.coladdstr.Caption = "Доп. строка";
            this.coladdstr.FieldName = "addstr";
            this.coladdstr.Name = "coladdstr";
            this.coladdstr.Visible = true;
            this.coladdstr.VisibleIndex = 12;
            this.coladdint.Caption = "Доп. число";
            this.coladdint.FieldName = "addint";
            this.coladdint.Name = "coladdint";
            this.coladdint.Visible = true;
            this.coladdint.VisibleIndex = 13;
            this.colindealerbase.Caption = "Дилеру";
            this.colindealerbase.FieldName = "indealerbase";
            this.colindealerbase.Name = "colindealerbase";
            this.colindealerbase.Visible = true;
            this.colindealerbase.VisibleIndex = 14;
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(821, 33);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(734, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отмена";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.OK;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(653, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выбрать";
            this.gridColumn1.Caption = "#";
            this.gridColumn1.FieldName = "iddocoper";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlDocOper);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "DocOperForm";
            this.Size = new Size(821, 435);
            this.Text = "Типы документов";
            this.panel1.ResumeLayout(false);
            this.gridControlDocOper.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_docoper.EndInit();
            this.table_docappearance.EndInit();
            this.gridViewDocOper.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemComboBox1.EndInit();
            this.repositoryItemTextEdit2.EndInit();
            this.repositoryItemComboBox2.EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
