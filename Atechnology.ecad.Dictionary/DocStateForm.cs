// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.DocStateForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.Classes;
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
    public class DocStateForm : AtUserControl
    {
        private string _RowFilter = "";
        private DataView drvDocState;
        private bool _IsDialog;
        private IContainer components;
        private atButtonsPanel atButtonsPanel1;
        private PanelControl panelControlDialog;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemAdd;
        private ToolStripMenuItem toolStripMenuItemDouble;
        private ToolStripMenuItem toolStripMenuItemDelete;
        private SimpleButton simpleButtonOk;
        private SimpleButton simpleButtonCancel;
        private GridControl gridControlDocState;
        private GridView gridViewDocState;
        private GridColumn coliddocstate;
        private GridColumn colnumpos;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colbeginstate;
        private GridColumn colendstate;
        private GridColumn coldocappearance_name;
        private RepositoryItemComboBox repositoryItemComboBoxDocAppearance;

        public string RowFilter
        {
            get
            {
                return this._RowFilter;
            }
            set
            {
                this._RowFilter = value;
            }
        }

        public bool IsDialog
        {
            get
            {
                return this._IsDialog;
            }
            set
            {
                this._IsDialog = value;
                this.gridViewDocState.OptionsBehavior.Editable = !this.IsDialog;
                this.contextMenuStrip1.Enabled = !this.IsDialog;
                this.atButtonsPanel1.Visible = !this.IsDialog;
                this.panelControlDialog.Visible = this.IsDialog;
            }
        }

        public ds_docstate.docstateRow SelectedRow
        {
            get
            {
                return AtGrid.getDataRow((Control)this.gridControlDocState) as ds_docstate.docstateRow;
            }
        }

        public DocStateForm()
            : this("", new int?())
        {
        }

        public DocStateForm(string RowFilter, int? IdDocAppearance)
        {
            this.InitializeComponent();
            this.RowFilter = RowFilter;
            foreach (ds_docstate.docappearanceRow docappearanceRow in DocStateClass.dsDocState.docappearance)
            {
                if (!docappearanceRow.IsnameNull())
                    this.repositoryItemComboBoxDocAppearance.Items.Add((object)new IdName(docappearanceRow.iddocappearance, docappearanceRow.name));
            }
            this.repositoryItemComboBoxDocAppearance.ParseEditValue += new ConvertEditValueEventHandler(this.repositoryItemComboBoxDocAppearance_ParseEditValue);
            this.drvDocState = new DataView((DataTable)DocStateClass.dsDocState.docstate, "", "numpos", DataViewRowState.CurrentRows);
            this.SetFilter(IdDocAppearance);
            this.gridControlDocState.DataSource = (object)this.drvDocState;
            this.atButtonsPanel1.Save = new atButtonsPanel.SaveDelegate(((AtUserControl)this).SaveToBase);
            this.atButtonsPanel1.Cancel = new atButtonsPanel.CancelDelegate(((AtUserControl)this).LoadFromBase);
            this.atButtonsPanel1.Close = new atButtonsPanel.CloseDelegate(((AtUserControl)this).Close);
            this.FormClosing += new FormClosing(this.DocStateForm_FormClosing);
        }

        public void SetFilter(int? IdDocAppearance)
        {
            this.drvDocState.RowFilter = (!IdDocAppearance.HasValue ? "" : "iddocappearance=" + (object)IdDocAppearance) + this.RowFilter;
            this.IsDialog = IdDocAppearance.HasValue;
        }

        private void repositoryItemComboBoxDocAppearance_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (((ComboBoxEdit)sender).SelectedIndex == -1)
                return;
            IdName idName = (IdName)((ComboBoxEdit)sender).SelectedItem;
            e.Value = (object)idName.Name;
            AtGrid.getDataRow((Control)this.gridControlDocState)["iddocappearance"] = (object)idName.Id;
        }

        private void DocStateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AtDataSet.quModifDataSet((DataSet)DocStateClass.dsDocState) <= 0)
                return;
            DialogResult dialogResult = MessageBox.Show("Данные были изменены! Сохранить изменения?", "Закрытие справочника Статусов документов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                this.SaveToBase();
            if (dialogResult == DialogResult.No)
            {
                this.LoadFromBase();
            }
            else
            {
                if (dialogResult != DialogResult.Cancel)
                    return;
                e.Cancel = false;
            }
        }

        public override void LoadFromBase()
        {
            DocStateClass.LoadDocState();
        }

        public override bool SaveToBase()
        {
            try
            {
                this.BindingContext[(object)DocStateClass.dsDocState.docstate].EndCurrentEdit();
                this.db.SaveDatatable2((DataTable)DocStateClass.dsDocState.docstate);
                DocStateClass.dsDocState.AcceptChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            ds_docstate.docstateRow row = DocStateClass.dsDocState.docstate.NewdocstateRow();
            row.iddocstate = dbconn.GetGenId("gen_docstate");
            row.name = "Новый статус документа";
            row.beginstate = false;
            row.endstate = false;
            DocStateClass.dsDocState.docstate.AdddocstateRow(row);
        }

        private void toolStripMenuItemDouble_Click(object sender, EventArgs e)
        {
            ds_docstate.docstateRow docstateRow = AtGrid.getDataRow((Control)this.gridControlDocState) as ds_docstate.docstateRow;
            if (docstateRow == null)
                return;
            ds_docstate.docstateRow row = DocStateClass.dsDocState.docstate.NewdocstateRow();
            row.iddocstate = dbconn.GetGenId("gen_docstate");
            AtDataSet.LoadRow((DataRow)docstateRow, (DataRow)row, false);
            DocStateClass.dsDocState.docstate.AdddocstateRow(row);
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (AtGrid.getSelectedDataRows((Control)this.gridControlDocState) == null)
                return;
            foreach (DataRow dataRow in AtGrid.getSelectedDataRows((Control)this.gridControlDocState))
                dataRow.Delete();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            this.panelControlDialog = new PanelControl();
            this.simpleButtonOk = new SimpleButton();
            this.simpleButtonCancel = new SimpleButton();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new ToolStripMenuItem();
            this.toolStripMenuItemDouble = new ToolStripMenuItem();
            this.toolStripMenuItemDelete = new ToolStripMenuItem();
            this.gridControlDocState = new GridControl();
            this.gridViewDocState = new GridView();
            this.coliddocstate = new GridColumn();
            this.colnumpos = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colbeginstate = new GridColumn();
            this.colendstate = new GridColumn();
            this.coldocappearance_name = new GridColumn();
            this.repositoryItemComboBoxDocAppearance = new RepositoryItemComboBox();
            this.atButtonsPanel1.BeginInit();
            this.panelControlDialog.BeginInit();
            this.panelControlDialog.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gridControlDocState.BeginInit();
            this.gridViewDocState.BeginInit();
            this.repositoryItemComboBoxDocAppearance.BeginInit();
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
            this.atButtonsPanel1.Location = new Point(0, 468);
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
            this.atButtonsPanel1.Size = new Size(744, 33);
            this.atButtonsPanel1.TabIndex = 0;
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
            this.panelControlDialog.BorderStyle = BorderStyles.NoBorder;
            this.panelControlDialog.Controls.Add((Control)this.simpleButtonOk);
            this.panelControlDialog.Controls.Add((Control)this.simpleButtonCancel);
            this.panelControlDialog.Dock = DockStyle.Bottom;
            this.panelControlDialog.Location = new Point(0, 435);
            this.panelControlDialog.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.panelControlDialog.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControlDialog.Name = "panelControlDialog";
            this.panelControlDialog.Size = new Size(744, 33);
            this.panelControlDialog.TabIndex = 1;
            this.simpleButtonOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.simpleButtonOk.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonOk.DialogResult = DialogResult.OK;
            this.simpleButtonOk.Location = new Point(578, 6);
            this.simpleButtonOk.LookAndFeel.Style = LookAndFeelStyle.UltraFlat;
            this.simpleButtonOk.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonOk.Name = "simpleButtonOk";
            this.simpleButtonOk.Size = new Size(73, 23);
            this.simpleButtonOk.TabIndex = 1;
            this.simpleButtonOk.Text = "Выбрать";
            this.simpleButtonOk.Click += new EventHandler(this.simpleButton1_Click);
            this.simpleButtonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.simpleButtonCancel.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonCancel.DialogResult = DialogResult.Cancel;
            this.simpleButtonCancel.Location = new Point(657, 6);
            this.simpleButtonCancel.LookAndFeel.Style = LookAndFeelStyle.UltraFlat;
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new Size(73, 23);
            this.simpleButtonCancel.TabIndex = 0;
            this.simpleButtonCancel.Text = "Отменить";
            this.simpleButtonCancel.Click += new EventHandler(this.simpleButtonCancel_Click);
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.toolStripMenuItemAdd,
        (ToolStripItem) this.toolStripMenuItemDouble,
        (ToolStripItem) this.toolStripMenuItemDelete
      });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(220, 70);
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.toolStripMenuItemAdd.Size = new Size(219, 22);
            this.toolStripMenuItemAdd.Text = "Добавить";
            this.toolStripMenuItemAdd.Click += new EventHandler(this.toolStripMenuItemAdd_Click);
            this.toolStripMenuItemDouble.Name = "toolStripMenuItemDouble";
            this.toolStripMenuItemDouble.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.toolStripMenuItemDouble.Size = new Size(219, 22);
            this.toolStripMenuItemDouble.Text = "Дублировать";
            this.toolStripMenuItemDouble.Click += new EventHandler(this.toolStripMenuItemDouble_Click);
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.ShortcutKeys = Keys.Delete | Keys.Control;
            this.toolStripMenuItemDelete.Size = new Size(219, 22);
            this.toolStripMenuItemDelete.Text = "Удалить";
            this.toolStripMenuItemDelete.Click += new EventHandler(this.toolStripMenuItemDelete_Click);
            this.gridControlDocState.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlDocState.DataMember = "docstate";
            this.gridControlDocState.Dock = DockStyle.Fill;
            this.gridControlDocState.EmbeddedNavigator.Name = "";
            this.gridControlDocState.Location = new Point(0, 0);
            this.gridControlDocState.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlDocState.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlDocState.MainView = (BaseView)this.gridViewDocState;
            this.gridControlDocState.Name = "gridControlDocState";
            this.gridControlDocState.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemComboBoxDocAppearance
      });
            this.gridControlDocState.Size = new Size(744, 435);
            this.gridControlDocState.TabIndex = 3;
            this.gridControlDocState.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewDocState
      });
            this.gridViewDocState.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewDocState.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewDocState.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewDocState.BorderStyle = BorderStyles.Simple;
            this.gridViewDocState.Columns.AddRange(new GridColumn[7]
      {
        this.coliddocstate,
        this.colnumpos,
        this.colname,
        this.colcomment,
        this.colbeginstate,
        this.colendstate,
        this.coldocappearance_name
      });
            this.gridViewDocState.GridControl = this.gridControlDocState;
            this.gridViewDocState.GroupPanelText = "Панель группировки";
            this.gridViewDocState.Name = "gridViewDocState";
            this.gridViewDocState.OptionsView.ShowIndicator = false;
            this.coliddocstate.Caption = "#";
            this.coliddocstate.FieldName = "iddocstate";
            this.coliddocstate.Name = "coliddocstate";
            this.coliddocstate.Visible = true;
            this.coliddocstate.VisibleIndex = 0;
            this.colnumpos.Caption = "Номер";
            this.colnumpos.FieldName = "numpos";
            this.colnumpos.Name = "colnumpos";
            this.colnumpos.Visible = true;
            this.colnumpos.VisibleIndex = 1;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colcomment.Caption = "Коментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 3;
            this.colbeginstate.Caption = "Начальный статус";
            this.colbeginstate.FieldName = "beginstate";
            this.colbeginstate.Name = "colbeginstate";
            this.colbeginstate.Visible = true;
            this.colbeginstate.VisibleIndex = 4;
            this.colendstate.Caption = "Конечный статус";
            this.colendstate.FieldName = "endstate";
            this.colendstate.Name = "colendstate";
            this.colendstate.Visible = true;
            this.colendstate.VisibleIndex = 5;
            this.coldocappearance_name.Caption = "Вид документа";
            this.coldocappearance_name.ColumnEdit = (RepositoryItem)this.repositoryItemComboBoxDocAppearance;
            this.coldocappearance_name.FieldName = "docappearance_name";
            this.coldocappearance_name.Name = "coldocappearance_name";
            this.coldocappearance_name.Visible = true;
            this.coldocappearance_name.VisibleIndex = 6;
            this.repositoryItemComboBoxDocAppearance.AutoHeight = false;
            this.repositoryItemComboBoxDocAppearance.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemComboBoxDocAppearance.Name = "repositoryItemComboBoxDocAppearance";
            this.repositoryItemComboBoxDocAppearance.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlDocState);
            this.Controls.Add((Control)this.panelControlDialog);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.Name = "DocStateForm";
            this.Size = new Size(744, 501);
            this.Text = "Статусы документов";
            this.atButtonsPanel1.EndInit();
            this.panelControlDialog.EndInit();
            this.panelControlDialog.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gridControlDocState.EndInit();
            this.gridViewDocState.EndInit();
            this.repositoryItemComboBoxDocAppearance.EndInit();
            this.ResumeLayout(false);
        }
    }
}
