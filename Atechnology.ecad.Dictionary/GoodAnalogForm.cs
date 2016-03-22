// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodAnalogForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
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
    public class GoodAnalogForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridView gridView2;
        private DataSet ds;
        private DataTable table_goodanalog;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataTable table_goodanalogdetail;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn9;
        private GridColumn colgood_marking;
        private GridColumn colgood_name;
        private GridColumn colidgoodanalog;
        private GridColumn colname;
        private GridColumn colanaloggroup;
        private GridColumn colcomment;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private TreeList treeList1;
        private TreeListColumn treeListColumn1;
        private Splitter splitter1;
        private DataColumn dataColumn13;
        private DataTable table_goodanaloggroup;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private ImageList imageList1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem8;
        private GridColumn colidgoodanaloggroup;

        public GoodAnalogForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.treeList1.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.FormClosing += new FormClosing(this.GoodAnalogForm_FormClosing);
            this.Shown += new Shown(this.GoodAnalogForm_Shown);
        }

        private void GoodAnalogForm_Shown(object sender, EventArgs e)
        {
            this.treeList1.MoveLast();
            this.treeList1.MoveFirst();
        }

        private void GoodAnalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) <= 0)
                return;
            switch (MessageBox.Show("Сохранить изменения?", "Закрытие формы аналогов материалов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.OK:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null)
                return;
            this.gridView1.Columns["idgoodanaloggroup"].FilterInfo = new ColumnFilterInfo(this.gridView1.Columns["idgoodanaloggroup"], selectedNode["idgoodanaloggroup"], "");
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from goodanaloggroup where deleted is null";
            this.db.adapter.Fill(this.table_goodanaloggroup);
            this.db.command.CommandText = "select * from goodanalog where deleted is null";
            this.db.adapter.Fill(this.table_goodanalog);
            this.db.command.CommandText = "select * from view_goodanalogdetail where deleted is null";
            this.db.adapter.Fill(this.table_goodanalogdetail);
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDataSet2(this.ds))
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

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_goodanaloggroup.NewRow();
            row["idgoodanaloggroup"] = (object)dbconn.GetGenId("gen_goodanaloggroup");
            if (InputBox.ShowDialog("Создание основной группы", "Введите имя", row["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
            this.table_goodanaloggroup.Rows.Add(row);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null)
                return;
            DataRow row = this.table_goodanaloggroup.NewRow();
            row["idgoodanaloggroup"] = (object)dbconn.GetGenId("gen_goodanaloggroup");
            if (InputBox.ShowDialog("Создание дочерней группы", "Введите имя", selectedNode["name"].ToString()) == DialogResult.Cancel)
                return;
            row["name"] = (object)InputBox.Value;
            row["parentid"] = selectedNode["idgoodanaloggroup"];
            this.table_goodanaloggroup.Rows.Add(row);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null || InputBox.ShowDialog("Изменение имени группы", "Введите новое имя", selectedNode["name"].ToString()) == DialogResult.Cancel)
                return;
            selectedNode["name"] = (object)InputBox.Value;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null)
                return;
            bool flag = false;
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_goodanaloggroup.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted && dataRow["parentid"] != DBNull.Value && (int)dataRow["parentid"] == (int)selectedNode["idgoodanaloggroup"])
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                int num = (int)MessageBox.Show("Сначало необходимо удалить вложенные группы.", "Удаление группы", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
                selectedNode.Delete();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeList1);
            if (selectedNode == null)
                return;
            DataRow row = this.table_goodanalog.NewRow();
            row["idgoodanalog"] = (object)dbconn.GetGenId("gen_goodanalog");
            row["name"] = (object)"Новый аналог";
            row["idgoodanaloggroup"] = selectedNode["idgoodanaloggroup"];
            this.table_goodanalog.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow1 == null || dataRow1.Table != this.table_goodanalog)
                return;
            GoodForm goodForm = new GoodForm();
            goodForm.IsDialog();
            if (goodForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow2 = AtGrid.getDataRow((Control)goodForm.gridControlGood);
            if (dataRow2 == null)
                return;
            DataRow row = this.table_goodanalogdetail.NewRow();
            row["idgoodanalogdetail"] = (object)dbconn.GetGenId("gen_goodanalogdetail");
            row["idgoodanalog"] = dataRow1["idgoodanalog"];
            row["idgood"] = dataRow2["idgood"];
            row["good_name"] = dataRow2["name"];
            row["good_marking"] = dataRow2["marking"];
            this.table_goodanalogdetail.Rows.Add(row);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow != null && dataRow.Table == this.table_goodanalogdetail)
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
            GridLevelNode gridLevelNode = new GridLevelNode();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GoodAnalogForm));
            this.gridView2 = new GridView();
            this.colgood_marking = new GridColumn();
            this.colgood_name = new GridColumn();
            this.gridControl1 = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_goodanalog = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.table_goodanalogdetail = new DataTable();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.table_goodanaloggroup = new DataTable();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.gridView1 = new GridView();
            this.colidgoodanalog = new GridColumn();
            this.colname = new GridColumn();
            this.colanaloggroup = new GridColumn();
            this.colcomment = new GridColumn();
            this.colidgoodanaloggroup = new GridColumn();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.treeList1 = new TreeList();
            this.treeListColumn1 = new TreeListColumn();
            this.contextMenuStrip2 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new ToolStripMenuItem();
            this.toolStripMenuItem6 = new ToolStripMenuItem();
            this.toolStripMenuItem7 = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItem8 = new ToolStripMenuItem();
            this.splitter1 = new Splitter();
            this.imageList1 = new ImageList(this.components);
            this.gridView2.BeginInit();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_goodanalog.BeginInit();
            this.table_goodanalogdetail.BeginInit();
            this.table_goodanaloggroup.BeginInit();
            this.gridView1.BeginInit();
            this.panel1.SuspendLayout();
            this.treeList1.BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.BorderStyle = BorderStyles.Simple;
            this.gridView2.Columns.AddRange(new GridColumn[2]
      {
        this.colgood_marking,
        this.colgood_name
      });
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.colgood_marking.Caption = "Артикул материала";
            this.colgood_marking.FieldName = "good_marking";
            this.colgood_marking.Name = "colgood_marking";
            this.colgood_marking.Visible = true;
            this.colgood_marking.VisibleIndex = 0;
            this.colgood_marking.Width = 252;
            this.colgood_name.Caption = "Наименование материала";
            this.colgood_name.FieldName = "good_name";
            this.colgood_name.Name = "colgood_name";
            this.colgood_name.Visible = true;
            this.colgood_name.VisibleIndex = 1;
            this.colgood_name.Width = 603;
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "goodanalog";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode.LevelTemplate = (BaseView)this.gridView2;
            gridLevelNode.RelationName = "Relation1";
            this.gridControl1.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
            this.gridControl1.Location = new Point(193, 0);
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new Size(521, 433);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gridView1,
        (BaseView) this.gridView2
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem3,
        (ToolStripItem) this.toolStripMenuItem4
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(187, 98);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(186, 22);
            this.toolStripMenuItem1.Text = "Добавить аналог";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(186, 22);
            this.toolStripMenuItem2.Text = "Удалить аналог";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(183, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(186, 22);
            this.toolStripMenuItem3.Text = "Добавить материал";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new Size(186, 22);
            this.toolStripMenuItem4.Text = "Удалить материал";
            this.toolStripMenuItem4.Click += new EventHandler(this.toolStripMenuItem4_Click);
            this.ds.DataSetName = "ds_goodanalog";
            this.ds.EnforceConstraints = false;
            this.ds.Relations.AddRange(new DataRelation[1]
      {
        new DataRelation("Relation1", "goodanalog", "goodanalogdetail", new string[1]
        {
          "idgoodanalog"
        }, new string[1]
        {
          "idgoodanalog"
        }, 0 != 0)
      });
            this.ds.Tables.AddRange(new DataTable[3]
      {
        this.table_goodanalog,
        this.table_goodanalogdetail,
        this.table_goodanaloggroup
      });
            this.table_goodanalog.Columns.AddRange(new DataColumn[5]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn9,
        this.dataColumn13
      });
            this.table_goodanalog.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodanalog"
        }, 1 != 0)
      });
            this.table_goodanalog.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_goodanalog.TableName = "goodanalog";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idgoodanalog";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "analoggroup";
            this.dataColumn9.ColumnName = "comment";
            this.dataColumn13.ColumnName = "idgoodanaloggroup";
            this.dataColumn13.DataType = typeof(int);
            this.table_goodanalogdetail.Columns.AddRange(new DataColumn[5]
      {
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8
      });
            this.table_goodanalogdetail.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodanalogdetail"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("Relation1", "goodanalog", new string[1]
        {
          "idgoodanalog"
        }, new string[1]
        {
          "idgoodanalog"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_goodanalogdetail.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn4
      };
            this.table_goodanalogdetail.TableName = "goodanalogdetail";
            this.dataColumn4.AllowDBNull = false;
            this.dataColumn4.ColumnName = "idgoodanalogdetail";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "idgoodanalog";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "idgood";
            this.dataColumn6.DataType = typeof(int);
            this.dataColumn7.ColumnName = "good_name";
            this.dataColumn7.Prefix = "local";
            this.dataColumn8.ColumnName = "good_marking";
            this.dataColumn8.Prefix = "local";
            this.table_goodanaloggroup.Columns.AddRange(new DataColumn[3]
      {
        this.dataColumn10,
        this.dataColumn11,
        this.dataColumn12
      });
            this.table_goodanaloggroup.TableName = "goodanaloggroup";
            this.dataColumn10.ColumnName = "idgoodanaloggroup";
            this.dataColumn10.DataType = typeof(int);
            this.dataColumn11.ColumnName = "parentid";
            this.dataColumn11.DataType = typeof(int);
            this.dataColumn12.ColumnName = "_imageindex";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn12.DefaultValue = (object)0;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
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
            this.gridView1.Columns.AddRange(new GridColumn[5]
      {
        this.colidgoodanalog,
        this.colname,
        this.colanaloggroup,
        this.colcomment,
        this.colidgoodanaloggroup
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colidgoodanalog.Caption = "#";
            this.colidgoodanalog.FieldName = "idgoodanalog";
            this.colidgoodanalog.Name = "colidgoodanalog";
            this.colidgoodanalog.Visible = true;
            this.colidgoodanalog.VisibleIndex = 0;
            this.colidgoodanalog.Width = 78;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 211;
            this.colanaloggroup.Caption = "Группа";
            this.colanaloggroup.FieldName = "analoggroup";
            this.colanaloggroup.Name = "colanaloggroup";
            this.colanaloggroup.Visible = true;
            this.colanaloggroup.VisibleIndex = 2;
            this.colanaloggroup.Width = 211;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 3;
            this.colcomment.Width = 212;
            this.colidgoodanaloggroup.Caption = "idgoodanaloggroup";
            this.colidgoodanaloggroup.FieldName = "idgoodanaloggroup";
            this.colidgoodanaloggroup.Name = "colidgoodanaloggroup";
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(714, 33);
            this.panel1.TabIndex = 3;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(627, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(546, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(465, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.treeList1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
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
            this.treeList1.ContextMenuStrip = this.contextMenuStrip2;
            this.treeList1.DataMember = "goodanaloggroup";
            this.treeList1.DataSource = (object)this.ds;
            this.treeList1.Dock = DockStyle.Left;
            this.treeList1.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeList1.ImageIndexFieldName = "imageindex_";
            this.treeList1.KeyFieldName = "idgoodanaloggroup";
            this.treeList1.Location = new Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AutoFocusNewNode = true;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.ParentFieldName = "parentid";
            this.treeList1.SelectImageList = (object)this.imageList1;
            this.treeList1.Size = new Size(190, 433);
            this.treeList1.TabIndex = 5;
            this.treeListColumn1.Caption = "Группы аналогов";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.MinWidth = 27;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 92;
            this.contextMenuStrip2.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.toolStripMenuItem5,
        (ToolStripItem) this.toolStripMenuItem6,
        (ToolStripItem) this.toolStripMenuItem7,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripMenuItem8
      });
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new Size(232, 98);
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new Size(231, 22);
            this.toolStripMenuItem5.Text = "Добавить основную группу";
            this.toolStripMenuItem5.Click += new EventHandler(this.toolStripMenuItem5_Click);
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new Size(231, 22);
            this.toolStripMenuItem6.Text = "Добавить дочернюю группу";
            this.toolStripMenuItem6.Click += new EventHandler(this.toolStripMenuItem6_Click);
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new Size(231, 22);
            this.toolStripMenuItem7.Text = "Переименовать";
            this.toolStripMenuItem7.Click += new EventHandler(this.toolStripMenuItem7_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(228, 6);
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new Size(231, 22);
            this.toolStripMenuItem8.Text = "Удалить";
            this.toolStripMenuItem8.Click += new EventHandler(this.toolStripMenuItem8_Click);
            this.splitter1.Location = new Point(190, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 433);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.splitter1);
            this.Controls.Add((Control)this.treeList1);
            this.Controls.Add((Control)this.panel1);
            this.Name = "GoodAnalogForm";
            this.Size = new Size(714, 466);
            this.Text = "Аналоги материалов";
            this.gridView2.EndInit();
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_goodanalog.EndInit();
            this.table_goodanalogdetail.EndInit();
            this.table_goodanaloggroup.EndInit();
            this.gridView1.EndInit();
            this.panel1.ResumeLayout(false);
            this.treeList1.EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
