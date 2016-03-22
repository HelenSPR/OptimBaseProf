// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.SelectGoodForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.ecad;
using Atechnology.ecad.Calc;
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
    public class SelectGoodForm : AtUserControl
    {
        public int f_idg = -1;
        public DataRow ChoiceGood1;
        public DataRow ChoiceGood2;
        public bool DoubleChoice;
        public DataRow Result;
        public ds_good.goodRow[] ResultArray;
        public int f_id;
        public bool isAddList;
        private IContainer components;
        private TreeList treeList1;
        private Splitter splitter1;
        private TreeListColumn colname;
        private GridColumn colname1;
        private GridColumn colcomment;
        private GridColumn colmarking;
        private GridColumn colextmarking;
        private GridColumn colheight;
        private GridColumn colwidth;
        private GridColumn colthick;
        private GridColumn colweight;
        private GridColumn colmeasure_shortname;
        private GridColumn colidgoodgroup;
        public Button cmdCancel;
        public Button cmdSelect;
        public Panel panel2;
        public GridView gridViewGood;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private GridColumn colprice2;
        private GridColumn colsystem_name;
        private GridColumn colidgood;
        private GridColumn colcolor1_name;
        private GridColumn colcolor2_name;
        private GridColumn colgoodtype_name;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private TreeListColumn treeListColumn3;
        private RepositoryItemComboBox cboMeasure;
        private GridColumn colvalut_shortname2;
        private GridColumn colpaking;
        private RepositoryItemComboBox cboValut1;
        private RepositoryItemComboBox cboValut2;
        public GridControl gridControlResult;
        private GridColumn colgood_name1;
        private GridColumn colgood_marking1;
        private GridColumn colqu1;
        private GridColumn colthick1;
        private GridColumn colheight1;
        private GridColumn colwidth1;
        private GridColumn colweight1;
        private GridColumn gridColumn1;
        private GridColumn colsystem_name1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit2;
        private AtRepositoryItemTextEdit repositoryItemTextEdit3;
        public DataSet ds;
        public DataTable table_result;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private DataColumn dataColumn23;
        private DataColumn dataColumn24;
        private DataColumn dataColumn25;
        private DataColumn dataColumn26;
        private DataColumn dataColumn20;
        private DataColumn dataColumn22;
        private DataColumn dataColumn27;
        private GridControl gridControlGood;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn9;
        private DataColumn dataColumn15;
        private DataColumn dataColumn16;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private DataColumn dataColumn19;
        private DataColumn dataColumn21;
        private GridColumn colsqr;
        private GridColumn colcolorout_name;
        private GridColumn colcolorin_name;
        private DataColumn dataColumn28;
        private GridColumn colcomment1;
        private atColorPopUpContainer PopupContainerEditColor1;
        private atColorPopUpContainer PopupContainerEditColor2;
        private DataColumn dataColumn29;
        private DataColumn dataColumn30;
        private DataColumn dataColumn31;
        private DataColumn dataColumn32;
        private DataColumn dataColumn33;
        public ImageList imageList1;
        public ds_good ds_good1;
        public ImageList imageListColor;
        public BindingSource bsGoodGroup;
        public BindingSource bsGood;
        public BindingSource fKgoodgroupgoodBindingSource;
        public GridView gridViewResult;
        public SplitterControl splitterControl1;
        public ButtonEdit buttonEditHideAndShowGroupAdding;

        public SelectGoodForm(bool isAll)
            : this()
        {
            using (new ThreadingStatusImageForm("Идет загрузка справочника материалов", "Подождите"))
            {
                this.ds_good1 = Goods.ds;
                this.ds_good1.goodgroup.CreateAllGroups();
                this.bsGoodGroup.DataSource = (object)this.ds_good1;
                this.bsGood.DataSource = (object)this.ds_good1;
                if (!isAll)
                    return;
                this.bsGoodGroup.Filter = "";
                this.bsGood.Filter = "";
            }
        }

        public SelectGoodForm()
        {
            this.InitializeComponent();
            CalcProcessor calcProcessor = new CalcProcessor(this.db);
            calcProcessor.ExecuteOrderEvent("События справочников.Перед загрузкой списка материалов", (object)this);
            this.SetList(this.isAddList);
            this.AddEvents();
            this.SetAddAnyGoodState(Settings.DictionarySettings.MaximazedAddManyGood);
            this.PopupContainerEditColor1.EditValueChanging += new ChangingEventHandler(this.PopupContainerEditColor1_EditValueChanging);
            this.PopupContainerEditColor2.EditValueChanging += new ChangingEventHandler(this.PopupContainerEditColor2_EditValueChanging);
            this.PopupContainerEditColor1.Popup += new EventHandler(this.PopupContainerEditColor1_Popup);
            this.PopupContainerEditColor2.Popup += new EventHandler(this.PopupContainerEditColor2_Popup);
            calcProcessor.ExecuteOrderEvent("События справочников.После загрузки списка материалов", (object)this);
        }

        private void PopupContainerEditColor1_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlResult);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = (DataRow)e.NewValue;
            dataRow1["idcolor1"] = dataRow2["idcolor"];
            dataRow1["colorout_name"] = dataRow2["name"];
        }

        private void PopupContainerEditColor2_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlResult);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = (DataRow)e.NewValue;
            dataRow1["idcolor2"] = dataRow2["idcolor"];
            dataRow1["colorin_name"] = dataRow2["name"];
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

        private void AddEvents()
        {
            this.treeList1.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.KeyDown += new KeyEventHandler(this.treeList1_KeyDown);
            this.Shown += new Shown(this.GoodForm_Shown);
            this.gridViewGood.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
            this.FormClosing += new FormClosing(this.GoodForm_FormClosing);
            this.gridViewGood.KeyPress += new KeyPressEventHandler(this.gridView1_KeyPress);
            this.cmdSelect.Click += new EventHandler(this.cmdSelect_Click);
            this.buttonEditHideAndShowGroupAdding.ButtonClick += new ButtonPressedEventHandler(this.buttonEditHideAndShowGroupAdding_ButtonClick);
        }

        private void buttonEditHideAndShowGroupAdding_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
                this.SetAddAnyGoodState(e.Button);
            else if (e.Button.Index == 1)
            {
                DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlResult);
                if (dataRow != null)
                    this.table_result.Rows.Remove(dataRow);
                this.table_result.AcceptChanges();
            }
            else if (e.Button.Index == 2)
            {
                this.AddRowToResult();
            }
            else
            {
                if (e.Button.Index != 3)
                    return;
                this.table_result.Clear();
                this.table_result.AcceptChanges();
            }
        }

        private void GoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGood);
            if (dataRow != null)
            {
                Settings.SavedValues.idgood = Useful.GetInt32(dataRow["idgood"]);
                Settings.SavedValues.idgoodgroup = Useful.GetInt32(dataRow["idgoodgroup"]);
            }
            this.Result = AtGrid.getDataRow((Control)this.gridControlGood);
            string str = AtDataSet.GetIDFilterString(this.table_result, "idgood").Replace(" ", ",");
            if (str != "")
                this.ResultArray = (ds_good.goodRow[])this.ds_good1.good.Select("idgood in (" + str + ")");
            this.treeList1.DataSource = (object)null;
            this.treeList1.DataMember = (string)null;
            DataRow[] dataRowArray = this.ds_good1.goodgroup.Select("parentid = -1");
            if (dataRowArray.Length != 0)
                this.ds_good1.goodgroup.Rows.Remove(dataRowArray[0]);
            Settings.DictionarySettings.MaximazedAddManyGood = this.buttonEditHideAndShowGroupAdding.Properties.Buttons[0].Kind == ButtonPredefines.Down;
        }

        private void GoodForm_Shown(object sender, EventArgs e)
        {
            if (this.DoubleChoice)
                this.buttonEditHideAndShowGroupAdding.Visible = false;
            if (this.f_id <= 0)
            {
                this.f_idg = Settings.SavedValues.idgoodgroup;
                this.f_id = Settings.SavedValues.idgood;
            }
            if (this.f_id <= 0)
                return;
            this.RepositionGood(this.f_idg, this.f_id);
        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            TreeList_KeyDown.Key(this.treeList1, e.KeyCode);
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeList1) == null)
                return;
            this.SetDataMember();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            this.AddRowToResult();
            if (this.buttonEditHideAndShowGroupAdding.Properties.Buttons[1].Visible && !this.DoubleChoice)
                return;
            this.GoodChoice();
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 13)
                return;
            this.GoodChoice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            if (this.table_result.Select().Length != 0)
                this.GoodChoice();
            else
                this.gridView1_DoubleClick((object)null, (EventArgs)null);
        }

        public void IsDialog()
        {
            this.Is_Dialog = true;
        }

        public void RepositionGood(int group, int good)
        {
            if (group == -1)
                AtTreeList.SelectFirstNode(this.treeList1);
            else
                AtTreeList.SelectNode(this.treeList1, "idgoodgroup", group);
            this.gridControlGood.Focus();
            this.gridControlGood.FocusedView = (BaseView)this.gridViewGood;
            this.gridControlGood.DataMember = (string)null;
            this.SetDataMember();
            if (good == -1)
                return;
            AtGrid.SelectRow(this.gridControlGood, "idgood", (object)good, false);
        }

        private void GoodChoice()
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGood);
            if (dataRow == null)
                return;
            if (this.ChoiceGood1 == null)
            {
                this.ChoiceGood1 = dataRow;
                if (!this.DoubleChoice)
                {
                    this.ParentForm.DialogResult = DialogResult.OK;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    this.ParentForm.Text = "Заменяем материал - " + dataRow["Name"].ToString() + ". НА материал";
            }
            else
            {
                if (!this.DoubleChoice || this.ChoiceGood2 != null)
                    return;
                this.ChoiceGood2 = dataRow;
                this.ParentForm.DialogResult = DialogResult.OK;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SetDataMember()
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null || Useful.GetInt32(selectedNode["parentid"]) == -1)
            {
                if (this.gridControlGood.DataSource == this.bsGood)
                    return;
                this.gridControlGood.DataMember = "";
                this.gridControlGood.DataSource = (object)this.bsGood;
                if (Settings.isDealer)
                    return;
                string str = string.Empty;
                foreach (int num in this.ds_good1.goodgroup.GoodGroups)
                    str = !string.IsNullOrEmpty(str) ? str + (object)"," + (string)(object)num : str + (object)num;
                this.gridViewGood.Columns["idgoodgroup"].FilterInfo = new ColumnFilterInfo(string.Format("[idgoodgroup] in ({0})", (object)str));
            }
            else
            {
                if (this.gridControlGood.DataSource == this.fKgoodgroupgoodBindingSource)
                    return;
                this.gridControlGood.DataSource = (object)this.fKgoodgroupgoodBindingSource;
                this.gridViewGood.Columns["idgoodgroup"].FilterInfo = (ColumnFilterInfo)null;
            }
        }

        private void SetList(bool Value)
        {
            this.gridControlResult.Visible = Value;
            this.splitterControl1.Visible = Value;
        }

        private void AddRowToResult()
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGood);
            if (dataRow == null)
                return;
            DataRow row = this.table_result.NewRow();
            row["idgood"] = dataRow["idgood"];
            row["idgoodgroup"] = dataRow["idgoodgroup"];
            row["name"] = dataRow["name"];
            row["marking"] = dataRow["marking"];
            row["price1"] = dataRow["price1"];
            row["price2"] = dataRow["price2"];
            row["system_name"] = dataRow["system_name"];
            row["idgoodtype"] = dataRow["idgoodtype"];
            row["idgoodtype2"] = dataRow["idgoodtype2"];
            row["idcolor1"] = dataRow["idcolor1"];
            row["idcolor2"] = dataRow["idcolor2"];
            row["colorout_name"] = dataRow["color1_name"];
            row["colorin_name"] = dataRow["color2_name"];
            row["measure_typ"] = dataRow["measure_typ"];
            row["measure_shortname"] = dataRow["measure_shortname"];
            row["measure_factor"] = dataRow["measure_factor"];
            row["goodtype_name"] = dataRow["goodtype_name"];
            row["goodtype_name2"] = dataRow["goodtype_name2"];
            row["waste"] = dataRow["waste"];
            row["goodgroup_name"] = dataRow["goodgroup_name"];
            row["idvalut"] = dataRow["idvalut"];
            row["valut_shortname"] = dataRow["valut_shortname"];
            row["idgoodoptim"] = dataRow["idgoodoptim"];
            this.table_result.Rows.Add(row);
            this.table_result.AcceptChanges();
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                    this.components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch
            {
            }
        }

        private void InitializeComponent()
        {
            this.components = (IContainer)new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SelectGoodForm));
            this.treeList1 = new TreeList();
            this.colname = new TreeListColumn();
            this.treeListColumn3 = new TreeListColumn();
            this.bsGoodGroup = new BindingSource(this.components);
            this.ds_good1 = new ds_good();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new RepositoryItemCheckEdit();
            this.imageList1 = new ImageList(this.components);
            this.splitter1 = new Splitter();
            this.gridControlGood = new GridControl();
            this.gridViewGood = new GridView();
            this.colidgood = new GridColumn();
            this.colmarking = new GridColumn();
            this.colname1 = new GridColumn();
            this.colsystem_name = new GridColumn();
            this.colheight = new GridColumn();
            this.colwidth = new GridColumn();
            this.colthick = new GridColumn();
            this.colweight = new GridColumn();
            this.colmeasure_shortname = new GridColumn();
            this.cboMeasure = new RepositoryItemComboBox();
            this.colidgoodgroup = new GridColumn();
            this.colprice2 = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.colvalut_shortname2 = new GridColumn();
            this.cboValut2 = new RepositoryItemComboBox();
            this.colcolor1_name = new GridColumn();
            this.colcolor2_name = new GridColumn();
            this.colgoodtype_name = new GridColumn();
            this.colpaking = new GridColumn();
            this.colcomment = new GridColumn();
            this.colextmarking = new GridColumn();
            this.cboValut1 = new RepositoryItemComboBox();
            this.bsGood = new BindingSource(this.components);
            this.panel2 = new Panel();
            this.cmdCancel = new Button();
            this.cmdSelect = new Button();
            this.fKgoodgroupgoodBindingSource = new BindingSource(this.components);
            this.splitterControl1 = new SplitterControl();
            this.gridControlResult = new GridControl();
            this.ds = new DataSet();
            this.table_result = new DataTable();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn23 = new DataColumn();
            this.dataColumn24 = new DataColumn();
            this.dataColumn25 = new DataColumn();
            this.dataColumn26 = new DataColumn();
            this.dataColumn20 = new DataColumn();
            this.dataColumn22 = new DataColumn();
            this.dataColumn27 = new DataColumn();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn15 = new DataColumn();
            this.dataColumn16 = new DataColumn();
            this.dataColumn17 = new DataColumn();
            this.dataColumn18 = new DataColumn();
            this.dataColumn19 = new DataColumn();
            this.dataColumn21 = new DataColumn();
            this.dataColumn28 = new DataColumn();
            this.dataColumn29 = new DataColumn();
            this.dataColumn30 = new DataColumn();
            this.dataColumn31 = new DataColumn();
            this.dataColumn32 = new DataColumn();
            this.dataColumn33 = new DataColumn();
            this.gridViewResult = new GridView();
            this.colgood_name1 = new GridColumn();
            this.colgood_marking1 = new GridColumn();
            this.colqu1 = new GridColumn();
            this.colthick1 = new GridColumn();
            this.colheight1 = new GridColumn();
            this.colwidth1 = new GridColumn();
            this.colweight1 = new GridColumn();
            this.colsqr = new GridColumn();
            this.gridColumn1 = new GridColumn();
            this.colsystem_name1 = new GridColumn();
            this.colcolorout_name = new GridColumn();
            this.PopupContainerEditColor1 = new atColorPopUpContainer();
            this.colcolorin_name = new GridColumn();
            this.PopupContainerEditColor2 = new atColorPopUpContainer();
            this.colcomment1 = new GridColumn();
            this.repositoryItemTextEdit2 = new AtRepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new AtRepositoryItemTextEdit();
            this.buttonEditHideAndShowGroupAdding = new ButtonEdit();
            this.imageListColor = new ImageList(this.components);
            this.treeList1.BeginInit();
            ((ISupportInitialize)this.bsGoodGroup).BeginInit();
            this.ds_good1.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.repositoryItemCheckEdit2.BeginInit();
            this.gridControlGood.BeginInit();
            this.gridViewGood.BeginInit();
            this.cboMeasure.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.cboValut2.BeginInit();
            this.cboValut1.BeginInit();
            ((ISupportInitialize)this.bsGood).BeginInit();
            this.panel2.SuspendLayout();
            ((ISupportInitialize)this.fKgoodgroupgoodBindingSource).BeginInit();
            this.gridControlResult.BeginInit();
            this.ds.BeginInit();
            this.table_result.BeginInit();
            this.gridViewResult.BeginInit();
            this.PopupContainerEditColor1.BeginInit();
            this.PopupContainerEditColor2.BeginInit();
            this.repositoryItemTextEdit2.BeginInit();
            this.repositoryItemTextEdit3.BeginInit();
            this.buttonEditHideAndShowGroupAdding.Properties.BeginInit();
            this.SuspendLayout();
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
            this.treeList1.Columns.AddRange(new TreeListColumn[2]
      {
        this.colname,
        this.treeListColumn3
      });
            this.treeList1.DataSource = (object)this.bsGoodGroup;
            this.treeList1.Dock = DockStyle.Left;
            this.treeList1.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeList1.ImageIndexFieldName = "_imageindex";
            this.treeList1.KeyFieldName = "idgoodgroup";
            this.treeList1.Location = new Point(0, 0);
            this.treeList1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.ParentFieldName = "parentid";
            this.treeList1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemCheckEdit1,
        (RepositoryItem) this.repositoryItemCheckEdit2
      });
            this.treeList1.SelectImageList = (object)this.imageList1;
            this.treeList1.Size = new Size(230, 501);
            this.treeList1.TabIndex = 1;
            this.colname.Caption = "Группа материалов";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 27;
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 196;
            this.treeListColumn3.Caption = "treeListColumn3";
            this.treeListColumn3.FieldName = "numpos";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.SortOrder = SortOrder.Ascending;
            this.bsGoodGroup.DataMember = "goodgroup";
            this.bsGoodGroup.DataSource = (object)this.ds_good1;
            this.bsGoodGroup.Filter = "isactive = true and isvisible = true";
            this.bsGoodGroup.Sort = "name";
            this.ds_good1.DataSetName = "ds_good";
            this.ds_good1.EnforceConstraints = false;
            this.ds_good1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Search.bmp");
            this.imageList1.Images.SetKeyName(1, "Folder2.ico");
            this.imageList1.Images.SetKeyName(2, "Folder.ico");
            this.splitter1.Location = new Point(230, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 501);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            this.gridControlGood.DataMember = "FK_goodgroup_good";
            this.gridControlGood.DataSource = (object)this.bsGoodGroup;
            this.gridControlGood.Dock = DockStyle.Fill;
            this.gridControlGood.EmbeddedNavigator.Name = "";
            this.gridControlGood.Location = new Point(233, 0);
            this.gridControlGood.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlGood.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlGood.MainView = (BaseView)this.gridViewGood;
            this.gridControlGood.Name = "gridControlGood";
            this.gridControlGood.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.cboMeasure,
        (RepositoryItem) this.cboValut1,
        (RepositoryItem) this.cboValut2
      });
            this.gridControlGood.Size = new Size(703, 294);
            this.gridControlGood.TabIndex = 0;
            this.gridControlGood.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewGood
      });
            this.gridViewGood.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGood.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGood.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGood.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewGood.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewGood.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewGood.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewGood.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGood.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGood.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewGood.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGood.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGood.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewGood.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewGood.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewGood.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewGood.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewGood.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGood.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGood.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewGood.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewGood.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewGood.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewGood.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewGood.BorderStyle = BorderStyles.Simple;
            this.gridViewGood.Columns.AddRange(new GridColumn[18]
      {
        this.colidgood,
        this.colmarking,
        this.colname1,
        this.colsystem_name,
        this.colheight,
        this.colwidth,
        this.colthick,
        this.colweight,
        this.colmeasure_shortname,
        this.colidgoodgroup,
        this.colprice2,
        this.colvalut_shortname2,
        this.colcolor1_name,
        this.colcolor2_name,
        this.colgoodtype_name,
        this.colpaking,
        this.colcomment,
        this.colextmarking
      });
            this.gridViewGood.GridControl = this.gridControlGood;
            this.gridViewGood.GroupPanelText = "Панель группировки";
            this.gridViewGood.Name = "gridViewGood";
            this.gridViewGood.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewGood.OptionsBehavior.Editable = false;
            this.gridViewGood.OptionsCustomization.AllowFilter = false;
            this.gridViewGood.OptionsDetail.ShowDetailTabs = false;
            this.gridViewGood.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGood.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewGood.OptionsView.ShowIndicator = false;
            this.colidgood.Caption = "#";
            this.colidgood.FieldName = "idgood";
            this.colidgood.Name = "colidgood";
            this.colidgood.OptionsColumn.AllowEdit = false;
            this.colidgood.Visible = true;
            this.colidgood.VisibleIndex = 0;
            this.colidgood.Width = 40;
            this.colmarking.Caption = "Артикул";
            this.colmarking.FieldName = "marking";
            this.colmarking.Name = "colmarking";
            this.colmarking.Visible = true;
            this.colmarking.VisibleIndex = 1;
            this.colmarking.Width = 73;
            this.colname1.Caption = "Наименование";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 2;
            this.colname1.Width = 168;
            this.colsystem_name.Caption = "Система";
            this.colsystem_name.FieldName = "system_name";
            this.colsystem_name.Name = "colsystem_name";
            this.colsystem_name.OptionsColumn.AllowEdit = false;
            this.colsystem_name.Visible = true;
            this.colsystem_name.VisibleIndex = 3;
            this.colsystem_name.Width = 64;
            this.colheight.Caption = "Высота";
            this.colheight.FieldName = "height";
            this.colheight.Name = "colheight";
            this.colheight.Width = 58;
            this.colwidth.Caption = "Ширина";
            this.colwidth.FieldName = "width";
            this.colwidth.Name = "colwidth";
            this.colwidth.Width = 62;
            this.colthick.Caption = "Длина";
            this.colthick.FieldName = "thick";
            this.colthick.Name = "colthick";
            this.colthick.Width = 52;
            this.colweight.Caption = "Вес";
            this.colweight.FieldName = "weight";
            this.colweight.Name = "colweight";
            this.colweight.Width = 27;
            this.colmeasure_shortname.Caption = "Ед.изм.";
            this.colmeasure_shortname.ColumnEdit = (RepositoryItem)this.cboMeasure;
            this.colmeasure_shortname.FieldName = "measure_shortname";
            this.colmeasure_shortname.Name = "colmeasure_shortname";
            this.colmeasure_shortname.OptionsColumn.AllowEdit = false;
            this.colmeasure_shortname.Visible = true;
            this.colmeasure_shortname.VisibleIndex = 4;
            this.colmeasure_shortname.Width = 60;
            this.cboMeasure.AutoHeight = false;
            this.cboMeasure.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboMeasure.ButtonsStyle = BorderStyles.Office2003;
            this.cboMeasure.Name = "cboMeasure";
            this.cboMeasure.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colidgoodgroup.Caption = "idgoodgroup";
            this.colidgoodgroup.FieldName = "idgoodgroup";
            this.colidgoodgroup.Name = "colidgoodgroup";
            this.colidgoodgroup.OptionsColumn.AllowEdit = false;
            this.colidgoodgroup.Width = 70;
            this.colprice2.Caption = "Цена 2";
            this.colprice2.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colprice2.FieldName = "price2";
            this.colprice2.Name = "colprice2";
            this.colprice2.Visible = true;
            this.colprice2.VisibleIndex = 5;
            this.colprice2.Width = 31;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n4";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n4";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.colvalut_shortname2.Caption = "Валюта цены 2";
            this.colvalut_shortname2.ColumnEdit = (RepositoryItem)this.cboValut2;
            this.colvalut_shortname2.FieldName = "valut2_shortname";
            this.colvalut_shortname2.Name = "colvalut_shortname2";
            this.colvalut_shortname2.Visible = true;
            this.colvalut_shortname2.VisibleIndex = 6;
            this.cboValut2.AutoHeight = false;
            this.cboValut2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut2.Name = "cboValut2";
            this.colcolor1_name.Caption = "Цвет1";
            this.colcolor1_name.FieldName = "color1_name";
            this.colcolor1_name.Name = "colcolor1_name";
            this.colcolor1_name.OptionsColumn.AllowEdit = false;
            this.colcolor1_name.Visible = true;
            this.colcolor1_name.VisibleIndex = 7;
            this.colcolor1_name.Width = 62;
            this.colcolor2_name.Caption = "Цвет2";
            this.colcolor2_name.FieldName = "color2_name";
            this.colcolor2_name.Name = "colcolor2_name";
            this.colcolor2_name.OptionsColumn.AllowEdit = false;
            this.colcolor2_name.Visible = true;
            this.colcolor2_name.VisibleIndex = 8;
            this.colcolor2_name.Width = 66;
            this.colgoodtype_name.Caption = "Тип";
            this.colgoodtype_name.FieldName = "goodtype_name";
            this.colgoodtype_name.Name = "colgoodtype_name";
            this.colgoodtype_name.OptionsColumn.AllowEdit = false;
            this.colgoodtype_name.OptionsColumn.ReadOnly = true;
            this.colgoodtype_name.Visible = true;
            this.colgoodtype_name.VisibleIndex = 9;
            this.colpaking.Caption = "Норма упаковки";
            this.colpaking.FieldName = "paking";
            this.colpaking.Name = "colpaking";
            this.colpaking.Visible = true;
            this.colpaking.VisibleIndex = 10;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Width = 77;
            this.colextmarking.Caption = "Вн.код";
            this.colextmarking.FieldName = "extmarking";
            this.colextmarking.Name = "colextmarking";
            this.colextmarking.Width = 45;
            this.cboValut1.AutoHeight = false;
            this.cboValut1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut1.Name = "cboValut1";
            this.bsGood.DataMember = "good";
            this.bsGood.DataSource = (object)this.ds_good1;
            this.bsGood.Filter = "goodgroup_isactive = true and goodgroup_isvisible = true";
            this.bsGood.Sort = "";
            this.panel2.Controls.Add((Control)this.cmdCancel);
            this.panel2.Controls.Add((Control)this.cmdSelect);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(936, 33);
            this.panel2.TabIndex = 5;
            this.cmdCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.FlatStyle = FlatStyle.Flat;
            this.cmdCancel.Location = new Point(849, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Отменить";
            this.cmdSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdSelect.DialogResult = DialogResult.OK;
            this.cmdSelect.FlatStyle = FlatStyle.Flat;
            this.cmdSelect.Location = new Point(768, 5);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new Size(75, 23);
            this.cmdSelect.TabIndex = 2;
            this.cmdSelect.Text = "Выбрать";
            this.fKgoodgroupgoodBindingSource.DataMember = "FK_goodgroup_good";
            this.fKgoodgroupgoodBindingSource.DataSource = (object)this.bsGoodGroup;
            this.splitterControl1.Dock = DockStyle.Bottom;
            this.splitterControl1.Location = new Point(233, 314);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(703, 6);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            this.gridControlResult.DataMember = "result";
            this.gridControlResult.DataSource = (object)this.ds;
            this.gridControlResult.Dock = DockStyle.Bottom;
            this.gridControlResult.EmbeddedNavigator.Name = "";
            this.gridControlResult.Location = new Point(233, 320);
            this.gridControlResult.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlResult.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlResult.MainView = (BaseView)this.gridViewResult;
            this.gridControlResult.Name = "gridControlResult";
            this.gridControlResult.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.repositoryItemTextEdit2,
        (RepositoryItem) this.repositoryItemTextEdit3,
        (RepositoryItem) this.PopupContainerEditColor1,
        (RepositoryItem) this.PopupContainerEditColor2
      });
            this.gridControlResult.Size = new Size(703, 181);
            this.gridControlResult.TabIndex = 2;
            this.gridControlResult.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewResult
      });
            this.ds.DataSetName = "ds_goodkit";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_result
      });
            this.table_result.Columns.AddRange(new DataColumn[33]
      {
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn10,
        this.dataColumn11,
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14,
        this.dataColumn23,
        this.dataColumn24,
        this.dataColumn25,
        this.dataColumn26,
        this.dataColumn20,
        this.dataColumn22,
        this.dataColumn27,
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn9,
        this.dataColumn15,
        this.dataColumn16,
        this.dataColumn17,
        this.dataColumn18,
        this.dataColumn19,
        this.dataColumn21,
        this.dataColumn28,
        this.dataColumn29,
        this.dataColumn30,
        this.dataColumn31,
        this.dataColumn32,
        this.dataColumn33
      });
            this.table_result.TableName = "result";
            this.dataColumn6.ColumnName = "idgood";
            this.dataColumn6.DataType = typeof(int);
            this.dataColumn7.ColumnName = "name";
            this.dataColumn7.Prefix = "local";
            this.dataColumn8.ColumnName = "marking";
            this.dataColumn8.Prefix = "local";
            this.dataColumn10.ColumnName = "qu";
            this.dataColumn10.DataType = typeof(double);
            this.dataColumn11.ColumnName = "thick";
            this.dataColumn11.DataType = typeof(int);
            this.dataColumn12.ColumnName = "height";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.ColumnName = "width";
            this.dataColumn13.DataType = typeof(int);
            this.dataColumn14.ColumnName = "weight";
            this.dataColumn14.DataType = typeof(double);
            this.dataColumn23.ColumnName = "price1";
            this.dataColumn23.DataType = typeof(double);
            this.dataColumn23.Prefix = "local";
            this.dataColumn24.ColumnName = "price2";
            this.dataColumn24.DataType = typeof(double);
            this.dataColumn24.Prefix = "local";
            this.dataColumn25.ColumnName = "price1base";
            this.dataColumn25.DataType = typeof(double);
            this.dataColumn25.Prefix = "local";
            this.dataColumn26.ColumnName = "price2base";
            this.dataColumn26.DataType = typeof(double);
            this.dataColumn26.Prefix = "local";
            this.dataColumn20.ColumnName = "system_name";
            this.dataColumn22.ColumnName = "idgoodtype";
            this.dataColumn22.DataType = typeof(int);
            this.dataColumn27.ColumnName = "idgoodtype2";
            this.dataColumn27.DataType = typeof(int);
            this.dataColumn1.ColumnName = "idcolor1";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "idcolor2";
            this.dataColumn2.DataType = typeof(int);
            this.dataColumn3.ColumnName = "colorin_name";
            this.dataColumn4.ColumnName = "colorout_name";
            this.dataColumn5.ColumnName = "measure_shortname";
            this.dataColumn9.ColumnName = "waste";
            this.dataColumn9.DataType = typeof(double);
            this.dataColumn15.ColumnName = "measure_typ";
            this.dataColumn15.DataType = typeof(int);
            this.dataColumn16.ColumnName = "measure_factor";
            this.dataColumn16.DataType = typeof(double);
            this.dataColumn17.ColumnName = "goodtype_name";
            this.dataColumn18.ColumnName = "goodtype_name2";
            this.dataColumn19.ColumnName = "ismy";
            this.dataColumn19.DataType = typeof(int);
            this.dataColumn21.ColumnName = "sqr";
            this.dataColumn21.DataType = typeof(double);
            this.dataColumn28.ColumnName = "comment";
            this.dataColumn29.ColumnName = "idvalut";
            this.dataColumn29.DataType = typeof(int);
            this.dataColumn30.ColumnName = "valut_shortname";
            this.dataColumn31.ColumnName = "idgoodgroup";
            this.dataColumn31.DataType = typeof(int);
            this.dataColumn32.ColumnName = "goodgroup_name";
            this.dataColumn33.ColumnName = "idgoodoptim";
            this.dataColumn33.DataType = typeof(int);
            this.gridViewResult.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResult.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResult.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResult.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewResult.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewResult.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewResult.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewResult.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResult.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResult.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewResult.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResult.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResult.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewResult.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewResult.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewResult.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewResult.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewResult.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResult.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResult.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewResult.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewResult.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewResult.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewResult.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewResult.BorderStyle = BorderStyles.Simple;
            this.gridViewResult.Columns.AddRange(new GridColumn[13]
      {
        this.colgood_name1,
        this.colgood_marking1,
        this.colqu1,
        this.colthick1,
        this.colheight1,
        this.colwidth1,
        this.colweight1,
        this.colsqr,
        this.gridColumn1,
        this.colsystem_name1,
        this.colcolorout_name,
        this.colcolorin_name,
        this.colcomment1
      });
            this.gridViewResult.GridControl = this.gridControlResult;
            this.gridViewResult.GroupPanelText = "Панель группировки";
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewResult.OptionsCustomization.AllowFilter = false;
            this.gridViewResult.OptionsDetail.ShowDetailTabs = false;
            this.gridViewResult.OptionsSelection.MultiSelect = true;
            this.gridViewResult.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewResult.OptionsView.ShowGroupPanel = false;
            this.gridViewResult.OptionsView.ShowIndicator = false;
            this.colgood_name1.Caption = "Наименование";
            this.colgood_name1.FieldName = "name";
            this.colgood_name1.Name = "colgood_name1";
            this.colgood_name1.OptionsColumn.AllowEdit = false;
            this.colgood_name1.Visible = true;
            this.colgood_name1.VisibleIndex = 1;
            this.colgood_name1.Width = 187;
            this.colgood_marking1.Caption = "Артикул";
            this.colgood_marking1.FieldName = "marking";
            this.colgood_marking1.Name = "colgood_marking1";
            this.colgood_marking1.OptionsColumn.AllowEdit = false;
            this.colgood_marking1.Visible = true;
            this.colgood_marking1.VisibleIndex = 0;
            this.colgood_marking1.Width = 149;
            this.colqu1.Caption = "Кол-во";
            this.colqu1.FieldName = "qu";
            this.colqu1.Name = "colqu1";
            this.colqu1.Visible = true;
            this.colqu1.VisibleIndex = 2;
            this.colqu1.Width = 70;
            this.colthick1.Caption = "Длина";
            this.colthick1.FieldName = "thick";
            this.colthick1.Name = "colthick1";
            this.colthick1.Visible = true;
            this.colthick1.VisibleIndex = 3;
            this.colthick1.Width = 70;
            this.colheight1.Caption = "Высота";
            this.colheight1.FieldName = "height";
            this.colheight1.Name = "colheight1";
            this.colheight1.Visible = true;
            this.colheight1.VisibleIndex = 4;
            this.colheight1.Width = 70;
            this.colwidth1.Caption = "Ширина";
            this.colwidth1.FieldName = "width";
            this.colwidth1.Name = "colwidth1";
            this.colwidth1.Visible = true;
            this.colwidth1.VisibleIndex = 5;
            this.colwidth1.Width = 70;
            this.colweight1.Caption = "Вес";
            this.colweight1.FieldName = "weight";
            this.colweight1.Name = "colweight1";
            this.colweight1.Visible = true;
            this.colweight1.VisibleIndex = 6;
            this.colweight1.Width = 70;
            this.colsqr.Caption = "S";
            this.colsqr.FieldName = "sqr";
            this.colsqr.Name = "colsqr";
            this.colsqr.Visible = true;
            this.colsqr.VisibleIndex = 7;
            this.gridColumn1.Caption = "Цена";
            this.gridColumn1.FieldName = "price2";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 70;
            this.colsystem_name1.Caption = "Система";
            this.colsystem_name1.FieldName = "system_name";
            this.colsystem_name1.Name = "colsystem_name1";
            this.colsystem_name1.OptionsColumn.AllowEdit = false;
            this.colsystem_name1.Visible = true;
            this.colsystem_name1.VisibleIndex = 9;
            this.colsystem_name1.Width = 76;
            this.colcolorout_name.Caption = "Цвет1";
            this.colcolorout_name.ColumnEdit = (RepositoryItem)this.PopupContainerEditColor1;
            this.colcolorout_name.FieldName = "colorout_name";
            this.colcolorout_name.Name = "colcolorout_name";
            this.colcolorout_name.Visible = true;
            this.colcolorout_name.VisibleIndex = 10;
            this.PopupContainerEditColor1.AutoHeight = false;
            this.PopupContainerEditColor1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.PopupContainerEditColor1.Name = "PopupContainerEditColor1";
            this.colcolorin_name.Caption = "Цвет2";
            this.colcolorin_name.ColumnEdit = (RepositoryItem)this.PopupContainerEditColor2;
            this.colcolorin_name.FieldName = "colorin_name";
            this.colcolorin_name.Name = "colcolorin_name";
            this.colcolorin_name.Visible = true;
            this.colcolorin_name.VisibleIndex = 11;
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
            this.colcomment1.VisibleIndex = 12;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.DisplayFormat.FormatString = "n";
            this.repositoryItemTextEdit2.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit2.EditFormat.FormatString = "n";
            this.repositoryItemTextEdit2.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.buttonEditHideAndShowGroupAdding.Dock = DockStyle.Bottom;
            this.buttonEditHideAndShowGroupAdding.Location = new Point(233, 294);
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
            this.buttonEditHideAndShowGroupAdding.Size = new Size(703, 20);
            this.buttonEditHideAndShowGroupAdding.TabIndex = 1;
            this.imageListColor.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListColor.ImageStream");
            this.imageListColor.TransparentColor = Color.Magenta;
            this.imageListColor.Images.SetKeyName(0, "Folder.ico");
            this.imageListColor.Images.SetKeyName(1, "ChooseColor.bmp");
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlGood);
            this.Controls.Add((Control)this.buttonEditHideAndShowGroupAdding);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.gridControlResult);
            this.Controls.Add((Control)this.splitter1);
            this.Controls.Add((Control)this.treeList1);
            this.Controls.Add((Control)this.panel2);
            this.Name = "SelectGoodForm";
            this.Size = new Size(936, 534);
            this.Text = "Материалы";
            this.treeList1.EndInit();
            ((ISupportInitialize)this.bsGoodGroup).EndInit();
            this.ds_good1.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.repositoryItemCheckEdit2.EndInit();
            this.gridControlGood.EndInit();
            this.gridViewGood.EndInit();
            this.cboMeasure.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.cboValut2.EndInit();
            this.cboValut1.EndInit();
            ((ISupportInitialize)this.bsGood).EndInit();
            this.panel2.ResumeLayout(false);
            ((ISupportInitialize)this.fKgoodgroupgoodBindingSource).EndInit();
            this.gridControlResult.EndInit();
            this.ds.EndInit();
            this.table_result.EndInit();
            this.gridViewResult.EndInit();
            this.PopupContainerEditColor1.EndInit();
            this.PopupContainerEditColor2.EndInit();
            this.repositoryItemTextEdit2.EndInit();
            this.repositoryItemTextEdit3.EndInit();
            this.buttonEditHideAndShowGroupAdding.Properties.EndInit();
            this.ResumeLayout(false);
        }
    }
}
