using Atechnology.DBConnections2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Choosing.Common
{
    public class ManufactAgreeNameCollection
    {
        private BindingSource _BindingSource;


        public List<ManufactAgreeName> Names
        {
            get
            {
                return _names;
            }
        }

        private List<ManufactAgreeName> _names { get; set; }

        public ManufactAgreeNameCollection(BindingSource bindingSource)
        {

            _names = new List<ManufactAgreeName>();


            _BindingSource = bindingSource;
            _BindingSource.DataSource = this;
            _BindingSource.DataMember = "Names";


        }

        // Связывает по новому список имен с bindingsource.
        private void BindWithView()
        {
            _BindingSource.DataSource = null;
            _BindingSource.DataSource = this;
            _BindingSource.DataMember = "Names";
        }

        // Добавление новых пар в список по массив пр. имен
        internal void AddByManufactNames(string[] manufaсtNames)
        {
            var names = ManufactAgreeName.GetNamesByManufactNames(manufaсtNames);

            _names.AddRange(names);

            BindWithView();
        }
    }

    public class ManufactAgreeName
    {
        private string _manufactName;
        public string ManufactName
        {
            get
            {
                return _manufactName;
            }
            set
            {


                _manufactName = value;
                SetAgreeNameByManufactName();
            }
        }



        private string _agreeName;
        public string AgreeName
        {
            get
            {
                return _agreeName;
            }
            set
            {

                _agreeName = value;
                SetManufactNameByAgreeName();
            }
        }


        public int IdOrder
        {
            get;
            private set;
        }

        public string DocOperName
        {
            get;
            private set;
        }

        public string ConstrComm
        {
            get;
            private set;
        }


        public ManufactAgreeName()
        {

        }




        // Получить перечисление имен из массива manufactNames.
        public static IEnumerable<ManufactAgreeName> GetNamesByManufactNames(string[] manufactNames)
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Connection = dbinit.db;

                command.CommandText = @"
SELECT
    mn.fo_manufactname AS manufactname
    , mn.fo_agreename AS agreename
    , o.idorder
    , do.name AS docopername
    , ISNULL(o.addstr4, '') AS ConstrComm
FROM fo_manufact_names AS mn
INNER JOIN orders AS o ON mn.fo_agreename = o.agreename
                        AND mn.fo_iddocoper = o.iddocoper
                        AND mn.fo_notrelevant IS NULL
                        AND o.deleted IS NULL
INNER JOIN docoper AS do ON o.iddocoper = do.iddocoper                        
WHERE mn.fo_manufactname IN(SELECT item FROM dbo.fnSplit(@manufactnames,','))";

                command.Parameters.AddWithValue("@manufactnames", string.Join(",", manufactNames));

                adapter.Fill(table);

                string idorder = string.Join(",", table.AsEnumerable().Select(r => r.Field<int>("idorder").ToString()).ToArray());

                foreach (DataRow row in table.Rows)
                {
                    ManufactAgreeName name = new ManufactAgreeName();
                    name._manufactName = (string)row["manufactname"];
                    name._agreeName = (string)row["agreename"];
                    name.IdOrder = (int)row["idorder"];
                    name.DocOperName = (string)row["docopername"];
                    name.ConstrComm = (string)row["ConstrComm"];

                    yield return name;
                }
            }
        }


        private void SetAgreeNameByManufactName()
        {
            string query = @"
SELECT
    o.agreename
    , o.idorder
	, do.name AS docopername
    , ISNULL(o.addstr4, '') AS ConstrComm
FROM fo_manufact_names AS mn
INNER JOIN orders AS o ON mn.fo_agreename = o.agreename
                    AND  mn.fo_notrelevant IS NULL
                    AND mn.fo_iddocoper = o.iddocoper
                    AND deleted IS NULL
INNER JOIN docoper AS do ON o.iddocoper = do.iddocoper
WHERE mn.fo_manufactname = @manufactname";

            using (SqlCommand command = new SqlCommand(query, dbinit.db))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@manufactname", _manufactName);
                try
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {

                        _agreeName = (string)reader["agreename"];
                        IdOrder = (int)reader["idorder"];
                        DocOperName = (string)reader["docopername"];
                        ConstrComm = (string)reader["ConstrComm"];
                    }
                    else
                    {
                        _agreeName = null;
                        IdOrder = -1;
                        DocOperName = null;
                    }
                }
                finally
                {
                    command.Connection.Close();
                }
            }
        }

        private void SetManufactNameByAgreeName()
        {
            string query = @"
SELECT
    mn.fo_manufactname AS manufactname
	, o.idorder
	, do.name AS docopername
    , ISNULL(o.addstr4, '') AS ConstrComm
FROM fo_manufact_names AS mn
INNER JOIN orders AS o ON mn.fo_agreename = o.agreename
                    AND  mn.fo_notrelevant IS NULL
                    AND mn.fo_iddocoper = o.iddocoper
                    AND o.deleted IS NULL
INNER JOIN docoper AS do ON o.iddocoper = do.iddocoper
WHERE mn.fo_agreename = @agreename";

            using (SqlCommand command = new SqlCommand(query, dbinit.db))
            {

                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@agreename", _agreeName);
                try
                {
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        _manufactName = (string)reader["manufactname"];
                        IdOrder = (int)reader["idorder"];
                        DocOperName = (string)reader["docopername"];
                        ConstrComm = (string)reader["ConstrComm"];
                    }
                    else
                    {
                        _manufactName = null;
                        IdOrder = -1;
                        DocOperName = null;
                    }
                }
                finally
                {

                    command.Connection.Close();
                }
            }
        }

    }


}
