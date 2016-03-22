// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.MeasureForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.Properties;
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
    public class MeasureForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GridControl gridControl1;
        private GridView gridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private DataSet ds;
        private DataTable table_measure;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colfactor;
        private DataColumn dataColumn5;
        private GridColumn colshortname;
        private ToolStripSeparator toolStripSeparator1;
        private AtRepositoryItemTextEdit repositoryItemTextEdit1;
        private DataColumn dataColumn6;
        private GridColumn colmeasure_typ;
        private RepositoryItemComboBox repositoryItemComboBox1;

        public MeasureForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.MeasureForm_FormClosing);
        }

        private void MeasureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AtDataSet.IsModifDataSet(this.ds))
                return;
            switch (MessageBox.Show("Данные были изменены! Сохранить изменения?", "Закрытие справочника единиц измерения", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
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
            this.db.command.CommandText = "select * from view_measure where deleted is null";
            this.db.adapter.Fill(this.table_measure);
            this.repositoryItemComboBox1.Items.Clear();
            this.repositoryItemComboBox1.Items.Add((object)"Количественный");
            this.repositoryItemComboBox1.Items.Add((object)"Линейный");
            this.repositoryItemComboBox1.Items.Add((object)"Плоскостной");
            this.repositoryItemComboBox1.Items.Add((object)"Объемный");
            this.repositoryItemComboBox1.Items.Add((object)"Весовой");
        }

        public override bool SaveToBase()
        {
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_measure.Rows)
            {
                dataRow.EndEdit();
                if (dataRow.RowState != DataRowState.Unchanged)
                {
                    switch (dataRow["measure_typ"].ToString())
                    {
                        case "Количественный":
                            dataRow["typ"] = (object)0;
                            continue;
                        case "Линейный":
                            dataRow["typ"] = (object)1;
                            continue;
                        case "Плоскостной":
                            dataRow["typ"] = (object)2;
                            continue;
                        case "Объемный":
                            dataRow["typ"] = (object)3;
                            continue;
                        case "Весовой":
                            dataRow["typ"] = (object)4;
                            continue;
                        default:
                            continue;
                    }
                }
            }
            return this.db.SaveDatatableAndAccept(this.table_measure);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_measure.NewRow();
            row["idmeasure"] = (object)dbconn.GetGenId("gen_measure");
            row["name"] = (object)"Новая единица измерения";
            this.table_measure.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow);
            dataRow["idmeasure"] = (object)dbconn.GetGenId("gen_measure");
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
            this.table_measure = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.gridView1 = new GridView();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colfactor = new GridColumn();
            this.repositoryItemTextEdit1 = new AtRepositoryItemTextEdit();
            this.colshortname = new GridColumn();
            this.colmeasure_typ = new GridColumn();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.panel1.SuspendLayout();
            this.gridControl1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ds.BeginInit();
            this.table_measure.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemTextEdit1.BeginInit();
            this.repositoryItemComboBox1.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(664, 33);
            this.panel1.TabIndex = 1;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(577, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(496, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(415, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataMember = "measure";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(0, 0);
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemComboBox1
      });
            this.gridControl1.Size = new Size(664, 389);
            this.gridControl1.TabIndex = 2;
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
            this.toolStripMenuItem1.Image = (Image)Resources.AddTable;
            this.toolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItem1.Size = new Size(230, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.toolStripMenuItem2.Image = (Image)Resources.ViewThumbnails;
            this.toolStripMenuItem2.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItem2.Size = new Size(230, 22);
            this.toolStripMenuItem2.Text = "Дублировать";
            this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(227, 6);
            this.toolStripMenuItem3.Image = (Image)Resources.Delete;
            this.toolStripMenuItem3.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItem3.Size = new Size(230, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.ds.DataSetName = "ds_measure";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_measure
      });
            this.table_measure.Columns.AddRange(new DataColumn[6]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn5,
        this.dataColumn6
      });
            this.table_measure.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idmeasure"
        }, 1 != 0)
      });
            this.table_measure.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_measure.TableName = "measure";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idmeasure";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "factor";
            this.dataColumn4.DataType = typeof(double);
            this.dataColumn5.ColumnName = "shortname";
            this.dataColumn6.ColumnName = "measure_typ";
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
        this.colname,
        this.colcomment,
        this.colfactor,
        this.colshortname,
        this.colmeasure_typ
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 188;
            this.colcomment.Caption = "Описание";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 1;
            this.colcomment.Width = 209;
            this.colfactor.Caption = "Коэффициент";
            this.colfactor.ColumnEdit = (RepositoryItem)this.repositoryItemTextEdit1;
            this.colfactor.FieldName = "factor";
            this.colfactor.Name = "colfactor";
            this.colfactor.Visible = true;
            this.colfactor.VisibleIndex = 4;
            this.colfactor.Width = 94;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.BorderStyle = BorderStyles.Default;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.colshortname.Caption = "Обозначение";
            this.colshortname.FieldName = "shortname";
            this.colshortname.Name = "colshortname";
            this.colshortname.Visible = true;
            this.colshortname.VisibleIndex = 2;
            this.colshortname.Width = 132;
            this.colmeasure_typ.Caption = "Тип";
            this.colmeasure_typ.ColumnEdit = (RepositoryItem)this.repositoryItemComboBox1;
            this.colmeasure_typ.FieldName = "measure_typ";
            this.colmeasure_typ.Name = "colmeasure_typ";
            this.colmeasure_typ.Visible = true;
            this.colmeasure_typ.VisibleIndex = 3;
            this.colmeasure_typ.Width = 151;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.BorderStyle = BorderStyles.Default;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(664, 422);
            this.Controls.Add((Control)this.gridControl1);
            this.Controls.Add((Control)this.panel1);
            this.Name = "MeasureForm";
            this.Text = "Единицы измерения";
            this.panel1.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_measure.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemTextEdit1.EndInit();
            this.repositoryItemComboBox1.EndInit();
            this.ResumeLayout(false);
        }
    }
}
