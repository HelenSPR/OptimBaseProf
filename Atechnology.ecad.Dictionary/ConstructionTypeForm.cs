// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ConstructionTypeForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad;
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class ConstructionTypeForm : AtUserControl
    {
        public int idversion;
        public bool saving;
        private bool HideNotActive;
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private SplitterControl splitterControl1;
        private TreeList treeList1;
        private TreeListColumn colname;
        private GridColumn colb;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn colidsystem;
        private GridColumn colidversion;
        private GridColumn colidmodelpart;
        private GridColumn colname1;
        private GridColumn colcomment;
        private GridColumn cola;
        private GridColumn gridColumn1;
        private GridColumn colc;
        private GridColumn cold;
        private GridColumn cole;
        private ImageList imageList1;
        private DataColumn dataColumn36;
        private DataTable table_constructiontype;
        private DataColumn dataColumn37;
        private DataColumn dataColumn38;
        private DataColumn dataColumn39;
        private DataColumn dataColumn35;
        private DataColumn dataColumn31;
        private DataColumn dataColumn30;
        private DataColumn dataColumn29;
        private DataColumn dataColumn28;
        private DataColumn dataColumn27;
        private DataColumn dataColumn26;
        private DataColumn dataColumn25;
        private DataColumn dataColumn24;
        private DataColumn dataColumn23;
        private DataColumn dataColumn22;
        private DataColumn dataColumn21;
        private DataColumn dataColumn20;
        private DataColumn dataColumn19;
        private DataColumn dataColumn18;
        private DataColumn dataColumn17;
        private DataColumn dataColumn16;
        private DataColumn dataColumn15;
        private DataColumn dataColumn14;
        private DataColumn dataColumn13;
        private DataColumn dataColumn12;
        private DataTable table_systemdetail;
        private DataColumn dataColumn11;
        private DataColumn dataColumn10;
        private DataColumn dataColumn9;
        private DataColumn dataColumn8;
        private DataColumn dataColumn7;
        private DataColumn dataColumn6;
        private DataColumn dataColumn5;
        private DataTable table_modelpart;
        private DataColumn dataColumn4;
        private DataColumn dataColumn3;
        private DataColumn dataColumn2;
        private DataColumn dataColumn1;
        private DataTable table_system;
        private DataSet ds;
        private DataTable table_constructiontypedetail;
        private DataColumn dataColumn40;
        private DataColumn dataColumn41;
        private DataColumn dataColumn42;
        private DataColumn dataColumn43;
        private DataColumn dataColumn44;
        private DataColumn dataColumn45;
        private DataColumn dataColumn46;
        private DataColumn dataColumn47;
        private DataColumn dataColumn48;
        private GridColumn colnumpos2;
        private GridColumn col_s;
        private GridColumn colsystemdetailgroup;
        private GridColumn colg;
        private DataTable table_tree;
        private DataColumn dataColumn32;
        private DataColumn dataColumn33;
        private DataColumn dataColumn34;
        private DataColumn dataColumn49;
        private DataColumn dataColumn50;
        private DataColumn dataColumn51;
        private DataColumn dataColumn52;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem MenuGroupAdd;
        private ToolStripMenuItem MenuGroupRemove;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuGroupRename;
        private GridColumn colidsystemdetail;
        private DataColumn dataColumn53;
        private DataColumn dataColumn54;
        private TreeListColumn treeListColumn1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuGroupMoveUp;
        private ToolStripMenuItem MenuGroupMoveDown;
        private TreeListColumn treeListColumn2;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DataColumn dataColumn55;
        private DataColumn dataColumn56;
        private Button cmdHideNotActive;
        private DataColumn dataColumn57;
        private GridColumn colalsoimpost;
        private DataColumn dataColumn58;

        public ConstructionTypeForm()
        {
            this.InitializeComponent();
            this.idversion = Settings.Base.DefaultVersionConstruction;
            this.LoadFromBase();
            this.GetTree();
            this.treeList1.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.KeyDown += new KeyEventHandler(this.treeList1_KeyDown);
            this.treeList1.MoveLastVisible();
            this.treeList1.MoveFirst();
            this.FormClosing += new FormClosing(this.ConstructionTypeForm_FormClosing);
            this.gridView1.KeyDown += new KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.RowUpdated += new RowObjectEventHandler(this.gridView1_RowUpdated);
            this.cmdHideNotActive.Click += new EventHandler(this.cmdHideNotActive_Click);
            this.Shown += new Shown(this.ConstructionTypeForm_Shown);
        }

        private void ConstructionTypeForm_Shown(object sender, EventArgs e)
        {
            if (this.treeList1.SortedColumnCount == 0)
                this.treeList1.Columns[1].SortOrder = SortOrder.Ascending;
            this.treeList1_FocusedNodeChanged((object)null, (FocusedNodeChangedEventArgs)null);
        }

        private void cmdHideNotActive_Click(object sender, EventArgs e)
        {
            this.HideNotActive = !this.HideNotActive;
            this.treeList1.FilterConditions.Clear();
            if (this.HideNotActive)
            {
                this.cmdHideNotActive.Text = "Показать неактивные";
                this.treeList1.FilterConditions.Add(new FilterCondition(FilterConditionEnum.Equals, this.treeList1.Columns["isactive"], (object)true));
                this.treeList1.Refresh();
            }
            else
                this.cmdHideNotActive.Text = "Скрыть неактивные";
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void ConstructionTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataTable(this.table_constructiontype) <= 0 && this.db.quModifDataTable(this.table_constructiontypedetail) <= 0)
                return;
            switch (MessageBox.Show("Сохранить изменения?", "Закрытие формы типов конструкций", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.OK:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            TreeList_KeyDown.Key(this.treeList1, e.KeyCode);
            if (e.KeyCode != Keys.Space)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode["parentid"] != DBNull.Value)
                return;
            selectedNode["isactive"] = (object)(bool)(!(bool)selectedNode["isactive"] ? true : false);
            this.table_constructiontype.Select("idconstructiontype = " + selectedNode["idconstructiontype"].ToString())[0]["isactive"] = selectedNode["isactive"];
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.saving)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null)
                return;
            if (selectedNode["parentid"] == DBNull.Value)
            {
                this.gridView1.Columns["idsystemdetail"].FilterInfo = new ColumnFilterInfo("[idsystemdetail] is null", "");
            }
            else
            {
                this.gridView1.Columns["idsystemdetail"].FilterInfo = new ColumnFilterInfo();
                DataRow dataRow = (DataRow)null;
                if (e.OldNode != null)
                    dataRow = ((DataRowView)this.treeList1.GetDataRecordByNode(e.OldNode)).Row;
                if (selectedNode["idsystem"] != DBNull.Value)
                {
                    this.gridView1.Columns["idsystem"].FilterInfo = new ColumnFilterInfo("[idsystem]=" + selectedNode["idsystem"].ToString(), "");
                    this.gridView1.Columns["idmodelpart"].FilterInfo = new ColumnFilterInfo(" [idmodelpart] is null", "");
                }
                if (selectedNode["idmodelpart"] == DBNull.Value)
                    return;
                this.gridView1.Columns["idmodelpart"].FilterInfo = new ColumnFilterInfo(" [idmodelpart]=" + selectedNode["idmodelpart"].ToString(), "");
                if (dataRow != null && dataRow["idmodelpart"] != DBNull.Value)
                    this.SaveConstructionTypeDetail((int)dataRow["idconstructiontype"], (int)dataRow["idmodelpart"]);
                this.GetSystemDetail((int)selectedNode["idconstructiontype"]);
            }
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from system where deleted is null and name <> 'Заполнения'\r\n\t\t\t\t\t\t\t\t\t\tand name not like 'Фурнитура%' and idversion = " + (object)this.idversion + " order by numpos";
            this.db.adapter.Fill(this.table_system);
            this.db.command.CommandText = "select * from systemdetail where deleted is null and idversion =" + (object)this.idversion;
            this.db.adapter.Fill(this.table_systemdetail);
            this.db.command.CommandText = "select * from modelpart where deleted is null and typ=0 and idversion = " + (object)this.idversion;
            this.db.adapter.Fill(this.table_modelpart);
            this.db.command.CommandText = "select * from constructiontype where deleted is null  and idversion = " + (object)this.idversion;
            this.db.adapter.Fill(this.table_constructiontype);
            this.db.command.CommandText = "select \r\n                idconstructiontypedetail,\r\n                idversion,\r\n                idconstructiontype,\r\n                idsystem,\r\n                idsystemdetail,\r\n                numpos,\r\n                idmodelpart,\r\n                deleted,\r\n                [guid],\r\n                isnull(alsoimpost,0) as alsoimpost\r\n            from constructiontypedetail where deleted is null and idversion = " + (object)this.idversion;
            this.db.adapter.Fill(this.table_constructiontypedetail);
        }

        public override bool SaveToBase()
        {
            using (new ThreadingStatusImageForm("Сохранение данных....", "Пожалуйста, подождите"))
            {
                this.saving = true;
                foreach (DataRow dataRow in this.table_tree.Select("numpos is not null"))
                    this.table_constructiontype.Select("idconstructiontype = " + dataRow["idconstructiontype"].ToString())[0]["numpos"] = dataRow["numpos"];
                if (!this.db.SaveDatatable2(this.table_constructiontype))
                    return false;
                DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
                if (selectedNode != null && selectedNode["idmodelpart"] != DBNull.Value)
                    this.SaveConstructionTypeDetail((int)selectedNode["idconstructiontype"], (int)selectedNode["idmodelpart"]);
                if (!this.db.SaveDatatable2(this.table_constructiontypedetail))
                    return false;
                this.ds.AcceptChanges();
                this.saving = false;
            }
            return true;
        }

        private void GetTree()
        {
            this.treeList1.DataMember = (string)null;
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_constructiontype.Rows)
            {
                DataRow row = this.table_tree.NewRow();
                row["id"] = (object)(this.table_tree.Rows.Count + 1);
                row["imageindex"] = (object)0;
                row["name"] = dataRow["name"];
                row["idconstructiontype"] = dataRow["idconstructiontype"];
                row["isactive"] = dataRow["isactive"];
                row["numpos"] = dataRow["numpos"];
                this.table_tree.Rows.Add(row);
                this.GetChildNodes((int)row["id"], (int)dataRow["idconstructiontype"]);
            }
            this.ds.AcceptChanges();
            this.treeList1.DataMember = "tree";
        }

        private void GetChildNodes(int id, int idconstructiontype)
        {
            foreach (DataRow dataRow1 in (InternalDataCollectionBase)this.table_system.Rows)
            {
                int num = this.table_tree.Rows.Count + 1;
                DataRow row1 = this.table_tree.NewRow();
                row1["id"] = (object)num;
                row1["parentid"] = (object)id;
                row1["imageindex"] = (object)1;
                row1["name"] = dataRow1["name"];
                row1["idsystem"] = dataRow1["idsystem"];
                row1["idconstructiontype"] = (object)idconstructiontype;
                this.table_tree.Rows.Add(row1);
                foreach (DataRow dataRow2 in (InternalDataCollectionBase)this.table_modelpart.Rows)
                {
                    DataRow row2 = this.table_tree.NewRow();
                    row2["id"] = (object)(this.table_tree.Rows.Count + 1);
                    row2["parentid"] = (object)num;
                    row2["imageindex"] = (object)2;
                    row2["name"] = dataRow2["name"];
                    row2["idmodelpart"] = dataRow2["idmodelpart"];
                    row2["idsystem"] = dataRow1["idsystem"];
                    row2["idconstructiontype"] = (object)idconstructiontype;
                    this.table_tree.Rows.Add(row2);
                }
            }
        }

        private void GetSystemDetail(int idconstructiontype)
        {
            foreach (DataRow dataRow1 in (InternalDataCollectionBase)this.table_systemdetail.Rows)
            {
                dataRow1["s"] = (object)0;
                DataTable dataTable = this.table_constructiontypedetail;
                string filterExpression = string.Concat(new object[4]
        {
          (object) "idconstructiontype = ",
          (object) idconstructiontype,
          (object) " and idsystemdetail = ",
          (object) dataRow1["idsystemdetail"].ToString()
        });
                foreach (DataRow dataRow2 in dataTable.Select(filterExpression))
                {
                    dataRow1["numpos2"] = dataRow2["numpos"];
                    dataRow1["alsoimpost"] = dataRow2["alsoimpost"];
                    dataRow1["s"] = (object)1;
                }
            }
        }

        private void SaveConstructionTypeDetail(int idconstructiontype, int idmodelpart)
        {
            foreach (DataRow dataRow1 in (InternalDataCollectionBase)this.table_systemdetail.Rows)
            {
                if (dataRow1["s"] == DBNull.Value || !(bool)dataRow1["s"])
                {
                    foreach (DataRow dataRow2 in (InternalDataCollectionBase)this.table_constructiontypedetail.Rows)
                    {
                        if (dataRow2.RowState != DataRowState.Deleted && (int)dataRow1["idsystemdetail"] == (int)dataRow2["idsystemdetail"] && ((int)dataRow2["idconstructiontype"] == idconstructiontype && (int)dataRow2["idmodelpart"] == idmodelpart))
                        {
                            dataRow2.Delete();
                            break;
                        }
                    }
                }
                else
                {
                    bool flag = false;
                    foreach (DataRow dataRow2 in (InternalDataCollectionBase)this.table_constructiontypedetail.Rows)
                    {
                        if (dataRow2.RowState != DataRowState.Deleted && (int)dataRow1["idsystemdetail"] == (int)dataRow2["idsystemdetail"] && (int)dataRow2["idconstructiontype"] == idconstructiontype)
                        {
                            flag = true;
                            dataRow2["numpos"] = dataRow1["numpos2"];
                            dataRow2["alsoimpost"] = dataRow1["alsoimpost"];
                            break;
                        }
                    }
                    if (!flag)
                    {
                        DataRow row = this.table_constructiontypedetail.NewRow();
                        this.table_constructiontypedetail.Rows.Add(row);
                        row["idconstructiontypedetail"] = (object)dbconn.GetGenId("gen_constructiontypedetail");
                        row["idversion"] = (object)this.idversion;
                        row["idconstructiontype"] = (object)idconstructiontype;
                        row["idsystem"] = dataRow1["idsystem"];
                        row["idsystemdetail"] = dataRow1["idsystemdetail"];
                        row["idmodelpart"] = dataRow1["idmodelpart"];
                        row["numpos"] = dataRow1["numpos2"];
                        row["alsoimpost"] = dataRow1["alsoimpost"];
                    }
                }
            }
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
            this.GetTree();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuGroupAdd_Click(object sender, EventArgs e)
        {
            if (InputBox.ShowDialog("Ввод имени типы конструкций", "Введите имя типа", "Новый тип конструкции") != DialogResult.OK)
                return;
            DataRow row1 = this.table_constructiontype.NewRow();
            this.table_constructiontype.Rows.Add(row1);
            row1["idconstructiontype"] = (object)dbconn.GetGenId("gen_constructiontype");
            row1["name"] = (object)InputBox.Value;
            row1["idversion"] = (object)this.idversion;
            row1["numpos"] = (object)this.table_constructiontype.Rows.Count;
            row1["isactive"] = (object)1;
            int id = this.table_tree.Rows.Count + 1;
            DataRow row2 = this.table_tree.NewRow();
            this.table_tree.Rows.Add(row2);
            row2["id"] = (object)id;
            row2["name"] = row1["name"];
            row2["imageindex"] = (object)0;
            row2["idconstructiontype"] = row1["idconstructiontype"];
            row2["numpos"] = row1["numpos"];
            row2["isactive"] = (object)1;
            this.GetChildNodes(id, (int)row1["idconstructiontype"]);
        }

        private void MenuGroupRemove_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null || (int)selectedNode["imageindex"] != 0)
                return;
            this.treeList1.DataMember = "";
            int num1 = (int)selectedNode["idconstructiontype"];
            foreach (DataRow dataRow in this.table_tree.Select("idconstructiontype = " + num1.ToString()))
                dataRow.Delete();
            foreach (DataRow dataRow in this.table_constructiontypedetail.Select("idconstructiontype = " + num1.ToString()))
                dataRow.Delete();
            foreach (DataRow dataRow in this.table_constructiontype.Select("idconstructiontype = " + num1.ToString()))
                dataRow.Delete();
            selectedNode.Delete();
            int num2 = 0;
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_tree.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                    dataRow["numpos"] = (object)num2++;
            }
            this.treeList1.DataMember = "tree";
        }

        private void MenuGroupRename_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null || (int)selectedNode["imageindex"] != 0 || InputBox.ShowDialog("Ввод имени типы конструкций", "Введите имя типа", selectedNode["name"].ToString()) != DialogResult.OK)
                return;
            selectedNode["name"] = (object)InputBox.Value;
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_constructiontype.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted && (int)dataRow["idconstructiontype"] == (int)selectedNode["idconstructiontype"])
                    dataRow["name"] = (object)InputBox.Value;
            }
        }

        private void MenuGroupMoveUp_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null || (int)selectedNode["imageindex"] != 0)
                return;
            this.SetNumPos();
            DataRow[] dataRowArray1 = this.table_tree.Select("imageindex = 0", "numpos");
            for (int index = 0; index < dataRowArray1.Length; ++index)
            {
                if ((int)dataRowArray1[index]["numpos"] != index + 1)
                    dataRowArray1[index]["numpos"] = (object)(index + 1);
            }
            DataRow[] dataRowArray2 = this.table_tree.Select("imageindex = 0 and numpos = " + ((int)selectedNode["numpos"] - 1).ToString());
            if (dataRowArray2.Length != 0)
                dataRowArray2[0]["numpos"] = (object)((int)dataRowArray2[0]["numpos"] + 1);
            selectedNode["numpos"] = (object)((int)selectedNode["numpos"] - 1);
            TreeListNode node = AtTreeList.FindNode(this.treeList1, (TreeListNode)null, "idconstructiontype", (int)selectedNode["idconstructiontype"]);
            this.treeList1.FocusedNode = node;
            node.Expanded = false;
            this.treeList1.Columns[1].SortOrder = SortOrder.Ascending;
        }

        private void MenuGroupMoveDown_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null || (int)selectedNode["imageindex"] != 0)
                return;
            this.SetNumPos();
            DataRow[] dataRowArray1 = this.table_tree.Select("imageindex = 0", "numpos");
            for (int index = 0; index < dataRowArray1.Length; ++index)
            {
                if ((int)dataRowArray1[index]["numpos"] != index + 1)
                    dataRowArray1[index]["numpos"] = (object)(index + 1);
            }
            DataRow[] dataRowArray2 = this.table_tree.Select("imageindex = 0 and numpos = " + ((int)selectedNode["numpos"] + 1).ToString());
            if (dataRowArray2.Length != 0)
                dataRowArray2[0]["numpos"] = (object)((int)dataRowArray2[0]["numpos"] - 1);
            selectedNode["numpos"] = (object)((int)selectedNode["numpos"] + 1);
            TreeListNode node = AtTreeList.FindNode(this.treeList1, (TreeListNode)null, "idconstructiontype", (int)selectedNode["idconstructiontype"]);
            this.treeList1.FocusedNode = node;
            node.Expanded = false;
            this.treeList1.Columns[1].SortOrder = SortOrder.Ascending;
        }

        private void SetNumPos()
        {
            DataRow[] dataRowArray1 = this.table_tree.Select("numpos is null and imageindex = 0", "idconstructiontype");
            DataRow[] dataRowArray2 = this.table_tree.Select("numpos is not null and imageindex = 0", "numpos desc");
            int num = 1;
            if (dataRowArray2.Length != 0)
                num = (int)dataRowArray2[0]["numpos"];
            foreach (DataRow dataRow in dataRowArray1)
                dataRow["numpos"] = (object)num++;
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ConstructionTypeForm));
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.cmdHideNotActive = new Button();
            this.button1 = new Button();
            this.splitterControl1 = new SplitterControl();
            this.treeList1 = new TreeList();
            this.colname = new TreeListColumn();
            this.treeListColumn1 = new TreeListColumn();
            this.treeListColumn2 = new TreeListColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.MenuGroupAdd = new ToolStripMenuItem();
            this.MenuGroupRemove = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuGroupRename = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuGroupMoveUp = new ToolStripMenuItem();
            this.MenuGroupMoveDown = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_system = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.table_modelpart = new DataTable();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.table_systemdetail = new DataTable();
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
            this.dataColumn35 = new DataColumn();
            this.dataColumn47 = new DataColumn();
            this.dataColumn48 = new DataColumn();
            this.dataColumn57 = new DataColumn();
            this.table_constructiontype = new DataTable();
            this.dataColumn36 = new DataColumn();
            this.dataColumn37 = new DataColumn();
            this.dataColumn38 = new DataColumn();
            this.dataColumn39 = new DataColumn();
            this.dataColumn53 = new DataColumn();
            this.dataColumn55 = new DataColumn();
            this.table_constructiontypedetail = new DataTable();
            this.dataColumn40 = new DataColumn();
            this.dataColumn41 = new DataColumn();
            this.dataColumn42 = new DataColumn();
            this.dataColumn43 = new DataColumn();
            this.dataColumn44 = new DataColumn();
            this.dataColumn45 = new DataColumn();
            this.dataColumn46 = new DataColumn();
            this.dataColumn58 = new DataColumn();
            this.table_tree = new DataTable();
            this.dataColumn32 = new DataColumn();
            this.dataColumn33 = new DataColumn();
            this.dataColumn34 = new DataColumn();
            this.dataColumn49 = new DataColumn();
            this.dataColumn50 = new DataColumn();
            this.dataColumn51 = new DataColumn();
            this.dataColumn52 = new DataColumn();
            this.dataColumn54 = new DataColumn();
            this.dataColumn56 = new DataColumn();
            this.imageList1 = new ImageList(this.components);
            this.colb = new GridColumn();
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.colnumpos2 = new GridColumn();
            this.col_s = new GridColumn();
            this.colalsoimpost = new GridColumn();
            this.colidsystem = new GridColumn();
            this.colidversion = new GridColumn();
            this.colidmodelpart = new GridColumn();
            this.colname1 = new GridColumn();
            this.cola = new GridColumn();
            this.gridColumn1 = new GridColumn();
            this.colc = new GridColumn();
            this.cold = new GridColumn();
            this.cole = new GridColumn();
            this.colcomment = new GridColumn();
            this.colidsystemdetail = new GridColumn();
            this.colsystemdetailgroup = new GridColumn();
            this.colg = new GridColumn();
            this.panel1.SuspendLayout();
            this.treeList1.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_system.BeginInit();
            this.table_modelpart.BeginInit();
            this.table_systemdetail.BeginInit();
            this.table_constructiontype.BeginInit();
            this.table_constructiontypedetail.BeginInit();
            this.table_tree.BeginInit();
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.cmdHideNotActive);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(821, 33);
            this.panel1.TabIndex = 3;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(734, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(653, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.cmdHideNotActive.FlatStyle = FlatStyle.Flat;
            this.cmdHideNotActive.Location = new Point(26, 6);
            this.cmdHideNotActive.Name = "cmdHideNotActive";
            this.cmdHideNotActive.Size = new Size(133, 23);
            this.cmdHideNotActive.TabIndex = 0;
            this.cmdHideNotActive.Text = "Скрыть неактивные";
            this.cmdHideNotActive.Visible = false;
            this.cmdHideNotActive.Click += new EventHandler(this.button1_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(572, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.splitterControl1.Location = new Point(225, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 500);
            this.splitterControl1.TabIndex = 9;
            this.splitterControl1.TabStop = false;
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
        this.colname,
        this.treeListColumn1,
        this.treeListColumn2
      });
            this.treeList1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeList1.DataMember = "tree";
            this.treeList1.DataSource = (object)this.ds;
            this.treeList1.Dock = DockStyle.Left;
            this.treeList1.ImageIndexFieldName = "imageindex";
            this.treeList1.KeyFieldName = "id";
            this.treeList1.Location = new Point(0, 0);
            this.treeList1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.ParentFieldName = "parentid";
            this.treeList1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemCheckEdit1
      });
            this.treeList1.SelectImageList = (object)this.imageList1;
            this.treeList1.Size = new Size(225, 500);
            this.treeList1.TabIndex = 8;
            this.colname.Caption = "Типы конструкций";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 27;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 176;
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "numpos";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.SortOrder = SortOrder.Ascending;
            this.treeListColumn2.Caption = "Активность";
            this.treeListColumn2.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit1;
            this.treeListColumn2.FieldName = "isactive";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 91;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.MenuGroupAdd,
        (ToolStripItem) this.MenuGroupRemove,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuGroupRename,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuGroupMoveUp,
        (ToolStripItem) this.MenuGroupMoveDown
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(301, 126);
            this.MenuGroupAdd.Name = "MenuGroupAdd";
            this.MenuGroupAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuGroupAdd.Size = new Size(300, 22);
            this.MenuGroupAdd.Text = "Добавить тип конструкций";
            this.MenuGroupAdd.Click += new EventHandler(this.MenuGroupAdd_Click);
            this.MenuGroupRemove.Name = "MenuGroupRemove";
            this.MenuGroupRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuGroupRemove.Size = new Size(300, 22);
            this.MenuGroupRemove.Text = "Удалить тип конструкций";
            this.MenuGroupRemove.Click += new EventHandler(this.MenuGroupRemove_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(297, 6);
            this.MenuGroupRename.Name = "MenuGroupRename";
            this.MenuGroupRename.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuGroupRename.Size = new Size(300, 22);
            this.MenuGroupRename.Text = "Переименовать тип конструкций";
            this.MenuGroupRename.Click += new EventHandler(this.MenuGroupRename_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(297, 6);
            this.MenuGroupMoveUp.Name = "MenuGroupMoveUp";
            this.MenuGroupMoveUp.ShortcutKeys = Keys.Up | Keys.Control;
            this.MenuGroupMoveUp.Size = new Size(300, 22);
            this.MenuGroupMoveUp.Text = "Переместить вверх";
            this.MenuGroupMoveUp.Click += new EventHandler(this.MenuGroupMoveUp_Click);
            this.MenuGroupMoveDown.Name = "MenuGroupMoveDown";
            this.MenuGroupMoveDown.ShortcutKeys = Keys.Down | Keys.Control;
            this.MenuGroupMoveDown.Size = new Size(300, 22);
            this.MenuGroupMoveDown.Text = "Переместить вниз";
            this.MenuGroupMoveDown.Click += new EventHandler(this.MenuGroupMoveDown_Click);
            this.ds.DataSetName = "ds_system";
            this.ds.EnforceConstraints = false;
            this.ds.Relations.AddRange(new DataRelation[3]
      {
        new DataRelation("Relation1", "system", "systemdetail", new string[1]
        {
          "idsystem"
        }, new string[1]
        {
          "idsystem"
        }, 0 != 0),
        new DataRelation("Relation2", "constructiontype", "constructiontypedetail", new string[1]
        {
          "idconstructiontype"
        }, new string[1]
        {
          "idconstructiontype"
        }, 0 != 0),
        new DataRelation("Relation3", "system", "constructiontypedetail", new string[1]
        {
          "idsystem"
        }, new string[1]
        {
          "idsystem"
        }, 0 != 0)
      });
            this.ds.Tables.AddRange(new DataTable[6]
      {
        this.table_system,
        this.table_modelpart,
        this.table_systemdetail,
        this.table_constructiontype,
        this.table_constructiontypedetail,
        this.table_tree
      });
            this.table_system.Columns.AddRange(new DataColumn[4]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4
      });
            this.table_system.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idsystem"
        }, 0 != 0)
      });
            this.table_system.TableName = "system";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idsystem";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "idversion";
            this.dataColumn4.DataType = typeof(int);
            this.table_modelpart.Columns.AddRange(new DataColumn[7]
      {
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn9,
        this.dataColumn10,
        this.dataColumn11
      });
            this.table_modelpart.TableName = "modelpart";
            this.dataColumn5.AllowDBNull = false;
            this.dataColumn5.ColumnName = "idmodelpart";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "name";
            this.dataColumn7.ColumnName = "comment";
            this.dataColumn8.ColumnName = "parentid";
            this.dataColumn8.DataType = typeof(int);
            this.dataColumn9.ColumnName = "typ";
            this.dataColumn9.DataType = typeof(int);
            this.dataColumn10.ColumnName = "numpos";
            this.dataColumn10.DataType = typeof(int);
            this.dataColumn11.ColumnName = "idversion";
            this.dataColumn11.DataType = typeof(int);
            this.table_systemdetail.Columns.AddRange(new DataColumn[24]
      {
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
        this.dataColumn35,
        this.dataColumn47,
        this.dataColumn48,
        this.dataColumn57
      });
            this.table_systemdetail.TableName = "systemdetail";
            this.dataColumn12.AllowDBNull = false;
            this.dataColumn12.ColumnName = "idsystemdetail";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.ColumnName = "idsystem";
            this.dataColumn13.DataType = typeof(int);
            this.dataColumn14.ColumnName = "name";
            this.dataColumn15.ColumnName = "comment";
            this.dataColumn16.ColumnName = "a";
            this.dataColumn16.DataType = typeof(double);
            this.dataColumn17.ColumnName = "b";
            this.dataColumn17.DataType = typeof(double);
            this.dataColumn18.ColumnName = "c";
            this.dataColumn18.DataType = typeof(double);
            this.dataColumn19.ColumnName = "d";
            this.dataColumn19.DataType = typeof(double);
            this.dataColumn20.ColumnName = "e";
            this.dataColumn20.DataType = typeof(double);
            this.dataColumn21.ColumnName = "f";
            this.dataColumn21.DataType = typeof(double);
            this.dataColumn22.ColumnName = "g";
            this.dataColumn22.DataType = typeof(double);
            this.dataColumn23.ColumnName = "thick";
            this.dataColumn23.DataType = typeof(int);
            this.dataColumn24.ColumnName = "thickness";
            this.dataColumn24.DataType = typeof(int);
            this.dataColumn25.ColumnName = "weight";
            this.dataColumn25.DataType = typeof(double);
            this.dataColumn26.ColumnName = "height";
            this.dataColumn26.DataType = typeof(int);
            this.dataColumn27.ColumnName = "width";
            this.dataColumn27.DataType = typeof(int);
            this.dataColumn28.ColumnName = "idmodelpart";
            this.dataColumn28.DataType = typeof(int);
            this.dataColumn29.ColumnName = "idversion";
            this.dataColumn29.DataType = typeof(int);
            this.dataColumn30.ColumnName = "systemdetailgroup";
            this.dataColumn31.ColumnName = "numpos";
            this.dataColumn31.DataType = typeof(int);
            this.dataColumn35.ColumnName = "deleted";
            this.dataColumn35.DataType = typeof(DateTime);
            this.dataColumn47.ColumnName = "s";
            this.dataColumn47.DataType = typeof(bool);
            this.dataColumn48.ColumnName = "numpos2";
            this.dataColumn48.DataType = typeof(int);
            this.dataColumn57.ColumnName = "alsoimpost";
            this.dataColumn57.DataType = typeof(bool);
            this.table_constructiontype.Columns.AddRange(new DataColumn[6]
      {
        this.dataColumn36,
        this.dataColumn37,
        this.dataColumn38,
        this.dataColumn39,
        this.dataColumn53,
        this.dataColumn55
      });
            this.table_constructiontype.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idconstructiontype"
        }, 1 != 0)
      });
            this.table_constructiontype.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn36
      };
            this.table_constructiontype.TableName = "constructiontype";
            this.dataColumn36.AllowDBNull = false;
            this.dataColumn36.ColumnName = "idconstructiontype";
            this.dataColumn36.DataType = typeof(int);
            this.dataColumn37.ColumnName = "name";
            this.dataColumn38.ColumnName = "idversion";
            this.dataColumn38.DataType = typeof(int);
            this.dataColumn39.ColumnName = "comment";
            this.dataColumn53.ColumnName = "numpos";
            this.dataColumn53.DataType = typeof(int);
            this.dataColumn55.ColumnName = "isactive";
            this.dataColumn55.DataType = typeof(bool);
            this.table_constructiontypedetail.Columns.AddRange(new DataColumn[8]
      {
        this.dataColumn40,
        this.dataColumn41,
        this.dataColumn42,
        this.dataColumn43,
        this.dataColumn44,
        this.dataColumn45,
        this.dataColumn46,
        this.dataColumn58
      });
            this.table_constructiontypedetail.Constraints.AddRange(new Constraint[3]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idconstructiontypedetail"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("Relation2", "constructiontype", new string[1]
        {
          "idconstructiontype"
        }, new string[1]
        {
          "idconstructiontype"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade),
        (Constraint) new ForeignKeyConstraint("Relation3", "system", new string[1]
        {
          "idsystem"
        }, new string[1]
        {
          "idsystem"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_constructiontypedetail.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn40
      };
            this.table_constructiontypedetail.TableName = "constructiontypedetail";
            this.dataColumn40.AllowDBNull = false;
            this.dataColumn40.ColumnName = "idconstructiontypedetail";
            this.dataColumn40.DataType = typeof(int);
            this.dataColumn41.ColumnName = "idversion";
            this.dataColumn41.DataType = typeof(int);
            this.dataColumn42.ColumnName = "idconstructiontype";
            this.dataColumn42.DataType = typeof(int);
            this.dataColumn43.ColumnName = "idsystem";
            this.dataColumn43.DataType = typeof(int);
            this.dataColumn44.ColumnName = "idsystemdetail";
            this.dataColumn44.DataType = typeof(int);
            this.dataColumn45.ColumnName = "numpos";
            this.dataColumn45.DataType = typeof(int);
            this.dataColumn46.ColumnName = "idmodelpart";
            this.dataColumn46.DataType = typeof(int);
            this.dataColumn58.ColumnName = "alsoimpost";
            this.table_tree.Columns.AddRange(new DataColumn[9]
      {
        this.dataColumn32,
        this.dataColumn33,
        this.dataColumn34,
        this.dataColumn49,
        this.dataColumn50,
        this.dataColumn51,
        this.dataColumn52,
        this.dataColumn54,
        this.dataColumn56
      });
            this.table_tree.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "numpos"
        }, 1 != 0)
      });
            this.table_tree.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn54
      };
            this.table_tree.TableName = "tree";
            this.dataColumn32.ColumnName = "id";
            this.dataColumn32.DataType = typeof(int);
            this.dataColumn33.ColumnName = "name";
            this.dataColumn34.ColumnName = "parentid";
            this.dataColumn34.DataType = typeof(int);
            this.dataColumn49.ColumnName = "imageindex";
            this.dataColumn49.DataType = typeof(int);
            this.dataColumn50.ColumnName = "idsystem";
            this.dataColumn50.DataType = typeof(int);
            this.dataColumn51.ColumnName = "idmodelpart";
            this.dataColumn51.DataType = typeof(int);
            this.dataColumn52.ColumnName = "idconstructiontype";
            this.dataColumn52.DataType = typeof(int);
            this.dataColumn54.AllowDBNull = false;
            this.dataColumn54.ColumnName = "numpos";
            this.dataColumn54.DataType = typeof(int);
            this.dataColumn56.ColumnName = "isactive";
            this.dataColumn56.DataType = typeof(bool);
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Webcontrol_Multiview.bmp");
            this.imageList1.Images.SetKeyName(1, "VSObject_Module.bmp");
            this.imageList1.Images.SetKeyName(2, "VSObject_Structure.bmp");
            this.imageList1.Images.SetKeyName(3, "stop.png");
            this.imageList1.Images.SetKeyName(4, "Relationships.bmp");
            this.imageList1.Images.SetKeyName(5, "Windows.bmp");
            this.colb.Caption = "b";
            this.colb.FieldName = "b";
            this.colb.Name = "colb";
            this.colb.Visible = true;
            this.colb.VisibleIndex = 0;
            this.colb.Width = 37;
            this.gridControl1.DataMember = "systemdetail";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(231, 0);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new Size(590, 500);
            this.gridControl1.TabIndex = 10;
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
            this.gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.BorderStyle = BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new GridColumn[14]
      {
        this.colnumpos2,
        this.col_s,
        this.colalsoimpost,
        this.colidsystem,
        this.colidversion,
        this.colidmodelpart,
        this.colname1,
        this.cola,
        this.gridColumn1,
        this.colc,
        this.cold,
        this.cole,
        this.colcomment,
        this.colidsystemdetail
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colnumpos2.Caption = "№пп";
            this.colnumpos2.FieldName = "numpos2";
            this.colnumpos2.Name = "colnumpos2";
            this.colnumpos2.Visible = true;
            this.colnumpos2.VisibleIndex = 0;
            this.colnumpos2.Width = 34;
            this.col_s.AppearanceHeader.Options.UseTextOptions = true;
            this.col_s.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            this.col_s.Caption = "\\/";
            this.col_s.FieldName = "s";
            this.col_s.Name = "col_s";
            this.col_s.Visible = true;
            this.col_s.VisibleIndex = 1;
            this.col_s.Width = 24;
            this.colalsoimpost.Caption = "Импост";
            this.colalsoimpost.FieldName = "alsoimpost";
            this.colalsoimpost.Name = "colalsoimpost";
            this.colalsoimpost.Visible = true;
            this.colalsoimpost.VisibleIndex = 2;
            this.colidsystem.AppearanceHeader.Options.UseTextOptions = true;
            this.colidsystem.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            this.colidsystem.Caption = "idsystem";
            this.colidsystem.FieldName = "idsystem";
            this.colidsystem.Name = "colidsystem";
            this.colidsystem.OptionsColumn.AllowEdit = false;
            this.colidversion.Caption = "idversion";
            this.colidversion.FieldName = "idversion";
            this.colidversion.Name = "colidversion";
            this.colidversion.OptionsColumn.AllowEdit = false;
            this.colidmodelpart.Caption = "idmodelpart";
            this.colidmodelpart.FieldName = "idmodelpart";
            this.colidmodelpart.Name = "colidmodelpart";
            this.colidmodelpart.OptionsColumn.AllowEdit = false;
            this.colidmodelpart.Width = 43;
            this.colname1.Caption = "Наименование";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.OptionsColumn.AllowEdit = false;
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 3;
            this.colname1.Width = 91;
            this.cola.Caption = "a";
            this.cola.FieldName = "a";
            this.cola.Name = "cola";
            this.cola.OptionsColumn.AllowEdit = false;
            this.cola.Visible = true;
            this.cola.VisibleIndex = 4;
            this.cola.Width = 32;
            this.gridColumn1.Caption = "b";
            this.gridColumn1.FieldName = "b";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 34;
            this.colc.Caption = "c";
            this.colc.FieldName = "c";
            this.colc.Name = "colc";
            this.colc.OptionsColumn.AllowEdit = false;
            this.colc.Visible = true;
            this.colc.VisibleIndex = 6;
            this.colc.Width = 33;
            this.cold.Caption = "d";
            this.cold.FieldName = "d";
            this.cold.Name = "cold";
            this.cold.OptionsColumn.AllowEdit = false;
            this.cold.Visible = true;
            this.cold.VisibleIndex = 7;
            this.cold.Width = 32;
            this.cole.Caption = "e";
            this.cole.FieldName = "e";
            this.cole.Name = "cole";
            this.cole.OptionsColumn.AllowEdit = false;
            this.cole.Visible = true;
            this.cole.VisibleIndex = 8;
            this.cole.Width = 32;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.OptionsColumn.AllowEdit = false;
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 9;
            this.colcomment.Width = 204;
            this.colidsystemdetail.Caption = "idsystemdetail";
            this.colidsystemdetail.FieldName = "idsystemdetail";
            this.colidsystemdetail.Name = "colidsystemdetail";
            this.colidsystemdetail.OptionsColumn.AllowEdit = false;
            this.colsystemdetailgroup.Caption = "Группа";
            this.colsystemdetailgroup.FieldName = "systemdetailgroup";
            this.colsystemdetailgroup.Name = "colsystemdetailgroup";
            this.colsystemdetailgroup.Visible = true;
            this.colsystemdetailgroup.VisibleIndex = 9;
            this.colsystemdetailgroup.Width = 90;
            this.colg.Caption = "g";
            this.colg.FieldName = "g";
            this.colg.Name = "colg";
            this.colg.Visible = true;
            this.colg.VisibleIndex = 8;
            this.colg.Width = 39;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeList1);
            this.Controls.Add((Control)this.panel1);
            this.Name = "ConstructionTypeForm";
            this.Size = new Size(821, 533);
            this.Text = "Типы конструкций";
            this.panel1.ResumeLayout(false);
            this.treeList1.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_system.EndInit();
            this.table_modelpart.EndInit();
            this.table_systemdetail.EndInit();
            this.table_constructiontype.EndInit();
            this.table_constructiontypedetail.EndInit();
            this.table_tree.EndInit();
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            this.ResumeLayout(false);
        }
    }
}
