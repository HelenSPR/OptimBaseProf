// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.SystemDetailRelationshipForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
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
    public class SystemDetailRelationshipForm : AtUserControl
    {
        private IContainer components;
        private PanelControl panelControl1;
        private SimpleButton simpleButtonApply;
        private SimpleButton simpleButtonCancel;
        private GridControl gridControlSystemRel;
        private GridView gridViewSystemRel;
        private DataSet ds;
        private DataTable systemdetail;
        private DataTable systemdetailrelationship;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private DataColumn dataColumn15;
        private DataColumn dataColumn16;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private DataColumn dataColumn19;
        private DataColumn dataColumn20;
        private GridColumn colidsystemdetailrelationship;
        private GridColumn colindent;
        private GridColumn colsystemdetail_name1;
        private GridColumn colsystemdetail_name2;
        private ContextMenuStrip contextMenuStripSystemRel;
        private ToolStripMenuItem toolStripMenuItemAdd;
        private ToolStripMenuItem toolStripMenuItemDelete;
        private SimpleButton simpleButtonClose;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DataColumn dataColumn4;

        public bool IsModyfiDS
        {
            get
            {
                return AtDataSet.quModifDataSet(this.ds) > 0;
            }
        }

        public SystemDetailRelationshipForm()
        {
            this.InitializeComponent();
            this.repositoryItemLookUpEdit1.DataSource = (object)this.systemdetail;
            this.repositoryItemLookUpEdit1.DisplayMember = "name";
            this.repositoryItemLookUpEdit1.ValueMember = "idsystemdetail";
            this.repositoryItemLookUpEdit2.DataSource = (object)this.systemdetail;
            this.repositoryItemLookUpEdit2.DisplayMember = "name";
            this.repositoryItemLookUpEdit2.ValueMember = "idsystemdetail";
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
            this.panelControl1 = new PanelControl();
            this.simpleButtonClose = new SimpleButton();
            this.simpleButtonApply = new SimpleButton();
            this.simpleButtonCancel = new SimpleButton();
            this.ds = new DataSet();
            this.systemdetail = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.systemdetailrelationship = new DataTable();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn15 = new DataColumn();
            this.dataColumn16 = new DataColumn();
            this.dataColumn17 = new DataColumn();
            this.dataColumn18 = new DataColumn();
            this.dataColumn19 = new DataColumn();
            this.dataColumn20 = new DataColumn();
            this.gridControlSystemRel = new GridControl();
            this.contextMenuStripSystemRel = new ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new ToolStripMenuItem();
            this.toolStripMenuItemDelete = new ToolStripMenuItem();
            this.gridViewSystemRel = new GridView();
            this.colidsystemdetailrelationship = new GridColumn();
            this.colindent = new GridColumn();
            this.colsystemdetail_name1 = new GridColumn();
            this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
            this.colsystemdetail_name2 = new GridColumn();
            this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
            this.panelControl1.BeginInit();
            this.panelControl1.SuspendLayout();
            this.ds.BeginInit();
            this.systemdetail.BeginInit();
            this.systemdetailrelationship.BeginInit();
            this.gridControlSystemRel.BeginInit();
            this.contextMenuStripSystemRel.SuspendLayout();
            this.gridViewSystemRel.BeginInit();
            this.repositoryItemLookUpEdit1.BeginInit();
            this.repositoryItemLookUpEdit2.BeginInit();
            this.SuspendLayout();
            this.panelControl1.BorderStyle = BorderStyles.Simple;
            this.panelControl1.Controls.Add((Control)this.simpleButtonClose);
            this.panelControl1.Controls.Add((Control)this.simpleButtonApply);
            this.panelControl1.Controls.Add((Control)this.simpleButtonCancel);
            this.panelControl1.Dock = DockStyle.Bottom;
            this.panelControl1.Location = new Point(0, 608);
            this.panelControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new Size(979, 32);
            this.panelControl1.TabIndex = 0;
            this.simpleButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonClose.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonClose.Location = new Point(899, 4);
            this.simpleButtonClose.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new Size(75, 23);
            this.simpleButtonClose.TabIndex = 2;
            this.simpleButtonClose.Text = "Закрыть";
            this.simpleButtonClose.Click += new EventHandler(this.simpleButtonClose_Click);
            this.simpleButtonApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonApply.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonApply.Location = new Point(737, 4);
            this.simpleButtonApply.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonApply.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonApply.Name = "simpleButtonApply";
            this.simpleButtonApply.Size = new Size(75, 23);
            this.simpleButtonApply.TabIndex = 1;
            this.simpleButtonApply.Text = "Применить";
            this.simpleButtonApply.Click += new EventHandler(this.simpleButton2_Click);
            this.simpleButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonCancel.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonCancel.Location = new Point(818, 4);
            this.simpleButtonCancel.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new Size(75, 23);
            this.simpleButtonCancel.TabIndex = 0;
            this.simpleButtonCancel.Text = "Отменить";
            this.simpleButtonCancel.Click += new EventHandler(this.simpleButton1_Click);
            this.ds.DataSetName = "ds";
            this.ds.Relations.AddRange(new DataRelation[1]
      {
        new DataRelation("system_systemdetailrelationship", "systemdetail", "systemdetailrelationship", new string[1]
        {
          "idsystemdetail"
        }, new string[1]
        {
          "idsystem"
        }, 0 != 0)
      });
            this.ds.Tables.AddRange(new DataTable[2]
      {
        this.systemdetail,
        this.systemdetailrelationship
      });
            this.systemdetail.Columns.AddRange(new DataColumn[4]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4
      });
            this.systemdetail.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idsystemdetail"
        }, 1 != 0)
      });
            this.systemdetail.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.systemdetail.TableName = "systemdetail";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idsystemdetail";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "modelpart_name";
            this.dataColumn4.ColumnName = "system_name";
            this.systemdetailrelationship.Columns.AddRange(new DataColumn[9]
      {
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14,
        this.dataColumn15,
        this.dataColumn16,
        this.dataColumn17,
        this.dataColumn18,
        this.dataColumn19,
        this.dataColumn20
      });
            this.systemdetailrelationship.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idsystemdetailrelationship"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("system_systemdetailrelationship", "systemdetail", new string[1]
        {
          "idsystemdetail"
        }, new string[1]
        {
          "idsystem"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.systemdetailrelationship.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn12
      };
            this.systemdetailrelationship.TableName = "systemdetailrelationship";
            this.dataColumn12.AllowDBNull = false;
            this.dataColumn12.ColumnName = "idsystemdetailrelationship";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.ColumnName = "idsystemdetail1";
            this.dataColumn13.DataType = typeof(int);
            this.dataColumn14.ColumnName = "idsystemdetail2";
            this.dataColumn14.DataType = typeof(int);
            this.dataColumn15.ColumnName = "indent";
            this.dataColumn15.DataType = typeof(int);
            this.dataColumn16.ColumnName = "deleted";
            this.dataColumn16.DataType = typeof(DateTime);
            this.dataColumn17.ColumnName = "idsystem";
            this.dataColumn17.DataType = typeof(int);
            this.dataColumn18.ColumnName = "system_name";
            this.dataColumn19.ColumnName = "systemdetail_name1";
            this.dataColumn20.ColumnName = "systemdetail_name2";
            this.gridControlSystemRel.ContextMenuStrip = this.contextMenuStripSystemRel;
            this.gridControlSystemRel.DataMember = "systemdetailrelationship";
            this.gridControlSystemRel.DataSource = (object)this.ds;
            this.gridControlSystemRel.Dock = DockStyle.Fill;
            this.gridControlSystemRel.EmbeddedNavigator.Name = "";
            this.gridControlSystemRel.Location = new Point(0, 0);
            this.gridControlSystemRel.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlSystemRel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlSystemRel.MainView = (BaseView)this.gridViewSystemRel;
            this.gridControlSystemRel.Name = "gridControlSystemRel";
            this.gridControlSystemRel.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit2
      });
            this.gridControlSystemRel.Size = new Size(979, 608);
            this.gridControlSystemRel.TabIndex = 0;
            this.gridControlSystemRel.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewSystemRel
      });
            this.contextMenuStripSystemRel.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripMenuItemAdd,
        (ToolStripItem) this.toolStripMenuItemDelete
      });
            this.contextMenuStripSystemRel.Name = "contextMenuStripSystemRel";
            this.contextMenuStripSystemRel.Size = new Size(125, 48);
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new Size(124, 22);
            this.toolStripMenuItemAdd.Text = "Добавить";
            this.toolStripMenuItemAdd.Click += new EventHandler(this.toolStripMenuItemAdd_Click);
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new Size(124, 22);
            this.toolStripMenuItemDelete.Text = "Удалить";
            this.toolStripMenuItemDelete.Click += new EventHandler(this.toolStripMenuItemDelete_Click);
            this.gridViewSystemRel.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewSystemRel.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewSystemRel.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewSystemRel.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewSystemRel.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewSystemRel.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewSystemRel.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewSystemRel.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewSystemRel.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewSystemRel.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewSystemRel.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewSystemRel.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewSystemRel.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewSystemRel.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewSystemRel.BorderStyle = BorderStyles.Simple;
            this.gridViewSystemRel.Columns.AddRange(new GridColumn[4]
      {
        this.colidsystemdetailrelationship,
        this.colindent,
        this.colsystemdetail_name1,
        this.colsystemdetail_name2
      });
            this.gridViewSystemRel.GridControl = this.gridControlSystemRel;
            this.gridViewSystemRel.GroupPanelText = "Панель группировки";
            this.gridViewSystemRel.Name = "gridViewSystemRel";
            this.gridViewSystemRel.OptionsFilter.AllowFilterEditor = false;
            this.gridViewSystemRel.OptionsView.ShowGroupPanel = false;
            this.gridViewSystemRel.OptionsView.ShowIndicator = false;
            this.colidsystemdetailrelationship.Caption = "#";
            this.colidsystemdetailrelationship.FieldName = "idsystemdetailrelationship";
            this.colidsystemdetailrelationship.Name = "colidsystemdetailrelationship";
            this.colidsystemdetailrelationship.OptionsColumn.AllowEdit = false;
            this.colidsystemdetailrelationship.OptionsFilter.AllowAutoFilter = false;
            this.colidsystemdetailrelationship.Visible = true;
            this.colidsystemdetailrelationship.VisibleIndex = 0;
            this.colindent.Caption = "Отступ";
            this.colindent.FieldName = "indent";
            this.colindent.Name = "colindent";
            this.colindent.OptionsFilter.AllowAutoFilter = false;
            this.colindent.Visible = true;
            this.colindent.VisibleIndex = 1;
            this.colsystemdetail_name1.Caption = "Элемент 1";
            this.colsystemdetail_name1.ColumnEdit = (RepositoryItem)this.repositoryItemLookUpEdit1;
            this.colsystemdetail_name1.FieldName = "idsystemdetail1";
            this.colsystemdetail_name1.Name = "colsystemdetail_name1";
            this.colsystemdetail_name1.OptionsFilter.AllowAutoFilter = false;
            this.colsystemdetail_name1.Visible = true;
            this.colsystemdetail_name1.VisibleIndex = 2;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemLookUpEdit1.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("system_name", "Система", 150),
        new LookUpColumnInfo("modelpart_name", "Часть", 150),
        new LookUpColumnInfo("name", "Элемент", 150)
      });
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.colsystemdetail_name2.Caption = "Элемент 2";
            this.colsystemdetail_name2.ColumnEdit = (RepositoryItem)this.repositoryItemLookUpEdit2;
            this.colsystemdetail_name2.FieldName = "idsystemdetail2";
            this.colsystemdetail_name2.Name = "colsystemdetail_name2";
            this.colsystemdetail_name2.OptionsFilter.AllowAutoFilter = false;
            this.colsystemdetail_name2.Visible = true;
            this.colsystemdetail_name2.VisibleIndex = 3;
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemLookUpEdit2.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("system_name", "Система", 150),
        new LookUpColumnInfo("modelpart_name", "Часть", 150),
        new LookUpColumnInfo("name", "Элемент", 150)
      });
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlSystemRel);
            this.Controls.Add((Control)this.panelControl1);
            this.Name = "SystemDetailRelationshipForm";
            this.Size = new Size(979, 640);
            this.Text = "Связи элементов систем";
            this.FormClosing += new FormClosing(this.SystemDetailRelationshipForm_FormClosing);
            this.panelControl1.EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ds.EndInit();
            this.systemdetail.EndInit();
            this.systemdetailrelationship.EndInit();
            this.gridControlSystemRel.EndInit();
            this.contextMenuStripSystemRel.ResumeLayout(false);
            this.gridViewSystemRel.EndInit();
            this.repositoryItemLookUpEdit1.EndInit();
            this.repositoryItemLookUpEdit2.EndInit();
            this.ResumeLayout(false);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.IsModyfiDS)
            {
                if (MessageBox.Show("Есть не сохраненные данные, продолжнить?", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    return;
                this.LoadFromBase();
            }
            else
                this.LoadFromBase();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        public override void LoadFromBase()
        {
            this.ds.Clear();
            this.db.command.CommandText = "\r\n            select\r\n            idsystemdetail,\r\n            sd.name,\r\n            modelpart_name,\r\n            system_name\r\n            from view_systemdetail sd\r\n\t            join system s on sd.idsystem=s.idsystem and s.deleted is null\r\n            where sd.deleted is null\r\n            ";
            this.db.adapter.Fill(this.ds, "systemdetail");
            this.db.command.CommandText = "\r\n                select\r\n                sr.idsystemdetailrelationship,\r\n                sr.idsystemdetail1,\r\n                sr.idsystemdetail2,\r\n                sr.indent,\r\n                sr.deleted,\r\n                sr.idsystem,\r\n                sr.system_name,\r\n                sr.systemdetail_name1,\r\n                sr.systemdetail_name2\r\n                from view_systemdetailrelationship sr\r\n                where sr.deleted is null";
            this.db.adapter.Fill(this.ds, "systemdetailrelationship");
        }

        public override bool SaveToBase()
        {
            try
            {
                if (this.systemdetailrelationship.Select("idsystemdetail1 is null or idsystemdetail2 is null").Length > 0)
                {
                    int num = (int)MessageBox.Show("Есть неопределенные соответствия элементов!", "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
                this.db.SaveDatatable2(this.systemdetailrelationship);
                this.systemdetailrelationship.AcceptChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            DataRow row = this.systemdetailrelationship.NewRow();
            row["idsystemdetailrelationship"] = (object)dbconn.GetGenId("gen_systemdetailrelationship");
            row["indent"] = (object)0;
            this.systemdetailrelationship.Rows.Add(row);
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlSystemRel);
            if (selectedDataRows == null)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void repositoryItemComboBox1_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            IdName idName = (IdName)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)idName.Name;
            AtGrid.getDataRow((Control)this.gridControlSystemRel)["idsystemdetail1"] = (object)idName.Id;
        }

        private void repositoryItemComboBox2_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            IdName idName = (IdName)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)idName.Name;
            AtGrid.getDataRow((Control)this.gridControlSystemRel)["idsystemdetail2"] = (object)idName.Id;
        }

        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SystemDetailRelationshipForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.IsModyfiDS)
                return;
            switch (MessageBox.Show("Есть не сохраненные данные, сохранить?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    this.SaveToBase();
                    break;
            }
        }
    }
}

