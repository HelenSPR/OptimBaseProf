// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodServiceForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class GoodServiceForm : AtUserControl
    {
        private bool IsMove;
        private bool IsMoveGroup;
        private DataRow[] MoveServicesRows;
        private DataRow MoveGroupRow;
        private IContainer components;
        public Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        public Panel panel2;
        private Button button4;
        private Button button5;
        private ds ds1;
        private ContextMenuStrip MenuStripService;
        private ToolStripMenuItem mnuItemAddService;
        private ToolStripMenuItem mnuItemDublicateService;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuItemRemoveService;
        private Splitter splitter1;
        private TreeList treeListGroup;
        private TreeListColumn treeListColumn1;
        private TreeListColumn treeListColumn2;
        public GridControl gridControl1;
        public GridView gridView1;
        private GridColumn colidgoodservice;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colsm;
        private GridColumn colperc;
        private GridColumn colgoodservicegroup;
        private GridColumn colisperc;
        private ContextMenuStrip MenuStripGroup;
        private ToolStripMenuItem mnuItemAddMainGroup;
        private ToolStripMenuItem mnuItemAddChildGroup;
        private ToolStripMenuItem mnuItemRenameGroup;
        private ToolStripMenuItem mnuItemDublicateGroup;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuItemRemoveGroup;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem mnuItemMoveGroup;
        private ImageList imageList1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuItemMoveService;
        private GridColumn colprice1;
        private RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private GridColumn colvalut1_shortname;
        private GridColumn colprice2;
        private RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private GridColumn colvalut2_shortname;
        private GridColumn colprice3;
        private RepositoryItemCalcEdit repositoryItemCalcEdit3;
        private GridColumn colvalut4_shortname;
        private GridColumn colprice4;
        private RepositoryItemCalcEdit repositoryItemCalcEdit4;
        private GridColumn colvalut3_shortname;
        private GridColumn colprice5;
        private RepositoryItemCalcEdit repositoryItemCalcEdit5;
        private GridColumn colvalut5_shortname;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private RepositoryItemComboBox repositoryItemComboBox2;
        private RepositoryItemComboBox repositoryItemComboBox3;
        private RepositoryItemComboBox repositoryItemComboBox4;
        private RepositoryItemComboBox repositoryItemComboBox5;
        private GridColumn colismy;

        public GoodServiceForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.gridView1.Columns["isperc"].Visible = true;
            this.gridView1.Columns["ismy"].OptionsColumn.AllowEdit = Settings.isDealer;
            this.FormClosing += new FormClosing(this.GoodServiceForm_FormClosing);
            this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
            this.mnuItemAddChildGroup.Click += new EventHandler(this.mnuItemAddChildGroup_Click);
            this.mnuItemAddMainGroup.Click += new EventHandler(this.mnuItemAddMainGroup_Click);
            this.mnuItemDublicateGroup.Click += new EventHandler(this.mnuItemDublicateGroup_Click);
            this.mnuItemMoveGroup.Click += new EventHandler(this.mnuItemMoveGroup_Click);
            this.mnuItemRemoveGroup.Click += new EventHandler(this.mnuItemRemoveGroup_Click);
            this.mnuItemRenameGroup.Click += new EventHandler(this.mnuItemRenameGroup_Click);
            this.mnuItemAddService.Click += new EventHandler(this.mnuItemAddService_Click);
            this.mnuItemDublicateService.Click += new EventHandler(this.mnuItemDublicateService_Click);
            this.mnuItemRemoveService.Click += new EventHandler(this.mnuItemRemoveService_Click);
            this.mnuItemMoveService.Click += new EventHandler(this.mnuItemMoveService_Click);
            this.treeListGroup.Click += new EventHandler(this.treeListGroup_Click);
            this.treeListGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListGroup_FocusedNodeChanged);
            this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
            this.repositoryItemComboBox1.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBox1_ParseEditValue);
            this.repositoryItemComboBox2.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBox2_ParseEditValue);
            this.repositoryItemComboBox3.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBox3_ParseEditValue);
            this.repositoryItemComboBox4.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBox4_ParseEditValue);
            this.repositoryItemComboBox5.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBox5_ParseEditValue);
        }

        private void repositoryItemComboBox5_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            Valut valut = (Valut)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)valut.name;
            AtGrid.getDataRow((Control)this.gridControl1)["idvalut5"] = (object)valut.idvalut;
        }

        private void repositoryItemComboBox4_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            Valut valut = (Valut)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)valut.name;
            AtGrid.getDataRow((Control)this.gridControl1)["idvalut4"] = (object)valut.idvalut;
        }

        private void repositoryItemComboBox3_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            Valut valut = (Valut)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)valut.name;
            AtGrid.getDataRow((Control)this.gridControl1)["idvalut3"] = (object)valut.idvalut;
        }

        private void repositoryItemComboBox2_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            Valut valut = (Valut)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)valut.name;
            AtGrid.getDataRow((Control)this.gridControl1)["idvalut2"] = (object)valut.idvalut;
        }

        private void repositoryItemComboBox1_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            Valut valut = (Valut)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)valut.name;
            AtGrid.getDataRow((Control)this.gridControl1)["idvalut1"] = (object)valut.idvalut;
        }

        private void mnuItemAddMainGroup_Click(object sender, EventArgs e)
        {
            ds.goodservicegroupRow goodservicegroupRow = this.ds1.goodservicegroup.NewgoodservicegroupRow();
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", goodservicegroupRow["name"].ToString()) == DialogResult.Cancel)
                return;
            goodservicegroupRow.idgoodservicegroup = dbconn.GetGenId("gen_goodservicegroup");
            goodservicegroupRow.name = InputBox.Value;
            goodservicegroupRow.isactive = true;
            this.ds1.goodservicegroup.Rows.Add((DataRow)goodservicegroupRow);
        }

        private void mnuItemAddChildGroup_Click(object sender, EventArgs e)
        {
            ds.goodservicegroupRow goodservicegroupRow1 = (ds.goodservicegroupRow)AtTreeList.GetSelectedNode(this.treeListGroup);
            if (goodservicegroupRow1 == null || InputBox.ShowDialog("Создание дочерней группы", "Введите имя", goodservicegroupRow1.name) == DialogResult.Cancel)
                return;
            ds.goodservicegroupRow goodservicegroupRow2 = this.ds1.goodservicegroup.NewgoodservicegroupRow();
            goodservicegroupRow2.idgoodservicegroup = dbconn.GetGenId("gen_goodservicegroup");
            goodservicegroupRow2["parentid"] = goodservicegroupRow1["idgoodservicegroup"];
            goodservicegroupRow2.name = InputBox.Value;
            goodservicegroupRow2.isactive = true;
            this.ds1.goodservicegroup.Rows.Add((DataRow)goodservicegroupRow2);
        }

        private void mnuItemRenameGroup_Click(object sender, EventArgs e)
        {
            ds.goodservicegroupRow goodservicegroupRow = (ds.goodservicegroupRow)AtTreeList.GetSelectedNode(this.treeListGroup);
            if (goodservicegroupRow == null || InputBox.ShowDialog("Изменение имени группы", "Введите новое имя", goodservicegroupRow.name) == DialogResult.Cancel)
                return;
            goodservicegroupRow.name = InputBox.Value;
        }

        private void mnuItemRemoveGroup_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            bool flag = false;
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.ds1.goodservicegroup.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted && dataRow["parentid"] != DBNull.Value && (int)dataRow["parentid"] == (int)selectedNode["idgoodservicegroup"])
                {
                    flag = true;
                    break;
                }
            }
            if (flag && MessageBox.Show("Группа содержит вложенные подгруппы. Удалить группу вместе с вложениями?", "Удаление группы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            selectedNode.Delete();
        }

        private void mnuItemMoveGroup_Click(object sender, EventArgs e)
        {
            this.MoveGroupRow = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (this.MoveGroupRow == null)
                return;
            this.IsMoveGroup = true;
            this.Cursor = Cursors.Hand;
        }

        private void mnuItemDublicateGroup_Click(object sender, EventArgs e)
        {
            if (this.treeListGroup.Selection.Count == 0)
                return;
            List<DataRow> listNodesRows = AtTreeList.GetListNodesRows(this.treeListGroup, this.treeListGroup.Selection[0]);
            if (listNodesRows == null || listNodesRows.Count == 0)
                return;
            List<int[]> ListID = new List<int[]>();
            int num = listNodesRows[0]["Parentid"] == DBNull.Value ? 0 : Convert.ToInt32(listNodesRows[0]["Parentid"]);
            ListID.Add(new int[2]
      {
        num,
        num
      });
            foreach (DataRow source1 in listNodesRows)
            {
                if (source1.RowState != DataRowState.Deleted)
                {
                    int SourceID = source1["parentid"] == DBNull.Value ? 0 : Convert.ToInt32(source1["parentid"]);
                    int parentId = AtTreeList.GetParentID(ListID, SourceID);
                    DataRow dataRow1 = AtDataSet.dublicate(source1);
                    int genId = dbconn.GetGenId("gen_goodservicegroup");
                    dataRow1["idgoodservicegroup"] = (object)genId;
                    dataRow1["parentid"] = (object)parentId;
                    ListID.Add(new int[2]
          {
            Convert.ToInt32(source1["idgoodservicegroup"]),
            genId
          });
                    foreach (DataRow source2 in source1.GetChildRows("FK_goodservicegroup_goodservice"))
                    {
                        if (source2.RowState != DataRowState.Deleted)
                        {
                            DataRow dataRow2 = AtDataSet.dublicate(source2);
                            dataRow2["idgoodservice"] = (object)dbconn.GetGenId("gen_goodservice");
                            dataRow2["idgoodservicegroup"] = (object)genId;
                        }
                    }
                }
            }
        }

        private void mnuItemAddService_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            ds.goodserviceRow goodserviceRow = this.ds1.goodservice.NewgoodserviceRow();
            goodserviceRow.idgoodservice = dbconn.GetGenId("gen_goodservice");
            goodserviceRow["idgoodservicegroup"] = selectedNode["idgoodservicegroup"];
            goodserviceRow.name = "Новая услуга";
            goodserviceRow.sm = new Decimal(0);
            goodserviceRow.perc = new Decimal(0);
            goodserviceRow.isperc = false;
            goodserviceRow.ismy = Settings.isDealer;
            this.ds1.goodservice.Rows.Add((DataRow)goodserviceRow);
        }

        private void mnuItemDublicateService_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            foreach (DataRow source in selectedDataRows)
                AtDataSet.dublicate(source)["idgoodservice"] = (object)dbconn.GetGenId("gen_goodservice");
        }

        private void mnuItemRemoveService_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void mnuItemMoveService_Click(object sender, EventArgs e)
        {
            if (this.gridView1.SelectedRowsCount == 0)
                return;
            this.MoveServicesRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            this.IsMove = true;
            this.Cursor = Cursors.Hand;
        }

        private void treeListGroup_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if ((!this.IsMove || this.MoveServicesRows == null || this.MoveServicesRows.Length == 0) && (!this.IsMoveGroup || this.MoveGroupRow == null))
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            if (this.IsMove)
            {
                foreach (DataRow dataRow in this.MoveServicesRows)
                    dataRow["idgoodservicegroup"] = selectedNode["idgoodservicegroup"];
                this.IsMove = false;
            }
            else
            {
                this.MoveGroupRow["parentid"] = selectedNode["idgoodservicegroup"];
                this.IsMoveGroup = false;
            }
            this.Cursor = Cursors.Default;
        }

        private void treeListGroup_Click(object sender, EventArgs e)
        {
            if ((!this.IsMove || this.MoveServicesRows == null || this.MoveServicesRows.Length == 0) && !this.IsMoveGroup || this.MoveGroupRow == null)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            if (this.IsMove)
            {
                if (!(this.MoveServicesRows[0]["idgoodservicegroup"].ToString() == selectedNode["idgoodservicegroup"].ToString()))
                    return;
                this.IsMove = false;
                this.Cursor = Cursors.Default;
            }
            else
            {
                if (!this.IsMoveGroup || !(this.MoveGroupRow["idgoodservicegroup"].ToString() == selectedNode["idgoodservicegroup"].ToString()) && !(this.MoveGroupRow["parentid"].ToString() == selectedNode["idgoodservicegroup"].ToString()))
                    return;
                this.IsMoveGroup = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (!this.IsMove || this.MoveServicesRows == null || this.MoveServicesRows.Length == 0)
                return;
            this.IsMove = false;
            this.Cursor = Cursors.Default;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GoodServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataTable((DataTable)this.ds1.goodservice) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        public override void LoadFromBase()
        {
            if (!this.Is_Dialog)
            {
                this.ds1.goodservicegroup.Rows.Clear();
                this.db.command.CommandText = "select * from goodservicegroup where deleted is null";
                this.db.adapter.Fill((DataTable)this.ds1.goodservicegroup);
            }
            this.ds1.goodservice.Rows.Clear();
            if (!this.Is_Dialog)
            {
                this.db.command.CommandText = "select * from view_goodservice where deleted is null and group_deleted is null";
            }
            else
            {
                this.db.command.CommandText = "select * from view_goodservice where deleted is null and group_deleted is null and group_isactive = 1";
                this.gridControl1.DataMember = "goodservice";
            }
            this.db.adapter.Fill((DataTable)this.ds1.goodservice);
            DataTable table = new DataTable("valut");
            this.db.command.CommandText = "select * from valut where deleted is null";
            this.db.adapter.Fill(table);
            foreach (DataRow dataRow in (InternalDataCollectionBase)table.Rows)
            {
                Valut valut = new Valut((int)dataRow["idvalut"], dataRow["shortname"].ToString());
                this.repositoryItemComboBox1.Items.Add((object)valut);
                this.repositoryItemComboBox2.Items.Add((object)valut);
                this.repositoryItemComboBox3.Items.Add((object)valut);
                this.repositoryItemComboBox4.Items.Add((object)valut);
                this.repositoryItemComboBox5.Items.Add((object)valut);
            }
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDatatableAndAccept2((DataTable)this.ds1.goodservicegroup))
                return false;
            return this.db.SaveDatatableAndAccept2((DataTable)this.ds1.goodservice);
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
            this.treeListGroup.Visible = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.gridView1.Columns["isperc"].Visible = false;
            this.Is_Dialog = true;
            this.LoadFromBase();
        }

        private void GoodServiceForm_Shown(object sender, EventArgs e)
        {
            new CalcProcessor(dbconn._db).ExecuteOrderEvent("События справочников.Открытие формы услуг", (object)this);
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GoodServiceForm));
            this.MenuStripService = new ContextMenuStrip(this.components);
            this.mnuItemAddService = new ToolStripMenuItem();
            this.mnuItemDublicateService = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.mnuItemRemoveService = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.mnuItemMoveService = new ToolStripMenuItem();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.ds1 = new ds();
            this.splitter1 = new Splitter();
            this.treeListGroup = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.treeListColumn2 = new TreeListColumn();
            this.MenuStripGroup = new ContextMenuStrip(this.components);
            this.mnuItemAddMainGroup = new ToolStripMenuItem();
            this.mnuItemAddChildGroup = new ToolStripMenuItem();
            this.mnuItemRenameGroup = new ToolStripMenuItem();
            this.mnuItemDublicateGroup = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.mnuItemRemoveGroup = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.mnuItemMoveGroup = new ToolStripMenuItem();
            this.imageList1 = new ImageList(this.components);
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.colidgoodservice = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colsm = new GridColumn();
            this.colperc = new GridColumn();
            this.colgoodservicegroup = new GridColumn();
            this.colisperc = new GridColumn();
            this.colprice1 = new GridColumn();
            this.repositoryItemCalcEdit1 = new RepositoryItemCalcEdit();
            this.colvalut1_shortname = new GridColumn();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.colprice2 = new GridColumn();
            this.repositoryItemCalcEdit2 = new RepositoryItemCalcEdit();
            this.colvalut2_shortname = new GridColumn();
            this.repositoryItemComboBox2 = new RepositoryItemComboBox();
            this.colprice3 = new GridColumn();
            this.repositoryItemCalcEdit3 = new RepositoryItemCalcEdit();
            this.colvalut4_shortname = new GridColumn();
            this.repositoryItemComboBox3 = new RepositoryItemComboBox();
            this.colprice4 = new GridColumn();
            this.repositoryItemCalcEdit4 = new RepositoryItemCalcEdit();
            this.colvalut3_shortname = new GridColumn();
            this.repositoryItemComboBox4 = new RepositoryItemComboBox();
            this.colprice5 = new GridColumn();
            this.repositoryItemCalcEdit5 = new RepositoryItemCalcEdit();
            this.colvalut5_shortname = new GridColumn();
            this.repositoryItemComboBox5 = new RepositoryItemComboBox();
            this.colismy = new GridColumn();
            this.MenuStripService.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ds1.BeginInit();
            this.treeListGroup.BeginInit();
            this.MenuStripGroup.SuspendLayout();
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemCalcEdit1.BeginInit();
            this.repositoryItemComboBox1.BeginInit();
            this.repositoryItemCalcEdit2.BeginInit();
            this.repositoryItemComboBox2.BeginInit();
            this.repositoryItemCalcEdit3.BeginInit();
            this.repositoryItemComboBox3.BeginInit();
            this.repositoryItemCalcEdit4.BeginInit();
            this.repositoryItemComboBox4.BeginInit();
            this.repositoryItemCalcEdit5.BeginInit();
            this.repositoryItemComboBox5.BeginInit();
            this.SuspendLayout();
            this.MenuStripService.Items.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.mnuItemAddService,
        (ToolStripItem) this.mnuItemDublicateService,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.mnuItemRemoveService,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.mnuItemMoveService
      });
            this.MenuStripService.Name = "contextMenuStrip1";
            this.MenuStripService.Size = new Size(188, 104);
            this.mnuItemAddService.Name = "mnuItemAddService";
            this.mnuItemAddService.Size = new Size(187, 22);
            this.mnuItemAddService.Text = "Добавить";
            this.mnuItemDublicateService.Name = "mnuItemDublicateService";
            this.mnuItemDublicateService.Size = new Size(187, 22);
            this.mnuItemDublicateService.Text = "Дублировать";
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(184, 6);
            this.mnuItemRemoveService.Name = "mnuItemRemoveService";
            this.mnuItemRemoveService.Size = new Size(187, 22);
            this.mnuItemRemoveService.Text = "Удалить";
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(184, 6);
            this.mnuItemMoveService.Name = "mnuItemMoveService";
            this.mnuItemMoveService.Size = new Size(187, 22);
            this.mnuItemMoveService.Text = "Переместить в группу";
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(929, 33);
            this.panel1.TabIndex = 3;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(842, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(761, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(680, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(929, 33);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(842, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Отменить";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.OK;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(761, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Выбрать";
            this.ds1.DataSetName = "ds";
            this.ds1.EnforceConstraints = false;
            this.ds1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.splitter1.Location = new Point(283, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 516);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
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
            this.treeListGroup.Columns.AddRange(new TreeListColumn[2]
      {
        this.treeListColumn1,
        this.treeListColumn2
      });
            this.treeListGroup.ContextMenuStrip = this.MenuStripGroup;
            this.treeListGroup.DataMember = "goodservicegroup";
            this.treeListGroup.DataSource = (object)this.ds1;
            this.treeListGroup.Dock = DockStyle.Left;
            this.treeListGroup.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeListGroup.ImageIndexFieldName = "imageindex_";
            this.treeListGroup.KeyFieldName = "idgoodservicegroup";
            this.treeListGroup.Location = new Point(0, 0);
            this.treeListGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListGroup.Name = "treeListGroup";
            this.treeListGroup.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListGroup.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListGroup.OptionsView.ShowHorzLines = false;
            this.treeListGroup.OptionsView.ShowIndicator = false;
            this.treeListGroup.OptionsView.ShowVertLines = false;
            this.treeListGroup.ParentFieldName = "parentid";
            this.treeListGroup.SelectImageList = (object)this.imageList1;
            this.treeListGroup.Size = new Size(283, 516);
            this.treeListGroup.TabIndex = 0;
            this.treeListColumn1.Caption = "Группы услуг";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 45;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 192;
            this.treeListColumn2.Caption = "Активность";
            this.treeListColumn2.FieldName = "isactive";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 89;
            this.MenuStripGroup.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.mnuItemAddMainGroup,
        (ToolStripItem) this.mnuItemAddChildGroup,
        (ToolStripItem) this.mnuItemRenameGroup,
        (ToolStripItem) this.mnuItemDublicateGroup,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.mnuItemRemoveGroup,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.mnuItemMoveGroup
      });
            this.MenuStripGroup.Name = "contextMenuStrip2";
            this.MenuStripGroup.Size = new Size(221, 148);
            this.mnuItemAddMainGroup.Name = "mnuItemAddMainGroup";
            this.mnuItemAddMainGroup.Size = new Size(220, 22);
            this.mnuItemAddMainGroup.Text = "Добавить основную группу";
            this.mnuItemAddChildGroup.Name = "mnuItemAddChildGroup";
            this.mnuItemAddChildGroup.Size = new Size(220, 22);
            this.mnuItemAddChildGroup.Text = "Добавить дочернюю группу";
            this.mnuItemRenameGroup.Name = "mnuItemRenameGroup";
            this.mnuItemRenameGroup.Size = new Size(220, 22);
            this.mnuItemRenameGroup.Text = "Переименовать";
            this.mnuItemDublicateGroup.Name = "mnuItemDublicateGroup";
            this.mnuItemDublicateGroup.Size = new Size(220, 22);
            this.mnuItemDublicateGroup.Text = "Дублировать";
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(217, 6);
            this.mnuItemRemoveGroup.Name = "mnuItemRemoveGroup";
            this.mnuItemRemoveGroup.Size = new Size(220, 22);
            this.mnuItemRemoveGroup.Text = "Удалить";
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(217, 6);
            this.mnuItemMoveGroup.Name = "mnuItemMoveGroup";
            this.mnuItemMoveGroup.Size = new Size(220, 22);
            this.mnuItemMoveGroup.Text = "Переместить в группу";
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "Folder2.ico");
            this.gridControl1.ContextMenuStrip = this.MenuStripService;
            this.gridControl1.DataMember = "goodservicegroup.FK_goodservicegroup_goodservice";
            this.gridControl1.DataSource = (object)this.ds1;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(286, 0);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[10]
      {
        (RepositoryItem) this.repositoryItemCalcEdit1,
        (RepositoryItem) this.repositoryItemCalcEdit2,
        (RepositoryItem) this.repositoryItemCalcEdit3,
        (RepositoryItem) this.repositoryItemCalcEdit4,
        (RepositoryItem) this.repositoryItemCalcEdit5,
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.repositoryItemComboBox2,
        (RepositoryItem) this.repositoryItemComboBox3,
        (RepositoryItem) this.repositoryItemComboBox4,
        (RepositoryItem) this.repositoryItemComboBox5
      });
            this.gridControl1.Size = new Size(643, 516);
            this.gridControl1.TabIndex = 4;
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
            this.gridView1.Columns.AddRange(new GridColumn[18]
      {
        this.colidgoodservice,
        this.colname,
        this.colcomment,
        this.colsm,
        this.colperc,
        this.colgoodservicegroup,
        this.colisperc,
        this.colprice1,
        this.colvalut1_shortname,
        this.colprice2,
        this.colvalut2_shortname,
        this.colprice3,
        this.colvalut4_shortname,
        this.colprice4,
        this.colvalut3_shortname,
        this.colprice5,
        this.colvalut5_shortname,
        this.colismy
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colidgoodservice.Caption = "#";
            this.colidgoodservice.FieldName = "idgoodservice";
            this.colidgoodservice.Name = "colidgoodservice";
            this.colidgoodservice.OptionsColumn.AllowEdit = false;
            this.colidgoodservice.Visible = true;
            this.colidgoodservice.VisibleIndex = 0;
            this.colidgoodservice.Width = 47;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 194;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 5;
            this.colcomment.Width = 386;
            this.colsm.Caption = "Цена";
            this.colsm.FieldName = "sm";
            this.colsm.Name = "colsm";
            this.colsm.Visible = true;
            this.colsm.VisibleIndex = 3;
            this.colsm.Width = 99;
            this.colperc.Caption = "%";
            this.colperc.FieldName = "perc";
            this.colperc.Name = "colperc";
            this.colperc.Visible = true;
            this.colperc.VisibleIndex = 4;
            this.colperc.Width = 107;
            this.colgoodservicegroup.Caption = "Группа";
            this.colgoodservicegroup.FieldName = "goodservicegroup";
            this.colgoodservicegroup.Name = "colgoodservicegroup";
            this.colgoodservicegroup.Visible = true;
            this.colgoodservicegroup.VisibleIndex = 1;
            this.colgoodservicegroup.Width = 99;
            this.colisperc.Caption = "Только %";
            this.colisperc.FieldName = "isperc";
            this.colisperc.Name = "colisperc";
            this.colisperc.Visible = true;
            this.colisperc.VisibleIndex = 6;
            this.colprice1.Caption = "Цена 1";
            this.colprice1.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit1;
            this.colprice1.FieldName = "price1";
            this.colprice1.Name = "colprice1";
            this.colprice1.Visible = true;
            this.colprice1.VisibleIndex = 7;
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            this.colvalut1_shortname.Caption = "Валюта 1";
            this.colvalut1_shortname.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox1;
            this.colvalut1_shortname.FieldName = "valut1_shortname";
            this.colvalut1_shortname.Name = "colvalut1_shortname";
            this.colvalut1_shortname.Visible = true;
            this.colvalut1_shortname.VisibleIndex = 8;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colprice2.Caption = "Цена 2";
            this.colprice2.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit2;
            this.colprice2.FieldName = "price2";
            this.colprice2.Name = "colprice2";
            this.colprice2.Visible = true;
            this.colprice2.VisibleIndex = 9;
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            this.colvalut2_shortname.Caption = "Валюта 2";
            this.colvalut2_shortname.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox2;
            this.colvalut2_shortname.FieldName = "valut2_shortname";
            this.colvalut2_shortname.Name = "colvalut2_shortname";
            this.colvalut2_shortname.Visible = true;
            this.colvalut2_shortname.VisibleIndex = 10;
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colprice3.Caption = "Цена 3";
            this.colprice3.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit3;
            this.colprice3.FieldName = "price3";
            this.colprice3.Name = "colprice3";
            this.colprice3.Visible = true;
            this.colprice3.VisibleIndex = 11;
            this.repositoryItemCalcEdit3.AutoHeight = false;
            this.repositoryItemCalcEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit3.Name = "repositoryItemCalcEdit3";
            this.colvalut4_shortname.Caption = "Валюта 3";
            this.colvalut4_shortname.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox3;
            this.colvalut4_shortname.FieldName = "valut4_shortname";
            this.colvalut4_shortname.Name = "colvalut4_shortname";
            this.colvalut4_shortname.Visible = true;
            this.colvalut4_shortname.VisibleIndex = 12;
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            this.repositoryItemComboBox3.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colprice4.Caption = "Цена 4";
            this.colprice4.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit4;
            this.colprice4.FieldName = "price4";
            this.colprice4.Name = "colprice4";
            this.colprice4.Visible = true;
            this.colprice4.VisibleIndex = 13;
            this.repositoryItemCalcEdit4.AutoHeight = false;
            this.repositoryItemCalcEdit4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit4.Name = "repositoryItemCalcEdit4";
            this.colvalut3_shortname.Caption = "Валюта 4";
            this.colvalut3_shortname.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox4;
            this.colvalut3_shortname.FieldName = "valut3_shortname";
            this.colvalut3_shortname.Name = "colvalut3_shortname";
            this.colvalut3_shortname.Visible = true;
            this.colvalut3_shortname.VisibleIndex = 14;
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            this.repositoryItemComboBox4.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colprice5.Caption = "Цена 5";
            this.colprice5.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit5;
            this.colprice5.FieldName = "price5";
            this.colprice5.Name = "colprice5";
            this.colprice5.Visible = true;
            this.colprice5.VisibleIndex = 15;
            this.repositoryItemCalcEdit5.AutoHeight = false;
            this.repositoryItemCalcEdit5.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit5.Name = "repositoryItemCalcEdit5";
            this.colvalut5_shortname.Caption = "Валюта 5";
            this.colvalut5_shortname.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox5;
            this.colvalut5_shortname.FieldName = "valut5_shortname";
            this.colvalut5_shortname.Name = "colvalut5_shortname";
            this.colvalut5_shortname.Visible = true;
            this.colvalut5_shortname.VisibleIndex = 16;
            this.repositoryItemComboBox5.AutoHeight = false;
            this.repositoryItemComboBox5.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
            this.repositoryItemComboBox5.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colismy.Caption = "Своя";
            this.colismy.FieldName = "ismy";
            this.colismy.Name = "colismy";
            this.colismy.Visible = true;
            this.colismy.VisibleIndex = 17;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.splitter1);
            this.Controls.Add((Control)this.treeListGroup);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "GoodServiceForm";
            this.Size = new Size(929, 582);
            this.Text = "Услуги";
            this.Shown += new Shown(this.GoodServiceForm_Shown);
            this.MenuStripService.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ds1.EndInit();
            this.treeListGroup.EndInit();
            this.MenuStripGroup.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemCalcEdit1.EndInit();
            this.repositoryItemComboBox1.EndInit();
            this.repositoryItemCalcEdit2.EndInit();
            this.repositoryItemComboBox2.EndInit();
            this.repositoryItemCalcEdit3.EndInit();
            this.repositoryItemComboBox3.EndInit();
            this.repositoryItemCalcEdit4.EndInit();
            this.repositoryItemComboBox4.EndInit();
            this.repositoryItemCalcEdit5.EndInit();
            this.repositoryItemComboBox5.EndInit();
            this.ResumeLayout(false);
        }
    }
}
