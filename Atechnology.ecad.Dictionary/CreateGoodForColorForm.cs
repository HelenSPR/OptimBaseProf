// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.CreateGoodForColorForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.DBConnections2;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class CreateGoodForColorForm : Form
    {
        private IContainer components;
        private TreeList treeList1;
        private Button cmdCancel;
        private Button cmdCreate;
        private DataSet ds;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private TreeListColumn colname;
        private TreeListColumn colisactive;
        public DataTable table_colorgroup;
        public CheckEdit chkInSideColor;
        public CheckEdit chkOutSideColor;
        public CheckEdit chkDoubleSideColor;
        private GroupBox groupBox1;
        public CheckEdit chkCreateGoodGroup;

        public CreateGoodForColorForm(dbconn _db)
        {
            this.InitializeComponent();
            _db.command.CommandText = "select * from colorgroup where deleted is null";
            _db.adapter.Fill(this.table_colorgroup);
            this.cmdCreate.Click += new EventHandler(this.cmdCreate_Click);
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            this.table_colorgroup.AcceptChanges();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CreateGoodForColorForm));
            this.chkInSideColor = new CheckEdit();
            this.chkOutSideColor = new CheckEdit();
            this.chkDoubleSideColor = new CheckEdit();
            this.treeList1 = new TreeList();
            this.colname = new TreeListColumn();
            this.colisactive = new TreeListColumn();
            this.ds = new DataSet();
            this.table_colorgroup = new DataTable();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.cmdCancel = new Button();
            this.cmdCreate = new Button();
            this.groupBox1 = new GroupBox();
            this.chkCreateGoodGroup = new CheckEdit();
            this.chkInSideColor.Properties.BeginInit();
            this.chkOutSideColor.Properties.BeginInit();
            this.chkDoubleSideColor.Properties.BeginInit();
            this.treeList1.BeginInit();
            this.ds.BeginInit();
            this.table_colorgroup.BeginInit();
            this.groupBox1.SuspendLayout();
            this.chkCreateGoodGroup.Properties.BeginInit();
            this.SuspendLayout();
            this.chkInSideColor.EditValue = (object)true;
            this.chkInSideColor.Location = new Point(11, 19);
            this.chkInSideColor.Name = "chkInSideColor";
            this.chkInSideColor.Properties.Caption = "Внутренняя ламинация";
            this.chkInSideColor.Size = new Size(147, 19);
            this.chkInSideColor.TabIndex = 0;
            this.chkOutSideColor.EditValue = (object)true;
            this.chkOutSideColor.Location = new Point(11, 44);
            this.chkOutSideColor.Name = "chkOutSideColor";
            this.chkOutSideColor.Properties.Caption = "Внешняя ламинация";
            this.chkOutSideColor.Size = new Size(147, 19);
            this.chkOutSideColor.TabIndex = 0;
            this.chkDoubleSideColor.EditValue = (object)true;
            this.chkDoubleSideColor.Location = new Point(11, 69);
            this.chkDoubleSideColor.Name = "chkDoubleSideColor";
            this.chkDoubleSideColor.Properties.Caption = "Двухсторонняя ламинация";
            this.chkDoubleSideColor.Size = new Size(175, 19);
            this.chkDoubleSideColor.TabIndex = 0;
            this.treeList1.BorderStyle = BorderStyles.Simple;
            this.treeList1.Columns.AddRange(new TreeListColumn[2]
      {
        this.colname,
        this.colisactive
      });
            this.treeList1.DataMember = "colorgroup";
            this.treeList1.DataSource = (object)this.ds;
            this.treeList1.KeyFieldName = "idcolorgroup";
            this.treeList1.Location = new Point(12, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.ParentFieldName = "parentid";
            this.treeList1.PreviewFieldName = "name";
            this.treeList1.Size = new Size(270, 206);
            this.treeList1.TabIndex = 1;
            this.colname.Caption = "Группа";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 284;
            this.colisactive.Caption = "V";
            this.colisactive.FieldName = "isactive";
            this.colisactive.Name = "colisactive";
            this.colisactive.Visible = true;
            this.colisactive.VisibleIndex = 1;
            this.colisactive.Width = 42;
            this.ds.DataSetName = "NewDataSet";
            this.ds.Tables.AddRange(new DataTable[1]
      {
        this.table_colorgroup
      });
            this.table_colorgroup.Columns.AddRange(new DataColumn[4]
      {
        this.dataColumn1,
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4
      });
            this.table_colorgroup.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idcolorgroup"
        }, 1 != 0)
      });
            this.table_colorgroup.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn1
      };
            this.table_colorgroup.TableName = "colorgroup";
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "idcolorgroup";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn2.ColumnName = "parentid";
            this.dataColumn2.DataType = typeof(int);
            this.dataColumn3.ColumnName = "name";
            this.dataColumn4.ColumnName = "isactive";
            this.dataColumn4.DataType = typeof(bool);
            this.cmdCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.FlatStyle = FlatStyle.Flat;
            this.cmdCancel.Location = new Point(194, 377);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Отменить";
            this.cmdCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmdCreate.DialogResult = DialogResult.OK;
            this.cmdCreate.FlatStyle = FlatStyle.Flat;
            this.cmdCreate.Location = new Point(113, 377);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new Size(75, 23);
            this.cmdCreate.TabIndex = 2;
            this.cmdCreate.Text = "Создать";
            this.groupBox1.Controls.Add((Control)this.chkDoubleSideColor);
            this.groupBox1.Controls.Add((Control)this.chkOutSideColor);
            this.groupBox1.Controls.Add((Control)this.chkInSideColor);
            this.groupBox1.Location = new Point(18, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(264, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стороны ламинации";
            this.chkCreateGoodGroup.EditValue = (object)true;
            this.chkCreateGoodGroup.Location = new Point(44, 338);
            this.chkCreateGoodGroup.Name = "chkCreateGoodGroup";
            this.chkCreateGoodGroup.Properties.Caption = "Создавать группы материалов";
            this.chkCreateGoodGroup.Size = new Size(195, 19);
            this.chkCreateGoodGroup.TabIndex = 0;
            this.AcceptButton = (IButtonControl)this.cmdCreate;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = (IButtonControl)this.cmdCancel;
            this.ClientSize = new Size(291, 412);
            this.ControlBox = false;
            this.Controls.Add((Control)this.chkCreateGoodGroup);
            this.Controls.Add((Control)this.groupBox1);
            this.Controls.Add((Control)this.cmdCancel);
            this.Controls.Add((Control)this.cmdCreate);
            this.Controls.Add((Control)this.treeList1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.Name = "CreateGoodForColorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Создание материалов по цветам конструкций";
            this.chkInSideColor.Properties.EndInit();
            this.chkOutSideColor.Properties.EndInit();
            this.chkDoubleSideColor.Properties.EndInit();
            this.treeList1.EndInit();
            this.ds.EndInit();
            this.table_colorgroup.EndInit();
            this.groupBox1.ResumeLayout(false);
            this.chkCreateGoodGroup.Properties.EndInit();
            this.ResumeLayout(false);
        }
    }
}
