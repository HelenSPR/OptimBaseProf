// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.PriceChangeListForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad;
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
    public class PriceChangeListForm : AtUserControl
    {
        private IContainer components;
        private Panel panel2;
        private Button button4;
        private Button button5;
        private GridView gridViewPriceChange;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit2;
        private ds_pricechange ds;
        private GridColumn colidpricechange;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colpricechange_type;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripMenuItem MenuItemDublicate;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemRemove;
        private Button button1;
        private Panel panel1;
        public GridControl gridControlPriceChange;
        private GridColumn colfororder_typ;
        private RepositoryItemComboBox repositoryItemComboBox2;
        private GridColumn colisperc;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private TreeList treeListPriceChangeGroup;
        private TreeListColumn treeListColumn1;
        private SplitterControl splitterControl1;
        private ImageList imageList1;
        private ContextMenuStrip MenuGroup;
        private ToolStripMenuItem MenuGroupAddMain;
        private ToolStripMenuItem MenuGroupAddChild;
        private ToolStripMenuItem MenuGroupEdit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuGroupRemove;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MenuItemMoveToGroup;
        private TreeListColumn treeListColumn2;
        private RepositoryItemCheckEdit repositoryItemCheckEdit2;
        public Button button2;
        public Button button6;
        private GridColumn coldefaultvalue;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MenuGroupMoveToGroup;
        private ToolStripMenuItem MenuGroupSetMain;
        private GridColumn colfororder;
        private GridColumn colindealerbase;
        private GridColumn colvisibledealer;
        private BindingSource bsPriceChangeGroup;
        private BindingSource bsPriceChange;
        private GridColumn colnumpos;
        private DataRow[] MoveItems;
        private DataRow MoveGroup;
        private bool isOrder;
        private bool isAll;
        private bool DisableEvent;

        private ds_pricechange.pricechangegroupRow SelectedGroup
        {
            get
            {
                return (ds_pricechange.pricechangegroupRow)AtTreeList.GetSelectedNode(this.treeListPriceChangeGroup);
            }
        }

        private int IDSelectedGroup
        {
            get
            {
                ds_pricechange.pricechangegroupRow selectedGroup = this.SelectedGroup;
                if (selectedGroup == null)
                    return 0;
                return selectedGroup.idpricechangegroup;
            }
        }

        public PriceChangeListForm()
        {
            this.InitializeComponent();
            this.FormClosing += new FormClosing(this.PriceChangeListForm_FormClosing);
            this.gridControlPriceChange.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
            this.gridControlPriceChange.KeyDown += new KeyEventHandler(this.gridControl1_KeyDown);
            this.treeListPriceChangeGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.Shown += new Shown(this.PriceChangeListForm_Shown);
            this.MenuGroupAddMain.Click += new EventHandler(this.MenuGroupAddMain_Click);
            this.MenuGroupAddChild.Click += new EventHandler(this.MenuGroupAddChild_Click);
            this.MenuGroupEdit.Click += new EventHandler(this.MenuGroupEdit_Click);
            this.MenuGroupRemove.Click += new EventHandler(this.MenuGroupRemove_Click);
            this.MenuGroupMoveToGroup.Click += new EventHandler(this.MenuGroupMoveToGroup_Click);
            this.MenuGroupSetMain.Click += new EventHandler(this.MenuGroupSetMain_Click);
            this.MenuItemAdd.Click += new EventHandler(this.MenuItemAdd_Click);
            this.MenuItemDublicate.Click += new EventHandler(this.MenuItemDublicate_Click);
            this.MenuItemMoveToGroup.Click += new EventHandler(this.MenuItemMoveToGroup_Click);
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            if (Settings.isDealer)
                this.bsPriceChange.Filter = "isnull(visibledealer,true) = true";
            else
                this.bsPriceChange.Filter = "";
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PriceChangeListForm));
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button1 = new Button();
            this.button5 = new Button();
            this.gridControlPriceChange = new GridControl();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.MenuItemAdd = new ToolStripMenuItem();
            this.MenuItemDublicate = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.MenuItemMoveToGroup = new ToolStripMenuItem();
            this.bsPriceChange = new BindingSource(this.components);
            this.bsPriceChangeGroup = new BindingSource(this.components);
            this.ds = new ds_pricechange();
            this.gridViewPriceChange = new GridView();
            this.colidpricechange = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colpricechange_type = new GridColumn();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.colfororder_typ = new GridColumn();
            this.repositoryItemComboBox2 = new RepositoryItemComboBox();
            this.colisperc = new GridColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.coldefaultvalue = new GridColumn();
            this.colfororder = new GridColumn();
            this.colindealerbase = new GridColumn();
            this.colvisibledealer = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new AtRepositoryItemTextEdit();
            this.panel1 = new Panel();
            this.button2 = new Button();
            this.button6 = new Button();
            this.treeListPriceChangeGroup = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.treeListColumn2 = new TreeListColumn();
            this.repositoryItemCheckEdit2 = new RepositoryItemCheckEdit();
            this.MenuGroup = new ContextMenuStrip(this.components);
            this.MenuGroupAddMain = new ToolStripMenuItem();
            this.MenuGroupAddChild = new ToolStripMenuItem();
            this.MenuGroupEdit = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuGroupRemove = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.MenuGroupMoveToGroup = new ToolStripMenuItem();
            this.MenuGroupSetMain = new ToolStripMenuItem();
            this.imageList1 = new ImageList(this.components);
            this.splitterControl1 = new SplitterControl();
            this.colnumpos = new GridColumn();
            this.panel2.SuspendLayout();
            this.gridControlPriceChange.BeginInit();
            this.MenuItem.SuspendLayout();
            ((ISupportInitialize)this.bsPriceChange).BeginInit();
            ((ISupportInitialize)this.bsPriceChangeGroup).BeginInit();
            this.ds.BeginInit();
            this.gridViewPriceChange.BeginInit();
            this.repositoryItemComboBox1.BeginInit();
            this.repositoryItemComboBox2.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemTextEdit2.BeginInit();
            this.panel1.SuspendLayout();
            this.treeListPriceChangeGroup.BeginInit();
            this.repositoryItemCheckEdit2.BeginInit();
            this.MenuGroup.SuspendLayout();
            this.SuspendLayout();
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button1);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(796, 33);
            this.panel2.TabIndex = 7;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(628, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отменить";
            this.button4.Click += new EventHandler(this.button4_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(547, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(709, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Закрыть";
            this.button5.Click += new EventHandler(this.button5_Click);
            this.gridControlPriceChange.ContextMenuStrip = this.MenuItem;
            this.gridControlPriceChange.DataSource = (object)this.bsPriceChange;
            this.gridControlPriceChange.Dock = DockStyle.Fill;
            this.gridControlPriceChange.EmbeddedNavigator.Name = "";
            this.gridControlPriceChange.Location = new Point(284, 0);
            this.gridControlPriceChange.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlPriceChange.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlPriceChange.MainView = (BaseView)this.gridViewPriceChange;
            this.gridControlPriceChange.Name = "gridControlPriceChange";
            this.gridControlPriceChange.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemTextEdit2,
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.repositoryItemComboBox2,
        (RepositoryItem) this.repositoryItemCheckEdit1
      });
            this.gridControlPriceChange.Size = new Size(512, 439);
            this.gridControlPriceChange.TabIndex = 8;
            this.gridControlPriceChange.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewPriceChange
      });
            this.MenuItem.Items.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.MenuItemDublicate,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemRemove,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.MenuItemMoveToGroup
      });
            this.MenuItem.Name = "contextMenuStrip1";
            this.MenuItem.Size = new Size(219, 104);
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuItemAdd.Size = new Size(218, 22);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemDublicate.Name = "MenuItemDublicate";
            this.MenuItemDublicate.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.MenuItemDublicate.Size = new Size(218, 22);
            this.MenuItemDublicate.Text = "Дублировать";
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(215, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(218, 22);
            this.MenuItemRemove.Text = "Удалить";
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(215, 6);
            this.MenuItemMoveToGroup.Name = "MenuItemMoveToGroup";
            this.MenuItemMoveToGroup.ShortcutKeys = Keys.F6;
            this.MenuItemMoveToGroup.Size = new Size(218, 22);
            this.MenuItemMoveToGroup.Text = "Переместить в группу...";
            this.bsPriceChange.DataMember = "pricechangegroup_pricechange";
            this.bsPriceChange.DataSource = (object)this.bsPriceChangeGroup;
            this.bsPriceChangeGroup.DataMember = "pricechangegroup";
            this.bsPriceChangeGroup.DataSource = (object)this.ds;
            this.ds.DataSetName = "ds_pricechange";
            this.ds.EnforceConstraints = false;
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridViewPriceChange.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewPriceChange.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewPriceChange.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewPriceChange.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewPriceChange.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewPriceChange.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewPriceChange.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewPriceChange.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewPriceChange.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewPriceChange.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceChange.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewPriceChange.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewPriceChange.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewPriceChange.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPriceChange.BorderStyle = BorderStyles.Simple;
            this.gridViewPriceChange.Columns.AddRange(new GridColumn[11]
      {
        this.colidpricechange,
        this.colnumpos,
        this.colname,
        this.colpricechange_type,
        this.colfororder_typ,
        this.coldefaultvalue,
        this.colisperc,
        this.colindealerbase,
        this.colvisibledealer,
        this.colcomment,
        this.colfororder
      });
            this.gridViewPriceChange.GridControl = this.gridControlPriceChange;
            this.gridViewPriceChange.GroupPanelText = "Панель группировки";
            this.gridViewPriceChange.Name = "gridViewPriceChange";
            this.gridViewPriceChange.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewPriceChange.OptionsCustomization.AllowFilter = false;
            this.gridViewPriceChange.OptionsDetail.ShowDetailTabs = false;
            this.gridViewPriceChange.OptionsSelection.MultiSelect = true;
            this.gridViewPriceChange.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewPriceChange.OptionsView.ShowGroupPanel = false;
            this.gridViewPriceChange.OptionsView.ShowIndicator = false;
            this.colidpricechange.Caption = "#";
            this.colidpricechange.FieldName = "idpricechange";
            this.colidpricechange.Name = "colidpricechange";
            this.colidpricechange.OptionsColumn.AllowEdit = false;
            this.colidpricechange.Visible = true;
            this.colidpricechange.VisibleIndex = 0;
            this.colidpricechange.Width = 49;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 212;
            this.colcomment.Caption = "Описание";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 7;
            this.colcomment.Width = 213;
            this.colpricechange_type.Caption = "Тип";
            this.colpricechange_type.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox1;
            this.colpricechange_type.FieldName = "pricechange_typ";
            this.colpricechange_type.Name = "colpricechange_type";
            this.colpricechange_type.Visible = true;
            this.colpricechange_type.VisibleIndex = 3;
            this.colpricechange_type.Width = 93;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Items.AddRange(new object[2]
      {
        (object) "Скидка",
        (object) "Наценка"
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colfororder_typ.Caption = "Принадлежность";
            this.colfororder_typ.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox2;
            this.colfororder_typ.FieldName = "fororder_typ";
            this.colfororder_typ.Name = "colfororder_typ";
            this.colfororder_typ.Visible = true;
            this.colfororder_typ.VisibleIndex = 4;
            this.colfororder_typ.Width = 144;
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox2.Items.AddRange(new object[2]
      {
        (object) "Заказ",
        (object) "Конструкция"
      });
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.colisperc.Caption = "Только %";
            this.colisperc.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit1;
            this.colisperc.FieldName = "isperc";
            this.colisperc.Name = "colisperc";
            this.colisperc.Visible = true;
            this.colisperc.VisibleIndex = 6;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.coldefaultvalue.Caption = "Значение";
            this.coldefaultvalue.FieldName = "defaultvalue";
            this.coldefaultvalue.Name = "coldefaultvalue";
            this.coldefaultvalue.Visible = true;
            this.coldefaultvalue.VisibleIndex = 5;
            this.colfororder.Caption = "fororder";
            this.colfororder.FieldName = "fororder";
            this.colfororder.Name = "colfororder";
            this.colfororder.OptionsColumn.ShowInCustomizationForm = false;
            this.colindealerbase.Caption = "Переносить дилеру";
            this.colindealerbase.FieldName = "indealerbase";
            this.colindealerbase.Name = "colindealerbase";
            this.colindealerbase.Visible = true;
            this.colindealerbase.VisibleIndex = 7;
            this.colvisibledealer.Caption = "Видимость у дилера";
            this.colvisibledealer.FieldName = "visibledealer";
            this.colvisibledealer.Name = "colvisibledealer";
            this.colvisibledealer.Visible = true;
            this.colvisibledealer.VisibleIndex = 8;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button6);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(796, 33);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.DialogResult = DialogResult.OK;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(628, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выбрать";
            this.button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button6.DialogResult = DialogResult.Cancel;
            this.button6.FlatStyle = FlatStyle.Flat;
            this.button6.Location = new Point(709, 5);
            this.button6.Name = "button6";
            this.button6.Size = new Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Отменить";
            this.treeListPriceChangeGroup.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPriceChangeGroup.Appearance.FocusedCell.ForeColor = Color.Black;
            this.treeListPriceChangeGroup.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeListPriceChangeGroup.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeListPriceChangeGroup.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPriceChangeGroup.Appearance.FocusedRow.ForeColor = Color.Black;
            this.treeListPriceChangeGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeListPriceChangeGroup.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeListPriceChangeGroup.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPriceChangeGroup.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPriceChangeGroup.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.treeListPriceChangeGroup.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeListPriceChangeGroup.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeListPriceChangeGroup.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPriceChangeGroup.Appearance.SelectedRow.ForeColor = Color.Black;
            this.treeListPriceChangeGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeListPriceChangeGroup.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeListPriceChangeGroup.BorderStyle = BorderStyles.Simple;
            this.treeListPriceChangeGroup.Columns.AddRange(new TreeListColumn[2]
      {
        this.treeListColumn1,
        this.treeListColumn2
      });
            this.treeListPriceChangeGroup.ContextMenuStrip = this.MenuGroup;
            this.treeListPriceChangeGroup.DataSource = (object)this.bsPriceChangeGroup;
            this.treeListPriceChangeGroup.Dock = DockStyle.Left;
            this.treeListPriceChangeGroup.ImageIndexFieldName = "_image";
            this.treeListPriceChangeGroup.KeyFieldName = "idpricechangegroup";
            this.treeListPriceChangeGroup.Location = new Point(0, 0);
            this.treeListPriceChangeGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListPriceChangeGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListPriceChangeGroup.Name = "treeListPriceChangeGroup";
            this.treeListPriceChangeGroup.OptionsView.ShowHorzLines = false;
            this.treeListPriceChangeGroup.OptionsView.ShowIndicator = false;
            this.treeListPriceChangeGroup.OptionsView.ShowVertLines = false;
            this.treeListPriceChangeGroup.ParentFieldName = "parentid";
            this.treeListPriceChangeGroup.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemCheckEdit2
      });
            this.treeListPriceChangeGroup.SelectImageList = (object)this.imageList1;
            this.treeListPriceChangeGroup.Size = new Size(278, 439);
            this.treeListPriceChangeGroup.TabIndex = 10;
            this.treeListColumn1.Caption = "Группы скидок и наценок";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 112;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 186;
            this.treeListColumn2.Caption = "Активность";
            this.treeListColumn2.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit2;
            this.treeListColumn2.FieldName = "isactive";
            this.treeListColumn2.Format.FormatType = FormatType.Numeric;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 90;
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = StyleIndeterminate.Unchecked;
            this.MenuGroup.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.MenuGroupAddMain,
        (ToolStripItem) this.MenuGroupAddChild,
        (ToolStripItem) this.MenuGroupEdit,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuGroupRemove,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.MenuGroupMoveToGroup,
        (ToolStripItem) this.MenuGroupSetMain
      });
            this.MenuGroup.Name = "contextMenuStrip2";
            this.MenuGroup.Size = new Size(298, 148);
            this.MenuGroupAddMain.Name = "MenuGroupAddMain";
            this.MenuGroupAddMain.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuGroupAddMain.Size = new Size(297, 22);
            this.MenuGroupAddMain.Text = "Добавить основную группу";
            this.MenuGroupAddChild.Name = "MenuGroupAddChild";
            this.MenuGroupAddChild.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuGroupAddChild.Size = new Size(297, 22);
            this.MenuGroupAddChild.Text = "Добавить дочернюю группу";
            this.MenuGroupEdit.Name = "MenuGroupEdit";
            this.MenuGroupEdit.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuGroupEdit.Size = new Size(297, 22);
            this.MenuGroupEdit.Text = "Переименовать группу";
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(294, 6);
            this.MenuGroupRemove.Name = "MenuGroupRemove";
            this.MenuGroupRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuGroupRemove.Size = new Size(297, 22);
            this.MenuGroupRemove.Text = "Удалить";
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(294, 6);
            this.MenuGroupMoveToGroup.Name = "MenuGroupMoveToGroup";
            this.MenuGroupMoveToGroup.ShortcutKeys = Keys.F6;
            this.MenuGroupMoveToGroup.Size = new Size(297, 22);
            this.MenuGroupMoveToGroup.Text = "Переместить в группу";
            this.MenuGroupSetMain.Name = "MenuGroupSetMain";
            this.MenuGroupSetMain.ShortcutKeys = Keys.M | Keys.Shift | Keys.Control;
            this.MenuGroupSetMain.Size = new Size(297, 22);
            this.MenuGroupSetMain.Text = "Сделать группу основной";
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.splitterControl1.Location = new Point(278, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 439);
            this.splitterControl1.TabIndex = 11;
            this.splitterControl1.TabStop = false;
            this.colnumpos.Caption = "№пп";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 1;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlPriceChange);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeListPriceChangeGroup);
            this.Controls.Add((Control)this.panel1);
            this.Controls.Add((Control)this.panel2);
            this.Name = "PriceChangeListForm";
            this.Size = new Size(796, 505);
            this.Text = "Скидки и наценки";
            this.panel2.ResumeLayout(false);
            this.gridControlPriceChange.EndInit();
            this.MenuItem.ResumeLayout(false);
            ((ISupportInitialize)this.bsPriceChange).EndInit();
            ((ISupportInitialize)this.bsPriceChangeGroup).EndInit();
            this.ds.EndInit();
            this.gridViewPriceChange.EndInit();
            this.repositoryItemComboBox1.EndInit();
            this.repositoryItemComboBox2.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemTextEdit2.EndInit();
            this.panel1.ResumeLayout(false);
            this.treeListPriceChangeGroup.EndInit();
            this.repositoryItemCheckEdit2.EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void PriceChangeListForm_Shown(object sender, EventArgs e)
        {
            this.LoadFromBase();
            this.treeListPriceChangeGroup.MoveLastVisible();
            this.treeListPriceChangeGroup.MoveFirst();
            if (AtTreeList.GetSelectedNode(this.treeListPriceChangeGroup) == null)
                return;
            if (this.treeListPriceChangeGroup.Nodes.Count == 1)
                this.treeList1_FocusedNodeChanged((object)null, (FocusedNodeChangedEventArgs)null);
            if (!this.Is_Dialog)
                return;
            this.treeListPriceChangeGroup.Columns.Remove(this.treeListColumn2);
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.DisableEvent)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPriceChangeGroup);
            if (selectedNode == null)
                return;
            if (this.MoveGroup != null)
            {
                this.DisableEvent = true;
                this.MoveGroup["parentid"] = selectedNode["idpricechangegroup"];
                this.MoveGroup = (DataRow)null;
                this.Cursor = Cursors.Default;
                this.DisableEvent = false;
            }
            if (this.MoveItems != null)
            {
                this.DisableEvent = true;
                foreach (DataRow dataRow in this.MoveItems)
                    dataRow["idpricechangegroup"] = selectedNode["idpricechangegroup"];
                this.MoveItems = (DataRow[])null;
                this.Cursor = Cursors.Default;
                this.DisableEvent = false;
            }
            if (!this.Is_Dialog)
                return;
            if (this.isAll)
                this.gridViewPriceChange.ClearColumnsFilter();
            else if (this.isOrder)
                this.gridViewPriceChange.Columns["fororder"].FilterInfo = new ColumnFilterInfo("[fororder] = true", "");
            else
                this.gridViewPriceChange.Columns["fororder"].FilterInfo = new ColumnFilterInfo("[fororder] = false", "");
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || !this.Is_Dialog)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PriceChangeListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet((DataSet)this.ds) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        public override void LoadFromBase()
        {
            if (this.Is_Dialog)
                this.db.command.CommandText = "select * from dbo.f_getpricechangegroup(" + (object)Settings.People.idpeople + ")";
            else
                this.db.command.CommandText = "select * from pricechangegroup where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.pricechangegroup);
            if (this.Is_Dialog)
                this.db.command.CommandText = "select * from dbo.f_getpricechange(" + (object)Settings.People.idpeople + ")";
            else
                this.db.command.CommandText = "select * from view_pricechange where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.pricechange);
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDatatable2((DataTable)this.ds.pricechangegroup))
                return false;
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.ds.pricechange.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted && (dataRow.RowState == DataRowState.Modified || dataRow.RowState == DataRowState.Added))
                {
                    dataRow["typ"] = (object)(dataRow["pricechange_typ"].ToString() == "Скидка" ? 0 : 1);
                    dataRow["fororder"] = (object)(dataRow["fororder_typ"].ToString() == "Заказ" ? 1 : 0);
                }
            }
            if (!this.db.SaveDatatable2((DataTable)this.ds.pricechange))
                return false;
            this.ds.pricechangegroup.AcceptChanges();
            this.ds.pricechange.AcceptChanges();
            return true;
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPriceChangeGroup);
            if (selectedNode == null)
                return;
            ds_pricechange.pricechangeRow pricechangeRow = this.ds.pricechange.NewpricechangeRow();
            this.ds.pricechange.Rows.Add((DataRow)pricechangeRow);
            pricechangeRow.idpricechange = dbconn.GetGenId("gen_pricechange");
            pricechangeRow.typ = false;
            pricechangeRow.pricechange_typ = "Скидка";
            pricechangeRow.fororder = true;
            pricechangeRow.fororder_typ = "Заказ";
            pricechangeRow.isperc = false;
            pricechangeRow.idpricechangegroup = (int)selectedNode["idpricechangegroup"];
            pricechangeRow.indealerbase = false;
            pricechangeRow.visibledealer = false;
        }

        private void MenuItemDublicate_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlPriceChange);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            int genFirstId = dbconn.GetGenFirstId("gen_pricechange", selectedDataRows.Length);
            foreach (DataRow source in selectedDataRows)
                AtDataSet.dublicate(source)["idpricechange"] = (object)genFirstId++;
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlPriceChange);
            if (selectedDataRows == null)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void MenuItemMoveToGroup_Click(object sender, EventArgs e)
        {
            this.MoveGroup = (DataRow)null;
            this.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlPriceChange);
            if (this.MoveItems == null || this.MoveItems.Length == 0)
                this.Cursor = Cursors.Default;
            else
                this.Cursor = Cursors.Hand;
        }

        private void MenuGroupAddMain_Click(object sender, EventArgs e)
        {
            DataRow row = this.ds.pricechangegroup.NewRow();
            row["idpricechangegroup"] = (object)dbconn.GetGenId("gen_pricechangegroup");
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
            this.ds.pricechangegroup.Rows.Add(row);
        }

        private void MenuGroupAddChild_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPriceChangeGroup);
            if (selectedNode == null)
                return;
            DataRow row = this.ds.pricechangegroup.NewRow();
            row["idpricechangegroup"] = (object)dbconn.GetGenId("gen_pricechangegroup");
            if (InputBox.ShowDialog("Создание дочерней группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
            row["parentid"] = selectedNode["idpricechangegroup"];
            this.ds.pricechangegroup.Rows.Add(row);
        }

        private void MenuGroupEdit_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPriceChangeGroup);
            if (selectedNode == null || InputBox.ShowDialog("Изменение группы", "Введите новое имя", "Введите новый комментарий", selectedNode["name"].ToString(), selectedNode["comment"].ToString()) == DialogResult.Cancel)
                return;
            selectedNode["name"] = (object)InputBox.Value;
            selectedNode["comment"] = (object)InputBox.Value2;
        }

        private void MenuGroupRemove_Click(object sender, EventArgs e)
        {
            ds_pricechange.pricechangegroupRow selectedGroup = this.SelectedGroup;
            if (selectedGroup == null || selectedGroup.GetpricechangegroupRows().Length != 0 && MessageBox.Show("Группа содержит вложенные подгруппы!\nУдалить группу м вложенные подгруппы?", "Удаление группы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || selectedGroup.GetpricechangegroupRows().Length == 0 && selectedGroup.GetpricechangeRows().Length != 0 && MessageBox.Show("Группа содержит позиции!\nУдалить группу вместе с позициями", "Удаление группы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            selectedGroup.Delete();
        }

        private void MenuGroupMoveToGroup_Click(object sender, EventArgs e)
        {
            this.MoveItems = (DataRow[])null;
            this.MoveGroup = (DataRow)this.SelectedGroup;
            if (this.MoveGroup != null)
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }

        private void MenuGroupSetMain_Click(object sender, EventArgs e)
        {
            this.MoveItems = (DataRow[])null;
            ds_pricechange.pricechangegroupRow selectedGroup = this.SelectedGroup;
            if (selectedGroup == null)
                return;
            this.DisableEvent = true;
            selectedGroup.SetparentidNull();
            this.DisableEvent = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idSelectedGroup = this.IDSelectedGroup;
            this.ds.Clear();
            this.LoadFromBase();
            AtTreeList.SelectNode(this.treeListPriceChangeGroup, "idpricechangegroup", idSelectedGroup);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idSelectedGroup = this.IDSelectedGroup;
            this.SaveToBase();
            AtTreeList.SelectNode(this.treeListPriceChangeGroup, "idpricechangegroup", idSelectedGroup);
        }

        public void IsDialog(bool order, bool isall)
        {
            this.isOrder = order;
            this.isAll = isall;
            this.panel2.Visible = false;
            this.panel1.Visible = true;
            this.gridViewPriceChange.OptionsBehavior.Editable = false;
            this.gridControlPriceChange.ContextMenuStrip = (ContextMenuStrip)null;
            this.Is_Dialog = true;
            this.gridViewPriceChange.Columns.Remove(this.colindealerbase);
            this.gridViewPriceChange.Columns.Remove(this.colvisibledealer);
            this.gridViewPriceChange.Columns.Remove(this.colfororder_typ);
            this.gridViewPriceChange.Columns.Remove(this.colisperc);
            if (!isall)
            {
                if (this.bsPriceChange.Filter != "")
                    this.bsPriceChange.Filter += " and ";
                if (order)
                    this.bsPriceChange.Filter += "isnull(fororder,0) = 1";
                else
                    this.bsPriceChange.Filter += "isnull(fororder,0) = 0";
            }
            this.treeListPriceChangeGroup.ContextMenuStrip = (ContextMenuStrip)null;
            foreach (DataRow dataRow1 in (InternalDataCollectionBase)this.ds.pricechangegroup.Rows)
            {
                if (dataRow1["isactive"] == DBNull.Value || !Convert.ToBoolean(dataRow1["isactive"]))
                {
                    foreach (DataRow dataRow2 in this.ds.pricechange.Select("idpricechangegroup = " + dataRow1["idpricechangegroup"].ToString()))
                        dataRow2.Delete();
                    dataRow1.Delete();
                }
            }
            this.ds.pricechangegroup.AcceptChanges();
            this.ds.pricechange.AcceptChanges();
        }
    }
}
