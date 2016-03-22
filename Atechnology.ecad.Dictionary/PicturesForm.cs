// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.PicturesForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
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
using System.IO;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class PicturesForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Panel panel2;
        private GridControl gridControl1;
        private GridView gridView1;
        private SimpleButton simpleButtonApply;
        private SimpleButton simpleButtonCancel;
        private SimpleButton simpleButtonExit;
        private ds_picture ds;
        private GridColumn colidpicture;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colpicture;
        private ContextMenuStrip contextMenuStripPicture;
        private ToolStripMenuItem toolStripMenuItemAdd;
        private ToolStripMenuItem toolStripMenuItemDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemExport;
        private ToolStripMenuItem toolStripMenuItemImport;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private RepositoryItemImageEdit repositoryItemImageEdit1;
        private GridColumn colbevel;
        private GridColumn colwidth;
        private GridColumn colheight;
        private GridColumn colmarking;

        public PicturesForm()
            : this(false)
        {
        }

        public PicturesForm(bool IsLoad)
        {
            this.InitializeComponent();
            if (!IsLoad)
                return;
            this.LoadFromBase();
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void LoadFromBase()
        {
            this.ds.Clear();
            this.db.command.CommandText = "select * from picture where deleted is null";
            this.db.adapter.Fill((DataTable)this.ds.picture);
        }

        public override bool SaveToBase()
        {
            try
            {
                if (!AtDataSet.IsModifDataSet((DataSet)this.ds))
                    return true;
                this.db.SaveDatatable2((DataTable)this.ds.picture);
                this.ds.AcceptChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void simpleButtonApply_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.LoadFromBase();
        }

        private void PicturesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AtDataSet.IsModifDataSet((DataSet)this.ds))
                return;
            switch (MessageBox.Show("Сохранить изменения?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            ds_picture.pictureRow row = this.ds.picture.NewpictureRow();
            row.idpicture = dbconn.GetGenId("gen_picture");
            row.stretchvertical = false;
            row.stretchhorizontal = false;
            row.bevel = true;
            this.ds.picture.AddpictureRow(row);
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null)
                return;
            foreach (DataRow dataRow in selectedDataRows)
                dataRow.Delete();
        }

        private void toolStripMenuItemExport_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null)
                return;
            foreach (ds_picture.pictureRow pictureRow in selectedDataRows)
            {
                if (!pictureRow.IspictureNull() && this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = new FileStream(this.saveFileDialog1.FileName, FileMode.Create);
                    fileStream.Write(pictureRow.picture, 0, pictureRow.picture.Length);
                    fileStream.Dispose();
                }
            }
        }

        private void toolStripMenuItemImport_Click(object sender, EventArgs e)
        {
            DataRow[] selectedDataRows = AtGrid.getSelectedDataRows((Control)this.gridControl1);
            if (selectedDataRows == null)
                return;
            foreach (ds_picture.pictureRow pictureRow in selectedDataRows)
            {
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = new FileStream(this.openFileDialog1.FileName, FileMode.Open);
                    byte[] buffer = new byte[(int)fileStream.Length];
                    fileStream.Read(buffer, 0, (int)fileStream.Length);
                    pictureRow.picture = buffer;
                    fileStream.Dispose();
                }
            }
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
            this.panel1 = new Panel();
            this.simpleButtonApply = new SimpleButton();
            this.simpleButtonCancel = new SimpleButton();
            this.simpleButtonExit = new SimpleButton();
            this.panel2 = new Panel();
            this.gridControl1 = new GridControl();
            this.contextMenuStripPicture = new ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new ToolStripMenuItem();
            this.toolStripMenuItemDelete = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItemExport = new ToolStripMenuItem();
            this.toolStripMenuItemImport = new ToolStripMenuItem();
            this.ds = new ds_picture();
            this.gridView1 = new GridView();
            this.colidpicture = new GridColumn();
            this.colname = new GridColumn();
            this.colcomment = new GridColumn();
            this.colpicture = new GridColumn();
            this.repositoryItemImageEdit1 = new RepositoryItemImageEdit();
            this.colbevel = new GridColumn();
            this.colwidth = new GridColumn();
            this.colheight = new GridColumn();
            this.colmarking = new GridColumn();
            this.openFileDialog1 = new OpenFileDialog();
            this.saveFileDialog1 = new SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gridControl1.BeginInit();
            this.contextMenuStripPicture.SuspendLayout();
            this.ds.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemImageEdit1.BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add((Control)this.simpleButtonApply);
            this.panel1.Controls.Add((Control)this.simpleButtonCancel);
            this.panel1.Controls.Add((Control)this.simpleButtonExit);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(908, 35);
            this.panel1.TabIndex = 0;
            this.simpleButtonApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonApply.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonApply.Location = new Point(668, 6);
            this.simpleButtonApply.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonApply.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonApply.Name = "simpleButtonApply";
            this.simpleButtonApply.Size = new Size(75, 23);
            this.simpleButtonApply.TabIndex = 0;
            this.simpleButtonApply.Text = "Применить";
            this.simpleButtonApply.Click += new EventHandler(this.simpleButtonApply_Click);
            this.simpleButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonCancel.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonCancel.Location = new Point(749, 6);
            this.simpleButtonCancel.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new Size(75, 23);
            this.simpleButtonCancel.TabIndex = 0;
            this.simpleButtonCancel.Text = "Отменить";
            this.simpleButtonCancel.Click += new EventHandler(this.simpleButtonCancel_Click);
            this.simpleButtonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonExit.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonExit.Location = new Point(830, 6);
            this.simpleButtonExit.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new Size(75, 23);
            this.simpleButtonExit.TabIndex = 0;
            this.simpleButtonExit.Text = "Выход";
            this.simpleButtonExit.Click += new EventHandler(this.simpleButtonExit_Click);
            this.panel2.Controls.Add((Control)this.gridControl1);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(908, 538);
            this.panel2.TabIndex = 1;
            this.gridControl1.ContextMenuStrip = this.contextMenuStripPicture;
            this.gridControl1.DataMember = "picture";
            this.gridControl1.DataSource = (object)this.ds;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new Point(0, 0);
            this.gridControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = (BaseView)this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemImageEdit1
      });
            this.gridControl1.Size = new Size(908, 538);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
            this.contextMenuStripPicture.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.toolStripMenuItemAdd,
        (ToolStripItem) this.toolStripMenuItemDelete,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItemExport,
        (ToolStripItem) this.toolStripMenuItemImport
      });
            this.contextMenuStripPicture.Name = "contextMenuStripPicture";
            this.contextMenuStripPicture.Size = new Size(125, 98);
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new Size(124, 22);
            this.toolStripMenuItemAdd.Text = "Добавить";
            this.toolStripMenuItemAdd.Click += new EventHandler(this.toolStripMenuItemAdd_Click);
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new Size(124, 22);
            this.toolStripMenuItemDelete.Text = "Удалить";
            this.toolStripMenuItemDelete.Click += new EventHandler(this.toolStripMenuItemDelete_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(121, 6);
            this.toolStripMenuItemExport.Name = "toolStripMenuItemExport";
            this.toolStripMenuItemExport.Size = new Size(124, 22);
            this.toolStripMenuItemExport.Text = "Экспорт";
            this.toolStripMenuItemExport.Click += new EventHandler(this.toolStripMenuItemExport_Click);
            this.toolStripMenuItemImport.Name = "toolStripMenuItemImport";
            this.toolStripMenuItemImport.Size = new Size(124, 22);
            this.toolStripMenuItemImport.Text = "Импорт";
            this.toolStripMenuItemImport.Click += new EventHandler(this.toolStripMenuItemImport_Click);
            this.ds.DataSetName = "ds_picture";
            this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.BorderStyle = BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new GridColumn[8]
      {
        this.colidpicture,
        this.colname,
        this.colcomment,
        this.colpicture,
        this.colbevel,
        this.colwidth,
        this.colheight,
        this.colmarking
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowIndicator = false;
            this.colidpicture.Caption = "#";
            this.colidpicture.FieldName = "idpicture";
            this.colidpicture.Name = "colidpicture";
            this.colidpicture.OptionsColumn.AllowEdit = false;
            this.colidpicture.OptionsFilter.AllowFilter = false;
            this.colidpicture.Visible = true;
            this.colidpicture.VisibleIndex = 0;
            this.colname.Caption = "Наименование";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsFilter.AllowFilter = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colcomment.Caption = "Комментарий";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.OptionsFilter.AllowFilter = false;
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 3;
            this.colpicture.Caption = "Рисунок";
            this.colpicture.ColumnEdit = (RepositoryItem)this.repositoryItemImageEdit1;
            this.colpicture.FieldName = "picture";
            this.colpicture.Name = "colpicture";
            this.colpicture.OptionsColumn.AllowEdit = false;
            this.colpicture.OptionsFilter.AllowFilter = false;
            this.colpicture.Visible = true;
            this.colpicture.VisibleIndex = 4;
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.colbevel.Caption = "Бевель";
            this.colbevel.FieldName = "bevel";
            this.colbevel.Name = "colbevel";
            this.colbevel.Visible = true;
            this.colbevel.VisibleIndex = 5;
            this.colwidth.Caption = "Ширина";
            this.colwidth.FieldName = "width";
            this.colwidth.Name = "colwidth";
            this.colwidth.Visible = true;
            this.colwidth.VisibleIndex = 6;
            this.colheight.Caption = "Высота";
            this.colheight.FieldName = "height";
            this.colheight.Name = "colheight";
            this.colheight.Visible = true;
            this.colheight.VisibleIndex = 7;
            this.colmarking.Caption = "Артикул";
            this.colmarking.FieldName = "marking";
            this.colmarking.Name = "colmarking";
            this.colmarking.Visible = true;
            this.colmarking.VisibleIndex = 1;
            this.openFileDialog1.Filter = "Рисунки svg|*.svg";
            this.saveFileDialog1.Filter = "Рисунки svg|*.svg";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.panel2);
            this.Controls.Add((Control)this.panel1);
            this.Name = "PicturesForm";
            this.Size = new Size(908, 573);
            this.Text = "Рисунки витражей";
            this.FormClosing += new FormClosing(this.PicturesForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gridControl1.EndInit();
            this.contextMenuStripPicture.ResumeLayout(false);
            this.ds.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemImageEdit1.EndInit();
            this.ResumeLayout(false);
        }
    }
}
