// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.PollAnswerSelectForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
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
    public class PollAnswerSelectForm : AtUserControl
    {
        private DataTable tabPollAnswer;
        private IContainer components;
        private Panel panel1;
        private SimpleButton simpleButtonExit2;
        private SimpleButton simpleButtonSelect;
        private GridControl gridControlPollAnswer;
        private GridView gridViewPollAnswer;
        private GridColumn gridColumn1;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;

        public DataRow[] SelectedRows
        {
            get
            {
                return AtGrid.getSelectedDataRows((Control)this.gridControlPollAnswer);
            }
        }

        public PollAnswerSelectForm(DataTable tabPollAnswer)
        {
            this.InitializeComponent();
            this.tabPollAnswer = tabPollAnswer;
            this.gridControlPollAnswer.DataSource = (object)tabPollAnswer;
        }

        private void simpleButtonSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonExit2_Click(object sender, EventArgs e)
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
            this.panel1 = new Panel();
            this.simpleButtonExit2 = new SimpleButton();
            this.simpleButtonSelect = new SimpleButton();
            this.gridControlPollAnswer = new GridControl();
            this.gridViewPollAnswer = new GridView();
            this.gridColumn1 = new GridColumn();
            this.gridColumn3 = new GridColumn();
            this.gridColumn4 = new GridColumn();
            this.panel1.SuspendLayout();
            this.gridControlPollAnswer.BeginInit();
            this.gridViewPollAnswer.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.simpleButtonExit2);
            this.panel1.Controls.Add((Control)this.simpleButtonSelect);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(798, 33);
            this.panel1.TabIndex = 2;
            this.simpleButtonExit2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonExit2.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonExit2.DialogResult = DialogResult.Cancel;
            this.simpleButtonExit2.Location = new Point(720, 6);
            this.simpleButtonExit2.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonExit2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonExit2.Name = "simpleButtonExit2";
            this.simpleButtonExit2.Size = new Size(75, 23);
            this.simpleButtonExit2.TabIndex = 3;
            this.simpleButtonExit2.Text = "Отменить";
            this.simpleButtonExit2.Click += new EventHandler(this.simpleButtonExit2_Click);
            this.simpleButtonSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonSelect.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonSelect.DialogResult = DialogResult.OK;
            this.simpleButtonSelect.Location = new Point(639, 6);
            this.simpleButtonSelect.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonSelect.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonSelect.Name = "simpleButtonSelect";
            this.simpleButtonSelect.Size = new Size(75, 23);
            this.simpleButtonSelect.TabIndex = 1;
            this.simpleButtonSelect.Text = "Выбрать";
            this.simpleButtonSelect.Click += new EventHandler(this.simpleButtonSelect_Click);
            this.gridControlPollAnswer.Dock = DockStyle.Fill;
            this.gridControlPollAnswer.EmbeddedNavigator.Name = "";
            this.gridControlPollAnswer.Location = new Point(0, 0);
            this.gridControlPollAnswer.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlPollAnswer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlPollAnswer.MainView = (BaseView)this.gridViewPollAnswer;
            this.gridControlPollAnswer.Name = "gridControlPollAnswer";
            this.gridControlPollAnswer.Size = new Size(798, 428);
            this.gridControlPollAnswer.TabIndex = 3;
            this.gridControlPollAnswer.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewPollAnswer
      });
            this.gridViewPollAnswer.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPollAnswer.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPollAnswer.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewPollAnswer.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewPollAnswer.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewPollAnswer.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPollAnswer.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPollAnswer.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewPollAnswer.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewPollAnswer.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewPollAnswer.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPollAnswer.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPollAnswer.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewPollAnswer.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewPollAnswer.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPollAnswer.BorderStyle = BorderStyles.Simple;
            this.gridViewPollAnswer.Columns.AddRange(new GridColumn[3]
      {
        this.gridColumn1,
        this.gridColumn3,
        this.gridColumn4
      });
            this.gridViewPollAnswer.GridControl = this.gridControlPollAnswer;
            this.gridViewPollAnswer.Name = "gridViewPollAnswer";
            this.gridViewPollAnswer.OptionsView.ShowDetailButtons = false;
            this.gridViewPollAnswer.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewPollAnswer.OptionsView.ShowGroupPanel = false;
            this.gridViewPollAnswer.OptionsView.ShowIndicator = false;
            this.gridColumn1.Caption = "#";
            this.gridColumn1.FieldName = "idpollanswer";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn3.Caption = "Ответ";
            this.gridColumn3.FieldName = "answer";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn4.Caption = "Вес ответа";
            this.gridColumn4.FieldName = "weightanswer";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlPollAnswer);
            this.Controls.Add((Control)this.panel1);
            this.Name = "PollAnswerSelectForm";
            this.Size = new Size(798, 461);
            this.Text = "Выбор существующего ответа";
            this.panel1.ResumeLayout(false);
            this.gridControlPollAnswer.EndInit();
            this.gridViewPollAnswer.EndInit();
            this.ResumeLayout(false);
        }
    }
}
