// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodKitAddForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
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
    public class GoodKitAddForm : AtUserControl
    {
        private IContainer components;
        private Panel panel2;
        public GridControl gridControlGoodKitDetail;
        private GridView gridViewGoodKitDetail;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit2;
        private GridView gridView2;
        private GridColumn colgood_marking;
        private GridColumn colgood_name;
        private GridColumn colqu;
        private GridColumn colthick;
        private GridColumn colheight;
        private GridColumn colwidth;
        private GridColumn colweight;
        private GridColumn colsystem_name;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private DataColumn dataColumn23;
        private DataColumn dataColumn24;
        private DataColumn dataColumn25;
        private DataColumn dataColumn26;
        private DataColumn dataColumn20;
        private GridColumn colgood_name1;
        private GridColumn colgood_marking1;
        private GridColumn colqu1;
        private GridColumn colthick1;
        private GridColumn colheight1;
        private GridColumn colwidth1;
        private GridColumn colweight1;
        private GridColumn colprice2;
        private GridColumn colsystem_name1;
        public DataSet ds;
        public DataTable table_goodkitdetail;
        public Button cmdCancel;
        public Button cmdOk;
        private DataColumn dataColumn22;
        private DataColumn dataColumn27;
        private DataColumn dataColumn28;
        private DataColumn dataColumn29;
        private DataColumn dataColumn30;
        private DataColumn dataColumn31;
        private DataColumn dataColumn32;
        private GridColumn colcolor1_name;
        private GridColumn colcolor2_name;
        private atColorPopUpContainer PopupContainerEditColor1;
        private atColorPopUpContainer PopupContainerEditColor2;
        private DataColumn dataColumn1;
        private GridColumn colcomment;
        private DataColumn dataColumn2;
        private int idgoodkit;

        public GoodKitAddForm(int _idgoodkit)
        {
            this.InitializeComponent();
            this.idgoodkit = _idgoodkit;
            this.db.command.CommandText = "select * from view_goodkitdetail where deleted is null \r\n\t\t\t\tand idgoodkit = " + (object)this.idgoodkit;
            this.db.adapter.Fill(this.table_goodkitdetail);
            this.gridControlGoodKitDetail.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
            this.PopupContainerEditColor1.EditValueChanging += new ChangingEventHandler(this.PopupContainerEditColor1_EditValueChanging);
            this.PopupContainerEditColor2.EditValueChanging += new ChangingEventHandler(this.PopupContainerEditColor2_EditValueChanging);
            this.PopupContainerEditColor1.Popup += new EventHandler(this.PopupContainerEditColor1_Popup);
            this.PopupContainerEditColor2.Popup += new EventHandler(this.PopupContainerEditColor2_Popup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel2 = new Panel();
            this.cmdCancel = new Button();
            this.cmdOk = new Button();
            this.gridControlGoodKitDetail = new GridControl();
            this.ds = new DataSet();
            this.table_goodkitdetail = new DataTable();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn23 = new DataColumn();
            this.dataColumn24 = new DataColumn();
            this.dataColumn25 = new DataColumn();
            this.dataColumn26 = new DataColumn();
            this.dataColumn20 = new DataColumn();
            this.dataColumn22 = new DataColumn();
            this.dataColumn27 = new DataColumn();
            this.dataColumn28 = new DataColumn();
            this.dataColumn29 = new DataColumn();
            this.dataColumn30 = new DataColumn();
            this.dataColumn31 = new DataColumn();
            this.dataColumn32 = new DataColumn();
            this.gridViewGoodKitDetail = new GridView();
            this.colgood_name1 = new GridColumn();
            this.colgood_marking1 = new GridColumn();
            this.colqu1 = new GridColumn();
            this.colthick1 = new GridColumn();
            this.colheight1 = new GridColumn();
            this.colwidth1 = new GridColumn();
            this.colweight1 = new GridColumn();
            this.colprice2 = new GridColumn();
            this.colsystem_name1 = new GridColumn();
            this.colcolor1_name = new GridColumn();
            this.PopupContainerEditColor1 = new atColorPopUpContainer();
            this.colcolor2_name = new GridColumn();
            this.PopupContainerEditColor2 = new atColorPopUpContainer();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new AtRepositoryItemTextEdit();
            this.gridView2 = new GridView();
            this.colgood_marking = new GridColumn();
            this.colgood_name = new GridColumn();
            this.colqu = new GridColumn();
            this.colthick = new GridColumn();
            this.colheight = new GridColumn();
            this.colwidth = new GridColumn();
            this.colweight = new GridColumn();
            this.colsystem_name = new GridColumn();
            this.dataColumn1 = new DataColumn();
            this.colcomment = new GridColumn();
            this.dataColumn2 = new DataColumn();
            this.panel2.SuspendLayout();
            this.gridControlGoodKitDetail.BeginInit();
            this.ds.BeginInit();
            this.table_goodkitdetail.BeginInit();
            this.gridViewGoodKitDetail.BeginInit();
            this.PopupContainerEditColor1.BeginInit();
            this.PopupContainerEditColor2.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemTextEdit2.BeginInit();
            this.gridView2.BeginInit();
            this.SuspendLayout();
            this.panel2.Controls.Add((Control)this.cmdCancel);
            this.panel2.Controls.Add((Control)this.cmdOk);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(769, 33);
            this.panel2.TabIndex = 7;
            this.cmdCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.FlatStyle = FlatStyle.Flat;
            this.cmdCancel.Location = new Point(682, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Отменить";
            this.cmdOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdOk.DialogResult = DialogResult.OK;
            this.cmdOk.FlatStyle = FlatStyle.Flat;
            this.cmdOk.Location = new Point(601, 5);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new Size(75, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Добавить";
            this.gridControlGoodKitDetail.DataMember = "goodkitdetail";
            this.gridControlGoodKitDetail.DataSource = (object)this.ds;
            this.gridControlGoodKitDetail.Dock = DockStyle.Fill;
            this.gridControlGoodKitDetail.EmbeddedNavigator.Name = "";
            this.gridControlGoodKitDetail.Location = new Point(0, 0);
            this.gridControlGoodKitDetail.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlGoodKitDetail.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlGoodKitDetail.MainView = (BaseView)this.gridViewGoodKitDetail;
            this.gridControlGoodKitDetail.Name = "gridControlGoodKitDetail";
            this.gridControlGoodKitDetail.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemTextEdit2,
        (RepositoryItem) this.PopupContainerEditColor1,
        (RepositoryItem) this.PopupContainerEditColor2
      });
            this.gridControlGoodKitDetail.Size = new Size(769, 430);
            this.gridControlGoodKitDetail.TabIndex = 8;
            this.gridControlGoodKitDetail.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridViewGoodKitDetail,
        (BaseView) this.gridView2
      });
            this.ds.DataSetName = "ds_goodkit";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_goodkitdetail
      });
            this.table_goodkitdetail.Columns.AddRange(new DataColumn[24]
      {
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn10,
        this.dataColumn11,
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14,
        this.dataColumn23,
        this.dataColumn24,
        this.dataColumn25,
        this.dataColumn26,
        this.dataColumn20,
        this.dataColumn22,
        this.dataColumn27,
        this.dataColumn28,
        this.dataColumn29,
        this.dataColumn30,
        this.dataColumn31,
        this.dataColumn32,
        this.dataColumn1,
        this.dataColumn2
      });
            this.table_goodkitdetail.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodkitdetail"
        }, 1 != 0)
      });
            this.table_goodkitdetail.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn4
      };
            this.table_goodkitdetail.TableName = "goodkitdetail";
            this.dataColumn4.AllowDBNull = false;
            this.dataColumn4.ColumnName = "idgoodkitdetail";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "idgoodkit";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "idgood";
            this.dataColumn6.DataType = typeof(int);
            this.dataColumn7.ColumnName = "good_name";
            this.dataColumn7.Prefix = "local";
            this.dataColumn8.ColumnName = "good_marking";
            this.dataColumn8.Prefix = "local";
            this.dataColumn10.ColumnName = "qu";
            this.dataColumn10.DataType = typeof(double);
            this.dataColumn11.ColumnName = "thick";
            this.dataColumn11.DataType = typeof(int);
            this.dataColumn12.ColumnName = "height";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.ColumnName = "width";
            this.dataColumn13.DataType = typeof(int);
            this.dataColumn14.ColumnName = "weight";
            this.dataColumn14.DataType = typeof(double);
            this.dataColumn23.ColumnName = "price1";
            this.dataColumn23.DataType = typeof(double);
            this.dataColumn23.Prefix = "local";
            this.dataColumn24.ColumnName = "price2";
            this.dataColumn24.DataType = typeof(double);
            this.dataColumn24.Prefix = "local";
            this.dataColumn25.ColumnName = "price1base";
            this.dataColumn25.DataType = typeof(double);
            this.dataColumn25.Prefix = "local";
            this.dataColumn26.ColumnName = "price2base";
            this.dataColumn26.DataType = typeof(double);
            this.dataColumn26.Prefix = "local";
            this.dataColumn20.ColumnName = "system_name";
            this.dataColumn22.ColumnName = "good_idgoodtype";
            this.dataColumn22.DataType = typeof(int);
            this.dataColumn27.ColumnName = "good_idgoodtype2";
            this.dataColumn27.DataType = typeof(int);
            this.dataColumn28.ColumnName = "ismain";
            this.dataColumn28.DataType = typeof(bool);
            this.dataColumn29.ColumnName = "idcolor1";
            this.dataColumn29.DataType = typeof(int);
            this.dataColumn30.ColumnName = "idcolor2";
            this.dataColumn30.DataType = typeof(int);
            this.dataColumn31.ColumnName = "color1_name";
            this.dataColumn32.ColumnName = "color2_name";
            this.gridViewGoodKitDetail.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewGoodKitDetail.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewGoodKitDetail.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewGoodKitDetail.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewGoodKitDetail.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewGoodKitDetail.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewGoodKitDetail.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewGoodKitDetail.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewGoodKitDetail.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewGoodKitDetail.BorderStyle = BorderStyles.Simple;
            this.gridViewGoodKitDetail.Columns.AddRange(new GridColumn[12]
      {
        this.colgood_name1,
        this.colgood_marking1,
        this.colqu1,
        this.colthick1,
        this.colheight1,
        this.colwidth1,
        this.colweight1,
        this.colprice2,
        this.colsystem_name1,
        this.colcolor1_name,
        this.colcolor2_name,
        this.colcomment
      });
            this.gridViewGoodKitDetail.GridControl = this.gridControlGoodKitDetail;
            this.gridViewGoodKitDetail.GroupPanelText = "Панель группировки";
            this.gridViewGoodKitDetail.Name = "gridViewGoodKitDetail";
            this.gridViewGoodKitDetail.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewGoodKitDetail.OptionsCustomization.AllowFilter = false;
            this.gridViewGoodKitDetail.OptionsDetail.ShowDetailTabs = false;
            this.gridViewGoodKitDetail.OptionsSelection.MultiSelect = true;
            this.gridViewGoodKitDetail.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewGoodKitDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewGoodKitDetail.OptionsView.ShowIndicator = false;
            this.colgood_name1.Caption = "Наименование";
            this.colgood_name1.FieldName = "good_name";
            this.colgood_name1.Name = "colgood_name1";
            this.colgood_name1.OptionsColumn.AllowEdit = false;
            this.colgood_name1.Visible = true;
            this.colgood_name1.VisibleIndex = 1;
            this.colgood_name1.Width = 187;
            this.colgood_marking1.Caption = "Артикул";
            this.colgood_marking1.FieldName = "good_marking";
            this.colgood_marking1.Name = "colgood_marking1";
            this.colgood_marking1.OptionsColumn.AllowEdit = false;
            this.colgood_marking1.Visible = true;
            this.colgood_marking1.VisibleIndex = 0;
            this.colgood_marking1.Width = 149;
            this.colqu1.Caption = "Кол-во";
            this.colqu1.FieldName = "qu";
            this.colqu1.Name = "colqu1";
            this.colqu1.Visible = true;
            this.colqu1.VisibleIndex = 2;
            this.colqu1.Width = 70;
            this.colthick1.Caption = "Длина";
            this.colthick1.FieldName = "thick";
            this.colthick1.Name = "colthick1";
            this.colthick1.Visible = true;
            this.colthick1.VisibleIndex = 3;
            this.colthick1.Width = 70;
            this.colheight1.Caption = "Высота";
            this.colheight1.FieldName = "height";
            this.colheight1.Name = "colheight1";
            this.colheight1.Visible = true;
            this.colheight1.VisibleIndex = 4;
            this.colheight1.Width = 70;
            this.colwidth1.Caption = "Ширина";
            this.colwidth1.FieldName = "width";
            this.colwidth1.Name = "colwidth1";
            this.colwidth1.Visible = true;
            this.colwidth1.VisibleIndex = 5;
            this.colwidth1.Width = 70;
            this.colweight1.Caption = "Вес";
            this.colweight1.FieldName = "weight";
            this.colweight1.Name = "colweight1";
            this.colweight1.Visible = true;
            this.colweight1.VisibleIndex = 6;
            this.colweight1.Width = 70;
            this.colprice2.Caption = "Цена";
            this.colprice2.FieldName = "price2";
            this.colprice2.Name = "colprice2";
            this.colprice2.OptionsColumn.AllowEdit = false;
            this.colprice2.Visible = true;
            this.colprice2.VisibleIndex = 10;
            this.colprice2.Width = 70;
            this.colsystem_name1.Caption = "Система";
            this.colsystem_name1.FieldName = "system_name";
            this.colsystem_name1.Name = "colsystem_name1";
            this.colsystem_name1.OptionsColumn.AllowEdit = false;
            this.colsystem_name1.Visible = true;
            this.colsystem_name1.VisibleIndex = 11;
            this.colsystem_name1.Width = 76;
            this.colcolor1_name.Caption = "Цвет 1";
            this.colcolor1_name.ColumnEdit = (RepositoryItem)this.PopupContainerEditColor1;
            this.colcolor1_name.FieldName = "color1_name";
            this.colcolor1_name.Name = "colcolor1_name";
            this.colcolor1_name.Visible = true;
            this.colcolor1_name.VisibleIndex = 7;
            this.PopupContainerEditColor1.AutoHeight = false;
            this.PopupContainerEditColor1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.PopupContainerEditColor1.Name = "PopupContainerEditColor1";
            this.colcolor2_name.Caption = "Цвет 2";
            this.colcolor2_name.ColumnEdit = (RepositoryItem)this.PopupContainerEditColor2;
            this.colcolor2_name.FieldName = "color2_name";
            this.colcolor2_name.Name = "colcolor2_name";
            this.colcolor2_name.Visible = true;
            this.colcolor2_name.VisibleIndex = 8;
            this.PopupContainerEditColor2.AutoHeight = false;
            this.PopupContainerEditColor2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.PopupContainerEditColor2.Name = "PopupContainerEditColor2";
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
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
            this.gridView2.Columns.AddRange(new GridColumn[8]
      {
        this.colgood_marking,
        this.colgood_name,
        this.colqu,
        this.colthick,
        this.colheight,
        this.colwidth,
        this.colweight,
        this.colsystem_name
      });
            this.gridView2.GridControl = this.gridControlGoodKitDetail;
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
            this.colgood_marking.OptionsColumn.AllowEdit = false;
            this.colgood_marking.Visible = true;
            this.colgood_marking.VisibleIndex = 1;
            this.colgood_name.Caption = "Наименование материала";
            this.colgood_name.FieldName = "good_name";
            this.colgood_name.Name = "colgood_name";
            this.colgood_name.OptionsColumn.AllowEdit = false;
            this.colgood_name.Visible = true;
            this.colgood_name.VisibleIndex = 0;
            this.colqu.Caption = "Кол-во";
            this.colqu.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colqu.FieldName = "qu";
            this.colqu.Name = "colqu";
            this.colqu.Visible = true;
            this.colqu.VisibleIndex = 2;
            this.colthick.Caption = "Длина";
            this.colthick.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
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
            this.colweight.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit2;
            this.colweight.FieldName = "weight";
            this.colweight.Name = "colweight";
            this.colweight.Visible = true;
            this.colweight.VisibleIndex = 6;
            this.colsystem_name.Caption = "Система";
            this.colsystem_name.FieldName = "system_name";
            this.colsystem_name.Name = "colsystem_name";
            this.colsystem_name.Visible = true;
            this.colsystem_name.VisibleIndex = 7;
            this.dataColumn1.ColumnName = "comment";
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 9;
            this.dataColumn2.ColumnName = "good_waste";
            this.dataColumn2.DataType = typeof(double);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlGoodKitDetail);
            this.Controls.Add((Control)this.panel2);
            this.Name = "GoodKitAddForm";
            this.Size = new Size(769, 463);
            this.Text = "Добавление материалов из комплекта";
            this.panel2.ResumeLayout(false);
            this.gridControlGoodKitDetail.EndInit();
            this.ds.EndInit();
            this.table_goodkitdetail.EndInit();
            this.gridViewGoodKitDetail.EndInit();
            this.PopupContainerEditColor1.EndInit();
            this.PopupContainerEditColor2.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemTextEdit2.EndInit();
            this.gridView2.EndInit();
            this.ResumeLayout(false);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PopupContainerEditColor1_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlGoodKitDetail);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = (DataRow)e.NewValue;
            dataRow1["idcolor1"] = dataRow2["idcolor"];
            dataRow1["color1_name"] = dataRow2["name"];
        }

        private void PopupContainerEditColor2_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlGoodKitDetail);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = (DataRow)e.NewValue;
            dataRow1["idcolor2"] = dataRow2["idcolor"];
            dataRow1["color2_name"] = dataRow2["name"];
        }

        private void PopupContainerEditColor1_Popup(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGoodKitDetail);
            if (dataRow == null)
                return;
            this.PopupContainerEditColor1.IdColor = dataRow["idcolor1"];
        }

        private void PopupContainerEditColor2_Popup(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGoodKitDetail);
            if (dataRow == null)
                return;
            this.PopupContainerEditColor2.IdColor = dataRow["idcolor2"];
        }
    }
}
