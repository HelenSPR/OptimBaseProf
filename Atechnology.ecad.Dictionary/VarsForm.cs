// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.VarsForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad;
using Atechnology.ecad.Dictionary.SettingsVar;
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class VarsForm : AtUserControl
    {
        private DataRow MoveGroup;
        private DataRow[] MoveItems;
        private bool isKeyMove;
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridControl gridControlSettingVar;
        private GridView gridViewSettingVar;
        private GridColumn colname;
        private GridColumn colintvalue;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private GridColumn colstrvalue;
        private GridColumn colcomment;
        private GridColumn coltxtvalue;
        private GridColumn colblbvalue;
        private RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private GridColumn colgroupname;
        private GridColumn colidsetting;
        private GridColumn colblbvalue1;
        private RepositoryItemImageEdit repositoryItemImageEdit1;
        private GridColumn colidsettinggroup;
        private TreeList treeListGroup;
        private TreeListColumn treeListColumn1;
        private TreeListColumn treeListColumn2;
        private SplitterControl splitterControl1;
        private ContextMenuStrip contextMenuGroup;
        private ToolStripMenuItem MenuGroupAddMain;
        private ToolStripMenuItem MenuGropAddChild;
        private ToolStripMenuItem MenuGroupRename;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MenuGroupRemove;
        private ContextMenuStrip contextMenuItem;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripMenuItem MenuItemDoublicate;
        private ToolStripMenuItem MenuItemLoadBinaryFromFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemSaveToFile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuItemRemove;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MenuItemMove;
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
        private ImageList imageListGroup;
        private DataColumn dataColumn9;
        private GridColumn coldtvalue;
        private RepositoryItemDateEdit repositoryItemDateEdit1;
        private ToolStripMenuItem MenuGroupDublicate;
        private ToolStripMenuItem MenuGroupMove;
        private ToolStripMenuItem MenuGroupSetMain;
        private ToolStripSeparator toolStripSeparator5;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private GridColumn coladdorder;
        private GridColumn coladdmodel;
        private DataColumn dataColumn19;
        private GridColumn colintvalue2;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem MenuItemEditTable;
        private ToolStripMenuItem MenuItemEditCustomTable;
        private ToolStripMenuItem MenuItemSaveToXmlCustomTable;
        private ToolStripMenuItem MenuItemLoadFromXmlCustomTable;
        private ToolStripSeparator toolStripSeparator7;
        private GridColumn colcustomtable;
        private DataColumn dataColumn20;

        public VarsForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.Shown += new Shown(this.VarsForm_Shown);
            this.treeListGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListGroup_FocusedNodeChanged);
            this.treeListGroup.KeyDown += new KeyEventHandler(this.treeListGroup_KeyDown);
            this.FormClosing += new FormClosing(this.VarsForm_FormClosing);
            this.MenuGroupDublicate.Click += new EventHandler(this.MenuGroupDublicate_Click);
            this.MenuGroupMove.Click += new EventHandler(this.MenuGroupMoveToGroup_Click);
            this.MenuGroupSetMain.Click += new EventHandler(this.MenuGroupSetMain_Click);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && (this.MoveItems != null || this.MoveGroup != null))
            {
                this.MoveItems = (DataRow[])null;
                this.MoveGroup = (DataRow)null;
                this.Cursor = Cursors.Default;
            }
            else if (keyData == Keys.Return && (this.MoveItems != null || this.MoveGroup != null))
                this.MoveElements();
            else if (this.treeListGroup.Focused)
                this.isKeyMove = true;
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void treeListGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.treeListGroup.Focused && (this.MoveItems != null || this.MoveGroup != null))
                this.treeListGroup_FocusedNodeChanged((object)null, (FocusedNodeChangedEventArgs)null);
            else
                TreeList_KeyDown.Key(this.treeListGroup, e.KeyCode);
        }

        private void treeListGroup_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (!this.isKeyMove)
                this.MoveElements();
            this.isKeyMove = false;
        }

        private void VarsForm_Shown(object sender, EventArgs e)
        {
            this.treeListGroup.MoveLastVisible();
            this.treeListGroup.MoveFirst();
        }

        private void VarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) <= 0)
                return;
            switch (MessageBox.Show("Данные справочника были изменены! Сохранить изменения?", "Закрытие формы справочника переменных", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        public override void LoadFromBase()
        {
            this.treeListGroup.DataSource = (object)null;
            this.ds.Clear();
            this.db.command.Parameters.Clear();
            this.db.command.CommandText = "select * from settinggroup where deleted is null";
            this.db.adapter.Fill(this.table_settinggroup);
            this.db.command.CommandText = "select * from view_setting where deleted is null";
            this.db.adapter.Fill(this.table_setting);
            this.treeListGroup.DataSource = (object)this.ds;
        }

        public override bool SaveToBase()
        {
            this.treeListGroup.DataSource = (object)null;
            try
            {
                if (!this.db.SaveDatatable2(this.table_settinggroup) || !this.db.SaveDatatable(this.table_setting))
                    return false;
                this.table_settinggroup.AcceptChanges();
                this.table_setting.AcceptChanges();
                Settings.LoadSetVars(this.db);
                return true;
            }
            finally
            {
                this.treeListGroup.DataSource = (object)this.ds;
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlSettingVar);
            if (dataRow == null)
                return;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, (int)fileStream.Length);
            fileStream.Close();
            dataRow["blbvalue"] = (object)buffer;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            DataRow row = this.table_setting.NewRow();
            row["idsetting"] = (object)dbconn.GetGenId("gen_setting");
            row["name"] = (object)"Новая переменная";
            row["idsettinggroup"] = selectedNode["idsettinggroup"];
            row["addmodel"] = (object)false;
            row["addorder"] = (object)false;
            this.table_setting.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlSettingVar);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            int num = dbconn.GetGenId("gen_setting", selectedDataRows.Length) - selectedDataRows.Length + 1;
            foreach (DataRow source in selectedDataRows)
                AtDataSet.dublicate(source)["idsetting"] = (object)num++;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML file|*.xml";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.table_setting.WriteXml(saveFileDialog.FileName);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in AtGrid.getSelectedDataRows((Control)this.gridControlSettingVar))
                dataRow.Delete();
        }

        private void MenuItemMove_Click(object sender, EventArgs e)
        {
            this.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlSettingVar);
            if (this.MoveItems == null || this.MoveItems.Length == 0)
            {
                this.MoveItems = (DataRow[])null;
            }
            else
            {
                this.treeListGroup.Focus();
                this.Cursor = Cursors.Hand;
                this.isKeyMove = false;
            }
        }

        private void MenuGroupAddMain_Click(object sender, EventArgs e)
        {
            if (InputBox.ShowDialog("Создание основной группы", "Введите наименование", "Новая группа") != DialogResult.OK)
                return;
            DataRow row = this.table_settinggroup.NewRow();
            this.table_settinggroup.Rows.Add(row);
            row["idsettinggroup"] = (object)dbconn.GetGenId("gen_settinggroup");
            row["name"] = (object)InputBox.Value;
            row["isactive"] = (object)0;
        }

        private void MenuGroupAddChild_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null || InputBox.ShowDialog("Создание дочерней группы", "Введите наименование", "Новая группа") != DialogResult.OK)
                return;
            DataRow row = this.table_settinggroup.NewRow();
            this.table_settinggroup.Rows.Add(row);
            row["idsettinggroup"] = (object)dbconn.GetGenId("gen_settinggroup");
            row["name"] = (object)InputBox.Value;
            row["isactive"] = (object)0;
            row["parentid"] = selectedNode["idsettinggroup"];
        }

        private void MenuGroupRename_Click(object sender, EventArgs e)
        {
            if (this.treeListGroup.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeListGroup.GetDataRecordByNode(this.treeListGroup.Selection[0])).Row;
            if (InputBox.ShowDialog("Изменить имя", "Введите новое имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
        }

        private void MenuGroupRemove_Click(object sender, EventArgs e)
        {
            if (this.treeListGroup.Selection.Count == 0)
                return;
            DataRow row = ((DataRowView)this.treeListGroup.GetDataRecordByNode(this.treeListGroup.Selection[0])).Row;
            foreach (DataRow dataRow1 in AtTreeList.GetListNodesRows(this.treeListGroup, this.treeListGroup.FocusedNode))
            {
                foreach (DataRow dataRow2 in this.table_setting.Select("idsettinggroup = " + dataRow1["idsettinggroup"].ToString()))
                    dataRow2.Delete();
                dataRow1.Delete();
            }
        }

        private void MenuGroupDublicate_Click(object sender, EventArgs e)
        {
            List<int[]> ListID = new List<int[]>();
            if (this.treeListGroup.Selection.Count == 0)
                return;
            List<DataRow> listNodesRows = AtTreeList.GetListNodesRows(this.treeListGroup, this.treeListGroup.Selection[0]);
            if (listNodesRows == null || listNodesRows.Count == 0)
                return;
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
                    int genId = dbconn.GetGenId("gen_settinggroup");
                    dataRow1["idsettinggroup"] = (object)genId;
                    if (parentId != 0)
                        dataRow1["parentid"] = (object)parentId;
                    ListID.Add(new int[2]
          {
            Convert.ToInt32(source1["idsettinggroup"]),
            genId
          });
                    foreach (DataRow source2 in this.table_setting.Select("idsettinggroup = " + source1["idsettinggroup"].ToString()))
                    {
                        if (source2.RowState != DataRowState.Deleted)
                        {
                            DataRow dataRow2 = AtDataSet.dublicate(source2);
                            dataRow2["idsetting"] = (object)dbconn.GetGenId("gen_setting");
                            dataRow2["idsettinggroup"] = (object)genId;
                        }
                    }
                }
            }
        }

        private void MenuGroupSetMain_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            selectedNode["parentid"] = (object)DBNull.Value;
        }

        private void MenuGroupMoveToGroup_Click(object sender, EventArgs e)
        {
            this.MoveGroup = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (this.MoveGroup != null)
                this.Cursor = Cursors.Hand;
            this.isKeyMove = false;
        }

        private void MoveElements()
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            if (this.MoveGroup != null)
            {
                if (this.MoveGroup != selectedNode)
                    this.MoveGroup["parentid"] = selectedNode["idsettinggroup"];
                this.Cursor = Cursors.Default;
                this.MoveGroup = (DataRow)null;
            }
            if (this.MoveItems == null)
                return;
            foreach (DataRow dataRow in this.MoveItems)
                dataRow["idsettinggroup"] = selectedNode["idsettinggroup"];
            this.Cursor = Cursors.Default;
            this.MoveItems = (DataRow[])null;
            GC.Collect();
            GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemEditTable_Click(object sender, EventArgs e)
        {
            int num = (int)new EditTableInSettingForm(AtGrid.getDataRow((Control)this.gridControlSettingVar)).ShowDialog();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            string str = string.Empty;
            EditUserTableInSettingForm tableInSettingForm = new EditUserTableInSettingForm(AtGrid.getDataRow((Control)this.gridControlSettingVar));
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlSettingVar);
            if (dataRow != null && DBNull.Value != dataRow["name"])
                str = dataRow["name"].ToString();
            tableInSettingForm.Text = string.Format("[{0}] - произвольная таблица", (object)str);
            MdiManager.Add((Control)tableInSettingForm);
        }

        private void MenuItemSaveToXmlCustomTable_Click(object sender, EventArgs e)
        {
            EditUserTableInSettingForm.SaveToXml(AtGrid.getDataRow((Control)this.gridControlSettingVar));
        }

        private void MenuItemLoadFromXmlCustomTable_Click(object sender, EventArgs e)
        {
            DataSet dataSet = EditUserTableInSettingForm.LoadFromXml();
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlSettingVar);
            if (dataSet == null)
                return;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                dataSet.WriteXml((Stream)memoryStream, XmlWriteMode.WriteSchema);
                dataRow["customtable"] = (object)Atechnology.Components.ZipArchiver.Zip(memoryStream.ToArray());
            }
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(VarsForm));
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.gridControlSettingVar = new GridControl();
            this.contextMenuItem = new ContextMenuStrip(this.components);
            this.MenuItemAdd = new ToolStripMenuItem();
            this.MenuItemDoublicate = new ToolStripMenuItem();
            this.toolStripSeparator6 = new ToolStripSeparator();
            this.MenuItemLoadBinaryFromFile = new ToolStripMenuItem();
            this.MenuItemEditTable = new ToolStripMenuItem();
            this.toolStripSeparator7 = new ToolStripSeparator();
            this.MenuItemEditCustomTable = new ToolStripMenuItem();
            this.MenuItemSaveToXmlCustomTable = new ToolStripMenuItem();
            this.MenuItemLoadFromXmlCustomTable = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemSaveToFile = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.MenuItemMove = new ToolStripMenuItem();
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
            this.dataColumn20 = new DataColumn();
            this.gridViewSettingVar = new GridView();
            this.colname = new GridColumn();
            this.colintvalue = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.colintvalue2 = new GridColumn();
            this.colstrvalue = new GridColumn();
            this.colcomment = new GridColumn();
            this.coltxtvalue = new GridColumn();
            this.colblbvalue = new GridColumn();
            this.repositoryItemMemoExEdit1 = new RepositoryItemMemoExEdit();
            this.colgroupname = new GridColumn();
            this.colidsetting = new GridColumn();
            this.colblbvalue1 = new GridColumn();
            this.repositoryItemImageEdit1 = new RepositoryItemImageEdit();
            this.colidsettinggroup = new GridColumn();
            this.coldtvalue = new GridColumn();
            this.repositoryItemDateEdit1 = new RepositoryItemDateEdit();
            this.coladdorder = new GridColumn();
            this.coladdmodel = new GridColumn();
            this.colcustomtable = new GridColumn();
            this.treeListGroup = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.treeListColumn2 = new TreeListColumn();
            this.contextMenuGroup = new ContextMenuStrip(this.components);
            this.MenuGroupAddMain = new ToolStripMenuItem();
            this.MenuGropAddChild = new ToolStripMenuItem();
            this.MenuGroupDublicate = new ToolStripMenuItem();
            this.MenuGroupRename = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.MenuGroupMove = new ToolStripMenuItem();
            this.MenuGroupSetMain = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.MenuGroupRemove = new ToolStripMenuItem();
            this.imageListGroup = new ImageList(this.components);
            this.splitterControl1 = new SplitterControl();
            this.panel1.SuspendLayout();
            this.gridControlSettingVar.BeginInit();
            this.contextMenuItem.SuspendLayout();
            this.ds.BeginInit();
            this.table_settinggroup.BeginInit();
            this.table_setting.BeginInit();
            this.gridViewSettingVar.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemMemoExEdit1.BeginInit();
            this.repositoryItemImageEdit1.BeginInit();
            this.repositoryItemDateEdit1.BeginInit();
            this.repositoryItemDateEdit1.VistaTimeProperties.BeginInit();
            this.treeListGroup.BeginInit();
            this.contextMenuGroup.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(891, 33);
            this.panel1.TabIndex = 2;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(804, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(723, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(642, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControlSettingVar.ContextMenuStrip = this.contextMenuItem;
            this.gridControlSettingVar.DataMember = "settinggroup.FK_setting_settinggroup";
            this.gridControlSettingVar.DataSource = (object)this.ds;
            this.gridControlSettingVar.Dock = DockStyle.Fill;
            this.gridControlSettingVar.EmbeddedNavigator.Name = "";
            this.gridControlSettingVar.Location = new Point(216, 0);
            this.gridControlSettingVar.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlSettingVar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlSettingVar.MainView = (BaseView)this.gridViewSettingVar;
            this.gridControlSettingVar.Name = "gridControlSettingVar";
            this.gridControlSettingVar.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemMemoExEdit1,
        (RepositoryItem) this.repositoryItemImageEdit1,
        (RepositoryItem) this.repositoryItemDateEdit1
      });
            this.gridControlSettingVar.Size = new Size(675, 308);
            this.gridControlSettingVar.TabIndex = 4;
            this.gridControlSettingVar.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewSettingVar
      });
            this.contextMenuItem.Items.AddRange(new ToolStripItem[15]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.MenuItemDoublicate,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.MenuItemLoadBinaryFromFile,
        (ToolStripItem) this.MenuItemEditTable,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.MenuItemEditCustomTable,
        (ToolStripItem) this.MenuItemSaveToXmlCustomTable,
        (ToolStripItem) this.MenuItemLoadFromXmlCustomTable,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemSaveToFile,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemRemove,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.MenuItemMove
      });
            this.contextMenuItem.Name = "contextMenuStrip1";
            this.contextMenuItem.Size = new Size(280, 254);
            this.MenuItemAdd.ImageTransparentColor = Color.Magenta;
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAdd.Size = new Size(279, 22);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemAdd.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.MenuItemDoublicate.ImageTransparentColor = Color.Magenta;
            this.MenuItemDoublicate.Name = "MenuItemDoublicate";
            this.MenuItemDoublicate.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.MenuItemDoublicate.Size = new Size(279, 22);
            this.MenuItemDoublicate.Text = "Дублировать";
            this.MenuItemDoublicate.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new Size(276, 6);
            this.MenuItemLoadBinaryFromFile.Name = "MenuItemLoadBinaryFromFile";
            this.MenuItemLoadBinaryFromFile.Size = new Size(279, 22);
            this.MenuItemLoadBinaryFromFile.Text = "Загрузить из файла бинарик";
            this.MenuItemLoadBinaryFromFile.Click += new EventHandler(this.toolStripMenuItem7_Click);
            this.MenuItemEditTable.Name = "MenuItemEditTable";
            this.MenuItemEditTable.Size = new Size(279, 22);
            this.MenuItemEditTable.Text = "Редактировать таблицу";
            this.MenuItemEditTable.Click += new EventHandler(this.MenuItemEditTable_Click);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new Size(276, 6);
            this.MenuItemEditCustomTable.Name = "MenuItemEditCustomTable";
            this.MenuItemEditCustomTable.Size = new Size(279, 22);
            this.MenuItemEditCustomTable.Text = "Редактировать произвольную таблицу";
            this.MenuItemEditCustomTable.Click += new EventHandler(this.toolStripMenuItem1_Click_1);
            this.MenuItemSaveToXmlCustomTable.Name = "MenuItemSaveToXmlCustomTable";
            this.MenuItemSaveToXmlCustomTable.Size = new Size(279, 22);
            this.MenuItemSaveToXmlCustomTable.Text = "Сохранить произвольную таблицу в xml";
            this.MenuItemSaveToXmlCustomTable.Click += new EventHandler(this.MenuItemSaveToXmlCustomTable_Click);
            this.MenuItemLoadFromXmlCustomTable.Name = "MenuItemLoadFromXmlCustomTable";
            this.MenuItemLoadFromXmlCustomTable.Size = new Size(279, 22);
            this.MenuItemLoadFromXmlCustomTable.Text = "Загрузка произвольной таблицы из xml";
            this.MenuItemLoadFromXmlCustomTable.Click += new EventHandler(this.MenuItemLoadFromXmlCustomTable_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(276, 6);
            this.MenuItemSaveToFile.Name = "MenuItemSaveToFile";
            this.MenuItemSaveToFile.Size = new Size(279, 22);
            this.MenuItemSaveToFile.Text = "Сохранить все в файл";
            this.MenuItemSaveToFile.Click += new EventHandler(this.toolStripMenuItem6_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(276, 6);
            this.MenuItemRemove.ImageTransparentColor = Color.Magenta;
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(279, 22);
            this.MenuItemRemove.Text = "Удалить";
            this.MenuItemRemove.Click += new EventHandler(this.toolStripMenuItem5_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(276, 6);
            this.MenuItemMove.Name = "MenuItemMove";
            this.MenuItemMove.ShortcutKeys = Keys.F6;
            this.MenuItemMove.Size = new Size(279, 22);
            this.MenuItemMove.Text = "Переместить в группу...";
            this.MenuItemMove.Click += new EventHandler(this.MenuItemMove_Click);
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
            this.table_setting.Columns.AddRange(new DataColumn[14]
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
        this.dataColumn19,
        this.dataColumn20
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
            this.dataColumn20.ColumnName = "hascustomtable";
            this.dataColumn20.DataType = typeof(bool);
            this.gridViewSettingVar.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewSettingVar.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewSettingVar.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewSettingVar.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewSettingVar.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewSettingVar.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewSettingVar.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewSettingVar.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewSettingVar.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewSettingVar.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSettingVar.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewSettingVar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewSettingVar.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewSettingVar.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewSettingVar.BorderStyle = BorderStyles.Simple;
            this.gridViewSettingVar.Columns.AddRange(new GridColumn[15]
      {
        this.colname,
        this.colintvalue,
        this.colintvalue2,
        this.colstrvalue,
        this.colcomment,
        this.coltxtvalue,
        this.colblbvalue,
        this.colgroupname,
        this.colidsetting,
        this.colblbvalue1,
        this.colidsettinggroup,
        this.coldtvalue,
        this.coladdorder,
        this.coladdmodel,
        this.colcustomtable
      });
            this.gridViewSettingVar.GridControl = this.gridControlSettingVar;
            this.gridViewSettingVar.GroupPanelText = "Панель группировки";
            this.gridViewSettingVar.Name = "gridViewSettingVar";
            this.gridViewSettingVar.OptionsCustomization.AllowFilter = false;
            this.gridViewSettingVar.OptionsDetail.ShowDetailTabs = false;
            this.gridViewSettingVar.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewSettingVar.OptionsSelection.MultiSelect = true;
            this.gridViewSettingVar.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewSettingVar.OptionsView.ShowIndicator = false;
            this.colname.Caption = "Имя";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 45;
            this.colintvalue.Caption = "Число 1";
            this.colintvalue.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colintvalue.FieldName = "intvalue";
            this.colintvalue.Name = "colintvalue";
            this.colintvalue.Visible = true;
            this.colintvalue.VisibleIndex = 2;
            this.colintvalue.Width = 67;
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
            this.colintvalue2.Width = 55;
            this.colstrvalue.Caption = "Строка";
            this.colstrvalue.FieldName = "strvalue";
            this.colstrvalue.Name = "colstrvalue";
            this.colstrvalue.Visible = true;
            this.colstrvalue.VisibleIndex = 4;
            this.colstrvalue.Width = 39;
            this.colcomment.Caption = "Описание";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 8;
            this.colcomment.Width = 53;
            this.coltxtvalue.Caption = "Текст";
            this.coltxtvalue.FieldName = "txtvalue";
            this.coltxtvalue.Name = "coltxtvalue";
            this.coltxtvalue.Visible = true;
            this.coltxtvalue.VisibleIndex = 5;
            this.coltxtvalue.Width = 39;
            this.colblbvalue.Caption = "Бинарик";
            this.colblbvalue.ColumnEdit = (RepositoryItem)this.repositoryItemMemoExEdit1;
            this.colblbvalue.FieldName = "blbvalue";
            this.colblbvalue.Name = "colblbvalue";
            this.colblbvalue.Visible = true;
            this.colblbvalue.VisibleIndex = 6;
            this.colblbvalue.Width = 72;
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.colgroupname.Caption = "Группа";
            this.colgroupname.FieldName = "groupname";
            this.colgroupname.Name = "colgroupname";
            this.colgroupname.Visible = true;
            this.colgroupname.VisibleIndex = 9;
            this.colgroupname.Width = 43;
            this.colidsetting.Caption = "#";
            this.colidsetting.FieldName = "idsetting";
            this.colidsetting.Name = "colidsetting";
            this.colidsetting.OptionsColumn.AllowEdit = false;
            this.colidsetting.Visible = true;
            this.colidsetting.VisibleIndex = 0;
            this.colidsetting.Width = 27;
            this.colblbvalue1.Caption = "Картинка";
            this.colblbvalue1.ColumnEdit = (RepositoryItem)this.repositoryItemImageEdit1;
            this.colblbvalue1.FieldName = "blbvalue";
            this.colblbvalue1.Name = "colblbvalue1";
            this.colblbvalue1.Visible = true;
            this.colblbvalue1.VisibleIndex = 7;
            this.colblbvalue1.Width = 74;
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.colidsettinggroup.Caption = "idsettinggroup";
            this.colidsettinggroup.FieldName = "idsettinggroup";
            this.colidsettinggroup.Name = "colidsettinggroup";
            this.coldtvalue.Caption = "Дата";
            this.coldtvalue.ColumnEdit = (RepositoryItem)this.repositoryItemDateEdit1;
            this.coldtvalue.FieldName = "dtvalue";
            this.coldtvalue.Name = "coldtvalue";
            this.coldtvalue.Visible = true;
            this.coldtvalue.VisibleIndex = 10;
            this.coldtvalue.Width = 36;
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
            this.coladdorder.Caption = "Добавлять в заказ";
            this.coladdorder.FieldName = "addorder";
            this.coladdorder.Name = "coladdorder";
            this.coladdorder.Visible = true;
            this.coladdorder.VisibleIndex = 11;
            this.coladdorder.Width = 20;
            this.coladdmodel.Caption = "Добавлять в модель";
            this.coladdmodel.FieldName = "addmodel";
            this.coladdmodel.Name = "coladdmodel";
            this.coladdmodel.Visible = true;
            this.coladdmodel.VisibleIndex = 12;
            this.coladdmodel.Width = 54;
            this.colcustomtable.Caption = "Произвольная таблица";
            this.colcustomtable.FieldName = "hascustomtable";
            this.colcustomtable.Name = "colcustomtable";
            this.colcustomtable.OptionsColumn.AllowEdit = false;
            this.colcustomtable.OptionsColumn.ReadOnly = true;
            this.colcustomtable.Visible = true;
            this.colcustomtable.VisibleIndex = 13;
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
            this.treeListGroup.ContextMenuStrip = this.contextMenuGroup;
            this.treeListGroup.DataMember = "settinggroup";
            this.treeListGroup.DataSource = (object)this.ds;
            this.treeListGroup.Dock = DockStyle.Left;
            this.treeListGroup.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeListGroup.ImageIndexFieldName = "_image";
            this.treeListGroup.KeyFieldName = "idsettinggroup";
            this.treeListGroup.Location = new Point(0, 0);
            this.treeListGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListGroup.Name = "treeListGroup";
            this.treeListGroup.OptionsView.ShowHorzLines = false;
            this.treeListGroup.OptionsView.ShowIndicator = false;
            this.treeListGroup.OptionsView.ShowVertLines = false;
            this.treeListGroup.ParentFieldName = "parentid";
            this.treeListGroup.SelectImageList = (object)this.imageListGroup;
            this.treeListGroup.Size = new Size(210, 308);
            this.treeListGroup.TabIndex = 5;
            this.treeListColumn1.Caption = "Группы переменных";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 28;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 167;
            this.treeListColumn2.Caption = "Активность";
            this.treeListColumn2.FieldName = "isactive";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 90;
            this.contextMenuGroup.Items.AddRange(new ToolStripItem[9]
      {
        (ToolStripItem) this.MenuGroupAddMain,
        (ToolStripItem) this.MenuGropAddChild,
        (ToolStripItem) this.MenuGroupDublicate,
        (ToolStripItem) this.MenuGroupRename,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.MenuGroupMove,
        (ToolStripItem) this.MenuGroupSetMain,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.MenuGroupRemove
      });
            this.contextMenuGroup.Name = "contextMenuStrip2";
            this.contextMenuGroup.Size = new Size(298, 170);
            this.MenuGroupAddMain.Name = "MenuGroupAddMain";
            this.MenuGroupAddMain.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuGroupAddMain.Size = new Size(297, 22);
            this.MenuGroupAddMain.Text = "Добавить основную группу";
            this.MenuGroupAddMain.Click += new EventHandler(this.MenuGroupAddMain_Click);
            this.MenuGropAddChild.Name = "MenuGropAddChild";
            this.MenuGropAddChild.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuGropAddChild.Size = new Size(297, 22);
            this.MenuGropAddChild.Text = "Добавить дочернюю группу";
            this.MenuGropAddChild.Click += new EventHandler(this.MenuGroupAddChild_Click);
            this.MenuGroupDublicate.Name = "MenuGroupDublicate";
            this.MenuGroupDublicate.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.MenuGroupDublicate.Size = new Size(297, 22);
            this.MenuGroupDublicate.Text = "Дублировать";
            this.MenuGroupRename.Name = "MenuGroupRename";
            this.MenuGroupRename.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuGroupRename.Size = new Size(297, 22);
            this.MenuGroupRename.Text = "Переименовать";
            this.MenuGroupRename.Click += new EventHandler(this.MenuGroupRename_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(294, 6);
            this.MenuGroupMove.Name = "MenuGroupMove";
            this.MenuGroupMove.ShortcutKeys = Keys.F6;
            this.MenuGroupMove.Size = new Size(297, 22);
            this.MenuGroupMove.Text = "Переместить в группу";
            this.MenuGroupSetMain.Name = "MenuGroupSetMain";
            this.MenuGroupSetMain.ShortcutKeys = Keys.M | Keys.Shift | Keys.Control;
            this.MenuGroupSetMain.Size = new Size(297, 22);
            this.MenuGroupSetMain.Text = "Сделать основной";
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(294, 6);
            this.MenuGroupRemove.Name = "MenuGroupRemove";
            this.MenuGroupRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuGroupRemove.Size = new Size(297, 22);
            this.MenuGroupRemove.Text = "Удалить";
            this.MenuGroupRemove.Click += new EventHandler(this.MenuGroupRemove_Click);
            this.imageListGroup.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListGroup.ImageStream");
            this.imageListGroup.TransparentColor = Color.Magenta;
            this.imageListGroup.Images.SetKeyName(0, "Folder.ico");
            this.splitterControl1.Location = new Point(210, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 308);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlSettingVar);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeListGroup);
            this.Controls.Add((Control)this.panel1);
            this.Name = "VarsForm";
            this.Size = new Size(891, 341);
            this.Text = "Переменные";
            this.panel1.ResumeLayout(false);
            this.gridControlSettingVar.EndInit();
            this.contextMenuItem.ResumeLayout(false);
            this.ds.EndInit();
            this.table_settinggroup.EndInit();
            this.table_setting.EndInit();
            this.gridViewSettingVar.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemMemoExEdit1.EndInit();
            this.repositoryItemImageEdit1.EndInit();
            this.repositoryItemDateEdit1.VistaTimeProperties.EndInit();
            this.repositoryItemDateEdit1.EndInit();
            this.treeListGroup.EndInit();
            this.contextMenuGroup.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
