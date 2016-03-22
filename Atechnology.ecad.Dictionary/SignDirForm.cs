// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.SignDirForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class SignDirForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private XtraTabControl TabControl;
        private XtraTabPage TabPageSign;
        private XtraTabPage TabPageDiraction;
        private GridControl gridControlSign;
        private GridView gridViewSign;
        private GridControl gridControlDiraction;
        private GridView gridViewDiraction;
        private ContextMenuStrip MenuItemSign;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ContextMenuStrip MenuStripDiraction;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private DataSet ds;
        private DataTable table_sign;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataTable table_signvalue;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataTable table_diraction;
        private DataColumn dataColumn9;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridView gridViewSignValue;
        private GridColumn colintvalue;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private GridColumn colidsignvalue;
        private GridColumn colstrvalue;
        private GridColumn colcomment1;
        private GridColumn colname1;
        private GridColumn colcomment2;
        private GridColumn colnumpos;
        private GridColumn colautosave;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripSeparator toolStripSeparator3;
        private DataColumn dataColumn14;
        private GridColumn colduration;
        private DataColumn dataColumn15;
        private GridColumn colautosave2;
        private SplitterControl splitterControl1;
        private TreeList treeListSignGroup;
        private TreeListColumn treeListColumn1;
        private TreeListColumn treeListColumn2;
        private DataColumn dataColumn27;
        private DataColumn dataColumn26;
        private DataTable table_diractiongroup;
        private DataColumn dataColumn16;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private DataColumn dataColumn19;
        private DataColumn dataColumn25;
        private DataTable table_signgroup;
        private DataColumn dataColumn20;
        private DataColumn dataColumn21;
        private DataColumn dataColumn22;
        private DataColumn dataColumn23;
        private DataColumn dataColumn24;
        private SplitterControl splitterControl2;
        private TreeList treeListDiractionGroup;
        private TreeListColumn treeListColumn3;
        private TreeListColumn treeListColumn4;
        private ContextMenuStrip MenuGroup;
        private ToolStripMenuItem MenuGroupAddMain;
        private ToolStripMenuItem MenuGroupAddChild;
        private ToolStripMenuItem MenuGroupRename;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MenuGroupRemove;
        private GridColumn colidsigngroup;
        private GridColumn coliddiractiongroup;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem toolStripMenuItem17;
        private DataColumn dataColumn28;
        private DataColumn dataColumn29;
        private ImageList imageList1;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem MenuGroupMove;
        private ToolStripMenuItem MenuGroupSetMain;
        private GridColumn colidsign;
        private GridColumn coliddiraction;
        private DataColumn dataColumn30;
        private GridColumn coladdtooptimdoc;
        private bool saved;
        private DataRow MoveGroup;
        private DataRow[] MoveItems;

        public SignDirForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.SignDirForm_FormClosing);
            this.treeListSignGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeListDiractionGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeList2_FocusedNodeChanged);
            this.TabControl.SelectedPageChanged += new TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            this.Shown += new Shown(this.SignDirForm_Shown);
            this.MenuGroupAddChild.Click += new EventHandler(this.MenuGroupAddChild_Click);
            this.MenuGroupAddMain.Click += new EventHandler(this.MenuGroupAddMain_Click);
            this.MenuGroupMove.Click += new EventHandler(this.MenuGroupMove_Click);
            this.MenuGroupRemove.Click += new EventHandler(this.MenuGroupRemove_Click);
            this.MenuGroupRename.Click += new EventHandler(this.MenuGroupRename_Click);
            this.MenuGroupSetMain.Click += new EventHandler(this.MenuGroupSetMain_Click);
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SignDirForm));
            this.gridViewSignValue = new GridView();
            this.colidsignvalue = new GridColumn();
            this.colintvalue = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.colstrvalue = new GridColumn();
            this.colcomment1 = new GridColumn();
            this.gridControlSign = new GridControl();
            this.MenuItemSign = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem7 = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.toolStripSeparator6 = new ToolStripSeparator();
            this.toolStripMenuItem16 = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_diractiongroup = new DataTable();
            this.dataColumn16 = new DataColumn();
            this.dataColumn17 = new DataColumn();
            this.dataColumn18 = new DataColumn();
            this.dataColumn19 = new DataColumn();
            this.dataColumn25 = new DataColumn();
            this.dataColumn28 = new DataColumn();
            this.table_signgroup = new DataTable();
            this.dataColumn20 = new DataColumn();
            this.dataColumn21 = new DataColumn();
            this.dataColumn22 = new DataColumn();
            this.dataColumn23 = new DataColumn();
            this.dataColumn24 = new DataColumn();
            this.dataColumn29 = new DataColumn();
            this.table_sign = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn27 = new DataColumn();
            this.table_signvalue = new DataTable();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.table_diraction = new DataTable();
            this.dataColumn9 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn15 = new DataColumn();
            this.dataColumn26 = new DataColumn();
            this.gridViewSign = new GridView();
            this.colidsign = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colidsigngroup = new GridColumn();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.TabControl = new XtraTabControl();
            this.TabPageSign = new XtraTabPage();
            this.splitterControl1 = new SplitterControl();
            this.treeListSignGroup = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.treeListColumn2 = new TreeListColumn();
            this.MenuGroup = new ContextMenuStrip(this.components);
            this.MenuGroupAddMain = new ToolStripMenuItem();
            this.MenuGroupAddChild = new ToolStripMenuItem();
            this.MenuGroupRename = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.MenuGroupRemove = new ToolStripMenuItem();
            this.toolStripSeparator8 = new ToolStripSeparator();
            this.MenuGroupMove = new ToolStripMenuItem();
            this.MenuGroupSetMain = new ToolStripMenuItem();
            this.imageList1 = new ImageList(this.components);
            this.TabPageDiraction = new XtraTabPage();
            this.gridControlDiraction = new GridControl();
            this.MenuStripDiraction = new ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.toolStripMenuItem5 = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItem6 = new ToolStripMenuItem();
            this.toolStripSeparator7 = new ToolStripSeparator();
            this.toolStripMenuItem17 = new ToolStripMenuItem();
            this.gridViewDiraction = new GridView();
            this.coliddiraction = new GridColumn();
            this.colname1 = new GridColumn();
            this.colcomment2 = new GridColumn();
            this.colnumpos = new GridColumn();
            this.colautosave = new GridColumn();
            this.colduration = new GridColumn();
            this.colautosave2 = new GridColumn();
            this.coliddiractiongroup = new GridColumn();
            this.splitterControl2 = new SplitterControl();
            this.treeListDiractionGroup = new TreeList();
            this.treeListColumn3 = new TreeListColumn();
            this.treeListColumn4 = new TreeListColumn();
            this.dataColumn30 = new DataColumn();
            this.coladdtooptimdoc = new GridColumn();
            this.gridViewSignValue.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.gridControlSign.BeginInit();
            this.MenuItemSign.SuspendLayout();
            this.ds.BeginInit();
            this.table_diractiongroup.BeginInit();
            this.table_signgroup.BeginInit();
            this.table_sign.BeginInit();
            this.table_signvalue.BeginInit();
            this.table_diraction.BeginInit();
            this.gridViewSign.BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPageSign.SuspendLayout();
            this.treeListSignGroup.BeginInit();
            this.MenuGroup.SuspendLayout();
            this.TabPageDiraction.SuspendLayout();
            this.gridControlDiraction.BeginInit();
            this.MenuStripDiraction.SuspendLayout();
            this.gridViewDiraction.BeginInit();
            this.treeListDiractionGroup.BeginInit();
            this.SuspendLayout();
            this.gridViewSignValue.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewSignValue.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewSignValue.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewSignValue.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewSignValue.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewSignValue.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewSignValue.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewSignValue.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewSignValue.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewSignValue.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSignValue.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewSignValue.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewSignValue.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewSignValue.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewSignValue.BorderStyle = BorderStyles.Simple;
            this.gridViewSignValue.Columns.AddRange(new GridColumn[4]
      {
        this.colidsignvalue,
        this.colintvalue,
        this.colstrvalue,
        this.colcomment1
      });
            this.gridViewSignValue.GridControl = this.gridControlSign;
            this.gridViewSignValue.Name = "gridViewSignValue";
            this.gridViewSignValue.OptionsCustomization.AllowFilter = false;
            this.gridViewSignValue.OptionsDetail.ShowDetailTabs = false;
            this.gridViewSignValue.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewSignValue.OptionsView.ShowGroupPanel = false;
            this.gridViewSignValue.OptionsView.ShowIndicator = false;
            this.colidsignvalue.Caption = "#";
            this.colidsignvalue.FieldName = "idsignvalue";
            this.colidsignvalue.Name = "colidsignvalue";
            this.colidsignvalue.OptionsColumn.AllowEdit = false;
            this.colidsignvalue.Visible = true;
            this.colidsignvalue.VisibleIndex = 0;
            this.colintvalue.Caption = "Число";
            this.colintvalue.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colintvalue.FieldName = "intvalue";
            this.colintvalue.Name = "colintvalue";
            this.colintvalue.Visible = true;
            this.colintvalue.VisibleIndex = 1;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.colstrvalue.Caption = "Строка";
            this.colstrvalue.FieldName = "strvalue";
            this.colstrvalue.Name = "colstrvalue";
            this.colstrvalue.Visible = true;
            this.colstrvalue.VisibleIndex = 2;
            this.colcomment1.Caption = "Описание";
            this.colcomment1.FieldName = "comment";
            this.colcomment1.Name = "colcomment1";
            this.colcomment1.Visible = true;
            this.colcomment1.VisibleIndex = 3;
            this.gridControlSign.ContextMenuStrip = this.MenuItemSign;
            this.gridControlSign.DataMember = "signgroup.rel_sign_signgroup";
            this.gridControlSign.DataSource = (object)this.ds;
            this.gridControlSign.Dock = DockStyle.Fill;
            this.gridControlSign.EmbeddedNavigator.Name = "";
            gridLevelNode.LevelTemplate = (BaseView)this.gridViewSignValue;
            gridLevelNode.RelationName = "Relation1";
            this.gridControlSign.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
            this.gridControlSign.Location = new Point(242, 0);
            this.gridControlSign.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlSign.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlSign.MainView = (BaseView)this.gridViewSign;
            this.gridControlSign.Name = "gridControlSign";
            this.gridControlSign.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemTextEdit1
      });
            this.gridControlSign.Size = new Size(663, 394);
            this.gridControlSign.TabIndex = 2;
            this.gridControlSign.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridViewSign,
        (BaseView) this.gridViewSignValue
      });
            this.MenuItemSign.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem7,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.toolStripMenuItem3,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.toolStripMenuItem16
      });
            this.MenuItemSign.Name = "contextMenuStrip1";
            this.MenuItemSign.Size = new Size(264, 132);
            this.toolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItem1.Size = new Size(263, 22);
            this.toolStripMenuItem1.Text = "Добавить признак";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItem2.Size = new Size(263, 22);
            this.toolStripMenuItem2.Text = "Дублировать признак";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(260, 6);
            this.toolStripMenuItem7.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.toolStripMenuItem7.Size = new Size(263, 22);
            this.toolStripMenuItem7.Text = "Добавить значение";
            this.toolStripMenuItem7.Click += new EventHandler(this.toolStripMenuItem7_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(260, 6);
            this.toolStripMenuItem3.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItem3.Size = new Size(263, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new Size(260, 6);
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new Size(263, 22);
            this.toolStripMenuItem16.Text = "Переместить в группу...";
            this.toolStripMenuItem16.Click += new EventHandler(this.toolStripMenuItem16_Click);
            this.ds.DataSetName = "ds_signdir";
            this.ds.EnforceConstraints = false;
            this.ds.Relations.AddRange(new DataRelation[5]
      {
        new DataRelation("Relation1", "sign", "signvalue", new string[1]
        {
          "idsign"
        }, new string[1]
        {
          "idsign"
        }, 0 != 0),
        new DataRelation("rel_sign_signgroup", "signgroup", "sign", new string[1]
        {
          "idsigngroup"
        }, new string[1]
        {
          "idsigngroup"
        }, 0 != 0),
        new DataRelation("rel_diraction_diractiongroup", "diractiongroup", "diraction", new string[1]
        {
          "iddiractiongroup"
        }, new string[1]
        {
          "iddiractiongroup"
        }, 0 != 0),
        new DataRelation("rel_signgroup", "signgroup", "signgroup", new string[1]
        {
          "idsigngroup"
        }, new string[1]
        {
          "parentid"
        }, 0 != 0),
        new DataRelation("rel_diractiongroup", "diractiongroup", "diractiongroup", new string[1]
        {
          "iddiractiongroup"
        }, new string[1]
        {
          "parentid"
        }, 0 != 0)
      });
            this.ds.Tables.AddRange(new DataTable[5]
      {
        this.table_diractiongroup,
        this.table_signgroup,
        this.table_sign,
        this.table_signvalue,
        this.table_diraction
      });
            this.table_diractiongroup.Columns.AddRange(new DataColumn[6]
      {
        this.dataColumn16,
        this.dataColumn17,
        this.dataColumn18,
        this.dataColumn19,
        this.dataColumn25,
        this.dataColumn28
      });
            this.table_diractiongroup.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "iddiractiongroup"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("rel_diractiongroup", "diractiongroup", new string[1]
        {
          "iddiractiongroup"
        }, new string[1]
        {
          "parentid"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_diractiongroup.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn16
      };
            this.table_diractiongroup.TableName = "diractiongroup";
            this.dataColumn16.AllowDBNull = false;
            this.dataColumn16.ColumnName = "iddiractiongroup";
            this.dataColumn16.DataType = typeof(int);
            this.dataColumn17.ColumnName = "name";
            this.dataColumn18.ColumnName = "parentid";
            this.dataColumn18.DataType = typeof(int);
            this.dataColumn19.ColumnName = "comment";
            this.dataColumn25.ColumnName = "isactive";
            this.dataColumn25.DataType = typeof(bool);
            this.dataColumn28.ColumnName = "_image";
            this.dataColumn28.DataType = typeof(int);
            this.dataColumn28.DefaultValue = (object)0;
            this.table_signgroup.Columns.AddRange(new DataColumn[6]
      {
        this.dataColumn20,
        this.dataColumn21,
        this.dataColumn22,
        this.dataColumn23,
        this.dataColumn24,
        this.dataColumn29
      });
            this.table_signgroup.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idsigngroup"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("rel_signgroup", "signgroup", new string[1]
        {
          "idsigngroup"
        }, new string[1]
        {
          "parentid"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_signgroup.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn20
      };
            this.table_signgroup.TableName = "signgroup";
            this.dataColumn20.AllowDBNull = false;
            this.dataColumn20.ColumnName = "idsigngroup";
            this.dataColumn20.DataType = typeof(int);
            this.dataColumn21.ColumnName = "name";
            this.dataColumn22.ColumnName = "comment";
            this.dataColumn23.ColumnName = "parentid";
            this.dataColumn23.DataType = typeof(int);
            this.dataColumn24.ColumnName = "isactive";
            this.dataColumn24.DataType = typeof(bool);
            this.dataColumn29.ColumnName = "_image";
            this.dataColumn29.DataType = typeof(int);
            this.dataColumn29.DefaultValue = (object)0;
            this.table_sign.Columns.AddRange(new DataColumn[4]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn27
      });
            this.table_sign.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idsign"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("rel_sign_signgroup", "signgroup", new string[1]
        {
          "idsigngroup"
        }, new string[1]
        {
          "idsigngroup"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_sign.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_sign.TableName = "sign";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idsign";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn27.ColumnName = "idsigngroup";
            this.dataColumn27.DataType = typeof(int);
            this.table_signvalue.Columns.AddRange(new DataColumn[5]
      {
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8
      });
            this.table_signvalue.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idsignvalue"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("Relation1", "sign", new string[1]
        {
          "idsign"
        }, new string[1]
        {
          "idsign"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_signvalue.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn4
      };
            this.table_signvalue.TableName = "signvalue";
            this.dataColumn4.AllowDBNull = false;
            this.dataColumn4.ColumnName = "idsignvalue";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "idsign";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "intvalue";
            this.dataColumn6.DataType = typeof(double);
            this.dataColumn7.ColumnName = "strvalue";
            this.dataColumn8.ColumnName = "comment";
            this.table_diraction.Columns.AddRange(new DataColumn[9]
      {
        this.dataColumn9,
        this.dataColumn10,
        this.dataColumn11,
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14,
        this.dataColumn15,
        this.dataColumn26,
        this.dataColumn30
      });
            this.table_diraction.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "iddiraction"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("rel_diraction_diractiongroup", "diractiongroup", new string[1]
        {
          "iddiractiongroup"
        }, new string[1]
        {
          "iddiractiongroup"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_diraction.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn9
      };
            this.table_diraction.TableName = "diraction";
            this.dataColumn9.AllowDBNull = false;
            this.dataColumn9.ColumnName = "iddiraction";
            this.dataColumn9.DataType = typeof(int);
            this.dataColumn10.ColumnName = "name";
            this.dataColumn11.ColumnName = "comment";
            this.dataColumn12.ColumnName = "numpos";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.ColumnName = "autosave";
            this.dataColumn13.DataType = typeof(bool);
            this.dataColumn13.DefaultValue = (object)false;
            this.dataColumn14.ColumnName = "duration";
            this.dataColumn14.DataType = typeof(int);
            this.dataColumn15.ColumnName = "autosave2";
            this.dataColumn15.DataType = typeof(bool);
            this.dataColumn15.DefaultValue = (object)false;
            this.dataColumn26.ColumnName = "iddiractiongroup";
            this.dataColumn26.DataType = typeof(int);
            this.gridViewSign.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSign.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSign.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSign.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewSign.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewSign.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewSign.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewSign.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSign.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSign.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewSign.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSign.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSign.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSign.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewSign.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewSign.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewSign.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewSign.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSign.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSign.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSign.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewSign.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewSign.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewSign.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewSign.BorderStyle = BorderStyles.Simple;
            this.gridViewSign.Columns.AddRange(new GridColumn[4]
      {
        this.colidsign,
        this.colname,
        this.colcomment,
        this.colidsigngroup
      });
            this.gridViewSign.GridControl = this.gridControlSign;
            this.gridViewSign.GroupPanelText = "Панель группировки";
            this.gridViewSign.Name = "gridViewSign";
            this.gridViewSign.OptionsCustomization.AllowFilter = false;
            this.gridViewSign.OptionsDetail.ShowDetailTabs = false;
            this.gridViewSign.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewSign.OptionsSelection.MultiSelect = true;
            this.gridViewSign.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewSign.OptionsView.ShowGroupPanel = false;
            this.gridViewSign.OptionsView.ShowIndicator = false;
            this.colidsign.Caption = "#";
            this.colidsign.FieldName = "idsign";
            this.colidsign.Name = "colidsign";
            this.colidsign.OptionsColumn.AllowEdit = false;
            this.colidsign.Visible = true;
            this.colidsign.VisibleIndex = 0;
            this.colidsign.Width = 61;
            this.colname.Caption = "Признак";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 298;
            this.colcomment.Caption = "Описание";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 2;
            this.colcomment.Width = 302;
            this.colidsigngroup.Caption = "idsigngroup";
            this.colidsigngroup.FieldName = "idsigngroup";
            this.colidsigngroup.Name = "colidsigngroup";
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(907, 33);
            this.panel1.TabIndex = 1;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(820, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(739, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(658, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.TabControl.BorderStyle = BorderStyles.Simple;
            this.TabControl.Dock = DockStyle.Fill;
            this.TabControl.Location = new Point(0, 0);
            this.TabControl.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.TabControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.TabPageSign;
            this.TabControl.Size = new Size(907, 418);
            this.TabControl.TabIndex = 2;
            this.TabControl.TabPages.AddRange(new XtraTabPage[2]
      {
        this.TabPageSign,
        this.TabPageDiraction
      });
            this.TabPageSign.Controls.Add((Control)this.gridControlSign);
            this.TabPageSign.Controls.Add((Control)this.splitterControl1);
            this.TabPageSign.Controls.Add((Control)this.treeListSignGroup);
            this.TabPageSign.Name = "TabPageSign";
            this.TabPageSign.Size = new Size(905, 394);
            this.TabPageSign.Text = "Признаки";
            this.splitterControl1.Location = new Point(236, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 394);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            this.treeListSignGroup.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListSignGroup.Appearance.FocusedCell.ForeColor = Color.Black;
            this.treeListSignGroup.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeListSignGroup.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeListSignGroup.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListSignGroup.Appearance.FocusedRow.ForeColor = Color.Black;
            this.treeListSignGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeListSignGroup.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeListSignGroup.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListSignGroup.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListSignGroup.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.treeListSignGroup.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeListSignGroup.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeListSignGroup.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListSignGroup.Appearance.SelectedRow.ForeColor = Color.Black;
            this.treeListSignGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeListSignGroup.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeListSignGroup.BorderStyle = BorderStyles.Simple;
            this.treeListSignGroup.Columns.AddRange(new TreeListColumn[2]
      {
        this.treeListColumn1,
        this.treeListColumn2
      });
            this.treeListSignGroup.ContextMenuStrip = this.MenuGroup;
            this.treeListSignGroup.DataMember = "signgroup";
            this.treeListSignGroup.DataSource = (object)this.ds;
            this.treeListSignGroup.Dock = DockStyle.Left;
            this.treeListSignGroup.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeListSignGroup.ImageIndexFieldName = "_image";
            this.treeListSignGroup.KeyFieldName = "idsigngroup";
            this.treeListSignGroup.Location = new Point(0, 0);
            this.treeListSignGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListSignGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListSignGroup.Name = "treeListSignGroup";
            this.treeListSignGroup.OptionsView.ShowHorzLines = false;
            this.treeListSignGroup.OptionsView.ShowIndicator = false;
            this.treeListSignGroup.OptionsView.ShowVertLines = false;
            this.treeListSignGroup.ParentFieldName = "parentid";
            this.treeListSignGroup.SelectImageList = (object)this.imageList1;
            this.treeListSignGroup.Size = new Size(236, 394);
            this.treeListSignGroup.TabIndex = 3;
            this.treeListColumn1.Caption = "Группа признаков";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 27;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 136;
            this.treeListColumn2.Caption = "Активность";
            this.treeListColumn2.FieldName = "isactive";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 98;
            this.MenuGroup.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.MenuGroupAddMain,
        (ToolStripItem) this.MenuGroupAddChild,
        (ToolStripItem) this.MenuGroupRename,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.MenuGroupRemove,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.MenuGroupMove,
        (ToolStripItem) this.MenuGroupSetMain
      });
            this.MenuGroup.Name = "contextMenuStrip3";
            this.MenuGroup.Size = new Size(298, 148);
            this.MenuGroupAddMain.Name = "MenuGroupAddMain";
            this.MenuGroupAddMain.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuGroupAddMain.Size = new Size(297, 22);
            this.MenuGroupAddMain.Text = "Добавить основную группу";
            this.MenuGroupAddChild.Name = "MenuGroupAddChild";
            this.MenuGroupAddChild.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuGroupAddChild.Size = new Size(297, 22);
            this.MenuGroupAddChild.Text = "Добавить дочернюю группу";
            this.MenuGroupRename.Name = "MenuGroupRename";
            this.MenuGroupRename.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuGroupRename.Size = new Size(297, 22);
            this.MenuGroupRename.Text = "Переименовать";
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(294, 6);
            this.MenuGroupRemove.Name = "MenuGroupRemove";
            this.MenuGroupRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuGroupRemove.Size = new Size(297, 22);
            this.MenuGroupRemove.Text = "Удалить";
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new Size(294, 6);
            this.MenuGroupMove.Name = "MenuGroupMove";
            this.MenuGroupMove.ShortcutKeys = Keys.F6;
            this.MenuGroupMove.Size = new Size(297, 22);
            this.MenuGroupMove.Text = "Переместить в группу";
            this.MenuGroupSetMain.Name = "MenuGroupSetMain";
            this.MenuGroupSetMain.ShortcutKeys = Keys.M | Keys.Shift | Keys.Control;
            this.MenuGroupSetMain.Size = new Size(297, 22);
            this.MenuGroupSetMain.Text = "Сделать группу основной";
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.TabPageDiraction.Controls.Add((Control)this.gridControlDiraction);
            this.TabPageDiraction.Controls.Add((Control)this.splitterControl2);
            this.TabPageDiraction.Controls.Add((Control)this.treeListDiractionGroup);
            this.TabPageDiraction.Name = "TabPageDiraction";
            this.TabPageDiraction.Size = new Size(905, 394);
            this.TabPageDiraction.Text = "Этапы";
            this.gridControlDiraction.ContextMenuStrip = this.MenuStripDiraction;
            this.gridControlDiraction.DataMember = "diractiongroup.rel_diraction_diractiongroup";
            this.gridControlDiraction.DataSource = (object)this.ds;
            this.gridControlDiraction.Dock = DockStyle.Fill;
            this.gridControlDiraction.EmbeddedNavigator.Name = "";
            this.gridControlDiraction.Location = new Point(217, 0);
            this.gridControlDiraction.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlDiraction.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlDiraction.MainView = (BaseView)this.gridViewDiraction;
            this.gridControlDiraction.Name = "gridControlDiraction";
            this.gridControlDiraction.Size = new Size(688, 394);
            this.gridControlDiraction.TabIndex = 3;
            this.gridControlDiraction.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewDiraction
      });
            this.MenuStripDiraction.Items.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.toolStripMenuItem4,
        (ToolStripItem) this.toolStripMenuItem5,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripMenuItem6,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.toolStripMenuItem17
      });
            this.MenuStripDiraction.Name = "contextMenuStrip1";
            this.MenuStripDiraction.Size = new Size(220, 104);
            this.toolStripMenuItem4.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItem4.Size = new Size(219, 22);
            this.toolStripMenuItem4.Text = "Добавить";
            this.toolStripMenuItem4.Click += new EventHandler(this.toolStripMenuItem4_Click);
            this.toolStripMenuItem5.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItem5.Size = new Size(219, 22);
            this.toolStripMenuItem5.Text = "Дублировать";
            this.toolStripMenuItem5.Click += new EventHandler(this.toolStripMenuItem5_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(216, 6);
            this.toolStripMenuItem6.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItem6.Size = new Size(219, 22);
            this.toolStripMenuItem6.Text = "Удалить";
            this.toolStripMenuItem6.Click += new EventHandler(this.toolStripMenuItem6_Click);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new Size(216, 6);
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new Size(219, 22);
            this.toolStripMenuItem17.Text = "Переместить в группу...";
            this.toolStripMenuItem17.Click += new EventHandler(this.toolStripMenuItem17_Click);
            this.gridViewDiraction.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewDiraction.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDiraction.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewDiraction.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewDiraction.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewDiraction.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewDiraction.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewDiraction.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewDiraction.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewDiraction.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDiraction.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewDiraction.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDiraction.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewDiraction.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewDiraction.BorderStyle = BorderStyles.Simple;
            this.gridViewDiraction.Columns.AddRange(new GridColumn[9]
      {
        this.coliddiraction,
        this.colname1,
        this.colcomment2,
        this.colnumpos,
        this.colautosave,
        this.colduration,
        this.colautosave2,
        this.coliddiractiongroup,
        this.coladdtooptimdoc
      });
            this.gridViewDiraction.GridControl = this.gridControlDiraction;
            this.gridViewDiraction.GroupPanelText = "Панель группировки";
            this.gridViewDiraction.Name = "gridViewDiraction";
            this.gridViewDiraction.OptionsCustomization.AllowFilter = false;
            this.gridViewDiraction.OptionsDetail.ShowDetailTabs = false;
            this.gridViewDiraction.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewDiraction.OptionsSelection.MultiSelect = true;
            this.gridViewDiraction.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewDiraction.OptionsView.ShowGroupPanel = false;
            this.gridViewDiraction.OptionsView.ShowIndicator = false;
            this.coliddiraction.Caption = "#";
            this.coliddiraction.FieldName = "iddiraction";
            this.coliddiraction.Name = "coliddiraction";
            this.coliddiraction.OptionsColumn.AllowEdit = false;
            this.coliddiraction.Visible = true;
            this.coliddiraction.VisibleIndex = 0;
            this.coliddiraction.Width = 30;
            this.colname1.Caption = "Наименование";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 2;
            this.colname1.Width = 204;
            this.colcomment2.Caption = "Описание";
            this.colcomment2.FieldName = "comment";
            this.colcomment2.Name = "colcomment2";
            this.colcomment2.Visible = true;
            this.colcomment2.VisibleIndex = 6;
            this.colcomment2.Width = 136;
            this.colnumpos.Caption = "№пп";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 1;
            this.colnumpos.Width = 55;
            this.colautosave.Caption = "Добавлять в заказы";
            this.colautosave.FieldName = "autosave";
            this.colautosave.Name = "colautosave";
            this.colautosave.Visible = true;
            this.colautosave.VisibleIndex = 3;
            this.colautosave.Width = 83;
            this.colduration.Caption = "Продолжительность";
            this.colduration.FieldName = "duration";
            this.colduration.Name = "colduration";
            this.colduration.Visible = true;
            this.colduration.VisibleIndex = 5;
            this.colduration.Width = 88;
            this.colautosave2.Caption = "Добавлять в задания";
            this.colautosave2.FieldName = "autosave2";
            this.colautosave2.Name = "colautosave2";
            this.colautosave2.Visible = true;
            this.colautosave2.VisibleIndex = 4;
            this.colautosave2.Width = 88;
            this.coliddiractiongroup.Caption = "iddiractiongroup";
            this.coliddiractiongroup.FieldName = "iddiractiongroup";
            this.coliddiractiongroup.Name = "coliddiractiongroup";
            this.splitterControl2.Location = new Point(211, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new Size(6, 394);
            this.splitterControl2.TabIndex = 5;
            this.splitterControl2.TabStop = false;
            this.treeListDiractionGroup.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListDiractionGroup.Appearance.FocusedCell.ForeColor = Color.Black;
            this.treeListDiractionGroup.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeListDiractionGroup.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeListDiractionGroup.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListDiractionGroup.Appearance.FocusedRow.ForeColor = Color.Black;
            this.treeListDiractionGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeListDiractionGroup.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeListDiractionGroup.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListDiractionGroup.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListDiractionGroup.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.treeListDiractionGroup.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeListDiractionGroup.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeListDiractionGroup.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListDiractionGroup.Appearance.SelectedRow.ForeColor = Color.Black;
            this.treeListDiractionGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeListDiractionGroup.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeListDiractionGroup.BorderStyle = BorderStyles.Simple;
            this.treeListDiractionGroup.Columns.AddRange(new TreeListColumn[2]
      {
        this.treeListColumn3,
        this.treeListColumn4
      });
            this.treeListDiractionGroup.ContextMenuStrip = this.MenuGroup;
            this.treeListDiractionGroup.DataMember = "diractiongroup";
            this.treeListDiractionGroup.DataSource = (object)this.ds;
            this.treeListDiractionGroup.Dock = DockStyle.Left;
            this.treeListDiractionGroup.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeListDiractionGroup.ImageIndexFieldName = "_image";
            this.treeListDiractionGroup.KeyFieldName = "iddiractiongroup";
            this.treeListDiractionGroup.Location = new Point(0, 0);
            this.treeListDiractionGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListDiractionGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListDiractionGroup.Name = "treeListDiractionGroup";
            this.treeListDiractionGroup.OptionsView.ShowHorzLines = false;
            this.treeListDiractionGroup.OptionsView.ShowIndicator = false;
            this.treeListDiractionGroup.OptionsView.ShowVertLines = false;
            this.treeListDiractionGroup.ParentFieldName = "parentid";
            this.treeListDiractionGroup.SelectImageList = (object)this.imageList1;
            this.treeListDiractionGroup.Size = new Size(211, 394);
            this.treeListDiractionGroup.TabIndex = 4;
            this.treeListColumn3.Caption = "Группа этапов";
            this.treeListColumn3.FieldName = "name";
            this.treeListColumn3.MinWidth = 27;
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.OptionsColumn.AllowEdit = false;
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 0;
            this.treeListColumn3.Width = 124;
            this.treeListColumn4.Caption = "Активность";
            this.treeListColumn4.FieldName = "isactive";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 1;
            this.treeListColumn4.Width = 85;
            this.dataColumn30.ColumnName = "addtooptimdoc";
            this.dataColumn30.DataType = typeof(bool);
            this.dataColumn30.DefaultValue = (object)false;
            this.coladdtooptimdoc.Caption = "Добавлять в док. оптимизации";
            this.coladdtooptimdoc.FieldName = "addtooptimdoc";
            this.coladdtooptimdoc.Name = "coladdtooptimdoc";
            this.coladdtooptimdoc.Visible = true;
            this.coladdtooptimdoc.VisibleIndex = 7;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.TabControl);
            this.Controls.Add((Control)this.panel1);
            this.Name = "SignDirForm";
            this.Size = new Size(907, 451);
            this.Text = "Признаки и этапы";
            this.gridViewSignValue.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.gridControlSign.EndInit();
            this.MenuItemSign.ResumeLayout(false);
            this.ds.EndInit();
            this.table_diractiongroup.EndInit();
            this.table_signgroup.EndInit();
            this.table_sign.EndInit();
            this.table_signvalue.EndInit();
            this.table_diraction.EndInit();
            this.gridViewSign.EndInit();
            this.panel1.ResumeLayout(false);
            this.TabControl.EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPageSign.ResumeLayout(false);
            this.treeListSignGroup.EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.TabPageDiraction.ResumeLayout(false);
            this.gridControlDiraction.EndInit();
            this.MenuStripDiraction.ResumeLayout(false);
            this.gridViewDiraction.EndInit();
            this.treeListDiractionGroup.EndInit();
            this.ResumeLayout(false);
        }

        private void SignDirForm_Shown(object sender, EventArgs e)
        {
            this.treeListSignGroup.MoveLastVisible();
            this.treeListSignGroup.MoveFirst();
            this.treeListDiractionGroup.MoveLastVisible();
            this.treeListDiractionGroup.MoveFirst();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            this.MoveGroup = (DataRow)null;
            this.MoveItems = (DataRow[])null;
            this.Cursor = Cursors.Default;
        }

        private void treeList2_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.saved)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListDiractionGroup);
            if (selectedNode == null)
                return;
            if (this.MoveItems != null)
            {
                foreach (DataRow dataRow in this.MoveItems)
                    dataRow["iddiractiongroup"] = selectedNode["iddiractiongroup"];
                this.MoveItems = (DataRow[])null;
                this.Cursor = Cursors.Default;
            }
            if (this.MoveGroup == null)
                return;
            this.MoveGroup["parentid"] = selectedNode["iddiractiongroup"];
            this.MoveGroup = (DataRow)null;
            this.Cursor = Cursors.Default;
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.saved)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListSignGroup);
            if (selectedNode == null)
                return;
            if (this.MoveItems != null)
            {
                foreach (DataRow dataRow in this.MoveItems)
                    dataRow["idsigngroup"] = selectedNode["idsigngroup"];
                this.MoveItems = (DataRow[])null;
                this.Cursor = Cursors.Default;
            }
            if (this.MoveGroup == null)
                return;
            this.MoveGroup["parentid"] = selectedNode["idsigngroup"];
            this.MoveGroup = (DataRow)null;
            this.Cursor = Cursors.Default;
        }

        private void SignDirForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) <= 0)
                return;
            switch (MessageBox.Show("Сохранить изменения?", "Закрытие формы признаков и этапов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.OK:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        public override void LoadFromBase()
        {
            this.saved = true;
            this.db.command.CommandText = "select * from signgroup where deleted is null";
            this.db.adapter.Fill(this.table_signgroup);
            this.db.command.CommandText = "select * from diractiongroup where deleted is null";
            this.db.adapter.Fill(this.table_diractiongroup);
            this.db.command.CommandText = "select * from sign where deleted is null";
            this.db.adapter.Fill(this.table_sign);
            this.db.command.CommandText = "select * from signvalue where deleted is null";
            this.db.adapter.Fill(this.table_signvalue);
            this.db.command.CommandText = "select * from diraction where deleted is null";
            this.db.adapter.Fill(this.table_diraction);
            this.saved = false;
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDataSet(this.ds))
                return false;
            this.ds.AcceptChanges();
            return true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListSignGroup);
            if (selectedNode == null)
                return;
            DataRow row = this.table_sign.NewRow();
            row["idsign"] = (object)dbconn.GetGenId("gen_sign");
            row["name"] = (object)"Новый признак";
            row["idsigngroup"] = selectedNode["idsigngroup"];
            this.table_sign.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlSign);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = AtDataSet.dublicate(dataRow1);
            dataRow2["idsign"] = (object)dbconn.GetGenId("gen_sign");
            int count = this.table_signvalue.Rows.Count;
            for (int index = 0; index < count; ++index)
            {
                DataRow source = this.table_signvalue.Rows[index];
                if ((int)source["idsign"] == (int)dataRow1["idsign"])
                {
                    DataRow dataRow3 = AtDataSet.dublicate(source);
                    dataRow3["idsignvalue"] = (object)dbconn.GetGenId("gen_signvalue");
                    dataRow3["idsign"] = dataRow2["idsign"];
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlSign);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlSign);
            if (dataRow == null)
                return;
            DataRow row = this.table_signvalue.NewRow();
            row["idsignvalue"] = (object)dbconn.GetGenId("gen_signvalue");
            row["idsign"] = dataRow["idsign"];
            row["intvalue"] = (object)0;
            row["strvalue"] = (object)"Новое значение";
            this.table_signvalue.Rows.Add(row);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            this.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlSign);
            if (this.MoveItems != null && this.MoveItems.Length == 0)
            {
                this.MoveItems = (DataRow[])null;
            }
            else
            {
                this.Cursor = Cursors.Hand;
                this.treeListSignGroup.Focus();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListDiractionGroup);
            if (selectedNode == null)
                return;
            DataRow row = this.table_diraction.NewRow();
            row["iddiraction"] = (object)dbconn.GetGenId("gen_diraction");
            row["iddiractiongroup"] = selectedNode["iddiractiongroup"];
            row["name"] = (object)"Новый этап";
            row["autosave"] = (object)false;
            row["autosave2"] = (object)false;
            this.table_diraction.Rows.Add(row);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlDiraction);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["iddiraction"] = (object)dbconn.GetGenId("gen_diraction");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlDiraction);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            this.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlDiraction);
            if (this.MoveItems != null && this.MoveItems.Length == 0)
            {
                this.MoveItems = (DataRow[])null;
            }
            else
            {
                this.Cursor = Cursors.Hand;
                this.treeListDiractionGroup.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.saved = true;
            DataRow selectedNode1 = AtTreeList.GetSelectedNode(this.treeListSignGroup);
            DataRow selectedNode2 = AtTreeList.GetSelectedNode(this.treeListDiractionGroup);
            int idgroup1 = selectedNode1 == null ? 0 : Useful.GetInt32(selectedNode1["idsigngroup"]);
            int idgroup2 = selectedNode2 == null ? 0 : Useful.GetInt32(selectedNode2["iddiractiongroup"]);
            this.treeListDiractionGroup.Enabled = false;
            this.treeListSignGroup.Enabled = false;
            this.treeListSignGroup.ClearNodes();
            this.treeListDiractionGroup.ClearNodes();
            this.ds.Clear();
            this.LoadFromBase();
            if (selectedNode1 != null)
                AtTreeList.SelectNode(this.treeListSignGroup, "idsigngroup", idgroup1);
            if (selectedNode2 != null)
                AtTreeList.SelectNode(this.treeListDiractionGroup, "iddiractiongroup", idgroup2);
            this.treeListDiractionGroup.Enabled = true;
            this.treeListSignGroup.Enabled = true;
            this.saved = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuGroupAddMain_Click(object sender, EventArgs e)
        {
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", "") == DialogResult.Cancel)
                return;
            DataRow row;
            if (this.TabControl.SelectedTabPage == this.TabPageSign)
            {
                row = this.table_signgroup.NewRow();
                row["idsigngroup"] = (object)dbconn.GetGenId("gen_signgroup");
                this.table_signgroup.Rows.Add(row);
            }
            else
            {
                row = this.table_diractiongroup.NewRow();
                row["iddiractiongroup"] = (object)dbconn.GetGenId("gen_diractiongroup");
                this.table_diractiongroup.Rows.Add(row);
            }
            row["name"] = (object)InputBox.Value;
            row["isactive"] = (object)1;
        }

        private void MenuGroupAddChild_Click(object sender, EventArgs e)
        {
            DataRow dataRow = this.TabControl.SelectedTabPage != this.TabPageSign ? AtTreeList.GetSelectedNode(this.treeListDiractionGroup) : AtTreeList.GetSelectedNode(this.treeListSignGroup);
            if (dataRow == null || InputBox.ShowDialog("Создание дочерней группы", "Введите имя", dataRow["name"].ToString()) == DialogResult.Cancel)
                return;
            DataRow row;
            if (this.TabControl.SelectedTabPage == this.TabPageSign)
            {
                row = this.table_signgroup.NewRow();
                row["idsigngroup"] = (object)dbconn.GetGenId("gen_signgroup");
                row["parentid"] = dataRow["idsigngroup"];
                this.table_signgroup.Rows.Add(row);
            }
            else
            {
                row = this.table_diractiongroup.NewRow();
                row["iddiractiongroup"] = (object)dbconn.GetGenId("gen_diractiongroup");
                row["parentid"] = dataRow["iddiractiongroup"];
                this.table_diractiongroup.Rows.Add(row);
            }
            row["name"] = (object)InputBox.Value;
            row["isactive"] = (object)1;
        }

        private void MenuGroupRename_Click(object sender, EventArgs e)
        {
            DataRow dataRow = this.TabControl.SelectedTabPage != this.TabPageSign ? AtTreeList.GetSelectedNode(this.treeListDiractionGroup) : AtTreeList.GetSelectedNode(this.treeListSignGroup);
            if (dataRow == null || InputBox.ShowDialog("Изменить имя", "Введите новое имя", dataRow["name"].ToString()) == DialogResult.Cancel)
                return;
            dataRow["name"] = (object)InputBox.Value;
        }

        private void MenuGroupRemove_Click(object sender, EventArgs e)
        {
            string[] strArray = new string[2]
      {
        "rel_signgroup",
        "rel_diractiongroup"
      };
            DataRow dataRow = this.TabControl.SelectedTabPage != this.TabPageSign ? AtTreeList.GetSelectedNode(this.treeListDiractionGroup) : AtTreeList.GetSelectedNode(this.treeListSignGroup);
            if (dataRow == null || dataRow.GetChildRows(strArray[this.TabControl.SelectedTabPageIndex]).Length != 0 && MessageBox.Show("В удаляемой группе есть вложенные подгруппы!\nУдалить группу вместе с вложениями?", "Удаление группы", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            dataRow.Delete();
        }

        private void MenuGroupMove_Click(object sender, EventArgs e)
        {
            this.MoveGroup = this.TabControl.SelectedTabPage != this.TabPageSign ? AtTreeList.GetSelectedNode(this.treeListDiractionGroup) : AtTreeList.GetSelectedNode(this.treeListSignGroup);
            if (this.MoveGroup == null)
                return;
            this.Cursor = Cursors.Hand;
        }

        private void MenuGroupSetMain_Click(object sender, EventArgs e)
        {
            DataRow dataRow = this.TabControl.SelectedTabPage != this.TabPageSign ? AtTreeList.GetSelectedNode(this.treeListDiractionGroup) : AtTreeList.GetSelectedNode(this.treeListSignGroup);
            if (dataRow == null)
                return;
            dataRow["parentid"] = (object)DBNull.Value;
        }
    }
}
