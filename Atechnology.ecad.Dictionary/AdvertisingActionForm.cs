// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.AdvertisingActionForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.Components.Tree;
using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.DataSets;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
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
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class AdvertisingActionForm : AtUserControl
    {
        private IContainer components;
        private ds_advertising ds;
        private atButtonsPanel atButtonsPanel1;
        private AtTreeListControl AtTreeListControl;
        private SplitterControl splitterControl1;
        private GridControl gridControlAdvertisingAction;
        private GridView gridViewAdvertisingAction;
        private GridColumn colidadvertisingaction;
        private GridColumn colname;
        private GridColumn coldtstart;
        private GridColumn coldtfinish;
        private GridColumn colperc;
        private GridColumn colsm;
        private GridColumn colcomment;
        private GridColumn colvalut_shortname;
        private GridColumn colisactive;
        private RepositoryItemComboBox cboValut;
        private ContextMenuStrip MenuItem;
        private ToolStripMenuItem MenuItemAdd;
        private ToolStripMenuItem MenuItemDoublicate;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemRemove;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuItemMoveToGroup;
        private RepositoryItemCalcEdit CalcEditSum;
        private bool DisableEvent;
        private bool IsActiveOnly;
        public DataRow Result;

        public AdvertisingActionForm(bool _IsActiveOnly)
        {
            this.DisableEvent = true;
            this.InitializeComponent();
            this.IsActiveOnly = _IsActiveOnly;
            this.AtTreeListControl.InitData(true);
            this.LoadFromBase();
            this.cboValut.EditValueChanging += new ChangingEventHandler(this.cboValut_EditValueChanging);
            this.Shown += new Shown(this.AdvertisingActionForm_Shown);
            this.FormClosing += new FormClosing(this.AdvertisingActionForm_FormClosing);
        }

        public AdvertisingActionForm()
            : this(false)
        {
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
            this.ds = new ds_advertising();
            this.atButtonsPanel1 = new atButtonsPanel();
            this.AtTreeListControl = new AtTreeListControl();
            this.splitterControl1 = new SplitterControl();
            this.gridControlAdvertisingAction = new GridControl();
            this.MenuItem = new ContextMenuStrip(this.components);
            this.MenuItemAdd = new ToolStripMenuItem();
            this.MenuItemDoublicate = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemRemove = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.MenuItemMoveToGroup = new ToolStripMenuItem();
            this.gridViewAdvertisingAction = new GridView();
            this.colidadvertisingaction = new GridColumn();
            this.colname = new GridColumn();
            this.coldtstart = new GridColumn();
            this.coldtfinish = new GridColumn();
            this.colperc = new GridColumn();
            this.CalcEditSum = new RepositoryItemCalcEdit();
            this.colsm = new GridColumn();
            this.colcomment = new GridColumn();
            this.colvalut_shortname = new GridColumn();
            this.cboValut = new RepositoryItemComboBox();
            this.colisactive = new GridColumn();
            this.ds.BeginInit();
            this.atButtonsPanel1.BeginInit();
            this.AtTreeListControl.BeginInit();
            this.gridControlAdvertisingAction.BeginInit();
            this.MenuItem.SuspendLayout();
            this.gridViewAdvertisingAction.BeginInit();
            this.CalcEditSum.BeginInit();
            this.cboValut.BeginInit();
            this.SuspendLayout();
            this.ds.DataSetName = "ds_advertising";
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.atButtonsPanel1.AcceptButton = atButtonsPanel.bpButtons.Save;
            this.atButtonsPanel1.CancelButton = atButtonsPanel.bpButtons.Cancel;
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
            this.atButtonsPanel1.Location = new Point(0, 319);
            this.atButtonsPanel1.Name = "atButtonsPanel1";
            this.atButtonsPanel1.PrintButtonText = "";
            this.atButtonsPanel1.PrintButtonVisible = false;
            this.atButtonsPanel1.ProcessedIsDialog = true;
            this.atButtonsPanel1.RefreshButtonText = "Обновить";
            this.atButtonsPanel1.RefreshButtonUseSelectItem = true;
            this.atButtonsPanel1.RefreshButtonVisible = false;
            this.atButtonsPanel1.SaveButtonText = "Выбрать";
            this.atButtonsPanel1.SaveButtonUseSelectItem = true;
            this.atButtonsPanel1.SaveButtonVisible = true;
            this.atButtonsPanel1.ScriptButtonText = "";
            this.atButtonsPanel1.ScriptButtonVisible = false;
            this.atButtonsPanel1.Size = new Size(778, 33);
            this.atButtonsPanel1.TabIndex = 3;
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
            this.AtTreeListControl.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.AtTreeListControl.Appearance.FocusedCell.ForeColor = Color.Black;
            this.AtTreeListControl.Appearance.FocusedCell.Options.UseBackColor = true;
            this.AtTreeListControl.Appearance.FocusedCell.Options.UseForeColor = true;
            this.AtTreeListControl.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.AtTreeListControl.Appearance.FocusedRow.ForeColor = Color.Black;
            this.AtTreeListControl.Appearance.FocusedRow.Options.UseBackColor = true;
            this.AtTreeListControl.Appearance.FocusedRow.Options.UseForeColor = true;
            this.AtTreeListControl.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.AtTreeListControl.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.AtTreeListControl.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.AtTreeListControl.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.AtTreeListControl.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.AtTreeListControl.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.AtTreeListControl.Appearance.SelectedRow.ForeColor = Color.Black;
            this.AtTreeListControl.Appearance.SelectedRow.Options.UseBackColor = true;
            this.AtTreeListControl.Appearance.SelectedRow.Options.UseForeColor = true;
            this.AtTreeListControl.BorderStyle = BorderStyles.Simple;
            this.AtTreeListControl.ColumnText = "Группы акций";
            this.AtTreeListControl.Connection = (dbconn)null;
            this.AtTreeListControl.DataMember = "advertisingactiongroup";
            this.AtTreeListControl.DataRelation = "advertisingactiongroup.FK_advertisingactiongroup_advertisingaction";
            this.AtTreeListControl.DataSource = (object)this.ds;
            this.AtTreeListControl.Dock = DockStyle.Left;
            this.AtTreeListControl.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.AtTreeListControl.ImageIndexFieldName = "_imageindex";
            this.AtTreeListControl.IsSupportFilter = false;
            this.AtTreeListControl.KeyFieldName = "idadvertisingactiongroup";
            this.AtTreeListControl.Location = new Point(0, 0);
            this.AtTreeListControl.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.AtTreeListControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.AtTreeListControl.MoveItems = (DataRow[])null;
            this.AtTreeListControl.Name = "AtTreeListControl";
            this.AtTreeListControl.OptionsBehavior.AutoFocusNewNode = true;
            this.AtTreeListControl.OptionsView.ShowHorzLines = false;
            this.AtTreeListControl.OptionsView.ShowIndicator = false;
            this.AtTreeListControl.OptionsView.ShowVertLines = false;
            this.AtTreeListControl.ParentFieldName = "parentid";
            this.AtTreeListControl.PrimaryKeyName = "idadvertisingactiongroup";
            this.AtTreeListControl.Size = new Size(215, 319);
            this.AtTreeListControl.TabIndex = 0;
            this.splitterControl1.Location = new Point(215, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new Size(6, 319);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            this.gridControlAdvertisingAction.ContextMenuStrip = this.MenuItem;
            this.gridControlAdvertisingAction.DataMember = "advertisingactiongroup.FK_advertisingactiongroup_advertisingaction";
            this.gridControlAdvertisingAction.DataSource = (object)this.ds;
            this.gridControlAdvertisingAction.Dock = DockStyle.Fill;
            this.gridControlAdvertisingAction.EmbeddedNavigator.Name = "";
            this.gridControlAdvertisingAction.Location = new Point(221, 0);
            this.gridControlAdvertisingAction.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlAdvertisingAction.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlAdvertisingAction.MainView = (BaseView)this.gridViewAdvertisingAction;
            this.gridControlAdvertisingAction.Name = "gridControlAdvertisingAction";
            this.gridControlAdvertisingAction.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.cboValut,
        (RepositoryItem) this.CalcEditSum
      });
            this.gridControlAdvertisingAction.Size = new Size(557, 319);
            this.gridControlAdvertisingAction.TabIndex = 2;
            this.gridControlAdvertisingAction.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewAdvertisingAction
      });
            this.MenuItem.Items.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.MenuItemAdd,
        (ToolStripItem) this.MenuItemDoublicate,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemRemove,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.MenuItemMoveToGroup
      });
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new Size(228, 104);
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemAdd.Size = new Size(227, 22);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemAdd.Click += new EventHandler(this.MenuItemAdd_Click);
            this.MenuItemDoublicate.Name = "MenuItemDoublicate";
            this.MenuItemDoublicate.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuItemDoublicate.Size = new Size(227, 22);
            this.MenuItemDoublicate.Text = "Дублировать";
            this.MenuItemDoublicate.Click += new EventHandler(this.MenuItemDoublicate_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(224, 6);
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemRemove.Size = new Size(227, 22);
            this.MenuItemRemove.Text = "Удалить";
            this.MenuItemRemove.Click += new EventHandler(this.MenuItemRemove_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(224, 6);
            this.MenuItemMoveToGroup.Name = "MenuItemMoveToGroup";
            this.MenuItemMoveToGroup.ShortcutKeys = Keys.M | Keys.Control;
            this.MenuItemMoveToGroup.Size = new Size(227, 22);
            this.MenuItemMoveToGroup.Text = "Переместить в группу";
            this.MenuItemMoveToGroup.Click += new EventHandler(this.MenuItemMoveToGroup_Click);
            this.gridViewAdvertisingAction.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.FocusedRow.ForeColor = SystemColors.ControlText;
            this.gridViewAdvertisingAction.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewAdvertisingAction.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewAdvertisingAction.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewAdvertisingAction.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewAdvertisingAction.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.HideSelectionRow.ForeColor = SystemColors.ControlText;
            this.gridViewAdvertisingAction.Appearance.HideSelectionRow.GradientMode = LinearGradientMode.Vertical;
            this.gridViewAdvertisingAction.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewAdvertisingAction.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridViewAdvertisingAction.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewAdvertisingAction.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewAdvertisingAction.Appearance.SelectedRow.ForeColor = SystemColors.ControlText;
            this.gridViewAdvertisingAction.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewAdvertisingAction.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewAdvertisingAction.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewAdvertisingAction.BorderStyle = BorderStyles.Simple;
            this.gridViewAdvertisingAction.Columns.AddRange(new GridColumn[9]
      {
        this.colidadvertisingaction,
        this.colname,
        this.coldtstart,
        this.coldtfinish,
        this.colperc,
        this.colsm,
        this.colcomment,
        this.colvalut_shortname,
        this.colisactive
      });
            this.gridViewAdvertisingAction.GridControl = this.gridControlAdvertisingAction;
            this.gridViewAdvertisingAction.GroupPanelText = "Панель группировки";
            this.gridViewAdvertisingAction.Name = "gridViewAdvertisingAction";
            this.gridViewAdvertisingAction.OptionsCustomization.AllowFilter = false;
            this.gridViewAdvertisingAction.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAdvertisingAction.OptionsView.ShowDetailButtons = false;
            this.gridViewAdvertisingAction.OptionsView.ShowIndicator = false;
            this.gridViewAdvertisingAction.DoubleClick += new EventHandler(this.gridViewAdvertisingAction_DoubleClick);
            this.colidadvertisingaction.Caption = "#";
            this.colidadvertisingaction.FieldName = "idadvertisingaction";
            this.colidadvertisingaction.Name = "colidadvertisingaction";
            this.colidadvertisingaction.OptionsColumn.AllowEdit = false;
            this.colidadvertisingaction.Visible = true;
            this.colidadvertisingaction.VisibleIndex = 0;
            this.colidadvertisingaction.Width = 29;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 64;
            this.coldtstart.Caption = "Начало";
            this.coldtstart.FieldName = "dtstart";
            this.coldtstart.Name = "coldtstart";
            this.coldtstart.Visible = true;
            this.coldtstart.VisibleIndex = 2;
            this.coldtstart.Width = 64;
            this.coldtfinish.Caption = "Окончание";
            this.coldtfinish.FieldName = "dtfinish";
            this.coldtfinish.Name = "coldtfinish";
            this.coldtfinish.Visible = true;
            this.coldtfinish.VisibleIndex = 3;
            this.coldtfinish.Width = 64;
            this.colperc.Caption = "%";
            this.colperc.ColumnEdit = (RepositoryItem)this.CalcEditSum;
            this.colperc.FieldName = "perc";
            this.colperc.Name = "colperc";
            this.colperc.Visible = true;
            this.colperc.VisibleIndex = 4;
            this.colperc.Width = 64;
            this.CalcEditSum.AutoHeight = false;
            this.CalcEditSum.DisplayFormat.FormatString = "N4";
            this.CalcEditSum.DisplayFormat.FormatType = FormatType.Numeric;
            this.CalcEditSum.EditFormat.FormatString = "N4";
            this.CalcEditSum.EditFormat.FormatType = FormatType.Numeric;
            this.CalcEditSum.Mask.EditMask = "N4";
            this.CalcEditSum.Name = "CalcEditSum";
            this.colsm.Caption = "Сумма";
            this.colsm.ColumnEdit = (RepositoryItem)this.CalcEditSum;
            this.colsm.FieldName = "sm";
            this.colsm.Name = "colsm";
            this.colsm.Visible = true;
            this.colsm.VisibleIndex = 5;
            this.colsm.Width = 64;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 7;
            this.colcomment.Width = 85;
            this.colvalut_shortname.Caption = "Валюта";
            this.colvalut_shortname.ColumnEdit = (RepositoryItem)this.cboValut;
            this.colvalut_shortname.FieldName = "valut_shortname";
            this.colvalut_shortname.Name = "colvalut_shortname";
            this.colvalut_shortname.Visible = true;
            this.colvalut_shortname.VisibleIndex = 6;
            this.colvalut_shortname.Width = 64;
            this.cboValut.AutoHeight = false;
            this.cboValut.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut.Name = "cboValut";
            this.cboValut.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.colisactive.Caption = "V";
            this.colisactive.FieldName = "isactive";
            this.colisactive.Name = "colisactive";
            this.colisactive.Visible = true;
            this.colisactive.VisibleIndex = 8;
            this.colisactive.Width = 57;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlAdvertisingAction);
            this.Controls.Add((Control)this.splitterControl1);
            this.Controls.Add((Control)this.AtTreeListControl);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.Name = "AdvertisingActionForm";
            this.Size = new Size(778, 352);
            this.Text = "AdvertisingActionForm";
            this.ds.EndInit();
            this.atButtonsPanel1.EndInit();
            this.AtTreeListControl.EndInit();
            this.gridControlAdvertisingAction.EndInit();
            this.MenuItem.ResumeLayout(false);
            this.gridViewAdvertisingAction.EndInit();
            this.CalcEditSum.EndInit();
            this.cboValut.EndInit();
            this.ResumeLayout(false);
        }

        private void AdvertisingActionForm_Shown(object sender, EventArgs e)
        {
            this.DisableEvent = false;
            if (!this.Is_Dialog)
                return;
            this.gridViewAdvertisingAction.OptionsBehavior.Editable = false;
            this.gridControlAdvertisingAction.ContextMenuStrip = (ContextMenuStrip)null;
            this.AtTreeListControl.ContextMenuStrip = (ContextMenuStrip)null;
        }

        private void AdvertisingActionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AtDataSet.IsModifDataSet((DataSet)this.ds))
                return;
            DialogResult dialogResult = MessageBox.Show("Данные были изменены! Сохранить данные?", "Справочник рекламных акций", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                this.ds.Save();
            else
                e.Cancel = dialogResult == DialogResult.Cancel;
        }

        private void cboValut_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (this.DisableEvent)
                return;
            this.DisableEvent = true;
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControlAdvertisingAction);
            if (dataRow == null)
                return;
            dataRow["idvalut"] = (object)((ds_advertising.valutRow)e.NewValue).idvalut;
            this.DisableEvent = false;
        }

        private void gridViewAdvertisingAction_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Is_Dialog)
                return;
            this.SelectItem();
        }

        public override void LoadFromBase()
        {
            this.ds.Load(this.IsActiveOnly);
            this.cboValut.Items.Clear();
            foreach (ds_advertising.valutRow valutRow in this.ds.valut)
                this.cboValut.Items.Add((object)valutRow);
        }

        public override bool SaveToBase()
        {
            return this.ds.Save();
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            this.ds.advertisingaction.CreateRow(this.AtTreeListControl.GetSelectedNode());
        }

        private void MenuItemDoublicate_Click(object sender, EventArgs e)
        {
            this.ds.advertisingaction.Doublicate(AtGrid.getSelectedDataRows((Control)this.gridControlAdvertisingAction));
        }

        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            this.ds.advertisingaction.Remove(AtGrid.getSelectedDataRows((Control)this.gridControlAdvertisingAction));
        }

        private void MenuItemMoveToGroup_Click(object sender, EventArgs e)
        {
            this.AtTreeListControl.MoveItems = AtGrid.getSelectedDataRows((Control)this.gridControlAdvertisingAction);
        }

        public override bool SelectItem()
        {
            this.Result = AtGrid.getDataRow((Control)this.gridControlAdvertisingAction);
            if (this.Result == null)
                return false;
            return base.SelectItem();
        }
    }
}
