// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.SelectGoodKitForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.ecad;
using Atechnology.ecad.Calc;
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
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class SelectGoodKitForm : AtUserControl
    {
        private IContainer components;
        private GridView gridViewGoodKit;
        private GridView gridViewGoodKitDetail;
        private GridColumn colgood_marking;
        private GridColumn colgood_name;
        private GridColumn colidgoodkit;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colkitgroup;
        private GridColumn colqu;
        private GridColumn colthick;
        private GridColumn colheight;
        private GridColumn colwidth;
        private GridColumn colweight;
        private TreeList treeListGroup;
        private TreeListColumn treeListColumn1;
        private ImageList imageList1;
        private GridColumn colidgoodkitgroup;
        private GridColumn colsystem_name;
        public GridControl gridControlSource;
        private ds_goodkit ds_goodkit;
        private GridColumn colismain;
        public Panel panel2;
        public Button cmdCancel;
        public Button cmdSelect;
        private ButtonEdit buttonEditHideAndShowGroupAdding;
        private SplitterControl splitterControl1;
        public GridControl gridControlResult;
        private GridView gridViewResultGoodKitDetail;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private GridColumn gridColumn6;
        private GridColumn gridColumn7;
        private GridView gridViewResultGoodKit;
        private GridColumn gridColumn10;
        private GridColumn gridColumn11;
        private GridColumn gridColumn12;
        private GridColumn gridColumn13;
        private GridColumn gridColumn14;
        private DataSet dsresult;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn9;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private DataColumn dataColumn15;
        private DataColumn dataColumn16;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private DataColumn dataColumn19;
        private DataColumn dataColumn20;
        private DataColumn dataColumn21;
        private GridColumn colsqr;
        private GridColumn colcolor1_name;
        private GridColumn colcolor2_name;
        private GridColumn colcomment1;
        private GridColumn colsystem_name1;
        private atColorPopUpContainer PopupContainerEditColor1;
        private atColorPopUpContainer PopupContainerEditColor2;
        private SplitterControl splitterControl2;
        private AtRepositoryItemTextEdit repositoryItemTextEdit3;
        private AtRepositoryItemTextEdit repositoryItemTextEdit4;
        public DataTable table_goodkitdetail;
        public DataTable table_goodkit;
        private DataColumn dataColumn22;
        private DataColumn dataColumn23;
        private DataColumn dataColumn24;
        private DataColumn dataColumn25;
        private DataColumn dataColumn26;
        private DataColumn dataColumn27;
        private DataColumn dataColumn28;
        private DataColumn dataColumn29;
        private DataColumn dataColumn30;
        private DataColumn dataColumn31;
        private DataColumn dataColumn32;
        private DataColumn dataColumn33;
        private DataColumn _vidgoodkit;
        private DataColumn column23;

        public atColorPopUpContainer SelectedGoodColor1
        {
            get
            {
                return this.PopupContainerEditColor1;
            }
        }

        public atColorPopUpContainer SelectedGoodColor2
        {
            get
            {
                return this.PopupContainerEditColor2;
            }
        }

        public SelectGoodKitForm()
        {
            this.InitializeComponent();
            this.Is_Dialog = true;
            this.dsresult.EnforceConstraints = false;
            this.ds_goodkit.Load(false, true);
            this.FormClosing += new FormClosing(this.SelectGoodKitForm_FormClosing);
            this.Shown += new Shown(this.SelectGoodKitForm_Shown);
            this.gridViewGoodKitDetail.DoubleClick += new EventHandler(this.gridViewGoodKitDetail_DoubleClick);
            this.gridViewGoodKit.DoubleClick += new EventHandler(this.gridViewGoodKit_DoubleClick);
            this.treeListGroup.KeyDown += new KeyEventHandler(this.treeListGroup_KeyDown);
            this.PopupContainerEditColor1.EditValueChanging += new ChangingEventHandler(this.PopupContainerEditColor1_EditValueChanging);
            this.PopupContainerEditColor2.EditValueChanging += new ChangingEventHandler(this.PopupContainerEditColor2_EditValueChanging);
            this.PopupContainerEditColor1.Popup += new EventHandler(this.PopupContainerEditColor1_Popup);
            this.PopupContainerEditColor2.Popup += new EventHandler(this.PopupContainerEditColor2_Popup);
            this.cmdSelect.Click += new EventHandler(this.cmdSelect_Click);
            this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
            this.buttonEditHideAndShowGroupAdding.ButtonClick += new ButtonPressedEventHandler(this.buttonEditHideAndShowGroupAdding_ButtonClick);
            this.SetAddAnyGoodState(Settings.DictionarySettings.MaximazedAddManyGoodKit);
        }

        private void buttonEditHideAndShowGroupAdding_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
                this.SetAddAnyGoodState(e.Button);
            else if (e.Button.Index == 1)
            {
                DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlResult);
                if (dataRow != null)
                    dataRow.Delete();
                this.table_goodkit.AcceptChanges();
            }
            else if (e.Button.Index == 2)
            {
                this.AddRowToResult();
            }
            else
            {
                if (e.Button.Index != 3)
                    return;
                this.table_goodkitdetail.Clear();
                this.table_goodkit.Clear();
                this.dsresult.AcceptChanges();
            }
        }

        private void gridViewGoodKit_DoubleClick(object sender, EventArgs e)
        {
            if (!this.buttonEditHideAndShowGroupAdding.Properties.Buttons[1].Visible)
                this.cmdSelect_Click((object)null, (EventArgs)null);
            else
                this.AddRowToResult();
        }

        private void gridViewGoodKitDetail_DoubleClick(object sender, EventArgs e)
        {
            this.gridViewGoodKit_DoubleClick((object)null, (EventArgs)null);
        }

        private void SelectGoodKitForm_Shown(object sender, EventArgs e)
        {
            this.treeListGroup.MoveLastVisible();
            this.treeListGroup.MoveFirst();
            if (Settings.SavedValues.idgoodkitgroup > 0)
                AtTreeList.SelectNode(this.treeListGroup, "idgoodkitgroup", Settings.SavedValues.idgoodkitgroup);
            if (Settings.SavedValues.idgoodkit > 0)
                AtGrid.SelectRow(this.gridControlSource, "idgoodkit", (object)Settings.SavedValues.idgoodkit, false);
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Открытие формы выбора комплектов материалов", (object)this);
        }

        private void SelectGoodKitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            Settings.SavedValues.idgoodkitgroup = Useful.GetInt32(selectedNode["idgoodkitgroup"]);
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlSource);
            if (dataRow == null)
                return;
            Settings.SavedValues.idgoodkit = Useful.GetInt32(dataRow["idgoodkit"]);
            Settings.DictionarySettings.MaximazedAddManyGoodKit = this.buttonEditHideAndShowGroupAdding.Properties.Buttons[0].Kind == ButtonPredefines.Down;
        }

        private void treeListGroup_KeyDown(object sender, KeyEventArgs e)
        {
            TreeList_KeyDown.Key(this.treeListGroup, e.KeyCode);
        }

        private void PopupContainerEditColor1_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlResult);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = (DataRow)e.NewValue;
            dataRow1["idcolor1"] = dataRow2["idcolor"];
            dataRow1["color1_name"] = dataRow2["name"];
        }

        private void PopupContainerEditColor2_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlResult);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = (DataRow)e.NewValue;
            dataRow1["idcolor2"] = dataRow2["idcolor"];
            dataRow1["color2_name"] = dataRow2["name"];
        }

        private void PopupContainerEditColor1_Popup(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlResult);
            if (dataRow == null)
                return;
            this.PopupContainerEditColor1.IdColor = dataRow["idcolor1"];
        }

        private void PopupContainerEditColor2_Popup(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlResult);
            if (dataRow == null)
                return;
            this.PopupContainerEditColor2.IdColor = dataRow["idcolor2"];
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            if (!this.buttonEditHideAndShowGroupAdding.Properties.Buttons[1].Visible)
                this.AddRowToResult();
            this.ParentForm.DialogResult = DialogResult.OK;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SetAddAnyGoodState(bool IsAnyGood)
        {
            this.buttonEditHideAndShowGroupAdding.Properties.Buttons[0].Kind = IsAnyGood ? ButtonPredefines.Down : ButtonPredefines.Up;
            this.splitterControl1.Visible = IsAnyGood;
            this.gridControlResult.Visible = IsAnyGood;
            this.buttonEditHideAndShowGroupAdding.Properties.Buttons[1].Visible = IsAnyGood;
            this.buttonEditHideAndShowGroupAdding.Properties.Buttons[2].Visible = IsAnyGood;
            this.buttonEditHideAndShowGroupAdding.Properties.Buttons[3].Visible = IsAnyGood;
        }

        private void SetAddAnyGoodState(EditorButton button)
        {
            this.SetAddAnyGoodState(button.Kind == ButtonPredefines.Up);
        }

        private void AddRowToResult()
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlSource);
            if (dataRow1 == null)
                return;
            if (dataRow1.Table.TableName != "goodkit")
                dataRow1 = dataRow1.GetParentRow("FK_goodkit_goodkitdetail");
            if (dataRow1 == null)
                return;
            DataRow[] childRows = dataRow1.GetChildRows("FK_goodkit_goodkitdetail");
            if (childRows.Length == 0)
                return;
            DataRow row = this.table_goodkit.NewRow();
            int num = 1;
            if (this.buttonEditHideAndShowGroupAdding.Properties.Buttons[1].Visible)
            {
                if (this.table_goodkit.Rows.Count != 0)
                    num = Useful.GetInt32(this.table_goodkit.Select("", "_vidgoodkit desc")[0]["_vidgoodkit"]) + 1;
            }
            else
                num = Useful.GetInt32(dataRow1["idgoodkit"]);
            int int32 = Useful.GetInt32(dataRow1["idgoodkit"]);
            row["idgoodkit"] = (object)int32;
            row["_vidgoodkit"] = (object)num;
            row["name"] = dataRow1["name"];
            row["comment"] = dataRow1["comment"];
            this.table_goodkit.Rows.Add(row);
            foreach (DataRow Source in childRows)
            {
                DataRow dataRow2 = this.table_goodkitdetail.NewRow();
                AtDataSet.LoadRow(Source, dataRow2);
                dataRow2["idgoodkit"] = (object)int32;
                dataRow2["_vidgoodkit"] = (object)num;
                this.table_goodkitdetail.Rows.Add(dataRow2);
            }
            this.table_goodkit.AcceptChanges();
            this.table_goodkitdetail.AcceptChanges();
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
            GridLevelNode gridLevelNode1 = new GridLevelNode();
            GridLevelNode gridLevelNode2 = new GridLevelNode();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SelectGoodKitForm));
            this.gridViewGoodKitDetail = new GridView();
            this.colgood_marking = new GridColumn();
            this.colgood_name = new GridColumn();
            this.colqu = new GridColumn();
            this.colthick = new GridColumn();
            this.colheight = new GridColumn();
            this.repositoryItemTextEdit3 = new AtRepositoryItemTextEdit();
            this.colwidth = new GridColumn();
            this.repositoryItemTextEdit4 = new AtRepositoryItemTextEdit();
            this.colweight = new GridColumn();
            this.colsystem_name = new GridColumn();
            this.colismain = new GridColumn();
            this.gridControlSource = new GridControl();
            this.ds_goodkit = new ds_goodkit();
            this.gridViewGoodKit = new GridView();
            this.colidgoodkit = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colkitgroup = new GridColumn();
            this.colidgoodkitgroup = new GridColumn();
            this.gridViewResultGoodKitDetail = new GridView();
            this.gridColumn1 = new GridColumn();
            this.gridColumn2 = new GridColumn();
            this.gridColumn3 = new GridColumn();
            this.gridColumn4 = new GridColumn();
            this.gridColumn5 = new GridColumn();
            this.gridColumn6 = new GridColumn();
            this.gridColumn7 = new GridColumn();
            this.colsqr = new GridColumn();
            this.colcolor1_name = new GridColumn();
            this.PopupContainerEditColor1 = new atColorPopUpContainer();
            this.colcolor2_name = new GridColumn();
            this.PopupContainerEditColor2 = new atColorPopUpContainer();
            this.colcomment1 = new GridColumn();
            this.colsystem_name1 = new GridColumn();
            this.gridControlResult = new GridControl();
            this.dsresult = new DataSet();
            this.table_goodkit = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this._vidgoodkit = new DataColumn();
            this.table_goodkitdetail = new DataTable();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn15 = new DataColumn();
            this.dataColumn16 = new DataColumn();
            this.dataColumn17 = new DataColumn();
            this.dataColumn18 = new DataColumn();
            this.dataColumn19 = new DataColumn();
            this.dataColumn20 = new DataColumn();
            this.dataColumn21 = new DataColumn();
            this.dataColumn22 = new DataColumn();
            this.dataColumn23 = new DataColumn();
            this.dataColumn24 = new DataColumn();
            this.dataColumn25 = new DataColumn();
            this.dataColumn26 = new DataColumn();
            this.dataColumn27 = new DataColumn();
            this.dataColumn28 = new DataColumn();
            this.dataColumn29 = new DataColumn();
            this.dataColumn30 = new DataColumn();
            this.dataColumn31 = new DataColumn();
            this.dataColumn32 = new DataColumn();
            this.dataColumn33 = new DataColumn();
            this.column23 = new DataColumn();
            this.gridViewResultGoodKit = new GridView();
            this.gridColumn10 = new GridColumn();
            this.gridColumn11 = new GridColumn();
            this.gridColumn12 = new GridColumn();
            this.gridColumn13 = new GridColumn();
            this.gridColumn14 = new GridColumn();
            this.treeListGroup = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.imageList1 = new ImageList(this.components);
            this.panel2 = new Panel();
            this.cmdCancel = new Button();
            this.cmdSelect = new Button();
            this.buttonEditHideAndShowGroupAdding = new ButtonEdit();
            this.splitterControl1 = new SplitterControl();
            this.splitterControl2 = new SplitterControl();
            this.gridViewGoodKitDetail.BeginInit();
            this.repositoryItemTextEdit3.BeginInit();
            this.repositoryItemTextEdit4.BeginInit();
            this.gridControlSource.BeginInit();
            this.ds_goodkit.BeginInit();
            this.gridViewGoodKit.BeginInit();
            this.gridViewResultGoodKitDetail.BeginInit();
            this.PopupContainerEditColor1.BeginInit();
            this.PopupContainerEditColor2.BeginInit();
            this.gridControlResult.BeginInit();
            this.dsresult.BeginInit();
            this.table_goodkit.BeginInit();
            this.table_goodkitdetail.BeginInit();
            this.gridViewResultGoodKit.BeginInit();
            this.treeListGroup.BeginInit();
            this.panel2.SuspendLayout();
            this.buttonEditHideAndShowGroupAdding.Properties.BeginInit();
            this.SuspendLayout();
            this.gridViewGoodKitDetail.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewGoodKitDetail.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewGoodKitDetail.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewGoodKitDetail.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewGoodKitDetail.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewGoodKitDetail.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewGoodKitDetail.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKitDetail.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewGoodKitDetail.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewGoodKitDetail.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewGoodKitDetail.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewGoodKitDetail.BorderStyle = BorderStyles.Simple;
            this.gridViewGoodKitDetail.Columns.AddRange(new GridColumn[9]
      {
        this.colgood_marking,
        this.colgood_name,
        this.colqu,
        this.colthick,
        this.colheight,
        this.colwidth,
        this.colweight,
        this.colsystem_name,
        this.colismain
      });
            this.gridViewGoodKitDetail.GridControl = this.gridControlSource;
            this.gridViewGoodKitDetail.Name = "gridViewGoodKitDetail";
            this.gridViewGoodKitDetail.OptionsBehavior.Editable = false;
            this.gridViewGoodKitDetail.OptionsCustomization.AllowFilter = false;
            this.gridViewGoodKitDetail.OptionsCustomization.AllowGroup = false;
            this.gridViewGoodKitDetail.OptionsDetail.ShowDetailTabs = false;
            this.gridViewGoodKitDetail.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewGoodKitDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewGoodKitDetail.OptionsView.ShowIndicator = false;
            this.colgood_marking.Caption = "Артикул материала";
            this.colgood_marking.FieldName = "good_marking";
            this.colgood_marking.Name = "colgood_marking";
            this.colgood_marking.OptionsColumn.AllowEdit = false;
            this.colgood_marking.Visible = true;
            this.colgood_marking.VisibleIndex = 1;
            this.colgood_name.Caption = "Наименование материала";
            this.colgood_name.FieldName = "good_name";
            this.colgood_name.Name = "colgood_name";
            this.colgood_name.OptionsColumn.AllowEdit = false;
            this.colgood_name.Visible = true;
            this.colgood_name.VisibleIndex = 0;
            this.colqu.Caption = "Кол-во";
            this.colqu.FieldName = "qu";
            this.colqu.Name = "colqu";
            this.colqu.Visible = true;
            this.colqu.VisibleIndex = 2;
            this.colthick.Caption = "Длина";
            this.colthick.FieldName = "thick";
            this.colthick.Name = "colthick";
            this.colthick.Visible = true;
            this.colthick.VisibleIndex = 3;
            this.colheight.Caption = "Высота";
            this.colheight.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit3;
            this.colheight.FieldName = "height";
            this.colheight.Name = "colheight";
            this.colheight.Visible = true;
            this.colheight.VisibleIndex = 4;
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.colwidth.Caption = "Ширина";
            this.colwidth.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit4;
            this.colwidth.FieldName = "width";
            this.colwidth.Name = "colwidth";
            this.colwidth.Visible = true;
            this.colwidth.VisibleIndex = 5;
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            this.colweight.Caption = "Вес";
            this.colweight.FieldName = "weight";
            this.colweight.Name = "colweight";
            this.colweight.Visible = true;
            this.colweight.VisibleIndex = 6;
            this.colsystem_name.Caption = "Система";
            this.colsystem_name.FieldName = "system_name";
            this.colsystem_name.Name = "colsystem_name";
            this.colsystem_name.Visible = true;
            this.colsystem_name.VisibleIndex = 7;
            this.colismain.Caption = "Главный";
            this.colismain.FieldName = "ismain";
            this.colismain.Name = "colismain";
            this.colismain.Visible = true;
            this.colismain.VisibleIndex = 8;
            this.gridControlSource.DataMember = "goodkitgroup.FK_goodkitgroup_goodkit";
            this.gridControlSource.DataSource = (object)this.ds_goodkit;
            this.gridControlSource.Dock = DockStyle.Fill;
            this.gridControlSource.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = (BaseView)this.gridViewGoodKitDetail;
            gridLevelNode1.RelationName = "FK_goodkit_goodkitdetail";
            this.gridControlSource.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode1
      });
            this.gridControlSource.Location = new Point(283, 0);
            this.gridControlSource.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlSource.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlSource.MainView = (BaseView)this.gridViewGoodKit;
            this.gridControlSource.Name = "gridControlSource";
            this.gridControlSource.Size = new Size(643, 237);
            this.gridControlSource.TabIndex = 3;
            this.gridControlSource.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridViewGoodKit,
        (BaseView) this.gridViewGoodKitDetail
      });
            this.ds_goodkit.DataSetName = "ds_goodkit";
            this.ds_goodkit.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridViewGoodKit.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewGoodKit.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewGoodKit.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewGoodKit.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewGoodKit.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewGoodKit.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewGoodKit.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewGoodKit.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewGoodKit.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewGoodKit.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGoodKit.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewGoodKit.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewGoodKit.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewGoodKit.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewGoodKit.BorderStyle = BorderStyles.Simple;
            this.gridViewGoodKit.Columns.AddRange(new GridColumn[5]
      {
        this.colidgoodkit,
        this.colname,
        this.colcomment,
        this.colkitgroup,
        this.colidgoodkitgroup
      });
            this.gridViewGoodKit.GridControl = this.gridControlSource;
            this.gridViewGoodKit.GroupPanelText = "Панель группировки";
            this.gridViewGoodKit.Name = "gridViewGoodKit";
            this.gridViewGoodKit.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewGoodKit.OptionsBehavior.Editable = false;
            this.gridViewGoodKit.OptionsCustomization.AllowFilter = false;
            this.gridViewGoodKit.OptionsDetail.ShowDetailTabs = false;
            this.gridViewGoodKit.OptionsSelection.MultiSelect = true;
            this.gridViewGoodKit.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewGoodKit.OptionsView.ShowGroupPanel = false;
            this.gridViewGoodKit.OptionsView.ShowIndicator = false;
            this.colidgoodkit.Caption = "#";
            this.colidgoodkit.FieldName = "idgoodkit";
            this.colidgoodkit.Name = "colidgoodkit";
            this.colidgoodkit.OptionsColumn.AllowEdit = false;
            this.colidgoodkit.Visible = true;
            this.colidgoodkit.VisibleIndex = 0;
            this.colidgoodkit.Width = 49;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 274;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 2;
            this.colcomment.Width = 278;
            this.colkitgroup.Caption = "Группа";
            this.colkitgroup.FieldName = "kitgroup";
            this.colkitgroup.Name = "colkitgroup";
            this.colkitgroup.Width = 210;
            this.colidgoodkitgroup.Caption = "idgoodkitgroup";
            this.colidgoodkitgroup.FieldName = "idgoodkitgroup";
            this.colidgoodkitgroup.Name = "colidgoodkitgroup";
            this.gridViewResultGoodKitDetail.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewResultGoodKitDetail.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewResultGoodKitDetail.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewResultGoodKitDetail.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewResultGoodKitDetail.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewResultGoodKitDetail.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewResultGoodKitDetail.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewResultGoodKitDetail.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewResultGoodKitDetail.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewResultGoodKitDetail.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKitDetail.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewResultGoodKitDetail.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewResultGoodKitDetail.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewResultGoodKitDetail.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewResultGoodKitDetail.BorderStyle = BorderStyles.Simple;
            this.gridViewResultGoodKitDetail.Columns.AddRange(new GridColumn[12]
      {
        this.gridColumn1,
        this.gridColumn2,
        this.gridColumn3,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6,
        this.gridColumn7,
        this.colsqr,
        this.colcolor1_name,
        this.colcolor2_name,
        this.colcomment1,
        this.colsystem_name1
      });
            this.gridViewResultGoodKitDetail.GridControl = this.gridControlResult;
            this.gridViewResultGoodKitDetail.Name = "gridViewResultGoodKitDetail";
            this.gridViewResultGoodKitDetail.OptionsCustomization.AllowFilter = false;
            this.gridViewResultGoodKitDetail.OptionsCustomization.AllowGroup = false;
            this.gridViewResultGoodKitDetail.OptionsDetail.ShowDetailTabs = false;
            this.gridViewResultGoodKitDetail.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewResultGoodKitDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewResultGoodKitDetail.OptionsView.ShowIndicator = false;
            this.gridColumn1.Caption = "Артикул материала";
            this.gridColumn1.FieldName = "good_marking";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn2.Caption = "Наименование материала";
            this.gridColumn2.FieldName = "good_name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn3.Caption = "Кол-во";
            this.gridColumn3.FieldName = "qu";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn4.Caption = "Длина";
            this.gridColumn4.FieldName = "thick";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn5.Caption = "Высота";
            this.gridColumn5.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit3;
            this.gridColumn5.FieldName = "height";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn6.Caption = "Ширина";
            this.gridColumn6.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit4;
            this.gridColumn6.FieldName = "width";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn7.Caption = "Вес";
            this.gridColumn7.FieldName = "weight";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.colsqr.Caption = "S";
            this.colsqr.FieldName = "sqr";
            this.colsqr.Name = "colsqr";
            this.colsqr.Visible = true;
            this.colsqr.VisibleIndex = 7;
            this.colcolor1_name.Caption = "Цвет 1";
            this.colcolor1_name.ColumnEdit = (RepositoryItem)this.PopupContainerEditColor1;
            this.colcolor1_name.FieldName = "color1_name";
            this.colcolor1_name.Name = "colcolor1_name";
            this.colcolor1_name.Visible = true;
            this.colcolor1_name.VisibleIndex = 8;
            this.PopupContainerEditColor1.AutoHeight = false;
            this.PopupContainerEditColor1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.PopupContainerEditColor1.Name = "PopupContainerEditColor1";
            this.colcolor2_name.Caption = "Цвет 2";
            this.colcolor2_name.ColumnEdit = (RepositoryItem)this.PopupContainerEditColor2;
            this.colcolor2_name.FieldName = "color2_name";
            this.colcolor2_name.Name = "colcolor2_name";
            this.colcolor2_name.Visible = true;
            this.colcolor2_name.VisibleIndex = 9;
            this.PopupContainerEditColor2.AutoHeight = false;
            this.PopupContainerEditColor2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.PopupContainerEditColor2.Name = "PopupContainerEditColor2";
            this.colcomment1.Caption = "Комментарий";
            this.colcomment1.FieldName = "comment";
            this.colcomment1.Name = "colcomment1";
            this.colcomment1.Visible = true;
            this.colcomment1.VisibleIndex = 10;
            this.colsystem_name1.Caption = "Система";
            this.colsystem_name1.FieldName = "system_name";
            this.colsystem_name1.Name = "colsystem_name1";
            this.colsystem_name1.OptionsColumn.AllowEdit = false;
            this.colsystem_name1.Visible = true;
            this.colsystem_name1.VisibleIndex = 11;
            this.gridControlResult.DataMember = "goodkit";
            this.gridControlResult.DataSource = (object)this.dsresult;
            this.gridControlResult.Dock = DockStyle.Bottom;
            this.gridControlResult.EmbeddedNavigator.Name = "";
            gridLevelNode2.LevelTemplate = (BaseView)this.gridViewResultGoodKitDetail;
            gridLevelNode2.RelationName = "FK_goodkit_goodkitdetail";
            this.gridControlResult.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode2
      });
            this.gridControlResult.Location = new Point(283, 263);
            this.gridControlResult.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlResult.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlResult.MainView = (BaseView)this.gridViewResultGoodKit;
            this.gridControlResult.Name = "gridControlResult";
            this.gridControlResult.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.PopupContainerEditColor1,
        (RepositoryItem) this.PopupContainerEditColor2
      });
            this.gridControlResult.Size = new Size(643, 225);
            this.gridControlResult.TabIndex = 9;
            this.gridControlResult.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridViewResultGoodKit,
        (BaseView) this.gridViewResultGoodKitDetail
      });
            this.dsresult.DataSetName = "NewDataSet";
            this.dsresult.Relations.AddRange(new DataRelation[1]
      {
        new DataRelation("FK_goodkit_goodkitdetail", "goodkit", "goodkitdetail", new string[1]
        {
          "_vidgoodkit"
        }, new string[1]
        {
          "_vidgoodkit"
        }, 0 != 0)
      });
            this.dsresult.Tables.AddRange(new DataTable[2]
      {
        this.table_goodkit,
        this.table_goodkitdetail
      });
            this.table_goodkit.Columns.AddRange(new DataColumn[4]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this._vidgoodkit
      });
            this.table_goodkit.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodkit"
        }, 0 != 0),
        (Constraint) new UniqueConstraint("Constraint2", new string[1]
        {
          "_vidgoodkit"
        }, 0 != 0)
      });
            this.table_goodkit.TableName = "goodkit";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idgoodkit";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this._vidgoodkit.ColumnName = "_vidgoodkit";
            this._vidgoodkit.DataType = typeof(int);
            this.table_goodkitdetail.Columns.AddRange(new DataColumn[31]
      {
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn9,
        this.dataColumn10,
        this.dataColumn11,
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14,
        this.dataColumn15,
        this.dataColumn16,
        this.dataColumn17,
        this.dataColumn18,
        this.dataColumn19,
        this.dataColumn20,
        this.dataColumn21,
        this.dataColumn22,
        this.dataColumn23,
        this.dataColumn24,
        this.dataColumn25,
        this.dataColumn26,
        this.dataColumn27,
        this.dataColumn28,
        this.dataColumn29,
        this.dataColumn30,
        this.dataColumn31,
        this.dataColumn32,
        this.dataColumn33,
        this.column23
      });
            this.table_goodkitdetail.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new ForeignKeyConstraint("Constraint1", "goodkit", new string[1]
        {
          "_vidgoodkit"
        }, new string[1]
        {
          "_vidgoodkit"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_goodkitdetail.TableName = "goodkitdetail";
            this.dataColumn4.ColumnName = "idgoodkitdetail";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "idgoodkit";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "idgood";
            this.dataColumn6.DataType = typeof(int);
            this.dataColumn7.ColumnName = "good_marking";
            this.dataColumn8.ColumnName = "good_name";
            this.dataColumn9.ColumnName = "qu";
            this.dataColumn9.DataType = typeof(double);
            this.dataColumn10.ColumnName = "thick";
            this.dataColumn10.DataType = typeof(double);
            this.dataColumn11.ColumnName = "width";
            this.dataColumn11.DataType = typeof(double);
            this.dataColumn12.ColumnName = "height";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.ColumnName = "weight";
            this.dataColumn13.DataType = typeof(double);
            this.dataColumn14.ColumnName = "sqr";
            this.dataColumn14.DataType = typeof(double);
            this.dataColumn15.ColumnName = "idcolor1";
            this.dataColumn15.DataType = typeof(int);
            this.dataColumn16.ColumnName = "idcolor2";
            this.dataColumn16.DataType = typeof(int);
            this.dataColumn17.ColumnName = "color1_name";
            this.dataColumn18.ColumnName = "color2_name";
            this.dataColumn19.ColumnName = "comment";
            this.dataColumn20.ColumnName = "idsystem";
            this.dataColumn20.DataType = typeof(int);
            this.dataColumn21.ColumnName = "system_name";
            this.dataColumn22.ColumnName = "ismain";
            this.dataColumn22.DataType = typeof(bool);
            this.dataColumn23.ColumnName = "price1";
            this.dataColumn23.DataType = typeof(double);
            this.dataColumn24.ColumnName = "price2";
            this.dataColumn24.DataType = typeof(double);
            this.dataColumn25.ColumnName = "measure_typ";
            this.dataColumn25.DataType = typeof(int);
            this.dataColumn26.ColumnName = "measure_shortname";
            this.dataColumn27.ColumnName = "measure_factor";
            this.dataColumn27.DataType = typeof(double);
            this.dataColumn28.ColumnName = "goodtype_name";
            this.dataColumn29.ColumnName = "goodtype_name2";
            this.dataColumn30.ColumnName = "good_idgoodtype";
            this.dataColumn30.DataType = typeof(int);
            this.dataColumn31.ColumnName = "good_idgoodtype2";
            this.dataColumn31.DataType = typeof(int);
            this.dataColumn32.ColumnName = "good_ismy";
            this.dataColumn32.DataType = typeof(bool);
            this.dataColumn33.ColumnName = "good_waste";
            this.dataColumn33.DataType = typeof(double);
            this.column23.ColumnName = "_vidgoodkit";
            this.column23.DataType = typeof(int);
            this.gridViewResultGoodKit.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewResultGoodKit.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewResultGoodKit.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewResultGoodKit.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewResultGoodKit.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewResultGoodKit.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewResultGoodKit.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewResultGoodKit.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewResultGoodKit.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewResultGoodKit.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResultGoodKit.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewResultGoodKit.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewResultGoodKit.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewResultGoodKit.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewResultGoodKit.BorderStyle = BorderStyles.Simple;
            this.gridViewResultGoodKit.Columns.AddRange(new GridColumn[5]
      {
        this.gridColumn10,
        this.gridColumn11,
        this.gridColumn12,
        this.gridColumn13,
        this.gridColumn14
      });
            this.gridViewResultGoodKit.GridControl = this.gridControlResult;
            this.gridViewResultGoodKit.GroupPanelText = "Панель группировки";
            this.gridViewResultGoodKit.Name = "gridViewResultGoodKit";
            this.gridViewResultGoodKit.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewResultGoodKit.OptionsCustomization.AllowFilter = false;
            this.gridViewResultGoodKit.OptionsDetail.ShowDetailTabs = false;
            this.gridViewResultGoodKit.OptionsSelection.MultiSelect = true;
            this.gridViewResultGoodKit.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewResultGoodKit.OptionsView.ShowGroupPanel = false;
            this.gridViewResultGoodKit.OptionsView.ShowIndicator = false;
            this.gridColumn10.Caption = "#";
            this.gridColumn10.FieldName = "idgoodkit";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 49;
            this.gridColumn11.Caption = "Наименование";
            this.gridColumn11.FieldName = "name";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 274;
            this.gridColumn12.Caption = "Комментарий";
            this.gridColumn12.FieldName = "comment";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 278;
            this.gridColumn13.Caption = "Группа";
            this.gridColumn13.FieldName = "kitgroup";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Width = 210;
            this.gridColumn14.Caption = "idgoodkitgroup";
            this.gridColumn14.FieldName = "idgoodkitgroup";
            this.gridColumn14.Name = "gridColumn14";
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
            this.treeListGroup.DataMember = "goodkitgroup";
            this.treeListGroup.DataSource = (object)this.ds_goodkit;
            this.treeListGroup.Dock = DockStyle.Left;
            this.treeListGroup.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeListGroup.ImageIndexFieldName = "imageindex_";
            this.treeListGroup.KeyFieldName = "idgoodkitgroup";
            this.treeListGroup.Location = new Point(0, 0);
            this.treeListGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListGroup.Name = "treeListGroup";
            this.treeListGroup.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListGroup.OptionsBehavior.Editable = false;
            this.treeListGroup.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListGroup.OptionsView.ShowHorzLines = false;
            this.treeListGroup.OptionsView.ShowIndicator = false;
            this.treeListGroup.OptionsView.ShowVertLines = false;
            this.treeListGroup.ParentFieldName = "parentid";
            this.treeListGroup.SelectImageList = (object)this.imageList1;
            this.treeListGroup.Size = new Size(277, 488);
            this.treeListGroup.TabIndex = 4;
            this.treeListColumn1.Caption = "Группы комплектов";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 45;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 192;
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "Folder2.ico");
            this.panel2.Controls.Add((Control)this.cmdCancel);
            this.panel2.Controls.Add((Control)this.cmdSelect);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(926, 33);
            this.panel2.TabIndex = 6;
            this.cmdCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.FlatStyle = FlatStyle.Flat;
            this.cmdCancel.Location = new Point(839, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Отменить";
            this.cmdSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdSelect.DialogResult = DialogResult.OK;
            this.cmdSelect.FlatStyle = FlatStyle.Flat;
            this.cmdSelect.Location = new Point(758, 5);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new Size(75, 23);
            this.cmdSelect.TabIndex = 2;
            this.cmdSelect.Text = "Выбрать";
            this.buttonEditHideAndShowGroupAdding.Dock = DockStyle.Bottom;
            this.buttonEditHideAndShowGroupAdding.Location = new Point(283, 237);
            this.buttonEditHideAndShowGroupAdding.Name = "buttonEditHideAndShowGroupAdding";
            this.buttonEditHideAndShowGroupAdding.Properties.AllowFocused = false;
            this.buttonEditHideAndShowGroupAdding.Properties.Appearance.BackColor = SystemColors.Control;
            this.buttonEditHideAndShowGroupAdding.Properties.Appearance.Options.UseBackColor = true;
            this.buttonEditHideAndShowGroupAdding.Properties.BorderStyle = BorderStyles.Simple;
            this.buttonEditHideAndShowGroupAdding.Properties.Buttons.AddRange(new EditorButton[4]
      {
        new EditorButton(ButtonPredefines.Up, "", 62, true, true, false, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Minus, "", 62, true, false, true, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Plus, "", 62, true, false, true, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Close, "", 62, true, false, true, ImageLocation.MiddleCenter, (Image) null)
      });
            this.buttonEditHideAndShowGroupAdding.Properties.ButtonsStyle = BorderStyles.Office2003;
            this.buttonEditHideAndShowGroupAdding.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.buttonEditHideAndShowGroupAdding.Size = new Size(643, 20);
            this.buttonEditHideAndShowGroupAdding.TabIndex = 7;
            this.splitterControl1.Dock = DockStyle.Bottom;
            this.splitterControl1.Location = new Point(283, 257);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(643, 6);
            this.splitterControl1.TabIndex = 8;
            this.splitterControl1.TabStop = false;
            this.splitterControl2.Location = new Point(277, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new Size(6, 488);
            this.splitterControl2.TabIndex = 10;
            this.splitterControl2.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlSource);
            this.Controls.Add((Control)this.buttonEditHideAndShowGroupAdding);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.gridControlResult);
            this.Controls.Add((Control)this.splitterControl2);
            this.Controls.Add((Control)this.treeListGroup);
            this.Controls.Add((Control)this.panel2);
            this.Name = "SelectGoodKitForm";
            this.Size = new Size(926, 521);
            this.Text = "Комплекты материалов";
            this.gridViewGoodKitDetail.EndInit();
            this.repositoryItemTextEdit3.EndInit();
            this.repositoryItemTextEdit4.EndInit();
            this.gridControlSource.EndInit();
            this.ds_goodkit.EndInit();
            this.gridViewGoodKit.EndInit();
            this.gridViewResultGoodKitDetail.EndInit();
            this.PopupContainerEditColor1.EndInit();
            this.PopupContainerEditColor2.EndInit();
            this.gridControlResult.EndInit();
            this.dsresult.EndInit();
            this.table_goodkit.EndInit();
            this.table_goodkitdetail.EndInit();
            this.gridViewResultGoodKit.EndInit();
            this.treeListGroup.EndInit();
            this.panel2.ResumeLayout(false);
            this.buttonEditHideAndShowGroupAdding.Properties.EndInit();
            this.ResumeLayout(false);
        }
    }
}
