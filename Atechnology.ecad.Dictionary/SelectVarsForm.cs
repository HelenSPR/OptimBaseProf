// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.SelectVarsForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
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
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class SelectVarsForm : AtUserControl
    {
        public DataRow[] Result;
        private IContainer components;
        private Panel panel1;
        private GridControl gridControlSetting;
        private GridView gridViewSetting;
        private GridColumn colname;
        private GridColumn colintvalue;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private GridColumn colstrvalue;
        private GridColumn colcomment;
        private GridColumn coltxtvalue;
        private RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private GridColumn colgroupname;
        private GridColumn colidsetting;
        private RepositoryItemImageEdit repositoryItemImageEdit1;
        private TreeList treeList1;
        private TreeListColumn treeListColumn1;
        private SplitterControl splitterControl1;
        private DataSet ds;
        private DataTable table_settinggroup;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private DataColumn dataColumn15;
        private DataTable table_setting;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn16;
        private ImageList imageList1;
        private DataColumn dataColumn9;
        private GridColumn coldtvalue;
        private RepositoryItemDateEdit repositoryItemDateEdit1;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private DataColumn dataColumn19;
        private GridColumn colintvalue2;
        public Button cmdCancel;
        public Button cmdRefresh;
        public Button cmdSelect;

        public SelectVarsForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.Shown += new Shown(this.VarsForm_Shown);
            this.FormClosing += new FormClosing(this.VarsForm_FormClosing);
            this.gridViewSetting.DoubleClick += new EventHandler(this.gridViewSetting_DoubleClick);
        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            TreeList_KeyDown.Key(this.treeList1, e.KeyCode);
        }

        private void VarsForm_Shown(object sender, EventArgs e)
        {
            this.treeList1.MoveLastVisible();
            this.treeList1.MoveFirst();
        }

        private void VarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void gridViewSetting_DoubleClick(object sender, EventArgs e)
        {
            this.cmdSelect_Click((object)null, (EventArgs)null);
        }

        public override void LoadFromBase()
        {
            this.db.command.Parameters.Clear();
            this.db.command.CommandText = "select * from settinggroup where deleted is null";
            this.db.adapter.Fill(this.table_settinggroup);
            this.db.command.CommandText = "select * from setting where deleted is null";
            this.db.adapter.Fill(this.table_setting);
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            this.Result = AtGrid.getSelectedDataRows((Control)this.gridControlSetting);
            if (this.Result == null || this.Result.Length == 0)
            {
                this.Result = (DataRow[])null;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            this.ds.Clear();
            this.LoadFromBase();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SelectVarsForm));
            this.panel1 = new Panel();
            this.cmdCancel = new Button();
            this.cmdRefresh = new Button();
            this.cmdSelect = new Button();
            this.gridControlSetting = new GridControl();
            this.ds = new DataSet();
            this.table_settinggroup = new DataTable();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn15 = new DataColumn();
            this.table_setting = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn16 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn17 = new DataColumn();
            this.dataColumn18 = new DataColumn();
            this.dataColumn19 = new DataColumn();
            this.gridViewSetting = new GridView();
            this.colidsetting = new GridColumn();
            this.colname = new GridColumn();
            this.colintvalue = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.colintvalue2 = new GridColumn();
            this.colstrvalue = new GridColumn();
            this.coltxtvalue = new GridColumn();
            this.colcomment = new GridColumn();
            this.colgroupname = new GridColumn();
            this.coldtvalue = new GridColumn();
            this.repositoryItemDateEdit1 = new RepositoryItemDateEdit();
            this.repositoryItemMemoExEdit1 = new RepositoryItemMemoExEdit();
            this.repositoryItemImageEdit1 = new RepositoryItemImageEdit();
            this.treeList1 = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.imageList1 = new ImageList(this.components);
            this.splitterControl1 = new SplitterControl();
            this.panel1.SuspendLayout();
            this.gridControlSetting.BeginInit();
            this.ds.BeginInit();
            this.table_settinggroup.BeginInit();
            this.table_setting.BeginInit();
            this.gridViewSetting.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemDateEdit1.BeginInit();
            this.repositoryItemDateEdit1.VistaTimeProperties.BeginInit();
            this.repositoryItemMemoExEdit1.BeginInit();
            this.repositoryItemImageEdit1.BeginInit();
            this.treeList1.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.cmdCancel);
            this.panel1.Controls.Add((Control)this.cmdRefresh);
            this.panel1.Controls.Add((Control)this.cmdSelect);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(705, 33);
            this.panel1.TabIndex = 2;
            this.cmdCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdCancel.FlatStyle = FlatStyle.Flat;
            this.cmdCancel.Location = new Point(618, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Закрыть";
            this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
            this.cmdRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdRefresh.FlatStyle = FlatStyle.Flat;
            this.cmdRefresh.Location = new Point(537, 5);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new Size(75, 23);
            this.cmdRefresh.TabIndex = 1;
            this.cmdRefresh.Text = "Обновить";
            this.cmdRefresh.Click += new EventHandler(this.cmdRefresh_Click);
            this.cmdSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdSelect.FlatStyle = FlatStyle.Flat;
            this.cmdSelect.Location = new Point(456, 5);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new Size(75, 23);
            this.cmdSelect.TabIndex = 0;
            this.cmdSelect.Text = "Выбрать";
            this.cmdSelect.Click += new EventHandler(this.cmdSelect_Click);
            this.gridControlSetting.DataMember = "settinggroup.FK_setting_settinggroup";
            this.gridControlSetting.DataSource = (object)this.ds;
            this.gridControlSetting.Dock = DockStyle.Fill;
            this.gridControlSetting.EmbeddedNavigator.Name = "";
            this.gridControlSetting.Location = new Point(246, 0);
            this.gridControlSetting.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlSetting.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlSetting.MainView = (BaseView)this.gridViewSetting;
            this.gridControlSetting.Name = "gridControlSetting";
            this.gridControlSetting.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemMemoExEdit1,
        (RepositoryItem) this.repositoryItemImageEdit1,
        (RepositoryItem) this.repositoryItemDateEdit1
      });
            this.gridControlSetting.Size = new Size(459, 333);
            this.gridControlSetting.TabIndex = 4;
            this.gridControlSetting.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewSetting
      });
            this.ds.DataSetName = "ds_setting";
            this.ds.EnforceConstraints = false;
            this.ds.Relations.AddRange(new DataRelation[1]
      {
        new DataRelation("FK_setting_settinggroup", "settinggroup", "setting", new string[1]
        {
          "idsettinggroup"
        }, new string[1]
        {
          "idsettinggroup"
        }, 0 != 0)
      });
            this.ds.Tables.AddRange(new DataTable[2]
      {
        this.table_settinggroup,
        this.table_setting
      });
            this.table_settinggroup.Columns.AddRange(new DataColumn[6]
      {
        this.dataColumn10,
        this.dataColumn11,
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14,
        this.dataColumn15
      });
            this.table_settinggroup.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idsettinggroup"
        }, 1 != 0)
      });
            this.table_settinggroup.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn10
      };
            this.table_settinggroup.TableName = "settinggroup";
            this.dataColumn10.AllowDBNull = false;
            this.dataColumn10.ColumnName = "idsettinggroup";
            this.dataColumn10.DataType = typeof(int);
            this.dataColumn11.ColumnName = "name";
            this.dataColumn12.ColumnName = "comment";
            this.dataColumn13.ColumnName = "isactive";
            this.dataColumn13.DataType = typeof(bool);
            this.dataColumn14.ColumnName = "parentid";
            this.dataColumn14.DataType = typeof(int);
            this.dataColumn15.ColumnName = "_image";
            this.dataColumn15.DataType = typeof(int);
            this.dataColumn15.DefaultValue = (object)0;
            this.table_setting.Columns.AddRange(new DataColumn[13]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn16,
        this.dataColumn9,
        this.dataColumn17,
        this.dataColumn18,
        this.dataColumn19
      });
            this.table_setting.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idsetting"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("Relation1", "settinggroup", new string[1]
        {
          "idsettinggroup"
        }, new string[1]
        {
          "idsettinggroup"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_setting.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_setting.TableName = "setting";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idsetting";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "intvalue";
            this.dataColumn3.DataType = typeof(double);
            this.dataColumn4.ColumnName = "strvalue";
            this.dataColumn5.ColumnName = "comment";
            this.dataColumn6.ColumnName = "txtvalue";
            this.dataColumn7.ColumnName = "blbvalue";
            this.dataColumn7.DataType = typeof(byte[]);
            this.dataColumn8.ColumnName = "groupname";
            this.dataColumn16.ColumnName = "idsettinggroup";
            this.dataColumn16.DataType = typeof(int);
            this.dataColumn9.ColumnName = "dtvalue";
            this.dataColumn9.DataType = typeof(DateTime);
            this.dataColumn17.ColumnName = "addorder";
            this.dataColumn17.DataType = typeof(bool);
            this.dataColumn18.ColumnName = "addmodel";
            this.dataColumn18.DataType = typeof(bool);
            this.dataColumn19.ColumnName = "intvalue2";
            this.dataColumn19.DataType = typeof(double);
            this.gridViewSetting.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewSetting.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewSetting.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewSetting.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewSetting.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewSetting.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewSetting.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewSetting.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewSetting.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewSetting.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSetting.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewSetting.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewSetting.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewSetting.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewSetting.BorderStyle = BorderStyles.Simple;
            this.gridViewSetting.Columns.AddRange(new GridColumn[9]
      {
        this.colidsetting,
        this.colname,
        this.colintvalue,
        this.colintvalue2,
        this.colstrvalue,
        this.coltxtvalue,
        this.colcomment,
        this.colgroupname,
        this.coldtvalue
      });
            this.gridViewSetting.GridControl = this.gridControlSetting;
            this.gridViewSetting.GroupPanelText = "Панель группировки";
            this.gridViewSetting.Name = "gridViewSetting";
            this.gridViewSetting.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewSetting.OptionsBehavior.Editable = false;
            this.gridViewSetting.OptionsCustomization.AllowFilter = false;
            this.gridViewSetting.OptionsDetail.ShowDetailTabs = false;
            this.gridViewSetting.OptionsSelection.MultiSelect = true;
            this.gridViewSetting.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewSetting.OptionsView.ShowIndicator = false;
            this.colidsetting.Caption = "#";
            this.colidsetting.FieldName = "idsetting";
            this.colidsetting.Name = "colidsetting";
            this.colidsetting.OptionsColumn.AllowEdit = false;
            this.colidsetting.Visible = true;
            this.colidsetting.VisibleIndex = 0;
            this.colidsetting.Width = 31;
            this.colname.Caption = "Имя";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 36;
            this.colintvalue.Caption = "Число 1";
            this.colintvalue.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colintvalue.FieldName = "intvalue";
            this.colintvalue.Name = "colintvalue";
            this.colintvalue.Visible = true;
            this.colintvalue.VisibleIndex = 2;
            this.colintvalue.Width = 54;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n6";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n6";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n6";
            this.repositoryItemTextEdit1.Mask.MaskType = MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.colintvalue2.Caption = "Число 2";
            this.colintvalue2.FieldName = "intvalue2";
            this.colintvalue2.Name = "colintvalue2";
            this.colintvalue2.Visible = true;
            this.colintvalue2.VisibleIndex = 3;
            this.colintvalue2.Width = 44;
            this.colstrvalue.Caption = "Строка";
            this.colstrvalue.FieldName = "strvalue";
            this.colstrvalue.Name = "colstrvalue";
            this.colstrvalue.Visible = true;
            this.colstrvalue.VisibleIndex = 4;
            this.colstrvalue.Width = 31;
            this.coltxtvalue.Caption = "Текст";
            this.coltxtvalue.FieldName = "txtvalue";
            this.coltxtvalue.Name = "coltxtvalue";
            this.coltxtvalue.Visible = true;
            this.coltxtvalue.VisibleIndex = 5;
            this.coltxtvalue.Width = 31;
            this.colcomment.Caption = "Описание";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 6;
            this.colcomment.Width = 31;
            this.colgroupname.Caption = "Группа";
            this.colgroupname.FieldName = "groupname";
            this.colgroupname.Name = "colgroupname";
            this.colgroupname.Visible = true;
            this.colgroupname.VisibleIndex = 7;
            this.colgroupname.Width = 31;
            this.coldtvalue.Caption = "Дата";
            this.coldtvalue.ColumnEdit = (RepositoryItem)this.repositoryItemDateEdit1;
            this.coldtvalue.FieldName = "dtvalue";
            this.coldtvalue.Name = "coldtvalue";
            this.coldtvalue.Visible = true;
            this.coldtvalue.VisibleIndex = 8;
            this.coldtvalue.Width = 31;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
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
            this.treeList1.Columns.AddRange(new TreeListColumn[1]
      {
        this.treeListColumn1
      });
            this.treeList1.DataMember = "settinggroup";
            this.treeList1.DataSource = (object)this.ds;
            this.treeList1.Dock = DockStyle.Left;
            this.treeList1.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeList1.ImageIndexFieldName = "_image";
            this.treeList1.KeyFieldName = "idsettinggroup";
            this.treeList1.Location = new Point(0, 0);
            this.treeList1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.ParentFieldName = "parentid";
            this.treeList1.SelectImageList = (object)this.imageList1;
            this.treeList1.Size = new Size(240, 333);
            this.treeList1.TabIndex = 5;
            this.treeListColumn1.Caption = "Группы переменных";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 28;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 167;
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.splitterControl1.Location = new Point(240, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 333);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlSetting);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeList1);
            this.Controls.Add((Control)this.panel1);
            this.Name = "SelectVarsForm";
            this.Size = new Size(705, 366);
            this.Text = "Переменные";
            this.panel1.ResumeLayout(false);
            this.gridControlSetting.EndInit();
            this.ds.EndInit();
            this.table_settinggroup.EndInit();
            this.table_setting.EndInit();
            this.gridViewSetting.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemDateEdit1.VistaTimeProperties.EndInit();
            this.repositoryItemDateEdit1.EndInit();
            this.repositoryItemMemoExEdit1.EndInit();
            this.repositoryItemImageEdit1.EndInit();
            this.treeList1.EndInit();
            this.ResumeLayout(false);
        }
    }
}
