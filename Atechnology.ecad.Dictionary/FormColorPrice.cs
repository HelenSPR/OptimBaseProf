// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.FormColorPrice
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.DataSets;
using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
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
    public class FormColorPrice : AtUserControl
    {
        private bool Flag = true;
        private IContainer components;
        private PanelControl panelControl1;
        private SimpleButton simpleButtonSave;
        private SimpleButton simpleButtonCancel;
        private SimpleButton simpleButtonExit;
        private PanelControl panelControl2;
        private SplitContainerControl splitContainerControl1;
        private SplitContainerControl splitContainerControl2;
        private GridControl gridControlColorGroup;
        private GridView gridViewColorGroup;
        private GridView gridView2;
        private GridControl gridControlPriceGroup;
        private GridView gridViewPriceGroup;
        private GridControl gridControlPriceGroupItem;
        private GridView gridViewPriceGroupItem;
        private ds_colorgroupcustom ds;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colname1;
        private GridColumn colcomment1;
        private GridColumn colidcolor;
        private GridColumn colcode;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private ContextMenuStrip contextMenuStripColorGroup;
        private ToolStripMenuItem toolStripMenuItemColorGroupAdd;
        private ToolStripMenuItem toolStripMenuItemColorGroupDelete;
        private ContextMenuStrip contextMenuStripPriceGroup;
        private ToolStripMenuItem toolStripMenuItemPriceGroupAdd;
        private ToolStripMenuItem toolStripMenuItemPriceGroupDelete;
        private ContextMenuStrip contextMenuStripPriceGroupItem;
        private ToolStripMenuItem toolStripMenuItemPriceGroupItemAdd;
        private ToolStripMenuItem toolStripMenuItemPriceGroupItemDelete;
        private BindingSource bindingSourceCG;
        private BindingSource bindingSourceCP;
        private BindingSource bindingSourceCPI;
        private GridColumn colidcolor2;

        public FormColorPrice()
        {
            this.InitializeComponent();
            this.repositoryItemLookUpEdit1.DataSource = (object)this.ds.color;
            this.repositoryItemLookUpEdit1.ValueMember = "idcolor";
            this.repositoryItemLookUpEdit1.DisplayMember = "name";
            this.LoadFromBase();
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
            this.panelControl1 = new PanelControl();
            this.simpleButtonSave = new SimpleButton();
            this.simpleButtonCancel = new SimpleButton();
            this.simpleButtonExit = new SimpleButton();
            this.panelControl2 = new PanelControl();
            this.splitContainerControl1 = new SplitContainerControl();
            this.gridControlColorGroup = new GridControl();
            this.contextMenuStripColorGroup = new ContextMenuStrip(this.components);
            this.toolStripMenuItemColorGroupAdd = new ToolStripMenuItem();
            this.toolStripMenuItemColorGroupDelete = new ToolStripMenuItem();
            this.bindingSourceCG = new BindingSource(this.components);
            this.ds = new ds_colorgroupcustom();
            this.gridViewColorGroup = new GridView();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.gridView2 = new GridView();
            this.splitContainerControl2 = new SplitContainerControl();
            this.gridControlPriceGroup = new GridControl();
            this.contextMenuStripPriceGroup = new ContextMenuStrip(this.components);
            this.toolStripMenuItemPriceGroupAdd = new ToolStripMenuItem();
            this.toolStripMenuItemPriceGroupDelete = new ToolStripMenuItem();
            this.bindingSourceCP = new BindingSource(this.components);
            this.gridViewPriceGroup = new GridView();
            this.colname1 = new GridColumn();
            this.colcomment1 = new GridColumn();
            this.gridControlPriceGroupItem = new GridControl();
            this.contextMenuStripPriceGroupItem = new ContextMenuStrip(this.components);
            this.toolStripMenuItemPriceGroupItemDelete = new ToolStripMenuItem();
            this.toolStripMenuItemPriceGroupItemAdd = new ToolStripMenuItem();
            this.bindingSourceCPI = new BindingSource(this.components);
            this.gridViewPriceGroupItem = new GridView();
            this.colidcolor = new GridColumn();
            this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
            this.colidcolor2 = new GridColumn();
            this.colcode = new GridColumn();
            this.panelControl1.BeginInit();
            this.panelControl1.SuspendLayout();
            this.panelControl2.BeginInit();
            this.panelControl2.SuspendLayout();
            this.splitContainerControl1.BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.gridControlColorGroup.BeginInit();
            this.contextMenuStripColorGroup.SuspendLayout();
            ((ISupportInitialize)this.bindingSourceCG).BeginInit();
            this.ds.BeginInit();
            this.gridViewColorGroup.BeginInit();
            this.gridView2.BeginInit();
            this.splitContainerControl2.BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.gridControlPriceGroup.BeginInit();
            this.contextMenuStripPriceGroup.SuspendLayout();
            ((ISupportInitialize)this.bindingSourceCP).BeginInit();
            this.gridViewPriceGroup.BeginInit();
            this.gridControlPriceGroupItem.BeginInit();
            this.contextMenuStripPriceGroupItem.SuspendLayout();
            ((ISupportInitialize)this.bindingSourceCPI).BeginInit();
            this.gridViewPriceGroupItem.BeginInit();
            this.repositoryItemLookUpEdit1.BeginInit();
            this.SuspendLayout();
            this.panelControl1.BorderStyle = BorderStyles.Simple;
            this.panelControl1.Controls.Add((Control)this.simpleButtonSave);
            this.panelControl1.Controls.Add((Control)this.simpleButtonCancel);
            this.panelControl1.Controls.Add((Control)this.simpleButtonExit);
            this.panelControl1.Dock = DockStyle.Bottom;
            this.panelControl1.Location = new Point(0, 489);
            this.panelControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new Size(788, 39);
            this.panelControl1.TabIndex = 0;
            this.simpleButtonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonSave.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonSave.Location = new Point(546, 6);
            this.simpleButtonSave.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new Size(75, 23);
            this.simpleButtonSave.TabIndex = 2;
            this.simpleButtonSave.Text = "Применить";
            this.simpleButtonSave.Click += new EventHandler(this.simpleButtonSave_Click);
            this.simpleButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonCancel.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonCancel.Location = new Point(627, 6);
            this.simpleButtonCancel.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new Size(75, 23);
            this.simpleButtonCancel.TabIndex = 1;
            this.simpleButtonCancel.Text = "Отменить";
            this.simpleButtonCancel.Click += new EventHandler(this.simpleButtonCancel_Click);
            this.simpleButtonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonExit.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonExit.Location = new Point(708, 6);
            this.simpleButtonExit.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new Size(75, 23);
            this.simpleButtonExit.TabIndex = 0;
            this.simpleButtonExit.Text = "Закрыть";
            this.simpleButtonExit.Click += new EventHandler(this.simpleButtonExit_Click);
            this.panelControl2.BorderStyle = BorderStyles.Simple;
            this.panelControl2.Controls.Add((Control)this.splitContainerControl1);
            this.panelControl2.Dock = DockStyle.Fill;
            this.panelControl2.Location = new Point(0, 0);
            this.panelControl2.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new Size(788, 489);
            this.panelControl2.TabIndex = 1;
            this.splitContainerControl1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Location = new Point(2, 2);
            this.splitContainerControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.splitContainerControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = BorderStyles.Simple;
            this.splitContainerControl1.Panel1.Controls.Add((Control)this.gridControlColorGroup);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = BorderStyles.NoBorder;
            this.splitContainerControl1.Panel2.Controls.Add((Control)this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new Size(784, 485);
            this.splitContainerControl1.SplitterPosition = 315;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            this.gridControlColorGroup.ContextMenuStrip = this.contextMenuStripColorGroup;
            this.gridControlColorGroup.DataSource = (object)this.bindingSourceCG;
            this.gridControlColorGroup.Dock = DockStyle.Fill;
            this.gridControlColorGroup.EmbeddedNavigator.Name = "";
            this.gridControlColorGroup.Location = new Point(0, 0);
            this.gridControlColorGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlColorGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlColorGroup.MainView = (BaseView)this.gridViewColorGroup;
            this.gridControlColorGroup.Name = "gridControlColorGroup";
            this.gridControlColorGroup.Size = new Size(311, 481);
            this.gridControlColorGroup.TabIndex = 0;
            this.gridControlColorGroup.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridViewColorGroup,
        (BaseView) this.gridView2
      });
            this.contextMenuStripColorGroup.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripMenuItemColorGroupAdd,
        (ToolStripItem) this.toolStripMenuItemColorGroupDelete
      });
            this.contextMenuStripColorGroup.Name = "contextMenuStripColorGroup";
            this.contextMenuStripColorGroup.Size = new Size(125, 48);
            this.toolStripMenuItemColorGroupAdd.Name = "toolStripMenuItemColorGroupAdd";
            this.toolStripMenuItemColorGroupAdd.Size = new Size(124, 22);
            this.toolStripMenuItemColorGroupAdd.Text = "Добавить";
            this.toolStripMenuItemColorGroupAdd.Click += new EventHandler(this.toolStripMenuItemColorGroupAdd_Click);
            this.toolStripMenuItemColorGroupDelete.Name = "toolStripMenuItemColorGroupDelete";
            this.toolStripMenuItemColorGroupDelete.Size = new Size(124, 22);
            this.toolStripMenuItemColorGroupDelete.Text = "Удалить";
            this.toolStripMenuItemColorGroupDelete.Click += new EventHandler(this.toolStripMenuItemColorGroupDelete_Click);
            this.bindingSourceCG.DataMember = "colorgroupcustom";
            this.bindingSourceCG.DataSource = (object)this.ds;
            this.ds.DataSetName = "ds_colorgroupcustom";
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridViewColorGroup.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewColorGroup.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewColorGroup.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewColorGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewColorGroup.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewColorGroup.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewColorGroup.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewColorGroup.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewColorGroup.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewColorGroup.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewColorGroup.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewColorGroup.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewColorGroup.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewColorGroup.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewColorGroup.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewColorGroup.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewColorGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewColorGroup.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewColorGroup.BorderStyle = BorderStyles.Simple;
            this.gridViewColorGroup.Columns.AddRange(new GridColumn[2]
      {
        this.colname,
        this.colcomment
      });
            this.gridViewColorGroup.GridControl = this.gridControlColorGroup;
            this.gridViewColorGroup.GroupPanelText = "Цветовые группы";
            this.gridViewColorGroup.Name = "gridViewColorGroup";
            this.gridViewColorGroup.OptionsView.ShowDetailButtons = false;
            this.gridViewColorGroup.OptionsView.ShowIndicator = false;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 1;
            this.gridView2.GridControl = this.gridControlColorGroup;
            this.gridView2.Name = "gridView2";
            this.splitContainerControl2.Dock = DockStyle.Fill;
            this.splitContainerControl2.Location = new Point(0, 0);
            this.splitContainerControl2.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.splitContainerControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.BorderStyle = BorderStyles.Simple;
            this.splitContainerControl2.Panel1.Controls.Add((Control)this.gridControlPriceGroup);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.BorderStyle = BorderStyles.Simple;
            this.splitContainerControl2.Panel2.Controls.Add((Control)this.gridControlPriceGroupItem);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new Size(465, 485);
            this.splitContainerControl2.SplitterPosition = 294;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            this.gridControlPriceGroup.ContextMenuStrip = this.contextMenuStripPriceGroup;
            this.gridControlPriceGroup.DataSource = (object)this.bindingSourceCP;
            this.gridControlPriceGroup.Dock = DockStyle.Fill;
            this.gridControlPriceGroup.EmbeddedNavigator.Name = "";
            this.gridControlPriceGroup.Location = new Point(0, 0);
            this.gridControlPriceGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlPriceGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlPriceGroup.MainView = (BaseView)this.gridViewPriceGroup;
            this.gridControlPriceGroup.Name = "gridControlPriceGroup";
            this.gridControlPriceGroup.Size = new Size(290, 481);
            this.gridControlPriceGroup.TabIndex = 0;
            this.gridControlPriceGroup.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewPriceGroup
      });
            this.contextMenuStripPriceGroup.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripMenuItemPriceGroupAdd,
        (ToolStripItem) this.toolStripMenuItemPriceGroupDelete
      });
            this.contextMenuStripPriceGroup.Name = "contextMenuStripPriceGroup";
            this.contextMenuStripPriceGroup.Size = new Size(125, 48);
            this.toolStripMenuItemPriceGroupAdd.Name = "toolStripMenuItemPriceGroupAdd";
            this.toolStripMenuItemPriceGroupAdd.Size = new Size(124, 22);
            this.toolStripMenuItemPriceGroupAdd.Text = "Добавить";
            this.toolStripMenuItemPriceGroupAdd.Click += new EventHandler(this.toolStripMenuItemPriceGroupAdd_Click);
            this.toolStripMenuItemPriceGroupDelete.Name = "toolStripMenuItemPriceGroupDelete";
            this.toolStripMenuItemPriceGroupDelete.Size = new Size(124, 22);
            this.toolStripMenuItemPriceGroupDelete.Text = "Удалить";
            this.toolStripMenuItemPriceGroupDelete.Click += new EventHandler(this.toolStripMenuItemPriceGroupDelete_Click);
            this.bindingSourceCP.DataMember = "FK_colorgroupcustom_colorgroupprice";
            this.bindingSourceCP.DataSource = (object)this.bindingSourceCG;
            this.gridViewPriceGroup.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroup.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroup.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewPriceGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewPriceGroup.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewPriceGroup.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroup.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceGroup.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewPriceGroup.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceGroup.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceGroup.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewPriceGroup.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewPriceGroup.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewPriceGroup.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroup.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroup.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewPriceGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewPriceGroup.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPriceGroup.BorderStyle = BorderStyles.Simple;
            this.gridViewPriceGroup.Columns.AddRange(new GridColumn[2]
      {
        this.colname1,
        this.colcomment1
      });
            this.gridViewPriceGroup.GridControl = this.gridControlPriceGroup;
            this.gridViewPriceGroup.GroupPanelText = "Ценовые группы";
            this.gridViewPriceGroup.Name = "gridViewPriceGroup";
            this.gridViewPriceGroup.OptionsView.ShowDetailButtons = false;
            this.gridViewPriceGroup.OptionsView.ShowIndicator = false;
            this.colname1.Caption = "Наименование";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 0;
            this.colcomment1.Caption = "Комментарий";
            this.colcomment1.FieldName = "comment";
            this.colcomment1.Name = "colcomment1";
            this.colcomment1.Visible = true;
            this.colcomment1.VisibleIndex = 1;
            this.gridControlPriceGroupItem.ContextMenuStrip = this.contextMenuStripPriceGroupItem;
            this.gridControlPriceGroupItem.DataSource = (object)this.bindingSourceCPI;
            this.gridControlPriceGroupItem.Dock = DockStyle.Fill;
            this.gridControlPriceGroupItem.EmbeddedNavigator.Name = "";
            this.gridControlPriceGroupItem.Location = new Point(0, 0);
            this.gridControlPriceGroupItem.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlPriceGroupItem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlPriceGroupItem.MainView = (BaseView)this.gridViewPriceGroupItem;
            this.gridControlPriceGroupItem.Name = "gridControlPriceGroupItem";
            this.gridControlPriceGroupItem.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
            this.gridControlPriceGroupItem.Size = new Size(163, 481);
            this.gridControlPriceGroupItem.TabIndex = 0;
            this.gridControlPriceGroupItem.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewPriceGroupItem
      });
            this.contextMenuStripPriceGroupItem.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripMenuItemPriceGroupItemDelete,
        (ToolStripItem) this.toolStripMenuItemPriceGroupItemAdd
      });
            this.contextMenuStripPriceGroupItem.Name = "contextMenuStripPriceGroupItem";
            this.contextMenuStripPriceGroupItem.Size = new Size(125, 48);
            this.toolStripMenuItemPriceGroupItemDelete.Name = "toolStripMenuItemPriceGroupItemDelete";
            this.toolStripMenuItemPriceGroupItemDelete.Size = new Size(124, 22);
            this.toolStripMenuItemPriceGroupItemDelete.Text = "Добавить";
            this.toolStripMenuItemPriceGroupItemDelete.Click += new EventHandler(this.toolStripMenuItemPriceGroupItemDelete_Click);
            this.toolStripMenuItemPriceGroupItemAdd.Name = "toolStripMenuItemPriceGroupItemAdd";
            this.toolStripMenuItemPriceGroupItemAdd.Size = new Size(124, 22);
            this.toolStripMenuItemPriceGroupItemAdd.Text = "Удалить";
            this.toolStripMenuItemPriceGroupItemAdd.Click += new EventHandler(this.toolStripMenuItemPriceGroupItemAdd_Click);
            this.bindingSourceCPI.AllowNew = false;
            this.bindingSourceCPI.DataMember = "FK_colorgroupprice_colorgrouppriceitem";
            this.bindingSourceCPI.DataSource = (object)this.bindingSourceCP;
            this.gridViewPriceGroupItem.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroupItem.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroupItem.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewPriceGroupItem.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewPriceGroupItem.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewPriceGroupItem.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroupItem.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceGroupItem.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewPriceGroupItem.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceGroupItem.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPriceGroupItem.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewPriceGroupItem.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewPriceGroupItem.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewPriceGroupItem.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroupItem.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPriceGroupItem.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewPriceGroupItem.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewPriceGroupItem.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPriceGroupItem.BorderStyle = BorderStyles.Simple;
            this.gridViewPriceGroupItem.Columns.AddRange(new GridColumn[3]
      {
        this.colidcolor,
        this.colidcolor2,
        this.colcode
      });
            this.gridViewPriceGroupItem.GridControl = this.gridControlPriceGroupItem;
            this.gridViewPriceGroupItem.GroupPanelText = "Цвета";
            this.gridViewPriceGroupItem.Name = "gridViewPriceGroupItem";
            this.gridViewPriceGroupItem.OptionsView.ShowDetailButtons = false;
            this.gridViewPriceGroupItem.OptionsView.ShowIndicator = false;
            this.gridViewPriceGroupItem.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridViewPriceGroupItem_FocusedRowChanged);
            this.gridViewPriceGroupItem.LostFocus += new EventHandler(this.gridViewPriceGroupItem_LostFocus);
            this.colidcolor.Caption = "Цвет1";
            this.colidcolor.ColumnEdit = (RepositoryItem)this.repositoryItemLookUpEdit1;
            this.colidcolor.FieldName = "idcolor1";
            this.colidcolor.Name = "colidcolor";
            this.colidcolor.Visible = true;
            this.colidcolor.VisibleIndex = 0;
            this.repositoryItemLookUpEdit1.ActionButtonIndex = 1;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemLookUpEdit1.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("idcolor", "#", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None),
        new LookUpColumnInfo("name", "Наименование", 100),
        new LookUpColumnInfo("shortname", "Сокр. наименование", 50)
      });
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ButtonClick += new ButtonPressedEventHandler(this.repositoryItemLookUpEdit1_ButtonClick);
            this.repositoryItemLookUpEdit1.EditValueChanging += new ChangingEventHandler(this.repositoryItemLookUpEdit1_EditValueChanging);
            this.colidcolor2.Caption = "Цвет2";
            this.colidcolor2.ColumnEdit = (RepositoryItem)this.repositoryItemLookUpEdit1;
            this.colidcolor2.FieldName = "idcolor2";
            this.colidcolor2.Name = "colidcolor2";
            this.colidcolor2.Visible = true;
            this.colidcolor2.VisibleIndex = 1;
            this.colcode.Caption = "Код";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 2;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.panelControl2);
            this.Controls.Add((Control)this.panelControl1);
            this.Name = "FormColorPrice";
            this.Size = new Size(788, 528);
            this.Text = "Цветовые группы";
            this.FormClosing += new FormClosing(this.FormColorPrice_FormClosing);
            this.panelControl1.EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl2.EndInit();
            this.panelControl2.ResumeLayout(false);
            this.splitContainerControl1.EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.gridControlColorGroup.EndInit();
            this.contextMenuStripColorGroup.ResumeLayout(false);
            ((ISupportInitialize)this.bindingSourceCG).EndInit();
            this.ds.EndInit();
            this.gridViewColorGroup.EndInit();
            this.gridView2.EndInit();
            this.splitContainerControl2.EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.gridControlPriceGroup.EndInit();
            this.contextMenuStripPriceGroup.ResumeLayout(false);
            ((ISupportInitialize)this.bindingSourceCP).EndInit();
            this.gridViewPriceGroup.EndInit();
            this.gridControlPriceGroupItem.EndInit();
            this.contextMenuStripPriceGroupItem.ResumeLayout(false);
            ((ISupportInitialize)this.bindingSourceCPI).EndInit();
            this.gridViewPriceGroupItem.EndInit();
            this.repositoryItemLookUpEdit1.EndInit();
            this.ResumeLayout(false);
        }

        private void toolStripMenuItemColorGroupAdd_Click(object sender, EventArgs e)
        {
            ds_colorgroupcustom.colorgroupcustomRow row = this.ds.colorgroupcustom.NewcolorgroupcustomRow();
            row.idcolorgroupcustom = dbconn.GetGenId("gen_colorgroupcustom");
            row.name = "Новая группа";
            this.ds.colorgroupcustom.AddcolorgroupcustomRow(row);
        }

        private void toolStripMenuItemColorGroupDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in AtGrid.getSelectedDataRows((Control)this.gridControlColorGroup))
                dataRow.Delete();
        }

        private void toolStripMenuItemPriceGroupAdd_Click(object sender, EventArgs e)
        {
            ds_colorgroupcustom.colorgroupcustomRow colorgroupcustomRow = AtGrid.getDataRow((Control)this.gridControlColorGroup) as ds_colorgroupcustom.colorgroupcustomRow;
            if (colorgroupcustomRow == null)
                return;
            ds_colorgroupcustom.colorgrouppriceRow row = this.ds.colorgroupprice.NewcolorgrouppriceRow();
            row.idcolorgroupprice = dbconn.GetGenId("gen_colorgroupprice");
            row.name = "Новая группа";
            row.idcolorgroupcustom = colorgroupcustomRow.idcolorgroupcustom;
            this.ds.colorgroupprice.AddcolorgrouppriceRow(row);
        }

        private void toolStripMenuItemPriceGroupDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in AtGrid.getSelectedDataRows((Control)this.gridControlPriceGroup))
                dataRow.Delete();
        }

        private void toolStripMenuItemPriceGroupItemDelete_Click(object sender, EventArgs e)
        {
            ds_colorgroupcustom.colorgrouppriceRow colorgrouppriceRow = AtGrid.getDataRow((Control)this.gridControlPriceGroup) as ds_colorgroupcustom.colorgrouppriceRow;
            if (colorgrouppriceRow == null)
                return;
            ds_colorgroupcustom.colorgrouppriceitemRow row = this.ds.colorgrouppriceitem.NewcolorgrouppriceitemRow();
            row.idcolorgrouppriceitem = dbconn.GetGenId("gen_colorgrouppriceitem");
            row.code = "";
            row.idcolorgroupprice = colorgrouppriceRow.idcolorgroupprice;
            this.ds.colorgrouppriceitem.AddcolorgrouppriceitemRow(row);
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from colorgroupcustom where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.colorgroupcustom);
            this.db.command.CommandText = "select * from colorgroupprice where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.colorgroupprice);
            this.db.command.CommandText = "select * from color where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.color);
            this.db.command.CommandText = "select * from colorgrouppriceitem where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.colorgrouppriceitem);
        }

        public override bool SaveToBase()
        {
            try
            {
                this.db.SaveDatatable2((DataTable)this.ds.colorgroupcustom);
                this.db.SaveDatatable2((DataTable)this.ds.colorgroupprice);
                this.db.SaveDatatable2((DataTable)this.ds.colorgrouppriceitem);
                this.ds.AcceptChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            if (AtDataSet.quModifDataSet((DataSet)this.ds) > 0)
            {
                if (MessageBox.Show("Есть несохраненные данные, отменить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
                    return;
                this.LoadFromBase();
            }
            else
                this.LoadFromBase();
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormColorPrice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AtDataSet.quModifDataSet((DataSet)this.ds) <= 0)
                return;
            switch (MessageBox.Show("Есть несохраненные данные, сохранить?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    this.SaveToBase();
                    break;
            }
        }

        private void repositoryItemLookUpEdit1_EditValueChanging(object sender, ChangingEventArgs e)
        {
        }

        private void repositoryItemLookUpEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != ButtonPredefines.Minus)
                return;
            foreach (ds_colorgroupcustom.colorgrouppriceitemRow colorgrouppriceitemRow in AtGrid.getSelectedDataRows((Control)this.gridControlPriceGroupItem))
            {
                if (this.gridViewPriceGroupItem.FocusedColumn.FieldName == "idcolor1")
                    colorgrouppriceitemRow.Setidcolor1Null();
                else
                    colorgrouppriceitemRow.Setidcolor2Null();
                colorgrouppriceitemRow.EndEdit();
            }
            this.gridViewPriceGroupItem.RefreshEditor(true);
        }

        private void gridViewPriceGroupItem_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ds_colorgroupcustom.colorgrouppriceitemRow drCPI = this.gridViewPriceGroupItem.GetDataRow(e.PrevFocusedRowHandle) as ds_colorgroupcustom.colorgrouppriceitemRow;
            this.Flag = true;
            this.CheckColorRow(drCPI);
            this.Flag = false;
        }

        private void gridViewPriceGroupItem_LostFocus(object sender, EventArgs e)
        {
            int num = this.Flag ? 1 : 0;
        }

        private void CheckColorRow(ds_colorgroupcustom.colorgrouppriceitemRow drCPI)
        {
            if (drCPI == null || drCPI.Isidcolor1Null() && drCPI.Isidcolor2Null())
                return;
            foreach (ds_colorgroupcustom.colorgrouppriceRow colorgrouppriceRow in this.ds.colorgroupprice.Select("idcolorgroupcustom=" + (object)this.ds.colorgroupprice.FindByidcolorgroupprice(drCPI.idcolorgroupprice).idcolorgroupcustom))
            {
                if (this.ds.colorgrouppriceitem.Select("idcolorgroupprice=" + (object)colorgrouppriceRow.idcolorgroupprice + " and idcolorgrouppriceitem<>" + (string)(object)drCPI.idcolorgrouppriceitem + " and isnull(idcolor1,0)=" + (string)(object)(drCPI.Isidcolor1Null() ? 0 : drCPI.idcolor1) + " and isnull(idcolor2,0)=" + (string)(object)(drCPI.Isidcolor2Null() ? 0 : drCPI.idcolor2)).Length > 0)
                {
                    int num = (int)MessageBox.Show("Цвета в ценовых группах должны быть уникальными!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    drCPI.Setidcolor1Null();
                    drCPI.Setidcolor2Null();
                    drCPI.EndEdit();
                    break;
                }
            }
        }

        private void toolStripMenuItemPriceGroupItemAdd_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in AtGrid.getSelectedDataRows((Control)this.gridControlPriceGroupItem))
                dataRow.Delete();
        }
    }
}
