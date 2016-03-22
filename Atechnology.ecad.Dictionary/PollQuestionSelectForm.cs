// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.PollQuestionSelectForm
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
    public class PollQuestionSelectForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private SimpleButton simpleButtonExit2;
        private SimpleButton simpleButtonSelect;
        private GridControl gridControlPollQuestion;
        private GridView gridViewPollQuestion;
        private GridColumn gridColumn1;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private GridColumn gridColumn6;
        private DataTable tabPollQuestion;

        public DataRow[] SelectedRow
        {
            get
            {
                return AtGrid.getSelectedDataRows((Control)this.gridControlPollQuestion);
            }
        }

        public PollQuestionSelectForm(DataTable tabPollQuestion)
        {
            this.InitializeComponent();
            this.tabPollQuestion = tabPollQuestion;
            this.gridControlPollQuestion.DataSource = (object)tabPollQuestion;
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
            this.gridControlPollQuestion = new GridControl();
            this.gridViewPollQuestion = new GridView();
            this.gridColumn1 = new GridColumn();
            this.gridColumn3 = new GridColumn();
            this.gridColumn4 = new GridColumn();
            this.gridColumn5 = new GridColumn();
            this.gridColumn6 = new GridColumn();
            this.panel1.SuspendLayout();
            this.gridControlPollQuestion.BeginInit();
            this.gridViewPollQuestion.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.simpleButtonExit2);
            this.panel1.Controls.Add((Control)this.simpleButtonSelect);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(704, 33);
            this.panel1.TabIndex = 1;
            this.simpleButtonExit2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonExit2.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonExit2.DialogResult = DialogResult.Cancel;
            this.simpleButtonExit2.Location = new Point(626, 6);
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
            this.simpleButtonSelect.Location = new Point(545, 6);
            this.simpleButtonSelect.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonSelect.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonSelect.Name = "simpleButtonSelect";
            this.simpleButtonSelect.Size = new Size(75, 23);
            this.simpleButtonSelect.TabIndex = 1;
            this.simpleButtonSelect.Text = "Выбрать";
            this.simpleButtonSelect.Click += new EventHandler(this.simpleButtonSelect_Click);
            this.gridControlPollQuestion.Dock = DockStyle.Fill;
            this.gridControlPollQuestion.EmbeddedNavigator.Name = "";
            this.gridControlPollQuestion.Location = new Point(0, 0);
            this.gridControlPollQuestion.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControlPollQuestion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlPollQuestion.MainView = (BaseView)this.gridViewPollQuestion;
            this.gridControlPollQuestion.Name = "gridControlPollQuestion";
            this.gridControlPollQuestion.Size = new Size(704, 428);
            this.gridControlPollQuestion.TabIndex = 2;
            this.gridControlPollQuestion.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridViewPollQuestion
      });
            this.gridViewPollQuestion.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPollQuestion.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPollQuestion.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridViewPollQuestion.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewPollQuestion.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewPollQuestion.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPollQuestion.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridViewPollQuestion.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridViewPollQuestion.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewPollQuestion.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewPollQuestion.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPollQuestion.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridViewPollQuestion.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridViewPollQuestion.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewPollQuestion.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPollQuestion.BorderStyle = BorderStyles.Simple;
            this.gridViewPollQuestion.Columns.AddRange(new GridColumn[5]
      {
        this.gridColumn1,
        this.gridColumn3,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6
      });
            this.gridViewPollQuestion.GridControl = this.gridControlPollQuestion;
            this.gridViewPollQuestion.Name = "gridViewPollQuestion";
            this.gridViewPollQuestion.OptionsView.ShowDetailButtons = false;
            this.gridViewPollQuestion.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridViewPollQuestion.OptionsView.ShowGroupPanel = false;
            this.gridViewPollQuestion.OptionsView.ShowIndicator = false;
            this.gridColumn1.Caption = "#";
            this.gridColumn1.FieldName = "idpollquestion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 48;
            this.gridColumn3.Caption = "Вопрос";
            this.gridColumn3.FieldName = "question";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 129;
            this.gridColumn4.Caption = "Пояснение";
            this.gridColumn4.FieldName = "explanation";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 129;
            this.gridColumn5.Caption = "Тип вопроса";
            this.gridColumn5.FieldName = "typeanswer";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 129;
            this.gridColumn6.Caption = "Обязательность";
            this.gridColumn6.FieldName = "obligatory";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 136;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.gridControlPollQuestion);
            this.Controls.Add((Control)this.panel1);
            this.Name = "PollQuestionSelectForm";
            this.Size = new Size(704, 461);
            this.Text = "Выбор существующего вопроса";
            this.panel1.ResumeLayout(false);
            this.gridControlPollQuestion.EndInit();
            this.gridViewPollQuestion.EndInit();
            this.ResumeLayout(false);
        }

        private void simpleButtonSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
