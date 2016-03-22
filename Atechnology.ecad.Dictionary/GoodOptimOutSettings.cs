// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodOptimOutSettings
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class GoodOptimOutSettings : AtUserControl
    {
        private IContainer components;
        private Panel pBottom;
        private Button button2;
        private Button bOk;
        private Panel pTop;
        private CalcEdit calcEditWaste5;
        private CalcEdit calcEditWaste4;
        private CalcEdit calcEditWaste3;
        private CalcEdit calcEditWaste2;
        private CalcEdit calcEditWaste1;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label16;

        public Decimal? Waste1
        {
            get
            {
                if (this.calcEditWaste1.EditValue != null)
                    return new Decimal?(this.calcEditWaste1.Value);
                return new Decimal?();
            }
        }

        public Decimal? Waste2
        {
            get
            {
                if (this.calcEditWaste2.EditValue != null)
                    return new Decimal?(this.calcEditWaste2.Value);
                return new Decimal?();
            }
        }

        public Decimal? Waste3
        {
            get
            {
                if (this.calcEditWaste3.EditValue != null)
                    return new Decimal?(this.calcEditWaste3.Value);
                return new Decimal?();
            }
        }

        public Decimal? Waste4
        {
            get
            {
                if (this.calcEditWaste4.EditValue != null)
                    return new Decimal?(this.calcEditWaste4.Value);
                return new Decimal?();
            }
        }

        public Decimal? Waste5
        {
            get
            {
                if (this.calcEditWaste5.EditValue != null)
                    return new Decimal?(this.calcEditWaste5.Value);
                return new Decimal?();
            }
        }

        public GoodOptimOutSettings()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pBottom = new Panel();
            this.pTop = new Panel();
            this.bOk = new Button();
            this.button2 = new Button();
            this.calcEditWaste5 = new CalcEdit();
            this.calcEditWaste4 = new CalcEdit();
            this.calcEditWaste3 = new CalcEdit();
            this.calcEditWaste2 = new CalcEdit();
            this.calcEditWaste1 = new CalcEdit();
            this.label37 = new Label();
            this.label36 = new Label();
            this.label35 = new Label();
            this.label34 = new Label();
            this.label16 = new Label();
            this.pBottom.SuspendLayout();
            this.pTop.SuspendLayout();
            this.calcEditWaste5.Properties.BeginInit();
            this.calcEditWaste4.Properties.BeginInit();
            this.calcEditWaste3.Properties.BeginInit();
            this.calcEditWaste2.Properties.BeginInit();
            this.calcEditWaste1.Properties.BeginInit();
            this.SuspendLayout();
            this.pBottom.Controls.Add((Control)this.button2);
            this.pBottom.Controls.Add((Control)this.bOk);
            this.pBottom.Dock = DockStyle.Bottom;
            this.pBottom.Location = new Point(0, 141);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new Size(176, 39);
            this.pBottom.TabIndex = 0;
            this.pTop.Controls.Add((Control)this.calcEditWaste5);
            this.pTop.Controls.Add((Control)this.calcEditWaste4);
            this.pTop.Controls.Add((Control)this.calcEditWaste3);
            this.pTop.Controls.Add((Control)this.calcEditWaste2);
            this.pTop.Controls.Add((Control)this.calcEditWaste1);
            this.pTop.Controls.Add((Control)this.label37);
            this.pTop.Controls.Add((Control)this.label36);
            this.pTop.Controls.Add((Control)this.label35);
            this.pTop.Controls.Add((Control)this.label34);
            this.pTop.Controls.Add((Control)this.label16);
            this.pTop.Dock = DockStyle.Fill;
            this.pTop.Location = new Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new Size(176, 141);
            this.pTop.TabIndex = 1;
            this.bOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.bOk.DialogResult = DialogResult.OK;
            this.bOk.FlatStyle = FlatStyle.Flat;
            this.bOk.Location = new Point(93, 7);
            this.bOk.Name = "bOk";
            this.bOk.Size = new Size(75, 23);
            this.bOk.TabIndex = 0;
            this.bOk.Text = "Выбрать";
            this.bOk.UseVisualStyleBackColor = true;
            this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button2.DialogResult = DialogResult.Cancel;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(12, 7);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.calcEditWaste5.Location = new Point(79, 111);
            this.calcEditWaste5.Name = "calcEditWaste5";
            this.calcEditWaste5.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste5.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste5.Size = new Size(82, 20);
            this.calcEditWaste5.TabIndex = 27;
            this.calcEditWaste4.Location = new Point(79, 85);
            this.calcEditWaste4.Name = "calcEditWaste4";
            this.calcEditWaste4.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste4.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste4.Size = new Size(82, 20);
            this.calcEditWaste4.TabIndex = 28;
            this.calcEditWaste3.Location = new Point(79, 61);
            this.calcEditWaste3.Name = "calcEditWaste3";
            this.calcEditWaste3.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste3.Size = new Size(82, 20);
            this.calcEditWaste3.TabIndex = 26;
            this.calcEditWaste2.Location = new Point(79, 34);
            this.calcEditWaste2.Name = "calcEditWaste2";
            this.calcEditWaste2.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste2.Size = new Size(82, 20);
            this.calcEditWaste2.TabIndex = 24;
            this.calcEditWaste1.Location = new Point(79, 8);
            this.calcEditWaste1.Name = "calcEditWaste1";
            this.calcEditWaste1.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste1.Size = new Size(82, 20);
            this.calcEditWaste1.TabIndex = 25;
            this.label37.AutoSize = true;
            this.label37.Location = new Point(12, 114);
            this.label37.Name = "label37";
            this.label37.Size = new Size(61, 13);
            this.label37.TabIndex = 32;
            this.label37.Text = "% отхода 5";
            this.label36.AutoSize = true;
            this.label36.Location = new Point(12, 88);
            this.label36.Name = "label36";
            this.label36.Size = new Size(61, 13);
            this.label36.TabIndex = 33;
            this.label36.Text = "% отхода 4";
            this.label35.AutoSize = true;
            this.label35.Location = new Point(12, 64);
            this.label35.Name = "label35";
            this.label35.Size = new Size(61, 13);
            this.label35.TabIndex = 31;
            this.label35.Text = "% отхода 3";
            this.label34.AutoSize = true;
            this.label34.Location = new Point(12, 37);
            this.label34.Name = "label34";
            this.label34.Size = new Size(61, 13);
            this.label34.TabIndex = 29;
            this.label34.Text = "% отхода 2";
            this.label16.AutoSize = true;
            this.label16.Location = new Point(12, 11);
            this.label16.Name = "label16";
            this.label16.Size = new Size(61, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "% отхода 1";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.pTop);
            this.Controls.Add((Control)this.pBottom);
            this.MaximumSize = new Size(176, 180);
            this.MinimumSize = new Size(176, 180);
            this.Name = "GoodOptimOutSettings";
            this.Size = new Size(176, 180);
            this.Text = "Настройки процентов отхода";
            this.pBottom.ResumeLayout(false);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.calcEditWaste5.Properties.EndInit();
            this.calcEditWaste4.Properties.EndInit();
            this.calcEditWaste3.Properties.EndInit();
            this.calcEditWaste2.Properties.EndInit();
            this.calcEditWaste1.Properties.EndInit();
            this.ResumeLayout(false);
        }
    }
}
