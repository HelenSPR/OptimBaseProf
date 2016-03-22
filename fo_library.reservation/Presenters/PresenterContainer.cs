using Atechnology.DBConnections2;
using Atechnology.ecad.Document.DataSets;
using fo_library.Choosing;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.reservation.Presenters
{
    internal static class PresenterContainer
    {
        internal static void CreatePresenters(ReservationForm form, int idorder)
        {

            SqlRepository repository = new SqlRepository();
            repository.dbContext = new WindrawDbDataContext(dbinit.db);

            DepartmentPresenter presenter1 = new DepartmentPresenter(form, new DepartmentSignValueChoosingModel(repository, idorder));
            PaymentMethodPresenter presenter2 = new PaymentMethodPresenter(form, new PaymentMethodSignValueChoosingModel(repository, idorder));
            GlassCoverObjectPresenter presenter3 = new GlassCoverObjectPresenter(form, new GlassCoverObjectSignValueChoosingModel(repository, idorder));
            LoggiaRecomendationObjectPresenter presenter4 = new LoggiaRecomendationObjectPresenter(form, new LoggiaRecomendationObjectSignValueChoosingModel(repository, idorder));
            ApertureCountObjectPresenter presenter5 = new ApertureCountObjectPresenter(form, new ApertureCountObjectSignValueChoosingModel(repository, idorder));
            ApertureToGlazingCountObjectPresenter presenter6 = new ApertureToGlazingCountObjectPresenter(form, new ApertureToGlazingCountObjectSignValueChoosingModel(repository, idorder));
        }

        internal static void CreatePresenters(ReservationForm form, ds_order datasetOrder)
        {
            SqlRepository repository = new SqlRepository();
            repository.dbContext = new WindrawDbDataContext(dbinit.db);

            DepartmentPresenter presenter1 = new DepartmentPresenter(form, new DepartmentSignValueChoosingModelDataSet(repository, datasetOrder));
            PaymentMethodPresenter presenter2 = new PaymentMethodPresenter(form, new PaymentMethodSignValueChoosingModelDataSet(repository, datasetOrder));
            GlassCoverObjectPresenter presenter3 = new GlassCoverObjectPresenter(form, new GlassCoverObjectSignValueChoosingModelDataSet(repository, datasetOrder));
            LoggiaRecomendationObjectPresenter presenter4 = new LoggiaRecomendationObjectPresenter(form, new LoggiaRecomendationObjectSignValueChoosingModelDataSet(repository, datasetOrder));
            ApertureCountObjectPresenter presenter5 = new ApertureCountObjectPresenter(form, new ApertureCountObjectSignValueChoosingModelDataSet(repository, datasetOrder));
            ApertureToGlazingCountObjectPresenter presenter6 = new ApertureToGlazingCountObjectPresenter(form, new ApertureToGlazingCountObjectSignValueChoosingModelDataSet(repository, datasetOrder));
        }
    }
}
