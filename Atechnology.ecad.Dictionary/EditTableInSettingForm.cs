// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.EditTableInSettingForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class EditTableInSettingForm : AtUserControl
    {
        private IContainer components;
        private DataSet ds;
        private DataTable table_setting;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private GridView gridViewTable;
        private GridControl gridControlTable;
        private atButtonsPanel atButtonsPanel1;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem MenuItemAddColumn;
        private ToolStripMenuItem MenuItemAddRow;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemRemoveRow;
        private ToolStripMenuItem MenuItemRemoveColumn;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuItemEditColumn;
        private ToolStripMenuItem MenuItemEditRow;
        private ToolStripMenuItem MenuItemCreateTable;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MenuItemLoadTableFromExcel;
        private ToolStripMenuItem MenuItemCreateTableFromExcel;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MenuItemClearTable;
        private DataRow drSetting;
        private DataTable table_workdata;

        public EditTableInSettingForm(DataRow _drSetting)
        {
            this.InitializeComponent();
            this.NeedRestoreLayout = true;
            this.NeedSaveLayout = true;
            this.drSetting = _drSetting;
            this.UnicleLayoutId = string.Format("{0}{1}", (object)this.Name, (object)("_tablevar_" + this.drSetting["idsetting"].ToString()));
            this.LoadFromBase();
            this.FormClosing += new FormClosing(this.EditTableInSettingForm_FormClosing);
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
            this.ds = new DataSet();
            this.table_setting = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.gridViewTable = new GridView();
            this.gridControlTable = new GridControl();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.MenuItemAddRow = new ToolStripMenuItem();
            this.MenuItemAddColumn = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.MenuItemCreateTable = new ToolStripMenuItem();
            this.MenuItemCreateTableFromExcel = new ToolStripMenuItem();
            this.MenuItemLoadTableFromExcel = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemEditRow = new ToolStripMenuItem();
            this.MenuItemEditColumn = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemRemoveRow = new ToolStripMenuItem();
            this.MenuItemRemoveColumn = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.MenuItemClearTable = new ToolStripMenuItem();
            this.atButtonsPanel1 = new atButtonsPanel();
            this.ds.BeginInit();
            this.table_setting.BeginInit();
            this.gridViewTable.BeginInit();
            this.gridControlTable.BeginInit();
            this.MenuItem.SuspendLayout();
            this.atButtonsPanel1.BeginInit();
            this.SuspendLayout();
            this.ds.DataSetName = "NewDataSet";
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_setting
      });
            this.table_setting.Columns.AddRange(new DataColumn[3]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3
      });
            this.table_setting.TableName = "setting";
            this.dataColumn1.ColumnName = "width";
            this.dataColumn1.DataType = typeof(double);
            this.dataColumn2.ColumnName = "height";
            this.dataColumn2.DataType = typeof(double);
            this.dataColumn3.ColumnName = "value";
            this.dataColumn3.DataType = typeof(double);
            this.gridViewTable.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewTable.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewTable.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewTable.GridControl = this.gridControlTable;
            this.gridViewTable.Name = "gridViewTable";
            this.gridViewTable.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewTable.OptionsCustomization.AllowFilter = false;
            this.gridViewTable.OptionsFilter.AllowFilterEditor = false;
            this.gridViewTable.OptionsFilter.AllowMRUFilterList = false;
            this.gridViewTable.OptionsView.ShowDetailButtons = false;
            this.gridViewTable.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewTable.OptionsView.ShowIndicator = false;
            this.gridControlTable.ContextMenuStrip = this.MenuItem;
            this.gridControlTable.Dock = DockStyle.Fill;
            this.gridControlTable.EmbeddedNavigator.Name = "";
            this.gridControlTable.Location = new Point(0, 0);
            this.gridControlTable.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlTable.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlTable.MainView = (BaseView)this.gridViewTable;
            this.gridControlTable.Name = "gridControlTable";
            this.gridControlTable.Size = new Size(618, 328);
            this.gridControlTable.TabIndex = 0;
            this.gridControlTable.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewTable
      });
            this.MenuItem.Items.AddRange(new ToolStripItem[14]
      {
        (ToolStripItem) this.MenuItemAddRow,
        (ToolStripItem) this.MenuItemAddColumn,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.MenuItemCreateTable,
        (ToolStripItem) this.MenuItemCreateTableFromExcel,
        (ToolStripItem) this.MenuItemLoadTableFromExcel,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemEditRow,
        (ToolStripItem) this.MenuItemEditColumn,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemRemoveRow,
        (ToolStripItem) this.MenuItemRemoveColumn,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.MenuItemClearTable
      });
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new Size(250, 248);
            this.MenuItemAddRow.Name = "MenuItemAddRow";
            this.MenuItemAddRow.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAddRow.Size = new Size(249, 22);
            this.MenuItemAddRow.Text = "Добавить строку";
            this.MenuItemAddRow.Click += new EventHandler(this.MenuItemAddRow_Click);
            this.MenuItemAddColumn.Name = "MenuItemAddColumn";
            this.MenuItemAddColumn.ShortcutKeys = Keys.Insert | Keys.Alt;
            this.MenuItemAddColumn.Size = new Size(249, 22);
            this.MenuItemAddColumn.Text = "Добавить столбец";
            this.MenuItemAddColumn.Click += new EventHandler(this.MenuItemAddColumn_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(246, 6);
            this.MenuItemCreateTable.Name = "MenuItemCreateTable";
            this.MenuItemCreateTable.ShortcutKeys = Keys.Insert | Keys.Control | Keys.Alt;
            this.MenuItemCreateTable.Size = new Size(249, 22);
            this.MenuItemCreateTable.Text = "Создать таблицу";
            this.MenuItemCreateTable.Click += new EventHandler(this.MenuItemCreateTable_Click);
            this.MenuItemCreateTableFromExcel.Name = "MenuItemCreateTableFromExcel";
            this.MenuItemCreateTableFromExcel.Size = new Size(249, 22);
            this.MenuItemCreateTableFromExcel.Text = "Создать таблицу из Excel";
            this.MenuItemCreateTableFromExcel.Click += new EventHandler(this.MenuItemCreateTableFromExcel_Click);
            this.MenuItemLoadTableFromExcel.Name = "MenuItemLoadTableFromExcel";
            this.MenuItemLoadTableFromExcel.Size = new Size(249, 22);
            this.MenuItemLoadTableFromExcel.Text = "Загрузить таблицу из Excel";
            this.MenuItemLoadTableFromExcel.Click += new EventHandler(this.MenuItemLoadTableFromExcel_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(246, 6);
            this.MenuItemEditRow.Name = "MenuItemEditRow";
            this.MenuItemEditRow.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuItemEditRow.Size = new Size(249, 22);
            this.MenuItemEditRow.Text = "Редактировать строку";
            this.MenuItemEditRow.Click += new EventHandler(this.MenuItemEditRow_Click);
            this.MenuItemEditColumn.Name = "MenuItemEditColumn";
            this.MenuItemEditColumn.ShortcutKeys = Keys.Return | Keys.Alt;
            this.MenuItemEditColumn.Size = new Size(249, 22);
            this.MenuItemEditColumn.Text = "Редактировать стобец";
            this.MenuItemEditColumn.Click += new EventHandler(this.MenuItemEditColumn_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(246, 6);
            this.MenuItemRemoveRow.Name = "MenuItemRemoveRow";
            this.MenuItemRemoveRow.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemoveRow.Size = new Size(249, 22);
            this.MenuItemRemoveRow.Text = "Удалить строку";
            this.MenuItemRemoveRow.Click += new EventHandler(this.MenuItemRemoveRow_Click);
            this.MenuItemRemoveColumn.Name = "MenuItemRemoveColumn";
            this.MenuItemRemoveColumn.ShortcutKeys = Keys.Delete | Keys.Alt;
            this.MenuItemRemoveColumn.Size = new Size(249, 22);
            this.MenuItemRemoveColumn.Text = "Удалить столбец";
            this.MenuItemRemoveColumn.Click += new EventHandler(this.MenuItemRemoveColumn_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(246, 6);
            this.MenuItemClearTable.Name = "MenuItemClearTable";
            this.MenuItemClearTable.Size = new Size(249, 22);
            this.MenuItemClearTable.Text = "Очистить таблицу";
            this.MenuItemClearTable.Click += new EventHandler(this.MenuItemClearTable_Click);
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
            this.atButtonsPanel1.Location = new Point(0, 328);
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
            this.atButtonsPanel1.Size = new Size(618, 33);
            this.atButtonsPanel1.TabIndex = 1;
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
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlTable);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.Name = "EditTableInSettingForm";
            this.Size = new Size(618, 361);
            this.Text = "Редактирование таблицы";
            this.ds.EndInit();
            this.table_setting.EndInit();
            this.gridViewTable.EndInit();
            this.gridControlTable.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.atButtonsPanel1.EndInit();
            this.ResumeLayout(false);
        }

        private void EditTableInSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AtDataSet.IsModifDataSet(this.ds))
                return;
            DialogResult dialogResult = MessageBox.Show("Данные таблицы были изменены! Сохранить изменения?", "Редактирование табличного значения", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                this.SaveToBase();
            e.Cancel = dialogResult == DialogResult.Cancel;
        }

        public override void LoadFromBase()
        {
            try
            {
                if (this.drSetting["blbvalue"] != DBNull.Value)
                {
                    int num = (int)this.ds.ReadXml((Stream)new MemoryStream(ZipArchiver.UnZip((byte[])this.drSetting["blbvalue"])));
                }
            }
            catch
            {
            }
            this.gridControlTable.DataMember = "";
            this.gridControlTable.DataSource = (object)null;
            this.gridViewTable.Columns.Clear();
            if (this.table_workdata != null)
            {
                this.table_workdata.Clear();
                this.table_workdata.Columns.Clear();
            }
            else
            {
                this.table_workdata = new DataTable("workdata");
                this.ds.Tables.Add(this.table_workdata);
            }
            this.table_workdata.Columns.Add(new DataColumn("Высота\\Ширина"));
            double double1;
            for (DataRow[] dataRowArray = this.table_setting.Select("", "width"); dataRowArray.Length > 0; dataRowArray = this.table_setting.Select("width > " + double1.ToString().Replace(',', '.'), "width"))
            {
                double1 = Useful.GetDouble(dataRowArray[0]["width"]);
                this.table_workdata.Columns.Add(new DataColumn(double1.ToString(), typeof(double)));
            }
            double double2;
            for (DataRow[] dataRowArray = this.table_setting.Select("", "height,width"); dataRowArray.Length > 0; dataRowArray = this.table_setting.Select("height > " + double2.ToString().Replace(',', '.'), "height,width"))
            {
                double2 = Useful.GetDouble(dataRowArray[0]["height"]);
                DataRow row = this.table_workdata.NewRow();
                this.table_workdata.Rows.Add(row);
                row["Высота\\Ширина"] = (object)double2.ToString();
                foreach (DataRow dataRow in dataRowArray)
                {
                    if (Useful.GetDouble(dataRow["height"]) == double2)
                        row[dataRow["width"].ToString()] = dataRow["value"];
                    else
                        break;
                }
            }
            this.gridControlTable.DataSource = (object)this.ds;
            this.gridControlTable.DataMember = "workdata";
            this.SetParamFirstColumn();
            this.ds.AcceptChanges();
        }

        public override bool SaveToBase()
        {
            this.ds.Tables.Remove(this.table_workdata);
            this.table_setting.Clear();
            DataRow[] dataRowArray = this.table_workdata.Select();
            int count = this.table_workdata.Columns.Count;
            for (int index1 = 0; index1 < dataRowArray.Length; ++index1)
            {
                for (int index2 = 1; index2 < count; ++index2)
                {
                    DataRow row = this.table_setting.NewRow();
                    this.table_setting.Rows.Add(row);
                    row["width"] = (object)Useful.GetDouble((object)this.table_workdata.Columns[index2].ColumnName);
                    row["height"] = dataRowArray[index1][0];
                    row["value"] = dataRowArray[index1][index2];
                }
            }
            MemoryStream memoryStream = new MemoryStream();
            this.ds.WriteXml((Stream)memoryStream, XmlWriteMode.WriteSchema);
            this.drSetting["blbvalue"] = (object)ZipArchiver.Zip(memoryStream.ToArray());
            this.ds.Tables.Add(this.table_workdata);
            this.table_workdata.AcceptChanges();
            this.ds.AcceptChanges();
            return true;
        }

        private void MenuItemAddColumn_Click(object sender, EventArgs e)
        {
            double DefValue = 0.0;
            if (this.table_workdata.Columns.Count > 1)
                DefValue = Useful.GetDouble((object)this.table_workdata.Columns[this.table_workdata.Columns.Count - 1].ColumnName);
            if (NumericInputBox.ShowDialog("Ввод значения нового столбца", "Ширина", DefValue) != DialogResult.OK)
                return;
            this.AddColumns(NumericInputBox.Value, NumericInputBox.Value, 1.0);
        }

        private void MenuItemAddRow_Click(object sender, EventArgs e)
        {
            double DefValue = 0.0;
            if (this.table_workdata.Rows.Count > 0)
                DefValue = Useful.GetDouble(this.table_workdata.Rows[this.table_workdata.Rows.Count - 1][0]);
            if (NumericInputBox.ShowDialog("Ввод значения новой строки", "Высота", DefValue) != DialogResult.OK)
                return;
            this.AddRows(NumericInputBox.Value, NumericInputBox.Value, 1.0);
        }

        private void MenuItemCreateTable_Click(object sender, EventArgs e)
        {
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            double num6 = 0.0;
            CreateTableForm createTableForm = new CreateTableForm();
            if (this.table_workdata.Columns.Count > 1)
            {
                num6 = Useful.GetDouble((object)this.table_workdata.Columns[this.table_workdata.Columns.Count - 1].ColumnName);
                num4 = Useful.GetDouble((object)this.table_workdata.Columns[1].ColumnName);
                if (this.table_workdata.Columns.Count > 2)
                    num5 = Useful.GetDouble((object)this.table_workdata.Columns[2].ColumnName) - Useful.GetDouble((object)this.table_workdata.Columns[1].ColumnName);
            }
            if (this.table_workdata.Rows.Count > 0)
            {
                num3 = Useful.GetDouble(this.table_workdata.Rows[this.table_workdata.Rows.Count - 1][0]);
                num1 = Useful.GetDouble(this.table_workdata.Rows[0][0]);
                if (this.table_workdata.Rows.Count > 1)
                    num2 = Useful.GetDouble(this.table_workdata.Rows[1][0]) - Useful.GetDouble(this.table_workdata.Rows[0][0]);
            }
            createTableForm.calcEditWidthEnd.Value = (Decimal)num6;
            createTableForm.calcEditWidthBegin.Value = (Decimal)num4;
            createTableForm.calcEditWidthStep.Value = (Decimal)num5;
            createTableForm.calcEditHeightEnd.Value = (Decimal)num3;
            createTableForm.calcEditHeightBegin.Value = (Decimal)num1;
            createTableForm.calcEditHeightStep.Value = (Decimal)num2;
            if (createTableForm.ShowDialog() != DialogResult.OK)
                return;
            double start1 = (double)createTableForm.calcEditHeightBegin.Value;
            double step1 = (double)createTableForm.calcEditHeightStep.Value;
            double finish1 = (double)createTableForm.calcEditHeightEnd.Value;
            double start2 = (double)createTableForm.calcEditWidthBegin.Value;
            double step2 = (double)createTableForm.calcEditWidthStep.Value;
            double finish2 = (double)createTableForm.calcEditWidthEnd.Value;
            this.ClearTable();
            this.AddColumns(start2, finish2, step2);
            this.AddRows(start1, finish1, step1);
        }

        private void MenuItemCreateTableFromExcel_Click(object sender, EventArgs e)
        {
            int BegRow = 0;
            int BegCol = 0;
            int EndRow = 0;
            int EndCol = 0;
            DataTable tableFromExcel = this.GetTableFromExcel(ref BegRow, ref BegCol, ref EndRow, ref EndCol);
            if (tableFromExcel == null || tableFromExcel.Rows.Count == 0)
                return;
            this.ClearTable();
            for (int index1 = BegCol + 1; index1 <= EndCol; ++index1)
            {
                double @double = Useful.GetDouble(tableFromExcel.Rows[BegRow][index1]);
                string index2 = tableFromExcel.Rows[BegRow][index1].ToString();
                if (tableFromExcel.Rows[BegRow][index1] == DBNull.Value || index2 == "" || this.table_workdata.Columns[index2] != null)
                {
                    tableFromExcel.Columns.RemoveAt(index1);
                    --index1;
                    --EndCol;
                }
                else
                    this.AddColumns(@double, @double, 1.0);
            }
            for (int index1 = BegRow + 1; index1 < EndRow + 1; ++index1)
            {
                Useful.GetDouble(tableFromExcel.Rows[index1][BegCol]);
                string str = tableFromExcel.Rows[index1][BegCol].ToString();
                if (tableFromExcel.Rows[index1][BegCol] == DBNull.Value || str == "" || this.table_workdata.Select("[Высота\\ширина] = '" + str.Replace(",", ".") + "'").Length != 0)
                {
                    tableFromExcel.Rows.RemoveAt(index1);
                    --index1;
                    --EndRow;
                }
                else
                {
                    DataRow row = this.table_workdata.NewRow();
                    this.table_workdata.Rows.Add(row);
                    for (int index2 = BegCol; index2 < EndCol + 1; ++index2)
                        row[index2 - BegCol] = tableFromExcel.Rows[index1][index2];
                }
            }
        }

        private void MenuItemLoadTableFromExcel_Click(object sender, EventArgs e)
        {
            int BegRow = 0;
            int BegCol = 0;
            int EndRow = 0;
            int EndCol = 0;
            DataTable tableFromExcel = this.GetTableFromExcel(ref BegRow, ref BegCol, ref EndRow, ref EndCol);
            if (tableFromExcel == null)
                return;
            if (tableFromExcel.Rows.Count == 0)
                return;
            try
            {
                int num = BegCol - 1;
                for (int index1 = 0; index1 < this.table_workdata.Rows.Count; ++index1)
                {
                    for (int index2 = 1; index2 < this.table_workdata.Columns.Count; ++index2)
                        this.table_workdata.Rows[index1][index2] = tableFromExcel.Rows[index1 + BegRow][index2 + num];
                }
            }
            catch
            {
            }
        }

        private void MenuItemEditColumn_Click(object sender, EventArgs e)
        {
            if (this.gridViewTable.FocusedColumn == null || this.gridViewTable.FocusedColumn == this.gridViewTable.Columns[0])
                return;
            string fieldName = this.gridViewTable.FocusedColumn.FieldName;
            if (NumericInputBox.ShowDialog("Ввод нового значения столбца", "Ширина", Useful.GetDouble((object)fieldName)) != DialogResult.OK)
                return;
            this.table_workdata.Columns[fieldName].ColumnName = NumericInputBox.Value.ToString();
            this.gridViewTable.FocusedColumn.FieldName = NumericInputBox.Value.ToString();
            this.gridViewTable.FocusedColumn.Caption = this.gridViewTable.FocusedColumn.FieldName;
        }

        private void MenuItemEditRow_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlTable);
            if (dataRow == null || NumericInputBox.ShowDialog("Ввод нового значения строки", "Высота", Useful.GetDouble(dataRow[0])) != DialogResult.OK)
                return;
            dataRow[0] = (object)NumericInputBox.Value.ToString();
        }

        private void MenuItemRemoveColumn_Click(object sender, EventArgs e)
        {
            if (this.gridViewTable.FocusedColumn == null)
                return;
            this.table_workdata.Columns.Remove(this.gridViewTable.FocusedColumn.FieldName);
            this.gridViewTable.Columns.Remove(this.gridViewTable.FocusedColumn);
        }

        private void MenuItemRemoveRow_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlTable);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        private void MenuItemClearTable_Click(object sender, EventArgs e)
        {
            this.ClearTable();
        }

        private void SetParamFirstColumn()
        {
            this.gridViewTable.Columns[0].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            this.gridViewTable.Columns[0].AppearanceHeader.TextOptions.VAlignment = VertAlignment.Center;
            this.gridViewTable.ColumnPanelRowHeight = 50;
            this.gridViewTable.Columns[0].AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;
            this.gridViewTable.Columns[0].AppearanceCell.BackColor = SystemColors.Control;
            this.gridViewTable.Columns[0].AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap;
            this.gridViewTable.Columns[0].OptionsColumn.AllowEdit = false;
            this.gridViewTable.Columns[0].OptionsColumn.AllowFocus = false;
            this.gridViewTable.Columns[0].Fixed = FixedStyle.Left;
            this.gridViewTable.Columns[0].Width = 150;
            this.gridViewTable.RowHeight = 15;
        }

        private void AddRows(double start, double finish, double step)
        {
            double num = start;
            while (num <= finish)
            {
                DataRow row = this.table_workdata.NewRow();
                row[0] = (object)num.ToString();
                this.table_workdata.Rows.Add(row);
                num += step;
            }
        }

        private void AddColumns(double start, double finish, double step)
        {
            double num = start;
            while (num <= finish)
            {
                this.table_workdata.Columns.Add(new DataColumn(num.ToString(), typeof(double)));
                num += step;
            }
            this.gridControlTable.DataMember = "";
            this.gridControlTable.DataSource = (object)null;
            this.gridViewTable.Columns.Clear();
            this.gridControlTable.DataSource = (object)this.ds;
            this.gridControlTable.DataMember = "workdata";
            this.SetParamFirstColumn();
        }

        private DataTable GetTableFromExcel(ref int BegRow, ref int BegCol, ref int EndRow, ref int EndCol)
        {
            DataTable dataTable = (DataTable)null;
            Atechnology.ecad.Dictionary.SettingsVar.GetExcelDataForm getExcelDataForm = new Atechnology.ecad.Dictionary.SettingsVar.GetExcelDataForm();
            if (getExcelDataForm.ShowDialog() != DialogResult.OK || getExcelDataForm.buttonEditFile.Text == "")
                return dataTable;
            if (!File.Exists(getExcelDataForm.buttonEditFile.Text))
            {
                int num = (int)MessageBox.Show("Файл не найден!", "Загрузка из Excel", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return dataTable;
            }
            if (getExcelDataForm.cboSheet.Text == "")
            {
                int num = (int)MessageBox.Show("Не выбран лист!", "Загрузка из Excel", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return dataTable;
            }
            OleDbConnection oleDbConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source=" + getExcelDataForm.buttonEditFile.Text + ";Extended Properties=\"Excel 8.0;HDR=NO\"");
            try
            {
                oleDbConnection.Open();
                dataTable = new DataTable();
                OleDbCommand selectCommand = new OleDbCommand();
                selectCommand.Connection = oleDbConnection;
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                selectCommand.CommandText = "select * from [" + getExcelDataForm.cboSheet.Text + "]";
                oleDbDataAdapter.Fill(dataTable);
            }
            catch
            {
                dataTable = (DataTable)null;
            }
            finally
            {
                oleDbConnection.Close();
            }
            BegCol = (int)getExcelDataForm.spinEditBeginColumn.Value - 1;
            BegRow = (int)getExcelDataForm.spinEditBeginRow.Value - 1;
            EndCol = (int)getExcelDataForm.spinEditEndColumn.Value - 1;
            EndRow = (int)getExcelDataForm.spinEditEndRow.Value - 1;
            return dataTable;
        }

        private void ClearTable()
        {
            this.table_workdata.Clear();
            while (this.table_workdata.Columns.Count > 1)
            {
                this.table_workdata.Columns.RemoveAt(1);
                this.gridViewTable.Columns.RemoveAt(1);
            }
        }
    }
}
