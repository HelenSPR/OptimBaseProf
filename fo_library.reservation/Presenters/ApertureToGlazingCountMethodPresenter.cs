using fo_library.Choosing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.reservation.Presenters
{
    internal class ApertureToGlazingCountObjectPresenter
    {
        private IApertureToGlazingCountMethodSignIntValueChoosingView _View;
        private ISignValueChoosingModel<decimal> _Model;

        public ApertureToGlazingCountObjectPresenter(IApertureToGlazingCountMethodSignIntValueChoosingView view, ISignValueChoosingModel<decimal> model)
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
            this._View.ApertureToGlazingCountMethodChosen += _View_ApertureToGlazingCountMethodChosen;
        }

        void _View_ApertureToGlazingCountMethodChosen(object sender, EventArg<decimal> e)
        {
            this._Model.SelectedSignValue = e.Value;
        }

        private void SetSignValues()
        {
            _View.SetApertureToGlazingCountMethodValue(this._Model.SelectedSignValue);
        }

        private void SetViewActionName()
        {
            _View.SetApertureToGlazingCountMethodActionName(this._Model.SignName);
        }
    }
}
