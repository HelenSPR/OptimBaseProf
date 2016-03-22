using Atechnology.DBConnections2;
using Atechnology.ecad.Calc.winDraw;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Data.Linq;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using fo_library.Correspondence.ProfileColors;

namespace SettingTestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            dbinit.db = new SqlConnection("Data Source=sqlwindraw.fabrikon.ru;Initial Catalog=ecad_FO;User ID=windraw;Password=Ffff1234");
            dbconn._db = new dbconn();
           

           

           

            SettingCustomtableContainer container = SettingCustomtableContainer.CreateContainer();
            int defaultcolorId = container.GetDefaultColorIdByProfileId(1);
            int[] colorgroupIds = container.GetColorGroupIdsByProfileId(1);
        }
    }
}
