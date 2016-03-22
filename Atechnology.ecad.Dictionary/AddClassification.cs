// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.AddClassification
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.DataSets;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class AddClassification : AtUserControl
    {
        public string FilterGroup = "";
        private IContainer components;
        private Panel panelDialog;
        public Button cmdCancel;
        public Button cmdOk;
        private Panel panelEdit;
        private Button cmdClose;
        private Button cmdReLoad;
        private Button cmdSave;
        public GridControl gridControlAddClassification;
        private GridView gridViewItem;
        private RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private SplitterControl splitterControl1;
        private TreeList treeListGroup;
        private TreeListColumn treeListColumn1;
        private GridColumn colidSourceInfo;
        private GridColumn colname;
        private GridColumn colcomment;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemRemove;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuItemMove;
        private ContextMenuStrip MenuGroup;
        private ToolStripMenuItem MenuGroupAddMain;
        private ToolStripMenuItem MenuGroupAddChild;
        private ToolStripMenuItem MenuGroupRename;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MenuGroupRemove;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem MenuGroupMove;
        private ToolStripMenuItem MenuGroupSetMain;
        private ImageList imageList1;
        private TreeListColumn treeListColumn2;
        private ds_addclassification ds;
        private GridColumn colnumval;
        private GridColumn colintval;
        private GridColumn colstrval;
        private int idAddClassification;
        private DataRow MoveGroup;
        private DataRow[] MoveItems;
        private bool isKeyMove;

        public bool IsDialog
        {
            get
            {
                return this.Is_Dialog;
            }
            set
            {
                this.Is_Dialog = value;
                this.panelEdit.Visible = !value;
                this.panelDialog.Visible = value;
                this.gridViewItem.OptionsBehavior.Editable = !value;
                this.gridControlAddClassification.ContextMenuStrip = value ? (ContextMenuStrip)null : this.MenuItem;
            }
        }

        public ds_addclassification.addclassificationRow SelectedRow
        {
            get
            {
                return AtGrid.getDataRow((Control)this.gridControlAddClassification) as ds_addclassification.addclassificationRow;
            }
        }

        public AddClassification()
        {
            this.InitializeComponent();
            this.treeListGroup.KeyDown += new KeyEventHandler(this.treeListGroup_KeyDown);
            this.treeListGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListGroup_FocusedNodeChanged);
            this.treeListGroup.LostFocus += new EventHandler(this.treeListGroup_LostFocus);
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AddClassification));
            this.panelDialog = new Panel();
            this.cmdCancel = new Button();
            this.cmdOk = new Button();
            this.panelEdit = new Panel();
            this.cmdClose = new Button();
            this.cmdReLoad = new Button();
            this.cmdSave = new Button();
            this.gridControlAddClassification = new GridControl();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.MenuItemAdd = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemMove = new ToolStripMenuItem();
            this.ds = new ds_addclassification();
            this.gridViewItem = new GridView();
            this.colidSourceInfo = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.repositoryItemMemoExEdit1 = new RepositoryItemMemoExEdit();
            this.repositoryItemPictureEdit1 = new RepositoryItemPictureEdit();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new RepositoryItemCheckEdit();
            this.splitterControl1 = new SplitterControl();
            this.treeListGroup = new TreeList();
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
            this.colnumval = new GridColumn();
            this.colintval = new GridColumn();
            this.colstrval = new GridColumn();
            this.panelDialog.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.gridControlAddClassification.BeginInit();
            this.MenuItem.SuspendLayout();
            this.ds.BeginInit();
            this.gridViewItem.BeginInit();
            this.repositoryItemMemoExEdit1.BeginInit();
            this.repositoryItemPictureEdit1.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.repositoryItemCheckEdit2.BeginInit();
            this.treeListGroup.BeginInit();
            this.MenuGroup.SuspendLayout();
            this.SuspendLayout();
            this.panelDialog.Controls.Add((Control)this.cmdCancel);
            this.panelDialog.Controls.Add((Control)this.cmdOk);
            this.panelDialog.Dock = DockStyle.Bottom;
            this.panelDialog.Location = new Point(0, 418);
            this.panelDialog.Name = "panelDialog";
            this.panelDialog.Size = new Size(847, 33);
            this.panelDialog.TabIndex = 5;
            this.panelDialog.Visible = false;
            this.cmdCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.FlatStyle = FlatStyle.Flat;
            this.cmdCancel.Location = new Point(760, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Отменить";
            this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
            this.cmdOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdOk.DialogResult = DialogResult.OK;
            this.cmdOk.FlatStyle = FlatStyle.Flat;
            this.cmdOk.Location = new Point(679, 5);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new Size(75, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Выбрать";
            this.cmdOk.Click += new EventHandler(this.cmdOk_Click);
            this.panelEdit.Controls.Add((Control)this.cmdClose);
            this.panelEdit.Controls.Add((Control)this.cmdReLoad);
            this.panelEdit.Controls.Add((Control)this.cmdSave);
            this.panelEdit.Dock = DockStyle.Bottom;
            this.panelEdit.Location = new Point(0, 451);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new Size(847, 33);
            this.panelEdit.TabIndex = 4;
            this.cmdClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdClose.FlatStyle = FlatStyle.Flat;
            this.cmdClose.Location = new Point(760, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new Size(75, 23);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Закрыть";
            this.cmdClose.Click += new EventHandler(this.cmdClose_Click);
            this.cmdReLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdReLoad.FlatStyle = FlatStyle.Flat;
            this.cmdReLoad.Location = new Point(679, 5);
            this.cmdReLoad.Name = "cmdReLoad";
            this.cmdReLoad.Size = new Size(75, 23);
            this.cmdReLoad.TabIndex = 1;
            this.cmdReLoad.Text = "Отменить";
            this.cmdReLoad.Click += new EventHandler(this.cmdReLoad_Click);
            this.cmdSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdSave.FlatStyle = FlatStyle.Flat;
            this.cmdSave.Location = new Point(598, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new Size(75, 23);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Применить";
            this.cmdSave.Click += new EventHandler(this.cmdSave_Click);
            this.gridControlAddClassification.ContextMenuStrip = this.MenuItem;
            this.gridControlAddClassification.DataMember = "addclassificationgroup.addclassificationgroup_addclassification";
            this.gridControlAddClassification.DataSource = (object)this.ds;
            this.gridControlAddClassification.Dock = DockStyle.Fill;
            this.gridControlAddClassification.EmbeddedNavigator.Name = "";
            this.gridControlAddClassification.Location = new Point(212, 0);
            this.gridControlAddClassification.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlAddClassification.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlAddClassification.MainView = (BaseView)this.gridViewItem;
            this.gridControlAddClassification.Name = "gridControlAddClassification";
            this.gridControlAddClassification.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.repositoryItemMemoExEdit1,
        (RepositoryItem) this.repositoryItemPictureEdit1,
        (RepositoryItem) this.repositoryItemCheckEdit1,
        (RepositoryItem) this.repositoryItemCheckEdit2
      });
            this.gridControlAddClassification.Size = new Size(635, 418);
            this.gridControlAddClassification.TabIndex = 7;
            this.gridControlAddClassification.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewItem
      });
            this.MenuItem.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemRemove,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemMove
      });
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new Size(207, 82);
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAdd.Size = new Size(206, 22);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemAdd.Click += new EventHandler(this.MenuItemAdd_Click_1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(203, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(206, 22);
            this.MenuItemRemove.Text = "Удалить";
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(203, 6);
            this.MenuItemMove.Name = "MenuItemMove";
            this.MenuItemMove.ShortcutKeys = Keys.F6;
            this.MenuItemMove.Size = new Size(206, 22);
            this.MenuItemMove.Text = "Переместить в группу";
            this.MenuItemMove.Click += new EventHandler(this.MenuItemMove_Click);
            this.ds.DataSetName = "ds_addclassification";
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridViewItem.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewItem.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewItem.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewItem.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewItem.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewItem.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewItem.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewItem.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewItem.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewItem.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewItem.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewItem.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewItem.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewItem.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewItem.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewItem.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewItem.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewItem.BorderStyle = BorderStyles.Simple;
            this.gridViewItem.Columns.AddRange(new GridColumn[6]
      {
        this.colidSourceInfo,
        this.colname,
        this.colcomment,
        this.colnumval,
        this.colintval,
        this.colstrval
      });
            this.gridViewItem.GridControl = this.gridControlAddClassification;
            this.gridViewItem.GroupPanelText = "Панель группировки";
            this.gridViewItem.Name = "gridViewItem";
            this.gridViewItem.OptionsCustomization.AllowFilter = false;
            this.gridViewItem.OptionsDetail.ShowDetailTabs = false;
            this.gridViewItem.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewItem.OptionsSelection.MultiSelect = true;
            this.gridViewItem.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewItem.OptionsView.ShowIndicator = false;
            this.gridViewItem.DoubleClick += new EventHandler(this.gridViewItem_DoubleClick);
            this.colidSourceInfo.Caption = "#";
            this.colidSourceInfo.FieldName = "idaddclassification";
            this.colidSourceInfo.Name = "colidSourceInfo";
            this.colidSourceInfo.OptionsColumn.AllowEdit = false;
            this.colidSourceInfo.OptionsColumn.ReadOnly = true;
            this.colidSourceInfo.Visible = true;
            this.colidSourceInfo.VisibleIndex = 0;
            this.colidSourceInfo.Width = 60;
            this.colname.Caption = "Источник информации";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 263;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 2;
            this.colcomment.Width = 766;
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemMemoExEdit1.ShowIcon = false;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.splitterControl1.Location = new Point(206, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 418);
            this.splitterControl1.TabIndex = 9;
            this.splitterControl1.TabStop = false;
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
            this.treeListGroup.Columns.AddRange(new TreeListColumn[2]
      {
        this.treeListColumn1,
        this.treeListColumn2
      });
            this.treeListGroup.ContextMenuStrip = this.MenuGroup;
            this.treeListGroup.DataMember = "addclassificationgroup";
            this.treeListGroup.DataSource = (object)this.ds;
            this.treeListGroup.Dock = DockStyle.Left;
            this.treeListGroup.ImageIndexFieldName = "_imageindex";
            this.treeListGroup.KeyFieldName = "idaddclassificationgroup";
            this.treeListGroup.Location = new Point(0, 0);
            this.treeListGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListGroup.Name = "treeListGroup";
            this.treeListGroup.OptionsView.ShowHorzLines = false;
            this.treeListGroup.OptionsView.ShowIndicator = false;
            this.treeListGroup.OptionsView.ShowVertLines = false;
            this.treeListGroup.ParentFieldName = "parentid";
            this.treeListGroup.SelectImageList = (object)this.imageList1;
            this.treeListGroup.Size = new Size(206, 418);
            this.treeListGroup.TabIndex = 8;
            this.treeListColumn1.Caption = "Группы источников";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 112;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 147;
            this.treeListColumn2.Caption = "V";
            this.treeListColumn2.FieldName = "isactive";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 57;
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
            this.MenuGroupAddMain.Click += new EventHandler(this.MenuGroupAddMain_Click);
            this.MenuGroupAddChild.Name = "MenuGroupAddChild";
            this.MenuGroupAddChild.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuGroupAddChild.Size = new Size(297, 22);
            this.MenuGroupAddChild.Text = "Добавить дочернюю группу";
            this.MenuGroupAddChild.Click += new EventHandler(this.MenuGroupAddChild_Click);
            this.MenuGroupRename.Name = "MenuGroupRename";
            this.MenuGroupRename.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuGroupRename.Size = new Size(297, 22);
            this.MenuGroupRename.Text = "Переименовать";
            this.MenuGroupRename.Click += new EventHandler(this.MenuGroupRename_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(294, 6);
            this.MenuGroupRemove.Name = "MenuGroupRemove";
            this.MenuGroupRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuGroupRemove.Size = new Size(297, 22);
            this.MenuGroupRemove.Text = "Удалить";
            this.MenuGroupRemove.Click += new EventHandler(this.MenuGroupRemove_Click);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new Size(294, 6);
            this.MenuGroupMove.Name = "MenuGroupMove";
            this.MenuGroupMove.ShortcutKeys = Keys.F6;
            this.MenuGroupMove.Size = new Size(297, 22);
            this.MenuGroupMove.Text = "Переместить в группу";
            this.MenuGroupMove.Click += new EventHandler(this.MenuGroupMove_Click);
            this.MenuGroupSetMain.Name = "MenuGroupSetMain";
            this.MenuGroupSetMain.ShortcutKeys = Keys.M | Keys.Shift | Keys.Control;
            this.MenuGroupSetMain.Size = new Size(297, 22);
            this.MenuGroupSetMain.Text = "Сделать группу основной";
            this.MenuGroupSetMain.Click += new EventHandler(this.MenuGroupSetMain_Click);
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.colnumval.Caption = "Число";
            this.colnumval.FieldName = "numval";
            this.colnumval.Name = "colnumval";
            this.colnumval.Visible = true;
            this.colnumval.VisibleIndex = 3;
            this.colintval.Caption = "Целое число";
            this.colintval.FieldName = "intval";
            this.colintval.Name = "colintval";
            this.colintval.Visible = true;
            this.colintval.VisibleIndex = 4;
            this.colstrval.Caption = "Строка";
            this.colstrval.FieldName = "strval";
            this.colstrval.Name = "colstrval";
            this.colstrval.Visible = true;
            this.colstrval.VisibleIndex = 5;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlAddClassification);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeListGroup);
            this.Controls.Add((Control)this.panelDialog);
            this.Controls.Add((Control)this.panelEdit);
            this.Name = "AddClassification";
            this.Size = new Size(847, 484);
            this.Text = "Доп. классификация";
            this.FormClosing += new FormClosing(this.AddClassification_FormClosing);
            this.panelDialog.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.gridControlAddClassification.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.ds.EndInit();
            this.gridViewItem.EndInit();
            this.repositoryItemMemoExEdit1.EndInit();
            this.repositoryItemPictureEdit1.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.repositoryItemCheckEdit2.EndInit();
            this.treeListGroup.EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void MenuGroupAddMain_Click(object sender, EventArgs e)
        {
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", "Введите комментарий", "", "") == DialogResult.Cancel)
                return;
            ds_addclassification.addclassificationgroupRow row = this.ds.addclassificationgroup.NewaddclassificationgroupRow();
            row.idaddclassificationgroup = dbconn.GetGenId("gen_addclassificationgroup");
            this.SaveDataMember((Control)this.treeListGroup);
            row.name = InputBox.Value;
            row.comment = InputBox.Value2;
            row.isactive = true;
            this.ds.addclassificationgroup.AddaddclassificationgroupRow(row);
            this.RestoreDataMember((Control)this.treeListGroup);
        }

        private void MenuGroupAddChild_Click(object sender, EventArgs e)
        {
            ds_addclassification.addclassificationgroupRow addclassificationgroupRow = AtTreeList.GetSelectedNode(this.treeListGroup) as ds_addclassification.addclassificationgroupRow;
            if (addclassificationgroupRow == null || InputBox.ShowDialog("Создание дочерней группы", "Введите имя", "Введите комментарий", addclassificationgroupRow["name"].ToString(), "") == DialogResult.Cancel)
                return;
            ds_addclassification.addclassificationgroupRow row = this.ds.addclassificationgroup.NewaddclassificationgroupRow();
            row.idaddclassificationgroup = dbconn.GetGenId("gen_addclassificationgroup");
            this.SaveDataMember((Control)this.treeListGroup);
            row.name = InputBox.Value;
            row.comment = InputBox.Value2;
            row.isactive = true;
            row.parentid = addclassificationgroupRow.idaddclassificationgroup;
            this.ds.addclassificationgroup.AddaddclassificationgroupRow(row);
            this.RestoreDataMember((Control)this.treeListGroup);
            this.RestoreDataMember((Control)this.treeListGroup);
            this.treeListGroup.FocusedNode = AtTreeList.FindNode(this.treeListGroup, (TreeListNode)null, "idaddclassificationgroup", row.idaddclassificationgroup);
        }

        private void MenuGroupRename_Click(object sender, EventArgs e)
        {
            ds_addclassification.addclassificationgroupRow addclassificationgroupRow = AtTreeList.GetSelectedNode(this.treeListGroup) as ds_addclassification.addclassificationgroupRow;
            if (addclassificationgroupRow == null || InputBox.ShowDialog("Изменение группы", "Введите новое имя", "Введите новый комментарий", addclassificationgroupRow["name"].ToString(), addclassificationgroupRow["comment"].ToString()) == DialogResult.Cancel)
                return;
            this.SaveDataMember((Control)this.treeListGroup);
            addclassificationgroupRow.name = InputBox.Value;
            addclassificationgroupRow.comment = InputBox.Value2;
            this.RestoreDataMember((Control)this.treeListGroup);
        }

        private void MenuGroupRemove_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            selectedNode.Delete();
        }

        private void MenuGroupMove_Click(object sender, EventArgs e)
        {
            this.MoveGroup = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (this.dr == null)
                return;
            this.Cursor = Cursors.Hand;
            this.treeListGroup.Focus();
        }

        private void MenuGroupSetMain_Click(object sender, EventArgs e)
        {
            ds_addclassification.addclassificationgroupRow addclassificationgroupRow = AtTreeList.GetSelectedNode(this.treeListGroup) as ds_addclassification.addclassificationgroupRow;
            if (addclassificationgroupRow == null)
                return;
            addclassificationgroupRow.SetparentidNull();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && (this.MoveItems != null || this.MoveGroup != null))
            {
                this.MoveItems = (DataRow[])null;
                this.MoveGroup = (DataRow)null;
                this.Cursor = Cursors.Default;
            }
            else if (keyData == Keys.Return && (this.MoveItems != null || this.MoveGroup != null))
                this.MoveElements();
            else if (this.Focused)
                this.isKeyMove = true;
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void treeListGroup_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeListGroup) == null)
                return;
            if (!this.isKeyMove)
                this.MoveElements();
            this.isKeyMove = false;
        }

        private void treeListGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && (this.MoveItems != null || this.MoveGroup != null))
                this.MoveElements();
            else
                TreeList_KeyDown.Key(this.treeListGroup, e.KeyCode);
        }

        private void treeListGroup_LostFocus(object sender, EventArgs e)
        {
            this.isKeyMove = false;
        }

        public void SetSelectedAddClassification(int _idAddClassification)
        {
            this.idAddClassification = _idAddClassification;
        }

        public override void LoadFromBase()
        {
            this.ds.Clear();
            this.ds.AcceptChanges();
            if (this.Is_Dialog)
                this.db.command.CommandText = "select *, 0 _imageindex from addclassificationgroup where deleted is null and isactive = 1 " + this.FilterGroup;
            else
                this.db.command.CommandText = "select *, 0 _imageindex from addclassificationgroup where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.addclassificationgroup);
            if (this.Is_Dialog)
                this.db.command.CommandText = "\r\n                    select * \r\n\t\t\t\t\t    from addclassification\r\n\t\t\t\t\t    where deleted is null \r\n\t\t\t\t\t\t    and idaddclassificationgroup in \r\n                            (select idaddclassificationgroup from addclassificationgroup where deleted is null and isactive = 1 " + this.FilterGroup + ") ";
            else
                this.db.command.CommandText = "select * from addclassification where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.addclassification);
        }

        public override bool SaveToBase()
        {
            try
            {
                this.db.SaveDatatable2((DataTable)this.ds.addclassificationgroup);
                this.db.SaveDatatable2((DataTable)this.ds.addclassification);
                this.ds.AcceptChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void MoveElements()
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            this.MoveElements(selectedNode);
        }

        public virtual void MoveElements(DataRow dr)
        {
            if (this.MoveGroup != null)
            {
                if (this.MoveGroup != dr)
                {
                    this.SaveDataMember((Control)this.treeListGroup);
                    this.MoveGroup["parentid"] = dr == null ? (object)DBNull.Value : dr["idaddclassificationgroup"];
                    this.RestoreDataMember((Control)this.treeListGroup);
                }
                this.Cursor = Cursors.Default;
                this.MoveGroup = (DataRow)null;
            }
            if (this.MoveItems == null)
                return;
            foreach (DataRow dataRow in this.MoveItems)
                dataRow["idaddclassificationgroup"] = dr["idaddclassificationgroup"];
            this.Cursor = Cursors.Default;
            this.MoveItems = (DataRow[])null;
        }

        private void MenuItemAdd_Click_1(object sender, EventArgs e)
        {
            ds_addclassification.addclassificationgroupRow addclassificationgroupRow = AtTreeList.GetSelectedNode(this.treeListGroup) as ds_addclassification.addclassificationgroupRow;
            if (addclassificationgroupRow == null)
                return;
            ds_addclassification.addclassificationRow row = this.ds.addclassification.NewaddclassificationRow();
            row.idaddclassification = dbconn.GetGenId("gen_addclassification");
            row.idaddclassificationgroup = addclassificationgroupRow.idaddclassificationgroup;
            row.name = "Новая доп. классификация";
            this.ds.addclassification.AddaddclassificationRow(row);
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            if (AtGrid.getSelectedDataRows((Control)this.gridControlAddClassification) == null)
                return;
            foreach (DataRow dataRow in AtGrid.getSelectedDataRows((Control)this.gridControlAddClassification))
                dataRow.Delete();
        }

        private void MenuItemMove_Click(object sender, EventArgs e)
        {
            this.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlAddClassification);
            if (this.MoveItems == null)
                return;
            this.Cursor = Cursors.Hand;
            this.treeListGroup.Focus();
        }

        private void AddClassification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet((DataSet)this.ds) <= 0)
                return;
            switch (MessageBox.Show("Данные справочника были изменены.\n\nСохранить изменения?", "Справочник источников информации", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (AtGrid.getDataRow((Control)this.gridControlAddClassification) == null)
                this.DialogResult = DialogResult.Cancel;
            else
                this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdReLoad_Click(object sender, EventArgs e)
        {
            this.LoadFromBase();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void gridViewItem_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.cmdOk_Click((object)this, new EventArgs());
        }
    }
}
