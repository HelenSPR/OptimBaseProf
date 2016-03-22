// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.EmbrasureTypeForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
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
    public class EmbrasureTypeForm : AtUserControl
    {
        private DataRow MoveGroup;
        private DataRow[] MoveItems;
        private bool isKeyMove;
        private IContainer components;
        private DataSet ds;
        private DataTable table_embrasuretypegroup;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataTable table_embrasuretype;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn9;
        private DataColumn dataColumn10;
        private ToolStripMenuItem MenuItemRemove;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuItemChangeGroup;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MenuItemDoublicate;
        private ImageList imageListGrop;
        private ToolStripMenuItem MenuGroupRemove;
        private ToolStripMenuItem MenuItemAdd;
        private ContextMenuStrip MenuItem;
        private GridColumn colidembrasuretypegroup;
        private GridColumn colidembrasuretype;
        public GridView gridViewItem;
        private GridColumn colname1;
        private GridColumn colcomment;
        public GridControl gridControlItem;
        private Button cmdApply;
        private Button cmdReLoad;
        private TreeList treeListGroup;
        private TreeListColumn colname;
        private ContextMenuStrip MenuGroup;
        private ToolStripMenuItem MenuGroupAddMain;
        private ToolStripMenuItem MenuGroupAddChild;
        private ToolStripMenuItem MenuGroupRename;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MenuGroupMove;
        private ToolStripMenuItem MenuGroupSetMain;
        private ToolStripSeparator toolStripSeparator1;
        public Panel panel1;
        private Button cmdClose;
        public Panel panel2;
        private SplitterControl splitterControl1;
        private TreeListColumn colisactive;
        public Button cmdCancel;
        public Button cmdOk;
        private DataColumn dataColumn6;
        private GridColumn colshortname;

        public EmbrasureTypeForm(dbconn _db)
        {
            this.InitializeComponent();
            this.FormClosing += new FormClosing(this.EmbrasureTypeForm_FormClosing);
            this.Shown += new Shown(this.EmbrasureTypeForm_Shown);
            this.cmdApply.Click += new EventHandler(this.cmdApply_Click);
            this.cmdReLoad.Click += new EventHandler(this.cmdReLoad_Click);
            this.cmdClose.Click += new EventHandler(this.cmdClose_Click);
            this.cmdOk.Click += new EventHandler(this.cmdOk_Click);
            this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
            this.gridViewItem.DoubleClick += new EventHandler(this.gridViewItem_DoubleClick);
            this.treeListGroup.KeyDown += new KeyEventHandler(this.treeListGroup_KeyDown);
            this.treeListGroup.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListGroup_FocusedNodeChanged);
            this.treeListGroup.LostFocus += new EventHandler(this.treeListGroup_LostFocus);
            this.MenuGroupAddMain.Click += new EventHandler(this.MenuGroupAddMain_Click);
            this.MenuGroupAddChild.Click += new EventHandler(this.MenuGroupAddChild_Click);
            this.MenuGroupRemove.Click += new EventHandler(this.MenuGroupRemove_Click);
            this.MenuGroupMove.Click += new EventHandler(this.MenuGroupMove_Click);
            this.MenuGroupRename.Click += new EventHandler(this.MenuGroupRename_Click);
            this.MenuGroupSetMain.Click += new EventHandler(this.MenuGroupSetMain_Click);
            this.MenuItemAdd.Click += new EventHandler(this.MenuItemAdd_Click);
            this.MenuItemDoublicate.Click += new EventHandler(this.MenuItemDoublicate_Click);
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            this.MenuItemChangeGroup.Click += new EventHandler(this.MenuItemChangeGroup_Click);
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

        private void EmbrasureTypeForm_Shown(object sender, EventArgs e)
        {
            this.LoadFromBase();
            AtTreeList.SelectFirstNode(this.treeListGroup);
        }

        private void EmbrasureTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) == 0)
                return;
            DialogResult dialogResult = MessageBox.Show("Данные были изменены!\nСохранить изменения?", "Справочник типов проёмов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == this.DialogResult)
            {
                this.SaveToBase();
            }
            else
            {
                if (dialogResult != DialogResult.Cancel)
                    return;
                e.Cancel = true;
            }
        }

        private void treeListGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && (this.MoveItems != null || this.MoveGroup != null))
                this.MoveElements();
            else
                TreeList_KeyDown.Key(this.treeListGroup, e.KeyCode);
        }

        private void treeListGroup_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (!this.isKeyMove)
                this.MoveElements();
            this.isKeyMove = false;
        }

        private void treeListGroup_LostFocus(object sender, EventArgs e)
        {
            this.isKeyMove = false;
        }

        private void gridViewItem_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.cmdOk_Click((object)null, (EventArgs)null);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.ParentForm.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (AtGrid.getDataRow((Control)this.gridControlItem) == null)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdReLoad_Click(object sender, EventArgs e)
        {
            this.LoadFromBase();
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        public override bool SaveToBase()
        {
            string dataMember = this.treeListGroup.DataMember;
            this.treeListGroup.DataMember = (string)null;
            if (!this.db.SaveDataSetAndAccept(this.ds))
            {
                this.treeListGroup.DataMember = dataMember;
                return false;
            }
            this.treeListGroup.DataMember = dataMember;
            return true;
        }

        public override void LoadFromBase()
        {
            string dataMember = this.treeListGroup.DataMember;
            this.treeListGroup.DataMember = (string)null;
            string str1;
            string str2;
            if (this.Is_Dialog)
            {
                str1 = "select * from embrasuretypegroup where deleted is null and isactive = 1";
                str2 = "select * from embrasuretype \r\n\t\t\t\t\t\t\twhere deleted is null and \r\n\t\t\t\t\t\t\t\t\tidembrasuretypegroup in (select idembrasuretypegroup from embrasuretypegroup where deleted is null and isactive = 1)";
            }
            else
            {
                str1 = "select * from embrasuretypegroup where deleted is null";
                str2 = "select * from embrasuretype where deleted is null";
            }
            this.table_embrasuretypegroup.Clear();
            this.table_embrasuretype.Clear();
            this.ds.AcceptChanges();
            this.db.command.CommandText = str1;
            this.db.adapter.Fill(this.table_embrasuretypegroup);
            this.db.command.CommandText = str2;
            this.db.adapter.Fill(this.table_embrasuretype);
            this.treeListGroup.DataMember = dataMember;
        }

        private void MenuGroupAddMain_Click(object sender, EventArgs e)
        {
            InputBoxForm inputBoxForm = new InputBoxForm("Добавление основной группы", "Наименование", "Комментарий", "", "");
            if (inputBoxForm.ShowDialog() == DialogResult.Cancel)
                return;
            DataRow row = this.table_embrasuretypegroup.NewRow();
            row["idembrasuretypegroup"] = (object)dbconn.GetGenId("gen_embrasuretypegroup");
            row["name"] = (object)inputBoxForm.Value;
            row["comment"] = (object)inputBoxForm.Value2;
            row["isactive"] = (object)true;
            this.table_embrasuretypegroup.Rows.Add(row);
        }

        private void MenuGroupAddChild_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            InputBoxForm inputBoxForm = new InputBoxForm("Добавление дочерней группы", "Наименование", "Комментарий", selectedNode["name"].ToString(), "");
            if (inputBoxForm.ShowDialog() == DialogResult.Cancel)
                return;
            DataRow row = this.table_embrasuretypegroup.NewRow();
            row["idembrasuretypegroup"] = (object)dbconn.GetGenId("gen_embrasuretypegroup");
            row["parentid"] = selectedNode["idembrasuretypegroup"];
            row["name"] = (object)inputBoxForm.Value;
            row["comment"] = (object)inputBoxForm.Value2;
            row["isactive"] = (object)true;
            this.table_embrasuretypegroup.Rows.Add(row);
        }

        private void MenuGroupSetMain_Click(object sender, EventArgs e)
        {
            this.MoveGroup = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (this.MoveGroup == null)
                return;
            this.MoveElements((DataRow)null);
        }

        private void MenuGroupMove_Click(object sender, EventArgs e)
        {
            this.MoveGroup = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (this.MoveGroup == null)
                return;
            this.Cursor = Cursors.Hand;
        }

        private void MenuGroupRename_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            InputBoxForm inputBoxForm = new InputBoxForm("Редактирование группы типов проёмов", "Наименование", "Комментарий", selectedNode["name"].ToString(), selectedNode["comment"].ToString());
            if (inputBoxForm.ShowDialog() == DialogResult.Cancel)
                return;
            selectedNode["name"] = (object)inputBoxForm.Value;
            selectedNode["comment"] = (object)inputBoxForm.Value2;
        }

        private void MenuGroupRemove_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null || MessageBox.Show("Вы действительно хотите удалить текущую группу?", "Удаление группы типов проёмов", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            selectedNode.Delete();
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            int genId = dbconn.GetGenId("gen_embrasuretype");
            DataRow row = this.table_embrasuretype.NewRow();
            DataRow dataRow = row;
            string index = "idembrasuretype";
            int num1 = genId;
            int num2 = 1;
            int num3 = num1 + num2;
            // ISSUE: variable of a boxed type
            __Boxed<int> local = (System.ValueType)num1;
            dataRow[index] = (object)local;
            row["idembrasuretypegroup"] = selectedNode["idembrasuretypegroup"];
            row["name"] = (object)"";
            row["comment"] = (object)"";
            this.table_embrasuretype.Rows.Add(row);
        }

        private void MenuItemDoublicate_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlItem);
            if (selectedDataRows == null)
                return;
            int genFirstId = dbconn.GetGenFirstId("gen_embrasuretype", selectedDataRows.Length);
            foreach (DataRow source in selectedDataRows)
                AtDataSet.dublicate(source)["idembrasuretype"] = (object)genFirstId++;
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlItem);
            if (selectedDataRows == null || MessageBox.Show("Вы уверенны что хотите удалить выделенные элементы?", "Удалени типов проёмов", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void MenuItemChangeGroup_Click(object sender, EventArgs e)
        {
            this.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlItem);
            if (this.MoveItems == null)
                return;
            this.Cursor = Cursors.Hand;
            this.treeListGroup.Focus();
        }

        public void MoveElements(DataRow dr)
        {
            if (this.MoveGroup != null)
            {
                if (this.MoveGroup != dr)
                {
                    string dataMember = this.treeListGroup.DataMember;
                    this.treeListGroup.DataMember = (string)null;
                    this.MoveGroup["parentid"] = dr == null ? (object)DBNull.Value : dr["idembrasuretypegroup"];
                    this.treeListGroup.DataMember = dataMember;
                }
                this.Cursor = Cursors.Default;
                this.MoveGroup = (DataRow)null;
            }
            if (this.MoveItems == null)
                return;
            foreach (DataRow dataRow in this.MoveItems)
                dataRow["idembrasuretypegroup"] = dr["idembrasuretypegroup"];
            this.Cursor = Cursors.Default;
            this.MoveItems = (DataRow[])null;
            GC.Collect();
            GC.Collect();
        }

        public void MoveElements()
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListGroup);
            if (selectedNode == null)
                return;
            this.MoveElements(selectedNode);
        }

        private void IsDialog()
        {
            this.Is_Dialog = true;
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridViewItem.OptionsBehavior.Editable = false;
            this.gridControlItem.ContextMenu = (ContextMenu)null;
            this.treeListGroup.ContextMenuStrip = (ContextMenuStrip)null;
            this.colisactive.VisibleIndex = -1;
            this.gridViewItem.OptionsSelection.MultiSelect = false;
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(EmbrasureTypeForm));
            this.ds = new DataSet();
            this.table_embrasuretypegroup = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.table_embrasuretype = new DataTable();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemChangeGroup = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.MenuItemDoublicate = new ToolStripMenuItem();
            this.imageListGrop = new ImageList(this.components);
            this.MenuGroupRemove = new ToolStripMenuItem();
            this.MenuItemAdd = new ToolStripMenuItem();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.colidembrasuretypegroup = new GridColumn();
            this.colidembrasuretype = new GridColumn();
            this.gridViewItem = new GridView();
            this.colname1 = new GridColumn();
            this.colcomment = new GridColumn();
            this.colshortname = new GridColumn();
            this.gridControlItem = new GridControl();
            this.cmdCancel = new Button();
            this.cmdApply = new Button();
            this.cmdOk = new Button();
            this.cmdReLoad = new Button();
            this.treeListGroup = new TreeList();
            this.colname = new TreeListColumn();
            this.colisactive = new TreeListColumn();
            this.MenuGroup = new ContextMenuStrip(this.components);
            this.MenuGroupAddMain = new ToolStripMenuItem();
            this.MenuGroupAddChild = new ToolStripMenuItem();
            this.MenuGroupRename = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.MenuGroupMove = new ToolStripMenuItem();
            this.MenuGroupSetMain = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.panel1 = new Panel();
            this.cmdClose = new Button();
            this.panel2 = new Panel();
            this.splitterControl1 = new SplitterControl();
            this.ds.BeginInit();
            this.table_embrasuretypegroup.BeginInit();
            this.table_embrasuretype.BeginInit();
            this.MenuItem.SuspendLayout();
            this.gridViewItem.BeginInit();
            this.gridControlItem.BeginInit();
            this.treeListGroup.BeginInit();
            this.MenuGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.ds.DataSetName = "NewDataSet";
            this.ds.Relations.AddRange(new DataRelation[2]
      {
        new DataRelation("FK_embrasuretypegroup", "embrasuretypegroup", "embrasuretypegroup", new string[1]
        {
          "idembrasuretypegroup"
        }, new string[1]
        {
          "parentid"
        }, 0 != 0),
        new DataRelation("FK_embrasuretypegroup_embrasuretype", "embrasuretypegroup", "embrasuretype", new string[1]
        {
          "idembrasuretypegroup"
        }, new string[1]
        {
          "idembrasuretypegroup"
        }, 0 != 0)
      });
            this.ds.Tables.AddRange(new DataTable[2]
      {
        this.table_embrasuretypegroup,
        this.table_embrasuretype
      });
            this.table_embrasuretypegroup.Columns.AddRange(new DataColumn[5]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5
      });
            this.table_embrasuretypegroup.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idembrasuretypegroup"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("FK_embrasuretypegroup", "embrasuretypegroup", new string[1]
        {
          "idembrasuretypegroup"
        }, new string[1]
        {
          "parentid"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_embrasuretypegroup.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_embrasuretypegroup.TableName = "embrasuretypegroup";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idembrasuretypegroup";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "parentid";
            this.dataColumn2.DataType = typeof(int);
            this.dataColumn3.ColumnName = "name";
            this.dataColumn4.ColumnName = "comment";
            this.dataColumn5.ColumnName = "isactive";
            this.dataColumn5.DataType = typeof(bool);
            this.table_embrasuretype.Columns.AddRange(new DataColumn[5]
      {
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn9,
        this.dataColumn10,
        this.dataColumn6
      });
            this.table_embrasuretype.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idembrasuretype"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("FK_embrasuretypegroup_embrasuretype", "embrasuretypegroup", new string[1]
        {
          "idembrasuretypegroup"
        }, new string[1]
        {
          "idembrasuretypegroup"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_embrasuretype.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn7
      };
            this.table_embrasuretype.TableName = "embrasuretype";
            this.dataColumn7.AllowDBNull = false;
            this.dataColumn7.ColumnName = "idembrasuretype";
            this.dataColumn7.DataType = typeof(int);
            this.dataColumn8.ColumnName = "idembrasuretypegroup";
            this.dataColumn8.DataType = typeof(int);
            this.dataColumn9.ColumnName = "name";
            this.dataColumn10.ColumnName = "comment";
            this.dataColumn6.ColumnName = "shortname";
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(290, 22);
            this.MenuItemRemove.Text = "Удалить тип проёма";
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(287, 6);
            this.MenuItemChangeGroup.Name = "MenuItemChangeGroup";
            this.MenuItemChangeGroup.ShortcutKeys = Keys.F6;
            this.MenuItemChangeGroup.Size = new Size(290, 22);
            this.MenuItemChangeGroup.Text = "Переместить в группу...";
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(287, 6);
            this.MenuItemDoublicate.Name = "MenuItemDoublicate";
            this.MenuItemDoublicate.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuItemDoublicate.Size = new Size(290, 22);
            this.MenuItemDoublicate.Text = "Дублировать тип проёма";
            this.imageListGrop.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListGrop.ImageStream");
            this.imageListGrop.TransparentColor = Color.Magenta;
            this.imageListGrop.Images.SetKeyName(0, "Folder.ico");
            this.MenuGroupRemove.Name = "MenuGroupRemove";
            this.MenuGroupRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuGroupRemove.Size = new Size(308, 22);
            this.MenuGroupRemove.Text = "Удалить";
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAdd.Size = new Size(290, 22);
            this.MenuItemAdd.Text = "Добавить тип проёма";
            this.MenuItem.Items.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.MenuItemDoublicate,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemRemove,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.MenuItemChangeGroup
      });
            this.MenuItem.Name = "contextMenuStrip2";
            this.MenuItem.Size = new Size(291, 104);
            this.colidembrasuretypegroup.Caption = "idsellergroup";
            this.colidembrasuretypegroup.FieldName = "idembrasuretypegroup";
            this.colidembrasuretypegroup.Name = "colidembrasuretypegroup";
            this.colidembrasuretype.Caption = "#";
            this.colidembrasuretype.FieldName = "idembrasuretype";
            this.colidembrasuretype.Name = "colidembrasuretype";
            this.colidembrasuretype.OptionsColumn.AllowEdit = false;
            this.colidembrasuretype.Visible = true;
            this.colidembrasuretype.VisibleIndex = 0;
            this.colidembrasuretype.Width = 31;
            this.gridViewItem.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewItem.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewItem.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewItem.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewItem.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewItem.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewItem.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewItem.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewItem.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewItem.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewItem.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewItem.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewItem.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewItem.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewItem.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewItem.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewItem.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewItem.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewItem.BorderStyle = BorderStyles.Simple;
            this.gridViewItem.Columns.AddRange(new GridColumn[5]
      {
        this.colidembrasuretype,
        this.colname1,
        this.colcomment,
        this.colidembrasuretypegroup,
        this.colshortname
      });
            this.gridViewItem.GridControl = this.gridControlItem;
            this.gridViewItem.GroupPanelText = "Панель группировки";
            this.gridViewItem.Name = "gridViewItem";
            this.gridViewItem.OptionsCustomization.AllowFilter = false;
            this.gridViewItem.OptionsDetail.ShowDetailTabs = false;
            this.gridViewItem.OptionsSelection.MultiSelect = true;
            this.gridViewItem.OptionsView.ShowAutoFilterRow = true;
            this.gridViewItem.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewItem.OptionsView.ShowIndicator = false;
            this.colname1.Caption = "Наименование";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            this.colname1.Width = 142;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 2;
            this.colcomment.Width = 110;
            this.colshortname.Caption = "Сокращение";
            this.colshortname.FieldName = "shortname";
            this.colshortname.Name = "colshortname";
            this.colshortname.Visible = true;
            this.colshortname.VisibleIndex = 3;
            this.gridControlItem.ContextMenuStrip = this.MenuItem;
            this.gridControlItem.DataMember = "embrasuretypegroup.FK_embrasuretypegroup_embrasuretype";
            this.gridControlItem.DataSource = (object)this.ds;
            this.gridControlItem.Dock = DockStyle.Fill;
            this.gridControlItem.EmbeddedNavigator.Name = "";
            this.gridControlItem.Location = new Point(188, 0);
            this.gridControlItem.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlItem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlItem.MainView = (BaseView)this.gridViewItem;
            this.gridControlItem.Name = "gridControlItem";
            this.gridControlItem.Size = new Size(604, 410);
            this.gridControlItem.TabIndex = 12;
            this.gridControlItem.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewItem
      });
            this.cmdCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.FlatStyle = FlatStyle.Flat;
            this.cmdCancel.Location = new Point(705, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Отменить";
            this.cmdApply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdApply.FlatStyle = FlatStyle.Flat;
            this.cmdApply.Location = new Point(543, 5);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new Size(75, 23);
            this.cmdApply.TabIndex = 0;
            this.cmdApply.Text = "Применить";
            this.cmdOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdOk.DialogResult = DialogResult.OK;
            this.cmdOk.FlatStyle = FlatStyle.Flat;
            this.cmdOk.Location = new Point(624, 5);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new Size(75, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Выбрать";
            this.cmdReLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdReLoad.FlatStyle = FlatStyle.Flat;
            this.cmdReLoad.Location = new Point(624, 5);
            this.cmdReLoad.Name = "cmdReLoad";
            this.cmdReLoad.Size = new Size(75, 23);
            this.cmdReLoad.TabIndex = 1;
            this.cmdReLoad.Text = "Отменить";
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
        this.colname,
        this.colisactive
      });
            this.treeListGroup.ContextMenuStrip = this.MenuGroup;
            this.treeListGroup.DataMember = "embrasuretypegroup";
            this.treeListGroup.DataSource = (object)this.ds;
            this.treeListGroup.Dock = DockStyle.Left;
            this.treeListGroup.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeListGroup.ImageIndexFieldName = "_image";
            this.treeListGroup.KeyFieldName = "idembrasuretypegroup";
            this.treeListGroup.Location = new Point(0, 0);
            this.treeListGroup.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListGroup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListGroup.Name = "treeListGroup";
            this.treeListGroup.OptionsBehavior.Editable = false;
            this.treeListGroup.OptionsView.ShowHorzLines = false;
            this.treeListGroup.OptionsView.ShowIndicator = false;
            this.treeListGroup.OptionsView.ShowVertLines = false;
            this.treeListGroup.ParentFieldName = "parentid";
            this.treeListGroup.SelectImageList = (object)this.imageListGrop;
            this.treeListGroup.Size = new Size(182, 410);
            this.treeListGroup.TabIndex = 10;
            this.colname.Caption = "Группы проёмов";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 27;
            this.colname.Name = "colname";
            this.colname.VisibleIndex = 0;
            this.colname.Width = 149;
            this.colisactive.Caption = "V";
            this.colisactive.FieldName = "isactive";
            this.colisactive.Name = "colisactive";
            this.colisactive.VisibleIndex = 1;
            this.colisactive.Width = 31;
            this.MenuGroup.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.MenuGroupAddMain,
        (ToolStripItem) this.MenuGroupAddChild,
        (ToolStripItem) this.MenuGroupRename,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.MenuGroupMove,
        (ToolStripItem) this.MenuGroupSetMain,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuGroupRemove
      });
            this.MenuGroup.Name = "contextMenuStrip1";
            this.MenuGroup.Size = new Size(309, 148);
            this.MenuGroupAddMain.Name = "MenuGroupAddMain";
            this.MenuGroupAddMain.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuGroupAddMain.Size = new Size(308, 22);
            this.MenuGroupAddMain.Text = "Добавить основную группу";
            this.MenuGroupAddChild.Name = "MenuGroupAddChild";
            this.MenuGroupAddChild.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuGroupAddChild.Size = new Size(308, 22);
            this.MenuGroupAddChild.Text = "Добавить дочернюю группу";
            this.MenuGroupRename.Name = "MenuGroupRename";
            this.MenuGroupRename.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuGroupRename.Size = new Size(308, 22);
            this.MenuGroupRename.Text = "Редактировать";
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(305, 6);
            this.MenuGroupMove.Name = "MenuGroupMove";
            this.MenuGroupMove.ShortcutKeys = Keys.F6;
            this.MenuGroupMove.Size = new Size(308, 22);
            this.MenuGroupMove.Text = "Переместить в группу";
            this.MenuGroupSetMain.Name = "MenuGroupSetMain";
            this.MenuGroupSetMain.ShortcutKeys = Keys.M | Keys.Shift | Keys.Control;
            this.MenuGroupSetMain.Size = new Size(308, 22);
            this.MenuGroupSetMain.Text = "Сделать оновной";
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(305, 6);
            this.panel1.Controls.Add((Control)this.cmdClose);
            this.panel1.Controls.Add((Control)this.cmdReLoad);
            this.panel1.Controls.Add((Control)this.cmdApply);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(792, 33);
            this.panel1.TabIndex = 8;
            this.cmdClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdClose.FlatStyle = FlatStyle.Flat;
            this.cmdClose.Location = new Point(705, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new Size(75, 23);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Закрыть";
            this.panel2.Controls.Add((Control)this.cmdCancel);
            this.panel2.Controls.Add((Control)this.cmdOk);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(792, 33);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            this.splitterControl1.Location = new Point(182, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 410);
            this.splitterControl1.TabIndex = 11;
            this.splitterControl1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlItem);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.treeListGroup);
            this.Controls.Add((Control)this.panel1);
            this.Controls.Add((Control)this.panel2);
            this.Name = "EmbrasureTypeForm";
            this.Size = new Size(792, 476);
            this.Text = "Типы проемов";
            this.ds.EndInit();
            this.table_embrasuretypegroup.EndInit();
            this.table_embrasuretype.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.gridViewItem.EndInit();
            this.gridControlItem.EndInit();
            this.treeListGroup.EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
