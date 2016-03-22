// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.StoreDepartForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class StoreDepartForm : AtUserControl
    {
        public int isdialog;
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridView gridView1;
        private DataSet ds;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private DataTable table_storedepart;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colpeople_fio;
        private GridColumn coldepartgroup;
        public GridControl gridControl1;
        private Panel panel2;
        private Button button4;
        private Button button5;
        private RepositoryItemButtonEdit ButtonEditPeople;

        public StoreDepartForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.StoreDepartForm_FormClosing);
            this.gridControl1.KeyDown += new KeyEventHandler(this.gridControl1_KeyDown);
            this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (this.isdialog != 1)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.isdialog != 1 || e.KeyCode != Keys.Return)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void StoreDepartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from view_storedepart where deleted is null";
            this.db.adapter.Fill(this.table_storedepart);
        }

        public override bool SaveToBase()
        {
            return this.db.SaveDatatableAndAccept2(this.table_storedepart);
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_storedepart.NewRow();
            row["idstoredepart"] = (object)dbconn.GetGenId("gen_storedepart");
            row["name"] = (object)"Новый склад материалов";
            this.table_storedepart.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["idstoredepart"] = (object)dbconn.GetGenId("gen_storedepart");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        public void IsDialog()
        {
            this.gridControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.isdialog = 1;
            this.gridView1.OptionsBehavior.Editable = false;
            this.panel1.Visible = false;
            this.panel2.Visible = true;
        }

        private void ButtonEditPeople_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            if (e.Button.Index == 0)
            {
                this.ButtonEditPeople.BeginUpdate();
                dataRow["idpeople"] = (object)DBNull.Value;
                dataRow["people_fio"] = (object)DBNull.Value;
                dataRow.EndEdit();
                this.ButtonEditPeople.EndUpdate();
            }
            else
            {
                Atechnology.ecad.Dictionary.People.SelectPeopleForm selectPeopleForm = new Atechnology.ecad.Dictionary.People.SelectPeopleForm(false);
                int num = (int)selectPeopleForm.ShowDialog();
                if (selectPeopleForm.SelectPeopleRows == null || selectPeopleForm.SelectPeopleRows.Length == 0)
                    return;
                dataRow["idpeople"] = selectPeopleForm.SelectPeopleRows[0]["idpeople"];
                dataRow["people_fio"] = selectPeopleForm.SelectPeopleRows[0]["people_fio"];
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
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.gridControl1 = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.table_storedepart = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.gridView1 = new GridView();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colpeople_fio = new GridColumn();
            this.coldepartgroup = new GridColumn();
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.ButtonEditPeople = new RepositoryItemButtonEdit();
            this.panel1.SuspendLayout();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_storedepart.BeginInit();
            this.gridView1.BeginInit();
            this.panel2.SuspendLayout();
            this.ButtonEditPeople.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(612, 33);
            this.panel1.TabIndex = 3;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(525, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(444, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(363, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "storedepart";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.FormsUseDefaultLookAndFeel = false;
            this.gridControl1.Location = new Point(0, 0);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.ButtonEditPeople
      });
            this.gridControl1.Size = new Size(612, 414);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItem3
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(220, 76);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItem1.Size = new Size(219, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItem2.Size = new Size(219, 22);
            this.toolStripMenuItem2.Text = "Дублировать";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(216, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItem3.Size = new Size(219, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.ds.DataSetName = "ds_storedepart";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_storedepart
      });
            this.table_storedepart.Columns.AddRange(new DataColumn[6]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6
      });
            this.table_storedepart.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idstoredepart"
        }, 1 != 0)
      });
            this.table_storedepart.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_storedepart.TableName = "storedepart";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idstoredepart";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "idpeople";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "people_fio";
            this.dataColumn5.Prefix = "local";
            this.dataColumn6.ColumnName = "departgroup";
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
            this.gridView1.Columns.AddRange(new GridColumn[4]
      {
        this.colname,
        this.colcomment,
        this.colpeople_fio,
        this.coldepartgroup
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 1;
            this.colpeople_fio.Caption = "Сотрудник (МОЛ)";
            this.colpeople_fio.ColumnEdit = (RepositoryItem)this.ButtonEditPeople;
            this.colpeople_fio.FieldName = "people_fio";
            this.colpeople_fio.Name = "colpeople_fio";
            this.colpeople_fio.Visible = true;
            this.colpeople_fio.VisibleIndex = 2;
            this.coldepartgroup.Caption = "Группа";
            this.coldepartgroup.FieldName = "departgroup";
            this.coldepartgroup.Name = "coldepartgroup";
            this.coldepartgroup.Visible = true;
            this.coldepartgroup.VisibleIndex = 3;
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(612, 33);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(525, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отмена";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.OK;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(444, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выбрать";
            this.ButtonEditPeople.AutoHeight = false;
            this.ButtonEditPeople.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton()
      });
            this.ButtonEditPeople.Name = "ButtonEditPeople";
            this.ButtonEditPeople.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.ButtonEditPeople.ButtonClick += new ButtonPressedEventHandler(this.ButtonEditPeople_ButtonClick);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "StoreDepartForm";
            this.Size = new Size(612, 480);
            this.Text = "Склады материалов";
            this.panel1.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_storedepart.EndInit();
            this.gridView1.EndInit();
            this.panel2.ResumeLayout(false);
            this.ButtonEditPeople.EndInit();
            this.ResumeLayout(false);
        }
    }
}
