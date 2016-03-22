using Atechnology.DBConnections2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FastExport
{
    internal class Contractor
    {
        internal readonly string Inn;

        internal readonly string Name;

        internal readonly string Address;

        private static Contractor _instance;

        private Contractor(string name, string inn, string address)
        {
            Inn = inn;
            Name = name;
            Address = address;
        }

        internal static Contractor GetContractor()
        {
            if (_instance == null)
            {
                SqlConnection connection = dbinit.db;
                using (SqlCommand command = new SqlCommand("SELECT name, inn, address FROM customer WHERE idcustomer = 40860", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    DataRow row = dataTable.Rows[0];


                    _instance = new Contractor((string)row["name"],(string)row["inn"],(string)row["address"]);
                }
            }

            return _instance;

        }
    }
}
