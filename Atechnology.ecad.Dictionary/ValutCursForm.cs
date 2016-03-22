// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ValutCursForm
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
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraScheduler;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class ValutCursForm : AtUserControl
    {
        private string lAwayCurrentDateTemplateString;
        private string lCurrentDateTemplateString;
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridControl gridControl6;
        private GridView gridView6;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit2;
        private ds_valut ds_valut1;
        private GridColumn colidvalutrate;
        private GridColumn colidvalut;
        private GridColumn colidvalut2;
        private GridColumn colsm;
        private GridColumn coldt;
        private GridColumn coldeleted;
        private GridColumn colvalut_shortname;
        private GridColumn colvalut_shortname2;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private BindingSource valutBindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem2;
        private DateNavigator dateNavigator1;
        private Panel panel2;
        private SplitterControl splitterControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit3;
        private AtRepositoryItemTextEdit repositoryItemTextEdit4;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private SplitterControl splitterControl2;
        private GridColumn coldt1;
        private GridColumn colsm1;
        private GridColumn colvalut_shortname1;
        private Label lCurrentDate;
        private Label lAwayCurrentDate;

        public ValutCursForm()
        {
            this.InitializeComponent();
            this.lAwayCurrentDateTemplateString = this.lAwayCurrentDate.Text;
            this.lCurrentDateTemplateString = this.lCurrentDate.Text;
            this.LoadFromBase();
            this.gridView6.OptionsCustomization.AllowSort = false;
            this.dateNavigator1.EditDateModified += new EventHandler(this.dateNavigator1_EditDateModified);
            this.dateNavigator1.DateTime = DateTime.Now;
        }

        private void dateNavigator1_EditDateModified(object sender, EventArgs e)
        {
            this.ReloadCurs();
        }

        public override void LoadFromBase()
        {
            this.ds_valut1.Clear();
            this.db.command.CommandText = "select * from valut where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds_valut1.valut);
            this.db.command.CommandText = "select * from valutrate where deleted is null and dbo.atdate1(dt) = @d";
            this.db.command.Parameters.Add("@d", SqlDbType.DateTime).Value = (object)DateTime.Now;
            this.db.adapter.Fill((DataTable)this.ds_valut1.valutrate);
            this.db.command.Parameters.Clear();
            this.ds_valut1.valutrate2.Clear();
            this.db.command.Parameters.Add("@d", SqlDbType.DateTime).Value = (object)this.dateNavigator1.SelectionStart;
            this.db.command.CommandText = "select d.*, shortname valut_shortname\r\n\t\t\t\t\t\t\t\t\t\t\t\tfrom valut v outer apply\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t (select top 1 * \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tfrom valutrate r \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\twhere deleted is null \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tand r.idvalut2 = v.idvalut \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tand dbo.atdate1(dt) <= @d\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\torder by r.dt desc) d\r\n\t\t\t\t\t\t\t\t\t\t\t\t\twhere isbase <> 1 and v.deleted is null";
            this.db.adapter.Fill((DataTable)this.ds_valut1.valutrate2);
            this.db.command.Parameters.Clear();
        }

        public override bool SaveToBase()
        {
            bool flag = this.db.SaveDatatableAndAccept2((DataTable)this.ds_valut1.valutrate);
            this.gridView1.RefreshData();
            this.gridView6.RefreshData();
            return flag;
        }

        private void ReloadCurs()
        {
            if (this.db.quModifDataTable((DataTable)this.ds_valut1.valutrate) > 0)
                this.db.SaveDatatable2((DataTable)this.ds_valut1.valutrate);
            this.ds_valut1.valutrate.Clear();
            this.db.command.CommandText = "select * from valutrate where deleted is null and dbo.atdate1(dt) = @d";
            this.db.command.Parameters.Add("@d", SqlDbType.DateTime).Value = (object)this.dateNavigator1.SelectionStart;
            this.db.adapter.Fill((DataTable)this.ds_valut1.valutrate);
            this.db.command.Parameters.Clear();
            this.ds_valut1.valutrate2.Clear();
            this.db.command.Parameters.Add("@d", SqlDbType.DateTime).Value = (object)this.dateNavigator1.SelectionStart;
            this.db.command.CommandText = "select d.*, shortname valut_shortname\r\n\t\t\t\t\t\t\t\t\t\t\t\tfrom valut v outer apply\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t (select top 1 * \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tfrom valutrate r \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\twhere deleted is null \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tand r.idvalut2 = v.idvalut \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tand dbo.atdate1(dt) <= @d\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\torder by r.dt desc) d\r\n\t\t\t\t\t\t\t\t\t\t\t\t\twhere isbase <> 1 and v.deleted is null";
            this.db.adapter.Fill((DataTable)this.ds_valut1.valutrate2);
            this.db.command.Parameters.Clear();
            this.lCurrentDate.Text = string.Format("{0} {1}", (object)this.lCurrentDateTemplateString, (object)this.dateNavigator1.SelectionStart.ToShortDateString());
            this.lAwayCurrentDate.Text = string.Format("{0} {1}", (object)this.lAwayCurrentDateTemplateString, (object)this.dateNavigator1.SelectionStart.ToShortDateString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds_valut1.Clear();
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.db.quModifDataSet((DataSet)this.ds_valut1) > 0 && MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.SaveToBase();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.ds_valut1.valutrate.NewRow();
            this.ds_valut1.valutrate.Rows.Add(row);
            row["idvalutrate"] = (object)dbconn.GetGenId("gen_valutrate");
            row["idvalut"] = (object)1;
            row["sm"] = (object)0;
            row["dt"] = (object)DateTime.Now;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl6);
            if (dataRow == null)
                return;
            dataRow.Delete();
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
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.gridControl6 = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.ds_valut1 = new ds_valut();
            this.gridView6 = new GridView();
            this.colidvalutrate = new GridColumn();
            this.colidvalut = new GridColumn();
            this.colidvalut2 = new GridColumn();
            this.colsm = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.coldt = new GridColumn();
            this.coldeleted = new GridColumn();
            this.colvalut_shortname = new GridColumn();
            this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
            this.valutBindingSource = new BindingSource(this.components);
            this.colvalut_shortname2 = new GridColumn();
            this.repositoryItemTextEdit2 = new AtRepositoryItemTextEdit();
            this.dateNavigator1 = new DateNavigator();
            this.panel2 = new Panel();
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.coldt1 = new GridColumn();
            this.colsm1 = new GridColumn();
            this.colvalut_shortname1 = new GridColumn();
            this.repositoryItemTextEdit3 = new AtRepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new AtRepositoryItemTextEdit();
            this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
            this.lAwayCurrentDate = new Label();
            this.splitterControl1 = new SplitterControl();
            this.lCurrentDate = new Label();
            this.splitterControl2 = new SplitterControl();
            this.panel1.SuspendLayout();
            this.gridControl6.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds_valut1.BeginInit();
            this.gridView6.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemLookUpEdit1.BeginInit();
            ((ISupportInitialize)this.valutBindingSource).BeginInit();
            this.repositoryItemTextEdit2.BeginInit();
            this.dateNavigator1.BeginInit();
            this.panel2.SuspendLayout();
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemTextEdit3.BeginInit();
            this.repositoryItemTextEdit4.BeginInit();
            this.repositoryItemLookUpEdit2.BeginInit();
            this.SuspendLayout();
            this.panel1.BackColor = SystemColors.Control;
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(941, 33);
            this.panel1.TabIndex = 5;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(854, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(773, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(692, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl6.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl6.DataMember = "valutrate";
            this.gridControl6.DataSource = (object)this.ds_valut1;
            this.gridControl6.Dock = DockStyle.Top;
            this.gridControl6.EmbeddedNavigator.Name = "";
            this.gridControl6.Location = new Point(0, 23);
            this.gridControl6.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl6.MainView = (BaseView)this.gridView6;
            this.gridControl6.Name = "gridControl6";
            this.gridControl6.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemTextEdit2,
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
            this.gridControl6.Size = new Size(295, 245);
            this.gridControl6.TabIndex = 12;
            this.gridControl6.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView6
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem2
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(125, 54);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(124, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(121, 6);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(124, 22);
            this.toolStripMenuItem2.Text = "Удалить";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.ds_valut1.DataSetName = "ds_valut";
            this.ds_valut1.EnforceConstraints = false;
            this.ds_valut1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
            this.gridView6.Appearance.Row.Options.UseTextOptions = true;
            this.gridView6.Appearance.Row.TextOptions.HAlignment = HorzAlignment.Center;
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
        this.colidvalutrate,
        this.colidvalut,
        this.colidvalut2,
        this.colsm,
        this.coldt,
        this.coldeleted,
        this.colvalut_shortname,
        this.colvalut_shortname2
      });
            this.gridView6.GridControl = this.gridControl6;
            this.gridView6.GroupPanelText = "Панель группировки";
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsCustomization.AllowFilter = false;
            this.gridView6.OptionsDetail.ShowDetailTabs = false;
            this.gridView6.OptionsView.ShowDetailButtons = false;
            this.gridView6.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.OptionsView.ShowIndicator = false;
            this.colidvalutrate.Caption = "idvalutrate";
            this.colidvalutrate.FieldName = "idvalutrate";
            this.colidvalutrate.Name = "colidvalutrate";
            this.colidvalut.Caption = "idvalut";
            this.colidvalut.FieldName = "idvalut";
            this.colidvalut.Name = "colidvalut";
            this.colidvalut2.Caption = "idvalut2";
            this.colidvalut2.FieldName = "idvalut2";
            this.colidvalut2.Name = "colidvalut2";
            this.colsm.Caption = "Курс (базовой)";
            this.colsm.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colsm.FieldName = "sm";
            this.colsm.Name = "colsm";
            this.colsm.Visible = true;
            this.colsm.VisibleIndex = 2;
            this.colsm.Width = 277;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.coldt.Caption = "Дата";
            this.coldt.FieldName = "dt";
            this.coldt.Name = "coldt";
            this.coldt.Visible = true;
            this.coldt.VisibleIndex = 0;
            this.coldt.Width = 152;
            this.coldeleted.Caption = "deleted";
            this.coldeleted.FieldName = "deleted";
            this.coldeleted.Name = "coldeleted";
            this.colvalut_shortname.Caption = "valut_shortname";
            this.colvalut_shortname.ColumnEdit = (RepositoryItem)this.repositoryItemLookUpEdit1;
            this.colvalut_shortname.FieldName = "valut_shortname";
            this.colvalut_shortname.Name = "colvalut_shortname";
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemLookUpEdit1.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("shortname", "Краткое название", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None),
        new LookUpColumnInfo("name", "Название", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None)
      });
            this.repositoryItemLookUpEdit1.DataSource = (object)this.valutBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "shortname";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "idvalut";
            this.valutBindingSource.DataMember = "valut";
            this.valutBindingSource.DataSource = (object)this.ds_valut1;
            this.colvalut_shortname2.Caption = "Валюта";
            this.colvalut_shortname2.ColumnEdit = (RepositoryItem)this.repositoryItemLookUpEdit1;
            this.colvalut_shortname2.FieldName = "idvalut2";
            this.colvalut_shortname2.Name = "colvalut_shortname2";
            this.colvalut_shortname2.Visible = true;
            this.colvalut_shortname2.VisibleIndex = 1;
            this.colvalut_shortname2.Width = 174;
            this.repositoryItemTextEdit2.AllowFocused = false;
            this.repositoryItemTextEdit2.Appearance.BackColor = Color.Silver;
            this.repositoryItemTextEdit2.Appearance.Options.UseBackColor = true;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.dateNavigator1.BorderStyle = BorderStyles.Simple;
            this.dateNavigator1.DateTime = new DateTime(2007, 4, 17, 0, 0, 0, 0);
            this.dateNavigator1.Dock = DockStyle.Fill;
            this.dateNavigator1.Location = new Point(0, 0);
            this.dateNavigator1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.dateNavigator1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateNavigator1.Multiselect = false;
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.ShowTodayButton = false;
            this.dateNavigator1.Size = new Size(640, 470);
            this.dateNavigator1.TabIndex = 15;
            this.dateNavigator1.View = DateEditCalendarViewType.MonthInfo;
            this.panel2.Controls.Add((Control)this.gridControl1);
            this.panel2.Controls.Add((Control)this.lAwayCurrentDate);
            this.panel2.Controls.Add((Control)this.splitterControl1);
            this.panel2.Controls.Add((Control)this.gridControl6);
            this.panel2.Controls.Add((Control)this.lCurrentDate);
            this.panel2.Dock = DockStyle.Right;
            this.panel2.Location = new Point(646, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(295, 470);
            this.panel2.TabIndex = 16;
            this.gridControl1.DataMember = "valutrate2";
            this.gridControl1.DataSource = (object)this.ds_valut1;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(0, 297);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemTextEdit3,
        (RepositoryItem) this.repositoryItemTextEdit4,
        (RepositoryItem) this.repositoryItemLookUpEdit2
      });
            this.gridControl1.Size = new Size(295, 173);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
            this.gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.BorderStyle = BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new GridColumn[3]
      {
        this.coldt1,
        this.colsm1,
        this.colvalut_shortname1
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.coldt1.Caption = "Дата";
            this.coldt1.FieldName = "dt";
            this.coldt1.Name = "coldt1";
            this.coldt1.Visible = true;
            this.coldt1.VisibleIndex = 0;
            this.coldt1.Width = 350;
            this.colsm1.Caption = "Курс (базовой)";
            this.colsm1.FieldName = "sm";
            this.colsm1.Name = "colsm1";
            this.colsm1.Visible = true;
            this.colsm1.VisibleIndex = 2;
            this.colsm1.Width = 306;
            this.colvalut_shortname1.Caption = "Валюта";
            this.colvalut_shortname1.FieldName = "valut_shortname";
            this.colvalut_shortname1.Name = "colvalut_shortname1";
            this.colvalut_shortname1.Visible = true;
            this.colvalut_shortname1.VisibleIndex = 1;
            this.colvalut_shortname1.Width = 388;
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit3.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit3.EditFormat.FormatString = "n2";
            this.repositoryItemTextEdit3.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit3.Mask.EditMask = "n2";
            this.repositoryItemTextEdit3.Mask.MaskType = MaskType.Numeric;
            this.repositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.repositoryItemTextEdit4.AllowFocused = false;
            this.repositoryItemTextEdit4.Appearance.BackColor = Color.Silver;
            this.repositoryItemTextEdit4.Appearance.Options.UseBackColor = true;
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemLookUpEdit2.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("shortname", "Краткое название", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None),
        new LookUpColumnInfo("name", "Название", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None)
      });
            this.repositoryItemLookUpEdit2.DataSource = (object)this.valutBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "shortname";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "idvalut";
            this.lAwayCurrentDate.Dock = DockStyle.Top;
            this.lAwayCurrentDate.Location = new Point(0, 274);
            this.lAwayCurrentDate.Name = "lAwayCurrentDate";
            this.lAwayCurrentDate.Size = new Size(295, 23);
            this.lAwayCurrentDate.TabIndex = 16;
            this.lAwayCurrentDate.Text = "Курсы на дату ближайшую от";
            this.lAwayCurrentDate.TextAlign = ContentAlignment.MiddleLeft;
            this.splitterControl1.Dock = DockStyle.Top;
            this.splitterControl1.Location = new Point(0, 268);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(295, 6);
            this.splitterControl1.TabIndex = 14;
            this.splitterControl1.TabStop = false;
            this.lCurrentDate.Dock = DockStyle.Top;
            this.lCurrentDate.Location = new Point(0, 0);
            this.lCurrentDate.Name = "lCurrentDate";
            this.lCurrentDate.Size = new Size(295, 23);
            this.lCurrentDate.TabIndex = 15;
            this.lCurrentDate.Text = "Курсы на";
            this.lCurrentDate.TextAlign = ContentAlignment.MiddleLeft;
            this.splitterControl2.Dock = DockStyle.Right;
            this.splitterControl2.Location = new Point(640, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new Size(6, 470);
            this.splitterControl2.TabIndex = 17;
            this.splitterControl2.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add((Control)this.dateNavigator1);
            this.Controls.Add((Control)this.splitterControl2);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "ValutCursForm";
            this.Size = new Size(941, 503);
            this.Text = "Курсы валют";
            this.panel1.ResumeLayout(false);
            this.gridControl6.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds_valut1.EndInit();
            this.gridView6.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemLookUpEdit1.EndInit();
            ((ISupportInitialize)this.valutBindingSource).EndInit();
            this.repositoryItemTextEdit2.EndInit();
            this.dateNavigator1.EndInit();
            this.panel2.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemTextEdit3.EndInit();
            this.repositoryItemTextEdit4.EndInit();
            this.repositoryItemLookUpEdit2.EndInit();
            this.ResumeLayout(false);
        }
    }
}
