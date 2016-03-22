// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.PollForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
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
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class PollForm : AtUserControl
    {
        private BindingSource bs = new BindingSource();
        private IContainer components;
        private Panel panelDialog;
        private Panel panelDictionary;
        private SplitContainer splitContainer1;
        private TreeList treeListPollGroup;
        private TreeListColumn colname_collgroup;
        private TreeListColumn colisactive;
        private ContextMenuStrip contextMenuStripPollGroup;
        private ToolStripMenuItem toolStripMenuItemPollGroupAddGroup;
        private ToolStripMenuItem toolStripMenuItemPollGroupAddChildGroup;
        private ToolStripMenuItem toolStripMenuItemPollGroupRename;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemPollGroupDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItemPoolGroupRemove;
        private ToolStripMenuItem toolStripMenuItemPollGroupMakeRoot;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItemPollGroupMoveUp;
        private ToolStripMenuItem toolStripMenuItemPollGroupMoveDown;
        private DataSet ds_poll;
        private GridControl gridControlPoll;
        private GridView gridViewPoll;
        private ImageList imageListPoll;
        private SimpleButton simpleButtonExit;
        private SimpleButton simpleButtonApply;
        private SimpleButton simpleButtonCancel;
        private SimpleButton simpleButtonExit2;
        private SimpleButton simpleButtonSelect;
        private ContextMenuStrip contextMenuStripPoll;
        private ToolStripMenuItem toolStripMenuItemPollAdd;
        private ToolStripMenuItem toolStripMenuItemPollEdit;
        private ToolStripMenuItem toolStripMenuItemPollDelete;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItemPollMove;
        private GridColumn gridColumn1;
        private GridColumn gridColumn4;
        private ToolStripMenuItem toolStripMenuItemPollDouble;
        private ToolStripSeparator toolStripSeparator5;
        private GridColumn gridColumn5;
        private TreeListColumn treeListColumn1;
        private RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DataRow MoveGroup;
        private DataRow[] MoveItems;
        private bool isKeyMove;
        private bool isdialog;

        public bool IsDialog
        {
            get
            {
                return this.isdialog;
            }
            set
            {
                this.isdialog = value;
                this.panelDialog.Visible = this.isdialog;
                this.panelDictionary.Visible = !this.isdialog;
                this.gridViewPoll.OptionsBehavior.Editable = !this.isdialog;
            }
        }

        public DataRow SelectedPoll
        {
            get
            {
                return AtGrid.getDataRow((Control)this.gridControlPoll);
            }
        }

        public PollForm(bool isdialog)
        {
            this.InitializeComponent();
            this.LoadDS();
            this.IsDialog = isdialog;
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PollForm));
            this.panelDialog = new Panel();
            this.simpleButtonExit2 = new SimpleButton();
            this.simpleButtonSelect = new SimpleButton();
            this.panelDictionary = new Panel();
            this.simpleButtonExit = new SimpleButton();
            this.simpleButtonApply = new SimpleButton();
            this.simpleButtonCancel = new SimpleButton();
            this.splitContainer1 = new SplitContainer();
            this.treeListPollGroup = new TreeList();
            this.colname_collgroup = new TreeListColumn();
            this.colisactive = new TreeListColumn();
            this.treeListColumn1 = new TreeListColumn();
            this.contextMenuStripPollGroup = new ContextMenuStrip(this.components);
            this.toolStripMenuItemPollGroupAddGroup = new ToolStripMenuItem();
            this.toolStripMenuItemPollGroupAddChildGroup = new ToolStripMenuItem();
            this.toolStripMenuItemPollGroupRename = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItemPollGroupDelete = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItemPoolGroupRemove = new ToolStripMenuItem();
            this.toolStripMenuItemPollGroupMakeRoot = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.toolStripMenuItemPollGroupMoveUp = new ToolStripMenuItem();
            this.toolStripMenuItemPollGroupMoveDown = new ToolStripMenuItem();
            this.imageListPoll = new ImageList(this.components);
            this.gridControlPoll = new GridControl();
            this.contextMenuStripPoll = new ContextMenuStrip(this.components);
            this.toolStripMenuItemPollAdd = new ToolStripMenuItem();
            this.toolStripMenuItemPollDouble = new ToolStripMenuItem();
            this.toolStripMenuItemPollEdit = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.toolStripMenuItemPollDelete = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.toolStripMenuItemPollMove = new ToolStripMenuItem();
            this.gridViewPoll = new GridView();
            this.gridColumn5 = new GridColumn();
            this.gridColumn1 = new GridColumn();
            this.gridColumn4 = new GridColumn();
            this.repositoryItemTimeEdit1 = new RepositoryItemTimeEdit();
            this.repositoryItemButtonEdit1 = new RepositoryItemButtonEdit();
            this.ds_poll = new DataSet();
            this.panelDialog.SuspendLayout();
            this.panelDictionary.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.treeListPollGroup.BeginInit();
            this.contextMenuStripPollGroup.SuspendLayout();
            this.gridControlPoll.BeginInit();
            this.contextMenuStripPoll.SuspendLayout();
            this.gridViewPoll.BeginInit();
            this.repositoryItemTimeEdit1.BeginInit();
            this.repositoryItemButtonEdit1.BeginInit();
            this.ds_poll.BeginInit();
            this.SuspendLayout();
            this.panelDialog.Controls.Add((Control)this.simpleButtonExit2);
            this.panelDialog.Controls.Add((Control)this.simpleButtonSelect);
            this.panelDialog.Dock = DockStyle.Bottom;
            this.panelDialog.Location = new Point(0, 433);
            this.panelDialog.Name = "panelDialog";
            this.panelDialog.Size = new Size(831, 33);
            this.panelDialog.TabIndex = 0;
            this.simpleButtonExit2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonExit2.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonExit2.DialogResult = DialogResult.Cancel;
            this.simpleButtonExit2.Location = new Point(753, 6);
            this.simpleButtonExit2.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonExit2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonExit2.Name = "simpleButtonExit2";
            this.simpleButtonExit2.Size = new Size(75, 23);
            this.simpleButtonExit2.TabIndex = 3;
            this.simpleButtonExit2.Text = "Отменить";
            this.simpleButtonExit2.Click += new EventHandler(this.simpleButtonExit2_Click);
            this.simpleButtonSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonSelect.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonSelect.DialogResult = DialogResult.OK;
            this.simpleButtonSelect.Location = new Point(672, 6);
            this.simpleButtonSelect.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonSelect.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonSelect.Name = "simpleButtonSelect";
            this.simpleButtonSelect.Size = new Size(75, 23);
            this.simpleButtonSelect.TabIndex = 1;
            this.simpleButtonSelect.Text = "Выбрать";
            this.simpleButtonSelect.Click += new EventHandler(this.simpleButtonSelect_Click);
            this.panelDictionary.Controls.Add((Control)this.simpleButtonExit);
            this.panelDictionary.Controls.Add((Control)this.simpleButtonApply);
            this.panelDictionary.Controls.Add((Control)this.simpleButtonCancel);
            this.panelDictionary.Dock = DockStyle.Bottom;
            this.panelDictionary.Location = new Point(0, 400);
            this.panelDictionary.Name = "panelDictionary";
            this.panelDictionary.Size = new Size(831, 33);
            this.panelDictionary.TabIndex = 1;
            this.simpleButtonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonExit.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonExit.Location = new Point(753, 6);
            this.simpleButtonExit.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new Size(75, 23);
            this.simpleButtonExit.TabIndex = 2;
            this.simpleButtonExit.Text = "Закрыть";
            this.simpleButtonExit.Click += new EventHandler(this.simpleButtonExit_Click);
            this.simpleButtonApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonApply.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonApply.Location = new Point(591, 6);
            this.simpleButtonApply.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonApply.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonApply.Name = "simpleButtonApply";
            this.simpleButtonApply.Size = new Size(75, 23);
            this.simpleButtonApply.TabIndex = 1;
            this.simpleButtonApply.Text = "Применить";
            this.simpleButtonApply.Click += new EventHandler(this.simpleButtonApply_Click);
            this.simpleButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonCancel.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonCancel.Location = new Point(672, 6);
            this.simpleButtonCancel.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new Size(75, 23);
            this.simpleButtonCancel.TabIndex = 0;
            this.simpleButtonCancel.Text = "Отменить";
            this.simpleButtonCancel.Click += new EventHandler(this.simpleButtonCancel_Click);
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add((Control)this.treeListPollGroup);
            this.splitContainer1.Panel2.Controls.Add((Control)this.gridControlPoll);
            this.splitContainer1.Size = new Size(831, 400);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 2;
            this.treeListPollGroup.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollGroup.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeListPollGroup.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeListPollGroup.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollGroup.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollGroup.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeListPollGroup.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeListPollGroup.BorderStyle = BorderStyles.Simple;
            this.treeListPollGroup.Columns.AddRange(new TreeListColumn[3]
      {
        this.colname_collgroup,
        this.colisactive,
        this.treeListColumn1
      });
            this.treeListPollGroup.ContextMenuStrip = this.contextMenuStripPollGroup;
            this.treeListPollGroup.Dock = DockStyle.Fill;
            this.treeListPollGroup.ImageIndexFieldName = "imageindex";
            this.treeListPollGroup.KeyFieldName = "idpollgroup";
            this.treeListPollGroup.Location = new Point(0, 0);
            this.treeListPollGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListPollGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListPollGroup.Name = "treeListPollGroup";
            this.treeListPollGroup.OptionsView.ShowHorzLines = false;
            this.treeListPollGroup.OptionsView.ShowIndicator = false;
            this.treeListPollGroup.OptionsView.ShowVertLines = false;
            this.treeListPollGroup.ParentFieldName = "parentid";
            this.treeListPollGroup.SelectImageList = (object)this.imageListPoll;
            this.treeListPollGroup.Size = new Size(267, 400);
            this.treeListPollGroup.TabIndex = 0;
            this.treeListPollGroup.KeyDown += new KeyEventHandler(this.treeListPollGroup_KeyDown);
            this.treeListPollGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListPollGroup_FocusedNodeChanged);
            this.colname_collgroup.Caption = "Группа";
            this.colname_collgroup.FieldName = "name";
            this.colname_collgroup.Name = "colname_collgroup";
            this.colname_collgroup.OptionsColumn.AllowEdit = false;
            this.colname_collgroup.Visible = true;
            this.colname_collgroup.VisibleIndex = 0;
            this.colname_collgroup.Width = 188;
            this.colisactive.Caption = "V";
            this.colisactive.FieldName = "isactive";
            this.colisactive.Name = "colisactive";
            this.colisactive.Visible = true;
            this.colisactive.VisibleIndex = 1;
            this.colisactive.Width = 65;
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "numpos";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.SortOrder = SortOrder.Ascending;
            this.contextMenuStripPollGroup.Items.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.toolStripMenuItemPollGroupAddGroup,
        (ToolStripItem) this.toolStripMenuItemPollGroupAddChildGroup,
        (ToolStripItem) this.toolStripMenuItemPollGroupRename,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItemPollGroupDelete,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripMenuItemPoolGroupRemove,
        (ToolStripItem) this.toolStripMenuItemPollGroupMakeRoot,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.toolStripMenuItemPollGroupMoveUp,
        (ToolStripItem) this.toolStripMenuItemPollGroupMoveDown
      });
            this.contextMenuStripPollGroup.Name = "contextMenuStripPollGroup";
            this.contextMenuStripPollGroup.Size = new Size(298, 198);
            this.contextMenuStripPollGroup.Opening += new CancelEventHandler(this.contextMenuStripPollGroup_Opening);
            this.toolStripMenuItemPollGroupAddGroup.Name = "toolStripMenuItemPollGroupAddGroup";
            this.toolStripMenuItemPollGroupAddGroup.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItemPollGroupAddGroup.Size = new Size(297, 22);
            this.toolStripMenuItemPollGroupAddGroup.Text = "Добавить основную группу";
            this.toolStripMenuItemPollGroupAddGroup.Click += new EventHandler(this.toolStripMenuItemPollGroupAddGroup_Click);
            this.toolStripMenuItemPollGroupAddChildGroup.Name = "toolStripMenuItemPollGroupAddChildGroup";
            this.toolStripMenuItemPollGroupAddChildGroup.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItemPollGroupAddChildGroup.Size = new Size(297, 22);
            this.toolStripMenuItemPollGroupAddChildGroup.Text = "Добавить дочернюю группу";
            this.toolStripMenuItemPollGroupAddChildGroup.Click += new EventHandler(this.toolStripMenuItemPollGroupAddChildGroup_Click);
            this.toolStripMenuItemPollGroupRename.Name = "toolStripMenuItemPollGroupRename";
            this.toolStripMenuItemPollGroupRename.ShortcutKeys = Keys.Return | Keys.Control;
            this.toolStripMenuItemPollGroupRename.Size = new Size(297, 22);
            this.toolStripMenuItemPollGroupRename.Text = "Переименовать";
            this.toolStripMenuItemPollGroupRename.Click += new EventHandler(this.toolStripMenuItemPollGroupRename_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(294, 6);
            this.toolStripMenuItemPollGroupDelete.Name = "toolStripMenuItemPollGroupDelete";
            this.toolStripMenuItemPollGroupDelete.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItemPollGroupDelete.Size = new Size(297, 22);
            this.toolStripMenuItemPollGroupDelete.Text = "Удалить группу";
            this.toolStripMenuItemPollGroupDelete.Click += new EventHandler(this.toolStripMenuItemPollGroupDelete_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(294, 6);
            this.toolStripMenuItemPoolGroupRemove.Name = "toolStripMenuItemPoolGroupRemove";
            this.toolStripMenuItemPoolGroupRemove.ShortcutKeys = Keys.F6;
            this.toolStripMenuItemPoolGroupRemove.Size = new Size(297, 22);
            this.toolStripMenuItemPoolGroupRemove.Text = "Переместить в группу";
            this.toolStripMenuItemPoolGroupRemove.Click += new EventHandler(this.toolStripMenuItemPoolGroupRemove_Click);
            this.toolStripMenuItemPollGroupMakeRoot.Name = "toolStripMenuItemPollGroupMakeRoot";
            this.toolStripMenuItemPollGroupMakeRoot.ShortcutKeys = Keys.M | Keys.Shift | Keys.Control;
            this.toolStripMenuItemPollGroupMakeRoot.Size = new Size(297, 22);
            this.toolStripMenuItemPollGroupMakeRoot.Text = "Сделать группу основной";
            this.toolStripMenuItemPollGroupMakeRoot.Click += new EventHandler(this.toolStripMenuItemPollGroupMakeRoot_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(294, 6);
            this.toolStripMenuItemPollGroupMoveUp.Name = "toolStripMenuItemPollGroupMoveUp";
            this.toolStripMenuItemPollGroupMoveUp.ShortcutKeys = Keys.Up | Keys.Control;
            this.toolStripMenuItemPollGroupMoveUp.Size = new Size(297, 22);
            this.toolStripMenuItemPollGroupMoveUp.Text = "Переместить вверх";
            this.toolStripMenuItemPollGroupMoveUp.Click += new EventHandler(this.toolStripMenuItemPollGroupMoveUp_Click);
            this.toolStripMenuItemPollGroupMoveDown.Name = "toolStripMenuItemPollGroupMoveDown";
            this.toolStripMenuItemPollGroupMoveDown.ShortcutKeys = Keys.Down | Keys.Control;
            this.toolStripMenuItemPollGroupMoveDown.Size = new Size(297, 22);
            this.toolStripMenuItemPollGroupMoveDown.Text = "Переметить вниз";
            this.toolStripMenuItemPollGroupMoveDown.Click += new EventHandler(this.toolStripMenuItemPollGroupMoveDown_Click);
            this.imageListPoll.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListPoll.ImageStream");
            this.imageListPoll.TransparentColor = Color.Transparent;
            this.imageListPoll.Images.SetKeyName(0, "Folder_wd.ico");
            this.imageListPoll.Images.SetKeyName(1, "Folder_wd.ico");
            this.gridControlPoll.ContextMenuStrip = this.contextMenuStripPoll;
            this.gridControlPoll.Dock = DockStyle.Fill;
            this.gridControlPoll.EmbeddedNavigator.Name = "";
            this.gridControlPoll.Location = new Point(0, 0);
            this.gridControlPoll.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlPoll.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlPoll.MainView = (BaseView)this.gridViewPoll;
            this.gridControlPoll.Name = "gridControlPoll";
            this.gridControlPoll.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemTimeEdit1,
        (RepositoryItem) this.repositoryItemButtonEdit1
      });
            this.gridControlPoll.Size = new Size(560, 400);
            this.gridControlPoll.TabIndex = 0;
            this.gridControlPoll.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewPoll
      });
            this.contextMenuStripPoll.Items.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.toolStripMenuItemPollAdd,
        (ToolStripItem) this.toolStripMenuItemPollDouble,
        (ToolStripItem) this.toolStripMenuItemPollEdit,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.toolStripMenuItemPollDelete,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.toolStripMenuItemPollMove
      });
            this.contextMenuStripPoll.Name = "contextMenuStripPoll";
            this.contextMenuStripPoll.Size = new Size(234, 126);
            this.toolStripMenuItemPollAdd.Name = "toolStripMenuItemPollAdd";
            this.toolStripMenuItemPollAdd.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItemPollAdd.Size = new Size(233, 22);
            this.toolStripMenuItemPollAdd.Text = "Добавить опрос";
            this.toolStripMenuItemPollAdd.Click += new EventHandler(this.toolStripMenuItemPollAdd_Click);
            this.toolStripMenuItemPollDouble.Name = "toolStripMenuItemPollDouble";
            this.toolStripMenuItemPollDouble.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.toolStripMenuItemPollDouble.Size = new Size(233, 22);
            this.toolStripMenuItemPollDouble.Text = "Дублировать";
            this.toolStripMenuItemPollDouble.Visible = false;
            this.toolStripMenuItemPollDouble.Click += new EventHandler(this.toolStripMenuItemPollDouble_Click);
            this.toolStripMenuItemPollEdit.Name = "toolStripMenuItemPollEdit";
            this.toolStripMenuItemPollEdit.ShortcutKeys = Keys.Return | Keys.Control;
            this.toolStripMenuItemPollEdit.Size = new Size(233, 22);
            this.toolStripMenuItemPollEdit.Text = "Редактировать";
            this.toolStripMenuItemPollEdit.Click += new EventHandler(this.toolStripMenuItemPollEdit_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(230, 6);
            this.toolStripMenuItemPollDelete.Name = "toolStripMenuItemPollDelete";
            this.toolStripMenuItemPollDelete.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItemPollDelete.Size = new Size(233, 22);
            this.toolStripMenuItemPollDelete.Text = "Удалить";
            this.toolStripMenuItemPollDelete.Click += new EventHandler(this.toolStripMenuItemPollDelete_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(230, 6);
            this.toolStripMenuItemPollMove.Name = "toolStripMenuItemPollMove";
            this.toolStripMenuItemPollMove.ShortcutKeys = Keys.F6;
            this.toolStripMenuItemPollMove.Size = new Size(233, 22);
            this.toolStripMenuItemPollMove.Text = "Переместить в группу";
            this.toolStripMenuItemPollMove.Click += new EventHandler(this.toolStripMenuItemPollMove_Click);
            this.gridViewPoll.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPoll.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPoll.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewPoll.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewPoll.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewPoll.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPoll.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPoll.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewPoll.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPoll.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPoll.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewPoll.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewPoll.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewPoll.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPoll.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPoll.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewPoll.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewPoll.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPoll.BorderStyle = BorderStyles.Simple;
            this.gridViewPoll.Columns.AddRange(new GridColumn[3]
      {
        this.gridColumn5,
        this.gridColumn1,
        this.gridColumn4
      });
            this.gridViewPoll.GridControl = this.gridControlPoll;
            this.gridViewPoll.GroupPanelText = "Панель группировки";
            this.gridViewPoll.Name = "gridViewPoll";
            this.gridViewPoll.OptionsSelection.MultiSelect = true;
            this.gridViewPoll.OptionsView.ShowIndicator = false;
            this.gridViewPoll.DoubleClick += new EventHandler(this.gridViewPoll_DoubleClick);
            this.gridColumn5.Caption = "#";
            this.gridColumn5.FieldName = "idpoll";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn1.Caption = "Наименование";
            this.gridColumn1.FieldName = "name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn4.Caption = "Дата";
            this.gridColumn4.FieldName = "dtedit";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.ds_poll.DataSetName = "NewDataSet";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.splitContainer1);
            this.Controls.Add((Control)this.panelDictionary);
            this.Controls.Add((Control)this.panelDialog);
            this.Name = "PollForm";
            this.Size = new Size(831, 466);
            this.Text = "Опросы";
            this.FormClosing += new FormClosing(this.PollForm_FormClosing);
            this.panelDialog.ResumeLayout(false);
            this.panelDictionary.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.treeListPollGroup.EndInit();
            this.contextMenuStripPollGroup.ResumeLayout(false);
            this.gridControlPoll.EndInit();
            this.contextMenuStripPoll.ResumeLayout(false);
            this.gridViewPoll.EndInit();
            this.repositoryItemTimeEdit1.EndInit();
            this.repositoryItemButtonEdit1.EndInit();
            this.ds_poll.EndInit();
            this.ResumeLayout(false);
        }

        private void LoadDS()
        {
            this.ds_poll = new DataSet();
            dbconn._db.command.CommandText = "select *, case when parentid is null then 0 else 1 end as imageindex from pollgroup where deleted is null";
            dbconn._db.adapter.Fill(this.ds_poll, "pollgroup");
            dbconn._db.command.CommandText = "select * from view_poll where deleted is null";
            dbconn._db.adapter.Fill(this.ds_poll, "poll");
            this.ds_poll.Tables["poll"].Constraints.Add("PK_poll", this.ds_poll.Tables["poll"].Columns["idpoll"], true);
            this.ds_poll.Tables["pollgroup"].Constraints.Add("PK_pollgroup", this.ds_poll.Tables["pollgroup"].Columns["idpollgroup"], true);
            this.ds_poll.Relations.Add("pollgroup_poll", this.ds_poll.Tables["pollgroup"].Columns["idpollgroup"], this.ds_poll.Tables["poll"].Columns["idpollgroup"]);
            this.ds_poll.Relations.Add("pollgroup_pollgroup", this.ds_poll.Tables["pollgroup"].Columns["idpollgroup"], this.ds_poll.Tables["pollgroup"].Columns["parentid"]);
            this.bs = new BindingSource((object)this.ds_poll, "pollgroup");
            this.treeListPollGroup.DataSource = (object)this.bs;
            this.gridControlPoll.DataSource = (object)this.bs;
            this.gridControlPoll.DataMember = "pollgroup_poll";
        }

        private void toolStripMenuItemPollGroupAddGroup_Click(object sender, EventArgs e)
        {
            DataRow row = this.ds_poll.Tables["pollgroup"].NewRow();
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["idpollgroup"] = (object)dbconn.GetGenId("gen_goodgroup");
            row["name"] = (object)InputBox.Value;
            row["isactive"] = (object)1;
            row["numpos"] = (object)this.GetGroupNumpos();
            row["imageindex"] = (object)0;
            this.ds_poll.Tables["pollgroup"].Rows.Add(row);
        }

        private int GetGroupNumpos()
        {
            DataRow[] dataRowArray = this.ds_poll.Tables["pollgroup"].Select("", "numpos");
            int num = 0;
            if (dataRowArray.Length > 0)
            {
                DataRow dataRow = dataRowArray[dataRowArray.Length - 1];
                if (!dbconn.IsValueDbNullOrNull(dataRow["numpos"]))
                    num = (int)dataRow["numpos"] + 1;
            }
            return num;
        }

        private void contextMenuStripPollGroup_Opening(object sender, CancelEventArgs e)
        {
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && (this.treeListPollGroup != null || this.MoveGroup != null))
            {
                this.MoveGroup = (DataRow)null;
                this.Cursor = Cursors.Default;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toolStripMenuItemPoolGroupRemove_Click(object sender, EventArgs e)
        {
            this.MoveGroup = AtTreeList.GetSelectedNode(this.treeListPollGroup);
            if (this.MoveGroup == null)
                return;
            this.Cursor = Cursors.Hand;
        }

        private void treeListPollGroup_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPollGroup);
            if (selectedNode == null)
                return;
            if (this.MoveItems != null)
            {
                foreach (DataRow dataRow in this.MoveItems)
                    dataRow["idpollgroup"] = selectedNode["idpollgroup"];
                this.Cursor = Cursors.Default;
                this.MoveItems = (DataRow[])null;
                this.isKeyMove = false;
            }
            if (this.MoveGroup != null)
            {
                this.treeListPollGroup.DataSource = (object)null;
                if (this.MoveGroup["parentid"] == DBNull.Value)
                    this.MoveGroup["imageindex"] = (object)0;
                this.MoveGroup["parentid"] = selectedNode["idpollgroup"];
                this.Cursor = Cursors.Default;
                this.MoveGroup = (DataRow)null;
                this.isKeyMove = false;
                this.treeListPollGroup.DataSource = (object)this.bs;
            }
            this.isKeyMove = false;
        }

        private void toolStripMenuItemPollGroupAddChildGroup_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPollGroup);
            if (selectedNode == null || selectedNode["idpollgroup"] == DBNull.Value || Convert.ToInt32(selectedNode["idpollgroup"]) == -1)
                return;
            DataRow row = this.ds_poll.Tables["pollgroup"].NewRow();
            if (InputBox.ShowDialog("Создание дочерней группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            string str = InputBox.Value;
            row["idpollgroup"] = (object)dbconn.GetGenId("gen_pollgroup");
            row["name"] = (object)str;
            row["parentid"] = selectedNode["idpollgroup"];
            row["isactive"] = (object)1;
            row["numpos"] = (object)this.GetGroupNumpos();
            this.ds_poll.Tables["pollgroup"].Rows.Add(row);
        }

        private void toolStripMenuItemPollGroupRename_Click(object sender, EventArgs e)
        {
            if (this.treeListPollGroup.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeListPollGroup.GetDataRecordByNode(this.treeListPollGroup.Selection[0])).Row;
            if (InputBox.ShowDialog("Изменить имя", "Введите новое имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
        }

        private void toolStripMenuItemPollGroupDelete_Click(object sender, EventArgs e)
        {
            if (this.treeListPollGroup.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeListPollGroup.GetDataRecordByNode(this.treeListPollGroup.Selection[0])).Row;
            this.treeListPollGroup.MovePrevVisible();
            if (row.GetChildRows("pollgroup_pollgroup").Length != 0 && MessageBox.Show("Группа содержит вложенные подгруппы. Удалить группу вместе с вложениями?", "Удаление группы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            row.Delete();
        }

        private void toolStripMenuItemPollGroupMakeRoot_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPollGroup);
            if (selectedNode == null || (int)selectedNode["imageindex"] == 5)
                return;
            selectedNode["parentid"] = (object)DBNull.Value;
            selectedNode["imageindex"] = (object)0;
        }

        private void toolStripMenuItemPollGroupMoveUp_Click(object sender, EventArgs e)
        {
            DataRow row1 = ((DataRowView)this.treeListPollGroup.GetDataRecordByNode(this.treeListPollGroup.FocusedNode)).Row;
            DataRow row2 = ((DataRowView)this.treeListPollGroup.GetDataRecordByNode(this.treeListPollGroup.MovePrevVisible())).Row;
            if (row1["parentid"] != row2["parentid"])
                return;
            int num1 = (int)row1["numpos"];
            int num2 = (int)row2["numpos"];
            row1["numpos"] = (object)num2;
            row2["numpos"] = (object)num1;
        }

        private void toolStripMenuItemPollGroupMoveDown_Click(object sender, EventArgs e)
        {
            DataRow row1 = ((DataRowView)this.treeListPollGroup.GetDataRecordByNode(this.treeListPollGroup.FocusedNode)).Row;
            if (this.treeListPollGroup.VisibleNodesCount == this.treeListPollGroup.GetVisibleIndexByNode(this.treeListPollGroup.FocusedNode) + 1)
                return;
            DataRow row2 = ((DataRowView)this.treeListPollGroup.GetDataRecordByNode(this.treeListPollGroup.MoveNextVisible())).Row;
            if (row1["parentid"] != row2["parentid"])
                return;
            int num1 = (int)row1["numpos"];
            int num2 = (int)row2["numpos"];
            row1["numpos"] = (object)num2;
            row2["numpos"] = (object)num1;
        }

        private void treeListPollGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || !this.treeListPollGroup.Focused || this.MoveItems == null && this.MoveGroup == null)
                return;
            this.treeListPollGroup_FocusedNodeChanged((object)null, (FocusedNodeChangedEventArgs)null);
        }

        private void simpleButtonApply_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        public override bool SaveToBase()
        {
            try
            {
                dbconn._db.SaveDatatable2(this.ds_poll.Tables["pollgroup"]);
                this.ds_poll.Tables["pollgroup"].AcceptChanges();
                dbconn._db.SaveDatatable2(this.ds_poll.Tables["poll"]);
                this.ds_poll.Tables["poll"].AcceptChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void LoadFromBase()
        {
            this.LoadDS();
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.LoadFromBase();
        }

        private void toolStripMenuItemPollAdd_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPollGroup);
            if (selectedNode == null)
                return;
            DataRow dataRow = this.ds_poll.Tables["poll"].NewRow();
            dataRow["idpoll"] = (object)dbconn.GetGenId("gen_poll");
            dataRow["idpollgroup"] = selectedNode["idpollgroup"];
            dataRow["dtedit"] = (object)DateTime.Now;
            this.ds_poll.Tables["poll"].Rows.Add(dataRow);
            if (this.db.quModifDataSet(this.ds_poll) > 0)
                this.SaveToBase();
            MdiManager.Add((Control)new PollEditForm(dataRow));
        }

        private void toolStripMenuItemPollDelete_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlPoll);
            if (selectedDataRows.Length == 0)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void toolStripMenuItemPollMove_Click(object sender, EventArgs e)
        {
            this.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlPoll);
            if (this.MoveItems == null || this.MoveItems.Length == 0)
                this.MoveItems = (DataRow[])null;
            else
                this.Cursor = Cursors.Hand;
        }

        private void toolStripMenuItemPollEdit_Click(object sender, EventArgs e)
        {
            if (this.db.quModifDataSet(this.ds_poll) > 0)
                this.SaveToBase();
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlPoll);
            if (dataRow == null)
                return;
            MdiManager.Add((Control)new PollEditForm(dataRow));
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PollForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds_poll) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        private void simpleButtonSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemPollDouble_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
            if (AtGrid.getSelectedDataRows((Control)this.gridControlPoll) == null)
                return;
            foreach (DataRow Source in AtGrid.getSelectedDataRows((Control)this.gridControlPoll))
            {
                DataRow dataRow = this.ds_poll.Tables["poll"].NewRow();
                dataRow["idpoll"] = (object)dbconn.GetGenId("gen_poll");
                AtDataSet.LoadRow(Source, dataRow, false);
                this.ds_poll.Tables["poll"].Rows.Add(dataRow);
            }
        }

        private void gridViewPoll_DoubleClick(object sender, EventArgs e)
        {
            if (this.IsDialog)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                this.toolStripMenuItemPollEdit_Click((object)null, (EventArgs)null);
        }
    }
}
