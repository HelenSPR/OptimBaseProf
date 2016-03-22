// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ErrorForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.Components.Tree;
using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.DataSets;
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
    public class ErrorForm : AtUserControl
    {
        private IContainer components;
        private atButtonsPanel atButtonsPanel1;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemDoublicate;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuItemRemove;
        private ds_error ds;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MenuItemMoveToGroup;
        private ToolStripMenuItem MenuItemEdit;
        private atButtonsPanel atButtonsPanelDialog;
        private AtTreeGroup atTreeGroup1;
        private SplitterControl splitterControl1;
        private GridControl gridControlError;
        private GridView gridViewError;
        private GridColumn coliderror;
        private GridColumn colcode;
        private GridColumn colname;
        private GridColumn colerrortype_name;
        private RepositoryItemButtonEdit ButtonEditErrorType;
        private GridColumn colmessage1;
        private GridColumn colmessage2;
        private GridColumn colmessage3;
        private GridColumn colunpack_picture;
        private RepositoryItemImageEdit ImageEditPic;
        private GridColumn colcomment;
        private GridColumn colshowtype_name;
        private RepositoryItemComboBox cboShowType;
        private GridColumn colissave;

        public bool IsDialog
        {
            get
            {
                return this.Is_Dialog;
            }
            set
            {
                this.Is_Dialog = value;
                this.atButtonsPanel1.Visible = !this.IsDialog;
                this.atButtonsPanelDialog.Visible = this.IsDialog;
                this.MenuItem.Enabled = !this.IsDialog;
                this.gridViewError.OptionsBehavior.Editable = !this.IsDialog;
                this.atTreeGroup1.OptionsBehavior.Editable = !this.IsDialog;
                this.atTreeGroup1.MenuGroup.Enabled = !this.IsDialog;
            }
        }

        public ds_error.errorRow SelectedRow
        {
            get
            {
                return AtGrid.getDataRow((Control)this.gridControlError) as ds_error.errorRow;
            }
        }

        public ErrorForm()
        {
            this.InitializeComponent();
            this.atTreeGroup1.InitData(true);
            this.IsDialog = false;
            this.atButtonsPanelDialog.Save = new atButtonsPanel.SaveDelegate(this.SaveMetodDialog);
            this.atButtonsPanelDialog.Cancel = new atButtonsPanel.CancelDelegate(this.CancelMetodDialog);
            this.LoadFromBase();
        }

        private bool SaveMetodDialog()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            return true;
        }

        private void CancelMetodDialog()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public override void LoadFromBase()
        {
            try
            {
                this.atTreeGroup1.saving = true;
                this.ds.Load();
            }
            finally
            {
                this.atTreeGroup1.saving = false;
            }
        }

        public override bool SaveToBase()
        {
            try
            {
                this.atTreeGroup1.saving = true;
                return this.ds.Save();
            }
            finally
            {
                this.atTreeGroup1.saving = false;
            }
        }

        private void ErrorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.IsDialog || !AtDataSet.IsModifDataSet((DataSet)this.ds))
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

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = this.atTreeGroup1.GetSelectedNode();
            if (selectedNode == null)
                return;
            this.ds.error.CreateRow(Useful.GetInt32(selectedNode["iderrorgroup"]));
        }

        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlError);
            if (dataRow == null)
                return;
            int num = (int)new ErrorEditForm(dataRow).ShowDialog();
        }

        private void MenuItemDoublicate_Click(object sender, EventArgs e)
        {
            this.ds.error.Doublicate(AtGrid.getSelectedDataRows((Control)this.gridControlError));
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControlError);
            if (selectedDataRows == null || selectedDataRows.Length == 0)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void MenuItemMoveToGroup_Click(object sender, EventArgs e)
        {
            this.atTreeGroup1.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlError);
        }

        private void ButtonEditErrorType_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow dataRow1 = AtGrid.getDataRow((Control)this.gridControlError);
            if (dataRow1 == null)
                return;
            this.ButtonEditErrorType.BeginUpdate();
            try
            {
                if (e.Button.Index == 0)
                {
                    dataRow1["iderrortype"] = (object)DBNull.Value;
                    dataRow1["errortype_name"] = (object)DBNull.Value;
                }
                else
                {
                    ErrorTypeForm errorTypeForm = new ErrorTypeForm();
                    if (errorTypeForm.ShowDialog() != DialogResult.OK)
                        return;
                    DataRow dataRow2 = AtGrid.getDataRow((Control)errorTypeForm.gridControlErrorType);
                    if (dataRow2 == null)
                        return;
                    dataRow1["iderrortype"] = dataRow2["iderrortype"];
                    dataRow1["errortype_name"] = dataRow2["name"];
                }
            }
            finally
            {
                this.ButtonEditErrorType.EndUpdate();
            }
        }

        private void cboShowType_EditValueChanging(object sender, ChangingEventArgs e)
        {
            ds_error.errorRow errorRow = (ds_error.errorRow)AtGrid.getDataRow((Control)this.gridControlError);
            if (errorRow == null)
                return;
            switch (e.NewValue.ToString())
            {
                case "Не отображать":
                    errorRow.showtype = 0;
                    break;
                case "Сообщение 1":
                    errorRow.showtype = 1;
                    break;
                case "Сообщение 2":
                    errorRow.showtype = 2;
                    break;
                case "Сообщение 3":
                    errorRow.showtype = 3;
                    break;
            }
        }

        private void ImageEditPic_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlError);
            if (dataRow == null)
                return;
            this.ImageEditPic.BeginUpdate();
            dataRow["unpack_picture"] = (object)DBNull.Value;
            this.ImageEditPic.EndUpdate();
        }

        private void gridViewError_DoubleClick(object sender, EventArgs e)
        {
            if (this.Is_Dialog)
                return;
            this.MenuItemEdit_Click((object)null, (EventArgs)null);
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
            this.MenuItem = new ContextMenuStrip(this.components);
            this.MenuItemAdd = new ToolStripMenuItem();
            this.MenuItemEdit = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemDoublicate = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.MenuItemMoveToGroup = new ToolStripMenuItem();
            this.ds = new ds_error();
            this.atButtonsPanelDialog = new atButtonsPanel();
            this.atTreeGroup1 = new AtTreeGroup();
            this.splitterControl1 = new SplitterControl();
            this.gridControlError = new GridControl();
            this.gridViewError = new GridView();
            this.coliderror = new GridColumn();
            this.colcode = new GridColumn();
            this.colname = new GridColumn();
            this.colerrortype_name = new GridColumn();
            this.ButtonEditErrorType = new RepositoryItemButtonEdit();
            this.colmessage1 = new GridColumn();
            this.colmessage2 = new GridColumn();
            this.colmessage3 = new GridColumn();
            this.colunpack_picture = new GridColumn();
            this.ImageEditPic = new RepositoryItemImageEdit();
            this.colcomment = new GridColumn();
            this.colshowtype_name = new GridColumn();
            this.cboShowType = new RepositoryItemComboBox();
            this.colissave = new GridColumn();
            this.atButtonsPanel1.BeginInit();
            this.MenuItem.SuspendLayout();
            this.ds.BeginInit();
            this.atButtonsPanelDialog.BeginInit();
            this.atTreeGroup1.BeginInit();
            this.gridControlError.BeginInit();
            this.gridViewError.BeginInit();
            this.ButtonEditErrorType.BeginInit();
            this.ImageEditPic.BeginInit();
            this.cboShowType.BeginInit();
            this.SuspendLayout();
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
            this.atButtonsPanel1.Location = new Point(0, 315);
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
            this.atButtonsPanel1.Size = new Size(736, 33);
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
            this.MenuItem.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.MenuItemEdit,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemDoublicate,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemRemove,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.MenuItemMoveToGroup
      });
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new Size(228, 132);
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAdd.Size = new Size(227, 22);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemAdd.Click += new EventHandler(this.MenuItemAdd_Click);
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.ShortcutKeys = Keys.Return | Keys.Control;
            this.MenuItemEdit.Size = new Size(227, 22);
            this.MenuItemEdit.Text = "Редактировать";
            this.MenuItemEdit.Click += new EventHandler(this.MenuItemEdit_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(224, 6);
            this.MenuItemDoublicate.Name = "MenuItemDoublicate";
            this.MenuItemDoublicate.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuItemDoublicate.Size = new Size(227, 22);
            this.MenuItemDoublicate.Text = "Дублировать";
            this.MenuItemDoublicate.Click += new EventHandler(this.MenuItemDoublicate_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(224, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(227, 22);
            this.MenuItemRemove.Text = "Удалить";
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(224, 6);
            this.MenuItemMoveToGroup.Name = "MenuItemMoveToGroup";
            this.MenuItemMoveToGroup.ShortcutKeys = Keys.M | Keys.Control;
            this.MenuItemMoveToGroup.Size = new Size(227, 22);
            this.MenuItemMoveToGroup.Text = "Переместить в группу";
            this.MenuItemMoveToGroup.Click += new EventHandler(this.MenuItemMoveToGroup_Click);
            this.ds.DataSetName = "ds_error";
            this.ds.EnforceConstraints = false;
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.atButtonsPanelDialog.AcceptButton = atButtonsPanel.bpButtons.None;
            this.atButtonsPanelDialog.CancelButton = atButtonsPanel.bpButtons.None;
            this.atButtonsPanelDialog.CancelButtonText = "";
            this.atButtonsPanelDialog.CancelButtonUseCancelSelect = true;
            this.atButtonsPanelDialog.CancelButtonVisible = true;
            this.atButtonsPanelDialog.CloseButtonText = "";
            this.atButtonsPanelDialog.CloseButtonUseCancelSelect = false;
            this.atButtonsPanelDialog.CloseButtonVisible = false;
            this.atButtonsPanelDialog.DataMember = (string)null;
            this.atButtonsPanelDialog.DataSource = (DataSet)null;
            this.atButtonsPanelDialog.Dock = DockStyle.Bottom;
            this.atButtonsPanelDialog.EnabledCancelButton = true;
            this.atButtonsPanelDialog.EnabledCloseButton = true;
            this.atButtonsPanelDialog.EnabledPrintButton = true;
            this.atButtonsPanelDialog.EnabledRefreshButton = true;
            this.atButtonsPanelDialog.EnabledSaveButton = true;
            this.atButtonsPanelDialog.EnabledScriptButton = true;
            this.atButtonsPanelDialog.IdDocAppearance = 0;
            this.atButtonsPanelDialog.Location = new Point(0, 282);
            this.atButtonsPanelDialog.Name = "atButtonsPanelDialog";
            this.atButtonsPanelDialog.PrintButtonText = "";
            this.atButtonsPanelDialog.PrintButtonVisible = false;
            this.atButtonsPanelDialog.ProcessedIsDialog = false;
            this.atButtonsPanelDialog.RefreshButtonText = "Обновить";
            this.atButtonsPanelDialog.RefreshButtonUseSelectItem = true;
            this.atButtonsPanelDialog.RefreshButtonVisible = true;
            this.atButtonsPanelDialog.SaveButtonText = "Выбрать";
            this.atButtonsPanelDialog.SaveButtonUseSelectItem = true;
            this.atButtonsPanelDialog.SaveButtonVisible = true;
            this.atButtonsPanelDialog.ScriptButtonText = "";
            this.atButtonsPanelDialog.ScriptButtonVisible = false;
            this.atButtonsPanelDialog.Size = new Size(736, 33);
            this.atButtonsPanelDialog.TabIndex = 5;
            this.atButtonsPanelDialog.TextCancelButton = "Отменить";
            this.atButtonsPanelDialog.TextCloseButton = "Закрыть";
            this.atButtonsPanelDialog.TextPrintButton = "Печать...";
            this.atButtonsPanelDialog.TextRefreshButton = "Обновить";
            this.atButtonsPanelDialog.TextSaveButton = "Выбрать";
            this.atButtonsPanelDialog.TextScriptButton = "Скрипты...";
            this.atButtonsPanelDialog.VisibleCancelButton = true;
            this.atButtonsPanelDialog.VisibleCloseButton = false;
            this.atButtonsPanelDialog.VisiblePrintButton = false;
            this.atButtonsPanelDialog.VisibleRefreshButton = false;
            this.atButtonsPanelDialog.VisibleSaveButton = true;
            this.atButtonsPanelDialog.VisibleScriptButton = false;
            this.atButtonsPanelDialog.WidthPrintButton = 75;
            this.atTreeGroup1.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeGroup1.Appearance.FocusedCell.ForeColor = Color.Black;
            this.atTreeGroup1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.atTreeGroup1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.atTreeGroup1.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeGroup1.Appearance.FocusedRow.ForeColor = Color.Black;
            this.atTreeGroup1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.atTreeGroup1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.atTreeGroup1.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeGroup1.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeGroup1.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.atTreeGroup1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.atTreeGroup1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.atTreeGroup1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.atTreeGroup1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.atTreeGroup1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.atTreeGroup1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.atTreeGroup1.BorderStyle = BorderStyles.Simple;
            this.atTreeGroup1.ColumnText = "Группы ошибок";
            this.atTreeGroup1.Connection = (dbconn)null;
            this.atTreeGroup1.DataMember = "errorgroup";
            this.atTreeGroup1.DataRelation = "errorgroup.FK_errorgroup_errorgroup";
            this.atTreeGroup1.DataSource = (object)this.ds;
            this.atTreeGroup1.Dock = DockStyle.Left;
            this.atTreeGroup1.FindEnableAddress = true;
            this.atTreeGroup1.FindEnableAgreeName = true;
            this.atTreeGroup1.FindEnableComment = true;
            this.atTreeGroup1.FindEnableCustomer = true;
            this.atTreeGroup1.FindEnableDest = true;
            this.atTreeGroup1.FindEnableDocName = true;
            this.atTreeGroup1.FindEnableDocOper = true;
            this.atTreeGroup1.FindEnableDtAgree = true;
            this.atTreeGroup1.FindEnableDtDoc = true;
            this.atTreeGroup1.FindEnableEditDir = true;
            this.atTreeGroup1.FindEnableSign = true;
            this.atTreeGroup1.GridView = (GridView)null;
            this.atTreeGroup1.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.atTreeGroup1.IdDocAppearance = "";
            this.atTreeGroup1.ImageIndexFieldName = "_imageindex";
            this.atTreeGroup1.IsSupportFilter = false;
            this.atTreeGroup1.KeyFieldName = "iderrorgroup";
            this.atTreeGroup1.Location = new Point(0, 0);
            this.atTreeGroup1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.atTreeGroup1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.atTreeGroup1.MoveItems = (DataRow[])null;
            this.atTreeGroup1.Name = "atTreeGroup1";
            this.atTreeGroup1.OptionsBehavior.AutoFocusNewNode = true;
            this.atTreeGroup1.OptionsView.ShowHorzLines = false;
            this.atTreeGroup1.OptionsView.ShowIndicator = false;
            this.atTreeGroup1.OptionsView.ShowVertLines = false;
            this.atTreeGroup1.ParentFieldName = "parentid";
            this.atTreeGroup1.PrimaryKeyName = "iderrorgroup";
            this.atTreeGroup1.Size = new Size(180, 282);
            this.atTreeGroup1.TabIndex = 7;
            this.atTreeGroup1.TableNameDiraction = "";
            this.splitterControl1.Location = new Point(180, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 282);
            this.splitterControl1.TabIndex = 8;
            this.splitterControl1.TabStop = false;
            this.gridControlError.ContextMenuStrip = this.MenuItem;
            this.gridControlError.DataMember = "errorgroup.FK_errorgroup_error";
            this.gridControlError.DataSource = (object)this.ds;
            this.gridControlError.Dock = DockStyle.Fill;
            this.gridControlError.EmbeddedNavigator.Name = "";
            this.gridControlError.Location = new Point(186, 0);
            this.gridControlError.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlError.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlError.MainView = (BaseView)this.gridViewError;
            this.gridControlError.Name = "gridControlError";
            this.gridControlError.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.ButtonEditErrorType,
        (RepositoryItem) this.ImageEditPic,
        (RepositoryItem) this.cboShowType
      });
            this.gridControlError.Size = new Size(550, 282);
            this.gridControlError.TabIndex = 9;
            this.gridControlError.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewError
      });
            this.gridViewError.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewError.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewError.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewError.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewError.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewError.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewError.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewError.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewError.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewError.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewError.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewError.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewError.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewError.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewError.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewError.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewError.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewError.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewError.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewError.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewError.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewError.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewError.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewError.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewError.BorderStyle = BorderStyles.Simple;
            this.gridViewError.Columns.AddRange(new GridColumn[11]
      {
        this.coliderror,
        this.colcode,
        this.colname,
        this.colerrortype_name,
        this.colmessage1,
        this.colmessage2,
        this.colmessage3,
        this.colunpack_picture,
        this.colcomment,
        this.colshowtype_name,
        this.colissave
      });
            this.gridViewError.GridControl = this.gridControlError;
            this.gridViewError.GroupPanelText = "Панель группировки";
            this.gridViewError.Name = "gridViewError";
            this.gridViewError.OptionsLayout.StoreVisualOptions = false;
            this.gridViewError.OptionsSelection.MultiSelect = true;
            this.gridViewError.OptionsView.ShowAutoFilterRow = true;
            this.gridViewError.OptionsView.ShowDetailButtons = false;
            this.gridViewError.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewError.OptionsView.ShowIndicator = false;
            this.coliderror.Caption = "#";
            this.coliderror.FieldName = "iderror";
            this.coliderror.Name = "coliderror";
            this.coliderror.OptionsColumn.AllowEdit = false;
            this.coliderror.OptionsFilter.AllowFilter = false;
            this.coliderror.Visible = true;
            this.coliderror.VisibleIndex = 0;
            this.colcode.Caption = "Код";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsFilter.AllowFilter = false;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 1;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsFilter.AllowFilter = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colerrortype_name.Caption = "Тип";
            this.colerrortype_name.ColumnEdit = (RepositoryItem)this.ButtonEditErrorType;
            this.colerrortype_name.FieldName = "errortype_name";
            this.colerrortype_name.Name = "colerrortype_name";
            this.colerrortype_name.OptionsFilter.AllowFilter = false;
            this.colerrortype_name.Visible = true;
            this.colerrortype_name.VisibleIndex = 3;
            this.ButtonEditErrorType.AutoHeight = false;
            this.ButtonEditErrorType.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton()
      });
            this.ButtonEditErrorType.Name = "ButtonEditErrorType";
            this.ButtonEditErrorType.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.ButtonEditErrorType.ButtonClick += new ButtonPressedEventHandler(this.ButtonEditErrorType_ButtonClick);
            this.colmessage1.Caption = "Сообщение 1";
            this.colmessage1.FieldName = "message1";
            this.colmessage1.Name = "colmessage1";
            this.colmessage1.OptionsFilter.AllowFilter = false;
            this.colmessage1.Visible = true;
            this.colmessage1.VisibleIndex = 5;
            this.colmessage2.Caption = "Сообщение 2";
            this.colmessage2.FieldName = "message2";
            this.colmessage2.Name = "colmessage2";
            this.colmessage2.OptionsFilter.AllowFilter = false;
            this.colmessage2.Visible = true;
            this.colmessage2.VisibleIndex = 6;
            this.colmessage3.Caption = "Сообщение 3";
            this.colmessage3.FieldName = "message3";
            this.colmessage3.Name = "colmessage3";
            this.colmessage3.OptionsFilter.AllowFilter = false;
            this.colmessage3.Visible = true;
            this.colmessage3.VisibleIndex = 7;
            this.colunpack_picture.Caption = "Картинка";
            this.colunpack_picture.ColumnEdit = (RepositoryItem)this.ImageEditPic;
            this.colunpack_picture.FieldName = "unpack_picture";
            this.colunpack_picture.Name = "colunpack_picture";
            this.colunpack_picture.OptionsFilter.AllowFilter = false;
            this.colunpack_picture.Visible = true;
            this.colunpack_picture.VisibleIndex = 8;
            this.ImageEditPic.ActionButtonIndex = 1;
            this.ImageEditPic.AutoHeight = false;
            this.ImageEditPic.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.ImageEditPic.Name = "ImageEditPic";
            this.ImageEditPic.PopupStartSize = new Size(292, 174);
            this.ImageEditPic.SizeMode = PictureSizeMode.Squeeze;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.OptionsFilter.AllowFilter = false;
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 4;
            this.colshowtype_name.Caption = "Отображать";
            this.colshowtype_name.ColumnEdit = (RepositoryItem)this.cboShowType;
            this.colshowtype_name.FieldName = "showtype_name";
            this.colshowtype_name.Name = "colshowtype_name";
            this.colshowtype_name.OptionsFilter.AllowFilter = false;
            this.colshowtype_name.Visible = true;
            this.colshowtype_name.VisibleIndex = 9;
            this.cboShowType.AutoHeight = false;
            this.cboShowType.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboShowType.Items.AddRange(new object[4]
      {
        (object) "Не отображать",
        (object) "Сообщение 1",
        (object) "Сообщение 2",
        (object) "Сообщение 3"
      });
            this.cboShowType.Name = "cboShowType";
            this.cboShowType.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboShowType.EditValueChanging += new ChangingEventHandler(this.cboShowType_EditValueChanging);
            this.colissave.Caption = "Сохранять";
            this.colissave.FieldName = "issave";
            this.colissave.Name = "colissave";
            this.colissave.OptionsFilter.AllowFilter = false;
            this.colissave.Visible = true;
            this.colissave.VisibleIndex = 10;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlError);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.atTreeGroup1);
            this.Controls.Add((Control)this.atButtonsPanelDialog);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.Name = "ErrorForm";
            this.Size = new Size(736, 348);
            this.Text = "Справочник ошибок";
            this.FormClosing += new FormClosing(this.ErrorForm_FormClosing);
            this.atButtonsPanel1.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.ds.EndInit();
            this.atButtonsPanelDialog.EndInit();
            this.atTreeGroup1.EndInit();
            this.gridControlError.EndInit();
            this.gridViewError.EndInit();
            this.ButtonEditErrorType.EndInit();
            this.ImageEditPic.EndInit();
            this.cboShowType.EndInit();
            this.ResumeLayout(false);
        }
    }
}
