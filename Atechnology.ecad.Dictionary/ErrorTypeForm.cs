// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ErrorTypeForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
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
    public class ErrorTypeForm : AtUserControl
    {
        private IContainer components;
        private atButtonsPanel atButtonsPanel1;
        private ds_error ds;
        private GridView gridViewErrorType;
        private ContextMenuStrip MenuItem;
        private GridColumn colname;
        private GridColumn colcomment;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemDoublicate;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuItemRemove;
        public GridControl gridControlErrorType;
        private GridColumn coliderrortype;

        public ErrorTypeForm()
        {
            this.InitializeComponent();
            this.LoadFromBase();
        }

        public override void LoadFromBase()
        {
            this.ds.errortype.Load();
        }

        public override bool SaveToBase()
        {
            return this.ds.errortype.Save();
        }

        private void ErrorTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Is_Dialog)
            {
                this.SaveToBase();
            }
            else
            {
                if (!AtDataSet.IsModifDataTable((DataTable)this.ds.errortype))
                    return;
                switch (MessageBox.Show("Данные были изменены! Сохранить данные", "Типы ошибок", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
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

        private void ErrorTypeForm_Shown(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.gridViewErrorType.OptionsSelection.MultiSelect = false;
        }

        private void gridViewErrorType_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            this.ds.errortype.CreateRow();
        }

        private void MenuItemDoublicate_Click(object sender, EventArgs e)
        {
            this.ds.errortype.Doublicate(AtGrid.getSelectedDataRows((Control)this.gridControlErrorType));
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlErrorType);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
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
            this.atButtonsPanel1 = new atButtonsPanel();
            this.ds = new ds_error();
            this.gridControlErrorType = new GridControl();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.MenuItemAdd = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemDoublicate = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.gridViewErrorType = new GridView();
            this.coliderrortype = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.atButtonsPanel1.BeginInit();
            this.ds.BeginInit();
            this.gridControlErrorType.BeginInit();
            this.MenuItem.SuspendLayout();
            this.gridViewErrorType.BeginInit();
            this.SuspendLayout();
            this.atButtonsPanel1.AcceptButton = atButtonsPanel.bpButtons.Save;
            this.atButtonsPanel1.CancelButton = atButtonsPanel.bpButtons.Close;
            this.atButtonsPanel1.CancelButtonText = "";
            this.atButtonsPanel1.CancelButtonUseCancelSelect = false;
            this.atButtonsPanel1.CancelButtonVisible = false;
            this.atButtonsPanel1.CloseButtonText = "";
            this.atButtonsPanel1.CloseButtonUseCancelSelect = true;
            this.atButtonsPanel1.CloseButtonVisible = true;
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
            this.atButtonsPanel1.Location = new Point(0, 308);
            this.atButtonsPanel1.Name = "atButtonsPanel1";
            this.atButtonsPanel1.PrintButtonText = "";
            this.atButtonsPanel1.PrintButtonVisible = false;
            this.atButtonsPanel1.ProcessedIsDialog = true;
            this.atButtonsPanel1.RefreshButtonText = "Обновить";
            this.atButtonsPanel1.RefreshButtonUseSelectItem = false;
            this.atButtonsPanel1.RefreshButtonVisible = false;
            this.atButtonsPanel1.SaveButtonText = "Выбрать";
            this.atButtonsPanel1.SaveButtonUseSelectItem = true;
            this.atButtonsPanel1.SaveButtonVisible = true;
            this.atButtonsPanel1.ScriptButtonText = "";
            this.atButtonsPanel1.ScriptButtonVisible = false;
            this.atButtonsPanel1.Size = new Size(431, 33);
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
            this.ds.DataSetName = "ds_error";
            this.ds.EnforceConstraints = false;
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridControlErrorType.ContextMenuStrip = this.MenuItem;
            this.gridControlErrorType.DataMember = "errortype";
            this.gridControlErrorType.DataSource = (object)this.ds;
            this.gridControlErrorType.Dock = DockStyle.Fill;
            this.gridControlErrorType.EmbeddedNavigator.Name = "";
            this.gridControlErrorType.FormsUseDefaultLookAndFeel = false;
            this.gridControlErrorType.Location = new Point(0, 0);
            this.gridControlErrorType.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlErrorType.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlErrorType.MainView = (BaseView)this.gridViewErrorType;
            this.gridControlErrorType.Name = "gridControlErrorType";
            this.gridControlErrorType.Size = new Size(431, 308);
            this.gridControlErrorType.TabIndex = 0;
            this.gridControlErrorType.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewErrorType
      });
            this.MenuItem.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemDoublicate,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemRemove
      });
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new Size(220, 82);
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAdd.Size = new Size(219, 22);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemAdd.Click += new EventHandler(this.MenuItemAdd_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(216, 6);
            this.MenuItemDoublicate.Name = "MenuItemDoublicate";
            this.MenuItemDoublicate.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuItemDoublicate.Size = new Size(219, 22);
            this.MenuItemDoublicate.Text = "Дублировать";
            this.MenuItemDoublicate.Click += new EventHandler(this.MenuItemDoublicate_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(216, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(219, 22);
            this.MenuItemRemove.Text = "Удалить";
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            this.gridViewErrorType.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewErrorType.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewErrorType.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewErrorType.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewErrorType.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewErrorType.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewErrorType.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewErrorType.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewErrorType.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewErrorType.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewErrorType.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewErrorType.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewErrorType.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewErrorType.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewErrorType.BorderStyle = BorderStyles.Simple;
            this.gridViewErrorType.Columns.AddRange(new GridColumn[3]
      {
        this.coliderrortype,
        this.colname,
        this.colcomment
      });
            this.gridViewErrorType.GridControl = this.gridControlErrorType;
            this.gridViewErrorType.GroupPanelText = "Панель группировки";
            this.gridViewErrorType.Name = "gridViewErrorType";
            this.gridViewErrorType.OptionsLayout.StoreVisualOptions = false;
            this.gridViewErrorType.OptionsSelection.MultiSelect = true;
            this.gridViewErrorType.OptionsView.ShowAutoFilterRow = true;
            this.gridViewErrorType.OptionsView.ShowDetailButtons = false;
            this.gridViewErrorType.OptionsView.ShowIndicator = false;
            this.gridViewErrorType.DoubleClick += new EventHandler(this.gridViewErrorType_DoubleClick);
            this.coliderrortype.Caption = "#";
            this.coliderrortype.FieldName = "iderrortype";
            this.coliderrortype.Name = "coliderrortype";
            this.coliderrortype.OptionsColumn.AllowEdit = false;
            this.coliderrortype.OptionsFilter.AllowAutoFilter = false;
            this.coliderrortype.OptionsFilter.AllowFilter = false;
            this.coliderrortype.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.coliderrortype.Visible = true;
            this.coliderrortype.VisibleIndex = 0;
            this.coliderrortype.Width = 62;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsFilter.AllowAutoFilter = false;
            this.colname.OptionsFilter.AllowFilter = false;
            this.colname.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 183;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.OptionsFilter.AllowAutoFilter = false;
            this.colcomment.OptionsFilter.AllowFilter = false;
            this.colcomment.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 2;
            this.colcomment.Width = 184;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlErrorType);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.MinimumSize = new Size(431, 341);
            this.Name = "ErrorTypeForm";
            this.Size = new Size(431, 341);
            this.Text = "Типы ошибок";
            this.FormClosing += new FormClosing(this.ErrorTypeForm_FormClosing);
            this.Shown += new Shown(this.ErrorTypeForm_Shown);
            this.atButtonsPanel1.EndInit();
            this.ds.EndInit();
            this.gridControlErrorType.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.gridViewErrorType.EndInit();
            this.ResumeLayout(false);
        }
    }
}
