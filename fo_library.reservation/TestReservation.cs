using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.Linq;
using Atechnology.DBConnections2;
using Atechnology.ecad;
using fo_library.Choosing;
using fo_library.reservation.Presenters;
using System.Windows.Forms;

namespace fo_library.reservation
{
    public static class TestReservation
    {
        public static void Start(int idorder)
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            dbinit.db = new SqlConnection("Data Source=sqlwindraw.fabrikon.ru;Initial Catalog=ecad_FO;User ID=windraw;Password=Ffff1234");
            dbconn._db = new dbconn();
            //dbconn.db = dbinit.db;
            Settings.People = PeopleStruct.GetPeople(dbconn._db, "n.fedorov", "Ffff1234");
            //Settings.People = PeopleStruct.GetPeople((
            //SqlConnection theConnection = new SqlConnection("Data Source=sqlwindraw.fabrikon.ru;Initial Catalog=ecad_FO;User ID=windraw;Password=Ffff1234");
            //SqlRepository repository = new SqlRepository();
            
            //repository.dbContext = new WindrawDbDataContext(dbinit.db);

            //PaymentMethodModel model = new PaymentMethodModel(repository,idorder);
            //PaymentMethodView view = new PaymentMethodView();
            //PaymentMethodPresenter presenter = new PaymentMethodPresenter(view, model);

            //List<SignValueChoosingPresenter<string>> presenters = new List<SignValueChoosingPresenter<string>>();

            //presenters.Add(PaymentMethodSignValueChoosingPresenter.CreatePresenter(repository, idorder));
            //presenters.Add(DepartmentSignValueChoosingPresenter.CreatePresenter(repository, idorder));

            //foreach (var presenter in presenters)
            //{
            //    presenter.ShowView();
            //}



            ReservationForm mainForm = new ReservationForm();
            PresenterContainer.CreatePresenters(mainForm, idorder);


            mainForm.ShowDialog();
            //Application.Run(mainForm);

           
        }
    }
}
