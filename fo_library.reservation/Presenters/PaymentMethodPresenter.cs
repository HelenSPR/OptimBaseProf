using fo_library.Choosing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.reservation.Presenters
{
    internal class PaymentMethodPresenter
    {
        private IPaymentMethodSignValueChoosingView _View;
        private ISignValueChoosingModel<string> _Model;

        public PaymentMethodPresenter(IPaymentMethodSignValueChoosingView view, ISignValueChoosingModel<string> model)
        {
            this._View = view;
            this._Model = model;

            this.InitializeView();
        }

        private void InitializeView()
        {
            this.SetViewActionName();
            this.SetSignValues();

            this.EnableEventHandler();
        }

        private void SetSignValues()
        {
            _View.SetPaymentMethodValues(this._Model.SignValues, this._Model.SelectedSignValue);
        }

        private void SetViewActionName()
        {
            _View.SetPaymentMethodActionName(this._Model.SignName);
        }

        private void EnableEventHandler()
        {
            this._View.PaymentMethodSignValueChosen +=_View_PaymentMethodSignValueChosen;
        }

        private void DisableEventHandler()
        {
            this._View.PaymentMethodSignValueChosen -= _View_PaymentMethodSignValueChosen;
        }

        private void _View_PaymentMethodSignValueChosen(object sender, EventArg<string> e)
        {
            this._Model.SelectedSignValue = e.Value;
        }
    }
}
