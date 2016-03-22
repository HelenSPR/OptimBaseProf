// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodBufferEdit
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.ecad.Dictionary.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class GoodBufferEdit : AtUserControl
    {
        private Dictionary<string, object> enumValuesHash = new Dictionary<string, object>();
        private IContainer components;
        private Label lMarking;
        private TextEdit teMarking;
        private Label lLenght;
        private Label lHeight;
        private Label lWidth;
        private CalcEdit ceLenght;
        private CalcEdit ceHeight;
        private CalcEdit ceWidth;
        private ComboBoxEdit cbeStatus;
        private Label lStatus;
        private MemoEdit meComment;
        private Label lComment;
        private Button bOK;
        private AtBevel blTop;
        private CalcEdit ceWeight;
        private Label lWeight;
        private AtBevel atBevel1;
        private AtBevel atBevel2;
        private AtBevel atBevel3;
        private TextEdit teRow;
        private Label label1;
        private TextEdit teCell;
        private Label label2;
        private AtBevel atBevel4;
        private GoodBufferUtils.GoodBufferType defaultType;
        private DataRow editRow;

        public GoodBufferUtils.GoodBufferType DefaultType
        {
            get
            {
                return this.defaultType;
            }
            set
            {
                this.defaultType = value;
            }
        }

        public DataRow EditRow
        {
            get
            {
                return this.editRow;
            }
            set
            {
                this.editRow = value;
            }
        }

        public GoodBufferEdit()
        {
            this.InitializeComponent();
            this.Shown += new Shown(this.GoodBufferEdit_Shown);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lMarking = new Label();
            this.teMarking = new TextEdit();
            this.lLenght = new Label();
            this.lHeight = new Label();
            this.lWidth = new Label();
            this.ceLenght = new CalcEdit();
            this.ceHeight = new CalcEdit();
            this.ceWidth = new CalcEdit();
            this.cbeStatus = new ComboBoxEdit();
            this.lStatus = new Label();
            this.meComment = new MemoEdit();
            this.lComment = new Label();
            this.bOK = new Button();
            this.blTop = new AtBevel();
            this.ceWeight = new CalcEdit();
            this.lWeight = new Label();
            this.atBevel1 = new AtBevel();
            this.atBevel2 = new AtBevel();
            this.atBevel3 = new AtBevel();
            this.teRow = new TextEdit();
            this.label1 = new Label();
            this.teCell = new TextEdit();
            this.label2 = new Label();
            this.atBevel4 = new AtBevel();
            this.teMarking.Properties.BeginInit();
            this.ceLenght.Properties.BeginInit();
            this.ceHeight.Properties.BeginInit();
            this.ceWidth.Properties.BeginInit();
            this.cbeStatus.Properties.BeginInit();
            this.meComment.Properties.BeginInit();
            this.ceWeight.Properties.BeginInit();
            this.teRow.Properties.BeginInit();
            this.teCell.Properties.BeginInit();
            this.SuspendLayout();
            this.lMarking.AutoSize = true;
            this.lMarking.Location = new Point(3, 14);
            this.lMarking.Name = "lMarking";
            this.lMarking.Size = new Size(70, 13);
            this.lMarking.TabIndex = 0;
            this.lMarking.Text = "Маркировка";
            this.teMarking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.teMarking.Location = new Point(101, 11);
            this.teMarking.Name = "teMarking";
            this.teMarking.Size = new Size(131, 20);
            this.teMarking.TabIndex = 1;
            this.lLenght.AutoSize = true;
            this.lLenght.Location = new Point(3, 50);
            this.lLenght.Name = "lLenght";
            this.lLenght.Size = new Size(40, 13);
            this.lLenght.TabIndex = 2;
            this.lLenght.Text = "Длина";
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new Point(3, 76);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new Size(45, 13);
            this.lHeight.TabIndex = 4;
            this.lHeight.Text = "Высота";
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new Point(3, 102);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new Size(46, 13);
            this.lWidth.TabIndex = 6;
            this.lWidth.Text = "Ширина";
            this.ceLenght.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.ceLenght.Location = new Point(101, 47);
            this.ceLenght.Name = "ceLenght";
            this.ceLenght.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.ceLenght.Size = new Size(131, 20);
            this.ceLenght.TabIndex = 8;
            this.ceHeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.ceHeight.Location = new Point(101, 73);
            this.ceHeight.Name = "ceHeight";
            this.ceHeight.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.ceHeight.Size = new Size(131, 20);
            this.ceHeight.TabIndex = 9;
            this.ceWidth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.ceWidth.Location = new Point(101, 99);
            this.ceWidth.Name = "ceWidth";
            this.ceWidth.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.ceWidth.Size = new Size(131, 20);
            this.ceWidth.TabIndex = 10;
            this.cbeStatus.AllowDrop = true;
            this.cbeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cbeStatus.Location = new Point(101, 161);
            this.cbeStatus.Name = "cbeStatus";
            this.cbeStatus.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cbeStatus.Properties.Items.AddRange(new object[5]
      {
        (object) "sdf",
        (object) "s",
        (object) "df",
        (object) "sd",
        (object) "f"
      });
            this.cbeStatus.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cbeStatus.Size = new Size(131, 20);
            this.cbeStatus.TabIndex = 11;
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new Point(3, 164);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new Size(41, 13);
            this.lStatus.TabIndex = 12;
            this.lStatus.Text = "Статус";
            this.meComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.meComment.Location = new Point(6, 272);
            this.meComment.Name = "meComment";
            this.meComment.Size = new Size(226, 69);
            this.meComment.TabIndex = 13;
            this.lComment.AutoSize = true;
            this.lComment.Location = new Point(3, 256);
            this.lComment.Name = "lComment";
            this.lComment.Size = new Size(77, 13);
            this.lComment.TabIndex = 14;
            this.lComment.Text = "Комментарий";
            this.bOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.bOK.FlatStyle = FlatStyle.Flat;
            this.bOK.Location = new Point(157, 357);
            this.bOK.Name = "bOK";
            this.bOK.Size = new Size(75, 23);
            this.bOK.TabIndex = 15;
            this.bOK.Text = "Ок";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new EventHandler(this.bOK_Click);
            this.blTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.blTop.Location = new Point(6, 37);
            this.blTop.MaximumSize = new Size(10000, 4);
            this.blTop.Name = "blTop";
            this.blTop.Size = new Size(226, 4);
            this.blTop.TabIndex = 16;
            this.ceWeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.ceWeight.Location = new Point(101, 125);
            this.ceWeight.Name = "ceWeight";
            this.ceWeight.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.ceWeight.Size = new Size(131, 20);
            this.ceWeight.TabIndex = 18;
            this.lWeight.AutoSize = true;
            this.lWeight.Location = new Point(3, 128);
            this.lWeight.Name = "lWeight";
            this.lWeight.Size = new Size(26, 13);
            this.lWeight.TabIndex = 17;
            this.lWeight.Text = "Вес";
            this.atBevel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.atBevel1.Location = new Point(6, 151);
            this.atBevel1.MaximumSize = new Size(10000, 4);
            this.atBevel1.Name = "atBevel1";
            this.atBevel1.Size = new Size(226, 4);
            this.atBevel1.TabIndex = 19;
            this.atBevel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.atBevel2.Location = new Point(3, 187);
            this.atBevel2.MaximumSize = new Size(10000, 4);
            this.atBevel2.Name = "atBevel2";
            this.atBevel2.Size = new Size(229, 4);
            this.atBevel2.TabIndex = 20;
            this.atBevel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.atBevel3.Location = new Point(6, 347);
            this.atBevel3.MaximumSize = new Size(10000, 4);
            this.atBevel3.Name = "atBevel3";
            this.atBevel3.Size = new Size(226, 4);
            this.atBevel3.TabIndex = 21;
            this.teRow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.teRow.Location = new Point(101, 197);
            this.teRow.Name = "teRow";
            this.teRow.Properties.Appearance.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.teRow.Properties.Appearance.Options.UseBackColor = true;
            this.teRow.Size = new Size(131, 20);
            this.teRow.TabIndex = 23;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(3, 200);
            this.label1.Name = "label1";
            this.label1.Size = new Size(26, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ряд";
            this.teCell.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.teCell.Location = new Point(101, 223);
            this.teCell.Name = "teCell";
            this.teCell.Properties.Appearance.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.teCell.Properties.Appearance.Options.UseBackColor = true;
            this.teCell.Size = new Size(131, 20);
            this.teCell.TabIndex = 25;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(3, 226);
            this.label2.Name = "label2";
            this.label2.Size = new Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ячейка";
            this.atBevel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.atBevel4.Location = new Point(3, 249);
            this.atBevel4.MaximumSize = new Size(10000, 4);
            this.atBevel4.Name = "atBevel4";
            this.atBevel4.Size = new Size(229, 4);
            this.atBevel4.TabIndex = 26;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.atBevel4);
            this.Controls.Add((Control)this.teCell);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.teRow);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.atBevel3);
            this.Controls.Add((Control)this.atBevel2);
            this.Controls.Add((Control)this.atBevel1);
            this.Controls.Add((Control)this.ceWeight);
            this.Controls.Add((Control)this.lWeight);
            this.Controls.Add((Control)this.blTop);
            this.Controls.Add((Control)this.bOK);
            this.Controls.Add((Control)this.lComment);
            this.Controls.Add((Control)this.meComment);
            this.Controls.Add((Control)this.lStatus);
            this.Controls.Add((Control)this.cbeStatus);
            this.Controls.Add((Control)this.ceWidth);
            this.Controls.Add((Control)this.ceHeight);
            this.Controls.Add((Control)this.ceLenght);
            this.Controls.Add((Control)this.lWidth);
            this.Controls.Add((Control)this.lHeight);
            this.Controls.Add((Control)this.lLenght);
            this.Controls.Add((Control)this.teMarking);
            this.Controls.Add((Control)this.lMarking);
            this.MinimumSize = new Size(235, 335);
            this.Name = "GoodBufferEdit";
            this.Size = new Size(235, 390);
            this.teMarking.Properties.EndInit();
            this.ceLenght.Properties.EndInit();
            this.ceHeight.Properties.EndInit();
            this.ceWidth.Properties.EndInit();
            this.cbeStatus.Properties.EndInit();
            this.meComment.Properties.EndInit();
            this.ceWeight.Properties.EndInit();
            this.teRow.Properties.EndInit();
            this.teCell.Properties.EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void GoodBufferEdit_Shown(object sender, EventArgs e)
        {
            this.MakeItems();
        }

        private void MakeItems()
        {
            this.cbeStatus.Properties.Items.Clear();
            this.cbeStatus.Properties.Items.Add((object)string.Empty);
            this.enumValuesHash.Add(string.Empty, (object)DBNull.Value);
            foreach (GoodBufferUtils.GoodBufferType goodBufferType in Enum.GetValues(typeof(GoodBufferUtils.GoodBufferType)))
            {
                string displayName = EnumUtils.GetDisplayName((Enum)goodBufferType);
                this.cbeStatus.Properties.Items.Add((object)displayName);
                if (goodBufferType == this.DefaultType)
                    this.cbeStatus.SelectedItem = (object)displayName;
                this.enumValuesHash.Add(displayName, (object)goodBufferType);
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (this.EditRow != null)
            {
                this.EditRow["marking"] = string.IsNullOrEmpty(this.teMarking.Text) ? (object)DBNull.Value : (object)this.teMarking.Text;
                this.EditRow["thick"] = string.IsNullOrEmpty(this.ceLenght.Text) ? (object)DBNull.Value : (object)this.ceLenght.Value;
                this.EditRow["height"] = string.IsNullOrEmpty(this.ceHeight.Text) ? (object)DBNull.Value : (object)this.ceHeight.Value;
                this.EditRow["width"] = string.IsNullOrEmpty(this.ceWidth.Text) ? (object)DBNull.Value : (object)this.ceWidth.Value;
                this.EditRow["weight"] = string.IsNullOrEmpty(this.ceWeight.Text) ? (object)DBNull.Value : (object)this.ceWeight.Value;
                this.EditRow["row"] = string.IsNullOrEmpty(this.teRow.Text) ? (object)DBNull.Value : (object)this.teRow.Text;
                this.EditRow["cell"] = string.IsNullOrEmpty(this.teCell.Text) ? (object)DBNull.Value : (object)this.teCell.Text;
                if (this.cbeStatus.EditValue == null)
                    this.cbeStatus.EditValue = (object)string.Empty;
                this.EditRow["status"] = this.enumValuesHash[this.cbeStatus.EditValue.ToString()];
                this.EditRow["status_name"] = (object)this.cbeStatus.EditValue.ToString();
                this.EditRow["comment"] = string.IsNullOrEmpty(this.meComment.Text) ? (object)DBNull.Value : (object)this.meComment.Text;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
