// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodBufferForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.Utils;
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
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class GoodBufferForm : AtUserControl
    {
        private Dictionary<string, object> enumValuesHash = new Dictionary<string, object>();
        private int id;
        private DataRow goodRow;
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridControl gcGoodBuffer;
        private GridView gvGoodBuffer;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private GridView gridView2;
        private GridColumn colgood_marking;
        private GridColumn colgood_name;
        private GridColumn colqu;
        private GridColumn colthick;
        private GridColumn colheight;
        private GridColumn colwidth;
        private GridColumn colweight;
        private DataSet ds;
        private DataTable table_goodbuffer;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn9;
        private GridColumn colidgoodbuffer;
        private GridColumn colheight1;
        private RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private GridColumn colwidth1;
        private RepositoryItemCalcEdit repositoryItemCalcEdit3;
        private GridColumn colweight1;
        private RepositoryItemCalcEdit repositoryItemCalcEdit4;
        private GridColumn colcomment;
        private GridColumn colthick1;
        private RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private GridColumn colmarking;
        private ContextMenuStrip cmsGood;
        private ToolStripMenuItem tsmiAddGood;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private GridColumn col_goodname;
        private GridColumn col_goodmarking;
        private Splitter splitter1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DataTable table_good;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private TreeListColumn treeListColumn3;
        private TreeListColumn treeListColumn1;
        private TreeListColumn treeListColumn2;
        private ImageList imageList1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DataColumn dataColumn20;
        private GridColumn colbarcode;
        private DataColumn dataColumn21;
        private GridColumn colstatus;
        private RepositoryItemComboBox colstatusEditor;
        private GridControl gcGoods;
        private GridView gvGoods;
        private GridColumn colidgood;
        private RepositoryItemCalcEdit repositoryItemCalcEdit5;
        private RepositoryItemCalcEdit repositoryItemCalcEdit6;
        private RepositoryItemCalcEdit repositoryItemCalcEdit7;
        private RepositoryItemCalcEdit repositoryItemCalcEdit8;
        private GridColumn colgoodmarking;
        private GridColumn colgoodmeasure;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private AtRepositoryItemTextEdit atRepositoryItemTextEdit1;
        private GridView gridView4;
        private GridColumn gridColumn12;
        private GridColumn gridColumn13;
        private GridColumn gridColumn14;
        private GridColumn gridColumn15;
        private GridColumn gridColumn16;
        private GridColumn gridColumn17;
        private GridColumn gridColumn18;
        private DataColumn dataColumn14;
        private DataColumn dataColumn15;
        private GridColumn colgoodname;
        private ContextMenuStrip cmsGoodBuffer;
        private ToolStripMenuItem tsmiAddGoodBuffer;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmiDeleteGoodBuffer;
        private GridColumn colidgood_buffer;
        private DataColumn dataColumn16;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private GridColumn colrow;
        private GridColumn colcell;
        private DataColumn dataColumn19;
        private DataColumn dataColumn22;
        private DataColumn dataColumn23;
        private DataColumn dataColumn24;
        private GridColumn colcolor1_name;
        private GridColumn colcolor2_name;
        private RepositoryItemTextEdit repositoryItemTextEdit2;
        private atColorPopUpContainer repositoryItemPopupContainerEdit_Color1;
        private atColorPopUpContainer repositoryItemPopupContainerEdit_Color2;

        public GoodBufferForm(int idgood, string Caption)
            : this(idgood)
        {
            GoodBufferForm goodBufferForm = this;
            string str = goodBufferForm.Text + " " + Caption;
            goodBufferForm.Text = str;
        }

        public GoodBufferForm(int idgood)
        {
            this.InitializeComponent();
            this.id = idgood;
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.GoodBufferForm_FormClosing);
            this.colstatusEditor.SelectedValueChanged += new EventHandler(this.colstatusEditor_SelectedValueChanged);
            this.colstatusEditor.Items.Clear();
            this.colstatusEditor.Items.Add((object)string.Empty);
            this.enumValuesHash.Add(string.Empty, (object)DBNull.Value);
            foreach (object obj in Enum.GetValues(typeof(GoodBufferUtils.GoodBufferType)))
            {
                string displayName = EnumUtils.GetDisplayName((Enum)obj);
                this.colstatusEditor.Items.Add((object)displayName);
                this.enumValuesHash.Add(displayName, (object)(int)obj);
            }
        }

        public GoodBufferForm(int idgood, bool isDialog)
            : this(idgood)
        {
            if (!isDialog)
                return;
            this.panel1.Visible = false;
            this.Is_Dialog = isDialog;
        }

        private void colstatusEditor_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBoxEdit = sender as ComboBoxEdit;
            DataRow dataRow = AtGrid.getDataRow((Control)this.gcGoodBuffer);
            if (comboBoxEdit == null || dataRow == null)
                return;
            string selectedText = comboBoxEdit.SelectedText;
            if (!this.enumValuesHash.ContainsKey(selectedText))
                return;
            dataRow["status"] = this.enumValuesHash[selectedText];
        }

        private void GoodBufferForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataTable(this.table_goodbuffer) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        private void LoadGood()
        {
            if (this.id < 0)
            {
                this.splitter1.Visible = true;
                this.gcGoods.Visible = true;
                this.table_good.Clear();
                this.db.command.CommandText = " select idgood, name, marking, measure_shortname from view_good\r\n                                            where deleted is null and \r\n                                            idgood in (\r\n                                                select distinct idgood from goodbuffer where deleted is null\r\n                                                   )";
                this.db.adapter.Fill(this.table_good);
            }
            else
            {
                this.splitter1.Visible = false;
                this.gcGoods.Visible = false;
            }
        }

        private void LoadGoodBuffer()
        {
            if (this.id <= 0)
                return;
            string str = "select * from view_goodbuffer where deleted is null " + (object)" and idgood = " + (string)(object)this.id;
            this.db.command.CommandText = "select * from view_good where idgood = " + (object)this.id;
            DataTable table = new DataTable();
            this.db.adapter.Fill(table);
            if (table.Rows.Count > 0)
                this.goodRow = table.Rows[0];
            this.db.command.CommandText = str;
            this.db.adapter.Fill(this.table_goodbuffer);
        }

        public override void LoadFromBase()
        {
            this.LoadGood();
            this.LoadGoodBuffer();
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDatatable2(this.table_goodbuffer))
                return false;
            this.table_goodbuffer.AcceptChanges();
            return true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow dataRow = (DataRow)null;
            if (!this.Is_Dialog)
            {
                GoodForm goodForm = new GoodForm(false);
                goodForm.IsDialog();
                if (goodForm.ShowDialog(goodForm.DefaultButton, goodForm.CancelButton) != DialogResult.OK)
                    return;
                dataRow = AtGrid.getDataRow((Control)goodForm.gridControlGood);
                if (dataRow == null)
                    return;
                if (!this.table_good.Rows.Contains(dataRow["idgood"]))
                {
                    DataRow row = this.table_good.NewRow();
                    row["idgood"] = dataRow["idgood"];
                    row["name"] = dataRow["name"];
                    row["marking"] = dataRow["marking"];
                    row["measure_shortname"] = dataRow["measure_shortname"];
                    this.table_good.Rows.Add(row);
                }
            }
            this.AddGoodBuffer((int)dataRow["idgood"], true);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds.Clear();
            this.LoadFromBase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        public void IsDialog()
        {
            this.Is_Dialog = true;
            this.panel1.Visible = false;
            this.gcGoodBuffer.ContextMenuStrip = (ContextMenuStrip)null;
        }

        private void UpdateGoodBuffer()
        {
            if (!this.gcGoods.Visible)
                return;
            this.SaveToBase();
            DataRow dataRow = AtGrid.getDataRow((Control)this.gcGoods);
            if (dataRow == null)
                return;
            this.table_goodbuffer.Clear();
            int num = (int)dataRow["idgood"];
            string str = "select * from view_goodbuffer where deleted is null ";
            if (num != -1)
                str = string.Format(" select * from view_goodbuffer where deleted is null \r\n                                                            and idgood = {0}", (object)num);
            this.db.command.CommandText = str;
            this.db.adapter.Fill(this.table_goodbuffer);
            this.table_goodbuffer.AcceptChanges();
            this.colidgood_buffer.FilterInfo = new ColumnFilterInfo("[idgood] = " + (object)num);
        }

        private void gvGoods_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            this.UpdateGoodBuffer();
        }

        private void tsmiDeleteGoodBuffer_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gcGoodBuffer);
            if (selectedDataRows == null || selectedDataRows.Length <= 0)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void tsmiAddGoodBuffer_Click(object sender, EventArgs e)
        {
            if (this.Is_Dialog)
            {
                this.AddGoodBuffer(this.id, false);
            }
            else
            {
                DataRow dataRow = AtGrid.getDataRow((Control)this.gcGoods);
                if (dataRow == null)
                    return;
                this.AddGoodBuffer((int)dataRow["idgood"], true);
            }
        }

        private void AddGoodBuffer(int idgood, bool showEditForm)
        {
            DataRow row = this.table_goodbuffer.NewRow();
            row["idgoodbuffer"] = (object)dbconn.GetGenId("gen_goodbuffer");
            row["idgood"] = (object)(this.Is_Dialog ? this.id : idgood);
            row["dtcre"] = (object)DateTime.Now;
            if (!this.Is_Dialog)
            {
                DataRow dataRow = AtGrid.getDataRow((Control)this.gcGoods);
                if (dataRow != null)
                {
                    row["good_name"] = dataRow["name"];
                    row["good_marking"] = dataRow["marking"];
                }
            }
            else if (this.goodRow != null)
            {
                row["good_name"] = this.goodRow["name"];
                row["good_marking"] = this.goodRow["marking"];
            }
            this.table_goodbuffer.Rows.Add(row);
            if (showEditForm)
            {
                GoodBufferEdit goodBufferEdit = new GoodBufferEdit();
                goodBufferEdit.Text = "Добавление остатка";
                goodBufferEdit.EditRow = row;
                int num = (int)goodBufferEdit.ShowDialog();
            }
            this.gcGoodBuffer.RefreshDataSource();
            this.gcGoods.RefreshDataSource();
        }

        private void repositoryItemPopupContainerEdit_Color1_Popup(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gcGoodBuffer);
            if (dataRow == null)
                return;
            this.repositoryItemPopupContainerEdit_Color1.IdColor = dataRow["idcolor1"];
        }

        private void repositoryItemPopupContainerEdit_Color2_Popup(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gcGoodBuffer);
            if (dataRow == null)
                return;
            this.repositoryItemPopupContainerEdit_Color2.IdColor = dataRow["idcolor2"];
        }

        private void repositoryItemPopupContainerEdit_Color1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            DataRow dataRow = AtGrid.getDataRow((Control)this.gcGoodBuffer);
            if (dataRow == null)
                return;
            dataRow["idcolor1"] = (object)DBNull.Value;
            dataRow["color1_name"] = (object)DBNull.Value;
            this.gcGoodBuffer.RefreshDataSource();
        }

        private void repositoryItemPopupContainerEdit_Color2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            DataRow dataRow = AtGrid.getDataRow((Control)this.gcGoodBuffer);
            if (dataRow == null)
                return;
            dataRow["idcolor2"] = (object)DBNull.Value;
            dataRow["color2_name"] = (object)DBNull.Value;
            this.gcGoodBuffer.RefreshDataSource();
        }

        private void repositoryItemPopupContainerEdit_Color1_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gcGoodBuffer);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = (DataRow)e.NewValue;
            dataRow1["idcolor1"] = dataRow2["idcolor"];
            dataRow1["color1_name"] = dataRow2["name"];
        }

        private void repositoryItemPopupContainerEdit_Color2_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gcGoodBuffer);
            if (dataRow1 == null)
                return;
            DataRow dataRow2 = (DataRow)e.NewValue;
            dataRow1["idcolor2"] = dataRow2["idcolor"];
            dataRow1["color2_name"] = dataRow2["name"];
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GoodBufferForm));
            this.repositoryItemCheckEdit3 = new RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit4 = new RepositoryItemCheckEdit();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.gcGoodBuffer = new GridControl();
            this.cmsGoodBuffer = new ContextMenuStrip(this.components);
            this.tsmiAddGoodBuffer = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.tsmiDeleteGoodBuffer = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_goodbuffer = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn20 = new DataColumn();
            this.dataColumn21 = new DataColumn();
            this.dataColumn16 = new DataColumn();
            this.dataColumn17 = new DataColumn();
            this.dataColumn18 = new DataColumn();
            this.dataColumn19 = new DataColumn();
            this.dataColumn22 = new DataColumn();
            this.dataColumn23 = new DataColumn();
            this.dataColumn24 = new DataColumn();
            this.table_good = new DataTable();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn15 = new DataColumn();
            this.gvGoodBuffer = new GridView();
            this.colidgoodbuffer = new GridColumn();
            this.colheight1 = new GridColumn();
            this.repositoryItemCalcEdit2 = new RepositoryItemCalcEdit();
            this.colwidth1 = new GridColumn();
            this.repositoryItemCalcEdit3 = new RepositoryItemCalcEdit();
            this.colweight1 = new GridColumn();
            this.repositoryItemCalcEdit4 = new RepositoryItemCalcEdit();
            this.colcomment = new GridColumn();
            this.colthick1 = new GridColumn();
            this.repositoryItemCalcEdit1 = new RepositoryItemCalcEdit();
            this.colmarking = new GridColumn();
            this.col_goodname = new GridColumn();
            this.col_goodmarking = new GridColumn();
            this.colbarcode = new GridColumn();
            this.colstatus = new GridColumn();
            this.colstatusEditor = new RepositoryItemComboBox();
            this.colidgood_buffer = new GridColumn();
            this.colrow = new GridColumn();
            this.colcell = new GridColumn();
            this.colcolor1_name = new GridColumn();
            this.repositoryItemPopupContainerEdit_Color1 = new atColorPopUpContainer();
            this.colcolor2_name = new GridColumn();
            this.repositoryItemPopupContainerEdit_Color2 = new atColorPopUpContainer();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new RepositoryItemTextEdit();
            this.gridView2 = new GridView();
            this.colgood_marking = new GridColumn();
            this.colgood_name = new GridColumn();
            this.colqu = new GridColumn();
            this.colthick = new GridColumn();
            this.colheight = new GridColumn();
            this.colwidth = new GridColumn();
            this.colweight = new GridColumn();
            this.cmsGood = new ContextMenuStrip(this.components);
            this.tsmiAddGood = new ToolStripMenuItem();
            this.splitter1 = new Splitter();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new RepositoryItemCheckEdit();
            this.imageList1 = new ImageList(this.components);
            this.treeListColumn3 = new TreeListColumn();
            this.treeListColumn1 = new TreeListColumn();
            this.treeListColumn2 = new TreeListColumn();
            this.gcGoods = new GridControl();
            this.gvGoods = new GridView();
            this.colidgood = new GridColumn();
            this.colgoodname = new GridColumn();
            this.colgoodmarking = new GridColumn();
            this.colgoodmeasure = new GridColumn();
            this.atRepositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.repositoryItemCalcEdit8 = new RepositoryItemCalcEdit();
            this.repositoryItemCalcEdit5 = new RepositoryItemCalcEdit();
            this.repositoryItemCalcEdit6 = new RepositoryItemCalcEdit();
            this.repositoryItemCalcEdit7 = new RepositoryItemCalcEdit();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.gridView4 = new GridView();
            this.gridColumn12 = new GridColumn();
            this.gridColumn13 = new GridColumn();
            this.gridColumn14 = new GridColumn();
            this.gridColumn15 = new GridColumn();
            this.gridColumn16 = new GridColumn();
            this.gridColumn17 = new GridColumn();
            this.gridColumn18 = new GridColumn();
            this.repositoryItemCheckEdit3.BeginInit();
            this.repositoryItemCheckEdit4.BeginInit();
            this.panel1.SuspendLayout();
            this.gcGoodBuffer.BeginInit();
            this.cmsGoodBuffer.SuspendLayout();
            this.ds.BeginInit();
            this.table_goodbuffer.BeginInit();
            this.table_good.BeginInit();
            this.gvGoodBuffer.BeginInit();
            this.repositoryItemCalcEdit2.BeginInit();
            this.repositoryItemCalcEdit3.BeginInit();
            this.repositoryItemCalcEdit4.BeginInit();
            this.repositoryItemCalcEdit1.BeginInit();
            this.colstatusEditor.BeginInit();
            this.repositoryItemPopupContainerEdit_Color1.BeginInit();
            this.repositoryItemPopupContainerEdit_Color2.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemTextEdit2.BeginInit();
            this.gridView2.BeginInit();
            this.cmsGood.SuspendLayout();
            this.repositoryItemCheckEdit1.BeginInit();
            this.repositoryItemCheckEdit2.BeginInit();
            this.gcGoods.BeginInit();
            this.gvGoods.BeginInit();
            this.atRepositoryItemTextEdit1.BeginInit();
            this.repositoryItemCalcEdit8.BeginInit();
            this.repositoryItemCalcEdit5.BeginInit();
            this.repositoryItemCalcEdit6.BeginInit();
            this.repositoryItemCalcEdit7.BeginInit();
            this.repositoryItemComboBox1.BeginInit();
            this.gridView4.BeginInit();
            this.SuspendLayout();
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(783, 33);
            this.panel1.TabIndex = 4;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(696, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(615, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(534, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gcGoodBuffer.ContextMenuStrip = this.cmsGoodBuffer;
            this.gcGoodBuffer.DataMember = "goodbuffer";
            this.gcGoodBuffer.DataSource = (object)this.ds;
            this.gcGoodBuffer.Dock = DockStyle.Fill;
            this.gcGoodBuffer.EmbeddedNavigator.Name = "";
            this.gcGoodBuffer.Location = new Point(203, 0);
            this.gcGoodBuffer.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gcGoodBuffer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcGoodBuffer.MainView = (BaseView)this.gvGoodBuffer;
            this.gcGoodBuffer.Name = "gcGoodBuffer";
            this.gcGoodBuffer.RepositoryItems.AddRange(new RepositoryItem[9]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemCalcEdit1,
        (RepositoryItem) this.repositoryItemCalcEdit2,
        (RepositoryItem) this.repositoryItemCalcEdit3,
        (RepositoryItem) this.repositoryItemCalcEdit4,
        (RepositoryItem) this.colstatusEditor,
        (RepositoryItem) this.repositoryItemTextEdit2,
        (RepositoryItem) this.repositoryItemPopupContainerEdit_Color1,
        (RepositoryItem) this.repositoryItemPopupContainerEdit_Color2
      });
            this.gcGoodBuffer.Size = new Size(580, 441);
            this.gcGoodBuffer.TabIndex = 5;
            this.gcGoodBuffer.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gvGoodBuffer,
        (BaseView) this.gridView2
      });
            this.cmsGoodBuffer.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.tsmiAddGoodBuffer,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.tsmiDeleteGoodBuffer
      });
            this.cmsGoodBuffer.Name = "contextMenuStrip1";
            this.cmsGoodBuffer.Size = new Size(125, 54);
            this.tsmiAddGoodBuffer.Name = "tsmiAddGoodBuffer";
            this.tsmiAddGoodBuffer.Size = new Size(124, 22);
            this.tsmiAddGoodBuffer.Text = "Добавить";
            this.tsmiAddGoodBuffer.Click += new EventHandler(this.tsmiAddGoodBuffer_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(121, 6);
            this.tsmiDeleteGoodBuffer.Name = "tsmiDeleteGoodBuffer";
            this.tsmiDeleteGoodBuffer.Size = new Size(124, 22);
            this.tsmiDeleteGoodBuffer.Text = "Удалить";
            this.tsmiDeleteGoodBuffer.Click += new EventHandler(this.tsmiDeleteGoodBuffer_Click);
            this.ds.DataSetName = "ds";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[2]
      {
        this.table_goodbuffer,
        this.table_good
      });
            this.table_goodbuffer.Columns.AddRange(new DataColumn[20]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn9,
        this.dataColumn10,
        this.dataColumn11,
        this.dataColumn20,
        this.dataColumn21,
        this.dataColumn16,
        this.dataColumn17,
        this.dataColumn18,
        this.dataColumn19,
        this.dataColumn22,
        this.dataColumn23,
        this.dataColumn24
      });
            this.table_goodbuffer.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodbuffer"
        }, 1 != 0)
      });
            this.table_goodbuffer.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_goodbuffer.TableName = "goodbuffer";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idgoodbuffer";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "idgood";
            this.dataColumn2.DataType = typeof(int);
            this.dataColumn3.ColumnName = "height";
            this.dataColumn3.DataType = typeof(int);
            this.dataColumn4.ColumnName = "width";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "weight";
            this.dataColumn5.DataType = typeof(double);
            this.dataColumn6.ColumnName = "comment";
            this.dataColumn7.ColumnName = "thick";
            this.dataColumn7.DataType = typeof(int);
            this.dataColumn8.ColumnName = "marking";
            this.dataColumn9.ColumnName = "idorderitem";
            this.dataColumn9.DataType = typeof(int);
            this.dataColumn10.ColumnName = "good_name";
            this.dataColumn11.ColumnName = "good_marking";
            this.dataColumn20.ColumnName = "barcode";
            this.dataColumn21.Caption = "status_name";
            this.dataColumn21.ColumnName = "status_name";
            this.dataColumn16.ColumnName = "status";
            this.dataColumn16.DataType = typeof(int);
            this.dataColumn17.ColumnName = "cell";
            this.dataColumn18.ColumnName = "row";
            this.dataColumn19.ColumnName = "idcolor1";
            this.dataColumn19.DataType = typeof(int);
            this.dataColumn22.ColumnName = "idcolor2";
            this.dataColumn22.DataType = typeof(int);
            this.dataColumn23.ColumnName = "color1_name";
            this.dataColumn24.ColumnName = "color2_name";
            this.table_good.Columns.AddRange(new DataColumn[4]
      {
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14,
        this.dataColumn15
      });
            this.table_good.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgood"
        }, 1 != 0)
      });
            this.table_good.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn12
      };
            this.table_good.TableName = "good";
            this.dataColumn12.AllowDBNull = false;
            this.dataColumn12.ColumnName = "idgood";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.Caption = "name";
            this.dataColumn13.ColumnName = "name";
            this.dataColumn14.Caption = "marking";
            this.dataColumn14.ColumnName = "marking";
            this.dataColumn15.Caption = "measure_shortname";
            this.dataColumn15.ColumnName = "measure_shortname";
            this.gvGoodBuffer.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gvGoodBuffer.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvGoodBuffer.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvGoodBuffer.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvGoodBuffer.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvGoodBuffer.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gvGoodBuffer.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvGoodBuffer.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvGoodBuffer.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvGoodBuffer.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoodBuffer.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gvGoodBuffer.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvGoodBuffer.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvGoodBuffer.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvGoodBuffer.BorderStyle = BorderStyles.Simple;
            this.gvGoodBuffer.Columns.AddRange(new GridColumn[16]
      {
        this.colidgoodbuffer,
        this.colheight1,
        this.colwidth1,
        this.colweight1,
        this.colcomment,
        this.colthick1,
        this.colmarking,
        this.col_goodname,
        this.col_goodmarking,
        this.colbarcode,
        this.colstatus,
        this.colidgood_buffer,
        this.colrow,
        this.colcell,
        this.colcolor1_name,
        this.colcolor2_name
      });
            this.gvGoodBuffer.GridControl = this.gcGoodBuffer;
            this.gvGoodBuffer.GroupPanelText = "Панель группировки";
            this.gvGoodBuffer.Name = "gvGoodBuffer";
            this.gvGoodBuffer.OptionsCustomization.AllowFilter = false;
            this.gvGoodBuffer.OptionsDetail.ShowDetailTabs = false;
            this.gvGoodBuffer.OptionsSelection.MultiSelect = true;
            this.gvGoodBuffer.OptionsView.ShowAutoFilterRow = true;
            this.gvGoodBuffer.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gvGoodBuffer.OptionsView.ShowGroupPanel = false;
            this.gvGoodBuffer.OptionsView.ShowIndicator = false;
            this.colidgoodbuffer.Caption = "#";
            this.colidgoodbuffer.FieldName = "idgoodbuffer";
            this.colidgoodbuffer.Name = "colidgoodbuffer";
            this.colidgoodbuffer.Visible = true;
            this.colidgoodbuffer.VisibleIndex = 0;
            this.colidgoodbuffer.Width = 57;
            this.colheight1.Caption = "Высота";
            this.colheight1.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit2;
            this.colheight1.FieldName = "height";
            this.colheight1.Name = "colheight1";
            this.colheight1.Visible = true;
            this.colheight1.VisibleIndex = 2;
            this.colheight1.Width = 68;
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            this.colwidth1.Caption = "Ширина";
            this.colwidth1.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit3;
            this.colwidth1.FieldName = "width";
            this.colwidth1.Name = "colwidth1";
            this.colwidth1.Visible = true;
            this.colwidth1.VisibleIndex = 3;
            this.colwidth1.Width = 67;
            this.repositoryItemCalcEdit3.AutoHeight = false;
            this.repositoryItemCalcEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit3.Name = "repositoryItemCalcEdit3";
            this.colweight1.Caption = "Вес";
            this.colweight1.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit4;
            this.colweight1.FieldName = "weight";
            this.colweight1.Name = "colweight1";
            this.colweight1.Visible = true;
            this.colweight1.VisibleIndex = 4;
            this.colweight1.Width = 64;
            this.repositoryItemCalcEdit4.AutoHeight = false;
            this.repositoryItemCalcEdit4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit4.Name = "repositoryItemCalcEdit4";
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 6;
            this.colcomment.Width = 338;
            this.colthick1.Caption = "Длина";
            this.colthick1.ColumnEdit = (RepositoryItem)this.repositoryItemCalcEdit1;
            this.colthick1.FieldName = "thick";
            this.colthick1.Name = "colthick1";
            this.colthick1.Visible = true;
            this.colthick1.VisibleIndex = 1;
            this.colthick1.Width = 58;
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            this.colmarking.Caption = "Маркировка";
            this.colmarking.FieldName = "marking";
            this.colmarking.Name = "colmarking";
            this.colmarking.Visible = true;
            this.colmarking.VisibleIndex = 5;
            this.colmarking.Width = 159;
            this.col_goodname.Caption = "Наименование материала";
            this.col_goodname.FieldName = "good_name";
            this.col_goodname.Name = "col_goodname";
            this.col_goodname.OptionsColumn.AllowEdit = false;
            this.col_goodname.OptionsColumn.ReadOnly = true;
            this.col_goodname.Visible = true;
            this.col_goodname.VisibleIndex = 7;
            this.col_goodmarking.Caption = "Артикул материала";
            this.col_goodmarking.FieldName = "good_marking";
            this.col_goodmarking.Name = "col_goodmarking";
            this.col_goodmarking.OptionsColumn.AllowEdit = false;
            this.col_goodmarking.OptionsColumn.ReadOnly = true;
            this.col_goodmarking.Visible = true;
            this.col_goodmarking.VisibleIndex = 8;
            this.colbarcode.Caption = "Баркод";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 9;
            this.colstatus.Caption = "Статус";
            this.colstatus.ColumnEdit = (RepositoryItem)this.colstatusEditor;
            this.colstatus.FieldName = "status_name";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 10;
            this.colstatusEditor.AutoHeight = false;
            this.colstatusEditor.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.colstatusEditor.Items.AddRange(new object[3]
      {
        (object) "",
        (object) "резерв",
        (object) "в наличии"
      });
            this.colstatusEditor.Name = "colstatusEditor";
            this.colidgood_buffer.Caption = "# материала";
            this.colidgood_buffer.FieldName = "idgood";
            this.colidgood_buffer.Name = "colidgood_buffer";
            this.colrow.AppearanceCell.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.colrow.AppearanceCell.Options.UseBackColor = true;
            this.colrow.Caption = "Ряд";
            this.colrow.FieldName = "row";
            this.colrow.Name = "colrow";
            this.colrow.Visible = true;
            this.colrow.VisibleIndex = 12;
            this.colcell.AppearanceCell.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.colcell.AppearanceCell.Options.UseBackColor = true;
            this.colcell.Caption = "Ячейка";
            this.colcell.FieldName = "cell";
            this.colcell.Name = "colcell";
            this.colcell.Visible = true;
            this.colcell.VisibleIndex = 11;
            this.colcolor1_name.Caption = "Цвет внешний";
            this.colcolor1_name.ColumnEdit = (RepositoryItem)this.repositoryItemPopupContainerEdit_Color1;
            this.colcolor1_name.FieldName = "color1_name";
            this.colcolor1_name.Name = "colcolor1_name";
            this.colcolor1_name.Visible = true;
            this.colcolor1_name.VisibleIndex = 13;
            this.repositoryItemPopupContainerEdit_Color1.ActionButtonIndex = 1;
            this.repositoryItemPopupContainerEdit_Color1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit_Color1.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemPopupContainerEdit_Color1.Name = "repositoryItemPopupContainerEdit_Color1";
            this.repositoryItemPopupContainerEdit_Color1.Popup += new EventHandler(this.repositoryItemPopupContainerEdit_Color1_Popup);
            this.repositoryItemPopupContainerEdit_Color1.EditValueChanging += new ChangingEventHandler(this.repositoryItemPopupContainerEdit_Color1_EditValueChanging);
            this.repositoryItemPopupContainerEdit_Color1.ButtonClick += new ButtonPressedEventHandler(this.repositoryItemPopupContainerEdit_Color1_ButtonClick);
            this.colcolor2_name.Caption = "Цвет внутренний";
            this.colcolor2_name.ColumnEdit = (RepositoryItem)this.repositoryItemPopupContainerEdit_Color2;
            this.colcolor2_name.FieldName = "color2_name";
            this.colcolor2_name.Name = "colcolor2_name";
            this.colcolor2_name.Visible = true;
            this.colcolor2_name.VisibleIndex = 14;
            this.repositoryItemPopupContainerEdit_Color2.ActionButtonIndex = 1;
            this.repositoryItemPopupContainerEdit_Color2.AutoHeight = false;
            this.repositoryItemPopupContainerEdit_Color2.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemPopupContainerEdit_Color2.Name = "repositoryItemPopupContainerEdit_Color2";
            this.repositoryItemPopupContainerEdit_Color2.Popup += new EventHandler(this.repositoryItemPopupContainerEdit_Color2_Popup);
            this.repositoryItemPopupContainerEdit_Color2.EditValueChanging += new ChangingEventHandler(this.repositoryItemPopupContainerEdit_Color2_EditValueChanging);
            this.repositoryItemPopupContainerEdit_Color2.ButtonClick += new ButtonPressedEventHandler(this.repositoryItemPopupContainerEdit_Color2_ButtonClick);
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
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
            this.gridView2.Columns.AddRange(new GridColumn[7]
      {
        this.colgood_marking,
        this.colgood_name,
        this.colqu,
        this.colthick,
        this.colheight,
        this.colwidth,
        this.colweight
      });
            this.gridView2.GridControl = this.gcGoodBuffer;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.colgood_marking.Caption = "Артикул материала";
            this.colgood_marking.FieldName = "good_marking";
            this.colgood_marking.Name = "colgood_marking";
            this.colgood_marking.Visible = true;
            this.colgood_marking.VisibleIndex = 1;
            this.colgood_name.Caption = "Наименование материала";
            this.colgood_name.FieldName = "good_name";
            this.colgood_name.Name = "colgood_name";
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
            this.colheight.FieldName = "height";
            this.colheight.Name = "colheight";
            this.colheight.Visible = true;
            this.colheight.VisibleIndex = 4;
            this.colwidth.Caption = "Ширина";
            this.colwidth.FieldName = "width";
            this.colwidth.Name = "colwidth";
            this.colwidth.Visible = true;
            this.colwidth.VisibleIndex = 5;
            this.colweight.Caption = "Вес";
            this.colweight.FieldName = "weight";
            this.colweight.Name = "colweight";
            this.colweight.Visible = true;
            this.colweight.VisibleIndex = 6;
            this.cmsGood.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tsmiAddGood
      });
            this.cmsGood.Name = "contextMenuStrip1";
            this.cmsGood.Size = new Size(125, 26);
            this.tsmiAddGood.Name = "tsmiAddGood";
            this.tsmiAddGood.Size = new Size(124, 22);
            this.tsmiAddGood.Text = "Добавить";
            this.tsmiAddGood.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.splitter1.Location = new Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 441);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "SearchFolder.bmp");
            this.imageList1.Images.SetKeyName(2, "GoToParentFolder.bmp");
            this.imageList1.Images.SetKeyName(3, "SearchInFolder.bmp");
            this.imageList1.Images.SetKeyName(4, "Search.bmp");
            this.imageList1.Images.SetKeyName(5, "Folder2.ico");
            this.treeListColumn3.Caption = "treeListColumn3";
            this.treeListColumn3.FieldName = "numpos";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.SortOrder = SortOrder.Ascending;
            this.treeListColumn1.Caption = "Активность";
            this.treeListColumn1.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit3;
            this.treeListColumn1.FieldName = "isactive";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 1;
            this.treeListColumn1.Width = 31;
            this.treeListColumn2.Caption = "Видимость";
            this.treeListColumn2.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit4;
            this.treeListColumn2.FieldName = "isvisible";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 2;
            this.treeListColumn2.Width = 31;
            this.gcGoods.ContextMenuStrip = this.cmsGood;
            this.gcGoods.DataMember = "good";
            this.gcGoods.DataSource = (object)this.ds;
            this.gcGoods.Dock = DockStyle.Left;
            this.gcGoods.EmbeddedNavigator.Name = "";
            this.gcGoods.Location = new Point(0, 0);
            this.gcGoods.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gcGoods.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcGoods.MainView = (BaseView)this.gvGoods;
            this.gcGoods.Name = "gcGoods";
            this.gcGoods.RepositoryItems.AddRange(new RepositoryItem[6]
      {
        (RepositoryItem) this.atRepositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemCalcEdit8,
        (RepositoryItem) this.repositoryItemCalcEdit5,
        (RepositoryItem) this.repositoryItemCalcEdit6,
        (RepositoryItem) this.repositoryItemCalcEdit7,
        (RepositoryItem) this.repositoryItemComboBox1
      });
            this.gcGoods.Size = new Size(200, 441);
            this.gcGoods.TabIndex = 8;
            this.gcGoods.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.gvGoods,
        (BaseView) this.gridView4
      });
            this.gvGoods.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoods.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoods.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoods.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gvGoods.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvGoods.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvGoods.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvGoods.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoods.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvGoods.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvGoods.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvGoods.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvGoods.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gvGoods.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gvGoods.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvGoods.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvGoods.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvGoods.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoods.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoods.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gvGoods.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gvGoods.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvGoods.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvGoods.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvGoods.BorderStyle = BorderStyles.Simple;
            this.gvGoods.Columns.AddRange(new GridColumn[4]
      {
        this.colidgood,
        this.colgoodname,
        this.colgoodmarking,
        this.colgoodmeasure
      });
            this.gvGoods.GridControl = this.gcGoods;
            this.gvGoods.GroupPanelText = "Панель группировки";
            this.gvGoods.Name = "gvGoods";
            this.gvGoods.OptionsCustomization.AllowFilter = false;
            this.gvGoods.OptionsDetail.ShowDetailTabs = false;
            this.gvGoods.OptionsSelection.MultiSelect = true;
            this.gvGoods.OptionsView.ShowAutoFilterRow = true;
            this.gvGoods.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gvGoods.OptionsView.ShowGroupPanel = false;
            this.gvGoods.OptionsView.ShowIndicator = false;
            this.gvGoods.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gvGoods_FocusedRowChanged);
            this.colidgood.Caption = "#";
            this.colidgood.FieldName = "idgood";
            this.colidgood.Name = "colidgood";
            this.colidgood.OptionsColumn.AllowEdit = false;
            this.colidgood.OptionsColumn.ReadOnly = true;
            this.colidgood.Visible = true;
            this.colidgood.VisibleIndex = 0;
            this.colidgood.Width = 57;
            this.colgoodname.Caption = "Наименование";
            this.colgoodname.FieldName = "name";
            this.colgoodname.Name = "colgoodname";
            this.colgoodname.OptionsColumn.AllowEdit = false;
            this.colgoodname.OptionsColumn.ReadOnly = true;
            this.colgoodname.Visible = true;
            this.colgoodname.VisibleIndex = 3;
            this.colgoodmarking.Caption = "Артикул";
            this.colgoodmarking.FieldName = "marking";
            this.colgoodmarking.Name = "colgoodmarking";
            this.colgoodmarking.OptionsColumn.AllowEdit = false;
            this.colgoodmarking.OptionsColumn.ReadOnly = true;
            this.colgoodmarking.Visible = true;
            this.colgoodmarking.VisibleIndex = 1;
            this.colgoodmeasure.Caption = "Ед. измерения";
            this.colgoodmeasure.FieldName = "measure_shortname";
            this.colgoodmeasure.Name = "colgoodmeasure";
            this.colgoodmeasure.OptionsColumn.AllowEdit = false;
            this.colgoodmeasure.OptionsColumn.ReadOnly = true;
            this.colgoodmeasure.Visible = true;
            this.colgoodmeasure.VisibleIndex = 2;
            this.atRepositoryItemTextEdit1.AutoHeight = false;
            this.atRepositoryItemTextEdit1.DisplayFormat.FormatString = "n2";
            this.atRepositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.atRepositoryItemTextEdit1.EditFormat.FormatString = "n2";
            this.atRepositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.atRepositoryItemTextEdit1.Mask.EditMask = "n2";
            this.atRepositoryItemTextEdit1.Mask.MaskType = MaskType.Numeric;
            this.atRepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.atRepositoryItemTextEdit1.Name = "atRepositoryItemTextEdit1";
            this.repositoryItemCalcEdit8.AutoHeight = false;
            this.repositoryItemCalcEdit8.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit8.Name = "repositoryItemCalcEdit8";
            this.repositoryItemCalcEdit5.AutoHeight = false;
            this.repositoryItemCalcEdit5.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit5.Name = "repositoryItemCalcEdit5";
            this.repositoryItemCalcEdit6.AutoHeight = false;
            this.repositoryItemCalcEdit6.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit6.Name = "repositoryItemCalcEdit6";
            this.repositoryItemCalcEdit7.AutoHeight = false;
            this.repositoryItemCalcEdit7.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemCalcEdit7.Name = "repositoryItemCalcEdit7";
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Items.AddRange(new object[3]
      {
        (object) "",
        (object) "резерв",
        (object) "в наличии"
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.gridView4.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView4.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView4.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView4.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView4.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView4.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView4.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView4.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView4.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView4.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView4.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView4.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView4.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView4.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView4.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView4.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView4.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView4.BorderStyle = BorderStyles.Simple;
            this.gridView4.Columns.AddRange(new GridColumn[7]
      {
        this.gridColumn12,
        this.gridColumn13,
        this.gridColumn14,
        this.gridColumn15,
        this.gridColumn16,
        this.gridColumn17,
        this.gridColumn18
      });
            this.gridView4.GridControl = this.gcGoods;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsCustomization.AllowFilter = false;
            this.gridView4.OptionsCustomization.AllowGroup = false;
            this.gridView4.OptionsDetail.ShowDetailTabs = false;
            this.gridView4.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.OptionsView.ShowIndicator = false;
            this.gridColumn12.Caption = "Артикул материала";
            this.gridColumn12.FieldName = "good_marking";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn13.Caption = "Наименование материала";
            this.gridColumn13.FieldName = "good_name";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            this.gridColumn14.Caption = "Кол-во";
            this.gridColumn14.FieldName = "qu";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            this.gridColumn15.Caption = "Длина";
            this.gridColumn15.FieldName = "thick";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 3;
            this.gridColumn16.Caption = "Высота";
            this.gridColumn16.FieldName = "height";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 4;
            this.gridColumn17.Caption = "Ширина";
            this.gridColumn17.FieldName = "width";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            this.gridColumn18.Caption = "Вес";
            this.gridColumn18.FieldName = "weight";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 6;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gcGoodBuffer);
            this.Controls.Add((Control)this.splitter1);
            this.Controls.Add((Control)this.gcGoods);
            this.Controls.Add((Control)this.panel1);
            this.Name = "GoodBufferForm";
            this.Size = new Size(783, 474);
            this.Text = "Буфер остатков";
            this.repositoryItemCheckEdit3.EndInit();
            this.repositoryItemCheckEdit4.EndInit();
            this.panel1.ResumeLayout(false);
            this.gcGoodBuffer.EndInit();
            this.cmsGoodBuffer.ResumeLayout(false);
            this.ds.EndInit();
            this.table_goodbuffer.EndInit();
            this.table_good.EndInit();
            this.gvGoodBuffer.EndInit();
            this.repositoryItemCalcEdit2.EndInit();
            this.repositoryItemCalcEdit3.EndInit();
            this.repositoryItemCalcEdit4.EndInit();
            this.repositoryItemCalcEdit1.EndInit();
            this.colstatusEditor.EndInit();
            this.repositoryItemPopupContainerEdit_Color1.EndInit();
            this.repositoryItemPopupContainerEdit_Color2.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemTextEdit2.EndInit();
            this.gridView2.EndInit();
            this.cmsGood.ResumeLayout(false);
            this.repositoryItemCheckEdit1.EndInit();
            this.repositoryItemCheckEdit2.EndInit();
            this.gcGoods.EndInit();
            this.gvGoods.EndInit();
            this.atRepositoryItemTextEdit1.EndInit();
            this.repositoryItemCalcEdit8.EndInit();
            this.repositoryItemCalcEdit5.EndInit();
            this.repositoryItemCalcEdit6.EndInit();
            this.repositoryItemCalcEdit7.EndInit();
            this.repositoryItemComboBox1.EndInit();
            this.gridView4.EndInit();
            this.ResumeLayout(false);
        }
    }
}
