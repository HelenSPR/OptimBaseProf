using Atechnology.DBConnections2;
using Atechnology.ecad.Document.DataSets;
using fo_library.Choosing;
using fo_library.Model;
using fo_library.reservation.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.reservation
{
    public static class Reservation
    {
        public static DialogResult Start(int idorder)
        {
            ReservationForm form = new ReservationForm();
            form.Text += string.Format(" (#{0})", idorder);
            PresenterContainer.CreatePresenters(form, idorder);
          
            return form.ShowDialog();
        }

        public static DialogResult Start(ds_order datasetOrder)
        {
            ReservationForm form = new ReservationForm();
            if (datasetOrder.orders.Rows != null && datasetOrder.orders.Rows.Count > 0) {
                form.Text += string.Format(" (#{0})", datasetOrder.orders.Rows[0]["idorder"].ToString());
            }
            PresenterContainer.CreatePresenters(form, datasetOrder);

            return form.ShowDialog();
        }
    }
}
