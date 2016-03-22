// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodParamNameForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class GoodParamNameForm : AtUserControl
    {
        private List<DataRow> changedRows = new List<DataRow>();
        private List<string> deletedRows = new List<string>();
        private IContainer components;
        private GridControl gridControl;
        private GridView gridView;
        private AtRepositoryItemTextEdit repositoryItemTextEdit13;
        private AtRepositoryItemTextEdit repositoryItemTextEdit12;
        private GridColumn nameColumn;
        private DataSet dataSet;
        private GridColumn commentColumn;
        private atButtonsPanel atButtonsPanel1;
        private DataTable goodparamname;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem createToolStripMenuItem;

        public DataRow Result { get; private set; }

        public GoodParamNameForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
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
            this.gridControl = new GridControl();
            this.contextMenuStrip = new ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripMenuItem1 = new ToolStripSeparator();
            this.deleteToolStripMenuItem = new ToolStripMenuItem();
            this.dataSet = new DataSet();
            this.goodparamname = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.gridView = new GridView();
            this.nameColumn = new GridColumn();
            this.commentColumn = new GridColumn();
            this.repositoryItemTextEdit12 = new AtRepositoryItemTextEdit();
            this.repositoryItemTextEdit13 = new AtRepositoryItemTextEdit();
            this.atButtonsPanel1 = new atButtonsPanel();
            this.gridControl.BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.dataSet.BeginInit();
            this.goodparamname.BeginInit();
            this.gridView.BeginInit();
            this.repositoryItemTextEdit12.BeginInit();
            this.repositoryItemTextEdit13.BeginInit();
            this.atButtonsPanel1.BeginInit();
            this.SuspendLayout();
            this.gridControl.ContextMenuStrip = this.contextMenuStrip;
            this.gridControl.DataMember = "goodparamname";
            this.gridControl.DataSource = (object)this.dataSet;
            this.gridControl.Dock = DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new Point(0, 0);
            this.gridControl.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl.MainView = (BaseView)this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemTextEdit12,
        (RepositoryItem) this.repositoryItemTextEdit13
      });
            this.gridControl.Size = new Size(746, 500);
            this.gridControl.TabIndex = 9;
            this.gridControl.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView
      });
            this.contextMenuStrip.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.createToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.deleteToolStripMenuItem
      });
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new Size(125, 54);
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new Size(124, 22);
            this.createToolStripMenuItem.Text = "Добавить";
            this.createToolStripMenuItem.Click += new EventHandler(this.createToolStripMenuItem_Click);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(121, 6);
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new Size(124, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new EventHandler(this.deleteToolStripMenuItem_Click);
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new DataTable[1]
      {
        this.goodparamname
      });
            this.goodparamname.Columns.AddRange(new DataColumn[3]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3
      });
            this.goodparamname.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodparamname"
        }, 1 != 0)
      });
            this.goodparamname.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.goodparamname.TableName = "goodparamname";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.Caption = "Номер";
            this.dataColumn1.ColumnName = "idgoodparamname";
            this.dataColumn1.DataType = typeof(uint);
            this.dataColumn2.Caption = "Наименование";
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.Caption = "Описание";
            this.dataColumn3.ColumnName = "comment";
            this.gridView.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView.BorderStyle = BorderStyles.Simple;
            this.gridView.Columns.AddRange(new GridColumn[2]
      {
        this.nameColumn,
        this.commentColumn
      });
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = "Панель группировки";
            this.gridView.Name = "gridView";
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsDetail.ShowDetailTabs = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.DoubleClick += new EventHandler(this.gridViewModelCalc_DoubleClick);
            this.gridView.CellValueChanged += new CellValueChangedEventHandler(this.gridViewModelCalc_CellValueChanged);
            this.nameColumn.Caption = "Наименование";
            this.nameColumn.FieldName = "name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 0;
            this.commentColumn.Caption = "Описание";
            this.commentColumn.FieldName = "comment";
            this.commentColumn.Name = "commentColumn";
            this.commentColumn.Visible = true;
            this.commentColumn.VisibleIndex = 1;
            this.repositoryItemTextEdit12.AutoHeight = false;
            this.repositoryItemTextEdit12.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit12.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit12.Name = "repositoryItemTextEdit12";
            this.repositoryItemTextEdit13.AutoHeight = false;
            this.repositoryItemTextEdit13.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit13.DisplayFormat.FormatType = FormatType.Numeric;
            this.repositoryItemTextEdit13.Name = "repositoryItemTextEdit13";
            this.atButtonsPanel1.AcceptButton = atButtonsPanel.bpButtons.None;
            this.atButtonsPanel1.CancelButton = atButtonsPanel.bpButtons.None;
            this.atButtonsPanel1.CancelButtonText = "";
            this.atButtonsPanel1.CancelButtonUseCancelSelect = true;
            this.atButtonsPanel1.CancelButtonVisible = true;
            this.atButtonsPanel1.CloseButtonText = "";
            this.atButtonsPanel1.CloseButtonUseCancelSelect = false;
            this.atButtonsPanel1.CloseButtonVisible = false;
            this.atButtonsPanel1.DataMember = (string)null;
            this.atButtonsPanel1.DataSource = (DataSet)null;
            this.atButtonsPanel1.Dock = DockStyle.Bottom;
            this.atButtonsPanel1.EnabledCancelButton = true;
            this.atButtonsPanel1.EnabledCloseButton = true;
            this.atButtonsPanel1.EnabledPrintButton = true;
            this.atButtonsPanel1.EnabledRefreshButton = true;
            this.atButtonsPanel1.EnabledSaveButton = true;
            this.atButtonsPanel1.EnabledScriptButton = true;
            this.atButtonsPanel1.IdDocAppearance = 0;
            this.atButtonsPanel1.Location = new Point(0, 500);
            this.atButtonsPanel1.Name = "atButtonsPanel1";
            this.atButtonsPanel1.PrintButtonText = "";
            this.atButtonsPanel1.PrintButtonVisible = false;
            this.atButtonsPanel1.ProcessedIsDialog = false;
            this.atButtonsPanel1.RefreshButtonText = "Обновить";
            this.atButtonsPanel1.RefreshButtonUseSelectItem = true;
            this.atButtonsPanel1.RefreshButtonVisible = true;
            this.atButtonsPanel1.SaveButtonText = "Выбрать";
            this.atButtonsPanel1.SaveButtonUseSelectItem = true;
            this.atButtonsPanel1.SaveButtonVisible = true;
            this.atButtonsPanel1.ScriptButtonText = "";
            this.atButtonsPanel1.ScriptButtonVisible = false;
            this.atButtonsPanel1.Size = new Size(746, 33);
            this.atButtonsPanel1.TabIndex = 10;
            this.atButtonsPanel1.TextCancelButton = "Отменить";
            this.atButtonsPanel1.TextCloseButton = "Закрыть";
            this.atButtonsPanel1.TextPrintButton = "Печать...";
            this.atButtonsPanel1.TextRefreshButton = "Обновить";
            this.atButtonsPanel1.TextSaveButton = "Применить";
            this.atButtonsPanel1.TextScriptButton = "Скрипты...";
            this.atButtonsPanel1.VisibleCancelButton = true;
            this.atButtonsPanel1.VisibleCloseButton = true;
            this.atButtonsPanel1.VisiblePrintButton = false;
            this.atButtonsPanel1.VisibleRefreshButton = false;
            this.atButtonsPanel1.VisibleSaveButton = true;
            this.atButtonsPanel1.VisibleScriptButton = false;
            this.atButtonsPanel1.WidthPrintButton = 75;
            this.atButtonsPanel1.CancelEvent += new atButtonsPanel.CancelEventDelegate(this.atButtonsPanel1_CancelEvent);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControl);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.Name = "GoodParamNameForm";
            this.Size = new Size(746, 533);
            this.Text = "Параметры материалов";
            this.Shown += new Shown(this.GoodParamNameForm_Shown);
            this.gridControl.EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.dataSet.EndInit();
            this.goodparamname.EndInit();
            this.gridView.EndInit();
            this.repositoryItemTextEdit12.EndInit();
            this.repositoryItemTextEdit13.EndInit();
            this.atButtonsPanel1.EndInit();
            this.ResumeLayout(false);
        }

        public override void LoadFromBase()
        {
            this.dataSet.Clear();
            this.goodparamname.Clear();
            base.LoadFromBase();
            dbconn._db.command.CommandText = "select idgoodparamname, name, comment from goodparamname where deleted is null";
            dbconn._db.adapter.Fill(this.goodparamname);
        }

        public override bool SaveToBase()
        {
            foreach (string str in this.deletedRows)
            {
                dbconn._db.command.CommandText = string.Format("update goodparam set idgoodparamname = null where idgoodparamname = {0}", (object)str);
                dbconn._db.Exec();
            }
            foreach (DataRow dataRow in this.changedRows)
            {
                dbconn._db.command.CommandText = string.Format("update goodparam set name = '{0}', comment = '{1}' where idgoodparamname = {2}", dataRow["name"], dataRow["comment"], dataRow["idgoodparamname"]);
                dbconn._db.Exec();
            }
            this.changedRows.Clear();
            this.deletedRows.Clear();
            return dbconn._db.SaveDataSetAndAccept(this.dataSet);
        }

        private void gridViewModelCalc_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle < 0)
                return;
            DataRow row = ((DataRowView)this.gridView.GetRow(e.RowHandle)).Row;
            this.changedRows.Remove(row);
            this.changedRows.Add(row);
        }

        private void GoodParamNameForm_Shown(object sender, EventArgs e)
        {
            this.nameColumn.OptionsColumn.ReadOnly = this.commentColumn.OptionsColumn.ReadOnly = this.Is_Dialog;
            this.nameColumn.OptionsColumn.AllowEdit = this.commentColumn.OptionsColumn.AllowEdit = !this.Is_Dialog;
            this.atButtonsPanel1.VisibleCancelButton = this.atButtonsPanel1.VisibleSaveButton = !this.Is_Dialog;
            if (!this.Is_Dialog)
                return;
            this.contextMenuStrip.Items.Clear();
        }

        private void gridViewModelCalc_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridView.FocusedRowHandle < 0)
                return;
            this.Result = AtGrid.getDataRow((Control)this.gridControl);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl);
            if (dataRow == null)
                return;
            this.deletedRows.Add(dataRow["idgoodparamname"].ToString());
            dataRow.Delete();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.goodparamname.Rows.Add((object)dbconn.GetGenId("gen_goodparamname"), (object)"Новый параметр", (object)DBNull.Value);
        }

        private void atButtonsPanel1_CancelEvent()
        {
            this.LoadFromBase();
        }
    }
}
