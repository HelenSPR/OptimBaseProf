using fo_library.Choosing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.reservation.Presenters
{
    internal class ApertureCountObjectPresenter
    {
        private IApertureCountMethodSignIntValueChoosingView _View;
        private ISignValueChoosingModel<decimal> _Model;

        public ApertureCountObjectPresenter(IApertureCountMethodSignIntValueChoosingView view, ISignValueChoosingModel<decimal> model)
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
            this._View.ApertureCountMethodChosen += _View_ApertureCountMethodChosen;
        }

        void _View_ApertureCountMethodChosen(object sender, EventArg<decimal> e)
        {
            this._Model.SelectedSignValue = e.Value;
        }

        private void SetSignValues()
        {
            _View.SetApertureCountMethodValue(this._Model.SelectedSignValue);
        }

        private void SetViewActionName()
        {
            _View.SetApertureCountMethodActionName(this._Model.SignName);
        }
    }
}
