using fo_library.Choosing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.reservation.Presenters
{
    internal class LoggiaRecomendationObjectPresenter
    {
        private ILoggiaRecomendationMethodSignValueChoosingView _View;
        private ISignValueChoosingModel<string> _Model;

        public LoggiaRecomendationObjectPresenter(ILoggiaRecomendationMethodSignValueChoosingView view, ISignValueChoosingModel<string> model)
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

        private void EnableEventHandler()
        {
            this._View.LoggiaRecomendationMethodChosen += _View_LoggiaRecomendationMethodChosen;
        }

        void _View_LoggiaRecomendationMethodChosen(object sender, EventArg<string> e)
        {
            this._Model.SelectedSignValue = e.Value;
        }

        private void SetSignValues()
        {
            _View.SetLoggiaRecomendationMethodValues(this._Model.SignValues, this._Model.SelectedSignValue);
        }

        private void SetViewActionName()
        {
            _View.SetLoggiaRecomendationMethodActionName(this._Model.SignName);
        }
    }
}
