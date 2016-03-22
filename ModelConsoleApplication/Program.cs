using Atechnology.DBConnections2;
using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Model;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace ModelConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            dbinit.db = new SqlConnection("Data Source=sqlwindraw.fabrikon.ru;Initial Catalog=ecad_FO;User ID=windraw;Password=Ffff1234");
            //dbconn._db = new dbconn();
            //dbconn.db = dbinit.db;
            //Settings.People = PeopleStruct.GetPeople(dbconn._db, "n.fedorov", "Ffff1234");
            //Settings.People = PeopleStruct.GetPeople((
            //SqlConnection theConnection = new SqlConnection("Data Source=sqlwindraw.fabrikon.ru;Initial Catalog=ecad_FO;User ID=windraw;Password=Ffff1234");
            SqlRepository repository = new SqlRepository();

            repository.dbContext = new WindrawDbDataContext(dbinit.db);

            model model = repository.Models.FirstOrDefault(m => m.idorderitem == 1215498);



            Construction contraction = new Construction();


            contraction.ColorOut = "red";
            contraction.Load(Atechnology.Components.ZipArchiver.UnZip2(model.cls.ToArray()));
            //contraction.ColorOut = "red";
            //contraction.Save();
           clsModel cls = new clsModel(Atechnology.Components.ZipArchiver.UnZip2(model.classnative.ToArray()));

            //cls.ColorOutside.ColorName = cls.ColorInside.ColorName;
            //cls.ColorOutside.GroupName = cls.ColorInside.GroupName;

            
           

            ////cls.Save();

            //model.classnative = Atechnology.Components.ZipArchiver.Zip2(cls.Save());

            //repository.UpdateModel(model);
        }
    }
}
