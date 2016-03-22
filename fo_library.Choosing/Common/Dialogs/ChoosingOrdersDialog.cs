using Atechnology.DBConnections2;
using fo_library.Choosing.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fo_library.Choosing.Common
{
    public class ChoosingOrdersDialog
    {

        public ChoosingOrdersDialog()
        {
            showDialogView = new ManufactnameXmlDialog();
        }
        public IChoosingOrdersIdDialogView showDialogView;

        public int[] OrderIdArray { get; private set; }

        public string TaskNumber { get; private set; }

        public DialogResult ShowDialog()
        {
            DialogResult dr = showDialogView.ShowDialog();

            if (dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                OrderIdArray = showDialogView.OrderIdArray;
                TaskNumber = showDialogView.TaskNumber;

                return DialogResult.OK;
                
            }

            return dr;
        }
    }
}
