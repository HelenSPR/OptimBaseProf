// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.PaymentGroupForm
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
    public class PaymentGroupForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridControl gridControl1;
        private GridView gridView1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private DataSet ds;
        private DataTable table_paymentgroup;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private GridColumn colname;
        private GridColumn colcomment;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        public int qu_modif;

        public PaymentGroupForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.PaymentGroupForm_FormClosing);
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
            this.table_paymentgroup = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.gridView1 = new GridView();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.panel1.SuspendLayout();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_paymentgroup.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(613, 33);
            this.panel1.TabIndex = 2;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(526, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(445, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(364, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "paymentgroup";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(0, 0);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemTextEdit1
      });
            this.gridControl1.Size = new Size(613, 441);
            this.gridControl1.TabIndex = 6;
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
            this.contextMenuStrip1.Size = new Size(231, 76);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItem1.Size = new Size(230, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItem2.Size = new Size(230, 22);
            this.toolStripMenuItem2.Text = "Дублировать";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(227, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItem3.Size = new Size(230, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.ds.DataSetName = "ds_paymentgroup";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_paymentgroup
      });
            this.table_paymentgroup.Columns.AddRange(new DataColumn[3]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3
      });
            this.table_paymentgroup.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idpaymentgroup"
        }, 1 != 0)
      });
            this.table_paymentgroup.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_paymentgroup.TableName = "paymentgroup";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idpaymentgroup";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
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
            this.gridView1.Columns.AddRange(new GridColumn[2]
      {
        this.colname,
        this.colcomment
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.panel1);
            this.Name = "PaymentGroupForm";
            this.Size = new Size(613, 474);
            this.Text = "Виды платежей";
            this.panel1.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_paymentgroup.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.ResumeLayout(false);
        }

        private void PaymentGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_paymentgroup.NewRow();
            row["idpaymentgroup"] = (object)dbconn.GetGenId("gen_paymentgroup");
            row["name"] = (object)"Новая вид платежей";
            this.table_paymentgroup.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["idpaymentgroup"] = (object)dbconn.GetGenId("gen_paymentgroup");
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
            this.qu_modif = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((this.qu_modif > 0 || this.db.quModifDataSet(this.ds) > 0) && MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.SaveToBase();
            this.Close();
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from paymentgroup where deleted is null";
            this.db.adapter.Fill(this.table_paymentgroup);
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDatatable2(this.table_paymentgroup))
                return false;
            this.table_paymentgroup.AcceptChanges();
            this.qu_modif = 0;
            return true;
        }
    }
}
