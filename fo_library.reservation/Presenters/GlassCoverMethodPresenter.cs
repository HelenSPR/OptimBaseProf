using fo_library.Choosing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.reservation.Presenters
{
    internal class GlassCoverObjectPresenter
    {
        private IGlassCoverMethodSignValueChoosingView _View;
        private ISignValueChoosingModel<string> _Model;

        public GlassCoverObjectPresenter(IGlassCoverMethodSignValueChoosingView view, ISignValueChoosingModel<string> model)
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
            this._View.GlassCoverMethodChosen += _View_GlassCoverMethodChosen;
        }

        void _View_GlassCoverMethodChosen(object sender, EventArg<string> e)
        {
            this._Model.SelectedSignValue = e.Value;
        }

        private void SetSignValues()
        {
            _View.SetGlassCoverMethodValues(this._Model.SignValues, this._Model.SelectedSignValue);
        }

        private void SetViewActionName()
        {
            _View.SetGlassCoverMethodActionName(this._Model.SignName);
        }
    }
}
