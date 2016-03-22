// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.PollEditForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Atechnology.ecad.Dictionary
{
    public class PollEditForm : AtUserControl
    {
        public int? IdPoll = new int?();
        private DataTable tabP = new DataTable();
        private DataTable tabPQ = new DataTable();
        private DataTable tabPA = new DataTable();
        private DataTable tabPR = new DataTable();
        private IContainer components;
        private Panel panel2;
        private SimpleButton simpleButtonExit;
        private SimpleButton simpleButtonApply;
        private SimpleButton simpleButtonCancel;
        private DataSet ds_polledit;
        private ContextMenuStrip contextMenuStripPollQuestion;
        private ToolStripMenuItem toolStripMenuItemPollQuestionAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemPollQuestionDelete;
        private ToolStripMenuItem toolStripMenuItemAddNewAnswer;
        private ToolStripMenuItem toolStripMenuItemDeleteAnswer;
        private ToolStripMenuItem toolStripMenuItemAddNewPollQuestion;
        private ToolStripMenuItem toolStripMenuItemAddExistAnswer;
        private ImageList imageListPollEdit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItemRelationMoveUp;
        private ToolStripMenuItem toolStripMenuItemRelationMoveDown;
        private ToolStripMenuItem toolStripMenuItemMove;
        private ToolStripMenuItem toolStripMenuItemMakeRoot;
        private TextEdit textEditHeadName;
        private DateEdit dateEditHeadDate;
        private LabelControl labelControlHeadDate;
        private PanelControl panelControl1;
        private LabelControl labelControlHeadAnswer;
        private SplitContainer splitContainer1;
        private TreeList treeListPollRelation;
        private TreeListColumn treeListColumn2;
        private TreeListColumn treeListColumn1;
        private Panel panelQuestion;
        private ComboBoxEdit comboBoxTypeAnswer;
        private CheckEdit checkEditQuestionObligatory;
        private MemoEdit memoEditQuestionQuery;
        private LabelControl labelQuestionQuery;
        private LabelControl labelControlQuestionTypeAnswer;
        private LabelControl labelControlQuestionPicture;
        private PictureEdit pictureEditQuestionPicture;
        private LabelControl labelControlQuestionExplanation;
        private TextEdit textEditQuestionExplanation;
        private LabelControl labelControlQuestion;
        private TextEdit Question;
        private Panel panelAnswer;
        private LabelControl labelControlAnswer;
        private LabelControl labelControlAnswerWeightAnswer;
        private SpinEdit spinEditAnswerWeightAnswer;
        private TextEdit textEditAnswer;
        private DataRow MoveGroup;
        private DataRow drPollFromList;

        public PollEditForm(int? IdPoll)
        {
            this.InitializeComponent();
            this.IdPoll = IdPoll;
            this.Text = "Опрос #" + (object)IdPoll;
            this.panelAnswer.Visible = false;
            this.panelQuestion.Visible = false;
            this.LoadFromBase();
            this.comboBoxTypeAnswer.Properties.Items.Clear();
            this.comboBoxTypeAnswer.Properties.Items.Add((object)TypeAnswer.Строка);
            this.comboBoxTypeAnswer.Properties.Items.Add((object)TypeAnswer.Текст);
            this.comboBoxTypeAnswer.Properties.Items.Add((object)TypeAnswer.Число);
            this.comboBoxTypeAnswer.Properties.Items.Add((object)TypeAnswer.Дата);
            this.comboBoxTypeAnswer.Properties.Items.Add((object)TypeAnswer.Да_нет);
            this.comboBoxTypeAnswer.Properties.Items.Add((object)TypeAnswer.Один_из);
            this.comboBoxTypeAnswer.Properties.Items.Add((object)TypeAnswer.Несколько_из);
            this.comboBoxTypeAnswer.Properties.Items.Add((object)TypeAnswer.Один_из_запрос);
            this.comboBoxTypeAnswer.Properties.Items.Add((object)TypeAnswer.Несколько_из_запрос);
        }

        public PollEditForm(DataRow drPoll)
            : this(new int?((int)drPoll["idpoll"]))
        {
            this.drPollFromList = drPoll;
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PollEditForm));
            this.contextMenuStripPollQuestion = new ContextMenuStrip(this.components);
            this.toolStripMenuItemAddNewPollQuestion = new ToolStripMenuItem();
            this.toolStripMenuItemPollQuestionAdd = new ToolStripMenuItem();
            this.toolStripMenuItemPollQuestionDelete = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolStripMenuItemAddNewAnswer = new ToolStripMenuItem();
            this.toolStripMenuItemAddExistAnswer = new ToolStripMenuItem();
            this.toolStripMenuItemDeleteAnswer = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItemRelationMoveUp = new ToolStripMenuItem();
            this.toolStripMenuItemRelationMoveDown = new ToolStripMenuItem();
            this.toolStripMenuItemMove = new ToolStripMenuItem();
            this.toolStripMenuItemMakeRoot = new ToolStripMenuItem();
            this.panel2 = new Panel();
            this.simpleButtonExit = new SimpleButton();
            this.simpleButtonApply = new SimpleButton();
            this.simpleButtonCancel = new SimpleButton();
            this.ds_polledit = new DataSet();
            this.imageListPollEdit = new ImageList(this.components);
            this.dateEditHeadDate = new DateEdit();
            this.labelControlHeadDate = new LabelControl();
            this.textEditHeadName = new TextEdit();
            this.panelControl1 = new PanelControl();
            this.labelControlHeadAnswer = new LabelControl();
            this.splitContainer1 = new SplitContainer();
            this.treeListPollRelation = new TreeList();
            this.treeListColumn2 = new TreeListColumn();
            this.treeListColumn1 = new TreeListColumn();
            this.panelQuestion = new Panel();
            this.comboBoxTypeAnswer = new ComboBoxEdit();
            this.checkEditQuestionObligatory = new CheckEdit();
            this.memoEditQuestionQuery = new MemoEdit();
            this.labelQuestionQuery = new LabelControl();
            this.labelControlQuestionTypeAnswer = new LabelControl();
            this.labelControlQuestionPicture = new LabelControl();
            this.pictureEditQuestionPicture = new PictureEdit();
            this.labelControlQuestionExplanation = new LabelControl();
            this.textEditQuestionExplanation = new TextEdit();
            this.labelControlQuestion = new LabelControl();
            this.Question = new TextEdit();
            this.panelAnswer = new Panel();
            this.labelControlAnswer = new LabelControl();
            this.labelControlAnswerWeightAnswer = new LabelControl();
            this.spinEditAnswerWeightAnswer = new SpinEdit();
            this.textEditAnswer = new TextEdit();
            this.contextMenuStripPollQuestion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ds_polledit.BeginInit();
            this.dateEditHeadDate.Properties.VistaTimeProperties.BeginInit();
            this.dateEditHeadDate.Properties.BeginInit();
            this.textEditHeadName.Properties.BeginInit();
            this.panelControl1.BeginInit();
            this.panelControl1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.treeListPollRelation.BeginInit();
            this.panelQuestion.SuspendLayout();
            this.comboBoxTypeAnswer.Properties.BeginInit();
            this.checkEditQuestionObligatory.Properties.BeginInit();
            this.memoEditQuestionQuery.Properties.BeginInit();
            this.pictureEditQuestionPicture.Properties.BeginInit();
            this.textEditQuestionExplanation.Properties.BeginInit();
            this.Question.Properties.BeginInit();
            this.panelAnswer.SuspendLayout();
            this.spinEditAnswerWeightAnswer.Properties.BeginInit();
            this.textEditAnswer.Properties.BeginInit();
            this.SuspendLayout();
            this.contextMenuStripPollQuestion.Items.AddRange(new ToolStripItem[12]
      {
        (ToolStripItem) this.toolStripMenuItemAddNewPollQuestion,
        (ToolStripItem) this.toolStripMenuItemPollQuestionAdd,
        (ToolStripItem) this.toolStripMenuItemPollQuestionDelete,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItemAddNewAnswer,
        (ToolStripItem) this.toolStripMenuItemAddExistAnswer,
        (ToolStripItem) this.toolStripMenuItemDeleteAnswer,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripMenuItemRelationMoveUp,
        (ToolStripItem) this.toolStripMenuItemRelationMoveDown,
        (ToolStripItem) this.toolStripMenuItemMove,
        (ToolStripItem) this.toolStripMenuItemMakeRoot
      });
            this.contextMenuStripPollQuestion.Name = "contextMenuStripPollQuestion";
            this.contextMenuStripPollQuestion.Size = new Size(245, 236);
            this.toolStripMenuItemAddNewPollQuestion.Name = "toolStripMenuItemAddNewPollQuestion";
            this.toolStripMenuItemAddNewPollQuestion.Size = new Size(244, 22);
            this.toolStripMenuItemAddNewPollQuestion.Text = "Добавить новый вопрос";
            this.toolStripMenuItemAddNewPollQuestion.Click += new EventHandler(this.toolStripMenuItemAddNewPollQuestion_Click);
            this.toolStripMenuItemPollQuestionAdd.Name = "toolStripMenuItemPollQuestionAdd";
            this.toolStripMenuItemPollQuestionAdd.Size = new Size(244, 22);
            this.toolStripMenuItemPollQuestionAdd.Text = "Добавить существующий вопрос";
            this.toolStripMenuItemPollQuestionAdd.Click += new EventHandler(this.toolStripMenuItemPollQuestionAdd_Click);
            this.toolStripMenuItemPollQuestionDelete.Name = "toolStripMenuItemPollQuestionDelete";
            this.toolStripMenuItemPollQuestionDelete.Size = new Size(244, 22);
            this.toolStripMenuItemPollQuestionDelete.Text = "Удалить вопрос";
            this.toolStripMenuItemPollQuestionDelete.Click += new EventHandler(this.toolStripMenuItemPollQuestionDelete_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(241, 6);
            this.toolStripMenuItemAddNewAnswer.Name = "toolStripMenuItemAddNewAnswer";
            this.toolStripMenuItemAddNewAnswer.Size = new Size(244, 22);
            this.toolStripMenuItemAddNewAnswer.Text = "Добавить новый ответ";
            this.toolStripMenuItemAddNewAnswer.Click += new EventHandler(this.toolStripMenuItemAddAnswer_Click);
            this.toolStripMenuItemAddExistAnswer.Name = "toolStripMenuItemAddExistAnswer";
            this.toolStripMenuItemAddExistAnswer.Size = new Size(244, 22);
            this.toolStripMenuItemAddExistAnswer.Text = "Добавить существующий ответ";
            this.toolStripMenuItemAddExistAnswer.Click += new EventHandler(this.toolStripMenuItemAddExistAnswer_Click);
            this.toolStripMenuItemDeleteAnswer.Name = "toolStripMenuItemDeleteAnswer";
            this.toolStripMenuItemDeleteAnswer.Size = new Size(244, 22);
            this.toolStripMenuItemDeleteAnswer.Text = "Удалить ответ";
            this.toolStripMenuItemDeleteAnswer.Click += new EventHandler(this.toolStripMenuItemDeleteAnswer_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(241, 6);
            this.toolStripMenuItemRelationMoveUp.Name = "toolStripMenuItemRelationMoveUp";
            this.toolStripMenuItemRelationMoveUp.Size = new Size(244, 22);
            this.toolStripMenuItemRelationMoveUp.Text = "Переместить вверх";
            this.toolStripMenuItemRelationMoveUp.Click += new EventHandler(this.toolStripMenuItemRelationMoveUp_Click);
            this.toolStripMenuItemRelationMoveDown.Name = "toolStripMenuItemRelationMoveDown";
            this.toolStripMenuItemRelationMoveDown.Size = new Size(244, 22);
            this.toolStripMenuItemRelationMoveDown.Text = "Переместить вниз";
            this.toolStripMenuItemRelationMoveDown.Click += new EventHandler(this.toolStripMenuItemRelationMoveDown_Click);
            this.toolStripMenuItemMove.Name = "toolStripMenuItemMove";
            this.toolStripMenuItemMove.Size = new Size(244, 22);
            this.toolStripMenuItemMove.Text = "Переместить в группу";
            this.toolStripMenuItemMove.Click += new EventHandler(this.toolStripMenuItemMove_Click);
            this.toolStripMenuItemMakeRoot.Name = "toolStripMenuItemMakeRoot";
            this.toolStripMenuItemMakeRoot.Size = new Size(244, 22);
            this.toolStripMenuItemMakeRoot.Text = "Сделать группу основной";
            this.toolStripMenuItemMakeRoot.Click += new EventHandler(this.toolStripMenuItemMakeRoot_Click);
            this.panel2.Controls.Add((Control)this.simpleButtonExit);
            this.panel2.Controls.Add((Control)this.simpleButtonApply);
            this.panel2.Controls.Add((Control)this.simpleButtonCancel);
            this.panel2.Dock = DockStyle.Bottom;
            this.panel2.Location = new Point(0, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(845, 33);
            this.panel2.TabIndex = 2;
            this.simpleButtonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonExit.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonExit.Location = new Point(767, 6);
            this.simpleButtonExit.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new Size(75, 23);
            this.simpleButtonExit.TabIndex = 2;
            this.simpleButtonExit.Text = "Закрыть";
            this.simpleButtonExit.Click += new EventHandler(this.simpleButtonExit_Click);
            this.simpleButtonApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonApply.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonApply.Location = new Point(605, 6);
            this.simpleButtonApply.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonApply.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonApply.Name = "simpleButtonApply";
            this.simpleButtonApply.Size = new Size(75, 23);
            this.simpleButtonApply.TabIndex = 1;
            this.simpleButtonApply.Text = "Применить";
            this.simpleButtonApply.Click += new EventHandler(this.simpleButtonApply_Click);
            this.simpleButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.simpleButtonCancel.ButtonStyle = BorderStyles.Simple;
            this.simpleButtonCancel.Location = new Point(686, 6);
            this.simpleButtonCancel.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new Size(75, 23);
            this.simpleButtonCancel.TabIndex = 0;
            this.simpleButtonCancel.Text = "Отменить";
            this.simpleButtonCancel.Click += new EventHandler(this.simpleButtonCancel_Click);
            this.ds_polledit.DataSetName = "NewDataSet";
            this.imageListPollEdit.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListPollEdit.ImageStream");
            this.imageListPollEdit.TransparentColor = Color.Transparent;
            this.imageListPollEdit.Images.SetKeyName(0, "help2.ico");
            this.imageListPollEdit.Images.SetKeyName(1, "code3.bmp");
            this.dateEditHeadDate.EditValue = (object)null;
            this.dateEditHeadDate.Location = new Point(95, 6);
            this.dateEditHeadDate.Name = "dateEditHeadDate";
            this.dateEditHeadDate.Properties.BorderStyle = BorderStyles.Simple;
            this.dateEditHeadDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.dateEditHeadDate.Properties.VistaTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.dateEditHeadDate.Size = new Size(135, 20);
            this.dateEditHeadDate.TabIndex = 9;
            this.labelControlHeadDate.Location = new Point(17, 9);
            this.labelControlHeadDate.Name = "labelControlHeadDate";
            this.labelControlHeadDate.Size = new Size(26, 13);
            this.labelControlHeadDate.TabIndex = 8;
            this.labelControlHeadDate.Text = "Дата";
            this.textEditHeadName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textEditHeadName.Location = new Point(426, 6);
            this.textEditHeadName.Name = "textEditHeadName";
            this.textEditHeadName.Properties.BorderStyle = BorderStyles.Simple;
            this.textEditHeadName.Size = new Size(413, 20);
            this.textEditHeadName.TabIndex = 6;
            this.textEditHeadName.EditValueChanged += new EventHandler(this.textEditHeadName_EditValueChanged);
            this.panelControl1.Controls.Add((Control)this.dateEditHeadDate);
            this.panelControl1.Controls.Add((Control)this.labelControlHeadAnswer);
            this.panelControl1.Controls.Add((Control)this.labelControlHeadDate);
            this.panelControl1.Controls.Add((Control)this.textEditHeadName);
            this.panelControl1.Dock = DockStyle.Top;
            this.panelControl1.Location = new Point(0, 0);
            this.panelControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new Size(845, 35);
            this.panelControl1.TabIndex = 4;
            this.labelControlHeadAnswer.Location = new Point(338, 9);
            this.labelControlHeadAnswer.Name = "labelControlHeadAnswer";
            this.labelControlHeadAnswer.Size = new Size(31, 13);
            this.labelControlHeadAnswer.TabIndex = 7;
            this.labelControlHeadAnswer.Text = "Опрос";
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.FixedPanel = FixedPanel.Panel1;
            this.splitContainer1.Location = new Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add((Control)this.treeListPollRelation);
            this.splitContainer1.Panel2.Controls.Add((Control)this.panelQuestion);
            this.splitContainer1.Panel2.Controls.Add((Control)this.panelAnswer);
            this.splitContainer1.Size = new Size(845, 479);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 5;
            this.treeListPollRelation.Appearance.FocusedCell.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollRelation.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeListPollRelation.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollRelation.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeListPollRelation.Appearance.HideSelectionRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollRelation.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollRelation.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeListPollRelation.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.treeListPollRelation.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeListPollRelation.BorderStyle = BorderStyles.Simple;
            this.treeListPollRelation.Columns.AddRange(new TreeListColumn[2]
      {
        this.treeListColumn2,
        this.treeListColumn1
      });
            this.treeListPollRelation.ContextMenuStrip = this.contextMenuStripPollQuestion;
            this.treeListPollRelation.Dock = DockStyle.Fill;
            this.treeListPollRelation.ImageIndexFieldName = "imageindex";
            this.treeListPollRelation.KeyFieldName = "idpollrelation";
            this.treeListPollRelation.Location = new Point(0, 0);
            this.treeListPollRelation.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.treeListPollRelation.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeListPollRelation.Name = "treeListPollRelation";
            this.treeListPollRelation.OptionsView.ShowHorzLines = false;
            this.treeListPollRelation.OptionsView.ShowIndicator = false;
            this.treeListPollRelation.OptionsView.ShowVertLines = false;
            this.treeListPollRelation.ParentFieldName = "parentid";
            this.treeListPollRelation.SelectImageList = (object)this.imageListPollEdit;
            this.treeListPollRelation.Size = new Size(328, 479);
            this.treeListPollRelation.TabIndex = 0;
            this.treeListPollRelation.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListPollRelation_FocusedNodeChanged);
            this.treeListColumn2.Caption = "Наименование";
            this.treeListColumn2.FieldName = "name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 288;
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "numpos";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.SortOrder = SortOrder.Ascending;
            this.panelQuestion.Controls.Add((Control)this.comboBoxTypeAnswer);
            this.panelQuestion.Controls.Add((Control)this.checkEditQuestionObligatory);
            this.panelQuestion.Controls.Add((Control)this.memoEditQuestionQuery);
            this.panelQuestion.Controls.Add((Control)this.labelQuestionQuery);
            this.panelQuestion.Controls.Add((Control)this.labelControlQuestionTypeAnswer);
            this.panelQuestion.Controls.Add((Control)this.labelControlQuestionPicture);
            this.panelQuestion.Controls.Add((Control)this.pictureEditQuestionPicture);
            this.panelQuestion.Controls.Add((Control)this.labelControlQuestionExplanation);
            this.panelQuestion.Controls.Add((Control)this.textEditQuestionExplanation);
            this.panelQuestion.Controls.Add((Control)this.labelControlQuestion);
            this.panelQuestion.Controls.Add((Control)this.Question);
            this.panelQuestion.Dock = DockStyle.Fill;
            this.panelQuestion.Location = new Point(0, 92);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new Size(513, 387);
            this.panelQuestion.TabIndex = 4;
            this.comboBoxTypeAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.comboBoxTypeAnswer.EditValue = (object)"";
            this.comboBoxTypeAnswer.Location = new Point(94, 224);
            this.comboBoxTypeAnswer.Name = "comboBoxTypeAnswer";
            this.comboBoxTypeAnswer.Properties.BorderStyle = BorderStyles.Simple;
            this.comboBoxTypeAnswer.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.comboBoxTypeAnswer.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.comboBoxTypeAnswer.Size = new Size(397, 20);
            this.comboBoxTypeAnswer.TabIndex = 19;
            this.comboBoxTypeAnswer.SelectedIndexChanged += new EventHandler(this.comboBoxTypeAnswer_SelectedIndexChanged);
            this.checkEditQuestionObligatory.Location = new Point(280, 68);
            this.checkEditQuestionObligatory.Name = "checkEditQuestionObligatory";
            this.checkEditQuestionObligatory.Properties.Caption = "Обязательный ответ";
            this.checkEditQuestionObligatory.Size = new Size(207, 19);
            this.checkEditQuestionObligatory.TabIndex = 17;
            this.memoEditQuestionQuery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.memoEditQuestionQuery.Location = new Point(94, 250);
            this.memoEditQuestionQuery.Name = "memoEditQuestionQuery";
            this.memoEditQuestionQuery.Properties.BorderStyle = BorderStyles.Simple;
            this.memoEditQuestionQuery.Size = new Size(397, 117);
            this.memoEditQuestionQuery.TabIndex = 15;
            this.labelQuestionQuery.Location = new Point(6, 253);
            this.labelQuestionQuery.Name = "labelQuestionQuery";
            this.labelQuestionQuery.Size = new Size(35, 13);
            this.labelQuestionQuery.TabIndex = 14;
            this.labelQuestionQuery.Text = "Запрос";
            this.labelControlQuestionTypeAnswer.Location = new Point(6, 227);
            this.labelControlQuestionTypeAnswer.Name = "labelControlQuestionTypeAnswer";
            this.labelControlQuestionTypeAnswer.Size = new Size(57, 13);
            this.labelControlQuestionTypeAnswer.TabIndex = 12;
            this.labelControlQuestionTypeAnswer.Text = "Тип ответа";
            this.labelControlQuestionPicture.Location = new Point(6, 74);
            this.labelControlQuestionPicture.Name = "labelControlQuestionPicture";
            this.labelControlQuestionPicture.Size = new Size(68, 13);
            this.labelControlQuestionPicture.TabIndex = 11;
            this.labelControlQuestionPicture.Text = "Изображение";
            this.pictureEditQuestionPicture.Location = new Point(94, 68);
            this.pictureEditQuestionPicture.Name = "pictureEditQuestionPicture";
            this.pictureEditQuestionPicture.Properties.BorderStyle = BorderStyles.Simple;
            this.pictureEditQuestionPicture.Properties.SizeMode = PictureSizeMode.Zoom;
            this.pictureEditQuestionPicture.Size = new Size(150, 150);
            this.pictureEditQuestionPicture.TabIndex = 10;
            this.labelControlQuestionExplanation.Location = new Point(6, 45);
            this.labelControlQuestionExplanation.Name = "labelControlQuestionExplanation";
            this.labelControlQuestionExplanation.Size = new Size(54, 13);
            this.labelControlQuestionExplanation.TabIndex = 9;
            this.labelControlQuestionExplanation.Text = "Пояснение";
            this.textEditQuestionExplanation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textEditQuestionExplanation.Location = new Point(94, 42);
            this.textEditQuestionExplanation.Name = "textEditQuestionExplanation";
            this.textEditQuestionExplanation.Properties.BorderStyle = BorderStyles.Simple;
            this.textEditQuestionExplanation.Size = new Size(397, 20);
            this.textEditQuestionExplanation.TabIndex = 8;
            this.labelControlQuestion.Location = new Point(6, 19);
            this.labelControlQuestion.Name = "labelControlQuestion";
            this.labelControlQuestion.Size = new Size(35, 13);
            this.labelControlQuestion.TabIndex = 7;
            this.labelControlQuestion.Text = "Вопрос";
            this.Question.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Question.Location = new Point(94, 16);
            this.Question.Name = "Question";
            this.Question.Properties.BorderStyle = BorderStyles.Simple;
            this.Question.Size = new Size(397, 20);
            this.Question.TabIndex = 6;
            this.panelAnswer.Controls.Add((Control)this.labelControlAnswer);
            this.panelAnswer.Controls.Add((Control)this.labelControlAnswerWeightAnswer);
            this.panelAnswer.Controls.Add((Control)this.spinEditAnswerWeightAnswer);
            this.panelAnswer.Controls.Add((Control)this.textEditAnswer);
            this.panelAnswer.Dock = DockStyle.Top;
            this.panelAnswer.Location = new Point(0, 0);
            this.panelAnswer.Name = "panelAnswer";
            this.panelAnswer.Size = new Size(513, 92);
            this.panelAnswer.TabIndex = 3;
            this.labelControlAnswer.Location = new Point(6, 46);
            this.labelControlAnswer.Name = "labelControlAnswer";
            this.labelControlAnswer.Size = new Size(32, 13);
            this.labelControlAnswer.TabIndex = 5;
            this.labelControlAnswer.Text = "Ответ";
            this.labelControlAnswerWeightAnswer.Location = new Point(6, 20);
            this.labelControlAnswerWeightAnswer.Name = "labelControlAnswerWeightAnswer";
            this.labelControlAnswerWeightAnswer.Size = new Size(56, 13);
            this.labelControlAnswerWeightAnswer.TabIndex = 4;
            this.labelControlAnswerWeightAnswer.Text = "Вес ответа";
            this.spinEditAnswerWeightAnswer.EditValue = (object)new Decimal(new int[4]);
            this.spinEditAnswerWeightAnswer.Location = new Point(94, 17);
            this.spinEditAnswerWeightAnswer.Name = "spinEditAnswerWeightAnswer";
            this.spinEditAnswerWeightAnswer.Properties.BorderStyle = BorderStyles.Simple;
            this.spinEditAnswerWeightAnswer.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.spinEditAnswerWeightAnswer.Size = new Size(105, 20);
            this.spinEditAnswerWeightAnswer.TabIndex = 3;
            this.textEditAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textEditAnswer.Location = new Point(94, 43);
            this.textEditAnswer.Name = "textEditAnswer";
            this.textEditAnswer.Properties.BorderStyle = BorderStyles.Simple;
            this.textEditAnswer.Size = new Size(397, 20);
            this.textEditAnswer.TabIndex = 0;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.splitContainer1);
            this.Controls.Add((Control)this.panelControl1);
            this.Controls.Add((Control)this.panel2);
            this.Name = "PollEditForm";
            this.Size = new Size(845, 547);
            this.Text = "Вопросы";
            this.FormClosing += new FormClosing(this.PollEditForm_FormClosing);
            this.contextMenuStripPollQuestion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ds_polledit.EndInit();
            this.dateEditHeadDate.Properties.VistaTimeProperties.EndInit();
            this.dateEditHeadDate.Properties.EndInit();
            this.textEditHeadName.Properties.EndInit();
            this.panelControl1.EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.treeListPollRelation.EndInit();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.comboBoxTypeAnswer.Properties.EndInit();
            this.checkEditQuestionObligatory.Properties.EndInit();
            this.memoEditQuestionQuery.Properties.EndInit();
            this.pictureEditQuestionPicture.Properties.EndInit();
            this.textEditQuestionExplanation.Properties.EndInit();
            this.Question.Properties.EndInit();
            this.panelAnswer.ResumeLayout(false);
            this.panelAnswer.PerformLayout();
            this.spinEditAnswerWeightAnswer.Properties.EndInit();
            this.textEditAnswer.Properties.EndInit();
            this.ResumeLayout(false);
        }

        private void tabPQ_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName == "question")
            {
                foreach (DataRow dataRow in e.Row.GetChildRows("pollquestion_pollrelation"))
                {
                    dataRow["pollquestion_question"] = e.Row["question"];
                    dataRow["name"] = e.Row["question"];
                }
            }
            else
            {
                if (!(e.Column.ColumnName == "typeanswer"))
                    return;
                foreach (DataRow dataRow in e.Row.GetChildRows("pollquestion_pollrelation"))
                {
                    if (dataRow.GetChildRows("pollrelation_pollrelation").Length != 0 && this.comboBoxTypeAnswer.Text != TypeAnswer.Несколько_из.ToString() && this.comboBoxTypeAnswer.Text != TypeAnswer.Один_из.ToString())
                    {
                        this.comboBoxTypeAnswer.Text = TypeAnswer.Один_из.ToString();
                        int num = (int)MessageBox.Show("Нельзя сменить тип вопроса, имеются подчиненные ответы!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void tabPA_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            foreach (DataRow dataRow in e.Row.GetChildRows("pollanswer_pollrelation"))
            {
                dataRow["pollanswer_answer"] = e.Row["answer"];
                dataRow["name"] = e.Row["answer"];
            }
        }

        public override bool SaveToBase()
        {
            try
            {
                this.BindingContext[(object)this.tabP].EndCurrentEdit();
                this.BindingContext[(object)this.tabPA].EndCurrentEdit();
                this.BindingContext[(object)this.tabPQ].EndCurrentEdit();
                this.BindingContext[(object)this.tabPR].EndCurrentEdit();
                this.db.SaveDatatable2(this.tabP);
                this.db.SaveDatatable2(this.tabPQ);
                this.db.SaveDatatable2(this.tabPA);
                this.db.SaveDatatable2(this.tabPR);
                this.ds_polledit.AcceptChanges();
                if (this.drPollFromList != null && this.tabP.Select().Length > 0)
                {
                    AtDataSet.LoadRow(this.tabP.Select()[0], this.drPollFromList, false);
                    this.drPollFromList.AcceptChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void LoadFromBase()
        {
            if (!this.IdPoll.HasValue)
                return;
            this.ds_polledit = new DataSet();
            dbconn._db.command.CommandText = "select * from view_poll where idpoll=" + (object)this.IdPoll;
            dbconn._db.adapter.Fill(this.ds_polledit, "poll");
            this.tabP = this.ds_polledit.Tables["poll"];
            dbconn._db.command.CommandText = "select * from view_pollquestion where deleted is null and idpoll=" + (object)this.IdPoll;
            dbconn._db.adapter.Fill(this.ds_polledit, "pollquestion");
            this.tabPQ = this.ds_polledit.Tables["pollquestion"];
            dbconn._db.command.CommandText = "select * from view_pollanswer where deleted is null and idpoll=" + (object)this.IdPoll;
            dbconn._db.adapter.Fill(this.ds_polledit, "pollanswer");
            this.tabPA = this.ds_polledit.Tables["pollanswer"];
            dbconn._db.command.CommandText = "select *,case when idpollquestion is not null then 0 else 1 end as imageindex from view_pollrelation where deleted is null and idpoll=" + (object)this.IdPoll;
            dbconn._db.adapter.Fill(this.ds_polledit, "pollrelation");
            this.tabPR = this.ds_polledit.Tables["pollrelation"];
            this.tabPR.Constraints.Add("PK_pollrelation", this.tabPR.Columns["idpollrelation"], true);
            this.tabPA.Constraints.Add("PK_pollanswer", this.tabPA.Columns["idpollanswer"], true);
            this.tabPQ.Constraints.Add("PK_pollquestion", this.tabPQ.Columns["idpollquestion"], true);
            this.tabP.Constraints.Add("PK_poll", this.tabP.Columns["idpoll"], true);
            this.ds_polledit.Relations.Add("poll_pollquestion", this.ds_polledit.Tables["poll"].Columns["idpoll"], this.ds_polledit.Tables["pollquestion"].Columns["idpoll"]);
            this.ds_polledit.Relations.Add("pollquestion_pollrelation", this.ds_polledit.Tables["pollquestion"].Columns["idpollquestion"], this.ds_polledit.Tables["pollrelation"].Columns["idpollquestion"]);
            this.ds_polledit.Relations.Add("pollanswer_pollrelation", this.ds_polledit.Tables["pollanswer"].Columns["idpollanswer"], this.ds_polledit.Tables["pollrelation"].Columns["idpollanswer"]);
            this.ds_polledit.Relations.Add("pollrelation_pollrelation", this.ds_polledit.Tables["pollrelation"].Columns["idpollrelation"], this.ds_polledit.Tables["pollrelation"].Columns["parentid"]);
            this.treeListPollRelation.DataSource = (object)this.ds_polledit;
            this.treeListPollRelation.DataMember = "pollrelation";
            this.textEditHeadName.DataBindings.Clear();
            this.textEditHeadName.DataBindings.Add("EditValue", (object)this.ds_polledit.Tables["poll"], "name", true, DataSourceUpdateMode.OnPropertyChanged, (object)"");
            this.dateEditHeadDate.DataBindings.Clear();
            this.dateEditHeadDate.DataBindings.Add("EditValue", (object)this.ds_polledit.Tables["poll"], "dtedit", true);
            this.spinEditAnswerWeightAnswer.DataBindings.Clear();
            this.spinEditAnswerWeightAnswer.DataBindings.Add("Value", (object)this.ds_polledit.Tables["pollanswer"], "weightanswer", true, DataSourceUpdateMode.OnPropertyChanged, (object)0);
            this.textEditAnswer.DataBindings.Clear();
            this.textEditAnswer.DataBindings.Add("Text", (object)this.ds_polledit.Tables["pollanswer"], "answer", true, DataSourceUpdateMode.OnPropertyChanged, (object)0);
            this.Question.DataBindings.Clear();
            this.Question.DataBindings.Add("Text", (object)this.ds_polledit.Tables["pollquestion"], "question", true, DataSourceUpdateMode.OnPropertyChanged, (object)"");
            this.textEditQuestionExplanation.DataBindings.Clear();
            this.textEditQuestionExplanation.DataBindings.Add("Text", (object)this.ds_polledit.Tables["pollquestion"], "explanation", true, DataSourceUpdateMode.OnPropertyChanged, (object)"");
            this.pictureEditQuestionPicture.DataBindings.Clear();
            this.pictureEditQuestionPicture.DataBindings.Add("Image", (object)this.ds_polledit.Tables["pollquestion"], "picture", true, DataSourceUpdateMode.OnPropertyChanged, (object)null);
            this.comboBoxTypeAnswer.DataBindings.Clear();
            this.comboBoxTypeAnswer.DataBindings.Add("Text", (object)this.ds_polledit.Tables["pollquestion"], "typeanswer", true, DataSourceUpdateMode.OnPropertyChanged, (object)"");
            this.memoEditQuestionQuery.DataBindings.Clear();
            this.memoEditQuestionQuery.DataBindings.Add("Text", (object)this.ds_polledit.Tables["pollquestion"], "query", true, DataSourceUpdateMode.OnPropertyChanged, (object)"");
            this.checkEditQuestionObligatory.DataBindings.Clear();
            this.checkEditQuestionObligatory.DataBindings.Add("Checked", (object)this.ds_polledit.Tables["pollquestion"], "obligatory", true, DataSourceUpdateMode.OnPropertyChanged, (object)false);
            this.tabPA.ColumnChanged += new DataColumnChangeEventHandler(this.tabPA_ColumnChanged);
            this.tabPQ.ColumnChanged += new DataColumnChangeEventHandler(this.tabPQ_ColumnChanged);
        }

        private void toolStripMenuItemPollQuestionAdd_Click(object sender, EventArgs e)
        {
            PollQuestionSelectForm questionSelectForm = new PollQuestionSelectForm(this.tabPQ);
            if (questionSelectForm.ShowDialog() != DialogResult.OK)
                return;
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
            {
                if (questionSelectForm.SelectedRow == null)
                    return;
                foreach (DataRow dataRow in questionSelectForm.SelectedRow)
                {
                    DataRow row = this.tabPR.NewRow();
                    row["idpollrelation"] = (object)dbconn.GetGenId("gen_pollrelation");
                    row["idpoll"] = (object)this.IdPoll;
                    row["idpollquestion"] = dataRow["idpollquestion"];
                    row["name"] = dataRow["question"];
                    row["imageindex"] = (object)0;
                    row["numpos"] = (object)this.GetGroupNumpos();
                    this.tabPR.Rows.Add(row);
                }
            }
            else
            {
                foreach (DataRow dataRow1 in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
                {
                    if (questionSelectForm.SelectedRow != null)
                    {
                        foreach (DataRow dataRow2 in questionSelectForm.SelectedRow)
                        {
                            DataRow row = this.tabPR.NewRow();
                            row["idpollrelation"] = (object)dbconn.GetGenId("gen_pollrelation");
                            row["idpoll"] = (object)this.IdPoll;
                            row["idpollquestion"] = dataRow2["idpollquestion"];
                            row["name"] = dataRow2["question"];
                            if (dataRow1["idpollanswer"] != DBNull.Value)
                                row["parentid"] = dataRow1["idpollrelation"];
                            row["parentid"] = dataRow1["idpollrelation"];
                            row["imageindex"] = (object)0;
                            row["numpos"] = (object)this.GetGroupNumpos();
                            this.tabPR.Rows.Add(row);
                        }
                    }
                }
            }
        }

        private void toolStripMenuItemPollQuestionDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                switch (MessageBox.Show("Удаление вопроса:\r\nДа - Удалить вопрос\r\nНет - Удалить только связь с вопросм\r\n", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DataRow parentRow = dataRow.GetParentRow("pollquestion_pollrelation");
                        if (parentRow != null)
                            parentRow.Delete();
                        dataRow.Delete();
                        break;
                    case DialogResult.No:
                        dataRow.Delete();
                        break;
                }
            }
        }

        private void simpleButtonApply_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void toolStripMenuItemAddAnswer_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
            {
                int num1 = (int)MessageBox.Show("Ответ можно добавить только к вопросу!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
                {
                    if (dataRow["idpollquestion"] == DBNull.Value)
                    {
                        int num2 = (int)MessageBox.Show("Ответ можно добавить только к вопросу!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataRow parentRow = dataRow.GetParentRow("pollquestion_pollrelation");
                        if (parentRow != null)
                        {
                            if (!this.CheckAdd(parentRow))
                            {
                                int num3 = (int)MessageBox.Show("Для данного типа вопроса ответы добавлять нельзя!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                DataRow row1 = this.tabPA.NewRow();
                                row1["idpollanswer"] = (object)dbconn.GetGenId("gen_pollanswer");
                                this.tabPA.Rows.Add(row1);
                                row1["answer"] = (object)"Новый ответ";
                                DataRow row2 = this.tabPR.NewRow();
                                row2["idpollrelation"] = (object)dbconn.GetGenId("gen_pollrelation");
                                row2["idpoll"] = (object)this.IdPoll;
                                row2["idpollanswer"] = row1["idpollanswer"];
                                row2["parentid"] = dataRow["idpollrelation"];
                                row2["imageindex"] = (object)1;
                                row2["numpos"] = (object)this.GetGroupNumpos();
                                row2["name"] = row1["answer"];
                                this.tabPR.Rows.Add(row2);
                            }
                        }
                    }
                }
            }
        }

        private void toolStripMenuItemDeleteAnswer_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                switch (MessageBox.Show("Удаление ответа:\r\nДа - Удалить ответ\r\nНет - Удалить только связь с ответом\r\n", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DataRow parentRow = dataRow.GetParentRow("pollanswer_pollrelation");
                        if (parentRow != null)
                        {
                            parentRow.Delete();
                            break;
                        }
                        break;
                    case DialogResult.No:
                        dataRow.Delete();
                        break;
                }
            }
        }

        private void toolStripMenuItemAddNewPollQuestion_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
            {
                DataRow row1 = this.tabPQ.NewRow();
                row1["idpollquestion"] = (object)dbconn.GetGenId("gen_pollquestion");
                row1["idpoll"] = (object)this.IdPoll;
                row1["question"] = (object)"Новый вопрос";
                row1["typeanswer"] = (object)TypeAnswer.Один_из.ToString();
                this.tabPQ.Rows.Add(row1);
                DataRow row2 = this.tabPR.NewRow();
                row2["idpollrelation"] = (object)dbconn.GetGenId("gen_pollrelation");
                row2["idpoll"] = (object)this.IdPoll;
                row2["idpollquestion"] = row1["idpollquestion"];
                row2["imageindex"] = (object)0;
                row2["numpos"] = (object)this.GetGroupNumpos();
                row2["name"] = row1["question"];
                this.tabPR.Rows.Add(row2);
            }
            else
            {
                foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
                {
                    DataRow row1 = this.tabPR.NewRow();
                    row1["idpollrelation"] = (object)dbconn.GetGenId("gen_pollrelation");
                    if (dataRow["idpollanswer"] != DBNull.Value)
                        row1["parentid"] = dataRow["idpollrelation"];
                    this.tabPR.Rows.Add(row1);
                    DataRow row2 = this.tabPQ.NewRow();
                    row2["idpollquestion"] = (object)dbconn.GetGenId("gen_pollquestion");
                    row2["idpoll"] = (object)this.IdPoll;
                    row2["question"] = (object)"Новый вопрос";
                    row2["typeanswer"] = (object)TypeAnswer.Один_из.ToString();
                    this.tabPQ.Rows.Add(row2);
                    row1["idpoll"] = (object)this.IdPoll;
                    row1["idpollquestion"] = row2["idpollquestion"];
                    row1["imageindex"] = (object)0;
                    row1["numpos"] = (object)this.GetGroupNumpos();
                    row1["name"] = row2["question"];
                }
            }
        }

        private void toolStripMenuItemAddExistAnswer_Click(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
            {
                int num1 = (int)MessageBox.Show("Ответ можно добавить только к вопросу!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (DataRow dataRow1 in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
                {
                    if (dataRow1["idpollquestion"] == DBNull.Value)
                    {
                        int num2 = (int)MessageBox.Show("Ответ можно добавить только к вопросу!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataRow parentRow = dataRow1.GetParentRow("pollquestion_pollrelation");
                        if (parentRow != null)
                        {
                            if (!this.CheckAdd(parentRow))
                            {
                                int num3 = (int)MessageBox.Show("Для данного типа вопроса ответы добавлять нельзя!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                PollAnswerSelectForm answerSelectForm = new PollAnswerSelectForm(this.tabPA);
                                if (answerSelectForm.ShowDialog() == DialogResult.OK && answerSelectForm.SelectedRows != null)
                                {
                                    foreach (DataRow dataRow2 in answerSelectForm.SelectedRows)
                                    {
                                        DataRow row = this.tabPR.NewRow();
                                        row["idpollrelation"] = (object)dbconn.GetGenId("gen_pollrelation");
                                        row["idpoll"] = (object)this.IdPoll;
                                        row["idpollanswer"] = dataRow2["idpollanswer"];
                                        row["name"] = dataRow2["answer"];
                                        row["parentid"] = dataRow1["idpollrelation"];
                                        row["imageindex"] = (object)1;
                                        row["numpos"] = (object)this.GetGroupNumpos();
                                        this.tabPR.Rows.Add(row);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void treeListPollRelation_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
                return;
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPollRelation);
            this.ShowNode(selectedNode);
            if (selectedNode["idpollquestion"] != DBNull.Value)
            {
                int num = 0;
                DataRow[] dataRowArray = this.tabPQ.Select();
                for (int index = 0; index < dataRowArray.Length && (int)dataRowArray[index]["idpollquestion"] != (int)selectedNode["idpollquestion"]; ++index)
                    ++num;
                this.BindingContext[(object)this.ds_polledit.Tables["pollquestion"]].Position = num;
            }
            if (selectedNode["idpollanswer"] != DBNull.Value)
            {
                int num = 0;
                DataRow[] dataRowArray = this.tabPA.Select();
                for (int index = 0; index < dataRowArray.Length && (int)dataRowArray[index]["idpollanswer"] != (int)selectedNode["idpollanswer"]; ++index)
                    ++num;
                this.BindingContext[(object)this.ds_polledit.Tables["pollanswer"]].Position = num;
            }
            if (selectedNode == null || this.MoveGroup == null)
                return;
            DataRow parentRow = selectedNode.GetParentRow("pollquestion_pollrelation");
            if (selectedNode["idpollquestion"] != DBNull.Value && this.MoveGroup["idpollanswer"] != DBNull.Value && parentRow != null && (parentRow["typeanswer"].ToString() == TypeAnswer.Один_из.ToString() || parentRow["typeanswer"].ToString() == TypeAnswer.Несколько_из.ToString()) || selectedNode["idpollanswer"] != DBNull.Value && this.MoveGroup["idpollquestion"] != DBNull.Value)
            {
                this.treeListPollRelation.DataSource = (object)null;
                this.MoveGroup["parentid"] = selectedNode["idpollrelation"];
                this.treeListPollRelation.DataSource = (object)this.ds_polledit;
            }
            this.Cursor = Cursors.Default;
            this.MoveGroup = (DataRow)null;
        }

        private void ShowNode(DataRow drRel)
        {
            if (drRel["idpollquestion"] != DBNull.Value)
            {
                this.panelAnswer.Visible = false;
                this.panelQuestion.Visible = true;
            }
            else
            {
                this.panelQuestion.Visible = false;
                this.panelAnswer.Visible = true;
            }
        }

        private void Question_EditValueChanged(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
                return;
            foreach (DataRow dataRow1 in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                DataRow parentRow = dataRow1.GetParentRow("pollquestion_pollrelation");
                if (parentRow != null && parentRow["question"].ToString() != this.Question.Text)
                    parentRow["question"] = (object)this.Question.Text;
                foreach (DataRow dataRow2 in parentRow.GetChildRows("pollquestion_pollrelation"))
                {
                    if (dataRow2["name"].ToString() != parentRow["question"].ToString())
                        dataRow2["name"] = parentRow["question"];
                }
            }
        }

        private void textEditQuestionExplanation_EditValueChanged(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
                return;
            foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                DataRow parentRow = dataRow.GetParentRow("pollquestion_pollrelation");
                if (parentRow != null && parentRow["explanation"].ToString() != this.textEditQuestionExplanation.Text)
                    parentRow["explanation"] = (object)this.textEditQuestionExplanation.Text;
            }
        }

        private void pictureEditQuestionPicture_ImageChanged(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
                return;
            foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                DataRow parentRow = dataRow.GetParentRow("pollquestion_pollrelation");
                if (parentRow != null && this.pictureEditQuestionPicture.Image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    this.pictureEditQuestionPicture.Image.Save((Stream)memoryStream, ImageFormat.Bmp);
                    if (parentRow["picture"] == DBNull.Value || (byte[])parentRow["picture"] != memoryStream.ToArray())
                        parentRow["picture"] = (object)memoryStream.ToArray();
                }
            }
        }

        private void comboBoxTypeAnswer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
                return;
            foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                DataRow parentRow = dataRow.GetParentRow("pollquestion_pollrelation");
                if (parentRow != null)
                {
                    if (dataRow.GetChildRows("pollrelation_pollrelation").Length != 0 && this.comboBoxTypeAnswer.Text != TypeAnswer.Несколько_из.ToString() && this.comboBoxTypeAnswer.Text != TypeAnswer.Один_из.ToString())
                    {
                        this.comboBoxTypeAnswer.Text = parentRow["typeanswer"].ToString();
                        int num = (int)MessageBox.Show("Нельзя сменить тип вопроса, имеются подчиненные ответы!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (parentRow["typeanswer"].ToString() != this.comboBoxTypeAnswer.Text)
                        parentRow["typeanswer"] = (object)this.comboBoxTypeAnswer.Text;
                }
            }
        }

        private void memoEditQuestionQuery_TextChanged(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
                return;
            foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                DataRow parentRow = dataRow.GetParentRow("pollquestion_pollrelation");
                if (parentRow != null && parentRow["query"].ToString() != this.memoEditQuestionQuery.Text)
                    parentRow["query"] = (object)this.memoEditQuestionQuery.Text;
            }
        }

        private void checkEditQuestionObligatory_CheckedChanged(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
                return;
            foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                DataRow parentRow = dataRow.GetParentRow("pollquestion_pollrelation");
                if (parentRow != null && parentRow["obligatory"].ToString() != this.checkEditQuestionObligatory.Checked.ToString())
                    parentRow["obligatory"] = (object)(bool)(this.checkEditQuestionObligatory.Checked ? 1 : 0);
            }
        }

        private int GetGroupNumpos()
        {
            DataRow[] dataRowArray = this.ds_polledit.Tables["pollrelation"].Select("", "numpos");
            int num = 0;
            if (dataRowArray.Length > 0)
            {
                DataRow dataRow = dataRowArray[dataRowArray.Length - 1];
                if (!dbconn.IsValueDbNullOrNull(dataRow["numpos"]))
                    num = (int)dataRow["numpos"] + 1;
            }
            return num;
        }

        private void toolStripMenuItemRelationMoveUp_Click(object sender, EventArgs e)
        {
            if (this.treeListPollRelation.FocusedNode == null || this.treeListPollRelation.FocusedNode.PrevNode == null)
                return;
            DataRow row1 = ((DataRowView)this.treeListPollRelation.GetDataRecordByNode(this.treeListPollRelation.FocusedNode)).Row;
            DataRow row2 = ((DataRowView)this.treeListPollRelation.GetDataRecordByNode(this.treeListPollRelation.FocusedNode.PrevNode)).Row;
            if (Useful.GetInt32(row1["parentid"]) != Useful.GetInt32(row2["parentid"]) || row1 == null || row2 == null)
                return;
            int num1 = (int)row1["numpos"];
            int num2 = (int)row2["numpos"];
            row1["numpos"] = (object)num2;
            row2["numpos"] = (object)num1;
        }

        private void toolStripMenuItemRelationMoveDown_Click(object sender, EventArgs e)
        {
            if (this.treeListPollRelation.FocusedNode == null || this.treeListPollRelation.FocusedNode.NextNode == null)
                return;
            DataRow row1 = ((DataRowView)this.treeListPollRelation.GetDataRecordByNode(this.treeListPollRelation.FocusedNode)).Row;
            DataRow row2 = ((DataRowView)this.treeListPollRelation.GetDataRecordByNode(this.treeListPollRelation.FocusedNode.NextNode)).Row;
            if (Useful.GetInt32(row1["parentid"]) != Useful.GetInt32(row2["parentid"]))
                return;
            int num1 = (int)row1["numpos"];
            int num2 = (int)row2["numpos"];
            row1["numpos"] = (object)num2;
            row2["numpos"] = (object)num1;
        }

        private void toolStripMenuItemMove_Click(object sender, EventArgs e)
        {
            this.MoveGroup = AtTreeList.GetSelectedNode(this.treeListPollRelation);
            if (this.MoveGroup == null)
                return;
            this.Cursor = Cursors.Hand;
        }

        private void spinEditAnswerWeightAnswer_EditValueChanged(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
                return;
            foreach (DataRow dataRow in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                DataRow parentRow = dataRow.GetParentRow("pollanswer_pollrelation");
                if (parentRow != null && parentRow["weightanswer"].ToString() != this.spinEditAnswerWeightAnswer.Value.ToString())
                    parentRow["weightanswer"] = (object)this.spinEditAnswerWeightAnswer.Value;
            }
        }

        private void textEditAnswer_EditValueChanged(object sender, EventArgs e)
        {
            if (AtTreeList.GetSelectedNodes(this.treeListPollRelation) == null)
                return;
            foreach (DataRow dataRow1 in AtTreeList.GetSelectedNodes(this.treeListPollRelation))
            {
                DataRow parentRow = dataRow1.GetParentRow("pollanswer_pollrelation");
                if (parentRow != null)
                {
                    parentRow["answer"] = (object)this.textEditAnswer.Text;
                    foreach (DataRow dataRow2 in parentRow.GetChildRows("pollanswer_pollrelation"))
                    {
                        if (dataRow2["name"].ToString() != parentRow["answer"].ToString())
                            dataRow2["name"] = parentRow["answer"];
                    }
                }
            }
        }

        private bool CheckAdd(DataRow drPQ)
        {
            return drPQ["typeanswer"].ToString() == TypeAnswer.Один_из.ToString() || drPQ["typeanswer"].ToString() == TypeAnswer.Несколько_из.ToString();
        }

        private void toolStripMenuItemMakeRoot_Click(object sender, EventArgs e)
        {
            DataRow selectedNode = AtTreeList.GetSelectedNode(this.treeListPollRelation);
            if (selectedNode == null)
                return;
            if (selectedNode["idpollquestion"] != DBNull.Value)
            {
                selectedNode["parentid"] = (object)DBNull.Value;
            }
            else
            {
                int num = (int)MessageBox.Show("Ответ нельзя сделать корневым!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.LoadFromBase();
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PollEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db.quModifDataSet(this.ds_polledit) <= 0 || MessageBox.Show("Сохранить изменения?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            this.SaveToBase();
        }

        private void textEditHeadName_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxTypeAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
