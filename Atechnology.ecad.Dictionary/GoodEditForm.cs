// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.GoodEditForm
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.Components;
using Atechnology.DBConnections2;
using Atechnology.ecad;
using Atechnology.ecad.Calc;
using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Atechnology.ecad.Dictionary
{
    public class GoodEditForm : AtUserControl
    {
        private IContainer components;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private DataSet ds;
        private DataTable table_good;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private DataColumn dataColumn7;
        private DataColumn dataColumn8;
        private DataColumn dataColumn9;
        private DataColumn dataColumn10;
        private DataColumn dataColumn11;
        private DataColumn dataColumn12;
        private DataColumn dataColumn13;
        private DataColumn dataColumn14;
        private DataColumn dataColumn15;
        private DataColumn dataColumn17;
        private DataColumn dataColumn18;
        private DataColumn dataColumn19;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private CheckEdit checkEdit3;
        private DataColumn dataColumn1;
        private Label label5;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label6;
        private GridControl gridControl1;
        private GridView gridView1;
        private DataTable table_goodparam;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn16;
        private DataColumn dataColumn20;
        private DataColumn dataColumn21;
        private DataColumn dataColumn22;
        private GridColumn colname;
        private GridColumn colcomment;
        private GridColumn colintvalue;
        private GridColumn colstrvalue;
        private GridColumn colparamgroup;
        private DataColumn dataColumn23;
        private GridColumn colidparam;
        private DataColumn dataColumn24;
        private DataColumn dataColumn25;
        private ContextMenuStrip MenuItemParam;
        private ToolStripMenuItem MenuItemParamAdd;
        private ToolStripMenuItem MenuItemParamDoublicate;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemParamRemove;
        private Label label12;
        private ComboBoxEdit comboBoxEdit1;
        private DataTable table_measure;
        private DataColumn dataColumn26;
        private DataColumn dataColumn27;
        private DataColumn dataColumn28;
        private DataColumn dataColumn29;
        private DataColumn dataColumn30;
        private CalcEdit calcEditPrice1;
        private CalcEdit calcEditPrice2;
        private Label label13;
        private Label label14;
        private DataColumn dataColumn31;
        private DataColumn dataColumn32;
        private Label label15;
        private ComboBoxEdit cboSystem;
        private DataTable table_system;
        private DataColumn dataColumn33;
        private DataColumn dataColumn34;
        private Label label16;
        private CalcEdit calcEditWaste1;
        private DataColumn dataColumn35;
        private Label label17;
        private ComboBoxEdit cboValut1;
        private DataColumn dataColumn38;
        private DataColumn dataColumn39;
        private DataTable table_valut;
        private DataColumn dataColumn36;
        private DataColumn dataColumn37;
        private Label label18;
        private Label label19;
        private DataTable table_goodtype;
        private DataColumn dataColumn42;
        private DataColumn dataColumn43;
        private DataColumn dataColumn44;
        private DataColumn dataColumn45;
        private LookUpEdit lookUpEditGoodType1;
        private DataColumn dataColumn46;
        private DataColumn dataColumn47;
        private BindingSource bsGoodType;
        private DataColumn dataColumn48;
        private DataColumn dataColumn49;
        private Label label21;
        private ButtonEdit buttonEditPriceChangeGroup;
        private DataColumn dataColumn50;
        private Label label22;
        private CalcEdit calcEdit4;
        private DataColumn dataColumn51;
        private DataColumn dataColumn52;
        private DataTable table_goodoptim;
        private DataColumn dataColumn53;
        private DataColumn dataColumn54;
        private Label label23;
        private ButtonEdit buttonEditOptimGroup;
        private DataColumn dataColumn55;
        private DataColumn dataColumn56;
        private DataColumn dataColumn57;
        private DataColumn dataColumn58;
        private DataColumn dataColumn59;
        private DataColumn dataColumn60;
        private DataColumn dataColumn61;
        private Label label24;
        private DataColumn dataColumn62;
        private DataColumn dataColumn63;
        private DataColumn dataColumn64;
        private DataColumn dataColumn65;
        private DataColumn dataColumn66;
        private CalcEdit calcEdit5;
        private CalcEdit calcEditPrice3;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label26;
        private Label label27;
        private Label label25;
        private CalcEdit calcEditPrice5;
        private CalcEdit calcEditPrice4;
        private ComboBoxEdit cboValut5;
        private ComboBoxEdit cboValut4;
        private ComboBoxEdit cboValut3;
        private ComboBoxEdit cboValut2;
        private ImageList imageList1;
        private DataColumn dataColumn40;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private XtraTabPage xtraTabPage2;
        private XtraTabPage xtraTabPage3;
        private XtraTabPage xtraTabGoodPrice;
        private XtraTabPage xtraTabPage5;
        private GroupBox groupBox1;
        private LookUpEdit lookUpEditGoodType2;
        private Label label10;
        private DataColumn dataColumn41;
        private DataColumn dataColumn67;
        private DataColumn dataColumn68;
        private Label label20;
        private ButtonEdit buttonEditStoredepart;
        private CalcEdit calcEditHeight;
        private CalcEdit calcEditThickness;
        private CalcEdit calcEditThick;
        private CalcEdit calcEditWidth;
        private CalcEdit calcEditWeight;
        private DataColumn dataColumn69;
        private CalcEdit calcEditSqr;
        private Label label32;
        private atColorPopUpContainer1 atColor2;
        private atColorPopUpContainer1 atColor1;
        private DataColumn dataColumn70;
        private CalcEdit calcEditSqr2;
        private Label label33;
        private DataColumn dataColumn71;
        private DataColumn dataColumn72;
        private CalcEdit calcEditWaste5;
        private CalcEdit calcEditWaste4;
        private CalcEdit calcEditWaste3;
        private CalcEdit calcEditWaste2;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private DataColumn dataColumn73;
        private DataColumn dataColumn74;
        private DataColumn dataColumn75;
        private DataColumn dataColumn76;
        private DataColumn dataColumn77;
        private CheckEdit checkEdit1;
        private CheckEdit checkEdit2;
        private RepositoryItemButtonEdit refButtonEdit;
        private GridColumn idnameColumn;
        private DataColumn dataColumn78;
        private DataTable table_colorgroupcustom;
        private DataColumn dataColumn79;
        private DataColumn dataColumn80;
        private DataColumn dataColumn81;
        private DataColumn dataColumn82;
        private LookUpEdit lookUpEditColorGroup;
        private Label label38;
        private DataTable table_goodcolorgroupprice;
        private DataColumn dataColumn83;
        private DataColumn dataColumn84;
        private DataColumn dataColumn85;
        private DataColumn dataColumn86;
        private DataColumn dataColumn87;
        private DataColumn dataColumn88;
        private GridControl gridControl2;
        private GridView gridView2;
        private GridColumn colcolorgroupprice_name;
        private DataColumn dataColumn89;
        private DataColumn dataColumn90;
        private DataColumn dataColumn91;
        private DataColumn dataColumn92;
        private DataColumn dataColumn93;
        private GridColumn colprice;
        private GridColumn colk1;
        private GridColumn colk2;
        private GridColumn colprice_k1;
        private GridColumn colprice_k2;
        private DataColumn dataColumn94;
        private DataColumn dataColumn95;
        private RepositoryItemLookUpEdit repositoryItemLookUpEditValut;
        private GridColumn colidvalut;
        private Label label39;
        private LookUpEdit lookUpEdit1;
        private DataTable table_customer;
        private DataColumn dataColumn96;
        private DataColumn dataColumn97;
        private DataColumn dataColumn98;
        private DataColumn dataColumn99;
        public int idgood;
        public DataRow dr_from_good;
        private GoodBufferForm gbuffer;
        private PriceHistoryForm phist;

        public GoodEditForm(int _idgood)
        {
            this.InitializeComponent();
            this.idgood = _idgood;
            this.LoadFromBase();
            this.comboBoxEdit1.Validating += new CancelEventHandler(this.comboBoxEdit1_Validating);
            this.cboSystem.Validating += new CancelEventHandler(this.cboSystem_Validating);
            this.cboSystem.ButtonClick += new ButtonPressedEventHandler(this.cboSystem_ButtonClick);
            this.cboValut1.Validating += new CancelEventHandler(this.cboValut1_Validating);
            this.cboValut2.Validating += new CancelEventHandler(this.cboValut2_Validating);
            this.cboValut3.Validating += new CancelEventHandler(this.cboValut3_Validating);
            this.cboValut4.Validating += new CancelEventHandler(this.cboValut4_Validating);
            this.cboValut5.Validating += new CancelEventHandler(this.cboValut5_Validating);
            this.cboValut1.ButtonClick += new ButtonPressedEventHandler(this.cboValut1_ButtonClick);
            this.cboValut2.ButtonClick += new ButtonPressedEventHandler(this.cboValut2_ButtonClick);
            this.cboValut3.ButtonClick += new ButtonPressedEventHandler(this.cboValut3_ButtonClick);
            this.cboValut4.ButtonClick += new ButtonPressedEventHandler(this.cboValut4_ButtonClick);
            this.cboValut5.ButtonClick += new ButtonPressedEventHandler(this.cboValut5_ButtonClick);
            this.buttonEditPriceChangeGroup.ButtonClick += new ButtonPressedEventHandler(this.buttonEditPriceChangeGroup_ButtonClick);
            this.buttonEditOptimGroup.ButtonClick += new ButtonPressedEventHandler(this.buttonEditOptimGroup_ButtonClick);
            this.atColor1.EditValueChanging += new ChangingEventHandler(this.atColor1_EditValueChanging);
            this.atColor2.EditValueChanging += new ChangingEventHandler(this.atColor2_EditValueChanging);
            this.atColor1.ButtonClick += new ButtonPressedEventHandler(this.atColor1_ButtonClick);
            this.atColor2.ButtonClick += new ButtonPressedEventHandler(this.atColor2_ButtonClick);
            PriceHistoryForm f = new PriceHistoryForm(this.idgood, true);
            this.xtraTabGoodPrice.Controls.Add((Control)f);
            f.Dock = DockStyle.Fill;
            f.Show();
            this.AssignPriceHistoryEvents(f);
            GoodBufferForm goodBufferForm = new GoodBufferForm(this.idgood, true);
            this.xtraTabPage5.Controls.Add((Control)goodBufferForm);
            goodBufferForm.Dock = DockStyle.Fill;
            goodBufferForm.Is_Dialog = true;
            goodBufferForm.Show();
            this.gbuffer = goodBufferForm;
            this.phist = f;
            this.calcEditPrice1.ButtonClick += new ButtonPressedEventHandler(this.calcEditPrice1_ButtonClick);
            this.calcEditPrice2.ButtonClick += new ButtonPressedEventHandler(this.calcEditPrice2_ButtonClick);
            this.calcEditPrice3.ButtonClick += new ButtonPressedEventHandler(this.calcEditPrice3_ButtonClick);
            this.calcEditPrice4.ButtonClick += new ButtonPressedEventHandler(this.calcEditPrice4_ButtonClick);
            this.calcEditPrice5.ButtonClick += new ButtonPressedEventHandler(this.calcEditPrice5_ButtonClick);
            this.lookUpEditGoodType1.ButtonClick += new ButtonPressedEventHandler(this.lookUpEditGoodType1_ButtonClick);
            this.lookUpEditGoodType2.ButtonClick += new ButtonPressedEventHandler(this.lookUpEditGoodType2_ButtonClick);
            this.buttonEditStoredepart.ButtonClick += new ButtonPressedEventHandler(this.buttonEditStoredepart_ButtonClick);
            this.calcEditHeight.ButtonClick += new ButtonPressedEventHandler(this.calcEditHeight_ButtonClick);
            this.calcEditSqr.ButtonClick += new ButtonPressedEventHandler(this.calcEditSqr_ButtonClick);
            this.calcEditSqr2.ButtonClick += new ButtonPressedEventHandler(this.calcEditSqr2_ButtonClick);
            this.calcEditThick.ButtonClick += new ButtonPressedEventHandler(this.calcEditThick_ButtonClick);
            this.calcEditThickness.ButtonClick += new ButtonPressedEventHandler(this.calcEditThickness_ButtonClick);
            this.calcEditWeight.ButtonClick += new ButtonPressedEventHandler(this.calcEditWeight_ButtonClick);
            this.calcEditWidth.ButtonClick += new ButtonPressedEventHandler(this.calcEditWidth_ButtonClick);
            this.FormClosing += new FormClosing(this.GoodEditForm_FormClosing);
            this.xtraTabControl1.SelectedPageChanged += new TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            this.lookUpEditColorGroup.Properties.DataSource = (object)this.table_colorgroupcustom;
            this.lookUpEditColorGroup.Properties.DisplayMember = "name";
            this.lookUpEditColorGroup.Properties.ValueMember = "idcolorgroupcustom";
            this.lookUpEdit1.Properties.DataSource = (object)this.table_customer;
            this.lookUpEdit1.Properties.DisplayMember = "name";
            this.lookUpEdit1.Properties.ValueMember = "idcustomer";
            this.repositoryItemLookUpEditValut.DataSource = (object)this.table_valut;
            this.repositoryItemLookUpEditValut.DisplayMember = "shortname";
            this.repositoryItemLookUpEditValut.ValueMember = "idvalut";
            this.table_goodcolorgroupprice.ColumnChanged += new DataColumnChangeEventHandler(this.table_goodcolorgroupprice_ColumnChanged);
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
            StyleFormatCondition styleFormatCondition = new StyleFormatCondition();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GoodEditForm));
            this.idnameColumn = new GridColumn();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            this.ds = new DataSet();
            this.table_good = new DataTable();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn15 = new DataColumn();
            this.dataColumn17 = new DataColumn();
            this.dataColumn18 = new DataColumn();
            this.dataColumn19 = new DataColumn();
            this.dataColumn1 = new DataColumn();
            this.dataColumn24 = new DataColumn();
            this.dataColumn25 = new DataColumn();
            this.dataColumn29 = new DataColumn();
            this.dataColumn30 = new DataColumn();
            this.dataColumn31 = new DataColumn();
            this.dataColumn32 = new DataColumn();
            this.dataColumn35 = new DataColumn();
            this.dataColumn38 = new DataColumn();
            this.dataColumn39 = new DataColumn();
            this.dataColumn46 = new DataColumn();
            this.dataColumn47 = new DataColumn();
            this.dataColumn48 = new DataColumn();
            this.dataColumn49 = new DataColumn();
            this.dataColumn50 = new DataColumn();
            this.dataColumn51 = new DataColumn();
            this.dataColumn52 = new DataColumn();
            this.dataColumn55 = new DataColumn();
            this.dataColumn56 = new DataColumn();
            this.dataColumn57 = new DataColumn();
            this.dataColumn58 = new DataColumn();
            this.dataColumn59 = new DataColumn();
            this.dataColumn60 = new DataColumn();
            this.dataColumn61 = new DataColumn();
            this.dataColumn62 = new DataColumn();
            this.dataColumn63 = new DataColumn();
            this.dataColumn64 = new DataColumn();
            this.dataColumn65 = new DataColumn();
            this.dataColumn66 = new DataColumn();
            this.dataColumn40 = new DataColumn();
            this.dataColumn41 = new DataColumn();
            this.dataColumn67 = new DataColumn();
            this.dataColumn68 = new DataColumn();
            this.dataColumn69 = new DataColumn();
            this.dataColumn70 = new DataColumn();
            this.dataColumn71 = new DataColumn();
            this.dataColumn72 = new DataColumn();
            this.dataColumn73 = new DataColumn();
            this.dataColumn74 = new DataColumn();
            this.dataColumn75 = new DataColumn();
            this.dataColumn76 = new DataColumn();
            this.dataColumn77 = new DataColumn();
            this.dataColumn78 = new DataColumn();
            this.dataColumn99 = new DataColumn();
            this.table_goodparam = new DataTable();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn16 = new DataColumn();
            this.dataColumn20 = new DataColumn();
            this.dataColumn21 = new DataColumn();
            this.dataColumn22 = new DataColumn();
            this.dataColumn23 = new DataColumn();
            this.table_measure = new DataTable();
            this.dataColumn26 = new DataColumn();
            this.dataColumn27 = new DataColumn();
            this.dataColumn28 = new DataColumn();
            this.table_system = new DataTable();
            this.dataColumn33 = new DataColumn();
            this.dataColumn34 = new DataColumn();
            this.table_valut = new DataTable();
            this.dataColumn36 = new DataColumn();
            this.dataColumn37 = new DataColumn();
            this.table_goodtype = new DataTable();
            this.dataColumn42 = new DataColumn();
            this.dataColumn43 = new DataColumn();
            this.dataColumn44 = new DataColumn();
            this.dataColumn45 = new DataColumn();
            this.table_goodoptim = new DataTable();
            this.dataColumn53 = new DataColumn();
            this.dataColumn54 = new DataColumn();
            this.table_colorgroupcustom = new DataTable();
            this.dataColumn79 = new DataColumn();
            this.dataColumn80 = new DataColumn();
            this.dataColumn81 = new DataColumn();
            this.dataColumn82 = new DataColumn();
            this.table_goodcolorgroupprice = new DataTable();
            this.dataColumn83 = new DataColumn();
            this.dataColumn84 = new DataColumn();
            this.dataColumn85 = new DataColumn();
            this.dataColumn86 = new DataColumn();
            this.dataColumn87 = new DataColumn();
            this.dataColumn88 = new DataColumn();
            this.dataColumn89 = new DataColumn();
            this.dataColumn90 = new DataColumn();
            this.dataColumn91 = new DataColumn();
            this.dataColumn92 = new DataColumn();
            this.dataColumn93 = new DataColumn();
            this.dataColumn94 = new DataColumn();
            this.dataColumn95 = new DataColumn();
            this.table_customer = new DataTable();
            this.dataColumn96 = new DataColumn();
            this.dataColumn97 = new DataColumn();
            this.dataColumn98 = new DataColumn();
            this.textBox2 = new TextBox();
            this.label2 = new Label();
            this.textBox3 = new TextBox();
            this.label3 = new Label();
            this.textBox4 = new TextBox();
            this.label4 = new Label();
            this.checkEdit3 = new CheckEdit();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label11 = new Label();
            this.gridControl1 = new GridControl();
            this.MenuItemParam = new ContextMenuStrip(this.components);
            this.MenuItemParamAdd = new ToolStripMenuItem();
            this.MenuItemParamDoublicate = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.MenuItemParamRemove = new ToolStripMenuItem();
            this.gridView1 = new GridView();
            this.colname = new GridColumn();
            this.refButtonEdit = new RepositoryItemButtonEdit();
            this.colcomment = new GridColumn();
            this.colintvalue = new GridColumn();
            this.colstrvalue = new GridColumn();
            this.colparamgroup = new GridColumn();
            this.colidparam = new GridColumn();
            this.label12 = new Label();
            this.comboBoxEdit1 = new ComboBoxEdit();
            this.calcEditPrice1 = new CalcEdit();
            this.calcEditPrice2 = new CalcEdit();
            this.label13 = new Label();
            this.label14 = new Label();
            this.label15 = new Label();
            this.cboSystem = new ComboBoxEdit();
            this.label16 = new Label();
            this.calcEditWaste1 = new CalcEdit();
            this.label17 = new Label();
            this.cboValut1 = new ComboBoxEdit();
            this.label18 = new Label();
            this.label19 = new Label();
            this.lookUpEditGoodType1 = new LookUpEdit();
            this.bsGoodType = new BindingSource(this.components);
            this.label21 = new Label();
            this.buttonEditPriceChangeGroup = new ButtonEdit();
            this.label22 = new Label();
            this.calcEdit4 = new CalcEdit();
            this.label23 = new Label();
            this.buttonEditOptimGroup = new ButtonEdit();
            this.label24 = new Label();
            this.calcEdit5 = new CalcEdit();
            this.calcEditPrice3 = new CalcEdit();
            this.label31 = new Label();
            this.label30 = new Label();
            this.label29 = new Label();
            this.label28 = new Label();
            this.label26 = new Label();
            this.label27 = new Label();
            this.label25 = new Label();
            this.calcEditPrice5 = new CalcEdit();
            this.calcEditPrice4 = new CalcEdit();
            this.cboValut5 = new ComboBoxEdit();
            this.cboValut4 = new ComboBoxEdit();
            this.cboValut3 = new ComboBoxEdit();
            this.cboValut2 = new ComboBoxEdit();
            this.imageList1 = new ImageList(this.components);
            this.xtraTabControl1 = new XtraTabControl();
            this.xtraTabPage3 = new XtraTabPage();
            this.lookUpEdit1 = new LookUpEdit();
            this.checkEdit1 = new CheckEdit();
            this.atColor2 = new atColorPopUpContainer1();
            this.atColor1 = new atColorPopUpContainer1();
            this.calcEditSqr2 = new CalcEdit();
            this.calcEditSqr = new CalcEdit();
            this.calcEditWeight = new CalcEdit();
            this.calcEditThickness = new CalcEdit();
            this.calcEditThick = new CalcEdit();
            this.calcEditWidth = new CalcEdit();
            this.calcEditHeight = new CalcEdit();
            this.lookUpEditGoodType2 = new LookUpEdit();
            this.label20 = new Label();
            this.label10 = new Label();
            this.calcEditWaste5 = new CalcEdit();
            this.calcEditWaste4 = new CalcEdit();
            this.calcEditWaste3 = new CalcEdit();
            this.calcEditWaste2 = new CalcEdit();
            this.buttonEditStoredepart = new ButtonEdit();
            this.checkEdit2 = new CheckEdit();
            this.label37 = new Label();
            this.label36 = new Label();
            this.label35 = new Label();
            this.label34 = new Label();
            this.label39 = new Label();
            this.label33 = new Label();
            this.label32 = new Label();
            this.xtraTabPage1 = new XtraTabPage();
            this.gridControl2 = new GridControl();
            this.gridView2 = new GridView();
            this.colcolorgroupprice_name = new GridColumn();
            this.colprice = new GridColumn();
            this.colidvalut = new GridColumn();
            this.repositoryItemLookUpEditValut = new RepositoryItemLookUpEdit();
            this.colk1 = new GridColumn();
            this.colprice_k1 = new GridColumn();
            this.colk2 = new GridColumn();
            this.colprice_k2 = new GridColumn();
            this.lookUpEditColorGroup = new LookUpEdit();
            this.groupBox1 = new GroupBox();
            this.label38 = new Label();
            this.xtraTabPage2 = new XtraTabPage();
            this.xtraTabGoodPrice = new XtraTabPage();
            this.xtraTabPage5 = new XtraTabPage();
            this.panel1.SuspendLayout();
            this.ds.BeginInit();
            this.table_good.BeginInit();
            this.table_goodparam.BeginInit();
            this.table_measure.BeginInit();
            this.table_system.BeginInit();
            this.table_valut.BeginInit();
            this.table_goodtype.BeginInit();
            this.table_goodoptim.BeginInit();
            this.table_colorgroupcustom.BeginInit();
            this.table_goodcolorgroupprice.BeginInit();
            this.table_customer.BeginInit();
            this.checkEdit3.Properties.BeginInit();
            this.gridControl1.BeginInit();
            this.MenuItemParam.SuspendLayout();
            this.gridView1.BeginInit();
            this.refButtonEdit.BeginInit();
            this.comboBoxEdit1.Properties.BeginInit();
            this.calcEditPrice1.Properties.BeginInit();
            this.calcEditPrice2.Properties.BeginInit();
            this.cboSystem.Properties.BeginInit();
            this.calcEditWaste1.Properties.BeginInit();
            this.cboValut1.Properties.BeginInit();
            this.lookUpEditGoodType1.Properties.BeginInit();
            ((ISupportInitialize)this.bsGoodType).BeginInit();
            this.buttonEditPriceChangeGroup.Properties.BeginInit();
            this.calcEdit4.Properties.BeginInit();
            this.buttonEditOptimGroup.Properties.BeginInit();
            this.calcEdit5.Properties.BeginInit();
            this.calcEditPrice3.Properties.BeginInit();
            this.calcEditPrice5.Properties.BeginInit();
            this.calcEditPrice4.Properties.BeginInit();
            this.cboValut5.Properties.BeginInit();
            this.cboValut4.Properties.BeginInit();
            this.cboValut3.Properties.BeginInit();
            this.cboValut2.Properties.BeginInit();
            this.xtraTabControl1.BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.lookUpEdit1.Properties.BeginInit();
            this.checkEdit1.Properties.BeginInit();
            this.atColor2.BeginInit();
            this.atColor2.Properties.BeginInit();
            this.atColor1.BeginInit();
            this.atColor1.Properties.BeginInit();
            this.calcEditSqr2.Properties.BeginInit();
            this.calcEditSqr.Properties.BeginInit();
            this.calcEditWeight.Properties.BeginInit();
            this.calcEditThickness.Properties.BeginInit();
            this.calcEditThick.Properties.BeginInit();
            this.calcEditWidth.Properties.BeginInit();
            this.calcEditHeight.Properties.BeginInit();
            this.lookUpEditGoodType2.Properties.BeginInit();
            this.calcEditWaste5.Properties.BeginInit();
            this.calcEditWaste4.Properties.BeginInit();
            this.calcEditWaste3.Properties.BeginInit();
            this.calcEditWaste2.Properties.BeginInit();
            this.buttonEditStoredepart.Properties.BeginInit();
            this.checkEdit2.Properties.BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.gridControl2.BeginInit();
            this.gridView2.BeginInit();
            this.repositoryItemLookUpEditValut.BeginInit();
            this.lookUpEditColorGroup.Properties.BeginInit();
            this.groupBox1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            this.idnameColumn.Caption = "id Имени";
            this.idnameColumn.FieldName = "idname";
            this.idnameColumn.Name = "idnameColumn";
            this.idnameColumn.Visible = true;
            this.idnameColumn.VisibleIndex = 6;
            this.panel1.Controls.Add((Control)this.button3);
            this.panel1.Controls.Add((Control)this.button2);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(877, 33);
            this.panel1.TabIndex = 5;
            this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(790, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(709, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(628, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Артикул";
            this.textBox1.BorderStyle = BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new Binding("Text", (object)this.ds, "good.marking", true));
            this.textBox1.Location = new Point(68, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(162, 20);
            this.textBox1.TabIndex = 0;
            this.ds.DataSetName = "ds_good";
            this.ds.EnforceConstraints = false;
            this.ds.Tables.AddRange(new DataTable[10]
      {
        this.table_good,
        this.table_goodparam,
        this.table_measure,
        this.table_system,
        this.table_valut,
        this.table_goodtype,
        this.table_goodoptim,
        this.table_colorgroupcustom,
        this.table_goodcolorgroupprice,
        this.table_customer
      });
            this.table_good.Columns.AddRange(new DataColumn[58]
      {
        this.dataColumn5,
        this.dataColumn6,
        this.dataColumn7,
        this.dataColumn8,
        this.dataColumn9,
        this.dataColumn10,
        this.dataColumn11,
        this.dataColumn12,
        this.dataColumn13,
        this.dataColumn14,
        this.dataColumn15,
        this.dataColumn17,
        this.dataColumn18,
        this.dataColumn19,
        this.dataColumn1,
        this.dataColumn24,
        this.dataColumn25,
        this.dataColumn29,
        this.dataColumn30,
        this.dataColumn31,
        this.dataColumn32,
        this.dataColumn35,
        this.dataColumn38,
        this.dataColumn39,
        this.dataColumn46,
        this.dataColumn47,
        this.dataColumn48,
        this.dataColumn49,
        this.dataColumn50,
        this.dataColumn51,
        this.dataColumn52,
        this.dataColumn55,
        this.dataColumn56,
        this.dataColumn57,
        this.dataColumn58,
        this.dataColumn59,
        this.dataColumn60,
        this.dataColumn61,
        this.dataColumn62,
        this.dataColumn63,
        this.dataColumn64,
        this.dataColumn65,
        this.dataColumn66,
        this.dataColumn40,
        this.dataColumn41,
        this.dataColumn67,
        this.dataColumn68,
        this.dataColumn69,
        this.dataColumn70,
        this.dataColumn71,
        this.dataColumn72,
        this.dataColumn73,
        this.dataColumn74,
        this.dataColumn75,
        this.dataColumn76,
        this.dataColumn77,
        this.dataColumn78,
        this.dataColumn99
      });
            this.table_good.Constraints.AddRange(new Constraint[2]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgood"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("Constraint2", "colorgroupcustom", new string[1]
        {
          "idcolorgroupcustom"
        }, new string[1]
        {
          "idcolorgroupcustom"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_good.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn5
      };
            this.table_good.TableName = "good";
            this.dataColumn5.AllowDBNull = false;
            this.dataColumn5.ColumnName = "idgood";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "name";
            this.dataColumn7.ColumnName = "comment";
            this.dataColumn8.ColumnName = "idmeasure";
            this.dataColumn8.DataType = typeof(int);
            this.dataColumn9.ColumnName = "marking";
            this.dataColumn10.ColumnName = "typ";
            this.dataColumn10.DataType = typeof(bool);
            this.dataColumn11.ColumnName = "extmarking";
            this.dataColumn12.ColumnName = "height";
            this.dataColumn12.DataType = typeof(int);
            this.dataColumn13.ColumnName = "width";
            this.dataColumn13.DataType = typeof(int);
            this.dataColumn14.ColumnName = "thick";
            this.dataColumn14.DataType = typeof(int);
            this.dataColumn15.ColumnName = "weight";
            this.dataColumn15.DataType = typeof(double);
            this.dataColumn17.ColumnName = "idgoodgroup";
            this.dataColumn17.DataType = typeof(int);
            this.dataColumn18.ColumnName = "measure_shortname";
            this.dataColumn18.Prefix = "local";
            this.dataColumn19.ColumnName = "goodgroup_name";
            this.dataColumn19.Prefix = "local";
            this.dataColumn1.ColumnName = "usehouse";
            this.dataColumn1.DataType = typeof(bool);
            this.dataColumn24.ColumnName = "thickness";
            this.dataColumn24.DataType = typeof(int);
            this.dataColumn25.ColumnName = "ismy";
            this.dataColumn25.DataType = typeof(bool);
            this.dataColumn29.ColumnName = "price1";
            this.dataColumn29.DataType = typeof(double);
            this.dataColumn30.ColumnName = "price2";
            this.dataColumn30.DataType = typeof(double);
            this.dataColumn31.ColumnName = "idsystem";
            this.dataColumn31.DataType = typeof(int);
            this.dataColumn32.ColumnName = "system_name";
            this.dataColumn32.Prefix = "local";
            this.dataColumn35.ColumnName = "waste";
            this.dataColumn35.DataType = typeof(double);
            this.dataColumn38.ColumnName = "idvalut";
            this.dataColumn38.DataType = typeof(int);
            this.dataColumn39.ColumnName = "valut_shortname";
            this.dataColumn46.ColumnName = "idgoodtype";
            this.dataColumn46.DataType = typeof(int);
            this.dataColumn47.ColumnName = "goodtype_name";
            this.dataColumn48.ColumnName = "idgoodpricegroup";
            this.dataColumn48.DataType = typeof(int);
            this.dataColumn49.ColumnName = "goodpricegroup_name";
            this.dataColumn50.ColumnName = "minost";
            this.dataColumn50.DataType = typeof(double);
            this.dataColumn51.ColumnName = "idgoodoptim";
            this.dataColumn51.DataType = typeof(int);
            this.dataColumn52.ColumnName = "goodoptim_name";
            this.dataColumn55.ColumnName = "price3";
            this.dataColumn55.DataType = typeof(double);
            this.dataColumn56.ColumnName = "price4";
            this.dataColumn56.DataType = typeof(double);
            this.dataColumn57.ColumnName = "price5";
            this.dataColumn57.DataType = typeof(double);
            this.dataColumn58.Caption = "idvalut2";
            this.dataColumn58.ColumnName = "idvalut2";
            this.dataColumn58.DataType = typeof(int);
            this.dataColumn59.ColumnName = "idvalut3";
            this.dataColumn59.DataType = typeof(int);
            this.dataColumn60.ColumnName = "idvalut4";
            this.dataColumn60.DataType = typeof(int);
            this.dataColumn61.ColumnName = "idvalut5";
            this.dataColumn61.DataType = typeof(int);
            this.dataColumn62.ColumnName = "packing";
            this.dataColumn62.DataType = typeof(double);
            this.dataColumn63.ColumnName = "valut2_shortname";
            this.dataColumn64.ColumnName = "valut3_shortname";
            this.dataColumn65.ColumnName = "valut4_shortname";
            this.dataColumn66.ColumnName = "valut5_shortname";
            this.dataColumn40.ColumnName = "idgoodtype2";
            this.dataColumn40.DataType = typeof(int);
            this.dataColumn41.ColumnName = "goodtype_name2";
            this.dataColumn67.ColumnName = "idstoredepart";
            this.dataColumn67.DataType = typeof(int);
            this.dataColumn68.ColumnName = "storedepart_name";
            this.dataColumn69.ColumnName = "sqr";
            this.dataColumn69.DataType = typeof(double);
            this.dataColumn70.ColumnName = "sqr2";
            this.dataColumn70.DataType = typeof(double);
            this.dataColumn71.ColumnName = "color1_name";
            this.dataColumn72.ColumnName = "color2_name";
            this.dataColumn73.ColumnName = "waste2";
            this.dataColumn73.DataType = typeof(double);
            this.dataColumn74.ColumnName = "waste3";
            this.dataColumn74.DataType = typeof(double);
            this.dataColumn75.ColumnName = "waste4";
            this.dataColumn75.DataType = typeof(double);
            this.dataColumn76.ColumnName = "waste5";
            this.dataColumn76.DataType = typeof(double);
            this.dataColumn77.ColumnName = "showinnopaper";
            this.dataColumn77.DataType = typeof(bool);
            this.dataColumn78.ColumnName = "idcolorgroupcustom";
            this.dataColumn78.DataType = typeof(int);
            this.dataColumn99.ColumnName = "idcustomer";
            this.dataColumn99.DataType = typeof(int);
            this.table_goodparam.Columns.AddRange(new DataColumn[8]
      {
        this.dataColumn2,
        this.dataColumn3,
        this.dataColumn4,
        this.dataColumn16,
        this.dataColumn20,
        this.dataColumn21,
        this.dataColumn22,
        this.dataColumn23
      });
            this.table_goodparam.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodparam"
        }, 1 != 0)
      });
            this.table_goodparam.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn16
      };
            this.table_goodparam.TableName = "goodparam";
            this.dataColumn2.ColumnName = "name";
            this.dataColumn3.ColumnName = "comment";
            this.dataColumn4.ColumnName = "idgood";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn16.AllowDBNull = false;
            this.dataColumn16.ColumnName = "idgoodparam";
            this.dataColumn16.DataType = typeof(int);
            this.dataColumn20.ColumnName = "intvalue";
            this.dataColumn20.DataType = typeof(double);
            this.dataColumn21.ColumnName = "strvalue";
            this.dataColumn22.ColumnName = "paramgroup";
            this.dataColumn23.ColumnName = "idparam";
            this.dataColumn23.DataType = typeof(int);
            this.table_measure.Columns.AddRange(new DataColumn[3]
      {
        this.dataColumn26,
        this.dataColumn27,
        this.dataColumn28
      });
            this.table_measure.TableName = "measure";
            this.dataColumn26.ColumnName = "idmeasure";
            this.dataColumn26.DataType = typeof(int);
            this.dataColumn27.ColumnName = "name";
            this.dataColumn28.ColumnName = "shortname";
            this.table_system.Columns.AddRange(new DataColumn[2]
      {
        this.dataColumn33,
        this.dataColumn34
      });
            this.table_system.TableName = "system";
            this.dataColumn33.ColumnName = "idsystem";
            this.dataColumn33.DataType = typeof(int);
            this.dataColumn34.ColumnName = "name";
            this.table_valut.Columns.AddRange(new DataColumn[2]
      {
        this.dataColumn36,
        this.dataColumn37
      });
            this.table_valut.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idvalut"
        }, 0 != 0)
      });
            this.table_valut.TableName = "valut";
            this.dataColumn36.ColumnName = "idvalut";
            this.dataColumn36.DataType = typeof(int);
            this.dataColumn37.ColumnName = "shortname";
            this.table_goodtype.Columns.AddRange(new DataColumn[4]
      {
        this.dataColumn42,
        this.dataColumn43,
        this.dataColumn44,
        this.dataColumn45
      });
            this.table_goodtype.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodtype"
        }, 1 != 0)
      });
            this.table_goodtype.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn42
      };
            this.table_goodtype.TableName = "goodtype";
            this.dataColumn42.AllowDBNull = false;
            this.dataColumn42.ColumnName = "idgoodtype";
            this.dataColumn42.DataType = typeof(int);
            this.dataColumn43.ColumnName = "name";
            this.dataColumn44.ColumnName = "numpos";
            this.dataColumn44.DataType = typeof(int);
            this.dataColumn45.ColumnName = "comment";
            this.table_goodoptim.Columns.AddRange(new DataColumn[2]
      {
        this.dataColumn53,
        this.dataColumn54
      });
            this.table_goodoptim.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodoptim"
        }, 1 != 0)
      });
            this.table_goodoptim.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn53
      };
            this.table_goodoptim.TableName = "goodoptim";
            this.dataColumn53.AllowDBNull = false;
            this.dataColumn53.ColumnName = "idgoodoptim";
            this.dataColumn53.DataType = typeof(int);
            this.dataColumn54.ColumnName = "name";
            this.table_colorgroupcustom.Columns.AddRange(new DataColumn[4]
      {
        this.dataColumn79,
        this.dataColumn80,
        this.dataColumn81,
        this.dataColumn82
      });
            this.table_colorgroupcustom.Constraints.AddRange(new Constraint[1]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idcolorgroupcustom"
        }, 0 != 0)
      });
            this.table_colorgroupcustom.TableName = "colorgroupcustom";
            this.dataColumn79.ColumnName = "idcolorgroupcustom";
            this.dataColumn79.DataType = typeof(int);
            this.dataColumn80.ColumnName = "name";
            this.dataColumn80.MaxLength = 64;
            this.dataColumn81.ColumnName = "comment";
            this.dataColumn81.MaxLength = 256;
            this.dataColumn82.ColumnName = "deleted";
            this.dataColumn82.DataType = typeof(DateTime);
            this.table_goodcolorgroupprice.Columns.AddRange(new DataColumn[13]
      {
        this.dataColumn83,
        this.dataColumn84,
        this.dataColumn85,
        this.dataColumn86,
        this.dataColumn87,
        this.dataColumn88,
        this.dataColumn89,
        this.dataColumn90,
        this.dataColumn91,
        this.dataColumn92,
        this.dataColumn93,
        this.dataColumn94,
        this.dataColumn95
      });
            this.table_goodcolorgroupprice.Constraints.AddRange(new Constraint[3]
      {
        (Constraint) new UniqueConstraint("Constraint1", new string[1]
        {
          "idgoodcolorgroupprice"
        }, 1 != 0),
        (Constraint) new ForeignKeyConstraint("Constraint2", "good", new string[1]
        {
          "idgood"
        }, new string[1]
        {
          "idgood"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade),
        (Constraint) new ForeignKeyConstraint("Constraint3", "valut", new string[1]
        {
          "idvalut"
        }, new string[1]
        {
          "idvalut"
        }, AcceptRejectRule.None, Rule.Cascade, Rule.Cascade)
      });
            this.table_goodcolorgroupprice.PrimaryKey = new DataColumn[1]
      {
        this.dataColumn83
      };
            this.table_goodcolorgroupprice.TableName = "goodcolorgroupprice";
            this.dataColumn83.AllowDBNull = false;
            this.dataColumn83.ColumnName = "idgoodcolorgroupprice";
            this.dataColumn83.DataType = typeof(int);
            this.dataColumn84.AllowDBNull = false;
            this.dataColumn84.ColumnName = "idcolorgroupprice";
            this.dataColumn84.DataType = typeof(uint);
            this.dataColumn85.AllowDBNull = false;
            this.dataColumn85.ColumnName = "idgood";
            this.dataColumn85.DataType = typeof(int);
            this.dataColumn86.ColumnName = "deleted";
            this.dataColumn86.DataType = typeof(DateTime);
            this.dataColumn87.ColumnName = "colorgroupprice_name";
            this.dataColumn88.ColumnName = "good_marking";
            this.dataColumn89.ColumnName = "price";
            this.dataColumn89.DataType = typeof(Decimal);
            this.dataColumn90.ColumnName = "k1";
            this.dataColumn90.DataType = typeof(Decimal);
            this.dataColumn91.ColumnName = "k2";
            this.dataColumn91.DataType = typeof(Decimal);
            this.dataColumn92.ColumnName = "price_k1";
            this.dataColumn92.DataType = typeof(Decimal);
            this.dataColumn93.ColumnName = "price_k2";
            this.dataColumn93.DataType = typeof(Decimal);
            this.dataColumn94.AllowDBNull = false;
            this.dataColumn94.ColumnName = "idvalut";
            this.dataColumn94.DataType = typeof(int);
            this.dataColumn95.ColumnName = "valut_shortname";
            this.table_customer.Columns.AddRange(new DataColumn[3]
      {
        this.dataColumn96,
        this.dataColumn97,
        this.dataColumn98
      });
            this.table_customer.TableName = "customer";
            this.dataColumn96.ColumnName = "idcustomer";
            this.dataColumn96.DataType = typeof(int);
            this.dataColumn97.ColumnName = "name";
            this.dataColumn98.ColumnName = "name2";
            this.textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBox2.BorderStyle = BorderStyle.FixedSingle;
            this.textBox2.DataBindings.Add(new Binding("Text", (object)this.ds, "good.name", true));
            this.textBox2.Location = new Point(321, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(552, 20);
            this.textBox2.TabIndex = 1;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(236, 15);
            this.label2.Name = "label2";
            this.label2.Size = new Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Наименование";
            this.textBox3.BorderStyle = BorderStyle.FixedSingle;
            this.textBox3.DataBindings.Add(new Binding("Text", (object)this.ds, "good.extmarking", true));
            this.textBox3.Location = new Point(68, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(162, 20);
            this.textBox3.TabIndex = 2;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Внеш.код";
            this.textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBox4.BorderStyle = BorderStyle.FixedSingle;
            this.textBox4.DataBindings.Add(new Binding("Text", (object)this.ds, "good.comment", true));
            this.textBox4.Location = new Point(321, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(552, 20);
            this.textBox4.TabIndex = 3;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(236, 41);
            this.label4.Name = "label4";
            this.label4.Size = new Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Комментарий";
            this.checkEdit3.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.ismy", true));
            this.checkEdit3.Enabled = false;
            this.checkEdit3.Location = new Point(687, 40);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "Своё";
            this.checkEdit3.Size = new Size(53, 19);
            this.checkEdit3.TabIndex = 16;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(8, 43);
            this.label5.Name = "label5";
            this.label5.Size = new Size(26, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Тип";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(485, 17);
            this.label6.Name = "label6";
            this.label6.Size = new Size(45, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Высота";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(485, 43);
            this.label7.Name = "label7";
            this.label7.Size = new Size(46, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ширина";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(485, 122);
            this.label8.Name = "label8";
            this.label8.Size = new Size(26, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Вес";
            this.label9.AutoSize = true;
            this.label9.Location = new Point(485, 69);
            this.label9.Name = "label9";
            this.label9.Size = new Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Длина";
            this.label11.AutoSize = true;
            this.label11.Location = new Point(485, 95);
            this.label11.Name = "label11";
            this.label11.Size = new Size(53, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Толщина";
            this.gridControl1.ContextMenuStrip = this.MenuItemParam;
            this.gridControl1.DataMember = "goodparam";
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
        (RepositoryItem) this.refButtonEdit
      });
            this.gridControl1.Size = new Size(869, 378);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
            this.MenuItemParam.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.MenuItemParamAdd,
        (ToolStripItem) this.MenuItemParamDoublicate,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.MenuItemParamRemove
      });
            this.MenuItemParam.Name = "contextMenuStrip1";
            this.MenuItemParam.Size = new Size(220, 76);
            this.MenuItemParamAdd.Name = "MenuItemParamAdd";
            this.MenuItemParamAdd.ShortcutKeys = Keys.Insert | Keys.Control;
            this.MenuItemParamAdd.Size = new Size(219, 22);
            this.MenuItemParamAdd.Text = "Добавить";
            this.MenuItemParamAdd.Click += new EventHandler(this.toolStripMenuItem1_Click);
            this.MenuItemParamDoublicate.Name = "MenuItemParamDoublicate";
            this.MenuItemParamDoublicate.ShortcutKeys = Keys.Insert | Keys.Shift | Keys.Control;
            this.MenuItemParamDoublicate.Size = new Size(219, 22);
            this.MenuItemParamDoublicate.Text = "Дублировать";
            this.MenuItemParamDoublicate.Click += new EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(216, 6);
            this.MenuItemParamRemove.Name = "MenuItemParamRemove";
            this.MenuItemParamRemove.ShortcutKeys = Keys.Delete | Keys.Control;
            this.MenuItemParamRemove.Size = new Size(219, 22);
            this.MenuItemParamRemove.Text = "Удалить";
            this.MenuItemParamRemove.Click += new EventHandler(this.toolStripMenuItem3_Click);
            this.gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.GroupPanel.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.BorderColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView1.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.BorderColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView1.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.BorderStyle = BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new GridColumn[7]
      {
        this.colname,
        this.colcomment,
        this.colintvalue,
        this.colstrvalue,
        this.colparamgroup,
        this.colidparam,
        this.idnameColumn
      });
            styleFormatCondition.Appearance.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            styleFormatCondition.Appearance.Options.UseBackColor = true;
            styleFormatCondition.ApplyToRow = true;
            styleFormatCondition.Column = this.idnameColumn;
            styleFormatCondition.Condition = FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition.Value1 = (object)"0";
            this.gridView1.FormatConditions.AddRange(new StyleFormatCondition[1]
      {
        styleFormatCondition
      });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Панель группировки";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.CellValueChanged += new CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.colname.Caption = "Наименование";
            this.colname.ColumnEdit = (RepositoryItem)this.refButtonEdit;
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.refButtonEdit.AutoHeight = false;
            this.refButtonEdit.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
            this.refButtonEdit.Name = "refButtonEdit";
            this.refButtonEdit.ButtonClick += new ButtonPressedEventHandler(this.refButtonEdit_ButtonClick);
            this.colcomment.Caption = "Описание";
            this.colcomment.ColumnEdit = (RepositoryItem)this.refButtonEdit;
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 1;
            this.colintvalue.Caption = "Число";
            this.colintvalue.FieldName = "intvalue";
            this.colintvalue.Name = "colintvalue";
            this.colintvalue.Visible = true;
            this.colintvalue.VisibleIndex = 2;
            this.colstrvalue.Caption = "Строка";
            this.colstrvalue.FieldName = "strvalue";
            this.colstrvalue.Name = "colstrvalue";
            this.colstrvalue.Visible = true;
            this.colstrvalue.VisibleIndex = 3;
            this.colparamgroup.Caption = "Группа";
            this.colparamgroup.FieldName = "paramgroup";
            this.colparamgroup.Name = "colparamgroup";
            this.colparamgroup.Visible = true;
            this.colparamgroup.VisibleIndex = 4;
            this.colidparam.Caption = "Код";
            this.colidparam.FieldName = "idparam";
            this.colidparam.Name = "colidparam";
            this.colidparam.Visible = true;
            this.colidparam.VisibleIndex = 5;
            this.label12.AutoSize = true;
            this.label12.Location = new Point(294, 17);
            this.label12.Name = "label12";
            this.label12.Size = new Size(46, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Ед.изм.";
            this.comboBoxEdit1.Location = new Point(380, 14);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.BorderStyle = BorderStyles.Simple;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.comboBoxEdit1.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new Size(82, 20);
            this.comboBoxEdit1.TabIndex = 6;
            this.calcEditPrice1.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.price1", true));
            this.calcEditPrice1.Location = new Point(131, 18);
            this.calcEditPrice1.Name = "calcEditPrice1";
            this.calcEditPrice1.Properties.ActionButtonIndex = 1;
            this.calcEditPrice1.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditPrice1.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditPrice1.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditPrice1.Properties.DisplayFormat.FormatString = "n4";
            this.calcEditPrice1.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice1.Properties.EditFormat.FormatString = "n4";
            this.calcEditPrice1.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice1.Size = new Size(253, 20);
            this.calcEditPrice1.TabIndex = 0;
            this.calcEditPrice2.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.price2", true));
            this.calcEditPrice2.Location = new Point(131, 43);
            this.calcEditPrice2.Name = "calcEditPrice2";
            this.calcEditPrice2.Properties.ActionButtonIndex = 1;
            this.calcEditPrice2.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditPrice2.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditPrice2.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditPrice2.Properties.DisplayFormat.FormatString = "n4";
            this.calcEditPrice2.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice2.Properties.EditFormat.FormatString = "n4";
            this.calcEditPrice2.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice2.Size = new Size(253, 20);
            this.calcEditPrice2.TabIndex = 2;
            this.calcEditPrice2.EditValueChanged += new EventHandler(this.calcEditPrice2_EditValueChanged);
            this.label13.AutoSize = true;
            this.label13.Location = new Point(18, 25);
            this.label13.Name = "label13";
            this.label13.Size = new Size(42, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Цена 1";
            this.label14.AutoSize = true;
            this.label14.Location = new Point(18, 51);
            this.label14.Name = "label14";
            this.label14.Size = new Size(42, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Цена 2";
            this.label15.AutoSize = true;
            this.label15.Location = new Point(8, 17);
            this.label15.Name = "label15";
            this.label15.Size = new Size(51, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Система";
            this.cboSystem.Location = new Point(64, 14);
            this.cboSystem.Name = "cboSystem";
            this.cboSystem.Properties.ActionButtonIndex = 1;
            this.cboSystem.Properties.BorderStyle = BorderStyles.Simple;
            this.cboSystem.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboSystem.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboSystem.Size = new Size(205, 20);
            this.cboSystem.TabIndex = 0;
            this.label16.AutoSize = true;
            this.label16.Location = new Point(294, 69);
            this.label16.Name = "label16";
            this.label16.Size = new Size(61, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "% отхода 1";
            this.calcEditWaste1.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.waste", true));
            this.calcEditWaste1.Location = new Point(380, 66);
            this.calcEditWaste1.Name = "calcEditWaste1";
            this.calcEditWaste1.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste1.Size = new Size(82, 20);
            this.calcEditWaste1.TabIndex = 8;
            this.label17.AutoSize = true;
            this.label17.Location = new Point(430, 21);
            this.label17.Name = "label17";
            this.label17.Size = new Size(54, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Валюта 1";
            this.cboValut1.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.valut_shortname", true));
            this.cboValut1.Location = new Point(577, 18);
            this.cboValut1.Name = "cboValut1";
            this.cboValut1.Properties.ActionButtonIndex = 1;
            this.cboValut1.Properties.BorderStyle = BorderStyles.Simple;
            this.cboValut1.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut1.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboValut1.Size = new Size(212, 20);
            this.cboValut1.TabIndex = 1;
            this.label18.AutoSize = true;
            this.label18.Location = new Point(8, 120);
            this.label18.Name = "label18";
            this.label18.Size = new Size(41, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Цвет 1";
            this.label19.AutoSize = true;
            this.label19.Location = new Point(8, 146);
            this.label19.Name = "label19";
            this.label19.Size = new Size(41, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Цвет 2";
            this.lookUpEditGoodType1.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.idgoodtype", true));
            this.lookUpEditGoodType1.Location = new Point(64, 40);
            this.lookUpEditGoodType1.Name = "lookUpEditGoodType1";
            this.lookUpEditGoodType1.Properties.ActionButtonIndex = 1;
            this.lookUpEditGoodType1.Properties.BorderStyle = BorderStyles.Simple;
            this.lookUpEditGoodType1.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.lookUpEditGoodType1.Properties.Columns.AddRange(new LookUpColumnInfo[4]
      {
        new LookUpColumnInfo("idgoodtype", "idgoodtype", 73, FormatType.Numeric, "", false, HorzAlignment.Far, ColumnSortOrder.None),
        new LookUpColumnInfo("numpos", "№пп", 15, FormatType.Numeric, "", true, HorzAlignment.Far, ColumnSortOrder.None),
        new LookUpColumnInfo("name", "Наименование типа", 50, FormatType.None, "", true, HorzAlignment.Near),
        new LookUpColumnInfo("comment", "Описание", 40, FormatType.None, "", true, HorzAlignment.Near)
      });
            this.lookUpEditGoodType1.Properties.DataSource = (object)this.bsGoodType;
            this.lookUpEditGoodType1.Properties.DisplayMember = "name";
            this.lookUpEditGoodType1.Properties.ValueMember = "idgoodtype";
            this.lookUpEditGoodType1.Size = new Size(205, 20);
            this.lookUpEditGoodType1.TabIndex = 1;
            this.bsGoodType.DataMember = "goodtype";
            this.bsGoodType.DataSource = (object)this.ds;
            this.bsGoodType.CurrentChanged += new EventHandler(this.bsGoodType_CurrentChanged);
            this.label21.AutoSize = true;
            this.label21.Location = new Point(8, 17);
            this.label21.Name = "label21";
            this.label21.Size = new Size(85, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Гр. переоценки";
            this.buttonEditPriceChangeGroup.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.goodpricegroup_name", true));
            this.buttonEditPriceChangeGroup.Location = new Point(142, 14);
            this.buttonEditPriceChangeGroup.Name = "buttonEditPriceChangeGroup";
            this.buttonEditPriceChangeGroup.Properties.BorderStyle = BorderStyles.Simple;
            this.buttonEditPriceChangeGroup.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton()
      });
            this.buttonEditPriceChangeGroup.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.buttonEditPriceChangeGroup.Size = new Size(394, 20);
            this.buttonEditPriceChangeGroup.TabIndex = 0;
            this.label22.AutoSize = true;
            this.label22.Location = new Point(294, 43);
            this.label22.Name = "label22";
            this.label22.Size = new Size(51, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "Мин.ост.";
            this.calcEdit4.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.minost", true));
            this.calcEdit4.Location = new Point(380, 40);
            this.calcEdit4.Name = "calcEdit4";
            this.calcEdit4.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEdit4.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEdit4.Size = new Size(82, 20);
            this.calcEdit4.TabIndex = 7;
            this.label23.AutoSize = true;
            this.label23.Location = new Point(8, 198);
            this.label23.Name = "label23";
            this.label23.Size = new Size(38, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "Склад";
            this.buttonEditOptimGroup.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.goodoptim_name", true));
            this.buttonEditOptimGroup.Location = new Point(64, 92);
            this.buttonEditOptimGroup.Name = "buttonEditOptimGroup";
            this.buttonEditOptimGroup.Properties.BorderStyle = BorderStyles.Simple;
            this.buttonEditOptimGroup.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton()
      });
            this.buttonEditOptimGroup.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.buttonEditOptimGroup.Size = new Size(205, 20);
            this.buttonEditOptimGroup.TabIndex = 3;
            this.label24.AutoSize = true;
            this.label24.Location = new Point(294, 198);
            this.label24.Name = "label24";
            this.label24.Size = new Size(70, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Норма упак.";
            this.calcEdit5.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.packing", true));
            this.calcEdit5.Location = new Point(380, 195);
            this.calcEdit5.Name = "calcEdit5";
            this.calcEdit5.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEdit5.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEdit5.Size = new Size(82, 20);
            this.calcEdit5.TabIndex = 9;
            this.calcEditPrice3.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.price3", true));
            this.calcEditPrice3.Location = new Point(131, 69);
            this.calcEditPrice3.Name = "calcEditPrice3";
            this.calcEditPrice3.Properties.ActionButtonIndex = 1;
            this.calcEditPrice3.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditPrice3.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditPrice3.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditPrice3.Properties.DisplayFormat.FormatString = "n4";
            this.calcEditPrice3.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice3.Properties.EditFormat.FormatString = "n4";
            this.calcEditPrice3.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice3.Size = new Size(253, 20);
            this.calcEditPrice3.TabIndex = 4;
            this.label31.AutoSize = true;
            this.label31.Location = new Point(430, 123);
            this.label31.Name = "label31";
            this.label31.Size = new Size(54, 13);
            this.label31.TabIndex = 23;
            this.label31.Text = "Валюта 5";
            this.label30.AutoSize = true;
            this.label30.Location = new Point(430, 98);
            this.label30.Name = "label30";
            this.label30.Size = new Size(54, 13);
            this.label30.TabIndex = 23;
            this.label30.Text = "Валюта 4";
            this.label29.AutoSize = true;
            this.label29.Location = new Point(430, 72);
            this.label29.Name = "label29";
            this.label29.Size = new Size(54, 13);
            this.label29.TabIndex = 23;
            this.label29.Text = "Валюта 3";
            this.label28.AutoSize = true;
            this.label28.Location = new Point(430, 47);
            this.label28.Name = "label28";
            this.label28.Size = new Size(54, 13);
            this.label28.TabIndex = 23;
            this.label28.Text = "Валюта 2";
            this.label26.AutoSize = true;
            this.label26.Location = new Point(18, 76);
            this.label26.Name = "label26";
            this.label26.Size = new Size(42, 13);
            this.label26.TabIndex = 23;
            this.label26.Text = "Цена 3";
            this.label27.AutoSize = true;
            this.label27.Location = new Point(18, 128);
            this.label27.Name = "label27";
            this.label27.Size = new Size(42, 13);
            this.label27.TabIndex = 23;
            this.label27.Text = "Цена 5";
            this.label25.AutoSize = true;
            this.label25.Location = new Point(18, 102);
            this.label25.Name = "label25";
            this.label25.Size = new Size(42, 13);
            this.label25.TabIndex = 23;
            this.label25.Text = "Цена 4";
            this.calcEditPrice5.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.price5", true));
            this.calcEditPrice5.Location = new Point(131, 120);
            this.calcEditPrice5.Name = "calcEditPrice5";
            this.calcEditPrice5.Properties.ActionButtonIndex = 1;
            this.calcEditPrice5.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditPrice5.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditPrice5.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditPrice5.Properties.DisplayFormat.FormatString = "n4";
            this.calcEditPrice5.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice5.Properties.EditFormat.FormatString = "n4";
            this.calcEditPrice5.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice5.Size = new Size(253, 20);
            this.calcEditPrice5.TabIndex = 8;
            this.calcEditPrice4.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.price4", true));
            this.calcEditPrice4.Location = new Point(131, 94);
            this.calcEditPrice4.Name = "calcEditPrice4";
            this.calcEditPrice4.Properties.ActionButtonIndex = 1;
            this.calcEditPrice4.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditPrice4.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditPrice4.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditPrice4.Properties.DisplayFormat.FormatString = "n4";
            this.calcEditPrice4.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice4.Properties.EditFormat.FormatString = "n4";
            this.calcEditPrice4.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.calcEditPrice4.Size = new Size(253, 20);
            this.calcEditPrice4.TabIndex = 6;
            this.cboValut5.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.valut5_shortname", true));
            this.cboValut5.Location = new Point(577, 120);
            this.cboValut5.Name = "cboValut5";
            this.cboValut5.Properties.ActionButtonIndex = 1;
            this.cboValut5.Properties.BorderStyle = BorderStyles.Simple;
            this.cboValut5.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut5.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboValut5.Size = new Size(212, 20);
            this.cboValut5.TabIndex = 9;
            this.cboValut4.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.valut4_shortname", true));
            this.cboValut4.Location = new Point(577, 95);
            this.cboValut4.Name = "cboValut4";
            this.cboValut4.Properties.ActionButtonIndex = 1;
            this.cboValut4.Properties.BorderStyle = BorderStyles.Simple;
            this.cboValut4.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut4.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboValut4.Size = new Size(212, 20);
            this.cboValut4.TabIndex = 7;
            this.cboValut3.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.valut3_shortname", true));
            this.cboValut3.Location = new Point(577, 69);
            this.cboValut3.Name = "cboValut3";
            this.cboValut3.Properties.ActionButtonIndex = 1;
            this.cboValut3.Properties.BorderStyle = BorderStyles.Simple;
            this.cboValut3.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut3.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboValut3.Size = new Size(212, 20);
            this.cboValut3.TabIndex = 5;
            this.cboValut2.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.valut2_shortname", true));
            this.cboValut2.Location = new Point(577, 44);
            this.cboValut2.Name = "cboValut2";
            this.cboValut2.Properties.ActionButtonIndex = 1;
            this.cboValut2.Properties.BorderStyle = BorderStyles.Simple;
            this.cboValut2.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.cboValut2.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboValut2.Size = new Size(212, 20);
            this.cboValut2.TabIndex = 3;
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "ChooseColor.bmp");
            this.xtraTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.xtraTabControl1.BorderStyle = BorderStyles.Simple;
            this.xtraTabControl1.Location = new Point(3, 74);
            this.xtraTabControl1.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl1.Size = new Size(871, 402);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new XtraTabPage[5]
      {
        this.xtraTabPage3,
        this.xtraTabPage1,
        this.xtraTabPage2,
        this.xtraTabGoodPrice,
        this.xtraTabPage5
      });
            this.xtraTabPage3.Controls.Add((Control)this.lookUpEdit1);
            this.xtraTabPage3.Controls.Add((Control)this.checkEdit1);
            this.xtraTabPage3.Controls.Add((Control)this.atColor2);
            this.xtraTabPage3.Controls.Add((Control)this.atColor1);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditSqr2);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditSqr);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditWeight);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditThickness);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditThick);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditWidth);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditHeight);
            this.xtraTabPage3.Controls.Add((Control)this.label15);
            this.xtraTabPage3.Controls.Add((Control)this.label19);
            this.xtraTabPage3.Controls.Add((Control)this.lookUpEditGoodType2);
            this.xtraTabPage3.Controls.Add((Control)this.lookUpEditGoodType1);
            this.xtraTabPage3.Controls.Add((Control)this.label12);
            this.xtraTabPage3.Controls.Add((Control)this.cboSystem);
            this.xtraTabPage3.Controls.Add((Control)this.label18);
            this.xtraTabPage3.Controls.Add((Control)this.label20);
            this.xtraTabPage3.Controls.Add((Control)this.label10);
            this.xtraTabPage3.Controls.Add((Control)this.label5);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditWaste5);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditWaste4);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditWaste3);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditWaste2);
            this.xtraTabPage3.Controls.Add((Control)this.calcEditWaste1);
            this.xtraTabPage3.Controls.Add((Control)this.buttonEditStoredepart);
            this.xtraTabPage3.Controls.Add((Control)this.buttonEditOptimGroup);
            this.xtraTabPage3.Controls.Add((Control)this.checkEdit2);
            this.xtraTabPage3.Controls.Add((Control)this.label23);
            this.xtraTabPage3.Controls.Add((Control)this.checkEdit3);
            this.xtraTabPage3.Controls.Add((Control)this.comboBoxEdit1);
            this.xtraTabPage3.Controls.Add((Control)this.label11);
            this.xtraTabPage3.Controls.Add((Control)this.label37);
            this.xtraTabPage3.Controls.Add((Control)this.label22);
            this.xtraTabPage3.Controls.Add((Control)this.label36);
            this.xtraTabPage3.Controls.Add((Control)this.label24);
            this.xtraTabPage3.Controls.Add((Control)this.label35);
            this.xtraTabPage3.Controls.Add((Control)this.label6);
            this.xtraTabPage3.Controls.Add((Control)this.label34);
            this.xtraTabPage3.Controls.Add((Control)this.label39);
            this.xtraTabPage3.Controls.Add((Control)this.label33);
            this.xtraTabPage3.Controls.Add((Control)this.label16);
            this.xtraTabPage3.Controls.Add((Control)this.label32);
            this.xtraTabPage3.Controls.Add((Control)this.label7);
            this.xtraTabPage3.Controls.Add((Control)this.label8);
            this.xtraTabPage3.Controls.Add((Control)this.calcEdit4);
            this.xtraTabPage3.Controls.Add((Control)this.label9);
            this.xtraTabPage3.Controls.Add((Control)this.calcEdit5);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new Size(869, 378);
            this.xtraTabPage3.Text = "Базовые свойства";
            this.lookUpEdit1.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.idcustomer", true));
            this.lookUpEdit1.Location = new Point(564, 195);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.ActionButtonIndex = 1;
            this.lookUpEdit1.Properties.BorderStyle = BorderStyles.Simple;
            this.lookUpEdit1.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.lookUpEdit1.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("idcustomer", "#", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None),
        new LookUpColumnInfo("name", "Наименование", 100),
        new LookUpColumnInfo("name2", "Наименование2", 100)
      });
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Size = new Size(190, 20);
            this.lookUpEdit1.TabIndex = 29;
            this.lookUpEdit1.ButtonClick += new ButtonPressedEventHandler(this.lookUpEdit1_ButtonClick);
            this.checkEdit1.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.showinnopaper", true));
            this.checkEdit1.Location = new Point(687, 66);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "На фурнитурный стол";
            this.checkEdit1.Properties.NullStyle = StyleIndeterminate.Unchecked;
            this.checkEdit1.Size = new Size(144, 19);
            this.checkEdit1.TabIndex = 27;
            this.atColor2.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.color2_name", true));
            this.atColor2.EditValue = (object)"";
            this.atColor2.IdColor = (object)null;
            this.atColor2.Location = new Point(64, 143);
            this.atColor2.Name = "atColor2";
            this.atColor2.NewColorFullName = (string)null;
            this.atColor2.NewColorGroupName = (string)null;
            this.atColor2.NewColorName = (string)null;
            this.atColor2.NewShowColorFormatString = "{0}\\{1}";
            this.atColor2.Properties.ActionButtonIndex = 1;
            this.atColor2.Properties.BorderStyle = BorderStyles.Simple;
            this.atColor2.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.atColor2.ShowColorMode = atColorPopUpContainer1.ShowColorModeType.GroupAndColor;
            this.atColor2.Size = new Size(205, 20);
            this.atColor2.TabIndex = 5;
            this.atColor1.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.color1_name", true));
            this.atColor1.EditValue = (object)"";
            this.atColor1.IdColor = (object)null;
            this.atColor1.Location = new Point(64, 117);
            this.atColor1.Name = "atColor1";
            this.atColor1.NewColorFullName = (string)null;
            this.atColor1.NewColorGroupName = (string)null;
            this.atColor1.NewColorName = (string)null;
            this.atColor1.NewShowColorFormatString = "{0}\\{1}";
            this.atColor1.Properties.ActionButtonIndex = 1;
            this.atColor1.Properties.BorderStyle = BorderStyles.Simple;
            this.atColor1.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.atColor1.ShowColorMode = atColorPopUpContainer1.ShowColorModeType.GroupAndColor;
            this.atColor1.Size = new Size(205, 20);
            this.atColor1.TabIndex = 4;
            this.calcEditSqr2.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.sqr2", true));
            this.calcEditSqr2.Location = new Point(564, 169);
            this.calcEditSqr2.Name = "calcEditSqr2";
            this.calcEditSqr2.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditSqr2.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditSqr2.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Combo, "", -1, true, false, false, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Minus)
      });
            this.calcEditSqr2.Properties.DisplayFormat.FormatString = "N3";
            this.calcEditSqr2.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditSqr2.Properties.Mask.EditMask = "N3";
            this.calcEditSqr2.Size = new Size(95, 20);
            this.calcEditSqr2.TabIndex = 15;
            this.calcEditSqr.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.sqr", true));
            this.calcEditSqr.Location = new Point(564, 143);
            this.calcEditSqr.Name = "calcEditSqr";
            this.calcEditSqr.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditSqr.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditSqr.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Combo, "", -1, true, false, false, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Minus)
      });
            this.calcEditSqr.Properties.DisplayFormat.FormatString = "N3";
            this.calcEditSqr.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditSqr.Properties.Mask.EditMask = "N3";
            this.calcEditSqr.Size = new Size(95, 20);
            this.calcEditSqr.TabIndex = 15;
            this.calcEditWeight.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.weight", true));
            this.calcEditWeight.Location = new Point(564, 117);
            this.calcEditWeight.Name = "calcEditWeight";
            this.calcEditWeight.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditWeight.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWeight.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Combo, "", -1, true, false, false, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Minus)
      });
            this.calcEditWeight.Properties.DisplayFormat.FormatString = "N3";
            this.calcEditWeight.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditWeight.Properties.Mask.EditMask = "N3";
            this.calcEditWeight.Size = new Size(95, 20);
            this.calcEditWeight.TabIndex = 14;
            this.calcEditThickness.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.thickness", true));
            this.calcEditThickness.Location = new Point(564, 91);
            this.calcEditThickness.Name = "calcEditThickness";
            this.calcEditThickness.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditThickness.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditThickness.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Combo, "", -1, true, false, false, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Minus)
      });
            this.calcEditThickness.Properties.DisplayFormat.FormatString = "N0";
            this.calcEditThickness.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditThickness.Properties.Mask.EditMask = "N0";
            this.calcEditThickness.Size = new Size(95, 20);
            this.calcEditThickness.TabIndex = 13;
            this.calcEditThick.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.thick", true));
            this.calcEditThick.Location = new Point(564, 66);
            this.calcEditThick.Name = "calcEditThick";
            this.calcEditThick.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditThick.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditThick.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Combo, "", -1, true, false, false, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Minus)
      });
            this.calcEditThick.Properties.DisplayFormat.FormatString = "N0";
            this.calcEditThick.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditThick.Properties.Mask.EditMask = "N0";
            this.calcEditThick.Size = new Size(95, 20);
            this.calcEditThick.TabIndex = 12;
            this.calcEditWidth.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.width", true));
            this.calcEditWidth.Location = new Point(564, 40);
            this.calcEditWidth.Name = "calcEditWidth";
            this.calcEditWidth.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditWidth.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWidth.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Combo, "", -1, true, false, false, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Minus)
      });
            this.calcEditWidth.Properties.DisplayFormat.FormatString = "N0";
            this.calcEditWidth.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditWidth.Properties.Mask.EditMask = "N0";
            this.calcEditWidth.Size = new Size(95, 20);
            this.calcEditWidth.TabIndex = 11;
            this.calcEditHeight.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.height", true));
            this.calcEditHeight.Location = new Point(564, 14);
            this.calcEditHeight.Name = "calcEditHeight";
            this.calcEditHeight.Properties.AllowNullInput = DefaultBoolean.True;
            this.calcEditHeight.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditHeight.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Combo, "", -1, true, false, false, ImageLocation.MiddleCenter, (Image) null),
        new EditorButton(ButtonPredefines.Minus)
      });
            this.calcEditHeight.Properties.DisplayFormat.FormatString = "N0";
            this.calcEditHeight.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.calcEditHeight.Properties.Mask.EditMask = "N0";
            this.calcEditHeight.Size = new Size(95, 20);
            this.calcEditHeight.TabIndex = 10;
            this.lookUpEditGoodType2.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.idgoodtype2", true));
            this.lookUpEditGoodType2.Location = new Point(64, 66);
            this.lookUpEditGoodType2.Name = "lookUpEditGoodType2";
            this.lookUpEditGoodType2.Properties.ActionButtonIndex = 1;
            this.lookUpEditGoodType2.Properties.BorderStyle = BorderStyles.Simple;
            this.lookUpEditGoodType2.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.lookUpEditGoodType2.Properties.Columns.AddRange(new LookUpColumnInfo[4]
      {
        new LookUpColumnInfo("idgoodtype", "idgoodtype", 73, FormatType.Numeric, "", false, HorzAlignment.Far, ColumnSortOrder.None),
        new LookUpColumnInfo("numpos", "№пп", 15, FormatType.Numeric, "", true, HorzAlignment.Far, ColumnSortOrder.None),
        new LookUpColumnInfo("name", "Наименование типа", 50, FormatType.None, "", true, HorzAlignment.Near),
        new LookUpColumnInfo("comment", "Описание", 40, FormatType.None, "", true, HorzAlignment.Near)
      });
            this.lookUpEditGoodType2.Properties.DataSource = (object)this.bsGoodType;
            this.lookUpEditGoodType2.Properties.DisplayMember = "name";
            this.lookUpEditGoodType2.Properties.ValueMember = "idgoodtype";
            this.lookUpEditGoodType2.Size = new Size(205, 20);
            this.lookUpEditGoodType2.TabIndex = 2;
            this.label20.AutoSize = true;
            this.label20.Location = new Point(8, 94);
            this.label20.Name = "label20";
            this.label20.Size = new Size(42, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Гр.опт.";
            this.label10.AutoSize = true;
            this.label10.Location = new Point(8, 69);
            this.label10.Name = "label10";
            this.label10.Size = new Size(41, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Тип 2й";
            this.calcEditWaste5.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.waste5", true));
            this.calcEditWaste5.Location = new Point(380, 169);
            this.calcEditWaste5.Name = "calcEditWaste5";
            this.calcEditWaste5.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste5.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste5.Size = new Size(82, 20);
            this.calcEditWaste5.TabIndex = 8;
            this.calcEditWaste4.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.waste4", true));
            this.calcEditWaste4.Location = new Point(380, 143);
            this.calcEditWaste4.Name = "calcEditWaste4";
            this.calcEditWaste4.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste4.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste4.Size = new Size(82, 20);
            this.calcEditWaste4.TabIndex = 8;
            this.calcEditWaste3.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.waste3", true));
            this.calcEditWaste3.Location = new Point(380, 119);
            this.calcEditWaste3.Name = "calcEditWaste3";
            this.calcEditWaste3.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste3.Size = new Size(82, 20);
            this.calcEditWaste3.TabIndex = 8;
            this.calcEditWaste2.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.waste2", true));
            this.calcEditWaste2.Location = new Point(380, 92);
            this.calcEditWaste2.Name = "calcEditWaste2";
            this.calcEditWaste2.Properties.BorderStyle = BorderStyles.Simple;
            this.calcEditWaste2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.calcEditWaste2.Size = new Size(82, 20);
            this.calcEditWaste2.TabIndex = 8;
            this.buttonEditStoredepart.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.storedepart_name", true));
            this.buttonEditStoredepart.Location = new Point(64, 195);
            this.buttonEditStoredepart.Name = "buttonEditStoredepart";
            this.buttonEditStoredepart.Properties.BorderStyle = BorderStyles.Simple;
            this.buttonEditStoredepart.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton()
      });
            this.buttonEditStoredepart.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.buttonEditStoredepart.Size = new Size(205, 20);
            this.buttonEditStoredepart.TabIndex = 16;
            this.checkEdit2.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.usehouse", true));
            this.checkEdit2.Location = new Point(687, 14);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Склад";
            this.checkEdit2.Size = new Size(54, 19);
            this.checkEdit2.TabIndex = 15;
            this.label37.AutoSize = true;
            this.label37.Location = new Point(294, 172);
            this.label37.Name = "label37";
            this.label37.Size = new Size(61, 13);
            this.label37.TabIndex = 23;
            this.label37.Text = "% отхода 5";
            this.label36.AutoSize = true;
            this.label36.Location = new Point(294, 146);
            this.label36.Name = "label36";
            this.label36.Size = new Size(61, 13);
            this.label36.TabIndex = 23;
            this.label36.Text = "% отхода 4";
            this.label35.AutoSize = true;
            this.label35.Location = new Point(294, 122);
            this.label35.Name = "label35";
            this.label35.Size = new Size(61, 13);
            this.label35.TabIndex = 23;
            this.label35.Text = "% отхода 3";
            this.label34.AutoSize = true;
            this.label34.Location = new Point(294, 95);
            this.label34.Name = "label34";
            this.label34.Size = new Size(61, 13);
            this.label34.TabIndex = 23;
            this.label34.Text = "% отхода 2";
            this.label39.AutoSize = true;
            this.label39.Location = new Point(485, 198);
            this.label39.Name = "label39";
            this.label39.Size = new Size(65, 13);
            this.label39.TabIndex = 23;
            this.label39.Text = "Поставщик";
            this.label33.AutoSize = true;
            this.label33.Location = new Point(484, 172);
            this.label33.Name = "label33";
            this.label33.Size = new Size(63, 13);
            this.label33.TabIndex = 23;
            this.label33.Text = "Площадь 2";
            this.label32.AutoSize = true;
            this.label32.Location = new Point(484, 146);
            this.label32.Name = "label32";
            this.label32.Size = new Size(54, 13);
            this.label32.TabIndex = 23;
            this.label32.Text = "Площадь";
            this.xtraTabPage1.Controls.Add((Control)this.gridControl2);
            this.xtraTabPage1.Controls.Add((Control)this.lookUpEditColorGroup);
            this.xtraTabPage1.Controls.Add((Control)this.groupBox1);
            this.xtraTabPage1.Controls.Add((Control)this.label38);
            this.xtraTabPage1.Controls.Add((Control)this.label21);
            this.xtraTabPage1.Controls.Add((Control)this.buttonEditPriceChangeGroup);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new Size(869, 378);
            this.xtraTabPage1.Text = "Ценообразование";
            this.gridControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.gridControl2.DataMember = "goodcolorgroupprice";
            this.gridControl2.DataSource = (object)this.ds;
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new Point(11, 233);
            this.gridControl2.LookAndFeel.Style = LookAndFeelStyle.Flat;
            this.gridControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl2.MainView = (BaseView)this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemLookUpEditValut
      });
            this.gridControl2.Size = new Size(850, 141);
            this.gridControl2.TabIndex = 26;
            this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
            this.gridView2.Appearance.FocusedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.FocusedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.FocusedRow.ForeColor = Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.HideSelectionRow.BackColor2 = Color.FromArgb(192, 192, (int)byte.MaxValue);
            this.gridView2.Appearance.HideSelectionRow.ForeColor = Color.Black;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.SelectedRow.BackColor2 = Color.FromArgb(128, 128, (int)byte.MaxValue);
            this.gridView2.Appearance.SelectedRow.ForeColor = Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.BorderStyle = BorderStyles.Simple;
            this.gridView2.Columns.AddRange(new GridColumn[7]
      {
        this.colcolorgroupprice_name,
        this.colprice,
        this.colidvalut,
        this.colk1,
        this.colprice_k1,
        this.colk2,
        this.colprice_k2
      });
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.colcolorgroupprice_name.Caption = "Ценовая группа";
            this.colcolorgroupprice_name.FieldName = "colorgroupprice_name";
            this.colcolorgroupprice_name.Name = "colcolorgroupprice_name";
            this.colcolorgroupprice_name.OptionsColumn.AllowEdit = false;
            this.colcolorgroupprice_name.OptionsFilter.AllowFilter = false;
            this.colcolorgroupprice_name.Visible = true;
            this.colcolorgroupprice_name.VisibleIndex = 0;
            this.colcolorgroupprice_name.Width = 247;
            this.colprice.Caption = "Цена по прайсу";
            this.colprice.DisplayFormat.FormatString = "0.####";
            this.colprice.DisplayFormat.FormatType = FormatType.Numeric;
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.OptionsFilter.AllowFilter = false;
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 1;
            this.colprice.Width = 105;
            this.colidvalut.Caption = "Валюта";
            this.colidvalut.ColumnEdit = (RepositoryItem)this.repositoryItemLookUpEditValut;
            this.colidvalut.FieldName = "idvalut";
            this.colidvalut.Name = "colidvalut";
            this.colidvalut.OptionsFilter.AllowFilter = false;
            this.colidvalut.Visible = true;
            this.colidvalut.VisibleIndex = 2;
            this.repositoryItemLookUpEditValut.AutoHeight = false;
            this.repositoryItemLookUpEditValut.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
            this.repositoryItemLookUpEditValut.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("shortname", "Сокр. наим.", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None)
      });
            this.repositoryItemLookUpEditValut.Name = "repositoryItemLookUpEditValut";
            this.repositoryItemLookUpEditValut.NullText = "";
            this.colk1.Caption = "К1";
            this.colk1.DisplayFormat.FormatString = "0.####";
            this.colk1.DisplayFormat.FormatType = FormatType.Numeric;
            this.colk1.FieldName = "k1";
            this.colk1.Name = "colk1";
            this.colk1.OptionsFilter.AllowFilter = false;
            this.colk1.Visible = true;
            this.colk1.VisibleIndex = 3;
            this.colk1.Width = 59;
            this.colprice_k1.Caption = "Себестоимость";
            this.colprice_k1.DisplayFormat.FormatString = "0.####";
            this.colprice_k1.DisplayFormat.FormatType = FormatType.Numeric;
            this.colprice_k1.FieldName = "price_k1";
            this.colprice_k1.Name = "colprice_k1";
            this.colprice_k1.OptionsColumn.AllowEdit = false;
            this.colprice_k1.OptionsFilter.AllowFilter = false;
            this.colprice_k1.Visible = true;
            this.colprice_k1.VisibleIndex = 4;
            this.colprice_k1.Width = 114;
            this.colk2.Caption = "К2";
            this.colk2.DisplayFormat.FormatString = "0.####";
            this.colk2.DisplayFormat.FormatType = FormatType.Numeric;
            this.colk2.FieldName = "k2";
            this.colk2.Name = "colk2";
            this.colk2.OptionsFilter.AllowFilter = false;
            this.colk2.Visible = true;
            this.colk2.VisibleIndex = 5;
            this.colk2.Width = 56;
            this.colprice_k2.Caption = "Стоимость";
            this.colprice_k2.DisplayFormat.FormatString = "0.####";
            this.colprice_k2.DisplayFormat.FormatType = FormatType.Numeric;
            this.colprice_k2.FieldName = "price_k2";
            this.colprice_k2.Name = "colprice_k2";
            this.colprice_k2.OptionsColumn.AllowEdit = false;
            this.colprice_k2.OptionsFilter.AllowFilter = false;
            this.colprice_k2.Visible = true;
            this.colprice_k2.VisibleIndex = 6;
            this.colprice_k2.Width = 144;
            this.lookUpEditColorGroup.DataBindings.Add(new Binding("EditValue", (object)this.ds, "good.idcolorgroupcustom", true));
            this.lookUpEditColorGroup.Location = new Point(142, 40);
            this.lookUpEditColorGroup.Name = "lookUpEditColorGroup";
            this.lookUpEditColorGroup.Properties.ActionButtonIndex = 1;
            this.lookUpEditColorGroup.Properties.BorderStyle = BorderStyles.Simple;
            this.lookUpEditColorGroup.Properties.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(ButtonPredefines.Minus),
        new EditorButton(ButtonPredefines.Combo)
      });
            this.lookUpEditColorGroup.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("idcolorgroupcustom", "#", 20, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None),
        new LookUpColumnInfo("name", "Наименование", 180),
        new LookUpColumnInfo("comment", "Комментарий", 180)
      });
            this.lookUpEditColorGroup.Properties.NullText = "";
            this.lookUpEditColorGroup.Properties.ButtonClick += new ButtonPressedEventHandler(this.lookUpEditColorGroup_Properties_ButtonClick);
            this.lookUpEditColorGroup.Properties.Click += new EventHandler(this.lookUpEditColorGroup_Properties_Click);
            this.lookUpEditColorGroup.Size = new Size(394, 20);
            this.lookUpEditColorGroup.TabIndex = 25;
            this.lookUpEditColorGroup.EditValueChanged += new EventHandler(this.lookUpEditColorGroup_EditValueChanged);
            this.lookUpEditColorGroup.EditValueChanging += new ChangingEventHandler(this.lookUpEditColorGroup_EditValueChanging);
            this.groupBox1.Controls.Add((Control)this.label13);
            this.groupBox1.Controls.Add((Control)this.calcEditPrice3);
            this.groupBox1.Controls.Add((Control)this.calcEditPrice5);
            this.groupBox1.Controls.Add((Control)this.calcEditPrice1);
            this.groupBox1.Controls.Add((Control)this.label25);
            this.groupBox1.Controls.Add((Control)this.calcEditPrice4);
            this.groupBox1.Controls.Add((Control)this.label31);
            this.groupBox1.Controls.Add((Control)this.label27);
            this.groupBox1.Controls.Add((Control)this.cboValut1);
            this.groupBox1.Controls.Add((Control)this.label14);
            this.groupBox1.Controls.Add((Control)this.label30);
            this.groupBox1.Controls.Add((Control)this.calcEditPrice2);
            this.groupBox1.Controls.Add((Control)this.cboValut2);
            this.groupBox1.Controls.Add((Control)this.label26);
            this.groupBox1.Controls.Add((Control)this.label29);
            this.groupBox1.Controls.Add((Control)this.cboValut5);
            this.groupBox1.Controls.Add((Control)this.cboValut3);
            this.groupBox1.Controls.Add((Control)this.label17);
            this.groupBox1.Controls.Add((Control)this.label28);
            this.groupBox1.Controls.Add((Control)this.cboValut4);
            this.groupBox1.Location = new Point(11, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(795, 159);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные цены";
            this.label38.AutoSize = true;
            this.label38.Location = new Point(8, 43);
            this.label38.Name = "label38";
            this.label38.Size = new Size(93, 13);
            this.label38.TabIndex = 23;
            this.label38.Text = "Цветовая группа";
            this.xtraTabPage2.Controls.Add((Control)this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new Size(869, 378);
            this.xtraTabPage2.Text = "Прочие характеристики";
            this.xtraTabGoodPrice.Name = "xtraTabGoodPrice";
            this.xtraTabGoodPrice.Size = new Size(869, 378);
            this.xtraTabGoodPrice.Text = "История цен";
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new Size(869, 378);
            this.xtraTabPage5.Text = "Буфер остатков";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.xtraTabControl1);
            this.Controls.Add((Control)this.textBox2);
            this.Controls.Add((Control)this.panel1);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.textBox4);
            this.Controls.Add((Control)this.label3);
            this.Controls.Add((Control)this.textBox3);
            this.Controls.Add((Control)this.label4);
            this.Name = "GoodEditForm";
            this.Size = new Size(877, 510);
            this.Text = "Материал";
            this.panel1.ResumeLayout(false);
            this.ds.EndInit();
            this.table_good.EndInit();
            this.table_goodparam.EndInit();
            this.table_measure.EndInit();
            this.table_system.EndInit();
            this.table_valut.EndInit();
            this.table_goodtype.EndInit();
            this.table_goodoptim.EndInit();
            this.table_colorgroupcustom.EndInit();
            this.table_goodcolorgroupprice.EndInit();
            this.table_customer.EndInit();
            this.checkEdit3.Properties.EndInit();
            this.gridControl1.EndInit();
            this.MenuItemParam.ResumeLayout(false);
            this.gridView1.EndInit();
            this.refButtonEdit.EndInit();
            this.comboBoxEdit1.Properties.EndInit();
            this.calcEditPrice1.Properties.EndInit();
            this.calcEditPrice2.Properties.EndInit();
            this.cboSystem.Properties.EndInit();
            this.calcEditWaste1.Properties.EndInit();
            this.cboValut1.Properties.EndInit();
            this.lookUpEditGoodType1.Properties.EndInit();
            ((ISupportInitialize)this.bsGoodType).EndInit();
            this.buttonEditPriceChangeGroup.Properties.EndInit();
            this.calcEdit4.Properties.EndInit();
            this.buttonEditOptimGroup.Properties.EndInit();
            this.calcEdit5.Properties.EndInit();
            this.calcEditPrice3.Properties.EndInit();
            this.calcEditPrice5.Properties.EndInit();
            this.calcEditPrice4.Properties.EndInit();
            this.cboValut5.Properties.EndInit();
            this.cboValut4.Properties.EndInit();
            this.cboValut3.Properties.EndInit();
            this.cboValut2.Properties.EndInit();
            this.xtraTabControl1.EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            this.lookUpEdit1.Properties.EndInit();
            this.checkEdit1.Properties.EndInit();
            this.atColor2.Properties.EndInit();
            this.atColor2.EndInit();
            this.atColor1.Properties.EndInit();
            this.atColor1.EndInit();
            this.calcEditSqr2.Properties.EndInit();
            this.calcEditSqr.Properties.EndInit();
            this.calcEditWeight.Properties.EndInit();
            this.calcEditThickness.Properties.EndInit();
            this.calcEditThick.Properties.EndInit();
            this.calcEditWidth.Properties.EndInit();
            this.calcEditHeight.Properties.EndInit();
            this.lookUpEditGoodType2.Properties.EndInit();
            this.calcEditWaste5.Properties.EndInit();
            this.calcEditWaste4.Properties.EndInit();
            this.calcEditWaste3.Properties.EndInit();
            this.calcEditWaste2.Properties.EndInit();
            this.buttonEditStoredepart.Properties.EndInit();
            this.checkEdit2.Properties.EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.gridControl2.EndInit();
            this.gridView2.EndInit();
            this.repositoryItemLookUpEditValut.EndInit();
            this.lookUpEditColorGroup.Properties.EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void table_goodcolorgroupprice_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            this.SetPricesFromK(e.Row);
        }

        private void table_colorgroupcustom_RowChanged(object sender, DataRowChangeEventArgs e)
        {
        }

        private void SetPricesFromK(DataRow dr)
        {
            Decimal num1 = Math.Round(Useful.GetDecimal(dr["price"]) * Useful.GetDecimal(dr["k1"]), 4);
            if (Useful.GetDecimal(dr["price_k1"]) != num1)
                dr["price_k1"] = (object)num1;
            Decimal num2 = Math.Round(num1 * Useful.GetDecimal(dr["k2"]), 4);
            if (!(Useful.GetDecimal(dr["price_k2"]) != num2))
                return;
            dr["price_k2"] = (object)num2;
        }

        private void AssignPriceHistoryEvents(PriceHistoryForm f)
        {
            if (f == null)
                return;
            f.BeforeAddPriceHistoryEvent += new EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs>(this.f_BeforeAddPriceHistoryEvent);
            f.AfterAddPriceHistoryEvent += new EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs>(this.f_AfterAddPriceHistoryEvent);
            f.BeforeDeletePriceHistoryEvent += new EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs>(this.f_BeforeDeletePriceHistoryEvent);
            f.AfterDeletePriceHistoryEvent += new EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs>(this.f_AfterDeletePriceHistoryEvent);
            f.BeforeEditPriceHistoryEvent += new EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs>(this.f_BeforeEditPriceHistoryEvent);
            f.AfterEditPriceHistoryEvent += new EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs>(this.f_AfterEditPriceHistoryEvent);
            f.BeforeDoublicatePriceHistoryEvent += new EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs>(this.f_BeforeDoublicatePriceHistoryEvent);
            f.AfterDoublicatePriceHistoryEvent += new EventHandler<PriceHistoryForm.OnPriceHistoryEventArgs>(this.f_AfterDoublicatePriceHistoryEvent);
        }

        private void f_AfterDoublicatePriceHistoryEvent(object sender, PriceHistoryForm.OnPriceHistoryEventArgs e)
        {
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.После дублирования истории цен", e.EventRows, (object)null, false);
        }

        private void f_BeforeDoublicatePriceHistoryEvent(object sender, PriceHistoryForm.OnPriceHistoryEventArgs e)
        {
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Перед дублированием истории цен", e.EventRows, (object)null, false);
        }

        private void f_AfterEditPriceHistoryEvent(object sender, PriceHistoryForm.OnPriceHistoryEventArgs e)
        {
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.После редактирования истории цен", e.EventRows, (object)null, false);
        }

        private void f_BeforeEditPriceHistoryEvent(object sender, PriceHistoryForm.OnPriceHistoryEventArgs e)
        {
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Перед редактированием истории цен", e.EventRows, (object)null, false);
        }

        private void f_AfterDeletePriceHistoryEvent(object sender, PriceHistoryForm.OnPriceHistoryEventArgs e)
        {
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.После удалением истории цен", e.EventRows, (object)null, false);
        }

        private void f_BeforeDeletePriceHistoryEvent(object sender, PriceHistoryForm.OnPriceHistoryEventArgs e)
        {
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Перед удалением истории цен", e.EventRows, (object)null, false);
        }

        private void f_AfterAddPriceHistoryEvent(object sender, PriceHistoryForm.OnPriceHistoryEventArgs e)
        {
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.После добавление истории цен", e.EventRows, (object)null, false);
        }

        private void f_BeforeAddPriceHistoryEvent(object sender, PriceHistoryForm.OnPriceHistoryEventArgs e)
        {
            new CalcProcessor(this.db).ExecuteOrderEvent("События справочников.Перед добавление истории цен", e.EventRows, (object)null, false);
        }

        public static bool SaveGoodPriceChanges(DataRow[] changedRows)
        {
            return GoodEditForm.SaveGoodPriceChanges(changedRows, true);
        }

        public static bool SaveGoodPriceChanges(DataRow[] changedRows, bool neddCheckChanges)
        {
            bool flag1 = false;
            string str = "INSERT INTO goodprice (idgoodprice,idgood,\r\n\t\t\t\t        \t\t\tprice1,price2,price3,price4,price5,\r\n\t\t\t    \t\t    \t\tidvalut,idvalut2,idvalut3,idvalut4,idvalut5,\r\n\t\t\t\t\t\t\t        dt,\r\n                                    idpeopleedit)\r\n\t\t                        VALUES (@idgoodprice, @idgood, \r\n\t\t\t\t                    @price1,@price2,@price3,@price4,@price5,\r\n\t\t\t\t                    @idvalut,@idvalut2,@idvalut3,@idvalut4,@idvalut5,\r\n                                    @curDate,\r\n                                    @idpeopleedit)";
            foreach (DataRow dataRow in changedRows)
            {
                bool flag2 = true;
                dbconn dbconn = dbconn._db;
                if (neddCheckChanges)
                {
                    dbconn.command.Parameters.Clear();
                    string cmd = " select count(*) from good where ";
                    string[] strArray = new string[11]
          {
            "price1",
            "price2",
            "price3",
            "price4",
            "price5",
            "idvalut",
            "idvalut2",
            "idvalut3",
            "idvalut4",
            "idvalut5",
            "idgood"
          };
                    int num = 0;
                    foreach (string index in strArray)
                    {
                        if (dbconn.IsValueDbNullOrNull(dataRow[index]))
                        {
                            cmd += string.Format(" {0} is null ", (object)index);
                        }
                        else
                        {
                            cmd += string.Format(" {0} = @{0} ", (object)index);
                            dbconn.command.Parameters.Add(new SqlParameter(string.Format("@{0}", (object)index), dataRow[index]));
                        }
                        if (num != strArray.Length - 1)
                            cmd += " and ";
                        ++num;
                    }
                    dbconn.command.CommandText = cmd;
                    int result = -42;
                    if (dbconn.ExecScalar(cmd, -42, out result))
                        flag2 = result == 0;
                }
                if (flag2)
                {
                    dbconn.command.Parameters.Clear();
                    int genId = dbconn.GetGenId("gen_goodprice");
                    dbconn.command.Parameters.Add(new SqlParameter("@idgoodprice", (object)genId));
                    dbconn.command.Parameters.Add(new SqlParameter("@idgood", dataRow["idgood"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@price1", dataRow["price1"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@price2", dataRow["price2"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@price3", dataRow["price3"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@price4", dataRow["price4"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@price5", dataRow["price5"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@idvalut", dataRow["idvalut"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@idvalut2", dataRow["idvalut2"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@idvalut3", dataRow["idvalut3"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@idvalut4", dataRow["idvalut4"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@idvalut5", dataRow["idvalut5"]));
                    dbconn.command.Parameters.Add(new SqlParameter("@idpeopleedit", (object)Settings.People.idpeople));
                    SqlParameter sqlParameter = new SqlParameter("@curDate", SqlDbType.DateTime);
                    sqlParameter.Value = (object)DateTime.Now;
                    dbconn.command.Parameters.Add(sqlParameter);
                    dbconn.command.CommandText = str;
                    flag1 = dbconn.Exec();
                    dbconn.command.Parameters.Clear();
                }
            }
            return flag1;
        }

        private void GoodEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.table_good.Rows[0].EndEdit();
            if (!AtDataSet.IsModifDataSet(this.ds))
                return;
            switch (MessageBox.Show("Данные были изменены! Сохранить изменения?", "Закрытие формы редактирования материала", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.SaveToBase();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void calcEditWidth_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.table_good.Rows[0]["width"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditWeight_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.table_good.Rows[0]["weight"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditThickness_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.table_good.Rows[0]["thickness"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditThick_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.table_good.Rows[0]["thick"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditSqr_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.table_good.Rows[0]["sqr"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditSqr2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.table_good.Rows[0]["sqr2"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditHeight_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.table_good.Rows[0]["height"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void lookUpEditGoodType1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["idgoodtype"] = (object)DBNull.Value;
        }

        private void lookUpEditGoodType2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["idgoodtype2"] = (object)DBNull.Value;
        }

        private void calcEditPrice1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["price1"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditPrice2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["price2"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditPrice3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["price3"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditPrice4_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["price4"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void calcEditPrice5_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["price5"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void atColor2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != ButtonPredefines.Minus)
                return;
            this.table_good.Rows[0]["idcolor2"] = (object)DBNull.Value;
            this.atColor2.Text = string.Empty;
        }

        private void atColor1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != ButtonPredefines.Minus)
                return;
            this.table_good.Rows[0]["idcolor1"] = (object)DBNull.Value;
            this.atColor1.Text = string.Empty;
        }

        private void atColor2_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (Useful.GetInt32(this.atColor2.IdColor) == 0)
                this.table_good.Rows[0]["idcolor2"] = (object)DBNull.Value;
            else
                this.table_good.Rows[0]["idcolor2"] = (object)Useful.GetInt32(this.atColor2.IdColor);
        }

        private void atColor1_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (Useful.GetInt32(this.atColor1.IdColor) == 0)
                this.table_good.Rows[0]["idcolor1"] = (object)DBNull.Value;
            else
                this.table_good.Rows[0]["idcolor1"] = (object)Useful.GetInt32(this.atColor1.IdColor);
        }

        private void cboValut1_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboValut1.SelectedIndex == -1)
                return;
            DataRow dataRow = this.table_good.Rows[0];
            int num = ((Valut)this.cboValut1.SelectedItem).idvalut;
            string str = ((Valut)this.cboValut1.SelectedItem).name;
            dataRow["idvalut"] = (object)num;
            dataRow["valut_shortname"] = (object)str;
            dataRow.EndEdit();
        }

        private void cboValut2_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboValut2.SelectedIndex == -1)
                return;
            DataRow dataRow = this.table_good.Rows[0];
            int num = ((Valut)this.cboValut2.SelectedItem).idvalut;
            string str = ((Valut)this.cboValut2.SelectedItem).name;
            dataRow["idvalut2"] = (object)num;
            dataRow["valut2_shortname"] = (object)str;
            dataRow.EndEdit();
        }

        private void cboValut3_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboValut3.SelectedIndex == -1)
                return;
            DataRow dataRow = this.table_good.Rows[0];
            int num = ((Valut)this.cboValut3.SelectedItem).idvalut;
            string str = ((Valut)this.cboValut3.SelectedItem).name;
            dataRow["idvalut3"] = (object)num;
            dataRow["valut3_shortname"] = (object)str;
            dataRow.EndEdit();
        }

        private void cboValut4_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboValut4.SelectedIndex == -1)
                return;
            DataRow dataRow = this.table_good.Rows[0];
            int num = ((Valut)this.cboValut4.SelectedItem).idvalut;
            string str = ((Valut)this.cboValut4.SelectedItem).name;
            dataRow["idvalut4"] = (object)num;
            dataRow["valut4_shortname"] = (object)str;
            dataRow.EndEdit();
        }

        private void cboValut5_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboValut5.SelectedIndex == -1)
                return;
            DataRow dataRow = this.table_good.Rows[0];
            int num = ((Valut)this.cboValut5.SelectedItem).idvalut;
            string str = ((Valut)this.cboValut5.SelectedItem).name;
            dataRow["idvalut5"] = (object)num;
            dataRow["valut5_shortname"] = (object)str;
            dataRow.EndEdit();
        }

        private void cboValut1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["idvalut"] = (object)DBNull.Value;
            this.table_good.Rows[0]["valut_shortname"] = (object)DBNull.Value;
        }

        private void cboValut2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["idvalut2"] = (object)DBNull.Value;
            this.table_good.Rows[0]["valut2_shortname"] = (object)DBNull.Value;
        }

        private void cboValut3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["idvalut3"] = (object)DBNull.Value;
            this.table_good.Rows[0]["valut3_shortname"] = (object)DBNull.Value;
        }

        private void cboValut4_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["idvalut4"] = (object)DBNull.Value;
            this.table_good.Rows[0]["valut4_shortname"] = (object)DBNull.Value;
        }

        private void cboValut5_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.table_good.Rows[0]["idvalut5"] = (object)DBNull.Value;
            this.table_good.Rows[0]["valut5_shortname"] = (object)DBNull.Value;
        }

        private void buttonEditOptimGroup_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                this.table_good.Rows[0]["idgoodoptim"] = (object)DBNull.Value;
                this.table_good.Rows[0]["goodoptim_name"] = (object)DBNull.Value;
            }
            else
            {
                GoodOptimForm goodOptimForm = new GoodOptimForm();
                goodOptimForm.IsDialog();
                if (goodOptimForm.ShowDialog() != DialogResult.OK)
                    return;
                DataRow dataRow = AtGrid.getDataRow((Control)goodOptimForm.gridControl1);
                if (dataRow == null)
                    return;
                this.table_good.Rows[0]["idgoodoptim"] = dataRow["idgoodoptim"];
                this.table_good.Rows[0]["goodoptim_name"] = dataRow["name"];
            }
        }

        private void buttonEditStoredepart_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                this.table_good.Rows[0]["idstoredepart"] = (object)DBNull.Value;
                this.table_good.Rows[0]["storedepart_name"] = (object)DBNull.Value;
            }
            else
            {
                StoreDepartForm storeDepartForm = new StoreDepartForm();
                storeDepartForm.IsDialog();
                if (storeDepartForm.ShowDialog() != DialogResult.OK)
                    return;
                DataRow dataRow = AtGrid.getDataRow((Control)storeDepartForm.gridControl1);
                if (dataRow == null)
                    return;
                this.table_good.Rows[0]["idstoredepart"] = dataRow["idstoredepart"];
                this.table_good.Rows[0]["storedepart_name"] = dataRow["name"];
            }
        }

        private void buttonEditPriceChangeGroup_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                this.table_good.Rows[0]["idgoodpricegroup"] = (object)DBNull.Value;
                this.table_good.Rows[0]["goodpricegroup_name"] = (object)DBNull.Value;
            }
            else
            {
                GoodPriceUpdateForm goodPriceUpdateForm = new GoodPriceUpdateForm();
                goodPriceUpdateForm.IsDialog();
                if (goodPriceUpdateForm.ShowDialog() != DialogResult.OK)
                    return;
                DataRow dataRow = AtGrid.getDataRow((Control)goodPriceUpdateForm.gridControl1);
                if (dataRow == null)
                    return;
                this.table_good.Rows[0]["idgoodpricegroup"] = dataRow["idgoodpricegroup"];
                this.table_good.Rows[0]["goodpricegroup_name"] = dataRow["name"];
            }
        }

        private void comboBoxEdit1_Validating(object sender, CancelEventArgs e)
        {
            if (this.comboBoxEdit1.SelectedIndex == -1)
                return;
            int idmeasure = ((Measure)this.comboBoxEdit1.SelectedItem).Idmeasure;
            string shortname = ((Measure)this.comboBoxEdit1.SelectedItem).Shortname;
            this.table_good.Rows[0]["idmeasure"] = (object)idmeasure;
            this.table_good.Rows[0]["measure_shortname"] = (object)shortname;
            this.table_good.Rows[0].EndEdit();
        }

        private void cboSystem_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboSystem.SelectedIndex == -1)
                return;
            int num = ((System1)this.cboSystem.SelectedItem).Id;
            string str = ((System1)this.cboSystem.SelectedItem).Name;
            if (num != -1)
            {
                this.table_good.Rows[0]["idsystem"] = (object)num;
                this.table_good.Rows[0]["system_name"] = (object)str;
            }
            else
            {
                this.table_good.Rows[0]["idsystem"] = (object)DBNull.Value;
                this.table_good.Rows[0]["system_name"] = (object)DBNull.Value;
            }
            this.table_good.Rows[0].EndEdit();
        }

        private void cboSystem_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index != 0)
                return;
            this.cboSystem.EditValue = (object)null;
            this.table_good.Rows[0]["idsystem"] = (object)DBNull.Value;
            this.table_good.Rows[0]["system_name"] = (object)DBNull.Value;
            this.table_good.Rows[0].EndEdit();
        }

        private void LoadGoodPriceChange()
        {
        }

        public override void LoadFromBase()
        {
            CalcProcessor calcProcessor = new CalcProcessor(this.db);
            calcProcessor.ExecuteOrderEvent("События справочников.Перед загрузкой материала", this.table_good.Select(), false);
            this.db.command.CommandText = "select * from colorgroupcustom where deleted is null";
            this.db.adapter.Fill(this.table_colorgroupcustom);
            this.db.command.CommandText = "select * from view_good where idgood = " + (object)this.idgood;
            this.db.adapter.Fill(this.table_good);
            if (this.table_good.Rows.Count > 0)
            {
                this.cboSystem.Text = this.table_good.Rows[0]["system_name"].ToString();
                this.comboBoxEdit1.Text = this.table_good.Rows[0]["measure_shortname"].ToString();
                this.cboValut1.Text = this.table_good.Rows[0]["valut_shortname"].ToString();
            }
            this.db.command.CommandText = "select * from goodparam where idgood = " + (object)this.idgood + " and deleted is null";
            this.db.adapter.Fill(this.table_goodparam);
            this.db.command.CommandText = "select idmeasure, name, shortname from measure where deleted is null";
            this.db.adapter.Fill(this.table_measure);
            this.db.command.CommandText = "select idsystem, name from system where deleted is null order by numpos";
            this.db.adapter.Fill(this.table_system);
            this.db.command.CommandText = "select idvalut, shortname from valut where deleted is null";
            this.db.adapter.Fill(this.table_valut);
            this.db.command.CommandText = "select * from goodtype where deleted is null";
            this.db.adapter.Fill(this.table_goodtype);
            this.db.command.CommandText = "select * from goodoptim where deleted is null";
            this.db.adapter.Fill(this.table_goodoptim);
            this.db.command.CommandText = "select * from view_goodcolorgroupprice where deleted is null and idgood=" + (object)this.idgood;
            this.db.adapter.Fill(this.table_goodcolorgroupprice);
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_measure.Rows)
                this.comboBoxEdit1.Properties.Items.Add((object)new Measure()
                {
                    Idmeasure = (int)dataRow["idmeasure"],
                    Shortname = dataRow["shortname"].ToString()
                });
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_system.Rows)
                this.cboSystem.Properties.Items.Add((object)new System1()
                {
                    Id = (int)dataRow["idsystem"],
                    Name = dataRow["name"].ToString()
                });
            this.cboSystem.Properties.Items.Add((object)new System1()
            {
                Id = -1,
                Name = "<пусто>"
            });
            foreach (DataRow dataRow in (InternalDataCollectionBase)this.table_valut.Rows)
            {
                Valut valut = new Valut();
                valut.idvalut = (int)dataRow["idvalut"];
                valut.name = dataRow["shortname"].ToString();
                this.cboValut1.Properties.Items.Add((object)valut);
                this.cboValut2.Properties.Items.Add((object)valut);
                this.cboValut3.Properties.Items.Add((object)valut);
                this.cboValut4.Properties.Items.Add((object)valut);
                this.cboValut5.Properties.Items.Add((object)valut);
            }
            this.atColor1.IdColor = this.table_good.Rows[0]["idcolor1"];
            this.atColor2.IdColor = this.table_good.Rows[0]["idcolor2"];
            calcProcessor.ExecuteOrderEvent("События справочников.После загрузки материала", this.table_good.Select(), false);
        }

        public override bool SaveToBase()
        {
            CalcProcessor calcProcessor = new CalcProcessor(this.db);
            calcProcessor.ExecuteOrderEvent("События справочников.Перед сохранением материала", this.table_good.Select(), false);
            List<DataRow> list = new List<DataRow>();
            list.AddRange((IEnumerable<DataRow>)this.table_good.Select());
            GoodEditForm.SaveGoodPriceChanges(list.ToArray());
            if (!this.db.SaveDataSet2(this.ds))
                return false;
            this.ds.AcceptChanges();
            DataRow dataRow = this.table_good.Rows[0];
            this.dr_from_good["name"] = dataRow["name"];
            this.dr_from_good["marking"] = dataRow["marking"];
            this.dr_from_good["extmarking"] = dataRow["extmarking"];
            this.dr_from_good["typ"] = dataRow["typ"];
            this.dr_from_good["ismy"] = dataRow["ismy"];
            this.dr_from_good["usehouse"] = dataRow["usehouse"];
            this.dr_from_good["system_name"] = dataRow["system_name"];
            this.dr_from_good["idsystem"] = dataRow["idsystem"];
            this.dr_from_good["idmeasure"] = dataRow["idmeasure"];
            this.dr_from_good["height"] = dataRow["height"];
            this.dr_from_good["width"] = dataRow["width"];
            this.dr_from_good["weight"] = dataRow["weight"];
            this.dr_from_good["thick"] = dataRow["thick"];
            this.dr_from_good["thickness"] = dataRow["thickness"];
            this.dr_from_good["price1"] = dataRow["price1"];
            this.dr_from_good["price2"] = dataRow["price2"];
            this.dr_from_good["waste"] = dataRow["waste"];
            this.dr_from_good["waste2"] = dataRow["waste2"];
            this.dr_from_good["waste3"] = dataRow["waste3"];
            this.dr_from_good["waste4"] = dataRow["waste4"];
            this.dr_from_good["waste5"] = dataRow["waste5"];
            this.dr_from_good["idvalut"] = dataRow["idvalut"];
            this.dr_from_good["valut_shortname"] = dataRow["valut_shortname"];
            this.dr_from_good["measure_shortname"] = dataRow["measure_shortname"];
            this.dr_from_good["idgoodtype"] = dataRow["idgoodtype"];
            this.dr_from_good["idgoodtype2"] = dataRow["idgoodtype2"];
            this.dr_from_good["idstoredepart"] = dataRow["idstoredepart"];
            this.dr_from_good["sqr"] = dataRow["sqr"];
            this.dr_from_good["goodtype_name"] = (object)this.lookUpEditGoodType1.Text;
            this.dr_from_good["showinnopaper"] = dataRow["showinnopaper"];
            this.dr_from_good["idcolorgroupcustom"] = dataRow["idcolorgroupcustom"];
            if (dataRow["idcolorgroupcustom"] == DBNull.Value)
            {
                this.dr_from_good["colorgroupcustom_name"] = (object)DBNull.Value;
            }
            else
            {
                DataRow[] dataRowArray = this.table_colorgroupcustom.Select("idcolorgroupcustom=" + dataRow["idcolorgroupcustom"].ToString());
                if (dataRowArray.Length != 1)
                    throw new Exception("В таблице colorgroupcustom не обнаружено записей, ссылающихся из материалов");
                this.dr_from_good["colorgroupcustom_name"] = (object)dataRowArray[0]["name"].ToString();
            }
            if (dataRow["idcolor1"] != DBNull.Value)
            {
                if (Useful.GetInt32(dataRow["idcolor1"]) > 0)
                {
                    this.dr_from_good["idcolor1"] = dataRow["idcolor1"];
                    this.dr_from_good["color1_name"] = dataRow["color1_name"];
                }
                else
                {
                    this.dr_from_good["idcolor1"] = (object)DBNull.Value;
                    this.dr_from_good["color1_name"] = (object)DBNull.Value;
                }
            }
            if (dataRow["idcolor2"] != DBNull.Value)
            {
                if (Useful.GetInt32(dataRow["idcolor2"]) > 0)
                {
                    this.dr_from_good["idcolor2"] = dataRow["idcolor2"];
                    this.dr_from_good["color2_name"] = dataRow["color2_name"];
                }
                else
                {
                    this.dr_from_good["idcolor2"] = (object)DBNull.Value;
                    this.dr_from_good["color2_name"] = (object)DBNull.Value;
                }
            }
            this.dr_from_good.AcceptChanges();
            if (this.phist != null)
                this.phist.SaveToBase();
            if (this.gbuffer != null)
                this.gbuffer.SaveToBase();
            this.db.SaveDatatable2(this.table_goodcolorgroupprice);
            calcProcessor.ExecuteOrderEvent("События справочников.После сохранения материала", this.table_good.Select(), false);
            return true;
        }

        public double LoadValutRate(int idvalut)
        {
            double num = 0.0;
            this.db.command2.CommandText = "select dbo.get_valutrate(@v, @d)";
            this.db.command2.Parameters.Clear();
            this.db.command2.Parameters.Add("@v", SqlDbType.Int).Value = (object)idvalut;
            this.db.command2.Parameters.Add("@d", SqlDbType.DateTime).Value = (object)DateTime.Now.Date;
            try
            {
                this.db.OpenDB();
                SqlDataReader sqlDataReader = this.db.command2.ExecuteReader();
                sqlDataReader.Read();
                num = Convert.ToDouble(sqlDataReader[0]);
                sqlDataReader.Close();
            }
            finally
            {
                this.db.CloseDB();
            }
            return num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveToBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ds.Clear();
            this.LoadFromBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = this.table_goodparam.NewRow();
            row["idgoodparam"] = (object)dbconn.GetGenId("gen_goodparam");
            row["name"] = (object)"Новая характеристика";
            row["idgood"] = this.table_good.Rows[0]["idgood"];
            this.table_goodparam.Rows.Add(row);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            AtDataSet.dublicate(dataRow)["idgoodparam"] = (object)dbconn.GetGenId("gen_goodparam");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow.Delete();
        }

        private void bsGoodType_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (this.xtraTabControl1.SelectedTabPage != this.xtraTabGoodPrice || this.xtraTabGoodPrice.Controls == null)
                return;
            foreach (Control control in (ArrangedElementCollection)this.xtraTabGoodPrice.Controls)
            {
                PriceHistoryForm priceHistoryForm = control as PriceHistoryForm;
                if (priceHistoryForm != null)
                {
                    priceHistoryForm.LoadFromBase();
                    break;
                }
            }
        }

        private void refButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GoodParamNameForm goodParamNameForm = new GoodParamNameForm();
            if (goodParamNameForm.ShowDialog() != DialogResult.OK)
                return;
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null)
                return;
            dataRow["idgoodparamname"] = goodParamNameForm.Result["idgoodparamname"];
            dataRow["name"] = goodParamNameForm.Result["name"];
            dataRow["comment"] = goodParamNameForm.Result["comment"];
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            DataRow dataRow = AtGrid.getDataRow((Control)this.gridControl1);
            if (dataRow == null || e.Column != this.colname && e.Column != this.colcomment)
                return;
            dataRow["idgoodparamname"] = (object)DBNull.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MdiManager.Add((Control)new GoodParamNameForm());
        }

        private void calcEditPrice2_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void lookUpEditColorGroup_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void lookUpEditColorGroup_Properties_Click(object sender, EventArgs e)
        {
        }

        private void lookUpEditColorGroup_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != ButtonPredefines.Minus)
                return;
            this.table_good.Rows[0]["idcolorgroupcustom"] = (object)DBNull.Value;
        }

        private void lookUpEditColorGroup_EditValueChanging(object sender, ChangingEventArgs e)
        {
            foreach (DataRow dataRow in this.table_goodcolorgroupprice.Select())
                dataRow.Delete();
            DataRow dataRow1 = this.table_good.Select()[0];
            int num1 = Convert.ToInt32(e.NewValue);
            if (this.table_valut.Select().Length <= 0)
                return;
            int num2 = Convert.ToInt32(this.table_valut.Select()[0]["idvalut"]);
            DataTable table = new DataTable();
            this.db.command.CommandText = "select * from colorgroupprice where deleted is null and idcolorgroupcustom=" + (object)num1;
            this.db.adapter.Fill(table);
            foreach (DataRow dataRow2 in table.Select())
            {
                DataRow row = this.table_goodcolorgroupprice.NewRow();
                row["idgoodcolorgroupprice"] = (object)dbconn.GetGenId("gen_goodcolorgroupprice");
                row["idvalut"] = (object)num2;
                row["idgood"] = (object)this.idgood;
                row["idcolorgroupprice"] = dataRow2["idcolorgroupprice"];
                row["colorgroupprice_name"] = dataRow2["name"];
                row["price"] = (object)0;
                row["k1"] = (object)1;
                row["k2"] = (object)1;
                row["price_k1"] = (object)0;
                row["price_k2"] = (object)0;
                this.table_goodcolorgroupprice.Rows.Add(row);
            }
        }

        private void lookUpEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != ButtonPredefines.Minus)
                return;
            this.table_good.Rows[0]["idcustomer"] = (object)DBNull.Value;
        }
    }
}
