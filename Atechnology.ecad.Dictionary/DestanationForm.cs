// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.DestanationForm
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class DestanationForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Button button4;
        private Button button5;
        public GridControl gridControl1;
        private GridView gridView1;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ds ds1;
        private GridColumn coliddestanation;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn coldestanationgroup;
        private GridColumn colnumpos;
        private GridColumn colpyramyd_name;
        private RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private GridColumn coladdint1;
        private GridColumn coladdint2;
        private GridColumn coladdint3;
        private GridColumn coladdnum1;
        private GridColumn coladdnum2;
        private GridColumn coladdnum3;
        private GridColumn coladdstr1;
        private GridColumn coladdstr2;
        private GridColumn coladdstr3;
        private GridColumn colpyrgrouping;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private GridColumn colidpreference;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private PopupContainerControl popupContainerControl1;
        private CheckedListBox checkedListBox1;
        private TreeView treeView2;
        private GridColumn colroutes;
        private RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private string value;

        public DataRow SelectedRow
        {
            get
            {
                return AtGrid.getDataRow((Control)this.gridControl1);
            }
        }

        public DestanationForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.repositoryItemLookUpEdit1.DataSource = (object)this.ds1.route;
            this.repositoryItemLookUpEdit1.ValueMember = "idroute";
            this.repositoryItemLookUpEdit1.DisplayMember = "name";
            this.repositoryItemLookUpEdit2.DataSource = (object)new DataTable()
            {
                Columns = {
          {
            "value",
            typeof (int)
          },
          {
            "name",
            typeof (string)
          }
        },
                Rows = {
          {
            (object) 0,
            (object) "Нет"
          },
          {
            (object) 1,
            (object) "Дилеры совместно"
          }
        }
            };
            this.repositoryItemLookUpEdit2.ValueMember = "value";
            this.repositoryItemLookUpEdit2.DisplayMember = "name";
            this.repositoryItemLookUpEdit3.DataSource = (object)this.ds1.preference;
            this.repositoryItemLookUpEdit3.ValueMember = "idpreference";
            this.repositoryItemLookUpEdit3.DisplayMember = "name";
            this.FormClosing += new FormClosing(this.DestanationForm_FormClosing);
            this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
            this.gridView1.KeyDown += new KeyEventHandler(this.gridView1_KeyDown);
            this.repositoryItemButtonEdit1.ButtonClick += new ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
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
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.gridControl1 = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.ds1 = new ds();
            this.gridView1 = new GridView();
            this.coliddestanation = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.coldestanationgroup = new GridColumn();
            this.colnumpos = new GridColumn();
            this.colpyramyd_name = new GridColumn();
            this.repositoryItemButtonEdit1 = new RepositoryItemButtonEdit();
            this.coladdint1 = new GridColumn();
            this.coladdint2 = new GridColumn();
            this.coladdint3 = new GridColumn();
            this.coladdnum1 = new GridColumn();
            this.coladdnum2 = new GridColumn();
            this.coladdnum3 = new GridColumn();
            this.coladdstr1 = new GridColumn();
            this.coladdstr2 = new GridColumn();
            this.coladdstr3 = new GridColumn();
            this.colpyrgrouping = new GridColumn();
            this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
            this.colidpreference = new GridColumn();
            this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
            this.colroutes = new GridColumn();
            this.repositoryItemPopupContainerEdit1 = new RepositoryItemPopupContainerEdit();
            this.popupContainerControl1 = new PopupContainerControl();
            this.checkedListBox1 = new CheckedListBox();
            this.treeView2 = new TreeView();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.repositoryItemCalcEdit1 = new RepositoryItemCalcEdit();
            this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds1.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemButtonEdit1.BeginInit();
            this.repositoryItemLookUpEdit2.BeginInit();
            this.repositoryItemLookUpEdit3.BeginInit();
            this.repositoryItemPopupContainerEdit1.BeginInit();
            this.popupContainerControl1.BeginInit();
            this.popupContainerControl1.SuspendLayout();
            this.repositoryItemComboBox1.BeginInit();
            this.repositoryItemCalcEdit1.BeginInit();
            this.repositoryItemLookUpEdit1.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1068, 33);
            this.panel1.TabIndex = 1;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(981, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(900, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(819, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(1068, 33);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(981, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отмена";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.OK;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(900, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выбрать";
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "destanation";
            this.gridControl1.DataSource = (object)this.ds1;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(0, 0);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[7]
      {
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.repositoryItemButtonEdit1,
        (RepositoryItem) this.repositoryItemCalcEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit2,
        (RepositoryItem) this.repositoryItemLookUpEdit3,
        (RepositoryItem) this.repositoryItemPopupContainerEdit1
      });
            this.gridControl1.Size = new Size(1068, 420);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem3
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(147, 76);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(146, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(146, 22);
            this.toolStripMenuItem2.Text = "Дублировать";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(143, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(146, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.ds1.DataSetName = "ds";
            this.ds1.EnforceConstraints = false;
            this.ds1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
            this.gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.BorderStyle = BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new GridColumn[18]
      {
        this.coliddestanation,
        this.colname,
        this.colcomment,
        this.coldestanationgroup,
        this.colnumpos,
        this.colpyramyd_name,
        this.coladdint1,
        this.coladdint2,
        this.coladdint3,
        this.coladdnum1,
        this.coladdnum2,
        this.coladdnum3,
        this.coladdstr1,
        this.coladdstr2,
        this.coladdstr3,
        this.colpyrgrouping,
        this.colidpreference,
        this.colroutes
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsLayout.StoreVisualOptions = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.coliddestanation.Caption = "#";
            this.coliddestanation.FieldName = "iddestanation";
            this.coliddestanation.Name = "coliddestanation";
            this.coliddestanation.OptionsColumn.AllowEdit = false;
            this.coliddestanation.Visible = true;
            this.coliddestanation.VisibleIndex = 5;
            this.coliddestanation.Width = 61;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 243;
            this.colcomment.Caption = "Описание";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 4;
            this.colcomment.Width = 179;
            this.coldestanationgroup.Caption = "Группа";
            this.coldestanationgroup.FieldName = "destanationgroup";
            this.coldestanationgroup.Name = "coldestanationgroup";
            this.coldestanationgroup.Visible = true;
            this.coldestanationgroup.VisibleIndex = 1;
            this.coldestanationgroup.Width = 108;
            this.colnumpos.Caption = "№пп";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 0;
            this.colnumpos.Width = 57;
            this.colpyramyd_name.Caption = "Пирамиды";
            this.colpyramyd_name.ColumnEdit = (RepositoryItem)this.repositoryItemButtonEdit1;
            this.colpyramyd_name.FieldName = "pyramid_name";
            this.colpyramyd_name.Name = "colpyramyd_name";
            this.colpyramyd_name.Visible = true;
            this.colpyramyd_name.VisibleIndex = 3;
            this.colpyramyd_name.Width = 98;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.coladdint1.Caption = "Доп. ц. число1";
            this.coladdint1.FieldName = "addint1";
            this.coladdint1.Name = "coladdint1";
            this.coladdint1.Visible = true;
            this.coladdint1.VisibleIndex = 6;
            this.coladdint2.Caption = "Доп. ц. число2";
            this.coladdint2.FieldName = "addint2";
            this.coladdint2.Name = "coladdint2";
            this.coladdint2.Visible = true;
            this.coladdint2.VisibleIndex = 7;
            this.coladdint3.Caption = "Доп. ц. число3";
            this.coladdint3.FieldName = "addint3";
            this.coladdint3.Name = "coladdint3";
            this.coladdint3.Visible = true;
            this.coladdint3.VisibleIndex = 8;
            this.coladdnum1.Caption = "Доп. число1";
            this.coladdnum1.FieldName = "addnum1";
            this.coladdnum1.Name = "coladdnum1";
            this.coladdnum1.Visible = true;
            this.coladdnum1.VisibleIndex = 9;
            this.coladdnum2.Caption = "Доп. число2";
            this.coladdnum2.FieldName = "addnum2";
            this.coladdnum2.Name = "coladdnum2";
            this.coladdnum2.Visible = true;
            this.coladdnum2.VisibleIndex = 10;
            this.coladdnum3.Caption = "Доп. число3";
            this.coladdnum3.FieldName = "addnum3";
            this.coladdnum3.Name = "coladdnum3";
            this.coladdnum3.Visible = true;
            this.coladdnum3.VisibleIndex = 11;
            this.coladdstr1.Caption = "Доп. строка1";
            this.coladdstr1.FieldName = "addstr1";
            this.coladdstr1.Name = "coladdstr1";
            this.coladdstr1.Visible = true;
            this.coladdstr1.VisibleIndex = 12;
            this.coladdstr2.Caption = "Доп. строка2";
            this.coladdstr2.FieldName = "addstr2";
            this.coladdstr2.Name = "coladdstr2";
            this.coladdstr2.Visible = true;
            this.coladdstr2.VisibleIndex = 13;
            this.coladdstr3.Caption = "Доп. строка3";
            this.coladdstr3.FieldName = "addstr3";
            this.coladdstr3.Name = "coladdstr3";
            this.coladdstr3.Visible = true;
            this.coladdstr3.VisibleIndex = 14;
            this.colpyrgrouping.Caption = "Группировка пирамид";
            this.colpyrgrouping.ColumnEdit = (RepositoryItem)this.repositoryItemLookUpEdit2;
            this.colpyrgrouping.FieldName = "pyrgrouping";
            this.colpyrgrouping.Name = "colpyrgrouping";
            this.colpyrgrouping.Visible = true;
            this.colpyrgrouping.VisibleIndex = 15;
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemLookUpEdit2.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("name", "Значение", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None)
      });
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.colidpreference.Caption = "Настройки плана";
            this.colidpreference.ColumnEdit = (RepositoryItem)this.repositoryItemLookUpEdit3;
            this.colidpreference.FieldName = "idpreference";
            this.colidpreference.Name = "colidpreference";
            this.colidpreference.Visible = true;
            this.colidpreference.VisibleIndex = 16;
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemLookUpEdit3.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("name", "Наименование", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None)
      });
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.colroutes.Caption = "Группы маршрутов";
            this.colroutes.ColumnEdit = (RepositoryItem)this.repositoryItemPopupContainerEdit1;
            this.colroutes.FieldName = "iddestanation";
            this.colroutes.Name = "colroutes";
            this.colroutes.Visible = true;
            this.colroutes.VisibleIndex = 17;
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            this.repositoryItemPopupContainerEdit1.PopupControl = this.popupContainerControl1;
            this.repositoryItemPopupContainerEdit1.Popup += new EventHandler(this.repositoryItemPopupContainerEdit1_Popup);
            this.repositoryItemPopupContainerEdit1.QueryDisplayText += new QueryDisplayTextEventHandler(this.repositoryItemPopupContainerEdit1_QueryDisplayText);
            this.repositoryItemPopupContainerEdit1.QueryResultValue += new QueryResultValueEventHandler(this.repositoryItemPopupContainerEdit1_QueryResultValue);
            this.repositoryItemPopupContainerEdit1.QueryPopUp += new CancelEventHandler(this.repositoryItemPopupContainerEdit1_QueryPopUp);
            this.popupContainerControl1.Controls.Add((Control)this.checkedListBox1);
            this.popupContainerControl1.Controls.Add((Control)this.treeView2);
            this.popupContainerControl1.Location = new Point(435, 128);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new Size(198, 231);
            this.popupContainerControl1.TabIndex = 9;
            this.checkedListBox1.Dock = DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new Size(198, 229);
            this.checkedListBox1.TabIndex = 2;
            this.treeView2.BorderStyle = BorderStyle.None;
            this.treeView2.Dock = DockStyle.Fill;
            this.treeView2.Location = new Point(0, 0);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new Size(198, 231);
            this.treeView2.TabIndex = 1;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemLookUpEdit1.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("name", "Наименование", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None)
      });
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.popupContainerControl1);
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "DestanationForm";
            this.Size = new Size(1068, 486);
            this.Text = "Маршруты";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds1.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemButtonEdit1.EndInit();
            this.repositoryItemLookUpEdit2.EndInit();
            this.repositoryItemLookUpEdit3.EndInit();
            this.repositoryItemPopupContainerEdit1.EndInit();
            this.popupContainerControl1.EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            this.repositoryItemComboBox1.EndInit();
            this.repositoryItemCalcEdit1.EndInit();
            this.repositoryItemLookUpEdit1.EndInit();
            this.ResumeLayout(false);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow1 == null)
                return;
            PyramidForm pyramidForm = new PyramidForm();
            pyramidForm.IsDialog();
            if (pyramidForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow2 = AtGrid.getDataRow((Control)pyramidForm.gridControl1);
            if (dataRow2 == null)
                return;
            dataRow1["idpyramid"] = dataRow2["idpyramid"];
            dataRow1["pyramid_name"] = dataRow2["name"];
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.Is_Dialog || e.KeyCode != Keys.Return)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!this.panel2.Visible)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DestanationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet((DataSet)this.ds1) <= 0)
                return;
            switch (MessageBox.Show("Сохранить изменения?", "Закрытие формы маршрутов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
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
            this.db.command.CommandText = "select * from view_destanation where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds1.destanation);
            this.db.command.CommandText = "select * from route where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds1.route);
            this.db.command.CommandText = "select * from preference where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds1.preference);
            this.db.command.CommandText = "select * from destanationroute where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds1.destanationroute);
            foreach (DataRow dataRow in this.ds1.route)
                this.checkedListBox1.Items.Add((object)new DestanationForm.RouteItem(dataRow["name"].ToString(), (int)dataRow["idroute"]));
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDatatable2((DataTable)this.ds1.destanation))
                return false;
            this.ds1.destanation.AcceptChanges();
            if (!this.db.SaveDatatable2((DataTable)this.ds1.destanationroute))
                return false;
            this.ds1.destanationroute.AcceptChanges();
            return true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.ds1.destanation.NewRow();
            row["iddestanation"] = (object)dbconn.GetGenId("gen_destanation");
            row["name"] = (object)"Новый маршрут";
            this.ds1.destanation.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["iddestanation"] = (object)dbconn.GetGenId("gen_destanation");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds1.Clear();
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void IsDialog()
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Is_Dialog = true;
        }

        private void repositoryItemPopupContainerEdit1_Popup(object sender, EventArgs e)
        {
        }

        private void repositoryItemPopupContainerEdit1_QueryDisplayText(object sender, QueryDisplayTextEventArgs e)
        {
            if (e == null || e.EditValue == null)
                return;
            this.value = e.EditValue.ToString();
            e.DisplayText = "";
            if (string.IsNullOrEmpty(this.value))
                return;
            DataRow[] dataRowArray = this.ds1.destanationroute.Select("iddestanation = " + this.value);
            List<string> list = new List<string>();
            foreach (DataRow dataRow in dataRowArray)
                list.Add(dataRow["idroute"].ToString());
            for (int index = 0; index < this.checkedListBox1.Items.Count; ++index)
            {
                DestanationForm.RouteItem item = this.checkedListBox1.Items[index] as DestanationForm.RouteItem;
                if (list.Find((Predicate<string>)(x => x == item.ID.ToString())) != null)
                {
                    if (e.DisplayText != "")
                        e.DisplayText += ", ";
                    e.DisplayText += item.ToString();
                }
            }
        }

        private void repositoryItemPopupContainerEdit1_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (this.value == null)
                this.value = "";
            DataRow[] dataRowArray = this.ds1.destanationroute.Select("iddestanation = " + this.value);
            List<string> list = new List<string>();
            foreach (DataRow dataRow in dataRowArray)
                list.Add(dataRow["idroute"].ToString());
            for (int index = 0; index < this.checkedListBox1.Items.Count; ++index)
            {
                DestanationForm.RouteItem item = this.checkedListBox1.Items[index] as DestanationForm.RouteItem;
                if (list.Find((Predicate<string>)(x => x == item.ID.ToString())) != null)
                    this.checkedListBox1.SetItemChecked(index, true);
                else
                    this.checkedListBox1.SetItemChecked(index, false);
            }
        }

        private void repositoryItemPopupContainerEdit1_QueryResultValue(object sender, QueryResultValueEventArgs e)
        {
            this.value = e.Value.ToString();
            List<DataRow> list = new List<DataRow>((IEnumerable<DataRow>)this.ds1.destanationroute.Select("iddestanation = " + this.value));
            foreach (DestanationForm.RouteItem routeItem in (ListBox.ObjectCollection)this.checkedListBox1.Items)
            {
                DataRow[] dataRowArray = this.ds1.destanationroute.Select(string.Concat(new object[4]
        {
          (object) "iddestanation = ",
          (object) this.value,
          (object) " and idroute = ",
          (object) routeItem.ID
        }));
                DataRow dataRow1 = (DataRow)null;
                foreach (DataRow dataRow2 in dataRowArray)
                {
                    if (dataRow2.RowState != DataRowState.Deleted)
                    {
                        dataRow1 = dataRow2;
                        break;
                    }
                }
                if (this.checkedListBox1.CheckedItems.Contains((object)routeItem))
                {
                    if (dataRow1 == null)
                    {
                        ds.destanationrouteRow destanationrouteRow = this.ds1.destanationroute.NewdestanationrouteRow();
                        destanationrouteRow.iddestanation = (int)this.SelectedRow["iddestanation"];
                        destanationrouteRow.idroute = routeItem.ID;
                        destanationrouteRow.iddestanationroute = dbconn.GetGenId("gen_destanationroute");
                        this.ds1.destanationroute.Rows.Add((DataRow)destanationrouteRow);
                    }
                }
                else if (dataRow1 != null)
                    dataRow1.Delete();
            }
        }

        private class RouteItem
        {
            private string name;

            public int ID { get; set; }

            public RouteItem(string name, int ID)
            {
                this.name = name;
                this.ID = ID;
            }

            public override string ToString()
            {
                return this.name;
            }
        }
    }
}
