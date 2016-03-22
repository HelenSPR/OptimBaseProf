// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodOptimForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class GoodOptimForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        public GridControl gridControl1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private DataSet ds;
        private DataTable table_goodoptim;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        public Panel panel2;
        private Button button4;
        private Button button5;
        private DataColumn dataColumn9;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private AdvBandedGridView advBandedGridView1;
        private GridBand gridBand1;
        private BandedGridColumn colidgoodoptim;
        private BandedGridColumn colname;
        private BandedGridColumn colcomment;
        private BandedGridColumn colbuffer;
        private GridBand gridBand2;
        private BandedGridColumn colwhiplen;
        private BandedGridColumn colworklen;
        private BandedGridColumn colstep;
        private BandedGridColumn colfreza;
        private BandedGridColumn coldrez;
        private GridBand gridBand3;
        private BandedGridColumn coldl;
        private BandedGridColumn coldr;
        private BandedGridColumn coldt;
        private BandedGridColumn coldb;
        private BandedGridColumn colmaxrez;
        private DataColumn dataColumn15;
        private DataColumn dataColumn16;
        private BandedGridColumn coltyp_name;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private BandedGridColumn colwidth;
        private BandedGridColumn colheight;
        private DataColumn dataColumn19;
        private BandedGridColumn colcanrotate;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DataColumn dataColumn20;
        private DataColumn dataColumn21;
        private BandedGridColumn coltyperez_name;
        private RepositoryItemComboBox cboTyperez_name;
        private BandedGridColumn optimtype_name;
        private RepositoryItemComboBox repositoryItemComboBox2;
        private BandedGridColumn maxworkrests;
        private DataColumn typeoptimend;
        private DataColumn dopuskoptim;
        private BandedGridColumn coldopuskoptim;
        private BandedGridColumn coltypeoptimend;
        private RepositoryItemComboBox repositoryItemComboBoxcoltypeoptimend;
        private DataColumn dataColumn22;

        public GoodOptimForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.GoodOptimForm_FormClosing);
            this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
            this.repositoryItemComboBox1.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBox1_ParseEditValue);
            this.repositoryItemComboBox2.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBox2_ParseEditValue);
            this.cboTyperez_name.SelectedIndexChanged += new EventHandler(this.cboTyperez_name_SelectedIndexChanged);
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
            this.table_goodoptim = new DataTable();
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
            this.dataColumn17 = new DataColumn();
            this.dataColumn18 = new DataColumn();
            this.dataColumn19 = new DataColumn();
            this.dataColumn20 = new DataColumn();
            this.dataColumn21 = new DataColumn();
            this.typeoptimend = new DataColumn();
            this.dopuskoptim = new DataColumn();
            this.dataColumn22 = new DataColumn();
            this.advBandedGridView1 = new AdvBandedGridView();
            this.gridBand1 = new GridBand();
            this.colidgoodoptim = new BandedGridColumn();
            this.coltyp_name = new BandedGridColumn();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.colname = new BandedGridColumn();
            this.colcomment = new BandedGridColumn();
            this.colbuffer = new BandedGridColumn();
            this.colfreza = new BandedGridColumn();
            this.colworklen = new BandedGridColumn();
            this.coldrez = new BandedGridColumn();
            this.optimtype_name = new BandedGridColumn();
            this.repositoryItemComboBox2 = new RepositoryItemComboBox();
            this.maxworkrests = new BandedGridColumn();
            this.gridBand2 = new GridBand();
            this.colwhiplen = new BandedGridColumn();
            this.colstep = new BandedGridColumn();
            this.coldopuskoptim = new BandedGridColumn();
            this.coltypeoptimend = new BandedGridColumn();
            this.repositoryItemComboBoxcoltypeoptimend = new RepositoryItemComboBox();
            this.gridBand3 = new GridBand();
            this.colcanrotate = new BandedGridColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.coldl = new BandedGridColumn();
            this.coldr = new BandedGridColumn();
            this.coldt = new BandedGridColumn();
            this.coldb = new BandedGridColumn();
            this.colmaxrez = new BandedGridColumn();
            this.colwidth = new BandedGridColumn();
            this.colheight = new BandedGridColumn();
            this.coltyperez_name = new BandedGridColumn();
            this.cboTyperez_name = new RepositoryItemComboBox();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.panel1.SuspendLayout();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_goodoptim.BeginInit();
            this.advBandedGridView1.BeginInit();
            this.repositoryItemComboBox1.BeginInit();
            this.repositoryItemComboBox2.BeginInit();
            this.repositoryItemComboBoxcoltypeoptimend.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.cboTyperez_name.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(896, 33);
            this.panel1.TabIndex = 4;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(809, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(728, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(647, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "goodoptim";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(0, 0);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[6]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.repositoryItemCheckEdit1,
        (RepositoryItem) this.cboTyperez_name,
        (RepositoryItem) this.repositoryItemComboBox2,
        (RepositoryItem) this.repositoryItemComboBoxcoltypeoptimend
      });
            this.gridControl1.Size = new Size(896, 418);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.advBandedGridView1
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem3
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(143, 76);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(142, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(142, 22);
            this.toolStripMenuItem2.Text = "Дублировать";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(139, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(142, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.ds.DataSetName = "ds";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_goodoptim
      });
            this.table_goodoptim.Columns.AddRange(new DataColumn[24]
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
        this.dataColumn17,
        this.dataColumn18,
        this.dataColumn19,
        this.dataColumn20,
        this.dataColumn21,
        this.typeoptimend,
        this.dopuskoptim,
        this.dataColumn22
      });
            this.table_goodoptim.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodoptim"
        }, 1 != 0)
      });
            this.table_goodoptim.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_goodoptim.TableName = "goodoptim";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idgoodoptim";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "whiplen";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "worklen";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "step";
            this.dataColumn6.DataType = typeof(int);
            this.dataColumn7.ColumnName = "freza";
            this.dataColumn7.DataType = typeof(int);
            this.dataColumn8.ColumnName = "buffer";
            this.dataColumn8.DataType = typeof(int);
            this.dataColumn9.ColumnName = "dl";
            this.dataColumn9.DataType = typeof(int);
            this.dataColumn10.ColumnName = "dr";
            this.dataColumn10.DataType = typeof(int);
            this.dataColumn11.ColumnName = "dt";
            this.dataColumn11.DataType = typeof(int);
            this.dataColumn12.ColumnName = "db";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.ColumnName = "drez";
            this.dataColumn13.DataType = typeof(int);
            this.dataColumn14.ColumnName = "maxrez";
            this.dataColumn14.DataType = typeof(int);
            this.dataColumn15.ColumnName = "typ";
            this.dataColumn15.DataType = typeof(short);
            this.dataColumn16.ColumnName = "typ_name";
            this.dataColumn17.ColumnName = "width";
            this.dataColumn17.DataType = typeof(int);
            this.dataColumn18.ColumnName = "height";
            this.dataColumn18.DataType = typeof(int);
            this.dataColumn19.ColumnName = "canrotate";
            this.dataColumn19.DataType = typeof(bool);
            this.dataColumn20.ColumnName = "typerez";
            this.dataColumn20.DataType = typeof(int);
            this.dataColumn21.ColumnName = "typerez_name";
            this.typeoptimend.AllowDBNull = false;
            this.typeoptimend.ColumnName = "typeoptimend";
            this.typeoptimend.DataType = typeof(int);
            this.typeoptimend.DefaultValue = (object)0;
            this.dopuskoptim.AllowDBNull = false;
            this.dopuskoptim.ColumnName = "dopuskoptim";
            this.dopuskoptim.DataType = typeof(int);
            this.dopuskoptim.DefaultValue = (object)0;
            this.dataColumn22.ColumnName = "typeoptimend_name";
            this.dataColumn22.DefaultValue = (object)"На одном хлысте";
            this.advBandedGridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.FocusedRow.ForeColor = Color.Black;
            this.advBandedGridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.advBandedGridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.advBandedGridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.advBandedGridView1.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.advBandedGridView1.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.advBandedGridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.advBandedGridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.advBandedGridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.advBandedGridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.advBandedGridView1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.advBandedGridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.advBandedGridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.advBandedGridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.advBandedGridView1.Bands.AddRange(new GridBand[3]
      {
        this.gridBand1,
        this.gridBand2,
        this.gridBand3
      });
            this.advBandedGridView1.BorderStyle = BorderStyles.Simple;
            this.advBandedGridView1.Columns.AddRange(new BandedGridColumn[23]
      {
        this.colidgoodoptim,
        this.colname,
        this.colcomment,
        this.colwhiplen,
        this.colworklen,
        this.colstep,
        this.colfreza,
        this.colbuffer,
        this.coldl,
        this.coldr,
        this.coldt,
        this.coldb,
        this.coldrez,
        this.colmaxrez,
        this.coltyp_name,
        this.colwidth,
        this.colheight,
        this.colcanrotate,
        this.coltyperez_name,
        this.optimtype_name,
        this.maxworkrests,
        this.coltypeoptimend,
        this.coldopuskoptim
      });
            this.advBandedGridView1.CustomizationFormBounds = new Rectangle(1197, 445, 212, 180);
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.GroupPanelText = "Панель группировки";
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsCustomization.AllowFilter = false;
            this.advBandedGridView1.OptionsSelection.MultiSelect = true;
            this.advBandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.advBandedGridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.OptionsView.ShowIndicator = false;
            this.gridBand1.AppearanceHeader.BackColor = Color.White;
            this.gridBand1.AppearanceHeader.BorderColor = Color.White;
            this.gridBand1.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand1.AppearanceHeader.Options.UseBorderColor = true;
            this.gridBand1.Caption = "Общее";
            this.gridBand1.Columns.Add(this.colidgoodoptim);
            this.gridBand1.Columns.Add(this.coltyp_name);
            this.gridBand1.Columns.Add(this.colname);
            this.gridBand1.Columns.Add(this.colcomment);
            this.gridBand1.Columns.Add(this.colbuffer);
            this.gridBand1.Columns.Add(this.colfreza);
            this.gridBand1.Columns.Add(this.colworklen);
            this.gridBand1.Columns.Add(this.coldrez);
            this.gridBand1.Columns.Add(this.optimtype_name);
            this.gridBand1.Columns.Add(this.maxworkrests);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 609;
            this.colidgoodoptim.Caption = "#";
            this.colidgoodoptim.FieldName = "idgoodoptim";
            this.colidgoodoptim.Name = "colidgoodoptim";
            this.colidgoodoptim.OptionsColumn.AllowEdit = false;
            this.colidgoodoptim.Visible = true;
            this.colidgoodoptim.Width = 20;
            this.coltyp_name.Caption = "Тип";
            this.coltyp_name.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox1;
            this.coltyp_name.FieldName = "typ_name";
            this.coltyp_name.Name = "coltyp_name";
            this.coltyp_name.Visible = true;
            this.coltyp_name.Width = 29;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.Width = 85;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.Width = 79;
            this.colbuffer.Caption = "Буфер";
            this.colbuffer.FieldName = "buffer";
            this.colbuffer.Name = "colbuffer";
            this.colbuffer.Visible = true;
            this.colbuffer.Width = 43;
            this.colfreza.Caption = "Фреза";
            this.colfreza.FieldName = "freza";
            this.colfreza.Name = "colfreza";
            this.colfreza.Visible = true;
            this.colfreza.Width = 42;
            this.colworklen.Caption = "Остаток";
            this.colworklen.FieldName = "worklen";
            this.colworklen.Name = "colworklen";
            this.colworklen.Visible = true;
            this.colworklen.Width = 54;
            this.coldrez.Caption = "Отступ";
            this.coldrez.FieldName = "drez";
            this.coldrez.Name = "coldrez";
            this.coldrez.Visible = true;
            this.coldrez.Width = 48;
            this.optimtype_name.Caption = "Версия";
            this.optimtype_name.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox2;
            this.optimtype_name.FieldName = "optimtype_name";
            this.optimtype_name.Name = "optimtype_name";
            this.optimtype_name.Visible = true;
            this.optimtype_name.Width = 46;
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.maxworkrests.Caption = "Деловые остатки (максимум)";
            this.maxworkrests.FieldName = "maxworkrests";
            this.maxworkrests.Name = "maxworkrests";
            this.maxworkrests.Visible = true;
            this.maxworkrests.Width = 163;
            this.gridBand2.AppearanceHeader.BackColor = Color.FromArgb((int)byte.MaxValue, 128, 128);
            this.gridBand2.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand2.Caption = "Линейная оптимизация";
            this.gridBand2.Columns.Add(this.colwhiplen);
            this.gridBand2.Columns.Add(this.colstep);
            this.gridBand2.Columns.Add(this.coldopuskoptim);
            this.gridBand2.Columns.Add(this.coltypeoptimend);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 372;
            this.colwhiplen.Caption = "Длина";
            this.colwhiplen.FieldName = "whiplen";
            this.colwhiplen.Name = "colwhiplen";
            this.colwhiplen.Visible = true;
            this.colwhiplen.Width = 42;
            this.colstep.Caption = "Шаг";
            this.colstep.FieldName = "step";
            this.colstep.Name = "colstep";
            this.colstep.Visible = true;
            this.colstep.Width = 31;
            this.coldopuskoptim.Caption = "Диапазон соед. вх. остатков";
            this.coldopuskoptim.FieldName = "dopuskoptim";
            this.coldopuskoptim.Name = "coldopuskoptim";
            this.coldopuskoptim.Visible = true;
            this.coldopuskoptim.Width = 159;
            this.coltypeoptimend.Caption = "Тип отпимизации остатка";
            this.coltypeoptimend.ColumnEdit = (RepositoryItem)this.repositoryItemComboBoxcoltypeoptimend;
            this.coltypeoptimend.FieldName = "typeoptimend_name";
            this.coltypeoptimend.Name = "coltypeoptimend";
            this.coltypeoptimend.Visible = true;
            this.coltypeoptimend.Width = 140;
            this.repositoryItemComboBoxcoltypeoptimend.AutoHeight = false;
            this.repositoryItemComboBoxcoltypeoptimend.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBoxcoltypeoptimend.Name = "repositoryItemComboBoxcoltypeoptimend";
            this.repositoryItemComboBoxcoltypeoptimend.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.repositoryItemComboBoxcoltypeoptimend.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBoxcoltypeoptimend_ParseEditValue);
            this.gridBand3.AppearanceHeader.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.gridBand3.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand3.Caption = "Плоскостная оптимзация";
            this.gridBand3.Columns.Add(this.colcanrotate);
            this.gridBand3.Columns.Add(this.coldl);
            this.gridBand3.Columns.Add(this.coldr);
            this.gridBand3.Columns.Add(this.coldt);
            this.gridBand3.Columns.Add(this.coldb);
            this.gridBand3.Columns.Add(this.colmaxrez);
            this.gridBand3.Columns.Add(this.colwidth);
            this.gridBand3.Columns.Add(this.colheight);
            this.gridBand3.Columns.Add(this.coltyperez_name);
            this.gridBand3.MinWidth = 20;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 415;
            this.colcanrotate.Caption = "Не вращать";
            this.colcanrotate.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit1;
            this.colcanrotate.FieldName = "canrotate";
            this.colcanrotate.Name = "colcanrotate";
            this.colcanrotate.Visible = true;
            this.colcanrotate.Width = 71;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.coldl.Caption = "dl";
            this.coldl.FieldName = "dl";
            this.coldl.Name = "coldl";
            this.coldl.Visible = true;
            this.coldl.Width = 20;
            this.coldr.Caption = "dr";
            this.coldr.FieldName = "dr";
            this.coldr.Name = "coldr";
            this.coldr.Visible = true;
            this.coldr.Width = 20;
            this.coldt.Caption = "dt";
            this.coldt.FieldName = "dt";
            this.coldt.Name = "coldt";
            this.coldt.Visible = true;
            this.coldt.Width = 20;
            this.coldb.Caption = "db";
            this.coldb.FieldName = "db";
            this.coldb.Name = "coldb";
            this.coldb.Visible = true;
            this.coldb.Width = 22;
            this.colmaxrez.Caption = "Макс.рез";
            this.colmaxrez.FieldName = "maxrez";
            this.colmaxrez.Name = "colmaxrez";
            this.colmaxrez.Visible = true;
            this.colmaxrez.Width = 56;
            this.colwidth.Caption = "Ширина";
            this.colwidth.FieldName = "width";
            this.colwidth.Name = "colwidth";
            this.colwidth.Visible = true;
            this.colwidth.Width = 50;
            this.colheight.Caption = "Высота";
            this.colheight.FieldName = "height";
            this.colheight.Name = "colheight";
            this.colheight.Visible = true;
            this.colheight.Width = 47;
            this.coltyperez_name.Caption = "Тип основного реза";
            this.coltyperez_name.ColumnEdit = (RepositoryItem)this.cboTyperez_name;
            this.coltyperez_name.FieldName = "typerez_name";
            this.coltyperez_name.Name = "coltyperez_name";
            this.coltyperez_name.Visible = true;
            this.coltyperez_name.Width = 109;
            this.cboTyperez_name.AutoHeight = false;
            this.cboTyperez_name.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboTyperez_name.Items.AddRange(new object[3]
      {
        (object) "Вертикальный",
        (object) "Горизонтальный",
        (object) "Смешанный"
      });
            this.cboTyperez_name.Name = "cboTyperez_name";
            this.cboTyperez_name.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n4";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n4";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(896, 33);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(809, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отменить";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.OK;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(728, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выбрать";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "GoodOptimForm";
            this.Size = new Size(896, 484);
            this.Text = "Группы оптимизации";
            this.panel1.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_goodoptim.EndInit();
            this.advBandedGridView1.EndInit();
            this.repositoryItemComboBox1.EndInit();
            this.repositoryItemComboBox2.EndInit();
            this.repositoryItemComboBoxcoltypeoptimend.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.cboTyperez_name.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void repositoryItemComboBox2_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            OptimType optimType = (OptimType)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)optimType.name;
            AtGrid.getDataRow((Control)this.gridControl1)["optimtype"] = (object)optimType.typ;
        }

        private void cboTyperez_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow["typerez"] = (object)((ComboBoxEdit)sender).SelectedIndex;
            dataRow.EndEdit();
        }

        private void repositoryItemComboBox1_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            OptimType optimType = (OptimType)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)optimType.name;
            AtGrid.getDataRow((Control)this.gridControl1)["typ"] = (object)optimType.typ;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ParentForm == null)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GoodOptimForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from view_goodoptim where deleted is null";
            this.db.adapter.Fill(this.table_goodoptim);
            this.repositoryItemComboBox1.Items.Add((object)new OptimType()
            {
                typ = 0,
                name = "Линейная"
            });
            this.repositoryItemComboBox1.Items.Add((object)new OptimType()
            {
                typ = 1,
                name = "Плоскостная"
            });
            this.repositoryItemComboBox2.Items.Add((object)new OptimType()
            {
                typ = 2,
                name = "версия 2"
            });
            this.repositoryItemComboBox2.Items.Add((object)new OptimType()
            {
                typ = 3,
                name = "версия 3"
            });
            this.repositoryItemComboBox2.Items.Add((object)new OptimType()
            {
                typ = 0,
                name = "не указано"
            });
            this.repositoryItemComboBoxcoltypeoptimend.Items.Clear();
            this.repositoryItemComboBoxcoltypeoptimend.Items.Add((object)new OptimType()
            {
                typ = 0,
                name = "На одном хлысте"
            });
            this.repositoryItemComboBoxcoltypeoptimend.Items.Add((object)new OptimType()
            {
                typ = 1,
                name = "Всегда на двух"
            });
        }

        public override bool SaveToBase()
        {
            return this.db.SaveDatatableAndAccept2(this.table_goodoptim);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds.Clear();
            this.LoadFromBase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_goodoptim.NewRow();
            this.table_goodoptim.Rows.Add(row);
            row["idgoodoptim"] = (object)dbconn.GetGenId("gen_goodoptim");
            row["name"] = (object)"Новая группа оптимизации";
            row["typ"] = (object)0;
            row["typ_name"] = (object)"Линейная";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["idgoodoptim"] = (object)dbconn.GetGenId("gen_goodoptim");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        public void IsDialog()
        {
            this.gridControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.advBandedGridView1.OptionsBehavior.Editable = false;
        }

        private void repositoryItemComboBoxcoltypeoptimend_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            OptimType optimType = (OptimType)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)optimType.name;
            AtGrid.getDataRow((Control)this.gridControl1)["typeoptimend"] = (object)optimType.typ;
        }
    }
}
