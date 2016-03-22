// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ColorForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
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
    public class ColorForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridControl gridControl6;
        private GridView gridView6;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colcolor1;
        private RepositoryItemColorEdit repositoryItemColorEdit1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private GridColumn colcolorgroup;
        private GridColumn colwindraw;
        private GridColumn colshortname;
        private TreeList treeList1;
        private TreeListColumn treeListColumn1;
        private SplitterControl splitterControl1;
        private ds ds;
        private GridColumn colidcolorgroup;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem7;
        private ImageList imageList1;
        private TreeListColumn treeListColumn2;
        private GridColumn colnumpos;
        private TreeListColumn treeListColumn3;
        public DataTable table_color;
        public bool groupChanging;

        public ColorForm()
        {
            this.InitializeComponent();
            this.table_color = this.ds.Tables["color"];
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.ColorForm_FormClosing);
            this.treeList1.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.KeyDown += new KeyEventHandler(this.treeList1_KeyDown);
            this.Shown += new Shown(this.ColorForm_Shown);
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ColorForm));
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.gridControl6 = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItem7 = new ToolStripMenuItem();
            this.ds = new ds();
            this.gridView6 = new GridView();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colcolor1 = new GridColumn();
            this.repositoryItemColorEdit1 = new RepositoryItemColorEdit();
            this.colcolorgroup = new GridColumn();
            this.colwindraw = new GridColumn();
            this.colshortname = new GridColumn();
            this.colidcolorgroup = new GridColumn();
            this.colnumpos = new GridColumn();
            this.treeList1 = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.treeListColumn2 = new TreeListColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.treeListColumn3 = new TreeListColumn();
            this.contextMenuStrip2 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.toolStripMenuItem5 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem6 = new ToolStripMenuItem();
            this.imageList1 = new ImageList(this.components);
            this.splitterControl1 = new SplitterControl();
            this.panel1.SuspendLayout();
            this.gridControl6.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.gridView6.BeginInit();
            this.repositoryItemColorEdit1.BeginInit();
            this.treeList1.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(796, 33);
            this.panel1.TabIndex = 3;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(709, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(628, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(547, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl6.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl6.DataMember = "color";
            this.gridControl6.DataSource = (object)this.ds;
            this.gridControl6.Dock = DockStyle.Fill;
            this.gridControl6.EmbeddedNavigator.Name = "";
            this.gridControl6.Location = new Point(306, 0);
            this.gridControl6.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl6.MainView = (BaseView)this.gridView6;
            this.gridControl6.Name = "gridControl6";
            this.gridControl6.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemColorEdit1
      });
            this.gridControl6.Size = new Size(490, 443);
            this.gridControl6.TabIndex = 10;
            this.gridControl6.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView6
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripMenuItem7
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(200, 76);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(199, 22);
            this.toolStripMenuItem1.Text = "Добавить цвет";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(199, 22);
            this.toolStripMenuItem2.Text = "Удалить цвет";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(196, 6);
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new Size(199, 22);
            this.toolStripMenuItem7.Text = "Переместить в группу...";
            this.toolStripMenuItem7.Click += new EventHandler(this.toolStripMenuItem7_Click);
            this.ds.DataSetName = "ds";
            this.ds.EnforceConstraints = false;
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridView6.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView6.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView6.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView6.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView6.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView6.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView6.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView6.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView6.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView6.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView6.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView6.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView6.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView6.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView6.BorderStyle = BorderStyles.Simple;
            this.gridView6.Columns.AddRange(new GridColumn[8]
      {
        this.colname,
        this.colcomment,
        this.colcolor1,
        this.colcolorgroup,
        this.colwindraw,
        this.colshortname,
        this.colidcolorgroup,
        this.colnumpos
      });
            this.gridView6.GridControl = this.gridControl6;
            this.gridView6.GroupPanelText = "Панель группировки";
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsCustomization.AllowFilter = false;
            this.gridView6.OptionsDetail.ShowDetailTabs = false;
            this.gridView6.OptionsSelection.MultiSelect = true;
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView6.OptionsView.ShowIndicator = false;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 90;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 3;
            this.colcomment.Width = 153;
            this.colcolor1.Caption = "Цвет";
            this.colcolor1.ColumnEdit = (RepositoryItem)this.repositoryItemColorEdit1;
            this.colcolor1.FieldName = "color";
            this.colcolor1.Name = "colcolor1";
            this.colcolor1.Visible = true;
            this.colcolor1.VisibleIndex = 4;
            this.colcolor1.Width = 49;
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            this.repositoryItemColorEdit1.StoreColorAsInteger = true;
            this.colcolorgroup.Caption = "Группа";
            this.colcolorgroup.FieldName = "colorgroup";
            this.colcolorgroup.Name = "colcolorgroup";
            this.colcolorgroup.Visible = true;
            this.colcolorgroup.VisibleIndex = 0;
            this.colcolorgroup.Width = 46;
            this.colwindraw.Caption = "Конструкции";
            this.colwindraw.FieldName = "windraw";
            this.colwindraw.Name = "colwindraw";
            this.colwindraw.Visible = true;
            this.colwindraw.VisibleIndex = 5;
            this.colwindraw.Width = 49;
            this.colshortname.Caption = "Сокращенное наименование";
            this.colshortname.FieldName = "shortname";
            this.colshortname.Name = "colshortname";
            this.colshortname.Visible = true;
            this.colshortname.VisibleIndex = 2;
            this.colshortname.Width = 103;
            this.colidcolorgroup.Caption = "idcolorgroup";
            this.colidcolorgroup.FieldName = "idcolorgroup";
            this.colidcolorgroup.Name = "colidcolorgroup";
            this.colnumpos.Caption = "№пп";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 6;
            this.treeList1.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeList1.Appearance.FocusedCell.ForeColor = Color.Black;
            this.treeList1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeList1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeList1.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeList1.Appearance.FocusedRow.ForeColor = Color.Black;
            this.treeList1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeList1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeList1.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeList1.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeList1.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.treeList1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeList1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeList1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeList1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.treeList1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeList1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeList1.BorderStyle = BorderStyles.Simple;
            this.treeList1.Columns.AddRange(new TreeListColumn[3]
      {
        this.treeListColumn1,
        this.treeListColumn2,
        this.treeListColumn3
      });
            this.treeList1.ContextMenuStrip = this.contextMenuStrip2;
            this.treeList1.DataMember = "colorgroup";
            this.treeList1.DataSource = (object)this.ds;
            this.treeList1.Dock = DockStyle.Left;
            this.treeList1.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeList1.ImageIndexFieldName = "_image";
            this.treeList1.KeyFieldName = "idcolorgroup";
            this.treeList1.Location = new Point(0, 0);
            this.treeList1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.ParentFieldName = "parentid";
            this.treeList1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemCheckEdit1
      });
            this.treeList1.SelectImageList = (object)this.imageList1;
            this.treeList1.Size = new Size(300, 443);
            this.treeList1.TabIndex = 11;
            this.treeListColumn1.Caption = "Группы цветов";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 28;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 196;
            this.treeListColumn2.Caption = "Активность";
            this.treeListColumn2.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit1;
            this.treeListColumn2.FieldName = "isactive";
            this.treeListColumn2.Format.FormatType = FormatType.Numeric;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.treeListColumn3.Caption = "№пп";
            this.treeListColumn3.FieldName = "numpos";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.contextMenuStrip2.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.toolStripMenuItem3,
        (ToolStripItem) this.toolStripMenuItem4,
        (ToolStripItem) this.toolStripMenuItem5,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem6
      });
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new Size(221, 98);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(220, 22);
            this.toolStripMenuItem3.Text = "Добавить основную группу";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new Size(220, 22);
            this.toolStripMenuItem4.Text = "Добавить дочернюю группу";
            this.toolStripMenuItem4.Click += new EventHandler(this.toolStripMenuItem4_Click);
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new Size(220, 22);
            this.toolStripMenuItem5.Text = "Переименовать";
            this.toolStripMenuItem5.Click += new EventHandler(this.toolStripMenuItem5_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(217, 6);
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new Size(220, 22);
            this.toolStripMenuItem6.Text = "Удалить";
            this.toolStripMenuItem6.Click += new EventHandler(this.toolStripMenuItem6_Click);
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.splitterControl1.Location = new Point(300, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 443);
            this.splitterControl1.TabIndex = 12;
            this.splitterControl1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl6);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeList1);
            this.Controls.Add((Control)this.panel1);
            this.Name = "ColorForm";
            this.Size = new Size(796, 476);
            this.Text = "Цвета";
            this.Load += new EventHandler(this.ColorForm_Load);
            this.panel1.ResumeLayout(false);
            this.gridControl6.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.gridView6.EndInit();
            this.repositoryItemColorEdit1.EndInit();
            this.treeList1.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void ColorForm_Shown(object sender, EventArgs e)
        {
            this.treeList1.MoveLastVisible();
            this.treeList1.MoveFirst();
        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            TreeList_KeyDown.Key(this.treeList1, e.KeyCode);
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.treeList1.Selection.Count == 0 || this.table_color.Rows.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.Selection[0])).Row;
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl6);
            if (this.groupChanging && selectedDataRows != null)
            {
                foreach (DataRow dataRow in selectedDataRows)
                    dataRow["idcolorgroup"] = row["idcolorgroup"];
                this.groupChanging = false;
            }
            this.gridView6.ClearColumnsFilter();
            this.gridView6.Columns["idcolorgroup"].FilterInfo = new ColumnFilterInfo("[idcolorgroup] = " + row["idcolorgroup"].ToString(), "");
        }

        private void ColorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet((DataSet)this.ds) <= 0)
                return;
            switch (MessageBox.Show("Сохранить изменения?", "Закрытие формы цветов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
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
            this.db.command.CommandText = "select * from color where deleted is null";
            this.db.adapter.Fill(this.table_color);
            this.db.command.CommandText = "select * from colorgroup where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.colorgroup);
            this.ds.AcceptChanges();
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDatatable2((DataTable)this.ds.colorgroup) || !this.db.SaveDatatable2(this.table_color))
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

        private void ColorForm_Load(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.groupChanging = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null)
                return;
            DataRow row = this.table_color.NewRow();
            row["idcolor"] = (object)dbconn.GetGenId("gen_color");
            row["name"] = (object)"Новый цвет";
            row["windraw"] = (object)1;
            row["idcolorgroup"] = selectedNode["idcolorgroup"];
            row["color"] = (object)-1;
            this.table_color.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl6);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow row = this.ds.colorgroup.NewRow();
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["idcolorgroup"] = (object)dbconn.GetGenId("gen_colorgroup");
            row["name"] = (object)InputBox.Value;
            row["isactive"] = (object)1;
            this.ds.colorgroup.Rows.Add(row);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (this.treeList1.Selection.Count == 0)
                return;
            DataRow row1 = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.Selection[0])).Row;
            DataRow row2 = this.ds.colorgroup.NewRow();
            if (InputBox.ShowDialog("Создание дочерней группы", "Введите имя", row2["name"].ToString()) == DialogResult.Cancel)
                return;
            row2["idcolorgroup"] = (object)dbconn.GetGenId("gen_colorgroup");
            row2["name"] = (object)InputBox.Value;
            row2["isactive"] = (object)1;
            row2["parentid"] = row1["idcolorgroup"];
            this.ds.colorgroup.Rows.Add(row2);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (this.treeList1.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.Selection[0])).Row;
            if (InputBox.ShowDialog("Изменить имя", "Введите новое имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (this.treeList1.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.Selection[0])).Row;
            foreach (DataRow dataRow in AtTreeList.GetListNodesRows(this.treeList1, this.treeList1.FocusedNode))
                dataRow.Delete();
        }
    }
}
