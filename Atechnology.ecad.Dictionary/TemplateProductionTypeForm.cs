// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.TemplateProductionTypeForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.ecad;
using Atechnology.ecad.Dictionary.Classes;
using Atechnology.ecad.Dictionary.DataSets;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public enum TypeAnswer
    {
        Строка,
        Текст,
        Число,
        Дата,
        Да_нет,
        Один_из,
        Несколько_из,
        Один_из_запрос,
        Несколько_из_запрос,
    }

    public class TemplateProductionTypeForm : AtUserControl
    {
        private IContainer components;
        private SplitterControl splitterControl1;
        private TreeList treeListTemplateGroup;
        private TreeListColumn coltemplategroup;
        private ImageList imageList1;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripMenuItem MenuItemDoublicate;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemRemove;
        private ContextMenuStrip MenuGroup;
        private ToolStripMenuItem MenuGroupeAddMain;
        private ToolStripMenuItem MenuGroupeAddChild;
        private ToolStripMenuItem MenuGroupeRename;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MenuGroupeRemove;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MenuGroupSetMain;
        private ToolStripMenuItem MenuGroupMoveToGroup;
        private atButtonsPanel atButtonsPanel1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem MenuItemMoveToGroup;
        private GridControl gridControlTemplate;
        private RepositoryItemPictureEdit PictureEdit;
        private ds_template ds;
        private GridView gridViewTemplate;
        private GridColumn colpicture;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colidtemplate;
        private GridView gridViewTemplateParam;
        private GridColumn colidtemplateparam;
        private GridColumn colmodelparam_name;
        private GridColumn colintvalue;
        private RepositoryItemComboBox cboNumericValue;
        private GridColumn colstrvalue;
        private RepositoryItemComboBox cboStrValue1;
        private GridColumn colstrvalue2;
        private RepositoryItemComboBox cboStrValue2;
        private GridColumn colproductiontype_name;
        private bool disableEvent;
        public ds_template.templateRow Result;
        private TemplateClass DocClass;

        public TemplateProductionTypeForm(bool isDialog)
        {
            this.InitializeComponent();
            this.Is_Dialog = isDialog;
            this.DocClass = new TemplateClass(this.ds, TemplateType.ProductionType, false);
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.TemplateForm_FormClosing);
            this.Shown += new Shown(this.TemplateForm_Shown);
            this.gridViewTemplate.DoubleClick += new EventHandler(this.gridViewTemplate_DoubleClick);
            this.gridViewTemplateParam.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridViewTemplateParam_FocusedRowChanged);
            this.gridViewTemplateParam.GotFocus += new EventHandler(this.gridViewTemplateParam_GotFocus);
            this.treeListTemplateGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListTemplateGroup_FocusedNodeChanged);
            this.MenuGroupSetMain.Click += new EventHandler(this.MenuGroupSetMain_Click);
            this.MenuGroupMoveToGroup.Click += new EventHandler(this.MenuGroupMoveToGroup_Click);
            this.atButtonsPanel1.Print = new atButtonsPanel.PrintDelegate(this.RefreshParameters);
            this.ApplyGrants();
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TemplateProductionTypeForm));
            this.gridViewTemplateParam = new GridView();
            this.colidtemplateparam = new GridColumn();
            this.colmodelparam_name = new GridColumn();
            this.colintvalue = new GridColumn();
            this.cboNumericValue = new RepositoryItemComboBox();
            this.colstrvalue = new GridColumn();
            this.cboStrValue1 = new RepositoryItemComboBox();
            this.colstrvalue2 = new GridColumn();
            this.cboStrValue2 = new RepositoryItemComboBox();
            this.gridControlTemplate = new GridControl();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.MenuItemAdd = new ToolStripMenuItem();
            this.MenuItemDoublicate = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.MenuItemMoveToGroup = new ToolStripMenuItem();
            this.ds = new ds_template();
            this.gridViewTemplate = new GridView();
            this.colidtemplate = new GridColumn();
            this.colproductiontype_name = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colpicture = new GridColumn();
            this.PictureEdit = new RepositoryItemPictureEdit();
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
            this.imageList1 = new ImageList(this.components);
            this.atButtonsPanel1 = new atButtonsPanel();
            this.gridViewTemplateParam.BeginInit();
            this.cboNumericValue.BeginInit();
            this.cboStrValue1.BeginInit();
            this.cboStrValue2.BeginInit();
            this.gridControlTemplate.BeginInit();
            this.MenuItem.SuspendLayout();
            this.ds.BeginInit();
            this.gridViewTemplate.BeginInit();
            this.PictureEdit.BeginInit();
            this.treeListTemplateGroup.BeginInit();
            this.MenuGroup.SuspendLayout();
            this.atButtonsPanel1.BeginInit();
            this.SuspendLayout();
            this.gridViewTemplateParam.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.FocusedRow.ForeColor = SystemColors.ControlText;
            this.gridViewTemplateParam.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewTemplateParam.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewTemplateParam.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewTemplateParam.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewTemplateParam.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.HideSelectionRow.ForeColor = SystemColors.ControlText;
            this.gridViewTemplateParam.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewTemplateParam.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewTemplateParam.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewTemplateParam.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplateParam.Appearance.SelectedRow.ForeColor = SystemColors.ControlText;
            this.gridViewTemplateParam.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewTemplateParam.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewTemplateParam.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewTemplateParam.Columns.AddRange(new GridColumn[5]
      {
        this.colidtemplateparam,
        this.colmodelparam_name,
        this.colintvalue,
        this.colstrvalue,
        this.colstrvalue2
      });
            this.gridViewTemplateParam.GridControl = this.gridControlTemplate;
            this.gridViewTemplateParam.GroupPanelText = "Панель группировки";
            this.gridViewTemplateParam.Name = "gridViewTemplateParam";
            this.gridViewTemplateParam.OptionsSelection.MultiSelect = true;
            this.gridViewTemplateParam.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewTemplateParam.OptionsView.ShowIndicator = false;
            this.colidtemplateparam.Caption = "#";
            this.colidtemplateparam.FieldName = "idtemplateparam";
            this.colidtemplateparam.Name = "colidtemplateparam";
            this.colidtemplateparam.OptionsColumn.AllowEdit = false;
            this.colidtemplateparam.Visible = true;
            this.colidtemplateparam.VisibleIndex = 0;
            this.colmodelparam_name.Caption = "Наименование";
            this.colmodelparam_name.FieldName = "modelparam_name";
            this.colmodelparam_name.Name = "colmodelparam_name";
            this.colmodelparam_name.OptionsColumn.AllowEdit = false;
            this.colmodelparam_name.Visible = true;
            this.colmodelparam_name.VisibleIndex = 1;
            this.colintvalue.Caption = "Число";
            this.colintvalue.ColumnEdit = (RepositoryItem)this.cboNumericValue;
            this.colintvalue.FieldName = "intvalue";
            this.colintvalue.Name = "colintvalue";
            this.colintvalue.Visible = true;
            this.colintvalue.VisibleIndex = 2;
            this.cboNumericValue.AutoHeight = false;
            this.cboNumericValue.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboNumericValue.Name = "cboNumericValue";
            this.colstrvalue.Caption = "Строка 1";
            this.colstrvalue.ColumnEdit = (RepositoryItem)this.cboStrValue1;
            this.colstrvalue.FieldName = "strvalue";
            this.colstrvalue.Name = "colstrvalue";
            this.colstrvalue.Visible = true;
            this.colstrvalue.VisibleIndex = 3;
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
            this.colstrvalue2.VisibleIndex = 4;
            this.cboStrValue2.AutoHeight = false;
            this.cboStrValue2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboStrValue2.Name = "cboStrValue2";
            this.gridControlTemplate.ContextMenuStrip = this.MenuItem;
            this.gridControlTemplate.DataMember = "templategroup.FK_template_templategroup";
            this.gridControlTemplate.DataSource = (object)this.ds;
            this.gridControlTemplate.Dock = DockStyle.Fill;
            this.gridControlTemplate.EmbeddedNavigator.Name = "";
            this.gridControlTemplate.FormsUseDefaultLookAndFeel = false;
            gridLevelNode.LevelTemplate = (BaseView)this.gridViewTemplateParam;
            gridLevelNode.RelationName = "FK_template_templateparam";
            this.gridControlTemplate.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
            this.gridControlTemplate.Location = new Point(203, 0);
            this.gridControlTemplate.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlTemplate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlTemplate.MainView = (BaseView)this.gridViewTemplate;
            this.gridControlTemplate.Name = "gridControlTemplate";
            this.gridControlTemplate.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.PictureEdit,
        (RepositoryItem) this.cboStrValue2,
        (RepositoryItem) this.cboStrValue1,
        (RepositoryItem) this.cboNumericValue
      });
            this.gridControlTemplate.Size = new Size(669, 361);
            this.gridControlTemplate.TabIndex = 0;
            this.gridControlTemplate.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridViewTemplate,
        (BaseView) this.gridViewTemplateParam
      });
            this.MenuItem.Items.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.MenuItemDoublicate,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemRemove,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.MenuItemMoveToGroup
      });
            this.MenuItem.Name = "contextMenuStrip1";
            this.MenuItem.Size = new Size(252, 104);
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAdd.Size = new Size(251, 22);
            this.MenuItemAdd.Text = "Добавить шаблон";
            this.MenuItemAdd.Click += new EventHandler(this.MenuItemAdd_Click);
            this.MenuItemDoublicate.Name = "MenuItemDoublicate";
            this.MenuItemDoublicate.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.MenuItemDoublicate.Size = new Size(251, 22);
            this.MenuItemDoublicate.Text = "Дублировать шаблон";
            this.MenuItemDoublicate.Click += new EventHandler(this.MenuItemDoublicate_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(248, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(251, 22);
            this.MenuItemRemove.Text = "Удалить шаблон";
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(248, 6);
            this.MenuItemMoveToGroup.Name = "MenuItemMoveToGroup";
            this.MenuItemMoveToGroup.ShortcutKeys = Keys.F6;
            this.MenuItemMoveToGroup.Size = new Size(251, 22);
            this.MenuItemMoveToGroup.Text = "Переместить в группу";
            this.MenuItemMoveToGroup.Click += new EventHandler(this.MenuItemMoveToGroup_Click);
            this.ds.DataSetName = "ds_template";
            this.ds.EnforceConstraints = false;
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridViewTemplate.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.FocusedRow.ForeColor = SystemColors.ControlText;
            this.gridViewTemplate.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewTemplate.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewTemplate.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewTemplate.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewTemplate.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.HideSelectionRow.ForeColor = SystemColors.ControlText;
            this.gridViewTemplate.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewTemplate.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewTemplate.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewTemplate.Appearance.Row.ForeColor = SystemColors.ControlText;
            this.gridViewTemplate.Appearance.Row.Options.UseForeColor = true;
            this.gridViewTemplate.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTemplate.Appearance.SelectedRow.ForeColor = SystemColors.ControlText;
            this.gridViewTemplate.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewTemplate.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewTemplate.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewTemplate.BorderStyle = BorderStyles.Simple;
            this.gridViewTemplate.Columns.AddRange(new GridColumn[5]
      {
        this.colidtemplate,
        this.colproductiontype_name,
        this.colname,
        this.colcomment,
        this.colpicture
      });
            this.gridViewTemplate.GridControl = this.gridControlTemplate;
            this.gridViewTemplate.GroupPanelText = "Панель группировки";
            this.gridViewTemplate.Name = "gridViewTemplate";
            this.gridViewTemplate.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewTemplate.OptionsDetail.ShowDetailTabs = false;
            this.gridViewTemplate.OptionsLayout.StoreVisualOptions = false;
            this.gridViewTemplate.OptionsSelection.MultiSelect = true;
            this.gridViewTemplate.OptionsView.RowAutoHeight = true;
            this.gridViewTemplate.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewTemplate.OptionsView.ShowIndicator = false;
            this.colidtemplate.AppearanceHeader.ForeColor = SystemColors.ControlText;
            this.colidtemplate.AppearanceHeader.Options.UseForeColor = true;
            this.colidtemplate.Caption = "#";
            this.colidtemplate.FieldName = "idtemplate";
            this.colidtemplate.Name = "colidtemplate";
            this.colidtemplate.OptionsColumn.AllowEdit = false;
            this.colidtemplate.Visible = true;
            this.colidtemplate.VisibleIndex = 0;
            this.colidtemplate.Width = 53;
            this.colproductiontype_name.AppearanceCell.Options.UseTextOptions = true;
            this.colproductiontype_name.AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap;
            this.colproductiontype_name.Caption = "Тип продукции";
            this.colproductiontype_name.FieldName = "productiontype_name";
            this.colproductiontype_name.Name = "colproductiontype_name";
            this.colproductiontype_name.OptionsColumn.AllowEdit = false;
            this.colproductiontype_name.Visible = true;
            this.colproductiontype_name.VisibleIndex = 1;
            this.colname.AppearanceCell.Options.UseTextOptions = true;
            this.colname.AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap;
            this.colname.AppearanceHeader.ForeColor = SystemColors.ControlText;
            this.colname.AppearanceHeader.Options.UseForeColor = true;
            this.colname.Caption = "Наименование";
            this.colname.CustomizationCaption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 203;
            this.colcomment.AppearanceCell.Options.UseTextOptions = true;
            this.colcomment.AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap;
            this.colcomment.AppearanceHeader.ForeColor = SystemColors.ControlText;
            this.colcomment.AppearanceHeader.Options.UseForeColor = true;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 3;
            this.colcomment.Width = 203;
            this.colpicture.AppearanceHeader.ForeColor = SystemColors.ControlText;
            this.colpicture.AppearanceHeader.Options.UseForeColor = true;
            this.colpicture.Caption = "Картинка";
            this.colpicture.ColumnEdit = (RepositoryItem)this.PictureEdit;
            this.colpicture.FieldName = "picture";
            this.colpicture.Name = "colpicture";
            this.colpicture.OptionsColumn.AllowEdit = false;
            this.colpicture.OptionsColumn.ReadOnly = true;
            this.colpicture.Visible = true;
            this.colpicture.VisibleIndex = 4;
            this.colpicture.Width = 208;
            this.PictureEdit.Name = "PictureEdit";
            this.PictureEdit.ReadOnly = true;
            this.PictureEdit.ShowMenu = false;
            this.PictureEdit.SizeMode = PictureSizeMode.Zoom;
            this.splitterControl1.Location = new Point(197, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 361);
            this.splitterControl1.TabIndex = 3;
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
            this.treeListTemplateGroup.Size = new Size(197, 361);
            this.treeListTemplateGroup.TabIndex = 1;
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
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "VSFolder_closed.bmp");
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
            this.atButtonsPanel1.Location = new Point(0, 361);
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
            this.atButtonsPanel1.TabIndex = 2;
            this.atButtonsPanel1.TextCancelButton = "Отменить";
            this.atButtonsPanel1.TextCloseButton = "Закрыть";
            this.atButtonsPanel1.TextPrintButton = "Обновить параметры";
            this.atButtonsPanel1.TextRefreshButton = "Обновить";
            this.atButtonsPanel1.TextSaveButton = "Применить";
            this.atButtonsPanel1.TextScriptButton = "Скрипты...";
            this.atButtonsPanel1.VisibleCancelButton = true;
            this.atButtonsPanel1.VisibleCloseButton = true;
            this.atButtonsPanel1.VisiblePrintButton = true;
            this.atButtonsPanel1.VisibleRefreshButton = false;
            this.atButtonsPanel1.VisibleSaveButton = true;
            this.atButtonsPanel1.VisibleScriptButton = false;
            this.atButtonsPanel1.WidthPrintButton = 130;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlTemplate);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeListTemplateGroup);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.Name = "TemplateProductionTypeForm";
            this.Size = new Size(872, 394);
            this.Text = "Шаблоны продукции";
            this.gridViewTemplateParam.EndInit();
            this.cboNumericValue.EndInit();
            this.cboStrValue1.EndInit();
            this.cboStrValue2.EndInit();
            this.gridControlTemplate.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.ds.EndInit();
            this.gridViewTemplate.EndInit();
            this.PictureEdit.EndInit();
            this.treeListTemplateGroup.EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.atButtonsPanel1.EndInit();
            this.ResumeLayout(false);
        }

        private void TemplateForm_Shown(object sender, EventArgs e)
        {
            AtTreeList.SelectNode(this.treeListTemplateGroup, "idtemplategroup", Settings.SavedValues.IdTemplateProductionGroup);
            AtGrid.SelectRow(this.gridControlTemplate, "idtemplate", (object)Settings.SavedValues.IdTemplateProduction, true);
            if (this.Is_Dialog)
            {
                this.treeListTemplateGroup.ContextMenuStrip = (ContextMenuStrip)null;
                this.gridControlTemplate.ContextMenuStrip = (ContextMenuStrip)null;
                this.gridViewTemplate.OptionsBehavior.Editable = false;
                this.gridViewTemplateParam.OptionsBehavior.Editable = false;
                this.gridControlTemplate.ViewCollection.Remove((BaseView)this.gridViewTemplateParam);
                this.gridControlTemplate.LevelTree.Nodes.Clear();
                this.gridViewTemplate.OptionsView.ShowDetailButtons = false;
            }
            else
                this.gridViewTemplate.OptionsView.ShowDetailButtons = true;
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
        }

        private void gridViewTemplate_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.SelectItem();
        }

        private void TemplateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                Settings.SavedValues.IdTemplateProduction = Useful.GetInt32(dataRow["idtemplate"]);
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListTemplateGroup);
            if (selectedNode == null)
                return;
            Settings.SavedValues.IdTemplateProductionGroup = Useful.GetInt32(selectedNode["idtemplategroup"]);
        }

        private void gridViewTemplateParam_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            this.cboStrValue1.Items.Clear();
            this.cboStrValue2.Items.Clear();
            this.cboNumericValue.Items.Clear();
            try
            {
                DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlTemplate);
                if (!(dataRow is ds_template.templateparamRow))
                    return;
                ds_template.templateparamRow templateparamRow = (ds_template.templateparamRow)dataRow;
                if (templateparamRow == null)
                    return;
                ds_template.modelparamRow modelparamRow = templateparamRow.modelparamRow;
                if (modelparamRow == null || !modelparamRow.onlyfromlist)
                    return;
                ds_template.modelparamvalueRow[] modelparamvalueRowArray = modelparamRow.GetmodelparamvalueRows();
                if (modelparamvalueRowArray == null || modelparamvalueRowArray.Length == 0)
                    return;
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
            finally
            {
                this.SetCboStyle();
            }
        }

        private void gridViewTemplateParam_GotFocus(object sender, EventArgs e)
        {
            this.gridViewTemplateParam_FocusedRowChanged((object)null, (FocusedRowChangedEventArgs)null);
        }

        public override void LoadFromBase()
        {
            this.ds.Load(this.DocClass._TemplateType, !this.Is_Dialog);
        }

        public override bool SaveToBase()
        {
            return this.ds.Save();
        }

        private void mnuRenameGroup_Click(object sender, EventArgs e)
        {
            this.DocClass.EditGroup(AtTreeList.GetSelectedNode(this.treeListTemplateGroup));
        }

        private void mnuAddRootGroupe_Click(object sender, EventArgs e)
        {
            this.DocClass.AddTemplateGroup((DataRow)null, TemplateType.ProductionType);
        }

        private void MenuGroupAddChild_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListTemplateGroup);
            if (selectedNode == null)
                return;
            this.DocClass.AddTemplateGroup(selectedNode, TemplateType.ProductionType);
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

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            this.DocClass.AddProductionType(AtTreeList.GetSelectedNode(this.treeListTemplateGroup));
        }

        private void MenuItemDoublicate_Click(object sender, EventArgs e)
        {
            this.DocClass.Doublicate(AtGrid.getSelectedDataRows((Control)this.gridControlTemplate));
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlTemplate);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
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
            this.MenuItemDoublicate.Enabled = Grant.Dics.TemplateGrants.TemplatesAdd;
            this.MenuItemMoveToGroup.Enabled = Grant.Dics.TemplateGrants.TemplatesEdit;
            this.atButtonsPanel1.EnabledPrintButton = Grant.Dics.TemplateGrants.TemplatesEdit;
            this.MenuItemRemove.Enabled = Grant.Dics.TemplateGrants.TemplatesRemove;
            if (!Grant.Dics.TemplateGrants.TemplatesGroupEdit)
                this.treeListTemplateGroup.ContextMenuStrip = (ContextMenuStrip)null;
            if (Grant.Dics.TemplateGrants.TemplatesEdit)
                return;
            this.gridViewTemplate.OptionsBehavior.Editable = Grant.Dics.TemplateGrants.TemplatesEdit;
            this.gridViewTemplateParam.OptionsBehavior.Editable = Grant.Dics.TemplateGrants.TemplatesEdit;
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

        private void RefreshParameters()
        {
            this.DocClass.RefreshParameters(AtGrid.getSelectedDataRows((Control)this.gridControlTemplate));
        }
    }
}
