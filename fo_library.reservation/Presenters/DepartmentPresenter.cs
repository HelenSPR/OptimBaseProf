using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fo_library.Choosing;

namespace fo_library.reservation.Presenters
{
    internal class DepartmentPresenter
    {
        private IDepartmentSignValueChoosingView _View;
        private ISignValueChoosingModel<string> _Model;

        public DepartmentPresenter(IDepartmentSignValueChoosingView view, ISignValueChoosingModel<string> model)
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
            this._View.DepartmentSignValueChosen += _View_DepartmentSignValueChosen;
        }

        private void DisableEventHandler()
        {
            this._View.DepartmentSignValueChosen -= _View_DepartmentSignValueChosen;
        }

        private void SetViewActionName()
        {
            _View.SetDepartmentActionName(this._Model.SignName);
        }

        private void SetSignValues()
        {
            _View.SetDepartmentValues(this._Model.SignValues, this._Model.SelectedSignValue);
        }

        void _View_DepartmentSignValueChosen(object sender, EventArg<string> e)
        {
            this._Model.SelectedSignValue = e.Value;
        }
    }
}
