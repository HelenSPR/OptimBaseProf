// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.WorkOperForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.Components.Tree;
using Atechnology.DBConnections2;
using Atechnology.ecad.Calc;
using Atechnology.ecad.Dictionary.DataSets;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
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
    public class WorkOperForm : AtUserControl
    {
        private DataTable valutTable = new DataTable();
        private IContainer components;
        private GridColumn colname;
        private GridColumn colworkgroup;
        private GridColumn colcomment;
        private GridColumn colname1;
        private GridColumn colcomment1;
        private GridColumn colpeople_fio1;
        private GridColumn colpeople_fio2;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripMenuItem MenuItemRemove;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemAddOperation;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuItemAddExecutor;
        private GridColumn colnumpos;
        private GridColumn colqu;
        private GridColumn colworktime;
        public GridControl gridControlWork;
        private SplitterControl splitterControl1;
        private GridColumn colidwork;
        private ToolStripSeparator toolStripSeparator3;
        private atButtonsPanel atButtonsPanel1;
        private ds_workoper ds;
        private GridColumn colidworkoper;
        private GridColumn colprice1;
        private GridColumn colprice2;
        private GridColumn colprice3;
        private GridColumn colprice4;
        private GridColumn colprice5;
        private GridColumn colpeople_fio;
        private GridColumn colpeople_fio3;
        private RepositoryItemButtonEdit ButtonEditExecutorWorkOper;
        private RepositoryItemButtonEdit ButtonEditWorkExecutor;
        private RepositoryItemCalcEdit CalcEditValue;
        private ToolStripMenuItem MenuItemDoublicate;
        private GridColumn colvalut1_name;
        private RepositoryItemButtonEdit ButtonEditSelectValut;
        private GridColumn colvalut2_name;
        private GridColumn colvalut3_name;
        private GridColumn colvalut4_name;
        private GridColumn colvalut5_name;
        private RepositoryItemComboBox ComboBoxValut;
        public GridView gridViewWork;
        public GridView gridViewOperation;
        public GridView gridViewWorkPeople;
        public AtTreeListControl atTreeListControl1;

        public WorkOperForm()
        {
            this.InitializeComponent();
            this.ds = WorkOperClass.ds;
            this.atTreeListControl1.InitData(true);
            this.atTreeListControl1.DataSource = (object)this.ds;
            this.gridControlWork.DataSource = (object)this.ds;
            this.ButtonEditExecutorWorkOper.ButtonClick += new ButtonPressedEventHandler(this.ButtonEditExecutorWorkOper_ButtonClick);
            this.ButtonEditWorkExecutor.ButtonClick += new ButtonPressedEventHandler(this.ButtonEditWorkExecutor_ButtonClick);
            this.gridViewOperation.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOperation_CellValueChanging);
            this.valutTable.Clear();
            this.valutTable.AcceptChanges();
            this.db.command.CommandText = "select idvalut, name from valut where deleted is null";
            this.db.adapter.Fill(this.valutTable);
            this.ComboBoxValut.Items.Clear();
            this.ComboBoxValut.Items.Add((object)new WorkOperForm.ValutPair()
            {
                Id = new int?(),
                Name = ""
            });
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.valutTable.Rows)
                this.ComboBoxValut.Items.Add((object)new WorkOperForm.ValutPair()
                {
                    Id = new int?((int)dataRow["idvalut"]),
                    Name = dataRow["name"].ToString()
                });
            this.FormClosing += new FormClosing(this.WorkOperForm_FormClosing);
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
            GridLevelNode gridLevelNode1 = new GridLevelNode();
            GridLevelNode gridLevelNode2 = new GridLevelNode();
            this.gridViewOperation = new GridView();
            this.colidworkoper = new GridColumn();
            this.colnumpos = new GridColumn();
            this.colname1 = new GridColumn();
            this.colqu = new GridColumn();
            this.CalcEditValue = new RepositoryItemCalcEdit();
            this.colworktime = new GridColumn();
            this.colpeople_fio1 = new GridColumn();
            this.ButtonEditExecutorWorkOper = new RepositoryItemButtonEdit();
            this.colcomment1 = new GridColumn();
            this.colprice1 = new GridColumn();
            this.colprice2 = new GridColumn();
            this.colprice3 = new GridColumn();
            this.colprice4 = new GridColumn();
            this.colprice5 = new GridColumn();
            this.colvalut1_name = new GridColumn();
            this.ComboBoxValut = new RepositoryItemComboBox();
            this.colvalut2_name = new GridColumn();
            this.colvalut3_name = new GridColumn();
            this.colvalut4_name = new GridColumn();
            this.colvalut5_name = new GridColumn();
            this.gridControlWork = new GridControl();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.MenuItemAdd = new ToolStripMenuItem();
            this.MenuItemDoublicate = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemAddOperation = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemAddExecutor = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.ds = new ds_workoper();
            this.gridViewWorkPeople = new GridView();
            this.colpeople_fio2 = new GridColumn();
            this.gridViewWork = new GridView();
            this.colidwork = new GridColumn();
            this.colname = new GridColumn();
            this.colworkgroup = new GridColumn();
            this.colpeople_fio3 = new GridColumn();
            this.ButtonEditWorkExecutor = new RepositoryItemButtonEdit();
            this.colcomment = new GridColumn();
            this.ButtonEditSelectValut = new RepositoryItemButtonEdit();
            this.atTreeListControl1 = new AtTreeListControl();
            this.splitterControl1 = new SplitterControl();
            this.atButtonsPanel1 = new atButtonsPanel();
            this.colpeople_fio = new GridColumn();
            this.gridViewOperation.BeginInit();
            this.CalcEditValue.BeginInit();
            this.ButtonEditExecutorWorkOper.BeginInit();
            this.ComboBoxValut.BeginInit();
            this.gridControlWork.BeginInit();
            this.MenuItem.SuspendLayout();
            this.ds.BeginInit();
            this.gridViewWorkPeople.BeginInit();
            this.gridViewWork.BeginInit();
            this.ButtonEditWorkExecutor.BeginInit();
            this.ButtonEditSelectValut.BeginInit();
            this.atTreeListControl1.BeginInit();
            this.atButtonsPanel1.BeginInit();
            this.SuspendLayout();
            this.gridViewOperation.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewOperation.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewOperation.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewOperation.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewOperation.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewOperation.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewOperation.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewOperation.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewOperation.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewOperation.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewOperation.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewOperation.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewOperation.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewOperation.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewOperation.BorderStyle = BorderStyles.Simple;
            this.gridViewOperation.ChildGridLevelName = "Операции";
            this.gridViewOperation.Columns.AddRange(new GridColumn[17]
      {
        this.colidworkoper,
        this.colnumpos,
        this.colname1,
        this.colqu,
        this.colworktime,
        this.colpeople_fio1,
        this.colcomment1,
        this.colprice1,
        this.colprice2,
        this.colprice3,
        this.colprice4,
        this.colprice5,
        this.colvalut1_name,
        this.colvalut2_name,
        this.colvalut3_name,
        this.colvalut4_name,
        this.colvalut5_name
      });
            this.gridViewOperation.GridControl = this.gridControlWork;
            this.gridViewOperation.Name = "gridViewOperation";
            this.gridViewOperation.OptionsCustomization.AllowFilter = false;
            this.gridViewOperation.OptionsDetail.ShowDetailTabs = false;
            this.gridViewOperation.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewOperation.OptionsView.ShowGroupPanel = false;
            this.gridViewOperation.OptionsView.ShowIndicator = false;
            this.gridViewOperation.ViewCaption = "Операции";
            this.colidworkoper.Caption = "#";
            this.colidworkoper.FieldName = "idworkoper";
            this.colidworkoper.Name = "colidworkoper";
            this.colidworkoper.OptionsColumn.AllowEdit = false;
            this.colidworkoper.Visible = true;
            this.colidworkoper.VisibleIndex = 0;
            this.colidworkoper.Width = 33;
            this.colnumpos.Caption = "№пп";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 1;
            this.colnumpos.Width = 29;
            this.colname1.Caption = "Наименование операции";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 2;
            this.colname1.Width = 113;
            this.colqu.Caption = "Норма";
            this.colqu.ColumnEdit = (RepositoryItem)this.CalcEditValue;
            this.colqu.FieldName = "qu";
            this.colqu.Name = "colqu";
            this.colqu.Visible = true;
            this.colqu.VisibleIndex = 4;
            this.colqu.Width = 66;
            this.CalcEditValue.AutoHeight = false;
            this.CalcEditValue.Name = "CalcEditValue";
            this.CalcEditValue.Precision = 4;
            this.CalcEditValue.ShowDropDown = ShowDropDown.Never;
            this.colworktime.Caption = "Время";
            this.colworktime.ColumnEdit = (RepositoryItem)this.CalcEditValue;
            this.colworktime.FieldName = "worktime";
            this.colworktime.Name = "colworktime";
            this.colworktime.Visible = true;
            this.colworktime.VisibleIndex = 5;
            this.colworktime.Width = 50;
            this.colpeople_fio1.Caption = "Ответственный";
            this.colpeople_fio1.ColumnEdit = (RepositoryItem)this.ButtonEditExecutorWorkOper;
            this.colpeople_fio1.FieldName = "people_fio";
            this.colpeople_fio1.Name = "colpeople_fio1";
            this.colpeople_fio1.Visible = true;
            this.colpeople_fio1.VisibleIndex = 3;
            this.colpeople_fio1.Width = 102;
            this.ButtonEditExecutorWorkOper.AutoHeight = false;
            this.ButtonEditExecutorWorkOper.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton()
      });
            this.ButtonEditExecutorWorkOper.Name = "ButtonEditExecutorWorkOper";
            this.ButtonEditExecutorWorkOper.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colcomment1.Caption = "Комментарий";
            this.colcomment1.FieldName = "comment";
            this.colcomment1.Name = "colcomment1";
            this.colcomment1.Visible = true;
            this.colcomment1.VisibleIndex = 11;
            this.colcomment1.Width = 97;
            this.colprice1.Caption = "Цена 1";
            this.colprice1.ColumnEdit = (RepositoryItem)this.CalcEditValue;
            this.colprice1.FieldName = "price1";
            this.colprice1.Name = "colprice1";
            this.colprice1.Visible = true;
            this.colprice1.VisibleIndex = 6;
            this.colprice1.Width = 27;
            this.colprice2.Caption = "Цена 2";
            this.colprice2.ColumnEdit = (RepositoryItem)this.CalcEditValue;
            this.colprice2.FieldName = "price2";
            this.colprice2.Name = "colprice2";
            this.colprice2.Visible = true;
            this.colprice2.VisibleIndex = 7;
            this.colprice2.Width = 27;
            this.colprice3.Caption = "Цена 3";
            this.colprice3.ColumnEdit = (RepositoryItem)this.CalcEditValue;
            this.colprice3.FieldName = "price3";
            this.colprice3.Name = "colprice3";
            this.colprice3.Visible = true;
            this.colprice3.VisibleIndex = 8;
            this.colprice3.Width = 27;
            this.colprice4.Caption = "Цена 4";
            this.colprice4.ColumnEdit = (RepositoryItem)this.CalcEditValue;
            this.colprice4.FieldName = "price4";
            this.colprice4.Name = "colprice4";
            this.colprice4.Visible = true;
            this.colprice4.VisibleIndex = 9;
            this.colprice4.Width = 27;
            this.colprice5.Caption = "Цена 5";
            this.colprice5.ColumnEdit = (RepositoryItem)this.CalcEditValue;
            this.colprice5.FieldName = "price5";
            this.colprice5.Name = "colprice5";
            this.colprice5.Visible = true;
            this.colprice5.VisibleIndex = 10;
            this.colprice5.Width = 27;
            this.colvalut1_name.Caption = "Валюта1";
            this.colvalut1_name.ColumnEdit = (RepositoryItem)this.ComboBoxValut;
            this.colvalut1_name.FieldName = "valut1_name";
            this.colvalut1_name.Name = "colvalut1_name";
            this.colvalut1_name.Visible = true;
            this.colvalut1_name.VisibleIndex = 12;
            this.ComboBoxValut.AutoHeight = false;
            this.ComboBoxValut.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.ComboBoxValut.Name = "ComboBoxValut";
            this.colvalut2_name.Caption = "Валюта2";
            this.colvalut2_name.ColumnEdit = (RepositoryItem)this.ComboBoxValut;
            this.colvalut2_name.FieldName = "valut2_name";
            this.colvalut2_name.Name = "colvalut2_name";
            this.colvalut2_name.Visible = true;
            this.colvalut2_name.VisibleIndex = 13;
            this.colvalut3_name.Caption = "Валюта3";
            this.colvalut3_name.ColumnEdit = (RepositoryItem)this.ComboBoxValut;
            this.colvalut3_name.FieldName = "valut3_name";
            this.colvalut3_name.Name = "colvalut3_name";
            this.colvalut3_name.Visible = true;
            this.colvalut3_name.VisibleIndex = 14;
            this.colvalut4_name.Caption = "Валюта4";
            this.colvalut4_name.ColumnEdit = (RepositoryItem)this.ComboBoxValut;
            this.colvalut4_name.FieldName = "valut4_name";
            this.colvalut4_name.Name = "colvalut4_name";
            this.colvalut4_name.Visible = true;
            this.colvalut4_name.VisibleIndex = 15;
            this.colvalut5_name.Caption = "Валюта5";
            this.colvalut5_name.ColumnEdit = (RepositoryItem)this.ComboBoxValut;
            this.colvalut5_name.FieldName = "valut5_name";
            this.colvalut5_name.Name = "colvalut5_name";
            this.colvalut5_name.Visible = true;
            this.colvalut5_name.VisibleIndex = 16;
            this.gridControlWork.ContextMenuStrip = this.MenuItem;
            this.gridControlWork.DataMember = "workgroup.FK_workgroup_work";
            this.gridControlWork.DataSource = (object)this.ds;
            this.gridControlWork.Dock = DockStyle.Fill;
            this.gridControlWork.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = (BaseView)this.gridViewOperation;
            gridLevelNode1.RelationName = "FK_work_workoper";
            gridLevelNode2.LevelTemplate = (BaseView)this.gridViewWorkPeople;
            gridLevelNode2.RelationName = "FK_work_workpeople";
            this.gridControlWork.LevelTree.Nodes.AddRange(new GridLevelNode[2]
      {
        gridLevelNode1,
        gridLevelNode2
      });
            this.gridControlWork.Location = new Point(223, 0);
            this.gridControlWork.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlWork.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlWork.MainView = (BaseView)this.gridViewWork;
            this.gridControlWork.Name = "gridControlWork";
            this.gridControlWork.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.ButtonEditWorkExecutor,
        (RepositoryItem) this.ButtonEditExecutorWorkOper,
        (RepositoryItem) this.CalcEditValue,
        (RepositoryItem) this.ButtonEditSelectValut,
        (RepositoryItem) this.ComboBoxValut
      });
            this.gridControlWork.Size = new Size(673, 324);
            this.gridControlWork.TabIndex = 2;
            this.gridControlWork.ViewCollection.AddRange(new BaseView[3]
      {
        (BaseView) this.gridViewWorkPeople,
        (BaseView) this.gridViewWork,
        (BaseView) this.gridViewOperation
      });
            this.MenuItem.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.MenuItemDoublicate,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemAddOperation,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemAddExecutor,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.MenuItemRemove
      });
            this.MenuItem.Name = "contextMenuStrip1";
            this.MenuItem.Size = new Size(302, 132);
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAdd.Size = new Size(301, 22);
            this.MenuItemAdd.Text = "Добавить работу";
            this.MenuItemAdd.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.MenuItemDoublicate.Name = "MenuItemDoublicate";
            this.MenuItemDoublicate.Size = new Size(301, 22);
            this.MenuItemDoublicate.Text = "Дублировать";
            this.MenuItemDoublicate.Click += new EventHandler(this.MenuItemDoublicate_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(298, 6);
            this.MenuItemAddOperation.Name = "MenuItemAddOperation";
            this.MenuItemAddOperation.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuItemAddOperation.Size = new Size(301, 22);
            this.MenuItemAddOperation.Text = "Добавить операцию";
            this.MenuItemAddOperation.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(298, 6);
            this.MenuItemAddExecutor.Name = "MenuItemAddExecutor";
            this.MenuItemAddExecutor.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.MenuItemAddExecutor.Size = new Size(301, 22);
            this.MenuItemAddExecutor.Text = "Добавить исполнителя работы";
            this.MenuItemAddExecutor.Click += new EventHandler(this.toolStripMenuItem5_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(298, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(301, 22);
            this.MenuItemRemove.Text = "Удалить";
            this.MenuItemRemove.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.ds.DataSetName = "ds_workoper";
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridViewWorkPeople.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewWorkPeople.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewWorkPeople.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewWorkPeople.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewWorkPeople.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewWorkPeople.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewWorkPeople.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewWorkPeople.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewWorkPeople.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewWorkPeople.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWorkPeople.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewWorkPeople.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewWorkPeople.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewWorkPeople.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewWorkPeople.BorderStyle = BorderStyles.Simple;
            this.gridViewWorkPeople.ChildGridLevelName = "Исполнители";
            this.gridViewWorkPeople.Columns.AddRange(new GridColumn[1]
      {
        this.colpeople_fio2
      });
            this.gridViewWorkPeople.GridControl = this.gridControlWork;
            this.gridViewWorkPeople.Name = "gridViewWorkPeople";
            this.gridViewWorkPeople.OptionsCustomization.AllowFilter = false;
            this.gridViewWorkPeople.OptionsDetail.ShowDetailTabs = false;
            this.gridViewWorkPeople.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewWorkPeople.OptionsView.ShowGroupPanel = false;
            this.gridViewWorkPeople.OptionsView.ShowIndicator = false;
            this.gridViewWorkPeople.ViewCaption = "Исполнители";
            this.colpeople_fio2.Caption = "ФИО";
            this.colpeople_fio2.FieldName = "people_fio";
            this.colpeople_fio2.Name = "colpeople_fio2";
            this.colpeople_fio2.Visible = true;
            this.colpeople_fio2.VisibleIndex = 0;
            this.gridViewWork.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWork.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWork.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWork.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewWork.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewWork.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewWork.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewWork.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWork.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewWork.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewWork.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewWork.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewWork.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewWork.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewWork.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewWork.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewWork.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewWork.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWork.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWork.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewWork.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewWork.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewWork.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewWork.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewWork.BorderStyle = BorderStyles.Simple;
            this.gridViewWork.Columns.AddRange(new GridColumn[5]
      {
        this.colidwork,
        this.colname,
        this.colworkgroup,
        this.colpeople_fio3,
        this.colcomment
      });
            this.gridViewWork.GridControl = this.gridControlWork;
            this.gridViewWork.GroupPanelText = "Панель группировки";
            this.gridViewWork.Name = "gridViewWork";
            this.gridViewWork.OptionsCustomization.AllowFilter = false;
            this.gridViewWork.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewWork.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewWork.OptionsView.ShowIndicator = false;
            this.colidwork.Caption = "#";
            this.colidwork.FieldName = "idwork";
            this.colidwork.Name = "colidwork";
            this.colidwork.OptionsColumn.AllowEdit = false;
            this.colidwork.Visible = true;
            this.colidwork.VisibleIndex = 0;
            this.colname.Caption = "Наименование работы";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colworkgroup.Caption = "Группа";
            this.colworkgroup.FieldName = "workgroup";
            this.colworkgroup.Name = "colworkgroup";
            this.colworkgroup.Visible = true;
            this.colworkgroup.VisibleIndex = 2;
            this.colpeople_fio3.Caption = "Ответственный";
            this.colpeople_fio3.ColumnEdit = (RepositoryItem)this.ButtonEditWorkExecutor;
            this.colpeople_fio3.FieldName = "people_fio";
            this.colpeople_fio3.Name = "colpeople_fio3";
            this.colpeople_fio3.Visible = true;
            this.colpeople_fio3.VisibleIndex = 3;
            this.ButtonEditWorkExecutor.AutoHeight = false;
            this.ButtonEditWorkExecutor.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton()
      });
            this.ButtonEditWorkExecutor.Name = "ButtonEditWorkExecutor";
            this.ButtonEditWorkExecutor.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 4;
            this.ButtonEditSelectValut.AutoHeight = false;
            this.ButtonEditSelectValut.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.ButtonEditSelectValut.Name = "ButtonEditSelectValut";
            this.atTreeListControl1.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeListControl1.Appearance.FocusedCell.ForeColor = Color.Black;
            this.atTreeListControl1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.atTreeListControl1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.atTreeListControl1.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeListControl1.Appearance.FocusedRow.ForeColor = Color.Black;
            this.atTreeListControl1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.atTreeListControl1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.atTreeListControl1.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeListControl1.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeListControl1.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.atTreeListControl1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.atTreeListControl1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.atTreeListControl1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeListControl1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.atTreeListControl1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.atTreeListControl1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.atTreeListControl1.BorderStyle = BorderStyles.Simple;
            this.atTreeListControl1.ColumnText = "Группы работ";
            this.atTreeListControl1.Connection = (dbconn)null;
            this.atTreeListControl1.DataMember = "workgroup";
            this.atTreeListControl1.DataRelation = (string)null;
            this.atTreeListControl1.DataSource = (object)this.ds;
            this.atTreeListControl1.Dock = DockStyle.Left;
            this.atTreeListControl1.DocTable = (string)null;
            this.atTreeListControl1.FindEnableAddress = true;
            this.atTreeListControl1.FindEnableAgreeName = true;
            this.atTreeListControl1.FindEnableComment = true;
            this.atTreeListControl1.FindEnableCustomer = true;
            this.atTreeListControl1.FindEnableDest = true;
            this.atTreeListControl1.FindEnableDocName = true;
            this.atTreeListControl1.FindEnableDocOper = true;
            this.atTreeListControl1.FindEnableDtAgree = true;
            this.atTreeListControl1.FindEnableDtDoc = true;
            this.atTreeListControl1.FindEnableEditDir = true;
            this.atTreeListControl1.FindEnableSign = true;
            this.atTreeListControl1.GridView = (GridView)null;
            this.atTreeListControl1.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.atTreeListControl1.IdDocAppearance = "";
            this.atTreeListControl1.ImageIndexFieldName = "_imageindex";
            this.atTreeListControl1.IsSupportFilter = false;
            this.atTreeListControl1.KeyFieldName = "idworkgroup";
            this.atTreeListControl1.Location = new Point(0, 0);
            this.atTreeListControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.atTreeListControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.atTreeListControl1.MoveItems = (DataRow[])null;
            this.atTreeListControl1.Name = "atTreeListControl1";
            this.atTreeListControl1.OptionsBehavior.AutoFocusNewNode = true;
            this.atTreeListControl1.OptionsView.ShowHorzLines = false;
            this.atTreeListControl1.OptionsView.ShowIndicator = false;
            this.atTreeListControl1.OptionsView.ShowVertLines = false;
            this.atTreeListControl1.ParentFieldName = "parentid";
            this.atTreeListControl1.PrimaryKeyName = "idworkgroup";
            this.atTreeListControl1.Size = new Size(217, 324);
            this.atTreeListControl1.TabIndex = 0;
            this.atTreeListControl1.TableNameDiraction = "";
            this.splitterControl1.Location = new Point(217, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 324);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            this.atButtonsPanel1.AcceptButton = atButtonsPanel.bpButtons.Save;
            this.atButtonsPanel1.CancelButton = atButtonsPanel.bpButtons.Cancel;
            this.atButtonsPanel1.CancelButtonText = "";
            this.atButtonsPanel1.CancelButtonUseCancelSelect = true;
            this.atButtonsPanel1.CancelButtonVisible = true;
            this.atButtonsPanel1.CloseButtonText = "";
            this.atButtonsPanel1.CloseButtonUseCancelSelect = false;
            this.atButtonsPanel1.CloseButtonVisible = false;
            this.atButtonsPanel1.DataMember = (string)null;
            this.atButtonsPanel1.DataSource = (DataSet)null;
            this.atButtonsPanel1.Dock = DockStyle.Bottom;
            this.atButtonsPanel1.EnabledCancelButton = true;
            this.atButtonsPanel1.EnabledCloseButton = true;
            this.atButtonsPanel1.EnabledPrintButton = true;
            this.atButtonsPanel1.EnabledRefreshButton = true;
            this.atButtonsPanel1.EnabledSaveButton = true;
            this.atButtonsPanel1.EnabledScriptButton = true;
            this.atButtonsPanel1.IdDocAppearance = 0;
            this.atButtonsPanel1.Location = new Point(0, 324);
            this.atButtonsPanel1.Name = "atButtonsPanel1";
            this.atButtonsPanel1.PrintButtonText = "";
            this.atButtonsPanel1.PrintButtonVisible = false;
            this.atButtonsPanel1.ProcessedIsDialog = false;
            this.atButtonsPanel1.RefreshButtonText = "Обновить";
            this.atButtonsPanel1.RefreshButtonUseSelectItem = true;
            this.atButtonsPanel1.RefreshButtonVisible = false;
            this.atButtonsPanel1.SaveButtonText = "Выбрать";
            this.atButtonsPanel1.SaveButtonUseSelectItem = true;
            this.atButtonsPanel1.SaveButtonVisible = true;
            this.atButtonsPanel1.ScriptButtonText = "";
            this.atButtonsPanel1.ScriptButtonVisible = false;
            this.atButtonsPanel1.Size = new Size(896, 33);
            this.atButtonsPanel1.TabIndex = 3;
            this.atButtonsPanel1.TextCancelButton = "Отменить";
            this.atButtonsPanel1.TextCloseButton = "Закрыть";
            this.atButtonsPanel1.TextPrintButton = "Печать...";
            this.atButtonsPanel1.TextRefreshButton = "Обновить";
            this.atButtonsPanel1.TextSaveButton = "Применить";
            this.atButtonsPanel1.TextScriptButton = "Скрипты...";
            this.atButtonsPanel1.VisibleCancelButton = true;
            this.atButtonsPanel1.VisibleCloseButton = true;
            this.atButtonsPanel1.VisiblePrintButton = false;
            this.atButtonsPanel1.VisibleRefreshButton = false;
            this.atButtonsPanel1.VisibleSaveButton = true;
            this.atButtonsPanel1.VisibleScriptButton = false;
            this.atButtonsPanel1.WidthPrintButton = 75;
            this.colpeople_fio.Caption = "Ответственный";
            this.colpeople_fio.FieldName = "people_fio";
            this.colpeople_fio.Name = "colpeople_fio";
            this.colpeople_fio.Visible = true;
            this.colpeople_fio.VisibleIndex = 3;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlWork);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.atTreeListControl1);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.Name = "WorkOperForm";
            this.Size = new Size(896, 357);
            this.Text = "Работы и операции";
            this.Shown += new Shown(this.WorkOperForm_Shown);
            this.gridViewOperation.EndInit();
            this.CalcEditValue.EndInit();
            this.ButtonEditExecutorWorkOper.EndInit();
            this.ComboBoxValut.EndInit();
            this.gridControlWork.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.ds.EndInit();
            this.gridViewWorkPeople.EndInit();
            this.gridViewWork.EndInit();
            this.ButtonEditWorkExecutor.EndInit();
            this.ButtonEditSelectValut.EndInit();
            this.atTreeListControl1.EndInit();
            this.atButtonsPanel1.EndInit();
            this.ResumeLayout(false);
        }

        private void gridViewOperation_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            WorkOperForm.ValutPair valutPair = e.Value as WorkOperForm.ValutPair;
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridViewOperation.GridControl);
            if (valutPair == null || dataRow == null)
                return;
            if (e.Column.Name == this.colvalut1_name.Name)
            {
                if (valutPair != null && valutPair.Id.HasValue)
                    dataRow["idvalut1"] = (object)valutPair.Id;
                else
                    dataRow["idvalut1"] = (object)DBNull.Value;
            }
            else if (e.Column.Name == this.colvalut2_name.Name)
            {
                if (valutPair != null && valutPair.Id.HasValue)
                    dataRow["idvalut2"] = (object)valutPair.Id;
                else
                    dataRow["idvalut2"] = (object)DBNull.Value;
            }
            else if (e.Column.Name == this.colvalut3_name.Name)
            {
                if (valutPair != null && valutPair.Id.HasValue)
                    dataRow["idvalut3"] = (object)valutPair.Id;
                else
                    dataRow["idvalut3"] = (object)DBNull.Value;
            }
            else if (e.Column.Name == this.colvalut4_name.Name)
            {
                if (valutPair != null && valutPair.Id.HasValue)
                    dataRow["idvalut4"] = (object)valutPair.Id;
                else
                    dataRow["idvalut4"] = (object)DBNull.Value;
            }
            else
            {
                if (!(e.Column.Name == this.colvalut5_name.Name))
                    return;
                if (valutPair != null && valutPair.Id.HasValue)
                    dataRow["idvalut5"] = (object)valutPair.Id;
                else
                    dataRow["idvalut5"] = (object)DBNull.Value;
            }
        }

        private void WorkOperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AtDataSet.IsModifDataSet((DataSet)this.ds))
                return;
            switch (MessageBox.Show("Сохранить изменения?", "Закрытие справочника работ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            this.SelectItem();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            this.SelectItem();
        }

        public override void LoadFromBase()
        {
            this.ds.RejectChanges();
        }

        public override bool SaveToBase()
        {
            return this.ds.Save();
        }

        public override bool SelectItem()
        {
            if (AtGrid.getDataRow((Control)this.gridControlWork) == null)
                return false;
            return base.SelectItem();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = this.atTreeListControl1.GetSelectedNode();
            if (selectedNode == null)
                return;
            this.ds.work.CreateRow(selectedNode);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlWork);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.ds.workoper.CreateRow(AtGrid.getDataRow((Control)this.gridControlWork));
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlWork);
            if (dataRow == null || AtDataSet.GetFieldInt(dataRow, "idwork") == 0)
                return;
            Atechnology.ecad.Dictionary.People.SelectPeopleForm selectPeopleForm = new Atechnology.ecad.Dictionary.People.SelectPeopleForm(false);
            if (selectPeopleForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow drPeople = selectPeopleForm.SelectPeopleRows[0];
            if (drPeople == null)
                return;
            this.ds.workpeople.CreateRow(dataRow, drPeople);
        }

        private void MenuItemDoublicate_Click(object sender, EventArgs e)
        {
            foreach (DataRow source in AtGrid.getSelectedDataRows((Control)this.gridControlWork))
            {
                if (source is ds_workoper.workRow)
                    ((ds_workoper.workRow)source).Doublicate();
                else
                    AtDataSet.DublicateRow(source, true);
            }
        }

        private void ButtonEditWorkExecutor_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlWork);
            if (dataRow1 == null || dataRow1.Table != this.ds.work)
                return;
            if (e.Button.Index == 0)
            {
                this.ButtonEditWorkExecutor.BeginUpdate();
                dataRow1["idpeople"] = (object)DBNull.Value;
                dataRow1["people_fio"] = (object)DBNull.Value;
                this.ButtonEditWorkExecutor.EndUpdate();
            }
            else
            {
                Atechnology.ecad.Dictionary.People.SelectPeopleForm selectPeopleForm = new Atechnology.ecad.Dictionary.People.SelectPeopleForm(false);
                if (selectPeopleForm.ShowDialog() != DialogResult.OK)
                    return;
                DataRow dataRow2 = selectPeopleForm.SelectPeopleRows[0];
                if (dataRow2 == null)
                    return;
                this.ButtonEditWorkExecutor.BeginUpdate();
                dataRow1["idpeople"] = dataRow2["idpeople"];
                dataRow1["people_fio"] = dataRow2["people_fio"];
                this.ButtonEditWorkExecutor.EndUpdate();
            }
        }

        private void ButtonEditExecutorWorkOper_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlWork);
            if (dataRow1 == null || dataRow1.Table != this.ds.workoper)
                return;
            if (e.Button.Index == 0)
            {
                this.ButtonEditExecutorWorkOper.BeginUpdate();
                dataRow1["idpeople"] = (object)DBNull.Value;
                dataRow1["people_fio"] = (object)DBNull.Value;
                this.ButtonEditExecutorWorkOper.EndUpdate();
            }
            else
            {
                Atechnology.ecad.Dictionary.People.SelectPeopleForm selectPeopleForm = new Atechnology.ecad.Dictionary.People.SelectPeopleForm(false);
                if (selectPeopleForm.ShowDialog() != DialogResult.OK)
                    return;
                DataRow dataRow2 = selectPeopleForm.SelectPeopleRows[0];
                if (dataRow2 == null)
                    return;
                this.ButtonEditExecutorWorkOper.BeginUpdate();
                dataRow1["idpeople"] = dataRow2["idpeople"];
                dataRow1["people_fio"] = dataRow2["people_fio"];
                this.ButtonEditExecutorWorkOper.EndUpdate();
            }
        }

        public void IsDialog()
        {
            this.gridViewWork.OptionsBehavior.Editable = false;
            this.gridViewWork.OptionsSelection.MultiSelect = false;
            this.gridViewOperation.OptionsBehavior.Editable = false;
            this.gridControlWork.ContextMenuStrip = (ContextMenuStrip)null;
            this.atTreeListControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.Is_Dialog = true;
            this.LoadFromBase();
            this.gridViewWork.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
            this.gridViewOperation.DoubleClick += new EventHandler(this.gridView2_DoubleClick);
        }

        private void WorkOperForm_Shown(object sender, EventArgs e)
        {
            new CalcProcessor(dbconn._db).ExecuteOrderEvent("События справочников.Открытие формы работ и операций", (object)this);
        }

        private class ValutPair : IConvertible
        {
            private int? id;
            private string name;

            public int? Id
            {
                get
                {
                    return this.id;
                }
                set
                {
                    this.id = value;
                }
            }

            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }

            public override string ToString()
            {
                return this.Name;
            }

            public TypeCode GetTypeCode()
            {
                return TypeCode.String;
            }

            public bool ToBoolean(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public byte ToByte(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public char ToChar(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public DateTime ToDateTime(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public Decimal ToDecimal(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public double ToDouble(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public short ToInt16(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public int ToInt32(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public long ToInt64(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public sbyte ToSByte(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public float ToSingle(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public string ToString(IFormatProvider provider)
            {
                return this.Name;
            }

            public object ToType(System.Type conversionType, IFormatProvider provider)
            {
                if (conversionType == typeof(string))
                    return (object)this.ToString(provider);
                throw new NotImplementedException();
            }

            public ushort ToUInt16(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public uint ToUInt32(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }

            public ulong ToUInt64(IFormatProvider provider)
            {
                throw new NotImplementedException();
            }
        }
    }
}
