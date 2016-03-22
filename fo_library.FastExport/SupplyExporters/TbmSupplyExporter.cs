using Atechnology.DBConnections2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace FastExport
{
    internal class TbmSupplyExporter : IDocExporter
    {
        private int supplyDocumentId;
        internal TbmSupplyExporter(int supplyDocId)
        {
            supplyDocumentId = supplyDocId;
        }

        public string DocName
        {
            get;
            set;
        }

        public DateTime DocDate
        {
            get;
            set;
        }

        public string FileDirecoryName
        {
            get;
            set;
        }


        public string FullFileName
        {
            get
            {
                return Path.Combine(FileDirecoryName, string.Concat("ZK_UNT_", "31625_", DocDate.ToString("dd_MM_yy_hh_mm"),".xml"));
            }
        }
        public void Export()
        {
            DataTable tbmTable = new DataTable("TBM");
            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;
                command.CommandText = @"
SELECT
	g.marking
	--, g.name AS name
	, sdp.thick
	, sdp.comment AS manufact_name
	, dbo.fo_getBarCodeValue_mc(sdp.fo_idmodelcalc) AS bar_code
    , ROW_NUMBER() OVER(PARTITION BY sdp.comment ORDER BY sdp.fo_idmodelcalc) AS order_nn
	, COUNT(*) OVER(PARTITION BY sdp.comment) AS order_count
FROM  supplydocpos AS sdp
INNER JOIN good AS g ON sdp.idgood = g.idgood
WHERE sdp.idsupplydoc = @idsupplydoc
AND sdp.deleted IS NULL
AND g.idgoodtype = 13
AND g.idcustomer = 60520 -- Поставщик ТБМ";

                command.Parameters.AddWithValue("@idsupplydoc", supplyDocumentId);
                adapter.Fill(tbmTable);
            }

            XElement xWindowsills = new XElement("Windowsills");

            foreach (DataRow row in tbmTable.Rows)
            {
                //string name = (string)row["name"];

                string article = (string)row["marking"]; // Артикул

                double length = ((int)row["thick"]) / 10.0;

                string manufactName = (string)row["manufact_name"];

                // -- "Номер в заказе"
                int orderNN = Convert.ToInt32(row["order_nn"]);

                // -- Общее количество в заказе
                int orderCount = Convert.ToInt32(row["order_count"]);

                string marking = string.Concat(manufactName, " ", orderNN, "/", orderCount);
                // -- Штрих код
                string barCode = (string)row["bar_code"];

                xWindowsills.Add(new XElement("Windowsill",
                    //new XAttribute("Name", name),
                    new XAttribute("Article", article),
                    new XAttribute("Length", length.ToString()), //ToString дает запятую вместо точки.
                    new XAttribute("Marking", marking),
                    new XAttribute("BarCode", barCode)));
            }

            Contractor contractor = Contractor.GetContractor();

            XElement xHead = new XElement("RequestInfo",
                new XAttribute("CustCode",31625),
                new XAttribute("RequestDate", DocDate),
                new XAttribute("DeliveryDate", DocDate.AddDays(2)),
                new XAttribute("DeliveryAddress", contractor.Address));

            XElement result = new XElement("Request",
                new XComment("RequestInfo - Информация по заявке."),
                 new XComment("CustCode - шифр клиента"),
                new XComment("RequestDate - Дата заявки"),
                new XComment("DeliveryDate - Дата доставки"),
                new XComment("DeliveryAddress - Адрес доставки"));

            result.Add(xHead);

            result.Add(new XComment("Windowsills - подоконники"));
            result.Add(new XComment("Article - Артикул"));
            result.Add(new XComment("Length - длина подоконика в см."));
            result.Add(new XComment("Marking - маркировка"));
            result.Add(new XComment("BarCode - Штрих код"));
            result.Add(xWindowsills);

        

            result.Save(FullFileName);
        }
    }
}
