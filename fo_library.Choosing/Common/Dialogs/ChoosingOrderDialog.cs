using Atechnology.DBConnections2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Choosing.Common
{
    public partial class ChoosingOrderDialog : Form
    {
        public int[] OrderIdArray { get; private set; }
        public ChoosingOrderDialog()
        {
            InitializeComponent();
        }

        private void _BtnOk_Click(object sender, EventArgs e)
        {

            dbconn._db.command.CommandText = "SELECT idorder FROM orders WHERE agreename = @agreename AND deleted IS NULL";
            dbconn._db.command.Parameters.AddWithValue("@agreename", textBox1.Text);
            DataTable resultTable = new DataTable();
            dbconn._db.adapter.Fill(resultTable);


            OrderIdArray = new int[resultTable.Rows.Count];

            for (int i = 0; i < OrderIdArray.Length; i++)
            {
                OrderIdArray[i] = (int)resultTable.Rows[i][0];
            }

            dbconn._db.command.Parameters.Clear();
        }
    }
}
