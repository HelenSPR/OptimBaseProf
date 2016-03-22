// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.PyramidForm
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
    public class PyramidForm : AtUserControl
    {
        private IContainer components;
        public GridControl gridControl1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private GridView gridView1;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private Panel panel2;
        private Button button4;
        private Button button5;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Button button3;
        private DataSet ds;
        private DataTable pyramid;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private GridColumn colidpyramid;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colnumpos;
        private GridColumn colqurow;
        private GridColumn colrowlen;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn9;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private GridColumn colwidth;
        private GridColumn colheight;
        private GridColumn coldepth;
        private GridColumn colselfdepth;
        private GridColumn colmaxwiwidth;
        private DataColumn dataColumn12;
        private GridColumn colweight;

        public PyramidForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.PyramidForm_FormClosing);
            this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
            this.gridView1.KeyDown += new KeyEventHandler(this.gridView1_KeyDown);
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
            this.gridControl1 = new GridControl();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.ds = new DataSet();
            this.pyramid = new DataTable();
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
            this.gridView1 = new GridView();
            this.colidpyramid = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colnumpos = new GridColumn();
            this.colqurow = new GridColumn();
            this.colrowlen = new GridColumn();
            this.colwidth = new GridColumn();
            this.colheight = new GridColumn();
            this.coldepth = new GridColumn();
            this.colselfdepth = new GridColumn();
            this.colmaxwiwidth = new GridColumn();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.panel2 = new Panel();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.dataColumn12 = new DataColumn();
            this.colweight = new GridColumn();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.pyramid.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemComboBox1.BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "pyramid";
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
        (RepositoryItem) this.repositoryItemComboBox1
      });
            this.gridControl1.Size = new Size(789, 353);
            this.gridControl1.TabIndex = 7;
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
            this.contextMenuStrip1.Size = new Size(147, 76);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(146, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(146, 22);
            this.toolStripMenuItem2.Text = "Дублировать";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(143, 6);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(146, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.ds.DataSetName = "ds";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.pyramid
      });
            this.pyramid.Columns.AddRange(new DataColumn[12]
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
        this.dataColumn12
      });
            this.pyramid.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idpyramid"
        }, 1 != 0)
      });
            this.pyramid.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.pyramid.TableName = "pyramid";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idpyramid";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "numpos";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "qurow";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "rowlen";
            this.dataColumn6.DataType = typeof(int);
            this.dataColumn7.Caption = "Ширина";
            this.dataColumn7.ColumnName = "width";
            this.dataColumn8.Caption = "Высота";
            this.dataColumn8.ColumnName = "height";
            this.dataColumn9.Caption = "Глубина";
            this.dataColumn9.ColumnName = "depth";
            this.dataColumn10.Caption = "Собс. глубина";
            this.dataColumn10.ColumnName = "selfdepth";
            this.dataColumn11.Caption = "Макс. ширина изделия";
            this.dataColumn11.ColumnName = "maxwiwidth";
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
            this.gridView1.Columns.AddRange(new GridColumn[12]
      {
        this.colidpyramid,
        this.colname,
        this.colcomment,
        this.colnumpos,
        this.colqurow,
        this.colrowlen,
        this.colwidth,
        this.colheight,
        this.coldepth,
        this.colselfdepth,
        this.colmaxwiwidth,
        this.colweight
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colidpyramid.Caption = "#";
            this.colidpyramid.FieldName = "idpyramid";
            this.colidpyramid.Name = "colidpyramid";
            this.colidpyramid.Visible = true;
            this.colidpyramid.VisibleIndex = 5;
            this.colidpyramid.Width = 73;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 213;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 4;
            this.colcomment.Width = 285;
            this.colnumpos.Caption = "№пп";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 0;
            this.colnumpos.Width = 58;
            this.colqurow.Caption = "Кол-во рядов";
            this.colqurow.FieldName = "qurow";
            this.colqurow.Name = "colqurow";
            this.colqurow.Visible = true;
            this.colqurow.VisibleIndex = 2;
            this.colqurow.Width = 85;
            this.colrowlen.Caption = "Длина ряда";
            this.colrowlen.FieldName = "rowlen";
            this.colrowlen.Name = "colrowlen";
            this.colrowlen.Visible = true;
            this.colrowlen.VisibleIndex = 3;
            this.colrowlen.Width = 73;
            this.colwidth.Caption = "Ширина";
            this.colwidth.FieldName = "width";
            this.colwidth.Name = "colwidth";
            this.colwidth.Visible = true;
            this.colwidth.VisibleIndex = 6;
            this.colheight.Caption = "Высота";
            this.colheight.FieldName = "height";
            this.colheight.Name = "colheight";
            this.colheight.Visible = true;
            this.colheight.VisibleIndex = 7;
            this.coldepth.Caption = "Глубина";
            this.coldepth.FieldName = "depth";
            this.coldepth.Name = "coldepth";
            this.coldepth.Visible = true;
            this.coldepth.VisibleIndex = 8;
            this.colselfdepth.Caption = "Собс. глубина";
            this.colselfdepth.FieldName = "selfdepth";
            this.colselfdepth.Name = "colselfdepth";
            this.colselfdepth.Visible = true;
            this.colselfdepth.VisibleIndex = 9;
            this.colmaxwiwidth.Caption = "Мак. ширина изд.";
            this.colmaxwiwidth.FieldName = "maxwiwidth";
            this.colmaxwiwidth.Name = "colmaxwiwidth";
            this.colmaxwiwidth.Visible = true;
            this.colmaxwiwidth.VisibleIndex = 10;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.panel2.Controls.Add((Control)this.button4);
            this.panel2.Controls.Add((Control)this.button5);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(789, 33);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(702, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отмена";
            this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button5.DialogResult = DialogResult.OK;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(621, 5);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выбрать";
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(621, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(540, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(789, 33);
            this.panel1.TabIndex = 5;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(702, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.dataColumn12.ColumnName = "weight";
            this.colweight.Caption = "Вес";
            this.colweight.FieldName = "weight";
            this.colweight.Name = "colweight";
            this.colweight.Visible = true;
            this.colweight.VisibleIndex = 11;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "PyramidForm";
            this.Size = new Size(789, 419);
            this.Text = "Пирамиды";
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.pyramid.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemComboBox1.EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void PyramidForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.Is_Dialog || e.KeyCode != Keys.Return)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!this.panel2.Visible)
                return;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.Close();
        }

        public override void LoadFromBase()
        {
            this.db.command.CommandText = "select * from pyramid where deleted is null";
            this.db.adapter.Fill(this.pyramid);
        }

        public override bool SaveToBase()
        {
            if (!this.db.SaveDatatable2(this.pyramid))
                return false;
            this.pyramid.AcceptChanges();
            return true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.pyramid.NewRow();
            row["idpyramid"] = (object)dbconn.GetGenId("gen_pyramid");
            row["name"] = (object)"Новый тип пирамид";
            this.pyramid.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["idpyramid"] = (object)dbconn.GetGenId("gen_pyramid");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow.Delete();
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
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridControl1.ContextMenuStrip = (ContextMenuStrip)null;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Is_Dialog = true;
        }
    }
}
