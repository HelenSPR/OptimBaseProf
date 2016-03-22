// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ValutForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.DataSets;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
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
    public class ValutForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridView gridView6;
        private ds_valut ds_valut1;
        private GridColumn colname;
        private GridColumn colshortname;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private GridColumn colisbase;
        public Panel panel2;
        private Button button4;
        private Button button5;
        public GridControl gridControl6;

        public ValutForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.ValutForm_FormClosing);
            this.gridView6.DoubleClick += new EventHandler(this.gridView6_DoubleClick);
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
            this.gridControl6 = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.ds_valut1 = new ds_valut();
            this.gridView6 = new GridView();
            this.colname = new GridColumn();
            this.colshortname = new GridColumn();
            this.colisbase = new GridColumn();
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.panel1.SuspendLayout();
            this.gridControl6.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds_valut1.BeginInit();
            this.gridView6.BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(713, 33);
            this.panel1.TabIndex = 4;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(626, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(545, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(464, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl6.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl6.DataMember = "valut";
            this.gridControl6.DataSource = (object)this.ds_valut1;
            this.gridControl6.Dock = DockStyle.Fill;
            this.gridControl6.EmbeddedNavigator.Name = "";
            this.gridControl6.Location = new Point(0, 0);
            this.gridControl6.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl6.MainView = (BaseView)this.gridView6;
            this.gridControl6.Name = "gridControl6";
            this.gridControl6.Size = new Size(713, 368);
            this.gridControl6.TabIndex = 11;
            this.gridControl6.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView6
      });
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(136, 48);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(135, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(135, 22);
            this.toolStripMenuItem2.Text = "Удалить";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.ds_valut1.DataSetName = "ds_valut";
            this.ds_valut1.EnforceConstraints = false;
            this.ds_valut1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridView6.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView6.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView6.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView6.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView6.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView6.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView6.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView6.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView6.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView6.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView6.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView6.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView6.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView6.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView6.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView6.BorderStyle = BorderStyles.Simple;
            this.gridView6.Columns.AddRange(new GridColumn[3]
      {
        this.colname,
        this.colshortname,
        this.colisbase
      });
            this.gridView6.GridControl = this.gridControl6;
            this.gridView6.GroupPanelText = "Панель группировки";
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsCustomization.AllowFilter = false;
            this.gridView6.OptionsDetail.ShowDetailTabs = false;
            this.gridView6.OptionsView.ShowDetailButtons = false;
            this.gridView6.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.OptionsView.ShowIndicator = false;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 278;
            this.colshortname.Caption = "Обозначение";
            this.colshortname.FieldName = "shortname";
            this.colshortname.Name = "colshortname";
            this.colshortname.Visible = true;
            this.colshortname.VisibleIndex = 1;
            this.colshortname.Width = 468;
            this.colisbase.Caption = "Основная";
            this.colisbase.FieldName = "isbase";
            this.colisbase.Name = "colisbase";
            this.colisbase.Visible = true;
            this.colisbase.VisibleIndex = 2;
            this.colisbase.Width = 90;
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(713, 33);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(626, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отменить";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.OK;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(545, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выбрать";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl6);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "ValutForm";
            this.Size = new Size(713, 434);
            this.Text = "Валюты";
            this.panel1.ResumeLayout(false);
            this.gridControl6.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds_valut1.EndInit();
            this.gridView6.EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void gridView6_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ValutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.colisbase.Visible = true;
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from valut where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds_valut1.valut);
        }

        public override bool SaveToBase()
        {
            return this.db.SaveDatatable2((DataTable)this.ds_valut1.valut);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds_valut1.Clear();
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.db.quModifDataSet((DataSet)this.ds_valut1) > 0 && MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.SaveToBase();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.ds_valut1.valut.NewRow();
            this.ds_valut1.valut.Rows.Add(row);
            row["idvalut"] = (object)dbconn.GetGenId("gen_valut");
            row["name"] = (object)"Новая валюта";
            row["isbase"] = (object)0;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl6);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        public void IsDialog()
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridView6.OptionsBehavior.Editable = false;
            this.Is_Dialog = true;
            this.colisbase.Visible = false;
        }
    }
}
