// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad;
using Atechnology.ecad.Calc;
using Atechnology.winDraw.Model.Settings;
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
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class GoodForm : AtUserControl
    {
        public int f_idg = -1;
        public DataRow ChoiceGood1;
        public DataRow ChoiceGood2;
        public bool DoubleChoice;
        public int isdialog;
        private DataRow MoveGroup;
        private DataRow[] MoveItems;
        private bool isKeyMove;
        public int f_id;
        private IContainer components;
        private Button button3;
        private Button button2;
        private Button button1;
        private TreeList treeList1;
        private Splitter splitter1;
        private DataSet ds;
        private DataTable table_goodgroup;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        public DataTable table_good;
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
        private ImageList imageList1;
        private TreeListColumn colname;
        private DataColumn dataColumn16;
        private GridColumn colname1;
        private GridColumn colcomment;
        private GridColumn colmarking;
        private GridColumn colextmarking;
        private GridColumn colheight;
        private GridColumn colwidth;
        private GridColumn colthick;
        private GridColumn colweight;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip MenuGroup;
        private ToolStripMenuItem MenuItemAddMainGroup;
        private ToolStripMenuItem MenuItemAddChildGroup;
        private ToolStripMenuItem MenuItemRenameGroup;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuItemRemoveGroup;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripMenuItem MenuItemDoublicate;
        private ToolStripMenuItem MenuItemEdit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemFromFile;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MenuItemRemove;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private GridColumn colmeasure_shortname;
        private GridColumn colidgoodgroup;
        private DataColumn dataColumn19;
        public Button CancelButton;
        public Button DefaultButton;
        public Panel panel1;
        public Panel panel2;
        public GridControl gridControlGood;
        public GridView gridViewGood;
        private ToolStripMenuItem MenuItemHistoryPrice;
        private ToolStripSeparator toolStripSeparator4;
        private DataColumn dataColumn20;
        private DataColumn dataColumn21;
        private GridColumn colprice1;
        private AtRepositoryItemTextEdit txtWaste;
        private GridColumn colprice2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem MenuItemMoveInGroup;
        private DataColumn dataColumn22;
        private GridColumn colsystem_name;
        private DataColumn dataColumn23;
        private GridColumn colwaste;
        private DataColumn dataColumn24;
        private GridColumn colidgood;
        private DataColumn dataColumn25;
        private DataColumn dataColumn26;
        private GridColumn colvalut_shortname;
        private DataColumn dataColumn27;
        private DataColumn dataColumn28;
        private DataColumn dataColumn29;
        private DataColumn dataColumn30;
        private GridColumn colcolor1_name;
        private GridColumn colcolor2_name;
        private GridColumn coltyp;
        private Button button7;
        private Button button6;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private DataColumn dataColumn31;
        private DataColumn dataColumn32;
        private GridColumn colgoodtype_name;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem MenuItemCreateGoodForColor;
        private DataTable table_color;
        private DataColumn dataColumn33;
        private DataColumn dataColumn34;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem toolStripMenuItem16;
        private DataColumn dataColumn35;
        private TreeListColumn treeListColumn1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private TreeListColumn treeListColumn2;
        private RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DataColumn dataColumn36;
        private DataColumn dataColumn37;
        private DataColumn dataColumn38;
        private TreeListColumn treeListColumn3;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem toolStripMenuItem19;
        private DataColumn dataColumn39;
        private ToolStripMenuItem MenuGroupMoveInGroup;
        private ToolStripMenuItem toolStripMenuItem21;
        private DataColumn dataColumn40;
        private GridColumn colgoodpricegroup_name;
        private DataColumn dataColumn41;
        private ToolStripMenuItem MenuItemGoToGroup;
        private DataColumn dataColumn42;
        private GridColumn colminost;
        private ToolStripMenuItem toolStripMenuItem23;
        private DataColumn dataColumn43;
        private DataColumn dataColumn44;
        private GridColumn colgoodoptim_name;
        private ToolStripMenuItem toolStripMenuItem24;
        private ToolStripMenuItem MenuGroupSetMain;
        private DataColumn dataColumn45;
        private RepositoryItemComboBox cboMeasure;
        private DataTable table_measure;
        private DataColumn dataColumn46;
        private DataColumn dataColumn47;
        private DataColumn dataColumn48;
        private DataColumn dataColumn49;
        private DataColumn dataColumn50;
        private DataColumn dataColumn51;
        private DataColumn dataColumn52;
        private DataColumn dataColumn53;
        private DataColumn dataColumn54;
        private DataColumn dataColumn55;
        private DataColumn dataColumn56;
        private DataColumn dataColumn57;
        private GridColumn colprice3;
        private GridColumn colprice4;
        private GridColumn colprice5;
        private GridColumn colvalut_shortname2;
        private GridColumn colvalut_shortname3;
        private GridColumn colvalut_shortname4;
        private GridColumn colvalut_shortname5;
        private GridColumn colpaking;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem MenuItemFindAndReplace;
        private ToolStripSeparator toolStripSeparator9;
        private RepositoryItemComboBox cboValut1;
        private RepositoryItemComboBox cboValut2;
        private DataTable table_valut;
        private DataColumn dataColumn58;
        private DataColumn dataColumn59;
        private DataColumn dataColumn60;
        private DataColumn dataColumn61;
        private ToolStripMenuItem MenuGroupSetGoodType2;
        private ToolStripMenuItem MenuGroupSetStoreDepart;
        private RepositoryItemComboBox cboValut3;
        private RepositoryItemComboBox cboValut4;
        private RepositoryItemComboBox cboValut5;
        private GridColumn colsqr;
        private RepositoryItemComboBox cboGoodType;
        private DataColumn dataColumn62;
        private DataTable table_goodtype;
        private GridColumn colgoodtype_name2;
        private RepositoryItemComboBox cboGoodType2;
        private DataColumn dataColumn63;
        private DataColumn dataColumn64;
        private DataColumn dataColumn65;
        private GridColumn colsqr2;
        private DataColumn dataColumn66;
        private DataColumn dataColumn67;
        private DataColumn dataColumn68;
        private DataColumn dataColumn69;
        private DataColumn dataColumn70;
        private GridColumn colwaste2;
        private GridColumn colwaste3;
        private GridColumn colwaste4;
        private GridColumn colwaste5;
        private DataColumn dataColumn71;
        private GridColumn gridColumn1;
        private DataColumn dataColumn72;
        private DataColumn dataColumn73;
        private ToolStripMenuItem MenuGroupSetOptimOutSettings;
        private DataColumn dataColumn74;
        private DataColumn dataColumn75;
        private GridColumn colcolorgroupcustom_name;
        private DataColumn dataColumn76;
        private DataColumn dataColumn77;
        private GridColumn colcustomer_name;

        public GoodForm()
        {
            this.InitializeComponent();
            this.ConstructionMethod();
            this.LoadFromBase();
            this.AddEvents();
        }

        public GoodForm(bool LoadGoods)
        {
            this.InitializeComponent();
            using (new ThreadingStatusImageForm("Идет загрузка справочника материалов", "Подождите"))
            {
                if (LoadGoods)
                    Goods.Reload();
                CalcProcessor calcProcessor = new CalcProcessor(this.db);
                calcProcessor.ExecuteOrderEvent("События справочников.Перед загрузкой списка материалов", (object)this);
                Application.DoEvents();
                this.ConstructionMethod();
                this.table_goodgroup.Merge(Goods.table_goodgroup);
                this.table_good.Merge(Goods.table_good);
                if (this.table_goodgroup.Rows.Count != Goods.table_goodgroup.Rows.Count + 1 || this.table_good.Rows.Count != Goods.table_good.Rows.Count)
                    Goods.Reload();
                this.AddEvents();
                this.CreateGroups();
                this.db.command.CommandText = "select * from measure where deleted is null";
                this.db.adapter.Fill(this.table_measure);
                foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_measure.Rows)
                    this.cboMeasure.Items.Add((object)new Measure(Convert.ToInt32(dataRow["idmeasure"]), dataRow["name"].ToString(), dataRow["shortname"].ToString()));
                this.colmeasure_shortname.OptionsColumn.AllowEdit = true;
                this.db.command.CommandText = "select * from valut where deleted is null";
                this.db.adapter.Fill(this.table_valut);
                foreach (DataRow dr in (InternalDataCollectionBase)this.table_valut.Rows)
                {
                    this.cboValut1.Items.Add((object)new Valut(dr));
                    this.cboValut2.Items.Add((object)new Valut(dr));
                    this.cboValut3.Items.Add((object)new Valut(dr));
                    this.cboValut4.Items.Add((object)new Valut(dr));
                    this.cboValut5.Items.Add((object)new Valut(dr));
                }
                this.cboValut1.TextEditStyle = TextEditStyles.DisableTextEditor;
                this.cboValut2.TextEditStyle = TextEditStyles.DisableTextEditor;
                calcProcessor.ExecuteOrderEvent("События справочников.После загрузки списка материалов", (object)this);
            }
        }

        public GoodForm(int idgood)
        {
            this.InitializeComponent();
            this.ConstructionMethod();
            this.table_goodgroup.Merge(Goods.table_goodgroup);
            this.table_good.Merge(Goods.table_good);
            if (this.table_goodgroup.Rows.Count != Goods.table_goodgroup.Rows.Count + 1 || this.table_good.Rows.Count != Goods.table_good.Rows.Count)
                Goods.Reload();
            this.AddEvents();
            this.CreateGroups();
            DataRow[] dataRowArray = Goods.table_good.Select("idgood = " + idgood.ToString());
            if (dataRowArray.Length == 0)
                return;
            this.f_id = idgood;
            this.f_idg = (int)dataRowArray[0]["idgoodgroup"];
        }

        private void ConstructionMethod()
        {
            if (Atechnology.ecad.Settings.People.IsAdmin)
            {
                this.treeList1.Columns["isactive"].VisibleIndex = 1;
                this.treeList1.Columns["isvisible"].VisibleIndex = 2;
            }
            else
            {
                this.treeList1.Columns["isactive"].VisibleIndex = -1;
                this.treeList1.Columns["isvisible"].VisibleIndex = -1;
            }
            this.gridViewGood.OptionsSelection.MultiSelect = true;
            this.panel3.Visible = Atechnology.ecad.Settings.Base.ShowHelp;
            this.CreateGroups();
        }

        private void AddEvents()
        {
            this.treeList1.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.KeyDown += new KeyEventHandler(this.treeList1_KeyDown);
            this.Shown += new Shown(this.GoodForm_Shown);
            this.gridViewGood.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
            this.FormClosing += new FormClosing(this.GoodForm_FormClosing);
            this.gridViewGood.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.treeList1.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeList1_CellValueChanged);
            this.MenuItemCreateGoodForColor.Click += new EventHandler(this.MenuItemCreateGoodForColor_Click);
            this.MenuItemFindAndReplace.Click += new EventHandler(this.MenuItemFindAndReplace_Click);
            this.gridViewGood.KeyPress += new KeyPressEventHandler(this.gridView1_KeyPress);
            this.cboValut1.EditValueChanged += new EventHandler(this.cboValut1_EditValueChanged);
            this.cboValut2.EditValueChanged += new EventHandler(this.cboValut2_EditValueChanged);
            this.cboValut3.EditValueChanged += new EventHandler(this.cboValut3_EditValueChanged);
            this.cboValut4.EditValueChanged += new EventHandler(this.cboValut4_EditValueChanged);
            this.cboValut5.EditValueChanged += new EventHandler(this.cboValut5_EditValueChanged);
            this.cboGoodType.ButtonClick += new ButtonPressedEventHandler(this.cboGoodType_ButtonClick);
            this.cboGoodType2.ButtonClick += new ButtonPressedEventHandler(this.cboGoodType2_ButtonClick);
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 13)
                return;
            this.GoodChoice();
        }

        private void MenuItemFindAndReplace_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlGood);
            if (selectedDataRows == null || selectedDataRows.Length == 0 || (InputBox.ShowDialog("Поиск и замена в наименовании", "Искать", "Замнеять на", "", "") != DialogResult.OK || InputBox.Value == ""))
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow["name"] = (object)dataRow["name"].ToString().Replace(InputBox.Value, InputBox.Value2);
        }

        private void CreateGroups()
        {
            if (this.table_goodgroup.Select("imageindex = 4").Length == 0)
            {
                DataRow row = this.table_goodgroup.NewRow();
                row["imageindex"] = (object)4;
                row["name"] = (object)"Все материалы";
                row["idgoodgroup"] = (object)-1;
                row["parentid"] = (object)-1;
                this.table_goodgroup.Rows.Add(row);
            }
            foreach (DataRow dataRow in this.table_goodgroup.Select("parentid is null"))
                dataRow["imageindex"] = (object)5;
            this.table_goodgroup.AcceptChanges();
        }

        private void cboGoodType_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGood);
            if (dataRow == null)
                return;
            dataRow["idgoodtype"] = (object)DBNull.Value;
            dataRow["goodtype_name"] = (object)DBNull.Value;
            this.BindingContext[(object)this.table_good].EndCurrentEdit();
            this.gridViewGood.RefreshEditor(true);
        }

        private void cboGoodType2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGood);
            if (dataRow == null)
                return;
            dataRow["idgoodtype2"] = (object)DBNull.Value;
            dataRow["goodtype_name2"] = (object)DBNull.Value;
            this.BindingContext[(object)this.table_good].EndCurrentEdit();
            this.gridViewGood.RefreshEditor(true);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.treeList1.Focused)
                this.isKeyMove = true;
            if (keyData == Keys.Escape && (this.MoveItems != null || this.MoveGroup != null))
            {
                this.MoveItems = (DataRow[])null;
                this.MoveGroup = (DataRow)null;
                this.Cursor = Cursors.Default;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void treeList1_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Column == this.treeListColumn1)
            {
                DataRow row = ((DataRowView)this.treeList1.GetDataRecordByNode(e.Node)).Row;
                foreach (DataRow dataRow in AtTreeList.GetListNodesRows(this.treeList1, e.Node))
                    dataRow["isactive"] = row["isactive"];
            }
            if (e.Column != this.treeListColumn2)
                return;
            DataRow row1 = ((DataRowView)this.treeList1.GetDataRecordByNode(e.Node)).Row;
            foreach (DataRow dataRow in AtTreeList.GetListNodesRows(this.treeList1, e.Node))
                dataRow["isvisible"] = row1["isvisible"];
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow dataRow = this.gridViewGood.GetDataRow(e.RowHandle);
            if (dataRow == null)
                return;
            if (Atechnology.ecad.Settings.isDealer && !(bool)dataRow["ismy"])
            {
                dataRow.RejectChanges();
                dataRow.CancelEdit();
                this.gridViewGood.RefreshRow(e.RowHandle);
                int num = (int)MessageBox.Show("Нельзя редактировать материалы, поступающие от поставщика!");
            }
            if (e.Column.FieldName == "measure_shortname")
            {
                dataRow["idmeasure"] = (object)((Measure)e.Value).Idmeasure;
                dataRow["measure_shortname"] = (object)((Measure)e.Value).Shortname;
            }
            if (e.Column.FieldName == "goodtype_name")
            {
                dataRow["idgoodtype"] = (object)((ComboboxItemClass)e.Value).id;
                dataRow["goodtype_name"] = (object)((ComboboxItemClass)e.Value).name;
            }
            if (!(e.Column.FieldName == "goodtype_name2"))
                return;
            dataRow["idgoodtype2"] = (object)((ComboboxItemClass)e.Value).id;
            dataRow["goodtype_name2"] = (object)((ComboboxItemClass)e.Value).name;
        }

        private void GoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.gridViewGood.Columns["Price1"] == null)
                this.gridViewGood.Columns.Add(this.colprice1);
            if (this.isdialog == 1 || !AtDataSet.IsModifDataSet(this.ds))
                return;
            switch (MessageBox.Show("Данные были изменены!\nСохранить изменения?", "Закрытие справочника материалов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void GoodForm_Shown(object sender, EventArgs e)
        {
            this.treeList1.MoveLastVisible();
            this.treeList1.MoveFirst();
            if (this.f_id != -1)
                this.RepositionGood(this.f_idg, this.f_id);
            if (this.Is_Dialog)
                return;
            this.gridViewGood.OptionsBehavior.Editable = Grant.Goods.GoodEdit;
            if (Grant.Goods.GoodEdit)
                return;
            this.gridControlGood.ContextMenuStrip = (ContextMenuStrip)null;
            this.treeList1.ContextMenuStrip = (ContextMenuStrip)null;
        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.treeList1.Focused && (this.MoveItems != null || this.MoveGroup != null))
                this.treeList1_FocusedNodeChanged((object)null, (FocusedNodeChangedEventArgs)null);
            else
                TreeList_KeyDown.Key(this.treeList1, e.KeyCode);
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null)
                return;
            this.SetDataMember();
            if (this.MoveItems != null && (int)selectedNode["imageindex"] != 4 && (!this.isKeyMove || sender == null))
            {
                foreach (DataRow dataRow in this.MoveItems)
                    dataRow["idgoodgroup"] = selectedNode["idgoodgroup"];
                this.Cursor = Cursors.Default;
                this.MoveItems = (DataRow[])null;
                this.isKeyMove = false;
                GC.Collect();
                GC.Collect();
            }
            if (this.MoveGroup != null && (int)selectedNode["imageindex"] != 4 && (!this.isKeyMove || sender == null))
            {
                this.treeList1.DataMember = (string)null;
                if (this.MoveGroup["parentid"] == DBNull.Value)
                    this.MoveGroup["imageindex"] = (object)0;
                this.MoveGroup["parentid"] = selectedNode["idgoodgroup"];
                this.Cursor = Cursors.Default;
                this.MoveGroup = (DataRow)null;
                this.isKeyMove = false;
                this.treeList1.DataMember = "goodgroup";
            }
            this.isKeyMove = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.isdialog == 1)
                this.GoodChoice();
            else
                this.MenuItemEdit_Click((object)null, (EventArgs)null);
        }

        public override void LoadFromBase()
        {
            if (this.table_goodgroup.Select("imageindex = 4").Length == 0)
            {
                DataRow row = this.table_goodgroup.NewRow();
                this.table_goodgroup.Rows.Add(row);
                row["name"] = (object)"Bсе материалы";
                row["idgoodgroup"] = (object)-1;
                row["imageindex"] = (object)4;
                row.AcceptChanges();
            }
            this.db.command.CommandText = "select * from goodgroup where deleted is null";
            if (!Atechnology.ecad.Settings.People.IsAdmin)
            {
                this.db.command.CommandText += " and isactive = 1";
                this.treeList1.Columns["isactive"].VisibleIndex = -1;
            }
            this.db.adapter.Fill(this.table_goodgroup);
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_goodgroup.Rows)
            {
                if (dataRow["parentid"] == DBNull.Value && (int)dataRow["imageindex"] != 4)
                    dataRow["imageindex"] = (object)5;
            }
            this.table_goodgroup.AcceptChanges();
            this.db.command.CommandText = "select * from view_good where deleted is null";
            this.db.adapter.Fill(this.table_good);
            this.db.command.CommandText = "select * from measure where deleted is null";
            this.db.adapter.Fill(this.table_measure);
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_measure.Rows)
                this.cboMeasure.Items.Add((object)dataRow);
            this.db.command.CommandText = "select idgoodtype,name from goodtype where deleted is null";
            this.db.adapter.Fill(this.table_goodtype);
            foreach (DataRow dr in (InternalDataCollectionBase)this.table_goodtype.Rows)
            {
                this.cboGoodType.Items.Add((object)new ComboboxItemClass(dr));
                this.cboGoodType2.Items.Add((object)new ComboboxItemClass(dr));
            }
            this.db.command.CommandText = "select * from valut where deleted is null";
            this.db.adapter.Fill(this.table_valut);
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_valut.Rows)
            {
                this.cboValut1.Items.Add((object)dataRow);
                this.cboValut2.Items.Add((object)dataRow);
            }
            this.cboValut1.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboValut2.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        public override bool SaveToBase()
        {
            using (AtUserControl.WithUIBlock)
            {
                using (new ThreadingStatusImageForm("Сохранение данных....", "Пожалуйста, подождите"))
                {
                    CalcProcessor calcProcessor = new CalcProcessor(this.db);
                    calcProcessor.ExecuteOrderEvent("События справочников.Перед сохранением списка материалов", this.table_good.Select(), false);
                    List<DataRow> list1 = new List<DataRow>();
                    List<DataRow> list2 = new List<DataRow>();
                    list1.AddRange((IEnumerable<DataRow>)this.table_good.Select("deleted is null", "", DataViewRowState.Added));
                    list2.AddRange((IEnumerable<DataRow>)this.table_good.Select("deleted is null", "", DataViewRowState.ModifiedCurrent));
                    GoodEditForm.SaveGoodPriceChanges(list2.ToArray());
                    if (!this.db.SaveDatatableAndAccept2(this.table_goodgroup) || !this.db.SaveDatatable(this.table_good))
                        return false;
                    GoodEditForm.SaveGoodPriceChanges(list1.ToArray(), false);
                    this.table_good.AcceptChanges();
                    foreach (DataRow dataRow1 in this.table_good.Select("_isdoublicate = true"))
                    {
                        DataTable dataTable = new DataTable("goodparam");
                        dbconn.FillDataTable(dataTable, string.Format("select * from goodparam where idgood = {0} and deleted is null", dataRow1["_doublicateidparent"]), true);
                        foreach (DataRow dataRow2 in dataTable.Select())
                        {
                            dataRow2.SetAdded();
                            dataRow2["idgoodparam"] = (object)dbconn.GetGenId("gen_goodparam");
                            dataRow2["idgood"] = dataRow1["idgood"];
                        }
                        dataTable.PrimaryKey = new DataColumn[1]
            {
              dataTable.Columns["idgoodparam"]
            };
                        dataTable.Columns.Remove("guid");
                        dataTable.Columns.Remove("deleted");
                        dbconn._db.SaveDatatable(dataTable);
                        dataRow1["_isdoublicate"] = (object)false;
                    }
                    calcProcessor.ExecuteOrderEvent("События справочников.После сохранения списка материалов", this.table_good.Select(), false);
                    Goods.Reload();
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds.Clear();
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null || InputBox.ShowDialog("Создание основной группы", "Введите имя", selectedNode["name"].ToString()) == DialogResult.Cancel)
                return;
            string str = InputBox.Value;
            this.db.ExecuteFunction("create_good_param " + selectedNode["idgoodgroup"].ToString() + ",'" + str + "'");
        }

        private void MenuItemAddMainGroup_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_goodgroup.NewRow();
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["idgoodgroup"] = (object)dbconn.GetGenId("gen_goodgroup");
            row["name"] = (object)InputBox.Value;
            row["isactive"] = (object)1;
            row["isvisible"] = (object)1;
            row["numpos"] = (object)this.GetGroupNumpos();
            row["imageindex"] = (object)5;
            this.table_goodgroup.Rows.Add(row);
        }

        private void MenuItemAddChildGroup_Click(object sender, EventArgs e)
        {
            this.CreateChildGroup("");
        }

        private void MenuItemRenameGroup_Click(object sender, EventArgs e)
        {
            if (this.treeList1.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.Selection[0])).Row;
            if (InputBox.ShowDialog("Изменить имя", "Введите новое имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
        }

        private void MenuItemRemoveGroup_Click(object sender, EventArgs e)
        {
            if (this.treeList1.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.Selection[0])).Row;
            this.treeList1.MovePrevVisible();
            int num = (int)row["idgoodgroup"];
            if (row.GetChildRows("Relation_goodgroup").Length != 0 && MessageBox.Show("Группа содержит вложенные подгруппы. Удалить группу вместе с вложениями?", "Удаление группы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            row.Delete();
            DataTable changes = this.table_good.GetChanges(DataRowState.Deleted);
            if (changes != null && changes.Rows.Count != 0)
                new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Удаление материала", this.table_good.Select("", "", DataViewRowState.Deleted), true);
            this.treeList1.RefreshDataSource();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeList1) == null)
                return;
            GoodPriceUpdateForm goodPriceUpdateForm = new GoodPriceUpdateForm();
            goodPriceUpdateForm.IsDialog();
            if (goodPriceUpdateForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow1 = AtGrid.getDataRow((Control)goodPriceUpdateForm.gridControl1);
            if (dataRow1 == null)
                return;
            foreach (DataRow dataRow2 in AtTreeList.GetListNodesRows(this.treeList1, this.treeList1.FocusedNode))
            {
                foreach (DataRow dataRow3 in this.ds.Tables["good"].Select("idgoodgroup = " + dataRow2["idgoodgroup"].ToString()))
                    dataRow3["idgoodpricegroup"] = dataRow1["idgoodpricegroup"];
            }
        }

        private void MenuItemGroupSetMain_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null || (int)selectedNode["imageindex"] == 5)
                return;
            selectedNode["parentid"] = (object)DBNull.Value;
            selectedNode["imageindex"] = (object)5;
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            DataRow row1 = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.FocusedNode)).Row;
            DataRow row2 = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.MovePrevVisible())).Row;
            if (row1["parentid"] != row2["parentid"])
                return;
            int num1 = (int)row1["numpos"];
            int num2 = (int)row2["numpos"];
            row1["numpos"] = (object)num2;
            row2["numpos"] = (object)num1;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            DataRow row1 = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.FocusedNode)).Row;
            if (this.treeList1.VisibleNodesCount == this.treeList1.GetVisibleIndexByNode(this.treeList1.FocusedNode) + 1)
                return;
            DataRow row2 = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.MoveNextVisible())).Row;
            if (row1["parentid"] != row2["parentid"])
                return;
            int num1 = (int)row1["numpos"];
            int num2 = (int)row2["numpos"];
            row1["numpos"] = (object)num2;
            row2["numpos"] = (object)num1;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            this.MoveGroup = AtTreeList.GetSelectedNode(this.treeList1);
            if (this.MoveGroup == null)
                return;
            this.Cursor = Cursors.Hand;
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            if (this.treeList1.Selection.Count == 0)
                return;
            DataRow row1 = ((DataRowView)this.treeList1.GetDataRecordByNode(this.treeList1.Selection[0])).Row;
            if (row1 == null)
                return;
            if ((int)row1["idgoodgroup"] == -1)
            {
                int num = (int)MessageBox.Show("Для создания материала необходимо выбрать одну из их групп!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.gridViewGood.ClearSelection();
                DataRow row2 = this.table_good.NewRow();
                row2["idgood"] = (object)dbconn.GetGenId("gen_good");
                row2["name"] = (object)"Новый материал";
                row2["idgoodgroup"] = row1["idgoodgroup"];
                row2["typ"] = (object)0;
                row2["ismy"] = (object)(Atechnology.ecad.Settings.isDealer ? 1 : 0);
                row2["usehouse"] = (object)0;
                row2["waste"] = (object)0;
                row2["idvalut"] = (object)1;
                row2["idvalut2"] = (object)1;
                row2["idvalut3"] = (object)1;
                row2["idvalut4"] = (object)1;
                row2["idvalut5"] = (object)1;
                row2["price1"] = (object)0;
                row2["price2"] = (object)0;
                row2["price3"] = (object)0;
                row2["price4"] = (object)0;
                row2["price5"] = (object)0;
                row2["packing"] = (object)0;
                this.table_good.Rows.Add(row2);
                new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Создание материала", new DataRow[1]
        {
          row2
        }, 0 != 0);
                this.gridViewGood.SelectRow(this.gridViewGood.FocusedRowHandle);
            }
        }

        private void MenuItemDoublicate_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlGood);
            if (selectedDataRows == null)
                return;
            this.gridViewGood.PostEditor();
            this.gridViewGood.ClearSelection();
            DataRow[] dr_event = new DataRow[selectedDataRows.Length];
            for (int index = 0; index < selectedDataRows.Length; ++index)
            {
                DataRow dataRow = AtDataSet.dublicate(selectedDataRows[index]);
                dataRow["idgood"] = (object)dbconn.GetGenId("gen_good");
                dataRow["idcolorgroupcustom"] = (object)DBNull.Value;
                this.gridViewGood.SelectRow(this.gridViewGood.FocusedRowHandle);
                dr_event[index] = dataRow;
                dataRow["_isdoublicate"] = (object)true;
                dataRow["_doublicateidparent"] = selectedDataRows[index]["idgood"];
            }
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Создание материала", dr_event, false);
            GC.Collect();
            GC.Collect();
        }

        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            if (!Grant.Goods.GoodEdit)
            {
                int num1 = (int)MessageBox.Show("У Вас нет прав на редактирование материала!", "Редактирование материала", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (this.db.quModifDataSet(this.ds) > 0)
                    this.SaveToBase();
                DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGood);
                if (dataRow == null)
                    return;
                if (Atechnology.ecad.Settings.isDealer && !(bool)dataRow["ismy"])
                {
                    int num2 = (int)MessageBox.Show("Нельзя редактировать материалы, поступающие от поставщика!");
                }
                else
                {
                    GoodEditForm goodEditForm = new GoodEditForm((int)dataRow["idgood"]);
                    goodEditForm.Text = "Материал - " + dataRow["marking"].ToString();
                    MdiManager.Add((Control)goodEditForm);
                    goodEditForm.dr_from_good = dataRow;
                    goodEditForm.Show();
                }
            }
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlGood);
            if (selectedDataRows.Length > 0)
            {
                foreach (DataRow dataRow in selectedDataRows)
                {
                    if (!Atechnology.ecad.Settings.isDealer || (bool)dataRow["ismy"])
                        dataRow.Delete();
                }
            }
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Удаление материала", selectedDataRows, true);
        }

        private void MenuItemHistoryPrice_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGood);
            if (dataRow == null)
                return;
            int num = (int)new PriceHistoryForm((int)dataRow["idgood"]).ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
        }

        private void MenuItemMoveInGroup_Click(object sender, EventArgs e)
        {
            this.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlGood);
            if (this.MoveItems == null || this.MoveItems.Length == 0)
            {
                this.MoveItems = (DataRow[])null;
            }
            else
            {
                this.treeList1.Focus();
                this.Cursor = Cursors.Hand;
            }
        }

        private void MenuItemCreateGoodForColor_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlGood);
            if (selectedDataRows.Length == 0)
                return;
            CreateGoodForColorForm goodForColorForm = new CreateGoodForColorForm(this.db);
            if (goodForColorForm.ShowDialog() == DialogResult.Cancel || !goodForColorForm.chkDoubleSideColor.Checked && !goodForColorForm.chkInSideColor.Checked && !goodForColorForm.chkOutSideColor.Checked)
                return;
            DataRow[] dataRowArray = goodForColorForm.table_colorgroup.Select("isactive = 1");
            if (dataRowArray.Length == 0)
                return;
            this.table_color.Clear();
            this.db.command.CommandText = "select idcolor, name \r\n\t\t\t\t\t\t\t\t\t\t\t\tfrom color \r\n\t\t\t\t\t\t\t\t\t\t\t\twhere deleted is null and \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\twindraw = 1 and \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tname like 'белый'";
            this.db.adapter.Fill(this.table_color);
            if (this.table_color.Rows.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Не найден белый цвет!\n Создание материалов остановлено.", "Ошибка обработки", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int num2 = (int)this.table_color.Rows[0]["idcolor"];
                string str1 = this.table_color.Rows[0]["name"].ToString();
                List<DataRow> list = new List<DataRow>();
                foreach (DataRow dataRow1 in dataRowArray)
                {
                    int num3 = -1;
                    if (goodForColorForm.chkCreateGoodGroup.Checked)
                    {
                        num3 = this.CreateChildGroup(dataRow1["name"].ToString());
                        if (num3 == -1)
                            continue;
                    }
                    this.table_color.Clear();
                    this.db.command.CommandText = "select idcolor, name \r\n\t\t\t\t\t\t\t\t\t\t\t\tfrom color \r\n\t\t\t\t\t\t\t\t\t\t\t\twhere deleted is null and \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\twindraw = 1 and \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tidcolor <> " + num2.ToString() + " and \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tidcolorgroup = " + dataRowArray[0]["idcolorgroup"].ToString();
                    this.db.adapter.Fill(this.table_color);
                    foreach (DataRow source in selectedDataRows)
                    {
                        if (num3 == -1)
                            num3 = (int)source["idgoodgroup"];
                        source["idcolor1"] = (object)num2;
                        source["idcolor2"] = (object)num2;
                        source["color1_name"] = (object)str1;
                        source["color2_name"] = (object)str1;
                        string str2 = source["marking"].ToString();
                        string str3 = source["idgoodtype"] == DBNull.Value ? "" : " and idgoodtype = " + source["idgoodtype"].ToString();
                        string str4 = source["idsystem"] == DBNull.Value ? "" : " and idsystem = " + source["idsystem"].ToString();
                        foreach (DataRow dataRow2 in (InternalDataCollectionBase)this.table_color.Rows)
                        {
                            if (goodForColorForm.chkDoubleSideColor.Checked)
                            {
                                if (this.table_good.Select("marking = '" + str2 + "'" + str3 + str4 + " and idcolor1 = " + dataRow2["idcolor"].ToString() + " and idcolor2 = " + dataRow2["idcolor"].ToString()).Length == 0)
                                {
                                    DataRow dataRow3 = AtDataSet.dublicate(source);
                                    dataRow3["idgood"] = (object)dbconn.GetGenId("gen_good");
                                    dataRow3["idcolor1"] = dataRow2["idcolor"];
                                    dataRow3["idcolor2"] = dataRow2["idcolor"];
                                    dataRow3["color1_name"] = dataRow2["name"];
                                    dataRow3["color2_name"] = dataRow2["name"];
                                    dataRow3["name"] = (object)(dataRow3["name"].ToString() + " " + dataRow2["name"].ToString() + " 2х-сторонний");
                                    dataRow3["idgoodgroup"] = (object)num3;
                                    list.Add(dataRow3);
                                }
                            }
                            if (goodForColorForm.chkInSideColor.Checked)
                            {
                                if (this.table_good.Select("marking = '" + str2 + "'" + str3 + str4 + " and idcolor1 = " + num2.ToString() + " and idcolor2 = " + dataRow2["idcolor"].ToString()).Length == 0)
                                {
                                    DataRow dataRow3 = AtDataSet.dublicate(source);
                                    dataRow3["idgood"] = (object)dbconn.GetGenId("gen_good");
                                    dataRow3["idcolor1"] = (object)num2;
                                    dataRow3["idcolor2"] = dataRow2["idcolor"];
                                    dataRow3["color1_name"] = (object)str1;
                                    dataRow3["color2_name"] = dataRow2["name"];
                                    dataRow3["name"] = (object)(dataRow3["name"].ToString() + " " + dataRow2["name"].ToString() + " внутренний");
                                    dataRow3["idgoodgroup"] = (object)num3;
                                    list.Add(dataRow3);
                                }
                            }
                            if (goodForColorForm.chkOutSideColor.Checked)
                            {
                                if (this.table_good.Select("marking = '" + str2 + "'" + str3 + str4 + " and idcolor1 = " + dataRow2["idcolor"].ToString() + " and idcolor2 = " + num2.ToString()).Length == 0)
                                {
                                    DataRow dataRow3 = AtDataSet.dublicate(source);
                                    list.Add(dataRow3);
                                    dataRow3["idgood"] = (object)dbconn.GetGenId("gen_good");
                                    dataRow3["idcolor1"] = dataRow2["idcolor"];
                                    dataRow3["idcolor2"] = (object)num2;
                                    dataRow3["color1_name"] = dataRow2["name"];
                                    dataRow3["color2_name"] = (object)str1;
                                    dataRow3["name"] = (object)(dataRow3["name"].ToString() + " " + dataRow2["name"].ToString() + " внешний");
                                    dataRow3["idgoodgroup"] = (object)num3;
                                }
                            }
                        }
                    }
                }
                new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Создание материала", list.ToArray(), false);
                GC.Collect();
                GC.Collect();
            }
        }

        private bool FindParentNode(int parentid)
        {
            bool flag = false;
            if (this.table_goodgroup.Select("idgoodgroup = " + parentid.ToString()).Length > 0)
                flag = true;
            return flag;
        }

        public void IsDialog()
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridViewGood.OptionsBehavior.Editable = false;
            this.isdialog = 1;
            this.gridControlGood.ContextMenuStrip = (ContextMenuStrip)null;
            this.gridViewGood.OptionsSelection.MultiSelect = false;
            this.gridViewGood.OptionsBehavior.AllowIncrementalSearch = true;
            this.treeList1.ContextMenuStrip = (ContextMenuStrip)null;
            this.gridViewGood.Columns.Remove(this.gridViewGood.Columns["price1"]);
            this.treeList1.Columns[1].VisibleIndex = -1;
            this.treeList1.Columns[2].VisibleIndex = -1;
            foreach (DataRow dataRow in this.table_goodgroup.Select("isvisible = 0"))
                dataRow.Delete();
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_goodgroup.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted && dataRow["parentid"] != DBNull.Value && !this.FindParentNode((int)dataRow["parentid"]))
                    dataRow.Delete();
            }
            this.table_goodgroup.AcceptChanges();
        }

        public void IsDialog(bool multiSelect)
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridViewGood.OptionsBehavior.Editable = false;
            this.isdialog = 1;
            this.gridControlGood.ContextMenuStrip = (ContextMenuStrip)null;
            this.treeList1.ContextMenuStrip = (ContextMenuStrip)null;
            this.gridViewGood.OptionsSelection.MultiSelect = multiSelect;
            this.gridViewGood.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewGood.Columns.Remove(this.gridViewGood.Columns["price1"]);
            this.treeList1.Columns[1].VisibleIndex = -1;
            this.treeList1.Columns[2].VisibleIndex = -1;
            foreach (DataRow dataRow in this.table_goodgroup.Select("isvisible = 0"))
                dataRow.Delete();
            this.table_goodgroup.AcceptChanges();
        }

        public void RepositionGood(int group, int good)
        {
            if (group == -1)
            {
                DataRow[] dataRowArray = this.table_good.Select("idgood = " + good.ToString());
                if (dataRowArray.Length > 0)
                    group = (int)dataRowArray[0]["idgoodgroup"];
            }
            this.gridControlGood.Focus();
            this.gridControlGood.FocusedView = (BaseView)this.gridViewGood;
            for (int index = 0; index < this.table_goodgroup.Rows.Count; ++index)
            {
                DataRow dataRow = this.table_goodgroup.Rows[index];
                if (dataRow["idgoodgroup"] != DBNull.Value && (int)dataRow["idgoodgroup"] == group)
                {
                    TreeListNode node = AtTreeList.FindNode(this.treeList1, (TreeListNode)null, "idgoodgroup", group);
                    if (node == null)
                        return;
                    if ((int)((DataRowView)this.treeList1.GetDataRecordByNode(node)).Row["idgoodgroup"] == group)
                    {
                        this.treeList1.FocusedNode = node;
                        break;
                    }
                    break;
                }
            }
            this.gridControlGood.DataMember = (string)null;
            this.SetDataMember();
            if (good == -1)
                return;
            for (int index = 0; index < this.table_good.Rows.Count; ++index)
            {
                DataRow dataRow = this.table_good.Rows[index];
                if (dataRow.RowState != DataRowState.Deleted && (int)dataRow["idgood"] == good)
                {
                    this.gridViewGood.FocusedRowHandle = this.gridViewGood.GetRowHandle(index);
                    this.gridViewGood.SelectRow(index);
                    break;
                }
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (InputBox.ShowDialog("Поиск материала по наименованию", "Введите наименование для поиска", "") != DialogResult.OK)
                return;
            this.gridViewGood.ClearColumnsFilter();
            this.gridViewGood.Columns["name"].FilterInfo = new ColumnFilterInfo("name = '" + InputBox.Value + "'", "");
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (InputBox.ShowDialog("Поиск материала по артикулу", "Введите артикул для поиска", "") != DialogResult.OK)
                return;
            this.gridViewGood.ClearColumnsFilter();
            this.gridViewGood.Columns["marking"].FilterInfo = new ColumnFilterInfo("marking = '" + InputBox.Value + "'", "");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip3.Show((Control)this.button7, 0, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip3.Show((Control)this.button6, 0, 0);
        }

        private int GetGroupNumpos()
        {
            DataRow[] dataRowArray = this.table_goodgroup.Select("", "numpos");
            int num = 0;
            if (dataRowArray.Length > 0)
            {
                DataRow dataRow = dataRowArray[dataRowArray.Length - 1];
                if (!dbconn.IsValueDbNullOrNull(dataRow["numpos"]))
                    num = (int)dataRow["numpos"] + 1;
            }
            return num;
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlGood);
            if (dataRow == null)
                return;
            this.treeList1.FocusedNode = this.treeList1.FindNodeByFieldValue("idgoodgroup", dataRow["idgoodgroup"]);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeList1) == null)
                return;
            List<DataRow> listNodesRows = AtTreeList.GetListNodesRows(this.treeList1, this.treeList1.FocusedNode);
            ProfileSystemChangeForm systemChangeForm = new ProfileSystemChangeForm(true);
            if (systemChangeForm.ShowDialog() != DialogResult.OK)
                return;
            string str;
            int num;
            if (systemChangeForm.comboBoxEdit1.SelectedItem is ProfileSystem)
            {
                ProfileSystem profileSystem = (ProfileSystem)systemChangeForm.comboBoxEdit1.SelectedItem;
                str = profileSystem.Name;
                num = profileSystem.idsystem;
            }
            else
            {
                FurnitureSystem furnitureSystem = (FurnitureSystem)systemChangeForm.comboBoxEdit1.SelectedItem;
                str = furnitureSystem.Name;
                num = furnitureSystem.Serial;
            }
            foreach (DataRow dataRow1 in listNodesRows)
            {
                foreach (DataRow dataRow2 in (InternalDataCollectionBase)this.table_good.Rows)
                {
                    if (dataRow2.RowState != DataRowState.Deleted && (int)dataRow2["idgoodgroup"] == (int)dataRow1["idgoodgroup"])
                    {
                        if (num == -1)
                        {
                            dataRow2["idsystem"] = (object)DBNull.Value;
                            dataRow2["system_name"] = (object)DBNull.Value;
                        }
                        else
                        {
                            dataRow2["idsystem"] = (object)num;
                            dataRow2["system_name"] = (object)str;
                        }
                    }
                }
            }
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeList1) == null)
                return;
            ValutForm valutForm = new ValutForm();
            valutForm.IsDialog();
            if (valutForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow1 = AtGrid.getDataRow((Control)valutForm.gridControl6);
            if (dataRow1 == null)
                return;
            foreach (DataRow dataRow2 in AtTreeList.GetListNodesRows(this.treeList1, this.treeList1.FocusedNode))
            {
                foreach (DataRow dataRow3 in this.ds.Tables["good"].Select("idgoodgroup = " + dataRow2["idgoodgroup"].ToString()))
                {
                    dataRow3["idvalut"] = dataRow1["idvalut"];
                    dataRow3["valut_shortname"] = dataRow1["shortname"];
                }
            }
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeList1) == null)
                return;
            GoodOptimForm goodOptimForm = new GoodOptimForm();
            goodOptimForm.IsDialog();
            if (goodOptimForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow1 = AtGrid.getDataRow((Control)goodOptimForm.gridControl1);
            if (dataRow1 == null)
                return;
            foreach (DataRow dataRow2 in AtTreeList.GetListNodesRows(this.treeList1, this.treeList1.FocusedNode))
            {
                foreach (DataRow dataRow3 in this.ds.Tables["good"].Select("idgoodgroup = " + dataRow2["idgoodgroup"].ToString()))
                {
                    dataRow3["idgoodoptim"] = dataRow1["idgoodoptim"];
                    dataRow3["goodoptim_name"] = dataRow1["name"];
                }
            }
        }

        private void MenuGroupSetGoodType_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeList1) == null)
                return;
            List<DataRow> listNodesRows = AtTreeList.GetListNodesRows(this.treeList1, this.treeList1.FocusedNode);
            GoodTypeForm goodTypeForm = new GoodTypeForm();
            goodTypeForm.IsDialog();
            if (goodTypeForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow1 = AtGrid.getDataRow((Control)goodTypeForm.gridControl1);
            if (dataRow1 == null)
                return;
            foreach (DataRow dataRow2 in listNodesRows)
            {
                foreach (DataRow dataRow3 in (InternalDataCollectionBase)this.table_good.Rows)
                {
                    if (dataRow3.RowState != DataRowState.Deleted && (int)dataRow3["idgoodgroup"] == (int)dataRow2["idgoodgroup"])
                    {
                        dataRow3["idgoodtype"] = dataRow1["idgoodtype"];
                        dataRow3["goodtype_name"] = dataRow1["name"];
                    }
                }
            }
        }

        private void MenuGroupSetGoodType2_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeList1) == null)
                return;
            List<DataRow> listNodesRows = AtTreeList.GetListNodesRows(this.treeList1, this.treeList1.FocusedNode);
            GoodTypeForm goodTypeForm = new GoodTypeForm();
            goodTypeForm.IsDialog();
            if (goodTypeForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow1 = AtGrid.getDataRow((Control)goodTypeForm.gridControl1);
            if (dataRow1 == null)
                return;
            foreach (DataRow dataRow2 in listNodesRows)
            {
                foreach (DataRow dataRow3 in (InternalDataCollectionBase)this.table_good.Rows)
                {
                    if (dataRow3.RowState != DataRowState.Deleted && (int)dataRow3["idgoodgroup"] == (int)dataRow2["idgoodgroup"])
                    {
                        dataRow3["idgoodtype2"] = dataRow1["idgoodtype"];
                        dataRow3["goodtype_name2"] = dataRow1["name"];
                    }
                }
            }
        }

        private void MenuGroupSetStoreDepart_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeList1) == null)
                return;
            List<DataRow> listNodesRows = AtTreeList.GetListNodesRows(this.treeList1, this.treeList1.FocusedNode);
            StoreDepartForm storeDepartForm = new StoreDepartForm();
            storeDepartForm.IsDialog();
            if (storeDepartForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow1 = AtGrid.getDataRow((Control)storeDepartForm.gridControl1);
            if (dataRow1 == null)
                return;
            foreach (DataRow dataRow2 in listNodesRows)
            {
                foreach (DataRow dataRow3 in (InternalDataCollectionBase)this.table_good.Rows)
                {
                    if (dataRow3.RowState != DataRowState.Deleted && (int)dataRow3["idgoodgroup"] == (int)dataRow2["idgoodgroup"])
                        dataRow3["idstoredepart"] = dataRow1["idstoredepart"];
                }
            }
        }

        private void cboValut1_EditValueChanged(object sender, EventArgs e)
        {
            this.dr = AtGrid.getDataRow((Control)this.gridControlGood);
            if (this.dr == null)
                return;
            this.dr["idvalut"] = (object)((Valut)((BaseEdit)sender).EditValue).idvalut;
            this.dr["valut_shortname"] = (object)((Valut)((BaseEdit)sender).EditValue).shortname;
        }

        private void cboValut2_EditValueChanged(object sender, EventArgs e)
        {
            this.dr = AtGrid.getDataRow((Control)this.gridControlGood);
            if (this.dr == null)
                return;
            this.dr["idvalut2"] = (object)((Valut)((BaseEdit)sender).EditValue).idvalut;
            this.dr["valut2_shortname"] = (object)((Valut)((BaseEdit)sender).EditValue).shortname;
        }

        private void cboValut3_EditValueChanged(object sender, EventArgs e)
        {
            this.dr = AtGrid.getDataRow((Control)this.gridControlGood);
            if (this.dr == null)
                return;
            this.dr["idvalut3"] = (object)((Valut)((BaseEdit)sender).EditValue).idvalut;
            this.dr["valut3_shortname"] = (object)((Valut)((BaseEdit)sender).EditValue).shortname;
        }

        private void cboValut4_EditValueChanged(object sender, EventArgs e)
        {
            this.dr = AtGrid.getDataRow((Control)this.gridControlGood);
            if (this.dr == null)
                return;
            this.dr["idvalut4"] = (object)((Valut)((BaseEdit)sender).EditValue).idvalut;
            this.dr["valut4_shortname"] = (object)((Valut)((BaseEdit)sender).EditValue).shortname;
        }

        private void cboValut5_EditValueChanged(object sender, EventArgs e)
        {
            this.dr = AtGrid.getDataRow((Control)this.gridControlGood);
            if (this.dr == null)
                return;
            this.dr["idvalut5"] = (object)((Valut)((BaseEdit)sender).EditValue).idvalut;
            this.dr["valut5_shortname"] = (object)((Valut)((BaseEdit)sender).EditValue).shortname;
        }

        private int CreateChildGroup(string Name)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null || selectedNode["idgoodgroup"] == DBNull.Value || Convert.ToInt32(selectedNode["idgoodgroup"]) == -1)
                return -1;
            DataRow row = this.table_goodgroup.NewRow();
            if (Name == "")
            {
                if (InputBox.ShowDialog("Создание дочерней группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                    return -1;
                Name = InputBox.Value;
            }
            row["idgoodgroup"] = (object)dbconn.GetGenId("gen_goodgroup");
            row["name"] = (object)Name;
            row["parentid"] = selectedNode["idgoodgroup"];
            row["isactive"] = (object)1;
            row["isvisible"] = (object)1;
            row["numpos"] = (object)this.GetGroupNumpos();
            this.table_goodgroup.Rows.Add(row);
            return (int)row["idgoodgroup"];
        }

        private void GoodChoice()
        {
            if (this.isdialog != 1)
                return;
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
            if (selectedNode == null || (int)selectedNode["imageindex"] == 4)
            {
                if (!(this.gridControlGood.DataMember != "good"))
                    return;
                this.gridControlGood.DataMember = "good";
            }
            else
            {
                if (!(this.gridControlGood.DataMember != "goodgroup.Relation_good"))
                    return;
                this.gridControlGood.DataMember = "goodgroup.Relation_good";
            }
        }

        private void MenuGroupSetOptimOutSettings_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNode(this.treeList1) == null)
                return;
            GoodOptimOutSettings optimOutSettings = new GoodOptimOutSettings();
            if (optimOutSettings.ShowDialog() != DialogResult.OK)
                return;
            foreach (DataRow dataRow1 in AtTreeList.GetListNodesRows(this.treeList1, this.treeList1.FocusedNode))
            {
                foreach (DataRow dataRow2 in this.ds.Tables["good"].Select("idgoodgroup = " + dataRow1["idgoodgroup"].ToString()))
                {
                    Decimal? waste1 = optimOutSettings.Waste1;
                    dataRow2["waste"] = !waste1.HasValue ? (object)DBNull.Value : (object)optimOutSettings.Waste1;
                    Decimal? waste2 = optimOutSettings.Waste2;
                    dataRow2["waste2"] = !waste2.HasValue ? (object)DBNull.Value : (object)optimOutSettings.Waste2;
                    Decimal? waste3 = optimOutSettings.Waste3;
                    dataRow2["waste3"] = !waste3.HasValue ? (object)DBNull.Value : (object)optimOutSettings.Waste3;
                    Decimal? waste4 = optimOutSettings.Waste4;
                    dataRow2["waste4"] = !waste4.HasValue ? (object)DBNull.Value : (object)optimOutSettings.Waste4;
                    Decimal? waste5 = optimOutSettings.Waste5;
                    dataRow2["waste5"] = !waste5.HasValue ? (object)DBNull.Value : (object)optimOutSettings.Waste5;
                }
            }
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GoodForm));
            this.panel1 = new Panel();
            this.button7 = new Button();
            this.contextMenuStrip3 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem12 = new ToolStripMenuItem();
            this.toolStripMenuItem13 = new ToolStripMenuItem();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.treeList1 = new TreeList();
            this.colname = new TreeListColumn();
            this.treeListColumn1 = new TreeListColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.treeListColumn2 = new TreeListColumn();
            this.repositoryItemCheckEdit2 = new RepositoryItemCheckEdit();
            this.treeListColumn3 = new TreeListColumn();
            this.MenuGroup = new ContextMenuStrip(this.components);
            this.MenuItemAddMainGroup = new ToolStripMenuItem();
            this.MenuItemAddChildGroup = new ToolStripMenuItem();
            this.MenuItemRenameGroup = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemRemoveGroup = new ToolStripMenuItem();
            this.toolStripSeparator9 = new ToolStripSeparator();
            this.MenuGroupMoveInGroup = new ToolStripMenuItem();
            this.MenuGroupSetMain = new ToolStripMenuItem();
            this.toolStripSeparator6 = new ToolStripSeparator();
            this.toolStripMenuItem14 = new ToolStripMenuItem();
            this.MenuGroupSetGoodType2 = new ToolStripMenuItem();
            this.toolStripMenuItem16 = new ToolStripMenuItem();
            this.toolStripMenuItem21 = new ToolStripMenuItem();
            this.toolStripMenuItem23 = new ToolStripMenuItem();
            this.toolStripMenuItem24 = new ToolStripMenuItem();
            this.MenuGroupSetStoreDepart = new ToolStripMenuItem();
            this.MenuGroupSetOptimOutSettings = new ToolStripMenuItem();
            this.toolStripMenuItem19 = new ToolStripMenuItem();
            this.toolStripSeparator7 = new ToolStripSeparator();
            this.toolStripMenuItem17 = new ToolStripMenuItem();
            this.toolStripMenuItem18 = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_goodgroup = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn16 = new DataColumn();
            this.dataColumn36 = new DataColumn();
            this.dataColumn37 = new DataColumn();
            this.dataColumn38 = new DataColumn();
            this.table_good = new DataTable();
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
            this.dataColumn35 = new DataColumn();
            this.dataColumn39 = new DataColumn();
            this.dataColumn40 = new DataColumn();
            this.dataColumn41 = new DataColumn();
            this.dataColumn42 = new DataColumn();
            this.dataColumn43 = new DataColumn();
            this.dataColumn44 = new DataColumn();
            this.dataColumn45 = new DataColumn();
            this.dataColumn46 = new DataColumn();
            this.dataColumn47 = new DataColumn();
            this.dataColumn48 = new DataColumn();
            this.dataColumn49 = new DataColumn();
            this.dataColumn50 = new DataColumn();
            this.dataColumn51 = new DataColumn();
            this.dataColumn52 = new DataColumn();
            this.dataColumn53 = new DataColumn();
            this.dataColumn54 = new DataColumn();
            this.dataColumn55 = new DataColumn();
            this.dataColumn56 = new DataColumn();
            this.dataColumn57 = new DataColumn();
            this.dataColumn61 = new DataColumn();
            this.dataColumn62 = new DataColumn();
            this.dataColumn65 = new DataColumn();
            this.dataColumn66 = new DataColumn();
            this.dataColumn67 = new DataColumn();
            this.dataColumn68 = new DataColumn();
            this.dataColumn69 = new DataColumn();
            this.dataColumn70 = new DataColumn();
            this.dataColumn71 = new DataColumn();
            this.dataColumn72 = new DataColumn();
            this.dataColumn73 = new DataColumn();
            this.dataColumn74 = new DataColumn();
            this.dataColumn75 = new DataColumn();
            this.dataColumn76 = new DataColumn();
            this.dataColumn77 = new DataColumn();
            this.table_color = new DataTable();
            this.dataColumn33 = new DataColumn();
            this.dataColumn34 = new DataColumn();
            this.table_measure = new DataTable();
            this.table_valut = new DataTable();
            this.dataColumn58 = new DataColumn();
            this.dataColumn59 = new DataColumn();
            this.dataColumn60 = new DataColumn();
            this.table_goodtype = new DataTable();
            this.dataColumn63 = new DataColumn();
            this.dataColumn64 = new DataColumn();
            this.imageList1 = new ImageList(this.components);
            this.splitter1 = new Splitter();
            this.gridControlGood = new GridControl();
            this.contextMenuStrip2 = new ContextMenuStrip(this.components);
            this.MenuItemAdd = new ToolStripMenuItem();
            this.MenuItemDoublicate = new ToolStripMenuItem();
            this.MenuItemEdit = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemHistoryPrice = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.MenuItemFromFile = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.MenuItemMoveInGroup = new ToolStripMenuItem();
            this.MenuItemGoToGroup = new ToolStripMenuItem();
            this.toolStripSeparator8 = new ToolStripSeparator();
            this.MenuItemCreateGoodForColor = new ToolStripMenuItem();
            this.MenuItemFindAndReplace = new ToolStripMenuItem();
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
            this.colprice1 = new GridColumn();
            this.txtWaste = new AtRepositoryItemTextEdit();
            this.colprice2 = new GridColumn();
            this.colvalut_shortname = new GridColumn();
            this.cboValut1 = new RepositoryItemComboBox();
            this.colvalut_shortname2 = new GridColumn();
            this.cboValut2 = new RepositoryItemComboBox();
            this.colwaste = new GridColumn();
            this.colwaste2 = new GridColumn();
            this.colwaste3 = new GridColumn();
            this.colwaste4 = new GridColumn();
            this.colwaste5 = new GridColumn();
            this.colcolor1_name = new GridColumn();
            this.colcolor2_name = new GridColumn();
            this.coltyp = new GridColumn();
            this.colgoodtype_name = new GridColumn();
            this.cboGoodType = new RepositoryItemComboBox();
            this.colgoodtype_name2 = new GridColumn();
            this.cboGoodType2 = new RepositoryItemComboBox();
            this.colgoodpricegroup_name = new GridColumn();
            this.colminost = new GridColumn();
            this.colgoodoptim_name = new GridColumn();
            this.colprice3 = new GridColumn();
            this.colprice4 = new GridColumn();
            this.colprice5 = new GridColumn();
            this.colvalut_shortname3 = new GridColumn();
            this.cboValut3 = new RepositoryItemComboBox();
            this.colvalut_shortname4 = new GridColumn();
            this.cboValut4 = new RepositoryItemComboBox();
            this.colvalut_shortname5 = new GridColumn();
            this.cboValut5 = new RepositoryItemComboBox();
            this.colpaking = new GridColumn();
            this.colcomment = new GridColumn();
            this.colextmarking = new GridColumn();
            this.colsqr = new GridColumn();
            this.colsqr2 = new GridColumn();
            this.gridColumn1 = new GridColumn();
            this.colcolorgroupcustom_name = new GridColumn();
            this.colcustomer_name = new GridColumn();
            this.panel2 = new Panel();
            this.button6 = new Button();
            this.CancelButton = new Button();
            this.DefaultButton = new Button();
            this.panel3 = new Panel();
            this.label1 = new Label();
            this.pictureBox1 = new PictureBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.treeList1.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.repositoryItemCheckEdit2.BeginInit();
            this.MenuGroup.SuspendLayout();
            this.ds.BeginInit();
            this.table_goodgroup.BeginInit();
            this.table_good.BeginInit();
            this.table_color.BeginInit();
            this.table_measure.BeginInit();
            this.table_valut.BeginInit();
            this.table_goodtype.BeginInit();
            this.gridControlGood.BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.gridViewGood.BeginInit();
            this.cboMeasure.BeginInit();
            this.txtWaste.BeginInit();
            this.cboValut1.BeginInit();
            this.cboValut2.BeginInit();
            this.cboGoodType.BeginInit();
            this.cboGoodType2.BeginInit();
            this.cboValut3.BeginInit();
            this.cboValut4.BeginInit();
            this.cboValut5.BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button7);
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(936, 33);
            this.panel1.TabIndex = 2;
            this.button7.ContextMenuStrip = this.contextMenuStrip3;
            this.button7.FlatStyle = FlatStyle.Flat;
            this.button7.Location = new Point(12, 5);
            this.button7.Name = "button7";
            this.button7.Size = new Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Найти...";
            this.button7.Visible = false;
            this.button7.Click += new EventHandler(this.button7_Click);
            this.contextMenuStrip3.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripMenuItem12,
        (ToolStripItem) this.toolStripMenuItem13
      });
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new Size(166, 48);
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new Size(165, 22);
            this.toolStripMenuItem12.Text = "По наименованию";
            this.toolStripMenuItem12.Click += new EventHandler(this.toolStripMenuItem12_Click);
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new Size(165, 22);
            this.toolStripMenuItem13.Text = "По артикулу";
            this.toolStripMenuItem13.Click += new EventHandler(this.toolStripMenuItem13_Click);
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(849, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(768, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(687, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
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
            this.treeList1.Columns.AddRange(new TreeListColumn[4]
      {
        this.colname,
        this.treeListColumn1,
        this.treeListColumn2,
        this.treeListColumn3
      });
            this.treeList1.ContextMenuStrip = this.MenuGroup;
            this.treeList1.DataMember = "goodgroup";
            this.treeList1.DataSource = (object)this.ds;
            this.treeList1.Dock = DockStyle.Left;
            this.treeList1.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeList1.ImageIndexFieldName = "imageindex";
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
            this.treeList1.Size = new Size(230, 468);
            this.treeList1.TabIndex = 1;
            this.colname.Caption = "Группа материалов";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 27;
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 196;
            this.treeListColumn1.Caption = "Активность";
            this.treeListColumn1.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit1;
            this.treeListColumn1.FieldName = "isactive";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 1;
            this.treeListColumn1.Width = 52;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.treeListColumn2.Caption = "Видимость";
            this.treeListColumn2.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit2;
            this.treeListColumn2.FieldName = "isvisible";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 2;
            this.treeListColumn2.Width = 50;
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.treeListColumn3.Caption = "treeListColumn3";
            this.treeListColumn3.FieldName = "numpos";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.SortOrder = SortOrder.Ascending;
            this.MenuGroup.Items.AddRange(new ToolStripItem[21]
      {
        (ToolStripItem) this.MenuItemAddMainGroup,
        (ToolStripItem) this.MenuItemAddChildGroup,
        (ToolStripItem) this.MenuItemRenameGroup,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemRemoveGroup,
        (ToolStripItem) this.toolStripSeparator9,
        (ToolStripItem) this.MenuGroupMoveInGroup,
        (ToolStripItem) this.MenuGroupSetMain,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.toolStripMenuItem14,
        (ToolStripItem) this.MenuGroupSetGoodType2,
        (ToolStripItem) this.toolStripMenuItem16,
        (ToolStripItem) this.toolStripMenuItem21,
        (ToolStripItem) this.toolStripMenuItem23,
        (ToolStripItem) this.toolStripMenuItem24,
        (ToolStripItem) this.MenuGroupSetStoreDepart,
        (ToolStripItem) this.MenuGroupSetOptimOutSettings,
        (ToolStripItem) this.toolStripMenuItem19,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.toolStripMenuItem17,
        (ToolStripItem) this.toolStripMenuItem18
      });
            this.MenuGroup.Name = "contextMenuStrip1";
            this.MenuGroup.Size = new Size(324, 402);
            this.MenuItemAddMainGroup.ImageTransparentColor = Color.Magenta;
            this.MenuItemAddMainGroup.Name = "MenuItemAddMainGroup";
            this.MenuItemAddMainGroup.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAddMainGroup.Size = new Size(323, 22);
            this.MenuItemAddMainGroup.Text = "Добавить основную группу";
            this.MenuItemAddMainGroup.Click += new EventHandler(this.MenuItemAddMainGroup_Click);
            this.MenuItemAddChildGroup.Name = "MenuItemAddChildGroup";
            this.MenuItemAddChildGroup.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuItemAddChildGroup.Size = new Size(323, 22);
            this.MenuItemAddChildGroup.Text = "Добавить дочернюю группу";
            this.MenuItemAddChildGroup.Click += new EventHandler(this.MenuItemAddChildGroup_Click);
            this.MenuItemRenameGroup.Name = "MenuItemRenameGroup";
            this.MenuItemRenameGroup.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuItemRenameGroup.Size = new Size(323, 22);
            this.MenuItemRenameGroup.Text = "Переименовать";
            this.MenuItemRenameGroup.Click += new EventHandler(this.MenuItemRenameGroup_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(320, 6);
            this.MenuItemRemoveGroup.Name = "MenuItemRemoveGroup";
            this.MenuItemRemoveGroup.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemoveGroup.Size = new Size(323, 22);
            this.MenuItemRemoveGroup.Text = "Удалить группу";
            this.MenuItemRemoveGroup.Click += new EventHandler(this.MenuItemRemoveGroup_Click);
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new Size(320, 6);
            this.MenuGroupMoveInGroup.Name = "MenuGroupMoveInGroup";
            this.MenuGroupMoveInGroup.ShortcutKeys = Keys.F6;
            this.MenuGroupMoveInGroup.Size = new Size(323, 22);
            this.MenuGroupMoveInGroup.Text = "Переместить в группу";
            this.MenuGroupMoveInGroup.Click += new EventHandler(this.toolStripMenuItem20_Click);
            this.MenuGroupSetMain.Name = "MenuGroupSetMain";
            this.MenuGroupSetMain.ShortcutKeys = Keys.M | Keys.Shift | Keys.Control;
            this.MenuGroupSetMain.Size = new Size(323, 22);
            this.MenuGroupSetMain.Text = "Сделать группу основной";
            this.MenuGroupSetMain.Click += new EventHandler(this.MenuItemGroupSetMain_Click);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new Size(320, 6);
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new Size(323, 22);
            this.toolStripMenuItem14.Text = "Установить тип для группы";
            this.toolStripMenuItem14.Click += new EventHandler(this.MenuGroupSetGoodType_Click);
            this.MenuGroupSetGoodType2.Name = "MenuGroupSetGoodType2";
            this.MenuGroupSetGoodType2.Size = new Size(323, 22);
            this.MenuGroupSetGoodType2.Text = "Устновить тип2 для всей группы";
            this.MenuGroupSetGoodType2.Click += new EventHandler(this.MenuGroupSetGoodType2_Click);
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new Size(323, 22);
            this.toolStripMenuItem16.Text = "Установить систему для группы";
            this.toolStripMenuItem16.Click += new EventHandler(this.toolStripMenuItem16_Click);
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new Size(323, 22);
            this.toolStripMenuItem21.Text = "Установить \"группу переоценки\" для группы";
            this.toolStripMenuItem21.Click += new EventHandler(this.toolStripMenuItem21_Click);
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new Size(323, 22);
            this.toolStripMenuItem23.Text = "Установить валюту для группы";
            this.toolStripMenuItem23.Click += new EventHandler(this.toolStripMenuItem23_Click);
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new Size(323, 22);
            this.toolStripMenuItem24.Text = "Установить \"группу оптимизации\" для группы";
            this.toolStripMenuItem24.Click += new EventHandler(this.toolStripMenuItem24_Click);
            this.MenuGroupSetStoreDepart.Name = "MenuGroupSetStoreDepart";
            this.MenuGroupSetStoreDepart.Size = new Size(323, 22);
            this.MenuGroupSetStoreDepart.Text = "Установить склад для группы";
            this.MenuGroupSetStoreDepart.Click += new EventHandler(this.MenuGroupSetStoreDepart_Click);
            this.MenuGroupSetOptimOutSettings.Name = "MenuGroupSetOptimOutSettings";
            this.MenuGroupSetOptimOutSettings.Size = new Size(323, 22);
            this.MenuGroupSetOptimOutSettings.Text = "Установить параметры оптимизации для группы";
            this.MenuGroupSetOptimOutSettings.Click += new EventHandler(this.MenuGroupSetOptimOutSettings_Click);
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new Size(323, 22);
            this.toolStripMenuItem19.Text = "Добавить параметр для группы";
            this.toolStripMenuItem19.Click += new EventHandler(this.toolStripMenuItem19_Click);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new Size(320, 6);
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.ShortcutKeys = Keys.Up | Keys.Control;
            this.toolStripMenuItem17.Size = new Size(323, 22);
            this.toolStripMenuItem17.Text = "Переместить вверх";
            this.toolStripMenuItem17.Click += new EventHandler(this.toolStripMenuItem17_Click);
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.ShortcutKeys = Keys.Down | Keys.Control;
            this.toolStripMenuItem18.Size = new Size(323, 22);
            this.toolStripMenuItem18.Text = "Переместить вниз";
            this.toolStripMenuItem18.Click += new EventHandler(this.toolStripMenuItem18_Click);
            this.ds.DataSetName = "ds_good";
            this.ds.EnforceConstraints = false;
            this.ds.Relations.AddRange(new DataRelation[2]
      {
        new DataRelation("Relation_goodgroup", "goodgroup", "goodgroup", new string[1]
        {
          "idgoodgroup"
        }, new string[1]
        {
          "parentid"
        }, 0 != 0),
        new DataRelation("Relation_good", "goodgroup", "good", new string[1]
        {
          "idgoodgroup"
        }, new string[1]
        {
          "idgoodgroup"
        }, 0 != 0)
      });
            this.ds.Tables.AddRange(new DataTable[6]
      {
        this.table_goodgroup,
        this.table_good,
        this.table_color,
        this.table_measure,
        this.table_valut,
        this.table_goodtype
      });
            this.table_goodgroup.Columns.AddRange(new DataColumn[8]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn16,
        this.dataColumn36,
        this.dataColumn37,
        this.dataColumn38
      });
            this.table_goodgroup.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodgroup"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("Relation_goodgroup", "goodgroup", new string[1]
        {
          "idgoodgroup"
        }, new string[1]
        {
          "parentid"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.None)
      });
            this.table_goodgroup.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_goodgroup.TableName = "goodgroup";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idgoodgroup";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "parentid";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn16.ColumnName = "imageindex";
            this.dataColumn16.DataType = typeof(int);
            this.dataColumn16.DefaultValue = (object)0;
            this.dataColumn16.Prefix = "local";
            this.dataColumn36.ColumnName = "isactive";
            this.dataColumn36.DataType = typeof(bool);
            this.dataColumn37.ColumnName = "isvisible";
            this.dataColumn37.DataType = typeof(bool);
            this.dataColumn38.ColumnName = "numpos";
            this.dataColumn38.DataType = typeof(int);
            this.table_good.Columns.AddRange(new DataColumn[62]
      {
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
        this.dataColumn35,
        this.dataColumn39,
        this.dataColumn40,
        this.dataColumn41,
        this.dataColumn42,
        this.dataColumn43,
        this.dataColumn44,
        this.dataColumn45,
        this.dataColumn46,
        this.dataColumn47,
        this.dataColumn48,
        this.dataColumn49,
        this.dataColumn50,
        this.dataColumn51,
        this.dataColumn52,
        this.dataColumn53,
        this.dataColumn54,
        this.dataColumn55,
        this.dataColumn56,
        this.dataColumn57,
        this.dataColumn61,
        this.dataColumn62,
        this.dataColumn65,
        this.dataColumn66,
        this.dataColumn67,
        this.dataColumn68,
        this.dataColumn69,
        this.dataColumn70,
        this.dataColumn71,
        this.dataColumn72,
        this.dataColumn73,
        this.dataColumn74,
        this.dataColumn75,
        this.dataColumn76,
        this.dataColumn77
      });
            this.table_good.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgood"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("Relation_good", "goodgroup", new string[1]
        {
          "idgoodgroup"
        }, new string[1]
        {
          "idgoodgroup"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_good.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn5
      };
            this.table_good.TableName = "good";
            this.dataColumn5.AllowDBNull = false;
            this.dataColumn5.ColumnName = "idgood";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "name";
            this.dataColumn7.ColumnName = "comment";
            this.dataColumn8.ColumnName = "idmeasure";
            this.dataColumn8.DataType = typeof(int);
            this.dataColumn9.ColumnName = "marking";
            this.dataColumn10.ColumnName = "typ";
            this.dataColumn10.DataType = typeof(int);
            this.dataColumn11.ColumnName = "extmarking";
            this.dataColumn12.ColumnName = "height";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.ColumnName = "width";
            this.dataColumn13.DataType = typeof(int);
            this.dataColumn14.ColumnName = "thick";
            this.dataColumn14.DataType = typeof(int);
            this.dataColumn15.ColumnName = "weight";
            this.dataColumn15.DataType = typeof(double);
            this.dataColumn17.ColumnName = "idgoodgroup";
            this.dataColumn17.DataType = typeof(int);
            this.dataColumn18.ColumnName = "measure_shortname";
            this.dataColumn18.Prefix = "local";
            this.dataColumn19.ColumnName = "goodgroup_name";
            this.dataColumn19.Prefix = "local";
            this.dataColumn20.ColumnName = "price1";
            this.dataColumn20.DataType = typeof(double);
            this.dataColumn21.ColumnName = "price2";
            this.dataColumn21.DataType = typeof(double);
            this.dataColumn22.ColumnName = "system_name";
            this.dataColumn22.Prefix = "local";
            this.dataColumn23.ColumnName = "waste";
            this.dataColumn23.DataType = typeof(double);
            this.dataColumn24.ColumnName = "measure_typ";
            this.dataColumn24.DataType = typeof(int);
            this.dataColumn25.ColumnName = "idvalut";
            this.dataColumn25.DataType = typeof(int);
            this.dataColumn26.ColumnName = "valut_shortname";
            this.dataColumn27.ColumnName = "idcolor1";
            this.dataColumn27.DataType = typeof(int);
            this.dataColumn28.ColumnName = "idcolor2";
            this.dataColumn28.DataType = typeof(int);
            this.dataColumn29.ColumnName = "color1_name";
            this.dataColumn30.ColumnName = "color2_name";
            this.dataColumn31.ColumnName = "idgoodtype";
            this.dataColumn31.DataType = typeof(int);
            this.dataColumn32.ColumnName = "goodtype_name";
            this.dataColumn35.ColumnName = "idsystem";
            this.dataColumn35.DataType = typeof(int);
            this.dataColumn39.ColumnName = "ismy";
            this.dataColumn39.DataType = typeof(bool);
            this.dataColumn40.ColumnName = "goodpricegroup_name";
            this.dataColumn41.ColumnName = "idgoodpricegroup";
            this.dataColumn41.DataType = typeof(int);
            this.dataColumn42.ColumnName = "minost";
            this.dataColumn42.DataType = typeof(double);
            this.dataColumn43.ColumnName = "idgoodoptim";
            this.dataColumn43.DataType = typeof(int);
            this.dataColumn44.ColumnName = "goodoptim_name";
            this.dataColumn45.ColumnName = "guid";
            this.dataColumn45.DataType = typeof(Guid);
            this.dataColumn46.Caption = "";
            this.dataColumn46.ColumnName = "price3";
            this.dataColumn46.DataType = typeof(double);
            this.dataColumn47.ColumnName = "price4";
            this.dataColumn47.DataType = typeof(double);
            this.dataColumn48.ColumnName = "price5";
            this.dataColumn48.DataType = typeof(double);
            this.dataColumn49.ColumnName = "packing";
            this.dataColumn49.DataType = typeof(double);
            this.dataColumn50.ColumnName = "idvalut2";
            this.dataColumn50.DataType = typeof(int);
            this.dataColumn51.ColumnName = "idvalut3";
            this.dataColumn51.DataType = typeof(int);
            this.dataColumn52.ColumnName = "idvalut4";
            this.dataColumn52.DataType = typeof(int);
            this.dataColumn53.ColumnName = "idvalut5";
            this.dataColumn53.DataType = typeof(int);
            this.dataColumn54.ColumnName = "valut2_shortname";
            this.dataColumn55.ColumnName = "valut3_shortname";
            this.dataColumn56.ColumnName = "valut4_shortname";
            this.dataColumn57.ColumnName = "valut5_shortname";
            this.dataColumn61.ColumnName = "idgoodtype2";
            this.dataColumn61.DataType = typeof(int);
            this.dataColumn62.ColumnName = "goodtype_name2";
            this.dataColumn65.ColumnName = "sqr2";
            this.dataColumn65.DataType = typeof(double);
            this.dataColumn66.ColumnName = "idstoredepart";
            this.dataColumn66.DataType = typeof(int);
            this.dataColumn67.ColumnName = "waste2";
            this.dataColumn67.DataType = typeof(double);
            this.dataColumn68.ColumnName = "waste3";
            this.dataColumn68.DataType = typeof(double);
            this.dataColumn69.ColumnName = "waste4";
            this.dataColumn69.DataType = typeof(double);
            this.dataColumn70.ColumnName = "waste5";
            this.dataColumn70.DataType = typeof(double);
            this.dataColumn71.ColumnName = "showinnopaper";
            this.dataColumn71.DataType = typeof(short);
            this.dataColumn72.ColumnName = "_isdoublicate";
            this.dataColumn72.DataType = typeof(bool);
            this.dataColumn72.DefaultValue = (object)false;
            this.dataColumn73.ColumnName = "_doublicateidparent";
            this.dataColumn73.DataType = typeof(int);
            this.dataColumn74.ColumnName = "idcolorgroupcustom";
            this.dataColumn74.DataType = typeof(int);
            this.dataColumn75.ColumnName = "colorgroupcustom_name";
            this.dataColumn76.ColumnName = "idcustomer";
            this.dataColumn76.DataType = typeof(int);
            this.dataColumn77.ColumnName = "customer_name";
            this.table_color.Columns.AddRange(new DataColumn[2]
      {
        this.dataColumn33,
        this.dataColumn34
      });
            this.table_color.TableName = "color";
            this.dataColumn33.ColumnName = "idcolor";
            this.dataColumn33.DataType = typeof(int);
            this.dataColumn34.ColumnName = "name";
            this.table_measure.TableName = "measure";
            this.table_valut.Columns.AddRange(new DataColumn[3]
      {
        this.dataColumn58,
        this.dataColumn59,
        this.dataColumn60
      });
            this.table_valut.TableName = "valut";
            this.dataColumn58.ColumnName = "idvalut";
            this.dataColumn58.DataType = typeof(int);
            this.dataColumn59.ColumnName = "name";
            this.dataColumn60.ColumnName = "shortname";
            this.table_goodtype.Columns.AddRange(new DataColumn[2]
      {
        this.dataColumn63,
        this.dataColumn64
      });
            this.table_goodtype.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodtype"
        }, 1 != 0)
      });
            this.table_goodtype.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn63
      };
            this.table_goodtype.TableName = "goodtype";
            this.dataColumn63.AllowDBNull = false;
            this.dataColumn63.ColumnName = "idgoodtype";
            this.dataColumn63.DataType = typeof(int);
            this.dataColumn64.ColumnName = "name";
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "SearchFolder.bmp");
            this.imageList1.Images.SetKeyName(2, "GoToParentFolder.bmp");
            this.imageList1.Images.SetKeyName(3, "SearchInFolder.bmp");
            this.imageList1.Images.SetKeyName(4, "Search.bmp");
            this.imageList1.Images.SetKeyName(5, "Folder2.ico");
            this.splitter1.Location = new Point(230, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 468);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            this.gridControlGood.ContextMenuStrip = this.contextMenuStrip2;
            this.gridControlGood.DataMember = "good";
            this.gridControlGood.DataSource = (object)this.ds;
            this.gridControlGood.Dock = DockStyle.Fill;
            this.gridControlGood.EmbeddedNavigator.Name = "";
            this.gridControlGood.Location = new Point(233, 0);
            this.gridControlGood.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlGood.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlGood.MainView = (BaseView)this.gridViewGood;
            this.gridControlGood.Name = "gridControlGood";
            this.gridControlGood.RepositoryItems.AddRange(new RepositoryItem[9]
      {
        (RepositoryItem) this.txtWaste,
        (RepositoryItem) this.cboMeasure,
        (RepositoryItem) this.cboValut1,
        (RepositoryItem) this.cboValut2,
        (RepositoryItem) this.cboValut3,
        (RepositoryItem) this.cboValut4,
        (RepositoryItem) this.cboValut5,
        (RepositoryItem) this.cboGoodType,
        (RepositoryItem) this.cboGoodType2
      });
            this.gridControlGood.Size = new Size(703, 405);
            this.gridControlGood.TabIndex = 0;
            this.gridControlGood.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewGood
      });
            this.contextMenuStrip2.Items.AddRange(new ToolStripItem[15]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.MenuItemDoublicate,
        (ToolStripItem) this.MenuItemEdit,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemHistoryPrice,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.MenuItemFromFile,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.MenuItemRemove,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.MenuItemMoveInGroup,
        (ToolStripItem) this.MenuItemGoToGroup,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.MenuItemCreateGoodForColor,
        (ToolStripItem) this.MenuItemFindAndReplace
      });
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new Size(299, 254);
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuItemAdd.Size = new Size(298, 22);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemAdd.Click += new EventHandler(this.MenuItemAdd_Click);
            this.MenuItemDoublicate.Name = "MenuItemDoublicate";
            this.MenuItemDoublicate.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.MenuItemDoublicate.Size = new Size(298, 22);
            this.MenuItemDoublicate.Text = "Дублировать";
            this.MenuItemDoublicate.Click += new EventHandler(this.MenuItemDoublicate_Click);
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuItemEdit.Size = new Size(298, 22);
            this.MenuItemEdit.Text = "Редактировать";
            this.MenuItemEdit.Click += new EventHandler(this.MenuItemEdit_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(295, 6);
            this.MenuItemHistoryPrice.Name = "MenuItemHistoryPrice";
            this.MenuItemHistoryPrice.Size = new Size(298, 22);
            this.MenuItemHistoryPrice.Text = "История цен...";
            this.MenuItemHistoryPrice.Click += new EventHandler(this.MenuItemHistoryPrice_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(295, 6);
            this.MenuItemFromFile.Name = "MenuItemFromFile";
            this.MenuItemFromFile.Size = new Size(298, 22);
            this.MenuItemFromFile.Text = "Импортировать из файла";
            this.MenuItemFromFile.Click += new EventHandler(this.toolStripMenuItem9_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(295, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(298, 22);
            this.MenuItemRemove.Text = "Удалить";
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(295, 6);
            this.MenuItemMoveInGroup.Name = "MenuItemMoveInGroup";
            this.MenuItemMoveInGroup.ShortcutKeys = Keys.F6;
            this.MenuItemMoveInGroup.Size = new Size(298, 22);
            this.MenuItemMoveInGroup.Text = "Переместить в группу...";
            this.MenuItemMoveInGroup.Click += new EventHandler(this.MenuItemMoveInGroup_Click);
            this.MenuItemGoToGroup.Name = "MenuItemGoToGroup";
            this.MenuItemGoToGroup.Size = new Size(298, 22);
            this.MenuItemGoToGroup.Text = "Перейти в группу";
            this.MenuItemGoToGroup.Click += new EventHandler(this.toolStripMenuItem22_Click);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new Size(295, 6);
            this.MenuItemCreateGoodForColor.Name = "MenuItemCreateGoodForColor";
            this.MenuItemCreateGoodForColor.Size = new Size(298, 22);
            this.MenuItemCreateGoodForColor.Text = "Создать материалы по цветам конструкций";
            this.MenuItemFindAndReplace.Name = "MenuItemFindAndReplace";
            this.MenuItemFindAndReplace.ShortcutKeys = Keys.H | Keys.Control;
            this.MenuItemFindAndReplace.Size = new Size(298, 22);
            this.MenuItemFindAndReplace.Text = "Поиск и замена в наименовании";
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
            this.gridViewGood.Columns.AddRange(new GridColumn[41]
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
        this.colprice1,
        this.colprice2,
        this.colvalut_shortname,
        this.colvalut_shortname2,
        this.colwaste,
        this.colwaste2,
        this.colwaste3,
        this.colwaste4,
        this.colwaste5,
        this.colcolor1_name,
        this.colcolor2_name,
        this.coltyp,
        this.colgoodtype_name,
        this.colgoodtype_name2,
        this.colgoodpricegroup_name,
        this.colminost,
        this.colgoodoptim_name,
        this.colprice3,
        this.colprice4,
        this.colprice5,
        this.colvalut_shortname3,
        this.colvalut_shortname4,
        this.colvalut_shortname5,
        this.colpaking,
        this.colcomment,
        this.colextmarking,
        this.colsqr,
        this.colsqr2,
        this.gridColumn1,
        this.colcolorgroupcustom_name,
        this.colcustomer_name
      });
            this.gridViewGood.GridControl = this.gridControlGood;
            this.gridViewGood.GroupPanelText = "Панель группировки";
            this.gridViewGood.Name = "gridViewGood";
            this.gridViewGood.OptionsCustomization.AllowFilter = false;
            this.gridViewGood.OptionsDetail.ShowDetailTabs = false;
            this.gridViewGood.OptionsLayout.StoreVisualOptions = false;
            this.gridViewGood.OptionsSelection.MultiSelect = true;
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
            this.colmeasure_shortname.Width = 32;
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
            this.colprice1.Caption = "Цена 1";
            this.colprice1.ColumnEdit = (RepositoryItem)this.txtWaste;
            this.colprice1.FieldName = "price1";
            this.colprice1.Name = "colprice1";
            this.colprice1.Visible = true;
            this.colprice1.VisibleIndex = 5;
            this.colprice1.Width = 20;
            this.txtWaste.AutoHeight = false;
            this.txtWaste.DisplayFormat.FormatString = "n2";
            this.txtWaste.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtWaste.EditFormat.FormatString = "n2";
            this.txtWaste.EditFormat.FormatType = FormatType.Numeric;
            this.txtWaste.Name = "txtWaste";
            this.colprice2.Caption = "Цена 2";
            this.colprice2.ColumnEdit = (RepositoryItem)this.txtWaste;
            this.colprice2.FieldName = "price2";
            this.colprice2.Name = "colprice2";
            this.colprice2.Visible = true;
            this.colprice2.VisibleIndex = 6;
            this.colprice2.Width = 20;
            this.colvalut_shortname.Caption = "Валюта цены 1";
            this.colvalut_shortname.ColumnEdit = (RepositoryItem)this.cboValut1;
            this.colvalut_shortname.FieldName = "valut_shortname";
            this.colvalut_shortname.Name = "colvalut_shortname";
            this.colvalut_shortname.Visible = true;
            this.colvalut_shortname.VisibleIndex = 7;
            this.colvalut_shortname.Width = 33;
            this.cboValut1.AutoHeight = false;
            this.cboValut1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut1.Name = "cboValut1";
            this.cboValut1.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colvalut_shortname2.Caption = "Валюта цены 2";
            this.colvalut_shortname2.ColumnEdit = (RepositoryItem)this.cboValut2;
            this.colvalut_shortname2.FieldName = "valut2_shortname";
            this.colvalut_shortname2.Name = "colvalut_shortname2";
            this.colvalut_shortname2.Visible = true;
            this.colvalut_shortname2.VisibleIndex = 8;
            this.colvalut_shortname2.Width = 40;
            this.cboValut2.AutoHeight = false;
            this.cboValut2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut2.Name = "cboValut2";
            this.cboValut2.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colwaste.Caption = "% отх.1";
            this.colwaste.ColumnEdit = (RepositoryItem)this.txtWaste;
            this.colwaste.FieldName = "waste";
            this.colwaste.Name = "colwaste";
            this.colwaste.Visible = true;
            this.colwaste.VisibleIndex = 9;
            this.colwaste.Width = 43;
            this.colwaste2.Caption = "% отх.2";
            this.colwaste2.ColumnEdit = (RepositoryItem)this.txtWaste;
            this.colwaste2.FieldName = "waste2";
            this.colwaste2.Name = "colwaste2";
            this.colwaste2.Visible = true;
            this.colwaste2.VisibleIndex = 10;
            this.colwaste3.Caption = "% отх.3";
            this.colwaste3.ColumnEdit = (RepositoryItem)this.txtWaste;
            this.colwaste3.FieldName = "waste3";
            this.colwaste3.Name = "colwaste3";
            this.colwaste3.Visible = true;
            this.colwaste3.VisibleIndex = 11;
            this.colwaste4.Caption = "% отх.4";
            this.colwaste4.ColumnEdit = (RepositoryItem)this.txtWaste;
            this.colwaste4.FieldName = "waste4";
            this.colwaste4.Name = "colwaste4";
            this.colwaste4.Visible = true;
            this.colwaste4.VisibleIndex = 12;
            this.colwaste5.Caption = "% отх.5";
            this.colwaste5.ColumnEdit = (RepositoryItem)this.txtWaste;
            this.colwaste5.FieldName = "waste5";
            this.colwaste5.Name = "colwaste5";
            this.colwaste5.Visible = true;
            this.colwaste5.VisibleIndex = 13;
            this.colcolor1_name.Caption = "Цвет1";
            this.colcolor1_name.FieldName = "color1_name";
            this.colcolor1_name.Name = "colcolor1_name";
            this.colcolor1_name.OptionsColumn.AllowEdit = false;
            this.colcolor1_name.Visible = true;
            this.colcolor1_name.VisibleIndex = 14;
            this.colcolor1_name.Width = 62;
            this.colcolor2_name.Caption = "Цвет2";
            this.colcolor2_name.FieldName = "color2_name";
            this.colcolor2_name.Name = "colcolor2_name";
            this.colcolor2_name.OptionsColumn.AllowEdit = false;
            this.colcolor2_name.Visible = true;
            this.colcolor2_name.VisibleIndex = 15;
            this.colcolor2_name.Width = 66;
            this.coltyp.Caption = "typ";
            this.coltyp.FieldName = "typ";
            this.coltyp.Name = "coltyp";
            this.colgoodtype_name.Caption = "Тип";
            this.colgoodtype_name.ColumnEdit = (RepositoryItem)this.cboGoodType;
            this.colgoodtype_name.FieldName = "goodtype_name";
            this.colgoodtype_name.Name = "colgoodtype_name";
            this.colgoodtype_name.OptionsColumn.AllowEdit = false;
            this.colgoodtype_name.OptionsColumn.ReadOnly = true;
            this.colgoodtype_name.Visible = true;
            this.colgoodtype_name.VisibleIndex = 18;
            this.colgoodtype_name.Width = 37;
            this.cboGoodType.ActionButtonIndex = 1;
            this.cboGoodType.AllowNullInput = DefaultBoolean.True;
            this.cboGoodType.AutoHeight = false;
            this.cboGoodType.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboGoodType.CaseSensitiveSearch = true;
            this.cboGoodType.Name = "cboGoodType";
            this.cboGoodType.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colgoodtype_name2.Caption = "Тип 2";
            this.colgoodtype_name2.ColumnEdit = (RepositoryItem)this.cboGoodType2;
            this.colgoodtype_name2.FieldName = "goodtype_name2";
            this.colgoodtype_name2.Name = "colgoodtype_name2";
            this.colgoodtype_name2.Visible = true;
            this.colgoodtype_name2.VisibleIndex = 20;
            this.colgoodtype_name2.Width = 37;
            this.cboGoodType2.ActionButtonIndex = 1;
            this.cboGoodType2.AllowNullInput = DefaultBoolean.True;
            this.cboGoodType2.AutoHeight = false;
            this.cboGoodType2.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboGoodType2.CaseSensitiveSearch = true;
            this.cboGoodType2.Name = "cboGoodType2";
            this.cboGoodType2.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colgoodpricegroup_name.Caption = "Группа переоценки";
            this.colgoodpricegroup_name.FieldName = "goodpricegroup_name";
            this.colgoodpricegroup_name.Name = "colgoodpricegroup_name";
            this.colgoodpricegroup_name.OptionsColumn.AllowEdit = false;
            this.colgoodpricegroup_name.Visible = true;
            this.colgoodpricegroup_name.VisibleIndex = 16;
            this.colminost.Caption = "Мин.остаток";
            this.colminost.FieldName = "minost";
            this.colminost.Name = "colminost";
            this.colgoodoptim_name.Caption = "Группа оптимизации";
            this.colgoodoptim_name.FieldName = "goodoptim_name";
            this.colgoodoptim_name.Name = "colgoodoptim_name";
            this.colgoodoptim_name.Visible = true;
            this.colgoodoptim_name.VisibleIndex = 17;
            this.colprice3.Caption = "Цена 3";
            this.colprice3.FieldName = "price3";
            this.colprice3.Name = "colprice3";
            this.colprice4.Caption = "Цена 4";
            this.colprice4.FieldName = "price4";
            this.colprice4.Name = "colprice4";
            this.colprice5.Caption = "Цена 5";
            this.colprice5.FieldName = "price5";
            this.colprice5.Name = "colprice5";
            this.colvalut_shortname3.Caption = "Валюта цены 3";
            this.colvalut_shortname3.ColumnEdit = (RepositoryItem)this.cboValut3;
            this.colvalut_shortname3.FieldName = "valut3_shortname";
            this.colvalut_shortname3.Name = "colvalut_shortname3";
            this.cboValut3.AutoHeight = false;
            this.cboValut3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut3.Name = "cboValut3";
            this.cboValut3.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colvalut_shortname4.Caption = "Валюта цены 4";
            this.colvalut_shortname4.ColumnEdit = (RepositoryItem)this.cboValut4;
            this.colvalut_shortname4.FieldName = "valut4_shortname";
            this.colvalut_shortname4.Name = "colvalut_shortname4";
            this.cboValut4.AutoHeight = false;
            this.cboValut4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut4.Name = "cboValut4";
            this.cboValut4.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colvalut_shortname5.Caption = "Валюта цены 5";
            this.colvalut_shortname5.ColumnEdit = (RepositoryItem)this.cboValut5;
            this.colvalut_shortname5.FieldName = "valut5_shortname";
            this.colvalut_shortname5.Name = "colvalut_shortname5";
            this.cboValut5.AutoHeight = false;
            this.cboValut5.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut5.Name = "cboValut5";
            this.cboValut5.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colpaking.Caption = "Норма упаковки";
            this.colpaking.FieldName = "packing";
            this.colpaking.Name = "colpaking";
            this.colpaking.Visible = true;
            this.colpaking.VisibleIndex = 19;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Width = 77;
            this.colextmarking.Caption = "Вн.код";
            this.colextmarking.FieldName = "extmarking";
            this.colextmarking.Name = "colextmarking";
            this.colextmarking.Width = 45;
            this.colsqr.Caption = "Площадь";
            this.colsqr.DisplayFormat.FormatString = "N3";
            this.colsqr.DisplayFormat.FormatType = FormatType.Numeric;
            this.colsqr.FieldName = "sqr";
            this.colsqr.GroupFormat.FormatString = "N3";
            this.colsqr.GroupFormat.FormatType = FormatType.Numeric;
            this.colsqr.Name = "colsqr";
            this.colsqr.Visible = true;
            this.colsqr.VisibleIndex = 21;
            this.colsqr2.Caption = "Площадь";
            this.colsqr2.DisplayFormat.FormatString = "N3";
            this.colsqr2.DisplayFormat.FormatType = FormatType.Numeric;
            this.colsqr2.FieldName = "sqr2";
            this.colsqr2.GroupFormat.FormatString = "N3";
            this.colsqr2.GroupFormat.FormatType = FormatType.Numeric;
            this.colsqr2.Name = "colsqr2";
            this.colsqr2.Visible = true;
            this.colsqr2.VisibleIndex = 22;
            this.gridColumn1.Caption = "На фурнитурный стол";
            this.gridColumn1.FieldName = "showinnopaper";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 23;
            this.colcolorgroupcustom_name.Caption = "Цветовая группа";
            this.colcolorgroupcustom_name.FieldName = "colorgroupcustom_name";
            this.colcolorgroupcustom_name.Name = "colcolorgroupcustom_name";
            this.colcolorgroupcustom_name.OptionsColumn.AllowEdit = false;
            this.colcolorgroupcustom_name.Visible = true;
            this.colcolorgroupcustom_name.VisibleIndex = 24;
            this.colcustomer_name.Caption = "Поставщик";
            this.colcustomer_name.FieldName = "customer_name";
            this.colcustomer_name.Name = "colcustomer_name";
            this.colcustomer_name.OptionsColumn.AllowEdit = false;
            this.colcustomer_name.Visible = true;
            this.colcustomer_name.VisibleIndex = 25;
            this.panel2.Controls.Add((Control)this.button6);
            this.panel2.Controls.Add((Control)this.CancelButton);
            this.panel2.Controls.Add((Control)this.DefaultButton);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(936, 33);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            this.button6.FlatStyle = FlatStyle.Flat;
            this.button6.Location = new Point(12, 5);
            this.button6.Name = "button6";
            this.button6.Size = new Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Найти...";
            this.button6.Visible = false;
            this.button6.Click += new EventHandler(this.button6_Click);
            this.CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.CancelButton.DialogResult = DialogResult.Cancel;
            this.CancelButton.FlatStyle = FlatStyle.Flat;
            this.CancelButton.Location = new Point(849, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отменить";
            this.DefaultButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.DefaultButton.DialogResult = DialogResult.OK;
            this.DefaultButton.FlatStyle = FlatStyle.Flat;
            this.DefaultButton.Location = new Point(768, 5);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new Size(75, 23);
            this.DefaultButton.TabIndex = 1;
            this.DefaultButton.Text = "Выбрать";
            this.panel3.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.panel3.Controls.Add((Control)this.label1);
            this.panel3.Controls.Add((Control)this.pictureBox1);
            this.panel3.Dock = DockStyle.Bottom;
            this.panel3.Location = new Point(233, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(703, 63);
            this.panel3.TabIndex = 9;
            this.label1.Location = new Point(29, 6);
            this.label1.Name = "label1";
            this.label1.Size = new Size(551, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Здесь создаются группы материалов и сами материалы.\r\nВсе свойства и характеристики материалов доступны для редактирования в интерефейсе материала.\r\n\r\nВоспользуйтесь контекстными меню...";
            this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(16, 16);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlGood);
            this.Controls.Add((Control)this.panel3);
            this.Controls.Add((Control)this.splitter1);
            this.Controls.Add((Control)this.treeList1);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "GoodForm";
            this.Size = new Size(936, 534);
            this.Text = "Материалы";
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.treeList1.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.repositoryItemCheckEdit2.EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.ds.EndInit();
            this.table_goodgroup.EndInit();
            this.table_good.EndInit();
            this.table_color.EndInit();
            this.table_measure.EndInit();
            this.table_valut.EndInit();
            this.table_goodtype.EndInit();
            this.gridControlGood.EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.gridViewGood.EndInit();
            this.cboMeasure.EndInit();
            this.txtWaste.EndInit();
            this.cboValut1.EndInit();
            this.cboValut2.EndInit();
            this.cboGoodType.EndInit();
            this.cboGoodType2.EndInit();
            this.cboValut3.EndInit();
            this.cboValut4.EndInit();
            this.cboValut5.EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
        }
    }
}
