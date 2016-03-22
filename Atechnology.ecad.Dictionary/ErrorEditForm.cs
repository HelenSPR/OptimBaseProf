// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ErrorEditForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.ecad.Dictionary.DataSets;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class ErrorEditForm : AtUserControl
    {
        private IContainer components;
        private atButtonsPanel atButtonsPanel1;
        private BindingSource bsError;
        private TextEdit txtName;
        private LayoutControl layoutControl1;
        private MemoEdit memComment;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlItem layoutControlItem2;
        private TextEdit txtCode;
        private LayoutControlItem layoutControlItem3;
        private ButtonEdit buttonEditErrorType;
        private LayoutControlItem layoutControlItem4;
        private ComboBoxEdit cboShowType;
        private LayoutControlItem layoutControlItem5;
        private CheckEdit chkSave;
        private LayoutControlItem layoutControlItem6;
        private MemoEdit memMessage3;
        private MemoEdit memMessage2;
        private MemoEdit memMessage1;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlItem layoutControlItem9;
        private PictureEdit pictureEdit1;
        private LayoutControlItem layoutControlItem10;

        public ErrorEditForm(DataRow drError)
        {
            this.InitializeComponent();
            this.bsError.DataSource = (object)(ds_error.errorRow)drError;
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
            this.bsError = new BindingSource(this.components);
            this.txtName = new TextEdit();
            this.layoutControl1 = new LayoutControl();
            this.pictureEdit1 = new PictureEdit();
            this.memMessage3 = new MemoEdit();
            this.memMessage2 = new MemoEdit();
            this.memMessage1 = new MemoEdit();
            this.chkSave = new CheckEdit();
            this.cboShowType = new ComboBoxEdit();
            this.buttonEditErrorType = new ButtonEdit();
            this.txtCode = new TextEdit();
            this.memComment = new MemoEdit();
            this.layoutControlGroup1 = new LayoutControlGroup();
            this.layoutControlItem1 = new LayoutControlItem();
            this.layoutControlItem2 = new LayoutControlItem();
            this.layoutControlItem3 = new LayoutControlItem();
            this.layoutControlItem4 = new LayoutControlItem();
            this.layoutControlItem5 = new LayoutControlItem();
            this.layoutControlItem6 = new LayoutControlItem();
            this.layoutControlItem7 = new LayoutControlItem();
            this.layoutControlItem8 = new LayoutControlItem();
            this.layoutControlItem9 = new LayoutControlItem();
            this.layoutControlItem10 = new LayoutControlItem();
            this.atButtonsPanel1.BeginInit();
            ((ISupportInitialize)this.bsError).BeginInit();
            this.txtName.Properties.BeginInit();
            this.layoutControl1.BeginInit();
            this.layoutControl1.SuspendLayout();
            this.pictureEdit1.Properties.BeginInit();
            this.memMessage3.Properties.BeginInit();
            this.memMessage2.Properties.BeginInit();
            this.memMessage1.Properties.BeginInit();
            this.chkSave.Properties.BeginInit();
            this.cboShowType.Properties.BeginInit();
            this.buttonEditErrorType.Properties.BeginInit();
            this.txtCode.Properties.BeginInit();
            this.memComment.Properties.BeginInit();
            this.layoutControlGroup1.BeginInit();
            this.layoutControlItem1.BeginInit();
            this.layoutControlItem2.BeginInit();
            this.layoutControlItem3.BeginInit();
            this.layoutControlItem4.BeginInit();
            this.layoutControlItem5.BeginInit();
            this.layoutControlItem6.BeginInit();
            this.layoutControlItem7.BeginInit();
            this.layoutControlItem8.BeginInit();
            this.layoutControlItem9.BeginInit();
            this.layoutControlItem10.BeginInit();
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
            this.atButtonsPanel1.Location = new Point(0, 324);
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
            this.atButtonsPanel1.Size = new Size(800, 33);
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
            this.bsError.DataSource = (object)typeof(ds_error.errorRow);
            this.txtName.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "name", true));
            this.txtName.Location = new Point(225, 7);
            this.txtName.Name = "txtName";
            this.txtName.Properties.BorderStyle = BorderStyles.Simple;
            this.txtName.Size = new Size(271, 20);
            this.txtName.StyleController = (IStyleController)this.layoutControl1;
            this.txtName.TabIndex = 1;
            this.layoutControl1.Controls.Add((Control)this.pictureEdit1);
            this.layoutControl1.Controls.Add((Control)this.memMessage3);
            this.layoutControl1.Controls.Add((Control)this.memMessage2);
            this.layoutControl1.Controls.Add((Control)this.memMessage1);
            this.layoutControl1.Controls.Add((Control)this.chkSave);
            this.layoutControl1.Controls.Add((Control)this.cboShowType);
            this.layoutControl1.Controls.Add((Control)this.buttonEditErrorType);
            this.layoutControl1.Controls.Add((Control)this.txtCode);
            this.layoutControl1.Controls.Add((Control)this.txtName);
            this.layoutControl1.Controls.Add((Control)this.memComment);
            this.layoutControl1.Dock = DockStyle.Fill;
            this.layoutControl1.Location = new Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new Size(800, 324);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            this.pictureEdit1.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "unpack_picture", true));
            this.pictureEdit1.Location = new Point(507, 32);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = BorderStyles.Simple;
            this.pictureEdit1.Properties.PictureStoreMode = PictureStoreMode.ByteArray;
            this.pictureEdit1.Properties.SizeMode = PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new Size(287, 286);
            this.pictureEdit1.StyleController = (IStyleController)this.layoutControl1;
            this.pictureEdit1.TabIndex = 11;
            this.memMessage3.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "message3", true));
            this.memMessage3.Location = new Point(85, 259);
            this.memMessage3.Name = "memMessage3";
            this.memMessage3.Properties.BorderStyle = BorderStyles.Simple;
            this.memMessage3.Size = new Size(411, 59);
            this.memMessage3.StyleController = (IStyleController)this.layoutControl1;
            this.memMessage3.TabIndex = 10;
            this.memMessage2.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "message2", true));
            this.memMessage2.Location = new Point(85, 189);
            this.memMessage2.Name = "memMessage2";
            this.memMessage2.Properties.BorderStyle = BorderStyles.Simple;
            this.memMessage2.Size = new Size(411, 59);
            this.memMessage2.StyleController = (IStyleController)this.layoutControl1;
            this.memMessage2.TabIndex = 9;
            this.memMessage1.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "message1", true));
            this.memMessage1.Location = new Point(85, 119);
            this.memMessage1.Name = "memMessage1";
            this.memMessage1.Properties.BorderStyle = BorderStyles.Simple;
            this.memMessage1.Size = new Size(411, 59);
            this.memMessage1.StyleController = (IStyleController)this.layoutControl1;
            this.memMessage1.TabIndex = 8;
            this.chkSave.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "issave", true));
            this.chkSave.Location = new Point(394, 38);
            this.chkSave.Name = "chkSave";
            this.chkSave.Properties.Caption = "Сохранять";
            this.chkSave.Properties.GlyphAlignment = HorzAlignment.Far;
            this.chkSave.Size = new Size(102, 19);
            this.chkSave.StyleController = (IStyleController)this.layoutControl1;
            this.chkSave.TabIndex = 7;
            this.cboShowType.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "showtype_name", true));
            this.cboShowType.Location = new Point(304, 38);
            this.cboShowType.Name = "cboShowType";
            this.cboShowType.Properties.BorderStyle = BorderStyles.Simple;
            this.cboShowType.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboShowType.Properties.Items.AddRange(new object[4]
      {
        (object) "Не отображать",
        (object) "Сообщение 1",
        (object) "Сообщение 2",
        (object) "Сообщение 3"
      });
            this.cboShowType.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboShowType.Size = new Size(79, 20);
            this.cboShowType.StyleController = (IStyleController)this.layoutControl1;
            this.cboShowType.TabIndex = 6;
            this.cboShowType.SelectedIndexChanged += new EventHandler(this.cboShowType_SelectedIndexChanged);
            this.buttonEditErrorType.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "errortype_name", true));
            this.buttonEditErrorType.Location = new Point(32, 38);
            this.buttonEditErrorType.Name = "buttonEditErrorType";
            this.buttonEditErrorType.Properties.BorderStyle = BorderStyles.Simple;
            this.buttonEditErrorType.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton()
      });
            this.buttonEditErrorType.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.buttonEditErrorType.Size = new Size(186, 20);
            this.buttonEditErrorType.StyleController = (IStyleController)this.layoutControl1;
            this.buttonEditErrorType.TabIndex = 5;
            this.buttonEditErrorType.ButtonClick += new ButtonPressedEventHandler(this.buttonEditErrorType_ButtonClick);
            this.txtCode.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "code", true));
            this.txtCode.Location = new Point(32, 7);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.BorderStyle = BorderStyles.Simple;
            this.txtCode.Size = new Size(104, 20);
            this.txtCode.StyleController = (IStyleController)this.layoutControl1;
            this.txtCode.TabIndex = 4;
            this.memComment.DataBindings.Add(new Binding("EditValue", (object)this.bsError, "comment", true));
            this.memComment.Location = new Point(85, 69);
            this.memComment.Name = "memComment";
            this.memComment.Properties.BorderStyle = BorderStyles.Simple;
            this.memComment.Size = new Size(411, 39);
            this.memComment.StyleController = (IStyleController)this.layoutControl1;
            this.memComment.TabIndex = 3;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[10]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10
      });
            this.layoutControlGroup1.Location = new Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new Size(800, 324);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            this.layoutControlItem1.Control = (Control)this.txtName;
            this.layoutControlItem1.CustomizationFormText = "Наименование";
            this.layoutControlItem1.Location = new Point(140, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new Size(360, 31);
            this.layoutControlItem1.Text = "Наименование";
            this.layoutControlItem1.TextAlignMode = TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextLocation = Locations.Left;
            this.layoutControlItem1.TextSize = new Size(73, 20);
            this.layoutControlItem2.Control = (Control)this.memComment;
            this.layoutControlItem2.CustomizationFormText = "Комментарий";
            this.layoutControlItem2.Location = new Point(0, 62);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new Size(500, 50);
            this.layoutControlItem2.Text = "Комментарий";
            this.layoutControlItem2.TextAlignMode = TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextLocation = Locations.Left;
            this.layoutControlItem2.TextSize = new Size(73, 20);
            this.layoutControlItem3.Control = (Control)this.txtCode;
            this.layoutControlItem3.CustomizationFormText = "Код";
            this.layoutControlItem3.Location = new Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new Size(140, 31);
            this.layoutControlItem3.Text = "Код";
            this.layoutControlItem3.TextAlignMode = TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextLocation = Locations.Left;
            this.layoutControlItem3.TextSize = new Size(20, 20);
            this.layoutControlItem4.Control = (Control)this.buttonEditErrorType;
            this.layoutControlItem4.CustomizationFormText = "Тип";
            this.layoutControlItem4.Location = new Point(0, 31);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new Size(222, 31);
            this.layoutControlItem4.Text = "Тип";
            this.layoutControlItem4.TextAlignMode = TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextLocation = Locations.Left;
            this.layoutControlItem4.TextSize = new Size(20, 20);
            this.layoutControlItem5.Control = (Control)this.cboShowType;
            this.layoutControlItem5.CustomizationFormText = "Отображение";
            this.layoutControlItem5.Location = new Point(222, 31);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new Size(165, 31);
            this.layoutControlItem5.Text = "Отображение";
            this.layoutControlItem5.TextAlignMode = TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextLocation = Locations.Left;
            this.layoutControlItem5.TextSize = new Size(70, 20);
            this.layoutControlItem6.Control = (Control)this.chkSave;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new Point(387, 31);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new Size(113, 31);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextLocation = Locations.Left;
            this.layoutControlItem6.TextSize = new Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            this.layoutControlItem7.Control = (Control)this.memMessage1;
            this.layoutControlItem7.CustomizationFormText = "Сообщение 1";
            this.layoutControlItem7.Location = new Point(0, 112);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new Size(500, 70);
            this.layoutControlItem7.Text = "Сообщение 1";
            this.layoutControlItem7.TextAlignMode = TextAlignModeItem.CustomSize;
            this.layoutControlItem7.TextLocation = Locations.Left;
            this.layoutControlItem7.TextSize = new Size(73, 20);
            this.layoutControlItem8.Control = (Control)this.memMessage2;
            this.layoutControlItem8.CustomizationFormText = "Сообщение 2";
            this.layoutControlItem8.Location = new Point(0, 182);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new Size(500, 70);
            this.layoutControlItem8.Text = "Сообщение 2";
            this.layoutControlItem8.TextAlignMode = TextAlignModeItem.CustomSize;
            this.layoutControlItem8.TextLocation = Locations.Left;
            this.layoutControlItem8.TextSize = new Size(73, 20);
            this.layoutControlItem9.Control = (Control)this.memMessage3;
            this.layoutControlItem9.CustomizationFormText = "Сообщение 2";
            this.layoutControlItem9.Location = new Point(0, 252);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new Size(500, 70);
            this.layoutControlItem9.Text = "Сообщение 2";
            this.layoutControlItem9.TextAlignMode = TextAlignModeItem.CustomSize;
            this.layoutControlItem9.TextLocation = Locations.Left;
            this.layoutControlItem9.TextSize = new Size(73, 20);
            this.layoutControlItem10.Control = (Control)this.pictureEdit1;
            this.layoutControlItem10.CustomizationFormText = "Иллюстрация";
            this.layoutControlItem10.Location = new Point(500, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new Size(298, 322);
            this.layoutControlItem10.Text = "Иллюстрация";
            this.layoutControlItem10.TextLocation = Locations.Top;
            this.layoutControlItem10.TextSize = new Size(69, 20);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.layoutControl1);
            this.Controls.Add((Control)this.atButtonsPanel1);
            this.MinimumSize = new Size(800, 357);
            this.Name = "ErrorEditForm";
            this.Size = new Size(800, 357);
            this.Text = "ErrorEditForm";
            this.FormClosing += new FormClosing(this.ErrorEditForm_FormClosing);
            this.atButtonsPanel1.EndInit();
            ((ISupportInitialize)this.bsError).EndInit();
            this.txtName.Properties.EndInit();
            this.layoutControl1.EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.pictureEdit1.Properties.EndInit();
            this.memMessage3.Properties.EndInit();
            this.memMessage2.Properties.EndInit();
            this.memMessage1.Properties.EndInit();
            this.chkSave.Properties.EndInit();
            this.cboShowType.Properties.EndInit();
            this.buttonEditErrorType.Properties.EndInit();
            this.txtCode.Properties.EndInit();
            this.memComment.Properties.EndInit();
            this.layoutControlGroup1.EndInit();
            this.layoutControlItem1.EndInit();
            this.layoutControlItem2.EndInit();
            this.layoutControlItem3.EndInit();
            this.layoutControlItem4.EndInit();
            this.layoutControlItem5.EndInit();
            this.layoutControlItem6.EndInit();
            this.layoutControlItem7.EndInit();
            this.layoutControlItem8.EndInit();
            this.layoutControlItem9.EndInit();
            this.layoutControlItem10.EndInit();
            this.ResumeLayout(false);
        }

        public override void LoadFromBase()
        {
            ((DataRow)this.bsError.DataSource).RejectChanges();
        }

        public override bool SaveToBase()
        {
            return ((ds_error.errorRow)this.bsError.DataSource).Save();
        }

        private void buttonEditErrorType_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ds_error.errorRow errorRow = (ds_error.errorRow)this.bsError.DataSource;
            if (e.Button.Index == 0)
            {
                errorRow.SetiderrortypeNull();
                errorRow.Seterrortype_nameNull();
            }
            else
            {
                ErrorTypeForm errorTypeForm = new ErrorTypeForm();
                if (errorTypeForm.ShowDialog() != DialogResult.OK)
                    return;
                DataRow dataRow = AtGrid.getDataRow((Control)errorTypeForm.gridControlErrorType);
                if (dataRow == null)
                    return;
                errorRow["iderrortype"] = dataRow["iderrortype"];
                errorRow["errortype_name"] = dataRow["name"];
            }
            this.buttonEditErrorType.Text = errorRow["errortype_name"].ToString();
        }

        private void cboShowType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboShowType.SelectedIndex == -1)
                return;
            ((ds_error.errorRow)this.bsError.DataSource).showtype = this.cboShowType.SelectedIndex;
        }

        private void ErrorEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((DataRow)this.bsError.DataSource).RowState == DataRowState.Unchanged)
                return;
            switch (MessageBox.Show("Данные были изменены! Сохранить изменения?", "Редактирования ошибки", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
