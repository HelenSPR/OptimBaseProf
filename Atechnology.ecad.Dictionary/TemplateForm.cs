// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.TemplateForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad;
using Atechnology.ecad.Calc.winDraw;
using Atechnology.ecad.Dictionary.Classes;
using Atechnology.ecad.Dictionary.DataSets;
using Atechnology.winDraw;
using Atechnology.winDraw.Model.Settings;
using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Card;
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
    public class TemplateForm : AtUserControl
    {
        public List<Atechnology.winDraw.winDraw> winDrawList = new List<Atechnology.winDraw.winDraw>();
        private IContainer components;
        private SplitterControl splitterControl1;
        private TreeList treeListTemplateGroup;
        private TreeListColumn coltemplategroup;
        private ImageList imageList1;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem MenuItemEdit;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripMenuItem MenuItemDoublicate;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemRemove;
        private ToolStripSeparator toolStripSeparator2;
        private ContextMenuStrip MenuGroup;
        private ToolStripMenuItem MenuGroupeAddMain;
        private ToolStripMenuItem MenuGroupeAddChild;
        private ToolStripMenuItem MenuGroupeRename;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MenuGroupeRemove;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MenuGroupSetMain;
        private ToolStripMenuItem MenuGroupMoveToGroup;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem MenuItemMoveToGroup;
        private GridControl gridControlTemplate;
        private CardView cardViewTemplate;
        private GridColumn colidtemplate;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colpicture;
        private RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private ContextMenuStrip MenuItemOpen;
        private ToolStripMenuItem MenuItemSelectTemplate;
        private BarAndDockingController barAndDockingController1;
        private DockManager dockManager1;
        private ds_template ds;
        private DockPanel dockPanelButtons;
        private ControlContainer dockPanel1_Container;
        private atButtonsPanel atButtonsPanel1;
        private DockPanel dockPanelParam;
        private ControlContainer dockPanel4_Container;
        private GroupBox groupBoxColors;
        private atColorPopUpContainer1 atColorIn;
        private atColorPopUpContainer1 atColorOut;
        private Label label3;
        private Label label4;
        private GroupBox groupBoxSystems;
        private ComboBoxEdit cboFurnitureSystem;
        private ComboBoxEdit cboProfilSystems;
        private Label label2;
        private Label label1;
        private GridControl gridControlParam;
        private GridView gridViewParam;
        private GridColumn colmodelpart;
        private GridColumn colmodelparam_name;
        private GridColumn colstrvalue;
        private RepositoryItemComboBox cboStrValue1;
        private GridColumn colstrvalue2;
        private RepositoryItemComboBox cboStrValue2;
        private GridColumn colintvalue;
        private RepositoryItemComboBox cboNumericValue;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem MenuItemRecalc;
        private GridColumn coltemplatetype;
        public Atechnology.winDraw.winDraw wd;
        private bool disableEvent;
        public ds_template.templateRow Result;
        private TemplateClass DocClass;

        public TemplateForm(bool isDialog)
        {
            this.InitializeComponent();
            this.Is_Dialog = isDialog;
            this.DocClass = new TemplateClass(this.ds, TemplateType.Construction, false);
            this.coltemplatetype.FilterInfo = new ColumnFilterInfo("templatetype is null or templatetype = 1 or templatetype = 2");
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.TemplateForm_FormClosing);
            this.Shown += new Shown(this.TemplateForm_Shown);
            this.cardViewTemplate.RowCountChanged += new EventHandler(this.cardViewTemplate_RowCountChanged);
            this.cardViewTemplate.DoubleClick += new EventHandler(this.cardViewTemplate_DoubleClick);
            this.cardViewTemplate.SelectionChanged += new SelectionChangedEventHandler(this.cardViewTemplate_SelectionChanged);
            this.treeListTemplateGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListTemplateGroup_FocusedNodeChanged);
            this.MenuGroupSetMain.Click += new EventHandler(this.MenuGroupSetMain_Click);
            this.MenuGroupMoveToGroup.Click += new EventHandler(this.MenuGroupMoveToGroup_Click);
            this.ApplyGrants();
            if (this.gridViewParam.OptionsBehavior.Editable)
                this.gridViewParam.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridViewParam_FocusedRowChanged);
            this.MenuItem.Opening += new CancelEventHandler(this.MenuItem_Opening);
            this.MenuGroup.Opening += new CancelEventHandler(this.MenuGroup_Opening);
            this.ds.template.templateRowChanged += new ds_template.templateRowChangeEventHandler(this.template_templateRowChanged);
            this.ds.template.templateRowChanging += new ds_template.templateRowChangeEventHandler(this.template_templateRowChanging);
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TemplateForm));
            this.MenuItem = new ContextMenuStrip(this.components);
            this.MenuItemEdit = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemAdd = new ToolStripMenuItem();
            this.MenuItemDoublicate = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.MenuItemMoveToGroup = new ToolStripMenuItem();
            this.toolStripSeparator6 = new ToolStripSeparator();
            this.MenuItemRecalc = new ToolStripMenuItem();
            this.splitterControl1 = new SplitterControl();
            this.treeListTemplateGroup = new TreeList();
            this.coltemplategroup = new TreeListColumn();
            this.MenuGroup = new ContextMenuStrip(this.components);
            this.MenuGroupeAddMain = new ToolStripMenuItem();
            this.MenuGroupeAddChild = new ToolStripMenuItem();
            this.MenuGroupeRename = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.MenuGroupeRemove = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.MenuGroupSetMain = new ToolStripMenuItem();
            this.MenuGroupMoveToGroup = new ToolStripMenuItem();
            this.ds = new ds_template();
            this.imageList1 = new ImageList(this.components);
            this.gridControlTemplate = new GridControl();
            this.cardViewTemplate = new CardView();
            this.colpicture = new GridColumn();
            this.repositoryItemPictureEdit1 = new RepositoryItemPictureEdit();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colidtemplate = new GridColumn();
            this.coltemplatetype = new GridColumn();
            this.MenuItemOpen = new ContextMenuStrip(this.components);
            this.MenuItemSelectTemplate = new ToolStripMenuItem();
            this.barAndDockingController1 = new BarAndDockingController(this.components);
            this.dockManager1 = new DockManager(this.components);
            this.dockPanelButtons = new DockPanel();
            this.dockPanel1_Container = new ControlContainer();
            this.dockPanelParam = new DockPanel();
            this.dockPanel4_Container = new ControlContainer();
            this.gridControlParam = new GridControl();
            this.gridViewParam = new GridView();
            this.colmodelpart = new GridColumn();
            this.colmodelparam_name = new GridColumn();
            this.colstrvalue = new GridColumn();
            this.cboStrValue1 = new RepositoryItemComboBox();
            this.colstrvalue2 = new GridColumn();
            this.cboStrValue2 = new RepositoryItemComboBox();
            this.colintvalue = new GridColumn();
            this.cboNumericValue = new RepositoryItemComboBox();
            this.groupBoxColors = new GroupBox();
            this.atColorIn = new atColorPopUpContainer1();
            this.atColorOut = new atColorPopUpContainer1();
            this.label3 = new Label();
            this.label4 = new Label();
            this.groupBoxSystems = new GroupBox();
            this.cboFurnitureSystem = new ComboBoxEdit();
            this.cboProfilSystems = new ComboBoxEdit();
            this.label2 = new Label();
            this.label1 = new Label();
            this.atButtonsPanel1 = new atButtonsPanel();
            this.MenuItem.SuspendLayout();
            this.treeListTemplateGroup.BeginInit();
            this.MenuGroup.SuspendLayout();
            this.ds.BeginInit();
            this.gridControlTemplate.BeginInit();
            this.cardViewTemplate.BeginInit();
            this.repositoryItemPictureEdit1.BeginInit();
            this.MenuItemOpen.SuspendLayout();
            this.barAndDockingController1.BeginInit();
            this.dockManager1.BeginInit();
            this.dockPanelButtons.SuspendLayout();
            this.dockPanelParam.SuspendLayout();
            this.dockPanel4_Container.SuspendLayout();
            this.gridControlParam.BeginInit();
            this.gridViewParam.BeginInit();
            this.cboStrValue1.BeginInit();
            this.cboStrValue2.BeginInit();
            this.cboNumericValue.BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.atColorIn.BeginInit();
            this.atColorIn.Properties.BeginInit();
            this.atColorOut.BeginInit();
            this.atColorOut.Properties.BeginInit();
            this.groupBoxSystems.SuspendLayout();
            this.cboFurnitureSystem.Properties.BeginInit();
            this.cboProfilSystems.Properties.BeginInit();
            this.atButtonsPanel1.BeginInit();
            this.SuspendLayout();
            this.MenuItem.Items.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.MenuItemEdit,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.MenuItemDoublicate,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemRemove,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.MenuItemMoveToGroup,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.MenuItemRecalc
      });
            this.MenuItem.Name = "contextMenuStrip1";
            this.MenuItem.Size = new Size(253, 160);
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuItemEdit.Size = new Size(252, 22);
            this.MenuItemEdit.Text = "Редактировать шаблон";
            this.MenuItemEdit.Click += new EventHandler(this.MenuItemEdit_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(249, 6);
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAdd.Size = new Size(252, 22);
            this.MenuItemAdd.Text = "Добавить шаблон";
            this.MenuItemAdd.Click += new EventHandler(this.MenuItemAdd_Click);
            this.MenuItemDoublicate.Name = "MenuItemDoublicate";
            this.MenuItemDoublicate.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.MenuItemDoublicate.Size = new Size(252, 22);
            this.MenuItemDoublicate.Text = "Дублировать шаблон";
            this.MenuItemDoublicate.Click += new EventHandler(this.MenuItemDoublicate_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(249, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(252, 22);
            this.MenuItemRemove.Text = "Удалить шаблон";
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(249, 6);
            this.MenuItemMoveToGroup.Name = "MenuItemMoveToGroup";
            this.MenuItemMoveToGroup.ShortcutKeys = Keys.F6;
            this.MenuItemMoveToGroup.Size = new Size(252, 22);
            this.MenuItemMoveToGroup.Text = "Переместить в группу";
            this.MenuItemMoveToGroup.Click += new EventHandler(this.MenuItemMoveToGroup_Click);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new Size(249, 6);
            this.MenuItemRecalc.Name = "MenuItemRecalc";
            this.MenuItemRecalc.Size = new Size(252, 22);
            this.MenuItemRecalc.Text = "Пересчитать шаблон";
            this.MenuItemRecalc.Click += new EventHandler(this.MenuItemRecalc_Click);
            this.splitterControl1.Location = new Point(197, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 376);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            this.treeListTemplateGroup.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListTemplateGroup.Appearance.FocusedCell.ForeColor = Color.Black;
            this.treeListTemplateGroup.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeListTemplateGroup.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeListTemplateGroup.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListTemplateGroup.Appearance.FocusedRow.ForeColor = Color.Black;
            this.treeListTemplateGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeListTemplateGroup.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeListTemplateGroup.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListTemplateGroup.Appearance.SelectedRow.ForeColor = Color.Black;
            this.treeListTemplateGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeListTemplateGroup.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeListTemplateGroup.BorderStyle = BorderStyles.Simple;
            this.treeListTemplateGroup.Columns.AddRange(new TreeListColumn[1]
      {
        this.coltemplategroup
      });
            this.treeListTemplateGroup.ContextMenuStrip = this.MenuGroup;
            this.treeListTemplateGroup.DataMember = "templategroup";
            this.treeListTemplateGroup.DataSource = (object)this.ds;
            this.treeListTemplateGroup.Dock = DockStyle.Left;
            this.treeListTemplateGroup.KeyFieldName = "idtemplategroup";
            this.treeListTemplateGroup.Location = new Point(0, 0);
            this.treeListTemplateGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListTemplateGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListTemplateGroup.Name = "treeListTemplateGroup";
            this.treeListTemplateGroup.OptionsBehavior.Editable = false;
            this.treeListTemplateGroup.OptionsView.ShowHorzLines = false;
            this.treeListTemplateGroup.OptionsView.ShowIndicator = false;
            this.treeListTemplateGroup.OptionsView.ShowVertLines = false;
            this.treeListTemplateGroup.ParentFieldName = "parentid";
            this.treeListTemplateGroup.SelectImageList = (object)this.imageList1;
            this.treeListTemplateGroup.Size = new Size(197, 376);
            this.treeListTemplateGroup.TabIndex = 2;
            this.coltemplategroup.Caption = "Группы шаблонов";
            this.coltemplategroup.FieldName = "name";
            this.coltemplategroup.MinWidth = 173;
            this.coltemplategroup.Name = "coltemplategroup";
            this.coltemplategroup.OptionsColumn.AllowSort = false;
            this.coltemplategroup.Visible = true;
            this.coltemplategroup.VisibleIndex = 0;
            this.coltemplategroup.Width = 93;
            this.MenuGroup.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.MenuGroupeAddMain,
        (ToolStripItem) this.MenuGroupeAddChild,
        (ToolStripItem) this.MenuGroupeRename,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.MenuGroupeRemove,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.MenuGroupSetMain,
        (ToolStripItem) this.MenuGroupMoveToGroup
      });
            this.MenuGroup.Name = "contextMenuStrip1";
            this.MenuGroup.Size = new Size(298, 148);
            this.MenuGroupeAddMain.Name = "MenuGroupeAddMain";
            this.MenuGroupeAddMain.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuGroupeAddMain.Size = new Size(297, 22);
            this.MenuGroupeAddMain.Text = "Добавить основную группу";
            this.MenuGroupeAddMain.Click += new EventHandler(this.mnuAddRootGroupe_Click);
            this.MenuGroupeAddChild.Name = "MenuGroupeAddChild";
            this.MenuGroupeAddChild.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuGroupeAddChild.Size = new Size(297, 22);
            this.MenuGroupeAddChild.Text = "Добавить дочернюю группу";
            this.MenuGroupeAddChild.Click += new EventHandler(this.MenuGroupAddChild_Click);
            this.MenuGroupeRename.Name = "MenuGroupeRename";
            this.MenuGroupeRename.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuGroupeRename.Size = new Size(297, 22);
            this.MenuGroupeRename.Text = "Переименовать группу";
            this.MenuGroupeRename.Click += new EventHandler(this.mnuRenameGroup_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(294, 6);
            this.MenuGroupeRemove.Name = "MenuGroupeRemove";
            this.MenuGroupeRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuGroupeRemove.Size = new Size(297, 22);
            this.MenuGroupeRemove.Text = "Удалить";
            this.MenuGroupeRemove.Click += new EventHandler(this.MenuGroupRemove_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(294, 6);
            this.MenuGroupSetMain.Name = "MenuGroupSetMain";
            this.MenuGroupSetMain.ShortcutKeys = Keys.M | Keys.Shift | Keys.Control;
            this.MenuGroupSetMain.Size = new Size(297, 22);
            this.MenuGroupSetMain.Text = "Сделать группу основной";
            this.MenuGroupMoveToGroup.Name = "MenuGroupMoveToGroup";
            this.MenuGroupMoveToGroup.ShortcutKeys = Keys.F6;
            this.MenuGroupMoveToGroup.Size = new Size(297, 22);
            this.MenuGroupMoveToGroup.Text = "Переместить в группу";
            this.ds.DataSetName = "ds_template";
            this.ds.EnforceConstraints = false;
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "VSFolder_closed.bmp");
            this.gridControlTemplate.ContextMenuStrip = this.MenuItem;
            this.gridControlTemplate.DataMember = "templategroup.FK_template_templategroup";
            this.gridControlTemplate.DataSource = (object)this.ds;
            this.gridControlTemplate.Dock = DockStyle.Fill;
            this.gridControlTemplate.EmbeddedNavigator.Name = "";
            this.gridControlTemplate.Location = new Point(203, 0);
            this.gridControlTemplate.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlTemplate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlTemplate.MainView = (BaseView)this.cardViewTemplate;
            this.gridControlTemplate.Name = "gridControlTemplate";
            this.gridControlTemplate.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemPictureEdit1
      });
            this.gridControlTemplate.Size = new Size(414, 376);
            this.gridControlTemplate.TabIndex = 0;
            this.gridControlTemplate.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.cardViewTemplate
      });
            this.cardViewTemplate.Appearance.FieldCaption.ForeColor = Color.White;
            this.cardViewTemplate.Appearance.FieldCaption.Options.UseForeColor = true;
            this.cardViewTemplate.Appearance.FocusedCardCaption.BorderColor = Color.Red;
            this.cardViewTemplate.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.cardViewTemplate.Appearance.HideSelectionCardCaption.BorderColor = Color.Red;
            this.cardViewTemplate.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.cardViewTemplate.Appearance.SelectedCardCaption.BorderColor = Color.Red;
            this.cardViewTemplate.Appearance.SelectedCardCaption.Options.UseBorderColor = true;
            this.cardViewTemplate.Appearance.SeparatorLine.BackColor = Color.White;
            this.cardViewTemplate.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.cardViewTemplate.BorderStyle = BorderStyles.Simple;
            this.cardViewTemplate.CardCaptionFormat = " {2}";
            this.cardViewTemplate.Columns.AddRange(new GridColumn[5]
      {
        this.colpicture,
        this.colname,
        this.colcomment,
        this.colidtemplate,
        this.coltemplatetype
      });
            this.cardViewTemplate.FocusedCardTopFieldIndex = 0;
            this.cardViewTemplate.GridControl = this.gridControlTemplate;
            this.cardViewTemplate.Name = "cardViewTemplate";
            this.cardViewTemplate.OptionsBehavior.FieldAutoHeight = true;
            this.cardViewTemplate.OptionsSelection.MultiSelect = true;
            this.cardViewTemplate.OptionsView.ShowCardCaption = false;
            this.cardViewTemplate.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.cardViewTemplate.OptionsView.ShowQuickCustomizeButton = false;
            this.cardViewTemplate.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.colpicture.ColumnEdit = (RepositoryItem)this.repositoryItemPictureEdit1;
            this.colpicture.FieldName = "picture";
            this.colpicture.Name = "colpicture";
            this.colpicture.OptionsColumn.AllowEdit = false;
            this.colpicture.OptionsColumn.ReadOnly = true;
            this.colpicture.OptionsColumn.ShowCaption = false;
            this.colpicture.Visible = true;
            this.colpicture.VisibleIndex = 0;
            this.repositoryItemPictureEdit1.CustomHeight = 110;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ReadOnly = true;
            this.repositoryItemPictureEdit1.ShowMenu = false;
            this.colname.AppearanceHeader.ForeColor = SystemColors.ControlText;
            this.colname.AppearanceHeader.Options.UseForeColor = true;
            this.colname.Caption = "Наименование";
            this.colname.CustomizationCaption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colcomment.AppearanceHeader.ForeColor = SystemColors.ControlText;
            this.colcomment.AppearanceHeader.Options.UseForeColor = true;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 2;
            this.colidtemplate.AppearanceHeader.ForeColor = SystemColors.ControlText;
            this.colidtemplate.AppearanceHeader.Options.UseForeColor = true;
            this.colidtemplate.Caption = "#";
            this.colidtemplate.FieldName = "idtemplate";
            this.colidtemplate.Name = "colidtemplate";
            this.colidtemplate.OptionsColumn.AllowEdit = false;
            this.colidtemplate.Visible = true;
            this.colidtemplate.VisibleIndex = 3;
            this.coltemplatetype.Caption = "coltemplatetype";
            this.coltemplatetype.FieldName = "templatetype";
            this.coltemplatetype.Name = "coltemplatetype";
            this.MenuItemOpen.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.MenuItemSelectTemplate
      });
            this.MenuItemOpen.Name = "contextMenuStrip1";
            this.MenuItemOpen.Size = new Size(218, 26);
            this.MenuItemSelectTemplate.Name = "MenuItemSelectTemplate";
            this.MenuItemSelectTemplate.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuItemSelectTemplate.Size = new Size(217, 22);
            this.MenuItemSelectTemplate.Text = "Выбрать шаблон";
            this.MenuItemSelectTemplate.Click += new EventHandler(this.MenuItemSelectTemplate_Click);
            this.dockManager1.Controller = this.barAndDockingController1;
            this.dockManager1.Form = (ContainerControl)this;
            this.dockManager1.RootPanels.AddRange(new DockPanel[2]
      {
        this.dockPanelButtons,
        this.dockPanelParam
      });
            this.dockManager1.TopZIndexControls.AddRange(new string[4]
      {
        "DevExpress.XtraBars.BarDockControl",
        "System.Windows.Forms.StatusBar",
        "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
        "DevExpress.XtraBars.Ribbon.RibbonControl"
      });
            this.dockPanelButtons.Controls.Add((Control)this.dockPanel1_Container);
            this.dockPanelButtons.Dock = DockingStyle.Bottom;
            this.dockPanelButtons.ID = new Guid("5c6dc2a0-e306-4934-9748-2333444ffeaa");
            this.dockPanelButtons.Location = new Point(0, 376);
            this.dockPanelButtons.Name = "dockPanelButtons";
            this.dockPanelButtons.Options.AllowDockFill = false;
            this.dockPanelButtons.Options.AllowDockLeft = false;
            this.dockPanelButtons.Options.AllowDockRight = false;
            this.dockPanelButtons.Options.AllowDockTop = false;
            this.dockPanelButtons.Options.AllowFloating = false;
            this.dockPanelButtons.Options.FloatOnDblClick = false;
            this.dockPanelButtons.Options.ShowAutoHideButton = false;
            this.dockPanelButtons.Options.ShowCloseButton = false;
            this.dockPanelButtons.Options.ShowMaximizeButton = false;
            this.dockPanelButtons.Size = new Size(617, 33);
            this.dockPanel1_Container.Location = new Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new Size(866, 5);
            this.dockPanel1_Container.TabIndex = 0;
            this.dockPanelParam.Controls.Add((Control)this.dockPanel4_Container);
            this.dockPanelParam.Dock = DockingStyle.Right;
            this.dockPanelParam.ID = new Guid("4e523344-79bc-44e1-bbba-099b0a70027a");
            this.dockPanelParam.Location = new Point(617, 0);
            this.dockPanelParam.Name = "dockPanelParam";
            this.dockPanelParam.Options.AllowDockBottom = false;
            this.dockPanelParam.Options.AllowDockFill = false;
            this.dockPanelParam.Options.AllowDockLeft = false;
            this.dockPanelParam.Options.AllowDockTop = false;
            this.dockPanelParam.Options.AllowFloating = false;
            this.dockPanelParam.Options.FloatOnDblClick = false;
            this.dockPanelParam.Options.ShowCloseButton = false;
            this.dockPanelParam.Options.ShowMaximizeButton = false;
            this.dockPanelParam.Size = new Size((int)byte.MaxValue, 409);
            this.dockPanelParam.Text = "Характеристики";
            this.dockPanel4_Container.Controls.Add((Control)this.gridControlParam);
            this.dockPanel4_Container.Controls.Add((Control)this.groupBoxColors);
            this.dockPanel4_Container.Controls.Add((Control)this.groupBoxSystems);
            this.dockPanel4_Container.Location = new Point(3, 25);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new Size(249, 348);
            this.dockPanel4_Container.TabIndex = 0;
            this.gridControlParam.DataMember = "templategroup.FK_template_templategroup.FK_template_templateparam";
            this.gridControlParam.DataSource = (object)this.ds;
            this.gridControlParam.Dock = DockStyle.Fill;
            this.gridControlParam.EmbeddedNavigator.Name = "";
            this.gridControlParam.Location = new Point(0, 140);
            this.gridControlParam.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlParam.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlParam.MainView = (BaseView)this.gridViewParam;
            this.gridControlParam.Name = "gridControlParam";
            this.gridControlParam.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.cboNumericValue,
        (RepositoryItem) this.cboStrValue1,
        (RepositoryItem) this.cboStrValue2
      });
            this.gridControlParam.Size = new Size(249, 208);
            this.gridControlParam.TabIndex = 2;
            this.gridControlParam.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewParam
      });
            this.gridViewParam.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewParam.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewParam.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewParam.Columns.AddRange(new GridColumn[5]
      {
        this.colmodelpart,
        this.colmodelparam_name,
        this.colstrvalue,
        this.colstrvalue2,
        this.colintvalue
      });
            this.gridViewParam.GridControl = this.gridControlParam;
            this.gridViewParam.GroupPanelText = "Панель группировки";
            this.gridViewParam.Name = "gridViewParam";
            this.gridViewParam.OptionsView.ShowIndicator = false;
            this.colmodelpart.Caption = "Часть";
            this.colmodelpart.FieldName = "modelpart";
            this.colmodelpart.Name = "colmodelpart";
            this.colmodelpart.Visible = true;
            this.colmodelpart.VisibleIndex = 0;
            this.colmodelparam_name.Caption = "Параметр";
            this.colmodelparam_name.FieldName = "modelparam_name";
            this.colmodelparam_name.Name = "colmodelparam_name";
            this.colmodelparam_name.Visible = true;
            this.colmodelparam_name.VisibleIndex = 1;
            this.colstrvalue.Caption = "Стока 1";
            this.colstrvalue.ColumnEdit = (RepositoryItem)this.cboStrValue1;
            this.colstrvalue.FieldName = "strvalue";
            this.colstrvalue.Name = "colstrvalue";
            this.colstrvalue.Visible = true;
            this.colstrvalue.VisibleIndex = 2;
            this.cboStrValue1.AutoHeight = false;
            this.cboStrValue1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboStrValue1.Name = "cboStrValue1";
            this.colstrvalue2.Caption = "Строка 2";
            this.colstrvalue2.ColumnEdit = (RepositoryItem)this.cboStrValue2;
            this.colstrvalue2.FieldName = "strvalue2";
            this.colstrvalue2.Name = "colstrvalue2";
            this.colstrvalue2.Visible = true;
            this.colstrvalue2.VisibleIndex = 3;
            this.cboStrValue2.AutoHeight = false;
            this.cboStrValue2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboStrValue2.Name = "cboStrValue2";
            this.colintvalue.Caption = "Число";
            this.colintvalue.ColumnEdit = (RepositoryItem)this.cboNumericValue;
            this.colintvalue.FieldName = "intvalue";
            this.colintvalue.Name = "colintvalue";
            this.colintvalue.Visible = true;
            this.colintvalue.VisibleIndex = 4;
            this.cboNumericValue.AutoHeight = false;
            this.cboNumericValue.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboNumericValue.Name = "cboNumericValue";
            this.groupBoxColors.Controls.Add((Control)this.atColorIn);
            this.groupBoxColors.Controls.Add((Control)this.atColorOut);
            this.groupBoxColors.Controls.Add((Control)this.label3);
            this.groupBoxColors.Controls.Add((Control)this.label4);
            this.groupBoxColors.Dock = DockStyle.Top;
            this.groupBoxColors.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            this.groupBoxColors.Location = new Point(0, 70);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new Size(249, 70);
            this.groupBoxColors.TabIndex = 1;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            this.atColorIn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.atColorIn.EditValue = (object)"";
            this.atColorIn.IdColor = (object)null;
            this.atColorIn.Location = new Point(77, 40);
            this.atColorIn.Name = "atColorIn";
            this.atColorIn.NewColorFullName = (string)null;
            this.atColorIn.NewColorGroupName = (string)null;
            this.atColorIn.NewColorName = (string)null;
            this.atColorIn.NewShowColorFormatString = "{0}\\{1}";
            this.atColorIn.Properties.BorderStyle = BorderStyles.Simple;
            this.atColorIn.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.atColorIn.ShowColorMode = atColorPopUpContainer1.ShowColorModeType.GroupAndColor;
            this.atColorIn.Size = new Size(166, 20);
            this.atColorIn.TabIndex = 1;
            this.atColorIn.SelectedColor += new atColorPopUpContainer1.SelectedColor_Delegate(this.atColorIn_SelectedColor);
            this.atColorOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.atColorOut.EditValue = (object)"";
            this.atColorOut.IdColor = (object)null;
            this.atColorOut.Location = new Point(77, 15);
            this.atColorOut.Name = "atColorOut";
            this.atColorOut.NewColorFullName = (string)null;
            this.atColorOut.NewColorGroupName = (string)null;
            this.atColorOut.NewColorName = (string)null;
            this.atColorOut.NewShowColorFormatString = "{0}\\{1}";
            this.atColorOut.Properties.BorderStyle = BorderStyles.Simple;
            this.atColorOut.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.atColorOut.ShowColorMode = atColorPopUpContainer1.ShowColorModeType.GroupAndColor;
            this.atColorOut.Size = new Size(166, 20);
            this.atColorOut.TabIndex = 0;
            this.atColorOut.SelectedColor += new atColorPopUpContainer1.SelectedColor_Delegate(this.atColorOut_SelectedColor);
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
            this.label3.Location = new Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Внутренний";
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
            this.label4.Location = new Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Внешний";
            this.groupBoxSystems.Controls.Add((Control)this.cboFurnitureSystem);
            this.groupBoxSystems.Controls.Add((Control)this.cboProfilSystems);
            this.groupBoxSystems.Controls.Add((Control)this.label2);
            this.groupBoxSystems.Controls.Add((Control)this.label1);
            this.groupBoxSystems.Dock = DockStyle.Top;
            this.groupBoxSystems.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            this.groupBoxSystems.Location = new Point(0, 0);
            this.groupBoxSystems.Name = "groupBoxSystems";
            this.groupBoxSystems.Size = new Size(249, 70);
            this.groupBoxSystems.TabIndex = 0;
            this.groupBoxSystems.TabStop = false;
            this.groupBoxSystems.Text = "Системы";
            this.cboFurnitureSystem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cboFurnitureSystem.Location = new Point(77, 41);
            this.cboFurnitureSystem.Name = "cboFurnitureSystem";
            this.cboFurnitureSystem.Properties.BorderStyle = BorderStyles.Simple;
            this.cboFurnitureSystem.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboFurnitureSystem.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboFurnitureSystem.Size = new Size(166, 20);
            this.cboFurnitureSystem.TabIndex = 1;
            this.cboFurnitureSystem.Closed += new ClosedEventHandler(this.cboFurnitureSystem_Closed);
            this.cboProfilSystems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cboProfilSystems.Location = new Point(77, 15);
            this.cboProfilSystems.Name = "cboProfilSystems";
            this.cboProfilSystems.Properties.BorderStyle = BorderStyles.Simple;
            this.cboProfilSystems.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboProfilSystems.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboProfilSystems.Size = new Size(166, 20);
            this.cboProfilSystems.TabIndex = 0;
            this.cboProfilSystems.Closed += new ClosedEventHandler(this.cboProfilSystems_Closed);
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
            this.label2.Location = new Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фурнитура";
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
            this.label1.Location = new Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Профиль";
            this.atButtonsPanel1.AcceptButton = atButtonsPanel.bpButtons.Save;
            this.atButtonsPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.atButtonsPanel1.CancelButton = atButtonsPanel.bpButtons.Cancel;
            this.atButtonsPanel1.CancelButtonText = "";
            this.atButtonsPanel1.CancelButtonUseCancelSelect = true;
            this.atButtonsPanel1.CancelButtonVisible = true;
            this.atButtonsPanel1.CloseButtonText = "";
            this.atButtonsPanel1.CloseButtonUseCancelSelect = false;
            this.atButtonsPanel1.CloseButtonVisible = false;
            this.atButtonsPanel1.DataMember = (string)null;
            this.atButtonsPanel1.DataSource = (DataSet)null;
            this.atButtonsPanel1.EnabledCancelButton = true;
            this.atButtonsPanel1.EnabledCloseButton = true;
            this.atButtonsPanel1.EnabledPrintButton = true;
            this.atButtonsPanel1.EnabledRefreshButton = true;
            this.atButtonsPanel1.EnabledSaveButton = true;
            this.atButtonsPanel1.EnabledScriptButton = true;
            this.atButtonsPanel1.IdDocAppearance = 0;
            this.atButtonsPanel1.Location = new Point(0, 376);
            this.atButtonsPanel1.Name = "atButtonsPanel1";
            this.atButtonsPanel1.PrintButtonText = "";
            this.atButtonsPanel1.PrintButtonVisible = false;
            this.atButtonsPanel1.ProcessedIsDialog = true;
            this.atButtonsPanel1.RefreshButtonText = "Обновить";
            this.atButtonsPanel1.RefreshButtonUseSelectItem = true;
            this.atButtonsPanel1.RefreshButtonVisible = true;
            this.atButtonsPanel1.SaveButtonText = "Выбрать";
            this.atButtonsPanel1.SaveButtonUseSelectItem = true;
            this.atButtonsPanel1.SaveButtonVisible = true;
            this.atButtonsPanel1.ScriptButtonText = "";
            this.atButtonsPanel1.ScriptButtonVisible = false;
            this.atButtonsPanel1.Size = new Size(872, 33);
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
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlTemplate);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeListTemplateGroup);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.Controls.Add((Control)this.dockPanelButtons);
            this.Controls.Add((Control)this.dockPanelParam);
            this.Name = "TemplateForm";
            this.Size = new Size(872, 409);
            this.Text = "Шаблоны изделий";
            this.MenuItem.ResumeLayout(false);
            this.treeListTemplateGroup.EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.ds.EndInit();
            this.gridControlTemplate.EndInit();
            this.cardViewTemplate.EndInit();
            this.repositoryItemPictureEdit1.EndInit();
            this.MenuItemOpen.ResumeLayout(false);
            this.barAndDockingController1.EndInit();
            this.dockManager1.EndInit();
            this.dockPanelButtons.ResumeLayout(false);
            this.dockPanelParam.ResumeLayout(false);
            this.dockPanel4_Container.ResumeLayout(false);
            this.gridControlParam.EndInit();
            this.gridViewParam.EndInit();
            this.cboStrValue1.EndInit();
            this.cboStrValue2.EndInit();
            this.cboNumericValue.EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.atColorIn.Properties.EndInit();
            this.atColorIn.EndInit();
            this.atColorOut.Properties.EndInit();
            this.atColorOut.EndInit();
            this.groupBoxSystems.ResumeLayout(false);
            this.groupBoxSystems.PerformLayout();
            this.cboFurnitureSystem.Properties.EndInit();
            this.cboProfilSystems.Properties.EndInit();
            this.atButtonsPanel1.EndInit();
            this.ResumeLayout(false);
        }

        private void MenuGroup_Opening(object sender, CancelEventArgs e)
        {
            this.ApplyGrants();
        }

        private void MenuItem_Opening(object sender, CancelEventArgs e)
        {
            this.ApplyGrants();
        }

        private void cardViewTemplate_RowCountChanged(object sender, EventArgs e)
        {
        }

        private void template_templateRowChanging(object sender, ds_template.templateRowChangeEvent e)
        {
        }

        private void template_templateRowChanged(object sender, ds_template.templateRowChangeEvent e)
        {
        }

        private void TemplateForm_Shown(object sender, EventArgs e)
        {
            AtTreeList.SelectNode(this.treeListTemplateGroup, "idtemplategroup", Atechnology.ecad.Settings.SavedValues.idtemplategroup);
            AtGrid.SelectRow(this.gridControlTemplate, "idtemplate", (object)Atechnology.ecad.Settings.SavedValues.idtemplate, true);
            if (this.Is_Dialog)
            {
                this.treeListTemplateGroup.ContextMenuStrip = (ContextMenuStrip)null;
                this.gridControlTemplate.ContextMenuStrip = (ContextMenuStrip)null;
                this.gridControlParam.ContextMenuStrip = (ContextMenuStrip)null;
                this.cardViewTemplate.OptionsBehavior.Editable = false;
                this.gridViewParam.OptionsBehavior.Editable = false;
                this.dockPanelParam.Visibility = DockVisibility.Hidden;
            }
            else
                this.dockPanelParam.Visibility = DockVisibility.Visible;
            this.dockPanelButtons.SendToBack();
            this.atButtonsPanel1.BringToFront();
            this.atButtonsPanel1.Top = this.Height - this.atButtonsPanel1.Height;
            this.atButtonsPanel1.Width = this.Width;
            this.coltemplatetype.FilterInfo = new ColumnFilterInfo("templatetype is null or templatetype = 1 or templatetype = 2");
        }

        private void TemplateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.winDrawList.Count != 0)
            {
                foreach (AtUserControl atUserControl in MdiManager.tabs)
                {
                    if (atUserControl.Text.Contains("Шаблон") && atUserControl != this)
                    {
                        int num = (int)MessageBox.Show("Закрытие невозможно!\nЕсть редактируемые шаблоны!", "Закрытие формы шаблонов", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        e.Cancel = true;
                        return;
                    }
                }
            }
            if (AtDataSet.IsModifDataSet((DataSet)this.ds))
            {
                switch (MessageBox.Show("Данные были изменены!\nСохранить данные?", "Закрытие формы шаблонов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        this.SaveToBase();
                        break;
                }
            }
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlTemplate);
            if (dataRow != null)
                Atechnology.ecad.Settings.SavedValues.idtemplate = Useful.GetInt32(dataRow["idtemplate"]);
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListTemplateGroup);
            if (selectedNode == null)
                return;
            Atechnology.ecad.Settings.SavedValues.idtemplategroup = Useful.GetInt32(selectedNode["idtemplategroup"]);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 27)
            {
                this.Cursor = Cursors.Default;
                this.DocClass.CancelMove();
            }
            base.OnKeyPress(e);
        }

        private void treeListTemplateGroup_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.disableEvent)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListTemplateGroup);
            if (selectedNode == null)
                return;
            this.disableEvent = true;
            this.DocClass.MoveGroupMethod(selectedNode);
            this.DocClass.MoveItemToGroup(selectedNode);
            this.Cursor = Cursors.Default;
            this.disableEvent = false;
            this.coltemplatetype.FilterInfo = new ColumnFilterInfo("templatetype is null or templatetype = 1 or templatetype = 2");
        }

        private void cardViewTemplate_DoubleClick(object sender, EventArgs e)
        {
            if (this.Is_Dialog)
            {
                this.SelectItem();
            }
            else
            {
                if (!Grant.Dics.TemplateGrants.TemplatesEdit)
                    return;
                this.MenuItemEdit_Click((object)null, (EventArgs)null);
            }
        }

        private void cardViewTemplate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlTemplate);
            if (selectedDataRows == null || selectedDataRows.Length == 0 || selectedDataRows[0] == null)
            {
                this.dockPanelParam.Enabled = false;
                this.cboProfilSystems.Text = "";
                this.cboFurnitureSystem.Text = "";
                this.atColorOut.IdColor = (object)0;
                this.atColorIn.IdColor = (object)0;
            }
            else
            {
                if (Grant.Dics.TemplateGrants.TemplatesEdit)
                {
                    this.cboFurnitureSystem.Enabled = true;
                    this.cboProfilSystems.Enabled = true;
                    this.atColorIn.Enabled = true;
                    this.atColorOut.Enabled = true;
                    this.gridViewParam.OptionsBehavior.Editable = true;
                    if (selectedDataRows[0].Table.Columns.Contains("templatetype"))
                    {
                        if (!dbconn.IsValueDbNullOrNull(selectedDataRows[0]["templatetype"]) && (int)selectedDataRows[0]["templatetype"] == 1)
                            this.dockPanelParam.Enabled = false;
                        else
                            this.dockPanelParam.Enabled = true;
                    }
                    else
                        this.dockPanelParam.Enabled = true;
                }
                else
                {
                    this.cboFurnitureSystem.Enabled = false;
                    this.cboProfilSystems.Enabled = false;
                    this.atColorIn.Enabled = false;
                    this.atColorOut.Enabled = false;
                    this.gridViewParam.OptionsBehavior.Editable = false;
                }
                string str1 = selectedDataRows[0]["profilesystem_name"].ToString();
                foreach (ds_template.templateRow templateRow in selectedDataRows)
                {
                    if (templateRow != null && templateRow["profilesystem_name"].ToString() != str1)
                    {
                        str1 = "";
                        break;
                    }
                }
                string str2 = selectedDataRows[0]["furnituresystem_name"].ToString();
                foreach (ds_template.templateRow templateRow in selectedDataRows)
                {
                    if (templateRow != null && templateRow["furnituresystem_name"].ToString() != str2)
                    {
                        str2 = "";
                        break;
                    }
                }
                int num1 = Useful.GetInt32(selectedDataRows[0]["idcolor1"]);
                foreach (ds_template.templateRow templateRow in selectedDataRows)
                {
                    if (templateRow != null && num1 != Useful.GetInt32(templateRow["idcolor1"]))
                    {
                        num1 = 0;
                        break;
                    }
                }
                int num2 = Useful.GetInt32(selectedDataRows[0]["idcolor2"]);
                foreach (ds_template.templateRow templateRow in selectedDataRows)
                {
                    if (templateRow != null && num2 != Useful.GetInt32(templateRow["idcolor2"]))
                    {
                        num2 = 0;
                        break;
                    }
                }
                this.cboProfilSystems.Text = str1;
                this.cboFurnitureSystem.Text = str2;
                this.atColorOut.IdColor = (object)num1;
                this.atColorIn.IdColor = (object)num2;
            }
        }

        private void gridViewParam_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ds_template.templateparamRow templateparamRow = (ds_template.templateparamRow)AtGrid.getDataRow((Control)this.gridControlParam);
            if (templateparamRow == null)
                return;
            this.cboStrValue1.Items.Clear();
            this.cboStrValue2.Items.Clear();
            this.cboNumericValue.Items.Clear();
            ds_template.modelparamRow modelparamRow = templateparamRow.modelparamRow;
            if (modelparamRow == null)
            {
                this.SetCboStyle();
            }
            else
            {
                if (modelparamRow.onlyfromlist)
                {
                    ds_template.modelparamvalueRow[] modelparamvalueRowArray = modelparamRow.GetmodelparamvalueRows();
                    if (modelparamvalueRowArray != null && modelparamvalueRowArray.Length != 0)
                    {
                        foreach (ds_template.modelparamvalueRow modelparamvalueRow in modelparamvalueRowArray)
                        {
                            if (modelparamvalueRow.onlystr && modelparamvalueRow.strvalue != "")
                                this.cboStrValue1.Items.Add((object)modelparamvalueRow.strvalue);
                            if (modelparamvalueRow.onlystr2 && modelparamvalueRow.strvalue2 != "")
                                this.cboStrValue2.Items.Add((object)modelparamvalueRow.strvalue2);
                            if (modelparamvalueRow.onlyint && !modelparamvalueRow.IsintvalueNull())
                                this.cboNumericValue.Items.Add((object)modelparamvalueRow.intvalue);
                        }
                    }
                }
                this.SetCboStyle();
            }
        }

        public override void LoadFromBase()
        {
            using (AtUserControl.WithUIBlock)
            {
                using (new StatusImageProgressClass("Идёт загрузка шаблонов.", "Пожалуйста подождите...", true))
                {
                    this.ds.Load(TemplateType.Construction, !this.Is_Dialog);
                    this.cboProfilSystems.Properties.Items.Clear();
                    foreach (ProfileSystem profileSystem in SettingsLoad.currentSettings.ProfileSystemList)
                        this.cboProfilSystems.Properties.Items.Add((object)profileSystem.Name);
                    this.cboFurnitureSystem.Properties.Items.Clear();
                    foreach (FurnitureSystem furnitureSystem in SettingsLoad.currentSettings.FurnitureSystemList)
                        this.cboFurnitureSystem.Properties.Items.Add((object)furnitureSystem.Name);
                }
            }
        }

        public override bool SaveToBase()
        {
            using (AtUserControl.WithUIBlock)
            {
                using (new StatusImageProgressClass("Идёт сохраненение шаблонов.", "Пожалуйста подождите...", true))
                    return this.ds.Save();
            }
        }

        private void mnuRenameGroup_Click(object sender, EventArgs e)
        {
            this.DocClass.EditGroup(AtTreeList.GetSelectedNode(this.treeListTemplateGroup));
        }

        private void mnuAddRootGroupe_Click(object sender, EventArgs e)
        {
            this.DocClass.AddTemplateGroup((DataRow)null, TemplateType.Construction);
        }

        private void MenuGroupAddChild_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListTemplateGroup);
            if (selectedNode == null)
                return;
            this.DocClass.AddTemplateGroup(selectedNode, TemplateType.Construction);
        }

        private void MenuGroupRemove_Click(object sender, EventArgs e)
        {
            this.DocClass.RemoveGroup(AtTreeList.GetSelectedNode(this.treeListTemplateGroup));
        }

        private void MenuGroupSetMain_Click(object sender, EventArgs e)
        {
            this.DocClass.SetGroupMain(AtTreeList.GetSelectedNode(this.treeListTemplateGroup));
        }

        private void MenuGroupMoveToGroup_Click(object sender, EventArgs e)
        {
            if (!this.DocClass.SetMoveGroup(AtTreeList.GetSelectedNode(this.treeListTemplateGroup)))
                return;
            this.Cursor = Cursors.Hand;
        }

        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            this.DocClass.AddAndEditConstruction(this.cardViewTemplate.GetDataRow(this.cardViewTemplate.FocusedRowHandle), (DataRow)null);
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            this.DocClass.AddAndEditConstruction((DataRow)null, AtTreeList.GetSelectedNode(this.treeListTemplateGroup));
        }

        private void MenuItemDoublicate_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlTemplate);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            List<DataRow> list = new List<DataRow>();
            bool flag = false;
            foreach (DataRow dataRow in selectedDataRows)
            {
                if (dataRow["templatetype"] == DBNull.Value || dataRow["templatetype"] == null)
                    list.Add(dataRow);
                else
                    flag = true;
            }
            if (flag)
            {
                int num = (int)MessageBox.Show(string.Format("В текущей версии winDraw невозможно дублировать конструкции.{0}Будут продублированы только изделия.", (object)Environment.NewLine), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.DocClass.Doublicate(list.ToArray());
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlTemplate);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            foreach (DataRow dataRow1 in selectedDataRows)
            {
                if (dataRow1["templatetype"] != null && dataRow1["templatetype"] != DBNull.Value && (int)dataRow1["templatetype"] == 1)
                {
                    foreach (DataRow dataRow2 in this.ds.template.Select("idparent = " + dataRow1["idtemplate"]))
                        dataRow2.Delete();
                }
                dataRow1.Delete();
            }
        }

        private void MenuItemMoveToGroup_Click(object sender, EventArgs e)
        {
            if (!this.DocClass.SetMoveItemToGroup(AtGrid.getSelectedDataRows((Control)this.gridControlTemplate)))
                return;
            this.Cursor = Cursors.Hand;
        }

        private void MenuItemSelectTemplate_Click(object sender, EventArgs e)
        {
            this.SelectItem();
        }

        private void MenuItemRecalc_Click(object sender, EventArgs e)
        {
            this.DocClass.Recalc(AtGrid.getSelectedDataRows((Control)this.gridControlTemplate));
        }

        public override bool SelectItem()
        {
            this.Result = (ds_template.templateRow)AtGrid.getDataRow((Control)this.gridControlTemplate);
            if (this.Result == null)
                return false;
            this.DialogResult = DialogResult.OK;
            this.Close();
            return true;
        }

        public void ApplyGrants()
        {
            this.MenuItemAdd.Enabled = Grant.Dics.TemplateGrants.TemplatesAdd;
            this.MenuItemEdit.Enabled = Grant.Dics.TemplateGrants.TemplatesEdit;
            this.MenuItemDoublicate.Enabled = Grant.Dics.TemplateGrants.TemplatesAdd;
            this.MenuItemMoveToGroup.Enabled = Grant.Dics.TemplateGrants.TemplatesEdit;
            this.MenuItemRemove.Enabled = Grant.Dics.TemplateGrants.TemplatesRemove;
            if (!Grant.Dics.TemplateGrants.TemplatesGroupEdit)
                this.treeListTemplateGroup.ContextMenuStrip = (ContextMenuStrip)null;
            if (Grant.Dics.TemplateGrants.TemplatesEdit)
                return;
            this.cardViewTemplate.OptionsBehavior.Editable = Grant.Dics.TemplateGrants.TemplatesEdit;
            this.cardViewTemplate.OptionsBehavior.Editable = Grant.Dics.TemplateGrants.TemplatesEdit;
        }

        public void SetCboStyle()
        {
            if (this.cboStrValue1.Items.Count == 0)
                this.cboStrValue1.TextEditStyle = TextEditStyles.Standard;
            else
                this.cboStrValue1.TextEditStyle = TextEditStyles.DisableTextEditor;
            if (this.cboStrValue2.Items.Count == 0)
                this.cboStrValue2.TextEditStyle = TextEditStyles.Standard;
            else
                this.cboStrValue2.TextEditStyle = TextEditStyles.DisableTextEditor;
            if (this.cboNumericValue.Items.Count == 0)
                this.cboNumericValue.TextEditStyle = TextEditStyles.Standard;
            else
                this.cboNumericValue.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboStrValue1.Buttons[0].Visible = this.cboStrValue1.Items.Count != 0;
            this.cboStrValue2.Buttons[0].Visible = this.cboStrValue2.Items.Count != 0;
            this.cboNumericValue.Buttons[0].Visible = this.cboNumericValue.Items.Count != 0;
        }

        private void cboProfilSystems_Closed(object sender, ClosedEventArgs e)
        {
            this.DocClass.ChangeSystemsPosition(AtGrid.getSelectedDataRows((Control)this.gridControlTemplate), this.cboProfilSystems.Text, this.cboFurnitureSystem.Text);
        }

        private void cboFurnitureSystem_Closed(object sender, ClosedEventArgs e)
        {
            this.DocClass.ChangeSystemsPosition(AtGrid.getSelectedDataRows((Control)this.gridControlTemplate), this.cboProfilSystems.Text, this.cboFurnitureSystem.Text);
        }

        private void atColorOut_SelectedColor(DataRow drColor)
        {
            this.DocClass.ChangeColor(AtGrid.getSelectedDataRows((Control)this.gridControlTemplate), Useful.GetInt32(this.atColorOut.IdColor), Useful.GetInt32(this.atColorIn.IdColor));
        }

        private void atColorIn_SelectedColor(DataRow drColor)
        {
            this.DocClass.ChangeColor(AtGrid.getSelectedDataRows((Control)this.gridControlTemplate), Useful.GetInt32(this.atColorOut.IdColor), Useful.GetInt32(this.atColorIn.IdColor));
        }
    }
}
