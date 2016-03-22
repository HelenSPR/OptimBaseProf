// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ServiceReasonForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
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
    public class ServiceReasonForm : AtUserControl
    {
        private IContainer components;
        public Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        public GridControl gridControl1;
        private GridView gridView1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private AtRepositoryItemTextEdit repositoryItemTextEdit2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private DataSet ds;
        private DataTable table_servicereason;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private GridColumn colidservicereason;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colpeople_fio;
        private GridColumn colnumpos;
        private GridColumn colreasoncode;
        private Panel panel2;
        private Button button4;
        private Button button5;

        public ServiceReasonForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.ServiceReasonForm_FormClosing);
            this.repositoryItemButtonEdit1.ButtonClick += new ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
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
            this.table_servicereason = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.gridView1 = new GridView();
            this.colidservicereason = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colpeople_fio = new GridColumn();
            this.repositoryItemButtonEdit1 = new RepositoryItemButtonEdit();
            this.colnumpos = new GridColumn();
            this.colreasoncode = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.repositoryItemButtonEdit2 = new RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit3 = new RepositoryItemButtonEdit();
            this.repositoryItemTextEdit2 = new AtRepositoryItemTextEdit();
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.panel1.SuspendLayout();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_servicereason.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemButtonEdit1.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemButtonEdit2.BeginInit();
            this.repositoryItemButtonEdit3.BeginInit();
            this.repositoryItemTextEdit2.BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(655, 33);
            this.panel1.TabIndex = 4;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(568, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(487, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(406, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "servicereason";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(0, 0);
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemButtonEdit1,
        (RepositoryItem) this.repositoryItemButtonEdit2,
        (RepositoryItem) this.repositoryItemButtonEdit3,
        (RepositoryItem) this.repositoryItemTextEdit2
      });
            this.gridControl1.Size = new Size(655, 427);
            this.gridControl1.TabIndex = 8;
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
            this.contextMenuStrip1.Size = new Size(154, 76);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(153, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(153, 22);
            this.toolStripMenuItem2.Text = "Дублировать";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(150, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(153, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.ds.DataSetName = "ds";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_servicereason
      });
            this.table_servicereason.Columns.AddRange(new DataColumn[7]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7
      });
            this.table_servicereason.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idservicereason"
        }, 1 != 0)
      });
            this.table_servicereason.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_servicereason.TableName = "servicereason";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idservicereason";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "idpeople";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "people_fio";
            this.dataColumn6.ColumnName = "numpos";
            this.dataColumn6.DataType = typeof(int);
            this.dataColumn7.ColumnName = "reasoncode";
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
            this.gridView1.Columns.AddRange(new GridColumn[6]
      {
        this.colidservicereason,
        this.colname,
        this.colcomment,
        this.colpeople_fio,
        this.colnumpos,
        this.colreasoncode
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colidservicereason.Caption = "#";
            this.colidservicereason.FieldName = "idservicereason";
            this.colidservicereason.Name = "colidservicereason";
            this.colidservicereason.OptionsColumn.AllowEdit = false;
            this.colidservicereason.Visible = true;
            this.colidservicereason.VisibleIndex = 5;
            this.colidservicereason.Width = 25;
            this.colname.Caption = "Наименование причины";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 240;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 3;
            this.colcomment.Width = 161;
            this.colpeople_fio.Caption = "Ответственное лицо";
            this.colpeople_fio.ColumnEdit = (RepositoryItem)this.repositoryItemButtonEdit1;
            this.colpeople_fio.FieldName = "people_fio";
            this.colpeople_fio.Name = "colpeople_fio";
            this.colpeople_fio.Visible = true;
            this.colpeople_fio.VisibleIndex = 4;
            this.colpeople_fio.Width = 302;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.colnumpos.Caption = "№пп";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 0;
            this.colnumpos.Width = 51;
            this.colreasoncode.Caption = "Код причины";
            this.colreasoncode.FieldName = "reasoncode";
            this.colreasoncode.Name = "colreasoncode";
            this.colreasoncode.Visible = true;
            this.colreasoncode.VisibleIndex = 1;
            this.colreasoncode.Width = 181;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "d";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "d";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "d";
            this.repositoryItemTextEdit1.Mask.MaskType = MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit3.AutoHeight = false;
            this.repositoryItemButtonEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit2.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit2.EditFormat.FormatString = "n2";
            this.repositoryItemTextEdit2.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(655, 33);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(568, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отменить";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.OK;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(487, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выбрать";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "ServiceReasonForm";
            this.Size = new Size(655, 493);
            this.Text = "Причины сервиса";
            this.panel1.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_servicereason.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemButtonEdit1.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemButtonEdit2.EndInit();
            this.repositoryItemButtonEdit3.EndInit();
            this.repositoryItemTextEdit2.EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow1 == null)
                return;
            Atechnology.ecad.Dictionary.People.SelectPeopleForm selectPeopleForm = new Atechnology.ecad.Dictionary.People.SelectPeopleForm(false);
            if (selectPeopleForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow2 = selectPeopleForm.SelectPeopleRows[0];
            if (dataRow2 == null)
                return;
            dataRow1["idpeople"] = dataRow2["idpeople"];
            dataRow1["people_fio"] = (object)dataRow2["people_fio"].ToString();
        }

        private void ServiceReasonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataTable(this.table_servicereason) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from view_servicereason where deleted is null";
            this.db.adapter.Fill(this.table_servicereason);
        }

        public override bool SaveToBase()
        {
            return this.db.SaveDatatableAndAccept2(this.table_servicereason);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_servicereason.NewRow();
            this.table_servicereason.Rows.Add(row);
            row["idservicereason"] = (object)dbconn.GetGenId("gen_servicereason");
            row["name"] = (object)"Новая причина";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["idservicereason"] = (object)dbconn.GetGenId("gen_servicereason");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow.Delete();
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

        public void IsDialog()
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.gridView1.OptionsBehavior.Editable = false;
            this.Is_Dialog = true;
        }
    }
}
