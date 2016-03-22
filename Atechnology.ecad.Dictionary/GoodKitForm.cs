// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodKitForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad;
using Atechnology.ecad.Dictionary.DataSets;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class GoodKitForm : AtUserControl
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
        private GridColumn colidgoodkit;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colkitgroup;
        private GridColumn colqu;
        private GridColumn colthick;
        private GridColumn colheight;
        private GridColumn colwidth;
        private GridColumn colweight;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit2;
        private AtRepositoryItemTextEdit repositoryItemTextEdit3;
        private AtRepositoryItemTextEdit repositoryItemTextEdit4;
        private TreeList treeListGroup;
        private TreeListColumn treeListColumn1;
        private Splitter splitter1;
        private ImageList imageList1;
        private ContextMenuStrip MenuGroup;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem8;
        private GridColumn colidgoodkitgroup;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripSeparator toolStripSeparator4;
        private Panel panel2;
        private GridColumn colsystem_name;
        private TreeListColumn treeListColumn2;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem ToolStripMenuDubl;
        private ToolStripMenuItem MenuItemSeach;
        private ToolStripMenuItem ToolStripMenuItemSetQu;
        public GridControl gridControl1;
        private ds_goodkit ds_goodkit;
        public Button cmdCancelSelect;
        public Button cmdOk;
        private GridColumn colismy;
        private RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private TreeListColumn colisvisible;
        private GridColumn colismain;
        private DataRow MoveGroup;
        private DataRow[] MoveItems;
        private bool isKeyMove;
        private int idgoodgroup;
        private int idgood;
        private bool disableevent;

        public GoodKitForm()
        {
            this.InitializeComponent();
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.Columns["idgoodkitgroup"].ClearFilter();
            this.ds_goodkit.goodkitdetail.Columns["price1"].Prefix = "local";
            this.ds_goodkit.goodkitdetail.Columns["price2"].Prefix = "local";
            this.ds_goodkit.goodkitdetail.Columns["price1base"].Prefix = "local";
            this.ds_goodkit.goodkitdetail.Columns["price2base"].Prefix = "local";
            this.FormClosing += new FormClosing(this.GoodKitForm_FormClosing);
            this.Shown += new Shown(this.GoodKitForm_Shown);
            this.gridView2.DoubleClick += new EventHandler(this.gridView2_DoubleClick);
            this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
            this.treeListGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListGroup_FocusedNodeChanged);
            this.treeListGroup.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeListGroup_CellValueChanged);
            this.treeListGroup.KeyDown += new KeyEventHandler(this.treeListGroup_KeyDown);
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
            GridLevelNode gridLevelNode = new GridLevelNode();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GoodKitForm));
            this.gridView2 = new GridView();
            this.colgood_marking = new GridColumn();
            this.colgood_name = new GridColumn();
            this.colqu = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.colthick = new GridColumn();
            this.colheight = new GridColumn();
            this.repositoryItemTextEdit3 = new AtRepositoryItemTextEdit();
            this.colwidth = new GridColumn();
            this.repositoryItemTextEdit4 = new AtRepositoryItemTextEdit();
            this.colweight = new GridColumn();
            this.repositoryItemTextEdit2 = new AtRepositoryItemTextEdit();
            this.colsystem_name = new GridColumn();
            this.colismain = new GridColumn();
            this.gridControl1 = new GridControl();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem10 = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.toolStripMenuItem9 = new ToolStripMenuItem();
            this.MenuItemSeach = new ToolStripMenuItem();
            this.ToolStripMenuItemSetQu = new ToolStripMenuItem();
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem11 = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.ds_goodkit = new ds_goodkit();
            this.gridView1 = new GridView();
            this.colidgoodkit = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colkitgroup = new GridColumn();
            this.colidgoodkitgroup = new GridColumn();
            this.colismy = new GridColumn();
            this.repositoryItemCheckEdit2 = new RepositoryItemCheckEdit();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.treeListGroup = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.treeListColumn2 = new TreeListColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.colisvisible = new TreeListColumn();
            this.MenuGroup = new ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new ToolStripMenuItem();
            this.toolStripMenuItem6 = new ToolStripMenuItem();
            this.toolStripMenuItem7 = new ToolStripMenuItem();
            this.ToolStripMenuDubl = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItem8 = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.toolStripMenuItem12 = new ToolStripMenuItem();
            this.imageList1 = new ImageList(this.components);
            this.splitter1 = new Splitter();
            this.panel2 = new Panel();
            this.cmdCancelSelect = new Button();
            this.cmdOk = new Button();
            this.gridView2.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemTextEdit3.BeginInit();
            this.repositoryItemTextEdit4.BeginInit();
            this.repositoryItemTextEdit2.BeginInit();
            this.gridControl1.BeginInit();
            this.MenuItem.SuspendLayout();
            this.ds_goodkit.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemCheckEdit2.BeginInit();
            this.panel1.SuspendLayout();
            this.treeListGroup.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.MenuGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.gridView2.Columns.AddRange(new GridColumn[9]
      {
        this.colgood_marking,
        this.colgood_name,
        this.colqu,
        this.colthick,
        this.colheight,
        this.colwidth,
        this.colweight,
        this.colsystem_name,
        this.colismain
      });
            this.gridView2.GridControl = this.gridControl1;
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
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.colthick.Caption = "Длина";
            this.colthick.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colthick.FieldName = "thick";
            this.colthick.Name = "colthick";
            this.colthick.Visible = true;
            this.colthick.VisibleIndex = 3;
            this.colheight.Caption = "Высота";
            this.colheight.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit3;
            this.colheight.FieldName = "height";
            this.colheight.Name = "colheight";
            this.colheight.Visible = true;
            this.colheight.VisibleIndex = 4;
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.colwidth.Caption = "Ширина";
            this.colwidth.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit4;
            this.colwidth.FieldName = "width";
            this.colwidth.Name = "colwidth";
            this.colwidth.Visible = true;
            this.colwidth.VisibleIndex = 5;
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            this.colweight.Caption = "Вес";
            this.colweight.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit2;
            this.colweight.FieldName = "weight";
            this.colweight.Name = "colweight";
            this.colweight.Visible = true;
            this.colweight.VisibleIndex = 6;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.colsystem_name.Caption = "Система";
            this.colsystem_name.FieldName = "system_name";
            this.colsystem_name.Name = "colsystem_name";
            this.colsystem_name.Visible = true;
            this.colsystem_name.VisibleIndex = 7;
            this.colismain.Caption = "Главный";
            this.colismain.FieldName = "ismain";
            this.colismain.Name = "colismain";
            this.colismain.Visible = true;
            this.colismain.VisibleIndex = 8;
            this.gridControl1.ContextMenuStrip = this.MenuItem;
            this.gridControl1.DataMember = "goodkitgroup.FK_goodkitgroup_goodkit";
            this.gridControl1.DataSource = (object)this.ds_goodkit;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode.LevelTemplate = (BaseView)this.gridView2;
            gridLevelNode.RelationName = "FK_goodkit_goodkitdetail";
            this.gridControl1.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
            this.gridControl1.Location = new Point(280, 0);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemTextEdit2,
        (RepositoryItem) this.repositoryItemCheckEdit2
      });
            this.gridControl1.Size = new Size(518, 455);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridView1,
        (BaseView) this.gridView2
      });
            this.MenuItem.Items.AddRange(new ToolStripItem[12]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem10,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.toolStripMenuItem3,
        (ToolStripItem) this.toolStripMenuItem9,
        (ToolStripItem) this.MenuItemSeach,
        (ToolStripItem) this.ToolStripMenuItemSetQu,
        (ToolStripItem) this.toolStripMenuItem4,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem11,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.toolStripMenuItem2
      });
            this.MenuItem.Name = "contextMenuStrip1";
            this.MenuItem.Size = new Size(275, 220);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItem1.Size = new Size(274, 22);
            this.toolStripMenuItem1.Text = "Добавить комплект";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.toolStripMenuItem10.Size = new Size(274, 22);
            this.toolStripMenuItem10.Text = "Дублировать комплект";
            this.toolStripMenuItem10.Click += new EventHandler(this.toolStripMenuItem10_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(271, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItem3.Size = new Size(274, 22);
            this.toolStripMenuItem3.Text = "Добавить материал";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShortcutKeys = Keys.Return | Keys.Control;
            this.toolStripMenuItem9.Size = new Size(274, 22);
            this.toolStripMenuItem9.Text = "Изменить материал";
            this.toolStripMenuItem9.Click += new EventHandler(this.toolStripMenuItem9_Click);
            this.MenuItemSeach.Name = "MenuItemSeach";
            this.MenuItemSeach.ShortcutKeys = Keys.H | Keys.Control;
            this.MenuItemSeach.Size = new Size(274, 22);
            this.MenuItemSeach.Text = "Поиск и замена в наименовании";
            this.MenuItemSeach.Click += new EventHandler(this.MenuItemSeach_Click);
            this.ToolStripMenuItemSetQu.Name = "ToolStripMenuItemSetQu";
            this.ToolStripMenuItemSetQu.Size = new Size(274, 22);
            this.ToolStripMenuItemSetQu.Text = "Задать количество";
            this.ToolStripMenuItemSetQu.Click += new EventHandler(this.ToolStripMenuItemSetQu_Click);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new Size(274, 22);
            this.toolStripMenuItem4.Text = "Удалить материал";
            this.toolStripMenuItem4.Click += new EventHandler(this.toolStripMenuItem4_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(271, 6);
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new Size(274, 22);
            this.toolStripMenuItem11.Text = "Переместить в группу...";
            this.toolStripMenuItem11.Click += new EventHandler(this.toolStripMenuItem11_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(271, 6);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(274, 22);
            this.toolStripMenuItem2.Text = "Удалить";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.ds_goodkit.DataSetName = "ds_goodkit";
            this.ds_goodkit.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
            this.gridView1.Columns.AddRange(new GridColumn[6]
      {
        this.colidgoodkit,
        this.colname,
        this.colcomment,
        this.colkitgroup,
        this.colidgoodkitgroup,
        this.colismy
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colidgoodkit.Caption = "#";
            this.colidgoodkit.FieldName = "idgoodkit";
            this.colidgoodkit.Name = "colidgoodkit";
            this.colidgoodkit.OptionsColumn.AllowEdit = false;
            this.colidgoodkit.Visible = true;
            this.colidgoodkit.VisibleIndex = 0;
            this.colidgoodkit.Width = 57;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 200;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 2;
            this.colcomment.Width = 203;
            this.colkitgroup.Caption = "Группа";
            this.colkitgroup.FieldName = "kitgroup";
            this.colkitgroup.Name = "colkitgroup";
            this.colkitgroup.Width = 210;
            this.colidgoodkitgroup.Caption = "idgoodkitgroup";
            this.colidgoodkitgroup.FieldName = "idgoodkitgroup";
            this.colidgoodkitgroup.Name = "colidgoodkitgroup";
            this.colismy.Caption = "\"Свой\"";
            this.colismy.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit2;
            this.colismy.FieldName = "ismy";
            this.colismy.Name = "colismy";
            this.colismy.Visible = true;
            this.colismy.VisibleIndex = 3;
            this.colismy.Width = 56;
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(798, 33);
            this.panel1.TabIndex = 2;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(711, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(630, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(549, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.treeListGroup.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGroup.Appearance.FocusedCell.ForeColor = Color.Black;
            this.treeListGroup.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeListGroup.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeListGroup.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGroup.Appearance.FocusedRow.ForeColor = Color.Black;
            this.treeListGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeListGroup.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeListGroup.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGroup.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGroup.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.treeListGroup.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeListGroup.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeListGroup.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGroup.Appearance.SelectedRow.ForeColor = Color.Black;
            this.treeListGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeListGroup.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeListGroup.BorderStyle = BorderStyles.Simple;
            this.treeListGroup.Columns.AddRange(new TreeListColumn[3]
      {
        this.treeListColumn1,
        this.treeListColumn2,
        this.colisvisible
      });
            this.treeListGroup.ContextMenuStrip = this.MenuGroup;
            this.treeListGroup.DataMember = "goodkitgroup";
            this.treeListGroup.DataSource = (object)this.ds_goodkit;
            this.treeListGroup.Dock = DockStyle.Left;
            this.treeListGroup.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeListGroup.ImageIndexFieldName = "imageindex_";
            this.treeListGroup.KeyFieldName = "idgoodkitgroup";
            this.treeListGroup.Location = new Point(0, 0);
            this.treeListGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListGroup.Name = "treeListGroup";
            this.treeListGroup.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListGroup.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListGroup.OptionsView.ShowHorzLines = false;
            this.treeListGroup.OptionsView.ShowIndicator = false;
            this.treeListGroup.OptionsView.ShowVertLines = false;
            this.treeListGroup.ParentFieldName = "parentid";
            this.treeListGroup.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemCheckEdit1
      });
            this.treeListGroup.SelectImageList = (object)this.imageList1;
            this.treeListGroup.Size = new Size(277, 455);
            this.treeListGroup.TabIndex = 4;
            this.treeListColumn1.Caption = "Группы комплектов";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 45;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 192;
            this.treeListColumn2.Caption = "Активность";
            this.treeListColumn2.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit1;
            this.treeListColumn2.FieldName = "isactive";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 89;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.colisvisible.Caption = "Видимость";
            this.colisvisible.FieldName = "isvisible";
            this.colisvisible.Name = "colisvisible";
            this.colisvisible.Visible = true;
            this.colisvisible.VisibleIndex = 2;
            this.MenuGroup.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.toolStripMenuItem5,
        (ToolStripItem) this.toolStripMenuItem6,
        (ToolStripItem) this.toolStripMenuItem7,
        (ToolStripItem) this.ToolStripMenuDubl,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripMenuItem8,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.toolStripMenuItem12
      });
            this.MenuGroup.Name = "contextMenuStrip2";
            this.MenuGroup.Size = new Size(298, 148);
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItem5.Size = new Size(297, 22);
            this.toolStripMenuItem5.Text = "Добавить основную группу";
            this.toolStripMenuItem5.Click += new EventHandler(this.toolStripMenuItem5_Click);
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItem6.Size = new Size(297, 22);
            this.toolStripMenuItem6.Text = "Добавить дочернюю группу";
            this.toolStripMenuItem6.Click += new EventHandler(this.toolStripMenuItem6_Click);
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.ShortcutKeys = Keys.Return | Keys.Control;
            this.toolStripMenuItem7.Size = new Size(297, 22);
            this.toolStripMenuItem7.Text = "Переименовать";
            this.toolStripMenuItem7.Click += new EventHandler(this.toolStripMenuItem7_Click);
            this.ToolStripMenuDubl.Name = "ToolStripMenuDubl";
            this.ToolStripMenuDubl.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.ToolStripMenuDubl.Size = new Size(297, 22);
            this.ToolStripMenuDubl.Text = "Дублировать";
            this.ToolStripMenuDubl.Click += new EventHandler(this.ToolStripMenuDubl_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(294, 6);
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItem8.Size = new Size(297, 22);
            this.toolStripMenuItem8.Text = "Удалить";
            this.toolStripMenuItem8.Click += new EventHandler(this.toolStripMenuItem8_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(294, 6);
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new Size(297, 22);
            this.toolStripMenuItem12.Text = "Переместить в группу";
            this.toolStripMenuItem12.Click += new EventHandler(this.toolStripMenuItem12_Click);
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "Folder2.ico");
            this.splitter1.Location = new Point(277, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 455);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            this.panel2.Controls.Add((Control)this.cmdCancelSelect);
            this.panel2.Controls.Add((Control)this.cmdOk);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(798, 33);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            this.cmdCancelSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdCancelSelect.DialogResult = DialogResult.Cancel;
            this.cmdCancelSelect.FlatStyle = FlatStyle.Flat;
            this.cmdCancelSelect.Location = new Point(711, 5);
            this.cmdCancelSelect.Name = "cmdCancelSelect";
            this.cmdCancelSelect.Size = new Size(75, 23);
            this.cmdCancelSelect.TabIndex = 2;
            this.cmdCancelSelect.Text = "Отменить";
            this.cmdOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdOk.DialogResult = DialogResult.OK;
            this.cmdOk.FlatStyle = FlatStyle.Flat;
            this.cmdOk.Location = new Point(630, 5);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new Size(75, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Выбрать";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.splitter1);
            this.Controls.Add((Control)this.treeListGroup);
            this.Controls.Add((Control)this.panel1);
            this.Controls.Add((Control)this.panel2);
            this.Name = "GoodKitForm";
            this.Size = new Size(798, 521);
            this.Text = "Комплекты материалов";
            this.gridView2.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemTextEdit3.EndInit();
            this.repositoryItemTextEdit4.EndInit();
            this.repositoryItemTextEdit2.EndInit();
            this.gridControl1.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.ds_goodkit.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemCheckEdit2.EndInit();
            this.panel1.ResumeLayout(false);
            this.treeListGroup.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.treeListGroup.Focused)
                this.isKeyMove = true;
            if (keyData == Keys.Escape && (this.MoveItems != null || this.MoveGroup != null))
            {
                this.MoveItems = (DataRow[])null;
                this.MoveGroup = (DataRow)null;
                this.Cursor = Cursors.Default;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                this.toolStripMenuItem9_Click((object)null, (EventArgs)null);
            else
                this.gridView1_DoubleClick((object)null, (EventArgs)null);
        }

        private void GoodKitForm_Shown(object sender, EventArgs e)
        {
            this.LoadFromBase();
            this.treeListGroup.MoveLastVisible();
            this.treeListGroup.MoveFirst();
            this.treeListGroup.FilterConditions.Clear();
            if (this.Is_Dialog)
            {
                if (Settings.SavedValues.idgoodkitgroup > 0)
                    AtTreeList.SelectNode(this.treeListGroup, "idgoodkitgroup", Settings.SavedValues.idgoodkitgroup);
                if (Settings.SavedValues.idgoodkit > 0)
                    AtGrid.SelectRow(this.gridControl1, "idgoodkit", (object)Settings.SavedValues.idgoodkit, false);
            }
            this.treeListGroup.OptionsBehavior.Editable = !this.Is_Dialog;
            this.gridView1.OptionsBehavior.Editable = !this.Is_Dialog;
        }

        private void GoodKitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AtDataSet.IsModifDataSet((DataSet)this.ds_goodkit))
            {
                switch (MessageBox.Show("Сохранить изменения?", "Закрытие формы комплектов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        this.SaveToBase();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }
            if (!this.Is_Dialog)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            Settings.SavedValues.idgoodkitgroup = Convert.ToInt32(selectedNode["idgoodkitgroup"]);
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            Settings.SavedValues.idgoodkit = Convert.ToInt32(dataRow["idgoodkit"]);
        }

        private void treeListGroup_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.disableevent)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            if (this.MoveItems != null && (!this.isKeyMove || sender == null))
            {
                foreach (DataRow dataRow in this.MoveItems)
                {
                    if (dataRow != null && dataRow.Table == this.ds_goodkit.goodkit)
                        dataRow["idgoodkitgroup"] = selectedNode["idgoodkitgroup"];
                }
                this.MoveItems = (DataRow[])null;
                this.Cursor = Cursors.Default;
                GC.Collect();
                GC.Collect();
            }
            if (this.MoveGroup != null && (!this.isKeyMove || sender == null))
            {
                this.disableevent = true;
                if (this.MoveGroup["parentid"] == DBNull.Value)
                    this.MoveGroup["imageindex_"] = (object)0;
                this.MoveGroup["parentid"] = selectedNode["idgoodkitgroup"];
                this.Cursor = Cursors.Default;
                this.MoveGroup = (DataRow)null;
                this.isKeyMove = false;
                this.disableevent = false;
            }
            this.isKeyMove = false;
        }

        private void treeListGroup_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Column == this.treeListColumn2)
            {
                DataRow row = ((DataRowView)this.treeListGroup.GetDataRecordByNode(e.Node)).Row;
                foreach (DataRow dataRow in AtTreeList.GetListNodesRows(this.treeListGroup, e.Node))
                    dataRow["isactive"] = row["isactive"];
            }
            if (e.Column != this.colisvisible)
                return;
            DataRow row1 = ((DataRowView)this.treeListGroup.GetDataRecordByNode(e.Node)).Row;
            foreach (DataRow dataRow in AtTreeList.GetListNodesRows(this.treeListGroup, e.Node))
                dataRow["isvisible"] = row1["isvisible"];
        }

        private void treeListGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.treeListGroup.Focused && (this.MoveItems != null || this.MoveGroup != null))
                this.treeListGroup_FocusedNodeChanged((object)null, (FocusedNodeChangedEventArgs)null);
            else
                TreeList_KeyDown.Key(this.treeListGroup, e.KeyCode);
        }

        public override void LoadFromBase()
        {
            if (this.Is_Dialog)
            {
                this.db.command.CommandText = "select * from view_activ_goodkitgroup";
                this.ds_goodkit.EnforceConstraints = false;
            }
            else
                this.db.command.CommandText = "select * from goodkitgroup where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds_goodkit.goodkitgroup);
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.ds_goodkit.goodkitgroup.Rows)
            {
                if (dataRow["parentid"] == DBNull.Value)
                    dataRow["imageindex_"] = (object)1;
            }
            this.ds_goodkit.goodkitgroup.AcceptChanges();
            this.db.command.CommandText = "select * from goodkit where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds_goodkit.goodkit);
            this.db.command.CommandText = "select * from view_goodkitdetail where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds_goodkit.goodkitdetail);
        }

        public override bool SaveToBase()
        {
            using (new ThreadingStatusImageForm("Сохранение данных....", "Пожалуйста, подождите"))
            {
                if (!this.db.SaveDatatable2((DataTable)this.ds_goodkit.goodkitgroup) || !this.db.SaveDatatable2((DataTable)this.ds_goodkit.goodkit) || !this.db.SaveDatatable2((DataTable)this.ds_goodkit.goodkitdetail))
                    return false;
                this.ds_goodkit.AcceptChanges();
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.treeListGroup.Nodes.Clear();
            this.ds_goodkit.Clear();
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.MoveGroup = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (this.MoveGroup == null)
                return;
            this.Cursor = Cursors.Hand;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DataRow row = this.ds_goodkit.goodkitgroup.NewRow();
            row["idgoodkitgroup"] = (object)dbconn.GetGenId("gen_goodkitgroup");
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
            row["imageindex_"] = (object)1;
            row["isactive"] = (object)1;
            row["isvisible"] = (object)1;
            this.ds_goodkit.goodkitgroup.Rows.Add(row);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            DataRow row = this.ds_goodkit.goodkitgroup.NewRow();
            row["idgoodkitgroup"] = (object)dbconn.GetGenId("gen_goodkitgroup");
            if (InputBox.ShowDialog("Создание дочерней группы", "Введите имя", selectedNode["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
            row["parentid"] = selectedNode["idgoodkitgroup"];
            row["isactive"] = (object)1;
            row["isvisible"] = (object)1;
            this.ds_goodkit.goodkitgroup.Rows.Add(row);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null || InputBox.ShowDialog("Изменение группы", "Введите новое имя", "Введите новый комментарий", selectedNode["name"].ToString(), selectedNode["comment"].ToString()) == DialogResult.Cancel)
                return;
            selectedNode["name"] = (object)InputBox.Value;
            selectedNode["comment"] = (object)InputBox.Value2;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            bool flag = false;
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.ds_goodkit.goodkitgroup.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted && dataRow["parentid"] != DBNull.Value && (int)dataRow["parentid"] == (int)selectedNode["idgoodkitgroup"])
                {
                    flag = true;
                    break;
                }
            }
            if (flag && MessageBox.Show("Группа содержит вложенные подгруппы. Удалить группу вместе с вложениями?", "Удаление группы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            selectedNode.Delete();
        }

        private void ToolStripMenuDubl_Click(object sender, EventArgs e)
        {
            List<int[]> ListID = new List<int[]>();
            if (this.treeListGroup.Selection.Count == 0)
                return;
            List<DataRow> listNodesRows = AtTreeList.GetListNodesRows(this.treeListGroup, this.treeListGroup.Selection[0]);
            if (listNodesRows == null || listNodesRows.Count == 0)
                return;
            int num = listNodesRows[0]["Parentid"] == DBNull.Value ? 0 : Convert.ToInt32(listNodesRows[0]["Parentid"]);
            ListID.Add(new int[2]
      {
        num,
        num
      });
            foreach (DataRow source1 in listNodesRows)
            {
                if (source1.RowState != DataRowState.Deleted)
                {
                    int SourceID = source1["parentid"] == DBNull.Value ? 0 : Convert.ToInt32(source1["parentid"]);
                    int parentId = AtTreeList.GetParentID(ListID, SourceID);
                    DataRow dataRow1 = AtDataSet.dublicate(source1);
                    int genId = dbconn.GetGenId("gen_goodkitgroup");
                    dataRow1["idgoodkitgroup"] = (object)genId;
                    if (parentId != 0)
                        dataRow1["parentid"] = (object)parentId;
                    ListID.Add(new int[2]
          {
            Convert.ToInt32(source1["idgoodkitgroup"]),
            genId
          });
                    foreach (DataRow source2 in this.ds_goodkit.goodkit.Select("idgoodkitgroup = " + source1["idgoodkitgroup"].ToString()))
                    {
                        if (source2.RowState != DataRowState.Deleted)
                        {
                            DataRow dataRow2 = AtDataSet.dublicate(source2);
                            dataRow2["idgoodkit"] = (object)dbconn.GetGenId("gen_goodkit");
                            dataRow2["idgoodkitgroup"] = (object)genId;
                            for (int index = 0; index < this.ds_goodkit.goodkitdetail.Rows.Count; ++index)
                            {
                                DataRow source3 = this.ds_goodkit.goodkitdetail.Rows[index];
                                if (source3.RowState != DataRowState.Deleted && (int)source3["idgoodkit"] == (int)source2["idgoodkit"])
                                {
                                    DataRow dataRow3 = AtDataSet.dublicate(source3);
                                    dataRow3["idgoodkitdetail"] = (object)dbconn.GetGenId("gen_goodkitdetail");
                                    dataRow3["idgoodkit"] = dataRow2["idgoodkit"];
                                }
                            }
                        }
                    }
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            DataRow row = this.ds_goodkit.goodkit.NewRow();
            row["idgoodkit"] = (object)dbconn.GetGenId("gen_goodkit");
            row["name"] = (object)"Новый комплект";
            row["idgoodkitgroup"] = selectedNode["idgoodkitgroup"];
            row["ismy"] = (object)(Settings.isDealer ? 1 : 0);
            this.ds_goodkit.goodkit.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows.Length == 0)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows.Length == 0 || selectedDataRows[0].Table != this.ds_goodkit.goodkit)
                return;
            GoodForm goodForm = new GoodForm(false);
            goodForm.IsDialog();
            goodForm.f_idg = this.idgoodgroup;
            goodForm.f_id = this.idgood;
            if (goodForm.ShowDialog(goodForm.DefaultButton, goodForm.CancelButton) != DialogResult.OK)
                return;
            DataRow dataRow1 = AtGrid.getDataRow((Control)goodForm.gridControlGood);
            if (dataRow1 == null || InputBox.ShowDialog("Задать количество", "Введите количество", "0") == DialogResult.Cancel)
                return;
            int result = 0;
            while (!int.TryParse(InputBox.Value, out result))
            {
                if (MessageBox.Show("Не верный формат числа! Попробуете ещё?", "Задать количество", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No || InputBox.ShowDialog("Задать количество", "Введите количество", "0") == DialogResult.Cancel)
                    return;
            }
            foreach (DataRow dataRow2 in selectedDataRows)
            {
                DataRow row = this.ds_goodkit.goodkitdetail.NewRow();
                row["idgoodkitdetail"] = (object)dbconn.GetGenId("gen_goodkitdetail");
                row["idgoodkit"] = dataRow2["idgoodkit"];
                row["idgood"] = dataRow1["idgood"];
                row["good_name"] = dataRow1["name"];
                row["good_marking"] = dataRow1["marking"];
                row["system_name"] = dataRow1["system_name"];
                row["ismain"] = (object)0;
                if (result != 0)
                    row["qu"] = (object)result;
                this.ds_goodkit.goodkitdetail.Rows.Add(row);
            }
            this.idgoodgroup = (int)dataRow1["idgoodgroup"];
            this.idgood = (int)dataRow1["idgood"];
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            int num1 = (int)MessageBox.Show("Выбран один или несколько комплектов!\nВам необходимо выбрать материал, КОТОРЫЙ будет удалён.", "Информация к размышлению", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            GoodForm goodForm = new GoodForm(false);
            goodForm.IsDialog();
            goodForm.Text = "Материалы - выбор материала";
            if (goodForm.ShowDialog(goodForm.DefaultButton, goodForm.CancelButton) != DialogResult.OK)
                return;
            DataRow dataRow1 = AtGrid.getDataRow((Control)goodForm.gridControlGood);
            if (dataRow1 == null)
                return;
            int num2 = (int)dataRow1["idgood"];
            foreach (DataRow dataRow2 in selectedDataRows)
            {
                if (dataRow2.RowState != DataRowState.Deleted)
                {
                    DataRow[] dataRowArray = this.ds_goodkit.goodkitdetail.Select("idgoodkit = " + dataRow2["idgoodkit"].ToString() + " and idgood = " + num2.ToString());
                    if (dataRowArray != null && dataRowArray.Length != 0)
                    {
                        foreach (DataRow dataRow3 in dataRowArray)
                        {
                            if (dataRow2.RowState != DataRowState.Deleted)
                                dataRow3.Delete();
                        }
                    }
                }
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null)
                return;
            if (selectedDataRows[0].Table == this.ds_goodkit.goodkitdetail)
            {
                if (selectedDataRows.Length > 1)
                    return;
                GoodForm goodForm = new GoodForm(false);
                goodForm.IsDialog();
                DataRow[] dataRowArray = goodForm.table_good.Select("idgood = " + selectedDataRows[0]["idgood"].ToString());
                if (dataRowArray.Length == 0)
                {
                    int num = (int)MessageBox.Show("Для изменения данного материала следует установить видимость его группы в справочнике материалов.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    DataRow dataRow1 = dataRowArray[0];
                    goodForm.f_idg = (int)dataRow1["idgoodgroup"];
                    goodForm.f_id = (int)dataRow1["idgood"];
                    if (goodForm.ShowDialog(goodForm.DefaultButton, goodForm.CancelButton) != DialogResult.OK)
                        return;
                    DataRow dataRow2 = AtGrid.getDataRow((Control)goodForm.gridControlGood);
                    if (dataRow2 == null)
                        return;
                    selectedDataRows[0]["idgood"] = dataRow2["idgood"];
                    selectedDataRows[0]["good_name"] = dataRow2["name"];
                    selectedDataRows[0]["good_marking"] = dataRow2["marking"];
                    selectedDataRows[0]["system_name"] = dataRow2["system_name"];
                    this.idgoodgroup = (int)dataRow2["idgoodgroup"];
                    this.idgood = (int)dataRow2["idgood"];
                }
            }
            else
            {
                int num = (int)MessageBox.Show("Выбран один или несколько комплектов!\nСНАЧАЛА Вам необходимо выбрать материал, КОТОРЫЙ необходимо заменить,\nа ЗАТЕМ материал, НА КОТОРЫЙ необходимо заменить.", "Информация к размышлению", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                GoodForm goodForm = new GoodForm(false);
                goodForm.IsDialog();
                goodForm.f_idg = this.idgoodgroup;
                goodForm.f_id = this.idgood;
                goodForm.Text = "Материалы - выбор первого материала";
                goodForm.DoubleChoice = true;
                if (goodForm.ShowDialog((Button)null, goodForm.CancelButton) != DialogResult.OK || goodForm.ChoiceGood1 == null || goodForm.ChoiceGood2 == null)
                    return;
                foreach (DataRow dataRow1 in selectedDataRows)
                {
                    if (dataRow1.RowState != DataRowState.Deleted)
                    {
                        foreach (DataRow dataRow2 in this.ds_goodkit.goodkitdetail.Select("idgoodkit = " + dataRow1["idgoodkit"].ToString() + " and idgood = " + goodForm.ChoiceGood1["idgood"].ToString()))
                        {
                            dataRow2["idgood"] = goodForm.ChoiceGood2["idgood"];
                            dataRow2["good_name"] = goodForm.ChoiceGood2["name"];
                            dataRow2["good_marking"] = goodForm.ChoiceGood2["marking"];
                            dataRow2["system_name"] = goodForm.ChoiceGood2["system_name"];
                        }
                    }
                }
                this.idgoodgroup = (int)goodForm.ChoiceGood2["idgoodgroup"];
                this.idgood = (int)goodForm.ChoiceGood2["idgood"];
            }
        }

        private void MenuItemSeach_Click(object sender, EventArgs e)
        {
            if (InputBox.ShowDialog("Изменение в наименовании комплектов", "Искать", "Заменить на", "", "") == DialogResult.Cancel)
                return;
            string oldValue = InputBox.Value;
            string newValue = InputBox.Value2;
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            foreach (DataRow dataRow in selectedDataRows)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    string str = dataRow["name"].ToString().Replace(oldValue, newValue);
                    dataRow["name"] = (object)str;
                }
            }
        }

        private void ToolStripMenuItemSetQu_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            int num1 = (int)MessageBox.Show("Выбран один или несколько комплектов!\nСНАЧАЛА Вам необходимо выбрать материал, для КОТОРОГО\nнеобходимо установить количество,а ЗАТЕМ задать это количество.", "Информация к размышлению", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            GoodForm goodForm = new GoodForm(false);
            goodForm.IsDialog();
            goodForm.f_idg = this.idgoodgroup;
            goodForm.f_id = this.idgood;
            goodForm.Text = "Материалы - выбор материала";
            if (goodForm.ShowDialog(goodForm.DefaultButton, goodForm.CancelButton) != DialogResult.OK)
                return;
            DataRow dataRow1 = AtGrid.getDataRow((Control)goodForm.gridControlGood);
            if (dataRow1 == null)
                return;
            this.idgoodgroup = (int)dataRow1["idgoodgroup"];
            this.idgood = (int)dataRow1["idgood"];
            int num2 = (int)dataRow1["idgood"];
            if (InputBox.ShowDialog("Задать количество", "Введите количество", "0") == DialogResult.Cancel)
                return;
            int result = 0;
            while (!int.TryParse(InputBox.Value, out result))
            {
                if (MessageBox.Show("Не верный формат числа! Попробуете ещё?", "Задать количество", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No || InputBox.ShowDialog("Задать количество", "Введите количество", "0") == DialogResult.Cancel)
                    return;
            }
            foreach (DataRow dataRow2 in selectedDataRows)
            {
                if (dataRow2.RowState != DataRowState.Deleted)
                {
                    DataRow[] dataRowArray = this.ds_goodkit.goodkitdetail.Select("idgoodkit = " + dataRow2["idgoodkit"].ToString() + " and idgood = " + num2.ToString());
                    if (dataRowArray == null || dataRowArray.Length == 0)
                        break;
                    foreach (DataRow dataRow3 in dataRowArray)
                    {
                        if (dataRow2.RowState != DataRowState.Deleted)
                            dataRow3["qu"] = (object)result;
                    }
                }
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null)
                return;
            foreach (DataRow source in selectedDataRows)
            {
                if (source.Table == this.ds_goodkit.goodkit)
                    AtDataSet.DublicateRow(source, true, "FK_goodkit_goodkitdetail");
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (this.MoveItems == null || this.MoveItems.Length == 0)
                this.MoveItems = (DataRow[])null;
            else
                this.Cursor = Cursors.Hand;
        }

        public void IsDialog()
        {
            this.gridView1.OptionsSelection.MultiSelect = false;
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.treeListGroup.ContextMenuStrip = (ContextMenuStrip)null;
            this.gridControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.treeListGroup.MoveFirst();
            this.Is_Dialog = true;
        }
    }
}
