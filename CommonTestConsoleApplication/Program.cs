using Atechnology.DBConnections2;
using fo_library.Choosing.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OptimBaseProf;


namespace CommonTestConsoleApplication
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            dbinit.db = new SqlConnection("Data Source=sqlwindraw.fabrikon.ru;Initial Catalog=ecad_FO;User ID=windraw;Password=Ffff1234");
            //ChoosingDatePeriodDialog dialog = new ChoosingDatePeriodDialog();
            //DialogResult result = dialog.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    Console.WriteLine("Start = " + dialog.StartPeriod.ToShortDateString());
            //    Console.WriteLine("End = " + dialog.EndPeriod.ToShortDateString());

            //    Console.ReadLine();
            //}


            //fo_library.Export.fo_export.SupplyWindowsillExport(165);

            //string result = fo_library.Validation.Validator.ManufactNumbersValidate(new string[]{"95145","95218","95287","95389","95398","95339","95318","95330","95321","95340","95324","95332","95326","95307","95038","95076","95325","95341","95333","95334","95316","95317","95323","95327","95315","95336","95328","95335","95388","95394","95363","95387","95344","95342","95343","95196","94974","95280","95214"});

            //ChoosingOrdersDialog dialog1 = new ChoosingOrdersDialog();

            //dialog1.showDialogView = new ManufactnameFormDialog();

            //DialogResult r = dialog1.ShowDialog();

            //if (r == DialogResult.OK)
            //{
            //    var result = dialog1.OrderIdArray;
            //    var res = string.Join(",", result.Select(item=>item.ToString()).ToArray());
            //    var taskname = dialog1.TaskNumber;
            //}

            //fo_library.Choosing.OfferPromotion.OfferPromotionChoosingDialog dialog = new fo_library.Choosing.OfferPromotion.OfferPromotionChoosingDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{

            //}

            //fo_library.Choosing.OfferPromotion.OfferPromotionsDialog dialog2 = new fo_library.Choosing.OfferPromotion.OfferPromotionsDialog();

            //dialog2.ShowDialog();

            //string idoptimdocs = "1709,1710,1711,1712,1713,1714,1715";
            //int idoptimdocs = 3454; OLD
     

            int idoptimdocs = 8003;// - трапеция прямая //6011 - трапеция кривая; //6337; //5651;//5469;//5400; //5140; // 5140;//5137;//5119;//5112; //5094;
            //fo_library.Export.fo_export.OptimizedMainProfileExport(idoptimdocs);
            string FilePath = "";
            //**************** задание на пилу **********************************
            OptimBaseProf.OptimBaseProf.FileGenerator(idoptimdocs, "c:\\MyProject\\123\\sawfile\\"); //ONE верно

            //fo_library.Export.fo_export.OptimizedMainProfileExport(idoptimdocs);  //TWO неверно

            //fo_library.Export.fo_export.SupplyGlassPackExport(3467); //3297
            //fo_library.Export.fo_export.SupplyWindowsillExport(1119);
            //FastExport.FastExport.SupplyWindowsillExport(124);

        //    FastExport.FastExport.GetAllWindowsillExport(1119);
            

           // Заполнить modelcalc.fo_attributes
            //string		commandText = "fo_supply_get_glasspacks";
            //string idorders = "165559";
			
            //DataSet dataSet = new DataSet();
            //using(SqlCommand command = new SqlCommand(commandText, dbinit.db))
            //using(SqlDataAdapter adapter = new SqlDataAdapter(command))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.AddWithValue(@"idorders", idorders);
				
            //    adapter.Fill(dataSet);
            //}
            //fo_library.Export.fo_export.SupplyGlassPackSetFoAttributes(dataSet);
         //   fo_library.Export.fo_export.OptimizedMainProfileExport(1911);
            // Заполнить modelcalc.fo_attributes
         


        }
    }
}
