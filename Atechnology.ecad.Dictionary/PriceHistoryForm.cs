// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.PriceHistoryForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
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
    public class PriceHistoryForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridView gridView1;
        private GridView gridView2;
        private GridColumn colgood_marking;
        private GridColumn colgood_name;
        private GridColumn colqu;
        private GridColumn colthick;
        private GridColumn colheight;
        private GridColumn colwidth;
        private GridColumn colweight;
        private DataSet ds;
        private DataTable table_goodprice;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private GridColumn colprice1;
        private GridColumn colprice2;
        private GridColumn colcomment;
        private GridColumn coldt;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        public GridControl gridPriceHistory;
        private GridColumn gridColumn3;
        private GridColumn gridColumn5;
        private GridColumn gridColumn4;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn9;
        private DataColumn dataColumn10;
        private GridColumn gridColumn1;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private DataColumn dataColumn15;
        private DataColumn dataColumn16;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private DataColumn dataColumn19;
        private DataColumn dataColumn20;
        private DataColumn dataColumn21;
        private DataColumn dataColumn22;
        private DataColumn dataColumn23;
        private DataColumn dataColumn24;
        private DataColumn dataColumn25;
        private GridColumn colvalut_name;
        private GridColumn colvalut_shortname;
        private GridColumn colvalut2_name;
        private GridColumn colvalut2_shortname;
        private GridColumn colvalut3_name;
        private GridColumn colvalut3_shortname;
        private GridColumn colvalut4_name;
        private GridColumn colvalut4_shortname;
        private GridColumn colvalut5_name;
        private GridColumn colvalut5_shortname;
        public int idgood;

        public event EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs> BeforeAddPriceHistoryEvent;

        public event EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs> AfterAddPriceHistoryEvent;

        public event EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs> BeforeEditPriceHistoryEvent;

        public event EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs> AfterEditPriceHistoryEvent;

        public event EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs> BeforeDoublicatePriceHistoryEvent;

        public event EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs> AfterDoublicatePriceHistoryEvent;

        public event EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs> BeforeDeletePriceHistoryEvent;

        public event EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs> AfterDeletePriceHistoryEvent;

        public PriceHistoryForm(int _idgood)
        {
            this.InitializeComponent();
            this.idgood = _idgood;
            this.LoadFromBase();
            this.gridView1.CellValueChanging += new CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.CellValueChanged += new CellValueChangedEventHandler(this.gridView1_CellValueChanged);
        }

        public PriceHistoryForm(int idgood, bool __IsDialog)
            : this(idgood)
        {
            if (!__IsDialog)
                return;
            this.panel1.Visible = false;
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
            this.gridPriceHistory = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_goodprice = new DataTable();
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
            this.gridView1 = new GridView();
            this.colprice1 = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.colprice2 = new GridColumn();
            this.gridColumn3 = new GridColumn();
            this.gridColumn5 = new GridColumn();
            this.gridColumn4 = new GridColumn();
            this.colcomment = new GridColumn();
            this.gridColumn1 = new GridColumn();
            this.coldt = new GridColumn();
            this.gridView2 = new GridView();
            this.colgood_marking = new GridColumn();
            this.colgood_name = new GridColumn();
            this.colqu = new GridColumn();
            this.colthick = new GridColumn();
            this.colheight = new GridColumn();
            this.colwidth = new GridColumn();
            this.colweight = new GridColumn();
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
            this.dataColumn22 = new DataColumn();
            this.dataColumn23 = new DataColumn();
            this.dataColumn24 = new DataColumn();
            this.dataColumn25 = new DataColumn();
            this.colvalut_name = new GridColumn();
            this.colvalut_shortname = new GridColumn();
            this.colvalut2_name = new GridColumn();
            this.colvalut2_shortname = new GridColumn();
            this.colvalut3_name = new GridColumn();
            this.colvalut3_shortname = new GridColumn();
            this.colvalut4_name = new GridColumn();
            this.colvalut4_shortname = new GridColumn();
            this.colvalut5_name = new GridColumn();
            this.colvalut5_shortname = new GridColumn();
            this.panel1.SuspendLayout();
            this.gridPriceHistory.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_goodprice.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.gridView2.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(788, 33);
            this.panel1.TabIndex = 3;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(701, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(620, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(539, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridPriceHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.gridPriceHistory.DataMember = "goodprice";
            this.gridPriceHistory.DataSource = (object)this.ds;
            this.gridPriceHistory.Dock = DockStyle.Fill;
            this.gridPriceHistory.EmbeddedNavigator.Name = "";
            this.gridPriceHistory.Location = new Point(0, 0);
            this.gridPriceHistory.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridPriceHistory.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridPriceHistory.MainView = (BaseView)this.gridView1;
            this.gridPriceHistory.Name = "gridPriceHistory";
            this.gridPriceHistory.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemTextEdit1
      });
            this.gridPriceHistory.Size = new Size(788, 415);
            this.gridPriceHistory.TabIndex = 4;
            this.gridPriceHistory.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridView1,
        (BaseView) this.gridView2
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
            this.ds.DataSetName = "ds_goodpricehistory";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_goodprice
      });
            this.table_goodprice.Columns.AddRange(new DataColumn[25]
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
        this.dataColumn22,
        this.dataColumn23,
        this.dataColumn24,
        this.dataColumn25
      });
            this.table_goodprice.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodprice"
        }, 1 != 0)
      });
            this.table_goodprice.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_goodprice.TableName = "goodprice";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idgoodprice";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "idgood";
            this.dataColumn2.DataType = typeof(int);
            this.dataColumn3.ColumnName = "price1";
            this.dataColumn3.DataType = typeof(double);
            this.dataColumn4.ColumnName = "price2";
            this.dataColumn4.DataType = typeof(double);
            this.dataColumn5.ColumnName = "comment";
            this.dataColumn6.ColumnName = "dt";
            this.dataColumn6.DataType = typeof(DateTime);
            this.dataColumn7.ColumnName = "price3";
            this.dataColumn7.DataType = typeof(double);
            this.dataColumn8.ColumnName = "price4";
            this.dataColumn8.DataType = typeof(double);
            this.dataColumn9.ColumnName = "price5";
            this.dataColumn9.DataType = typeof(double);
            this.dataColumn10.ColumnName = "peopleedit_fio";
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
            this.gridView1.Columns.AddRange(new GridColumn[18]
      {
        this.colprice1,
        this.colprice2,
        this.gridColumn3,
        this.gridColumn5,
        this.gridColumn4,
        this.colcomment,
        this.gridColumn1,
        this.coldt,
        this.colvalut_name,
        this.colvalut_shortname,
        this.colvalut2_name,
        this.colvalut2_shortname,
        this.colvalut3_name,
        this.colvalut3_shortname,
        this.colvalut4_name,
        this.colvalut4_shortname,
        this.colvalut5_name,
        this.colvalut5_shortname
      });
            this.gridView1.GridControl = this.gridPriceHistory;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colprice1.Caption = "Цена 1";
            this.colprice1.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colprice1.FieldName = "price1";
            this.colprice1.Name = "colprice1";
            this.colprice1.OptionsColumn.AllowEdit = false;
            this.colprice1.Visible = true;
            this.colprice1.VisibleIndex = 2;
            this.colprice1.Width = 80;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.colprice2.Caption = "Цена 2";
            this.colprice2.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colprice2.FieldName = "price2";
            this.colprice2.Name = "colprice2";
            this.colprice2.OptionsColumn.AllowEdit = false;
            this.colprice2.Visible = true;
            this.colprice2.VisibleIndex = 3;
            this.colprice2.Width = 84;
            this.gridColumn3.Caption = "Цена 3";
            this.gridColumn3.FieldName = "price3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 68;
            this.gridColumn5.Caption = "Цена 4";
            this.gridColumn5.FieldName = "price4";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 68;
            this.gridColumn4.Caption = "Цена 5";
            this.gridColumn4.FieldName = "price5";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 97;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.OptionsColumn.AllowEdit = false;
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 7;
            this.colcomment.Width = 324;
            this.gridColumn1.Caption = "Редактировал";
            this.gridColumn1.FieldName = "peopleedit_fio";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.coldt.Caption = "Дата";
            this.coldt.FieldName = "dt";
            this.coldt.Name = "coldt";
            this.coldt.OptionsColumn.AllowEdit = false;
            this.coldt.Visible = true;
            this.coldt.VisibleIndex = 0;
            this.coldt.Width = 65;
            this.gridView2.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.BorderStyle = BorderStyles.Simple;
            this.gridView2.Columns.AddRange(new GridColumn[7]
      {
        this.colgood_marking,
        this.colgood_name,
        this.colqu,
        this.colthick,
        this.colheight,
        this.colwidth,
        this.colweight
      });
            this.gridView2.GridControl = this.gridPriceHistory;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.colgood_marking.Caption = "Артикул материала";
            this.colgood_marking.FieldName = "good_marking";
            this.colgood_marking.Name = "colgood_marking";
            this.colgood_marking.Visible = true;
            this.colgood_marking.VisibleIndex = 1;
            this.colgood_name.Caption = "Наименование материала";
            this.colgood_name.FieldName = "good_name";
            this.colgood_name.Name = "colgood_name";
            this.colgood_name.Visible = true;
            this.colgood_name.VisibleIndex = 0;
            this.colqu.Caption = "Кол-во";
            this.colqu.FieldName = "qu";
            this.colqu.Name = "colqu";
            this.colqu.Visible = true;
            this.colqu.VisibleIndex = 2;
            this.colthick.Caption = "Длина";
            this.colthick.FieldName = "thick";
            this.colthick.Name = "colthick";
            this.colthick.Visible = true;
            this.colthick.VisibleIndex = 3;
            this.colheight.Caption = "Высота";
            this.colheight.FieldName = "height";
            this.colheight.Name = "colheight";
            this.colheight.Visible = true;
            this.colheight.VisibleIndex = 4;
            this.colwidth.Caption = "Ширина";
            this.colwidth.FieldName = "width";
            this.colwidth.Name = "colwidth";
            this.colwidth.Visible = true;
            this.colwidth.VisibleIndex = 5;
            this.colweight.Caption = "Вес";
            this.colweight.FieldName = "weight";
            this.colweight.Name = "colweight";
            this.colweight.Visible = true;
            this.colweight.VisibleIndex = 6;
            this.dataColumn11.ColumnName = "valut_name";
            this.dataColumn12.ColumnName = "valut_shortname";
            this.dataColumn13.ColumnName = "valut2_name";
            this.dataColumn14.ColumnName = "valut2_shortname";
            this.dataColumn15.ColumnName = "valut3_name";
            this.dataColumn16.ColumnName = "valut3_shortname";
            this.dataColumn17.ColumnName = "valut4_name";
            this.dataColumn18.ColumnName = "valut4_shortname";
            this.dataColumn19.ColumnName = "valut5_name";
            this.dataColumn20.ColumnName = "valut5_shortname";
            this.dataColumn21.ColumnName = "idvalut";
            this.dataColumn21.DataType = typeof(int);
            this.dataColumn22.ColumnName = "idvalut2";
            this.dataColumn22.DataType = typeof(int);
            this.dataColumn23.ColumnName = "idvalut3";
            this.dataColumn23.DataType = typeof(int);
            this.dataColumn24.ColumnName = "idvalut4";
            this.dataColumn24.DataType = typeof(int);
            this.dataColumn25.ColumnName = "idvalut5";
            this.dataColumn25.DataType = typeof(int);
            this.colvalut_name.Caption = "Валюта";
            this.colvalut_name.FieldName = "valut_name";
            this.colvalut_name.Name = "colvalut_name";
            this.colvalut_name.Visible = true;
            this.colvalut_name.VisibleIndex = 8;
            this.colvalut_shortname.Caption = "Кр. валюта";
            this.colvalut_shortname.FieldName = "valut_shortname";
            this.colvalut_shortname.Name = "colvalut_shortname";
            this.colvalut_shortname.Visible = true;
            this.colvalut_shortname.VisibleIndex = 9;
            this.colvalut2_name.Caption = "Валюта 2";
            this.colvalut2_name.FieldName = "valut2_name";
            this.colvalut2_name.Name = "colvalut2_name";
            this.colvalut2_name.Visible = true;
            this.colvalut2_name.VisibleIndex = 10;
            this.colvalut2_shortname.Caption = "Кр. валюта 2";
            this.colvalut2_shortname.FieldName = "valut2_shortname";
            this.colvalut2_shortname.Name = "colvalut2_shortname";
            this.colvalut2_shortname.Visible = true;
            this.colvalut2_shortname.VisibleIndex = 11;
            this.colvalut3_name.Caption = "Валюта 3";
            this.colvalut3_name.FieldName = "valut3_name";
            this.colvalut3_name.Name = "colvalut3_name";
            this.colvalut3_name.Visible = true;
            this.colvalut3_name.VisibleIndex = 12;
            this.colvalut3_shortname.Caption = "Кр. валюта 3";
            this.colvalut3_shortname.FieldName = "valut3_shortname";
            this.colvalut3_shortname.Name = "colvalut3_shortname";
            this.colvalut3_shortname.Visible = true;
            this.colvalut3_shortname.VisibleIndex = 13;
            this.colvalut4_name.Caption = "Валюта 4";
            this.colvalut4_name.FieldName = "valut4_name";
            this.colvalut4_name.Name = "colvalut4_name";
            this.colvalut4_name.Visible = true;
            this.colvalut4_name.VisibleIndex = 14;
            this.colvalut4_shortname.Caption = "Кр. валюта 4";
            this.colvalut4_shortname.FieldName = "valut4_shortname";
            this.colvalut4_shortname.Name = "colvalut4_shortname";
            this.colvalut4_shortname.Visible = true;
            this.colvalut4_shortname.VisibleIndex = 15;
            this.colvalut5_name.Caption = "Валюта 5";
            this.colvalut5_name.FieldName = "valut5_name";
            this.colvalut5_name.Name = "colvalut5_name";
            this.colvalut5_name.Visible = true;
            this.colvalut5_name.VisibleIndex = 16;
            this.colvalut5_shortname.Caption = "Кр. валюта 5";
            this.colvalut5_shortname.FieldName = "valut5_shortname";
            this.colvalut5_shortname.Name = "colvalut5_shortname";
            this.colvalut5_shortname.Visible = true;
            this.colvalut5_shortname.VisibleIndex = 17;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridPriceHistory);
            this.Controls.Add((Control)this.panel1);
            this.Name = "PriceHistoryForm";
            this.Size = new Size(788, 448);
            this.Text = "История цен";
            this.panel1.ResumeLayout(false);
            this.gridPriceHistory.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_goodprice.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.gridView2.EndInit();
            this.ResumeLayout(false);
        }

        public override void LoadFromBase()
        {
            this.table_goodprice.Clear();
            this.table_goodprice.AcceptChanges();
            this.db.command.CommandText = "select * from view_goodprice where deleted is null and idgood = " + (object)this.idgood;
            this.db.adapter.Fill(this.table_goodprice);
        }

        public override bool SaveToBase()
        {
            return this.db.SaveDatatableAndAccept2(this.table_goodprice);
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

        protected virtual void InvokeBeforeAddPriceHistoryEvent(DataRow[] eventRows)
        {
            if (this.BeforeAddPriceHistoryEvent == null)
                return;
            this.BeforeAddPriceHistoryEvent((object)this, new PriceHistoryForm.OnPriceHistoryEventArgs(eventRows));
        }

        protected virtual void InvokeAfterAddPriceHistoryEvent(DataRow[] eventRows)
        {
            if (this.AfterAddPriceHistoryEvent == null)
                return;
            this.AfterAddPriceHistoryEvent((object)this, new PriceHistoryForm.OnPriceHistoryEventArgs(eventRows));
        }

        protected virtual void InvokeBeforeEditPriceHistoryEvent(DataRow[] eventRows)
        {
            if (this.BeforeEditPriceHistoryEvent == null)
                return;
            this.BeforeEditPriceHistoryEvent((object)this, new PriceHistoryForm.OnPriceHistoryEventArgs(eventRows));
        }

        protected virtual void InvokeAfterEditPriceHistoryEvent(DataRow[] eventRows)
        {
            if (this.AfterEditPriceHistoryEvent == null)
                return;
            this.AfterEditPriceHistoryEvent((object)this, new PriceHistoryForm.OnPriceHistoryEventArgs(eventRows));
        }

        protected virtual void InvokeBeforeDoublicatePriceHistoryEvent(DataRow[] eventRows)
        {
            if (this.BeforeDoublicatePriceHistoryEvent == null)
                return;
            this.BeforeDoublicatePriceHistoryEvent((object)this, new PriceHistoryForm.OnPriceHistoryEventArgs(eventRows));
        }

        protected virtual void InvokeAfterDoublicatePriceHistoryEvent(DataRow[] eventRows)
        {
            if (this.AfterDoublicatePriceHistoryEvent == null)
                return;
            this.AfterDoublicatePriceHistoryEvent((object)this, new PriceHistoryForm.OnPriceHistoryEventArgs(eventRows));
        }

        protected virtual void InvokeBeforeDeletePriceHistoryEvent(DataRow[] eventRows)
        {
            if (this.BeforeDeletePriceHistoryEvent == null)
                return;
            this.BeforeDeletePriceHistoryEvent((object)this, new PriceHistoryForm.OnPriceHistoryEventArgs(eventRows));
        }

        protected virtual void InvokeAfterDeletePriceHistoryEvent(DataRow[] eventRows)
        {
            if (this.AfterDeletePriceHistoryEvent == null)
                return;
            this.AfterDeletePriceHistoryEvent((object)this, new PriceHistoryForm.OnPriceHistoryEventArgs(eventRows));
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            this.InvokeAfterEditPriceHistoryEvent(new DataRow[1]
      {
        AtGrid.getDataRow((Control) this.gridPriceHistory)
      });
        }

        private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            this.InvokeBeforeEditPriceHistoryEvent(new DataRow[1]
      {
        AtGrid.getDataRow((Control) this.gridPriceHistory)
      });
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.InvokeBeforeAddPriceHistoryEvent((DataRow[])null);
            DataRow row = this.table_goodprice.NewRow();
            this.table_goodprice.Rows.Add(row);
            row["idgoodprice"] = (object)dbconn.GetGenId("gen_goodprice");
            row["idgood"] = (object)this.idgood;
            row["dt"] = (object)DateTime.Now.Date;
            this.InvokeAfterAddPriceHistoryEvent(new DataRow[1]
      {
        row
      });
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.InvokeBeforeDoublicatePriceHistoryEvent((DataRow[])null);
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridPriceHistory);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = AtDataSet.dublicate(dataRow1);
            dataRow2["idgoodprice"] = (object)dbconn.GetGenId("gen_goodprice");
            this.InvokeAfterDoublicatePriceHistoryEvent(new DataRow[1]
      {
        dataRow2
      });
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridPriceHistory);
            if (dataRow == null)
                return;
            this.InvokeBeforeDeletePriceHistoryEvent(new DataRow[1]
      {
        dataRow
      });
            dataRow.Delete();
            this.InvokeAfterDeletePriceHistoryEvent(new DataRow[1]
      {
        dataRow
      });
        }

        public class OnPriceHistoryEventArgs : EventArgs
        {
            private DataRow[] eventRows;

            public DataRow[] EventRows
            {
                get
                {
                    return this.eventRows;
                }
                set
                {
                    this.eventRows = value;
                }
            }

            private OnPriceHistoryEventArgs()
            {
            }

            public OnPriceHistoryEventArgs(DataRow[] eventRows)
            {
                this.eventRows = eventRows;
            }
        }
    }
}
