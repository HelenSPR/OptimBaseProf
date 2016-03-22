// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ProfileSystemChangeForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.ecad.Calc.winDraw;
using Atechnology.winDraw.Model.Settings;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class ProfileSystemChangeForm : AtUserControl
    {
        private IContainer components;
        public ComboBoxEdit comboBoxEdit1;
        private Button button1;
        private Button button2;

        public ProfileSystemChangeForm()
        {
            this.InitializeComponent();
            foreach (object obj in SettingsLoad.currentSettings.ProfileSystemList)
                this.comboBoxEdit1.Properties.Items.Add(obj);
            this.comboBoxEdit1.Properties.Items.Add((object)new ProfileSystem()
            {
                idsystem = -1,
                Name = "<пусто>"
            });
        }

        public ProfileSystemChangeForm(bool IsShowFurniture)
        {
            this.InitializeComponent();
            Settings settings = SettingsLoad.currentSettings;
            foreach (object obj in settings.ProfileSystemList)
                this.comboBoxEdit1.Properties.Items.Add(obj);
            if (IsShowFurniture)
            {
                foreach (object obj in settings.FurnitureSystemList)
                    this.comboBoxEdit1.Properties.Items.Add(obj);
            }
            this.comboBoxEdit1.Properties.Items.Add((object)new ProfileSystem()
            {
                idsystem = -1,
                Name = "<пусто>"
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxEdit1 = new ComboBoxEdit();
            this.button1 = new Button();
            this.button2 = new Button();
            this.comboBoxEdit1.Properties.BeginInit();
            this.SuspendLayout();
            this.comboBoxEdit1.Location = new Point(25, 17);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.BorderStyle = BorderStyles.Simple;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.comboBoxEdit1.Size = new Size(277, 20);
            this.comboBoxEdit1.TabIndex = 2;
            this.button1.DialogResult = DialogResult.OK;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(145, 43);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button2.DialogResult = DialogResult.Cancel;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(227, 43);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.comboBoxEdit1);
            this.Name = "ProfileSystemChangeForm";
            this.Size = new Size(323, 77);
            this.Text = "Установка системы";
            this.comboBoxEdit1.Properties.EndInit();
            this.ResumeLayout(false);
        }
    }
}
