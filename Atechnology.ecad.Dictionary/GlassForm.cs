// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GlassForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.DataSets;
using Atechnology.ecad.Dictionary.windraw;
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
    public class GlassForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridControl gridControlGlass;
        private GridView gridViewGlass;
        private ds ds;
        private GridColumn colname;
        private GridColumn colmarking;
        private GridColumn colcomment;
        private GridColumn colglassgroup;
        private GridColumn col_color;
        private RepositoryItemColorEdit repositoryItemColorEdit1;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private GridColumn colramkaoffset;
        private GridColumn colnumpos;
        private GridColumn colthickness;
        private GridColumn colcamernost;
        private TreeList treeListGlassGroup;
        private TreeListColumn treeListColumn1;
        private SplitterControl splitterControl1;
        private ContextMenuStrip MenuGroup;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private TreeListColumn treeListColumn2;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private ImageList imageList1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItem8;
        private GridView gridViewGlassDetail;
        private GridColumn colgood_marking;
        private GridColumn colgood_name;
        private GridColumn coltyp_name;
        private GridColumn colcomment1;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItem10;
        private GridColumn colidglassgroup;
        private GridColumn colmarking2;
        private GridColumn colmarking3;
        private GridColumn colmarking4;
        private GridColumn colmarking5;
        private ToolStripMenuItem MenuItemMoveGroup;
        private ToolStripMenuItem MenuItemSetGroupMain;
        private GridColumn colfilltype_name;
        private RepositoryItemComboBox cboFillType;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MenuGroupSetType;
        public DataTable table_glass;
        public DataTable table_glassgroup;
        public DataTable table_glassdetail;
        public bool ChanginGroup;
        private DataRow MoveGroup;
        private DataRow[] MoveGlass;

        public GlassForm()
        {
            this.InitializeComponent();
            this.table_glass = this.ds.Tables["glass"];
            this.table_glassdetail = this.ds.Tables["glassdetail"];
            this.table_glassgroup = this.ds.Tables["glassgroup"];
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.GlassForm_FormClosing);
            this.repositoryItemComboBox1.Items.Add((object)"Стекло");
            this.repositoryItemComboBox1.Items.Add((object)"Рамка");
            this.treeListGlassGroup.KeyDown += new KeyEventHandler(this.treeList1_KeyDown);
            this.Shown += new Shown(this.GlassForm_Shown);
            this.treeListGlassGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.MenuItemMoveGroup.Click += new EventHandler(this.MenuItemMoveGroup_Click);
            this.MenuItemSetGroupMain.Click += new EventHandler(this.MenuItemSetGroupMain_Click);
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GlassForm));
            this.gridViewGlassDetail = new GridView();
            this.colgood_marking = new GridColumn();
            this.colgood_name = new GridColumn();
            this.coltyp_name = new GridColumn();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.colcomment1 = new GridColumn();
            this.gridControlGlass = new GridControl();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.toolStripMenuItem8 = new ToolStripMenuItem();
            this.toolStripMenuItem9 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.toolStripMenuItem10 = new ToolStripMenuItem();
            this.ds = new ds();
            this.gridViewGlass = new GridView();
            this.colname = new GridColumn();
            this.colmarking = new GridColumn();
            this.colcomment = new GridColumn();
            this.colglassgroup = new GridColumn();
            this.col_color = new GridColumn();
            this.repositoryItemColorEdit1 = new RepositoryItemColorEdit();
            this.colramkaoffset = new GridColumn();
            this.colnumpos = new GridColumn();
            this.colthickness = new GridColumn();
            this.colcamernost = new GridColumn();
            this.colidglassgroup = new GridColumn();
            this.colmarking2 = new GridColumn();
            this.colmarking3 = new GridColumn();
            this.colmarking4 = new GridColumn();
            this.colmarking5 = new GridColumn();
            this.colfilltype_name = new GridColumn();
            this.cboFillType = new RepositoryItemComboBox();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.treeListGlassGroup = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.treeListColumn2 = new TreeListColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.MenuGroup = new ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.toolStripMenuItem5 = new ToolStripMenuItem();
            this.toolStripMenuItem7 = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItem6 = new ToolStripMenuItem();
            this.MenuItemMoveGroup = new ToolStripMenuItem();
            this.MenuItemSetGroupMain = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.MenuGroupSetType = new ToolStripMenuItem();
            this.imageList1 = new ImageList(this.components);
            this.splitterControl1 = new SplitterControl();
            this.gridViewGlassDetail.BeginInit();
            this.repositoryItemComboBox1.BeginInit();
            this.gridControlGlass.BeginInit();
            this.MenuItem.SuspendLayout();
            this.ds.BeginInit();
            this.gridViewGlass.BeginInit();
            this.repositoryItemColorEdit1.BeginInit();
            this.cboFillType.BeginInit();
            this.panel1.SuspendLayout();
            this.treeListGlassGroup.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.MenuGroup.SuspendLayout();
            this.SuspendLayout();
            this.gridViewGlassDetail.BorderStyle = BorderStyles.Simple;
            this.gridViewGlassDetail.Columns.AddRange(new GridColumn[4]
      {
        this.colgood_marking,
        this.colgood_name,
        this.coltyp_name,
        this.colcomment1
      });
            this.gridViewGlassDetail.GridControl = this.gridControlGlass;
            this.gridViewGlassDetail.Name = "gridViewGlassDetail";
            this.gridViewGlassDetail.OptionsCustomization.AllowFilter = false;
            this.gridViewGlassDetail.OptionsCustomization.AllowGroup = false;
            this.gridViewGlassDetail.OptionsDetail.ShowDetailTabs = false;
            this.gridViewGlassDetail.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewGlassDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewGlassDetail.OptionsView.ShowIndicator = false;
            this.colgood_marking.Caption = "Артикул материала";
            this.colgood_marking.FieldName = "good_marking";
            this.colgood_marking.Name = "colgood_marking";
            this.colgood_marking.OptionsColumn.AllowEdit = false;
            this.colgood_marking.Visible = true;
            this.colgood_marking.VisibleIndex = 0;
            this.colgood_name.Caption = "Наименование материала";
            this.colgood_name.FieldName = "good_name";
            this.colgood_name.Name = "colgood_name";
            this.colgood_name.OptionsColumn.AllowEdit = false;
            this.colgood_name.Visible = true;
            this.colgood_name.VisibleIndex = 1;
            this.coltyp_name.Caption = "Тип";
            this.coltyp_name.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox1;
            this.coltyp_name.FieldName = "typ_name";
            this.coltyp_name.Name = "coltyp_name";
            this.coltyp_name.Visible = true;
            this.coltyp_name.VisibleIndex = 2;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colcomment1.Caption = "Комментарий";
            this.colcomment1.FieldName = "comment";
            this.colcomment1.Name = "colcomment1";
            this.colcomment1.Visible = true;
            this.colcomment1.VisibleIndex = 3;
            this.gridControlGlass.ContextMenuStrip = this.MenuItem;
            this.gridControlGlass.DataMember = "glassgroup.FK_glass_glassgroup";
            this.gridControlGlass.DataSource = (object)this.ds;
            this.gridControlGlass.Dock = DockStyle.Fill;
            this.gridControlGlass.EmbeddedNavigator.Name = "";
            this.gridControlGlass.FormsUseDefaultLookAndFeel = false;
            gridLevelNode.LevelTemplate = (BaseView)this.gridViewGlassDetail;
            gridLevelNode.RelationName = "FK_glassdetail_glass";
            this.gridControlGlass.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
            this.gridControlGlass.Location = new Point(188, 0);
            this.gridControlGlass.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlGlass.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlGlass.MainView = (BaseView)this.gridViewGlass;
            this.gridControlGlass.Name = "gridControlGlass";
            this.gridControlGlass.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemColorEdit1,
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.cboFillType
      });
            this.gridControlGlass.Size = new Size(682, 297);
            this.gridControlGlass.TabIndex = 3;
            this.gridControlGlass.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridViewGlass,
        (BaseView) this.gridViewGlassDetail
      });
            this.MenuItem.Items.AddRange(new ToolStripItem[9]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.toolStripMenuItem8,
        (ToolStripItem) this.toolStripMenuItem9,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem3,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.toolStripMenuItem10
      });
            this.MenuItem.Name = "contextMenuStrip1";
            this.MenuItem.Size = new Size(205, 154);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(204, 22);
            this.toolStripMenuItem1.Text = "Добавить заполнение";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(204, 22);
            this.toolStripMenuItem2.Text = "Дублировать заполнение";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(201, 6);
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new Size(204, 22);
            this.toolStripMenuItem8.Text = "Добавить материал";
            this.toolStripMenuItem8.Click += new EventHandler(this.toolStripMenuItem8_Click);
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new Size(204, 22);
            this.toolStripMenuItem9.Text = "Изменить материал";
            this.toolStripMenuItem9.Visible = false;
            this.toolStripMenuItem9.Click += new EventHandler(this.toolStripMenuItem9_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(201, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(204, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(201, 6);
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new Size(204, 22);
            this.toolStripMenuItem10.Text = "Смена группы...";
            this.toolStripMenuItem10.Click += new EventHandler(this.toolStripMenuItem10_Click);
            this.ds.DataSetName = "ds";
            this.ds.EnforceConstraints = false;
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridViewGlass.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewGlass.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewGlass.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewGlass.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewGlass.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewGlass.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewGlass.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewGlass.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewGlass.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewGlass.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGlass.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewGlass.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewGlass.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewGlass.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewGlass.BorderStyle = BorderStyles.Simple;
            this.gridViewGlass.Columns.AddRange(new GridColumn[15]
      {
        this.colname,
        this.colmarking,
        this.colcomment,
        this.colglassgroup,
        this.col_color,
        this.colramkaoffset,
        this.colnumpos,
        this.colthickness,
        this.colcamernost,
        this.colidglassgroup,
        this.colmarking2,
        this.colmarking3,
        this.colmarking4,
        this.colmarking5,
        this.colfilltype_name
      });
            this.gridViewGlass.GridControl = this.gridControlGlass;
            this.gridViewGlass.GroupPanelText = "Панель группировки";
            this.gridViewGlass.Name = "gridViewGlass";
            this.gridViewGlass.OptionsCustomization.AllowFilter = false;
            this.gridViewGlass.OptionsDetail.ShowDetailTabs = false;
            this.gridViewGlass.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewGlass.OptionsSelection.MultiSelect = true;
            this.gridViewGlass.OptionsView.ShowDetailButtons = false;
            this.gridViewGlass.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewGlass.OptionsView.ShowIndicator = false;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 92;
            this.colmarking.Caption = "Артикул";
            this.colmarking.FieldName = "marking";
            this.colmarking.Name = "colmarking";
            this.colmarking.Visible = true;
            this.colmarking.VisibleIndex = 1;
            this.colmarking.Width = 92;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 8;
            this.colcomment.Width = 122;
            this.colglassgroup.Caption = "Группа";
            this.colglassgroup.FieldName = "glassgroup";
            this.colglassgroup.Name = "colglassgroup";
            this.colglassgroup.Visible = true;
            this.colglassgroup.VisibleIndex = 4;
            this.colglassgroup.Width = 88;
            this.col_color.Caption = "Цвет";
            this.col_color.ColumnEdit = (RepositoryItem)this.repositoryItemColorEdit1;
            this.col_color.FieldName = "color";
            this.col_color.Name = "col_color";
            this.col_color.Visible = true;
            this.col_color.VisibleIndex = 3;
            this.col_color.Width = 46;
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            this.repositoryItemColorEdit1.StoreColorAsInteger = true;
            this.colramkaoffset.Caption = "Глубина рамки";
            this.colramkaoffset.FieldName = "ramkaoffset";
            this.colramkaoffset.Name = "colramkaoffset";
            this.colramkaoffset.Visible = true;
            this.colramkaoffset.VisibleIndex = 5;
            this.colramkaoffset.Width = 85;
            this.colnumpos.Caption = "№пп";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 0;
            this.colnumpos.Width = 65;
            this.colthickness.Caption = "Толщина";
            this.colthickness.FieldName = "thickness";
            this.colthickness.Name = "colthickness";
            this.colthickness.Visible = true;
            this.colthickness.VisibleIndex = 6;
            this.colthickness.Width = 53;
            this.colcamernost.Caption = "Камерность";
            this.colcamernost.FieldName = "camernost";
            this.colcamernost.Name = "colcamernost";
            this.colcamernost.Visible = true;
            this.colcamernost.VisibleIndex = 7;
            this.colcamernost.Width = 60;
            this.colidglassgroup.Caption = "idglassgroup";
            this.colidglassgroup.FieldName = "idglassgroup";
            this.colidglassgroup.Name = "colidglassgroup";
            this.colmarking2.Caption = "Внешний артикул";
            this.colmarking2.FieldName = "marking2";
            this.colmarking2.Name = "colmarking2";
            this.colmarking2.Visible = true;
            this.colmarking2.VisibleIndex = 9;
            this.colmarking3.Caption = "Внешний артикул 2";
            this.colmarking3.FieldName = "marking3";
            this.colmarking3.Name = "colmarking3";
            this.colmarking3.Visible = true;
            this.colmarking3.VisibleIndex = 10;
            this.colmarking4.Caption = "Внешний артикул 3";
            this.colmarking4.FieldName = "marking4";
            this.colmarking4.Name = "colmarking4";
            this.colmarking4.Visible = true;
            this.colmarking4.VisibleIndex = 11;
            this.colmarking5.Caption = "Внешний артикул 4";
            this.colmarking5.FieldName = "marking5";
            this.colmarking5.Name = "colmarking5";
            this.colmarking5.Visible = true;
            this.colmarking5.VisibleIndex = 12;
            this.colfilltype_name.Caption = "Тип заполнения";
            this.colfilltype_name.ColumnEdit = (RepositoryItem)this.cboFillType;
            this.colfilltype_name.FieldName = "filltype_name";
            this.colfilltype_name.Name = "colfilltype_name";
            this.colfilltype_name.Visible = true;
            this.colfilltype_name.VisibleIndex = 13;
            this.cboFillType.AutoHeight = false;
            this.cboFillType.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboFillType.Items.AddRange(new object[5]
      {
        (object) "Неопределено",
        (object) "Стеклопакет",
        (object) "Сэндвич",
        (object) "Наборное заполнение",
        (object) "Без заполнения"
      });
            this.cboFillType.Name = "cboFillType";
            this.cboFillType.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboFillType.EditValueChanging += new ChangingEventHandler(this.cboFillType_EditValueChanging);
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(870, 33);
            this.panel1.TabIndex = 2;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(783, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(702, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(621, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.treeListGlassGroup.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGlassGroup.Appearance.FocusedCell.ForeColor = Color.Black;
            this.treeListGlassGroup.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeListGlassGroup.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeListGlassGroup.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGlassGroup.Appearance.FocusedRow.ForeColor = Color.Black;
            this.treeListGlassGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeListGlassGroup.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeListGlassGroup.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.treeListGlassGroup.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            this.treeListGlassGroup.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGlassGroup.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGlassGroup.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.treeListGlassGroup.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeListGlassGroup.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeListGlassGroup.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListGlassGroup.Appearance.SelectedRow.ForeColor = Color.Black;
            this.treeListGlassGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeListGlassGroup.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeListGlassGroup.BorderStyle = BorderStyles.Simple;
            this.treeListGlassGroup.Columns.AddRange(new TreeListColumn[2]
      {
        this.treeListColumn1,
        this.treeListColumn2
      });
            this.treeListGlassGroup.ContextMenuStrip = this.MenuGroup;
            this.treeListGlassGroup.DataMember = "glassgroup";
            this.treeListGlassGroup.DataSource = (object)this.ds;
            this.treeListGlassGroup.Dock = DockStyle.Left;
            this.treeListGlassGroup.ImageIndexFieldName = "_image";
            this.treeListGlassGroup.KeyFieldName = "idglassgroup";
            this.treeListGlassGroup.Location = new Point(0, 0);
            this.treeListGlassGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListGlassGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListGlassGroup.Name = "treeListGlassGroup";
            this.treeListGlassGroup.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListGlassGroup.OptionsView.ShowHorzLines = false;
            this.treeListGlassGroup.OptionsView.ShowIndicator = false;
            this.treeListGlassGroup.OptionsView.ShowVertLines = false;
            this.treeListGlassGroup.ParentFieldName = "parentid";
            this.treeListGlassGroup.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemCheckEdit1
      });
            this.treeListGlassGroup.SelectImageList = (object)this.imageList1;
            this.treeListGlassGroup.Size = new Size(182, 297);
            this.treeListGlassGroup.TabIndex = 4;
            this.treeListColumn1.Caption = "Группы заполнений";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 27;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 148;
            this.treeListColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn2.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            this.treeListColumn2.Caption = "Активность";
            this.treeListColumn2.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit1;
            this.treeListColumn2.FieldName = "isactive";
            this.treeListColumn2.Format.FormatType = FormatType.Numeric;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 32;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.MenuGroup.Items.AddRange(new ToolStripItem[9]
      {
        (ToolStripItem) this.toolStripMenuItem4,
        (ToolStripItem) this.toolStripMenuItem5,
        (ToolStripItem) this.toolStripMenuItem7,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripMenuItem6,
        (ToolStripItem) this.MenuItemMoveGroup,
        (ToolStripItem) this.MenuItemSetGroupMain,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.MenuGroupSetType
      });
            this.MenuGroup.Name = "contextMenuStrip2";
            this.MenuGroup.Size = new Size(221, 170);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new Size(220, 22);
            this.toolStripMenuItem4.Text = "Добавить основную группу";
            this.toolStripMenuItem4.Click += new EventHandler(this.toolStripMenuItem4_Click);
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new Size(220, 22);
            this.toolStripMenuItem5.Text = "Добавить дочернюю группу";
            this.toolStripMenuItem5.Click += new EventHandler(this.toolStripMenuItem5_Click);
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new Size(220, 22);
            this.toolStripMenuItem7.Text = "Переименовать";
            this.toolStripMenuItem7.Click += new EventHandler(this.toolStripMenuItem7_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(217, 6);
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new Size(220, 22);
            this.toolStripMenuItem6.Text = "Удалить группу";
            this.toolStripMenuItem6.Click += new EventHandler(this.toolStripMenuItem6_Click);
            this.MenuItemMoveGroup.Name = "MenuItemMoveGroup";
            this.MenuItemMoveGroup.Size = new Size(220, 22);
            this.MenuItemMoveGroup.Text = "Переместить в группу";
            this.MenuItemSetGroupMain.Name = "MenuItemSetGroupMain";
            this.MenuItemSetGroupMain.Size = new Size(220, 22);
            this.MenuItemSetGroupMain.Text = "Сделать основоной";
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(217, 6);
            this.MenuGroupSetType.Name = "MenuGroupSetType";
            this.MenuGroupSetType.Size = new Size(220, 22);
            this.MenuGroupSetType.Text = "Установить тип для группы";
            this.MenuGroupSetType.Click += new EventHandler(this.MenuGroupSetType_Click);
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.splitterControl1.Location = new Point(182, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 297);
            this.splitterControl1.TabIndex = 5;
            this.splitterControl1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlGlass);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeListGlassGroup);
            this.Controls.Add((Control)this.panel1);
            this.Name = "GlassForm";
            this.Size = new Size(870, 330);
            this.Text = "Заполнения";
            this.gridViewGlassDetail.EndInit();
            this.repositoryItemComboBox1.EndInit();
            this.gridControlGlass.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.ds.EndInit();
            this.gridViewGlass.EndInit();
            this.repositoryItemColorEdit1.EndInit();
            this.cboFillType.EndInit();
            this.panel1.ResumeLayout(false);
            this.treeListGlassGroup.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            this.dr = AtTreeList.GetSelectedNode(this.treeListGlassGroup);
            if (this.dr == null)
                return;
            if (this.MoveGlass != null)
            {
                foreach (DataRow dataRow in this.MoveGlass)
                    dataRow["idglassgroup"] = this.dr["idglassgroup"];
                this.MoveGlass = (DataRow[])null;
                this.Cursor = Cursors.Default;
            }
            if (this.MoveGroup == null)
                return;
            this.MoveGroup["parentid"] = this.dr["idglassgroup"];
            this.MoveGroup = (DataRow)null;
            this.Cursor = Cursors.Default;
        }

        private void GlassForm_Shown(object sender, EventArgs e)
        {
            this.treeListGlassGroup.MoveLastVisible();
            this.treeListGlassGroup.MoveFirst();
        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            TreeList_KeyDown.Key(this.treeListGlassGroup, e.KeyCode);
        }

        private void GlassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet((DataSet)this.ds) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from glassgroup where deleted is null";
            this.db.adapter.Fill(this.table_glassgroup);
            this.db.command.CommandText = "select * from view_glass where deleted is null order by numpos";
            this.db.adapter.Fill(this.table_glass);
            this.db.command.CommandText = "select * from glassdetail where deleted is null";
            this.db.adapter.Fill(this.table_glassdetail);
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDatatable(this.table_glassgroup) || !this.db.SaveDatatable(this.table_glass) || !this.db.SaveDatatable(this.table_glassdetail))
                return false;
            this.ds.AcceptChanges();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds.Clear();
            this.ds.AcceptChanges();
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGlassGroup);
            if (selectedNode == null)
                return;
            DataRow row = this.table_glass.NewRow();
            row["idglass"] = (object)dbconn.GetGenId("gen_glass");
            row["name"] = (object)"Новое заполнение";
            row["idglassgroup"] = selectedNode["idglassgroup"];
            this.table_glass.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlGlass);
            if (selectedDataRows == null || selectedDataRows.Length == 0 || selectedDataRows[0].Table != this.table_glass)
                return;
            int genFirstId = dbconn.GetGenFirstId("gen_glass", selectedDataRows.Length);
            foreach (DataRow source in selectedDataRows)
                AtDataSet.dublicate(source)["idglass"] = (object)genFirstId++;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlGlass);
            if (selectedDataRows == null || selectedDataRows.Length == 0 || selectedDataRows[0].Table != this.table_glass)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlGlass);
            if (dataRow1 == null || dataRow1.Table != this.table_glass)
                return;
            GoodForm goodForm = new GoodForm();
            goodForm.IsDialog();
            if (goodForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow2 = AtGrid.getDataRow((Control)goodForm.gridControlGood);
            if (dataRow2 == null)
                return;
            DataRow row = this.table_glassdetail.NewRow();
            this.table_glassdetail.Rows.Add(row);
            row["idglassdetail"] = (object)dbconn.GetGenId("gen_glassdetail");
            row["idglass"] = dataRow1["idglass"];
            row["idgood"] = dataRow2["idgood"];
            row["good_marking"] = dataRow2["marking"];
            row["good_name"] = dataRow2["name"];
            row["typ"] = (object)0;
            row["typ_name"] = (object)"Стекло";
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            this.MoveGlass = AtGrid.getSelectedDataRows((Control)this.gridControlGlass);
            if (this.MoveGlass == null || this.MoveGlass.Length == 0)
                this.MoveGlass = (DataRow[])null;
            else
                this.Cursor = Cursors.Hand;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_glassgroup.NewRow();
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["idglassgroup"] = (object)dbconn.GetGenId("gen_glassgroup");
            row["name"] = (object)InputBox.Value;
            row["isactive"] = (object)1;
            this.table_glassgroup.Rows.Add(row);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (this.treeListGlassGroup.Selection.Count == 0)
                return;
            DataRow row1 = ((DataRowView)this.treeListGlassGroup.GetDataRecordByNode(this.treeListGlassGroup.Selection[0])).Row;
            DataRow row2 = this.table_glassgroup.NewRow();
            if (InputBox.ShowDialog("Создание дочерней группы", "Введите имя", row2["name"].ToString()) == DialogResult.Cancel)
                return;
            row2["idglassgroup"] = (object)dbconn.GetGenId("gen_glassgroup");
            row2["name"] = (object)InputBox.Value;
            row2["parentid"] = row1["idglassgroup"];
            row2["isactive"] = (object)1;
            this.table_glassgroup.Rows.Add(row2);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (this.treeListGlassGroup.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeListGlassGroup.GetDataRecordByNode(this.treeListGlassGroup.Selection[0])).Row;
            if (row.GetChildRows("FK_glassgroup_glassgroup").Length != 0 && MessageBox.Show("В группе содержатся подгруппы!\nУдалить группу со всеми вложенными подгруппами?", "Удаление группы заполнений", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            row.Delete();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (this.treeListGlassGroup.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeListGlassGroup.GetDataRecordByNode(this.treeListGlassGroup.Selection[0])).Row;
            if (InputBox.ShowDialog("Изменить имя", "Введите новое имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
        }

        private void MenuItemSetGroupMain_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGlassGroup);
            if (selectedNode == null)
                return;
            selectedNode["parentid"] = (object)DBNull.Value;
        }

        private void MenuItemMoveGroup_Click(object sender, EventArgs e)
        {
            this.MoveGroup = AtTreeList.GetSelectedNode(this.treeListGlassGroup);
            if (this.MoveGroup == null)
                return;
            this.Cursor = Cursors.Hand;
        }

        private void cboFillType_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGlass);
            if (e.NewValue.ToString() == "Неопределено")
                dataRow["idfilltype"] = (object)0;
            else if (e.NewValue.ToString() == "Стеклопакет")
                dataRow["idfilltype"] = (object)1;
            else if (e.NewValue.ToString() == "Сэндвич")
                dataRow["idfilltype"] = (object)2;
            else if (e.NewValue.ToString() == "Наборное заполнение")
            {
                dataRow["idfilltype"] = (object)3;
            }
            else
            {
                if (!(e.NewValue.ToString() == "Без заполнения"))
                    return;
                dataRow["idfilltype"] = (object)4;
            }
        }

        private void MenuGroupSetType_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGlassGroup);
            if (selectedNode == null)
                return;
            ds.glassgroupRow drGroup = (ds.glassgroupRow)selectedNode;
            GetFillTypeForm getFillTypeForm = new GetFillTypeForm();
            if (getFillTypeForm.ShowDialog() != DialogResult.OK || getFillTypeForm.idfilltype == -1)
                return;
            this.SetGlassGroup(drGroup, getFillTypeForm.idfilltype, getFillTypeForm.filltype_name);
        }

        private void SetGlassGroup(ds.glassgroupRow drGroup, int idfilltype, string filltype_name)
        {
            ds.glassRow[] glassRowArray = drGroup.GetglassRows();
            if (glassRowArray != null && glassRowArray.Length != 0)
            {
                foreach (ds.glassRow glassRow in glassRowArray)
                {
                    glassRow.idfilltype = idfilltype;
                    glassRow.filltype_name = filltype_name;
                }
            }
            ds.glassgroupRow[] glassgroupRowArray = drGroup.GetglassgroupRows();
            if (glassgroupRowArray == null || glassgroupRowArray.Length == 0)
                return;
            foreach (ds.glassgroupRow drGroup1 in glassgroupRowArray)
                this.SetGlassGroup(drGroup1, idfilltype, filltype_name);
        }
    }
}
