// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.MarkingFilterForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class MarkingFilterForm : AtUserControl
    {
        private IContainer components;
        public GridControl gcFilter;
        private GridView gvFilterDetail;
        private GridColumn colgood_marking;
        private GridColumn colgood_name;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit2;
        private GridView gvFilter;
        private GridColumn colidmarkingfilter;
        private RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private TreeList treeListGroup;
        private TreeListColumn treeListColumn1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataSet dsData;
        private DataTable table_markingfiltertype;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataTable table_markingfilter;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataTable table_markingfilterdetail;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn9;
        private DataColumn dataColumn10;
        private ContextMenuStrip cmsGridMenu;
        private ToolStripMenuItem MenuItemAddFilter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemRemove;
        private DataColumn dataColumn11;
        private GridColumn colcomment;
        private ToolStripMenuItem MenuItemAddFilterGood;
        private GridColumn colidmarkingfilterdetail;
        private GridColumn colfilterdetailcomment;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private GridColumn colname;

        public MarkingFilterForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.MarkingFilterForm_FormClosing);
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
            this.gvFilterDetail = new GridView();
            this.colidmarkingfilterdetail = new GridColumn();
            this.colgood_marking = new GridColumn();
            this.colgood_name = new GridColumn();
            this.colfilterdetailcomment = new GridColumn();
            this.gcFilter = new GridControl();
            this.cmsGridMenu = new ContextMenuStrip(this.components);
            this.MenuItemAddFilter = new ToolStripMenuItem();
            this.MenuItemAddFilterGood = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.dsData = new DataSet();
            this.table_markingfiltertype = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.table_markingfilter = new DataTable();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.table_markingfilterdetail = new DataTable();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.gvFilter = new GridView();
            this.colidmarkingfilter = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new AtRepositoryItemTextEdit();
            this.repositoryItemCheckEdit2 = new RepositoryItemCheckEdit();
            this.treeListGroup = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.gvFilterDetail.BeginInit();
            this.gcFilter.BeginInit();
            this.cmsGridMenu.SuspendLayout();
            this.dsData.BeginInit();
            this.table_markingfiltertype.BeginInit();
            this.table_markingfilter.BeginInit();
            this.table_markingfilterdetail.BeginInit();
            this.gvFilter.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemTextEdit2.BeginInit();
            this.repositoryItemCheckEdit2.BeginInit();
            this.treeListGroup.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            this.gvFilterDetail.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gvFilterDetail.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFilterDetail.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvFilterDetail.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFilterDetail.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFilterDetail.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gvFilterDetail.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFilterDetail.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvFilterDetail.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFilterDetail.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilterDetail.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gvFilterDetail.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvFilterDetail.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvFilterDetail.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFilterDetail.BorderStyle = BorderStyles.Simple;
            this.gvFilterDetail.Columns.AddRange(new GridColumn[4]
      {
        this.colidmarkingfilterdetail,
        this.colgood_marking,
        this.colgood_name,
        this.colfilterdetailcomment
      });
            this.gvFilterDetail.GridControl = this.gcFilter;
            this.gvFilterDetail.Name = "gvFilterDetail";
            this.gvFilterDetail.OptionsCustomization.AllowFilter = false;
            this.gvFilterDetail.OptionsCustomization.AllowGroup = false;
            this.gvFilterDetail.OptionsDetail.ShowDetailTabs = false;
            this.gvFilterDetail.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gvFilterDetail.OptionsView.ShowGroupPanel = false;
            this.gvFilterDetail.OptionsView.ShowIndicator = false;
            this.colidmarkingfilterdetail.Caption = "#";
            this.colidmarkingfilterdetail.FieldName = "idmarkingfilterdetail";
            this.colidmarkingfilterdetail.Name = "colidmarkingfilterdetail";
            this.colidmarkingfilterdetail.Visible = true;
            this.colidmarkingfilterdetail.VisibleIndex = 0;
            this.colidmarkingfilterdetail.Width = 79;
            this.colgood_marking.Caption = "Артикул материала";
            this.colgood_marking.FieldName = "good_marking";
            this.colgood_marking.Name = "colgood_marking";
            this.colgood_marking.OptionsColumn.AllowEdit = false;
            this.colgood_marking.Visible = true;
            this.colgood_marking.VisibleIndex = 1;
            this.colgood_marking.Width = 188;
            this.colgood_name.Caption = "Наименование материала";
            this.colgood_name.FieldName = "good_name";
            this.colgood_name.Name = "colgood_name";
            this.colgood_name.OptionsColumn.AllowEdit = false;
            this.colgood_name.Visible = true;
            this.colgood_name.VisibleIndex = 2;
            this.colgood_name.Width = 327;
            this.colfilterdetailcomment.Caption = "Комментарий";
            this.colfilterdetailcomment.FieldName = "comment";
            this.colfilterdetailcomment.Name = "colfilterdetailcomment";
            this.colfilterdetailcomment.Visible = true;
            this.colfilterdetailcomment.VisibleIndex = 3;
            this.colfilterdetailcomment.Width = 331;
            this.gcFilter.ContextMenuStrip = this.cmsGridMenu;
            this.gcFilter.DataMember = "markingfilter";
            this.gcFilter.DataSource = (object)this.dsData;
            this.gcFilter.Dock = DockStyle.Fill;
            this.gcFilter.EmbeddedNavigator.Name = "";
            gridLevelNode.LevelTemplate = (BaseView)this.gvFilterDetail;
            gridLevelNode.RelationName = "fk_markingfilterl_markingfilterdetail";
            this.gcFilter.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
            this.gcFilter.Location = new Point(214, 0);
            this.gcFilter.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gcFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcFilter.MainView = (BaseView)this.gvFilter;
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemTextEdit2,
        (RepositoryItem) this.repositoryItemCheckEdit2
      });
            this.gcFilter.Size = new Size(552, 432);
            this.gcFilter.TabIndex = 6;
            this.gcFilter.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gvFilter,
        (BaseView) this.gvFilterDetail
      });
            this.cmsGridMenu.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.MenuItemAddFilter,
        (ToolStripItem) this.MenuItemAddFilterGood,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemRemove
      });
            this.cmsGridMenu.Name = "contextMenuStrip2";
            this.cmsGridMenu.Size = new Size(184, 76);
            this.MenuItemAddFilter.Name = "MenuItemAddFilter";
            this.MenuItemAddFilter.Size = new Size(183, 22);
            this.MenuItemAddFilter.Text = "Добавить фильтр";
            this.MenuItemAddFilter.Click += new EventHandler(this.MenuItemAdd_Click);
            this.MenuItemAddFilterGood.Name = "MenuItemAddFilterGood";
            this.MenuItemAddFilterGood.Size = new Size(183, 22);
            this.MenuItemAddFilterGood.Text = "Добавить материалы";
            this.MenuItemAddFilterGood.Click += new EventHandler(this.MenuItemAddFilterGood_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(180, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.Size = new Size(183, 22);
            this.MenuItemRemove.Text = "Удалить ";
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            this.dsData.DataSetName = "NewDataSet";
            this.dsData.Relations.AddRange(new DataRelation[1]
      {
        new DataRelation("fk_markingfilterl_markingfilterdetail", "markingfilter", "markingfilterdetail", new string[1]
        {
          "idmarkingfilter"
        }, new string[1]
        {
          "idmarkingfilter"
        }, 0 != 0)
      });
            this.dsData.Tables.AddRange(new DataTable[3]
      {
        this.table_markingfiltertype,
        this.table_markingfilter,
        this.table_markingfilterdetail
      });
            this.table_markingfiltertype.Columns.AddRange(new DataColumn[2]
      {
        this.dataColumn1,
        this.dataColumn2
      });
            this.table_markingfiltertype.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idmarkingfiltertype"
        }, 1 != 0)
      });
            this.table_markingfiltertype.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_markingfiltertype.TableName = "markingfiltertype";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idmarkingfiltertype";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.table_markingfilter.Columns.AddRange(new DataColumn[5]
      {
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn11
      });
            this.table_markingfilter.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idmarkingfilter"
        }, 1 != 0)
      });
            this.table_markingfilter.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn3
      };
            this.table_markingfilter.TableName = "markingfilter";
            this.dataColumn3.AllowDBNull = false;
            this.dataColumn3.ColumnName = "idmarkingfilter";
            this.dataColumn3.DataType = typeof(int);
            this.dataColumn4.ColumnName = "name";
            this.dataColumn5.ColumnName = "deleted";
            this.dataColumn5.DataType = typeof(DateTime);
            this.dataColumn6.ColumnName = "idmarkingfiltertype";
            this.dataColumn6.DataType = typeof(int);
            this.dataColumn11.ColumnName = "comment";
            this.table_markingfilterdetail.Columns.AddRange(new DataColumn[7]
      {
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn9,
        this.dataColumn10,
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14
      });
            this.table_markingfilterdetail.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idmarkingfilterdetail"
        }, 1 != 0)
      });
            this.table_markingfilterdetail.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn7
      };
            this.table_markingfilterdetail.TableName = "markingfilterdetail";
            this.dataColumn7.AllowDBNull = false;
            this.dataColumn7.ColumnName = "idmarkingfilterdetail";
            this.dataColumn7.DataType = typeof(int);
            this.dataColumn8.ColumnName = "idmarkingfilter";
            this.dataColumn8.DataType = typeof(int);
            this.dataColumn9.ColumnName = "idgood";
            this.dataColumn9.DataType = typeof(int);
            this.dataColumn10.ColumnName = "deleted";
            this.dataColumn10.DataType = typeof(DateTime);
            this.dataColumn12.ColumnName = "comment";
            this.dataColumn13.ColumnName = "good_name";
            this.dataColumn14.ColumnName = "good_marking";
            this.gvFilter.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilter.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilter.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilter.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gvFilter.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFilter.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvFilter.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFilter.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilter.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvFilter.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFilter.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvFilter.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvFilter.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvFilter.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gvFilter.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFilter.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvFilter.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFilter.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilter.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilter.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvFilter.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gvFilter.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvFilter.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvFilter.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFilter.BorderStyle = BorderStyles.Simple;
            this.gvFilter.Columns.AddRange(new GridColumn[3]
      {
        this.colidmarkingfilter,
        this.colname,
        this.colcomment
      });
            this.gvFilter.GridControl = this.gcFilter;
            this.gvFilter.GroupPanelText = "Панель группировки";
            this.gvFilter.Name = "gvFilter";
            this.gvFilter.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvFilter.OptionsCustomization.AllowFilter = false;
            this.gvFilter.OptionsDetail.ShowDetailTabs = false;
            this.gvFilter.OptionsSelection.MultiSelect = true;
            this.gvFilter.OptionsView.ShowAutoFilterRow = true;
            this.gvFilter.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gvFilter.OptionsView.ShowGroupPanel = false;
            this.gvFilter.OptionsView.ShowIndicator = false;
            this.colidmarkingfilter.Caption = "#";
            this.colidmarkingfilter.FieldName = "idmarkingfilter";
            this.colidmarkingfilter.Name = "colidmarkingfilter";
            this.colidmarkingfilter.OptionsColumn.AllowEdit = false;
            this.colidmarkingfilter.Visible = true;
            this.colidmarkingfilter.VisibleIndex = 0;
            this.colidmarkingfilter.Width = 51;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 414;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 2;
            this.colcomment.Width = 460;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
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
            this.treeListGroup.Columns.AddRange(new TreeListColumn[1]
      {
        this.treeListColumn1
      });
            this.treeListGroup.DataMember = "markingfiltertype";
            this.treeListGroup.DataSource = (object)this.dsData;
            this.treeListGroup.Dock = DockStyle.Left;
            this.treeListGroup.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeListGroup.ImageIndexFieldName = "";
            this.treeListGroup.KeyFieldName = "";
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
            this.treeListGroup.Size = new Size(214, 432);
            this.treeListGroup.TabIndex = 7;
            this.treeListColumn1.Caption = "Форма";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 45;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 118;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(766, 33);
            this.panel1.TabIndex = 5;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(679, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(598, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(517, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gcFilter);
            this.Controls.Add((Control)this.treeListGroup);
            this.Controls.Add((Control)this.panel1);
            this.Name = "MarkingFilterForm";
            this.Size = new Size(766, 465);
            this.Text = "Фильтры артикулов";
            this.gvFilterDetail.EndInit();
            this.gcFilter.EndInit();
            this.cmsGridMenu.ResumeLayout(false);
            this.dsData.EndInit();
            this.table_markingfiltertype.EndInit();
            this.table_markingfilter.EndInit();
            this.table_markingfilterdetail.EndInit();
            this.gvFilter.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemTextEdit2.EndInit();
            this.repositoryItemCheckEdit2.EndInit();
            this.treeListGroup.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void MarkingFilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.OnCloseAlert();
        }

        private void OnCloseAlert()
        {
            if (!AtDataSet.IsModifDataSet(this.dsData) || MessageBox.Show(string.Format("Изменения не сохранены.{0}Сохранить?", (object)Environment.NewLine), "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
                return;
            this.SaveToBase();
        }

        public override void LoadFromBase()
        {
            this.table_markingfiltertype.Clear();
            this.table_markingfiltertype.AcceptChanges();
            this.db.command.CommandText = "select * from markingfiltertype";
            this.db.adapter.Fill(this.table_markingfiltertype);
            this.table_markingfilter.Clear();
            this.table_markingfilter.AcceptChanges();
            this.db.command.CommandText = "select * from markingfilter where deleted is null";
            this.db.adapter.Fill(this.table_markingfilter);
            this.table_markingfilterdetail.Clear();
            this.table_markingfilterdetail.AcceptChanges();
            this.db.command.CommandText = "select * from view_markingfilterdetail where deleted is null";
            this.db.adapter.Fill(this.table_markingfilterdetail);
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_markingfilter.NewRow();
            row["idmarkingfilter"] = (object)dbconn.GetGenId("gen_markingfilter");
            row["name"] = (object)"Новый фильтр";
            row["idmarkingfiltertype"] = (object)1;
            this.table_markingfilter.Rows.Add(row);
        }

        private void MenuItemAddFilterGood_Click(object sender, EventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gcFilter);
            if (dataRow1 == null && dataRow1.Table != this.table_markingfilter)
                return;
            SelectGoodForm selectGoodForm = new SelectGoodForm(true);
            int num = (int)selectGoodForm.ShowDialog();
            if (selectGoodForm.table_result == null || selectGoodForm.table_result.Rows.Count <= 0)
                return;
            foreach (DataRow dataRow2 in (InternalDataCollectionBase)selectGoodForm.table_result.Rows)
            {
                DataRow row = this.table_markingfilterdetail.NewRow();
                row["idmarkingfilterdetail"] = (object)dbconn.GetGenId("gen_markingfilterdetail");
                row["idmarkingfilter"] = dataRow1["idmarkingfilter"];
                row["idgood"] = dataRow2["idgood"];
                row["good_name"] = dataRow2["name"];
                row["good_marking"] = dataRow2["marking"];
                this.table_markingfilterdetail.Rows.Add(row);
            }
            this.gvFilter.RefreshData();
            this.gcFilter.Refresh();
        }

        public override bool SaveToBase()
        {
            return this.db.SaveDataSetAndAccept(this.dsData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LoadFromBase();
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gcFilter);
            if (dataRow1 == null)
                return;
            if (dataRow1.Table == this.table_markingfilterdetail)
            {
                dataRow1.Delete();
            }
            else
            {
                if (dataRow1.Table != this.table_markingfilter)
                    return;
                foreach (DataRow dataRow2 in this.table_markingfilterdetail.Select("idmarkingfilter = " + dataRow1["idmarkingfilter"].ToString()))
                    dataRow2.Delete();
                dataRow1.Delete();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
