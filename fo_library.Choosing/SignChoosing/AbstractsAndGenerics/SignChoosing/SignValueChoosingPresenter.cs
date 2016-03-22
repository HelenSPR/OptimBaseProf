using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public abstract class SignValueChoosingPresenter<TSignValue>
    {
        private ISignValueChoosingForm<TSignValue> _View;
        private ISignValueChoosingModel<TSignValue> _Model;

        public SignValueChoosingPresenter(ISignValueChoosingForm<TSignValue> view, ISignValueChoosingModel<TSignValue> model)
        {
            this._View = view;
            this._Model = model;

            this.InitializeView();
        }

        private void InitializeView()
        {
            #region Настройка формы

            this.SetTitleView();
            this.SetViewActionName();
            this.SetSignValues();

            #endregion

            this.EnableEventHandler();
        }

      
        private void EnableEventHandler()
        {
            this._View.SignValueChosen += _View_SignValueChosen;
        }

        private void DisableEventHandler()
        {
            this._View.SignValueChosen -= _View_SignValueChosen;
        }

        private void SetSignValues()
        {
            _View.SetSignValues(this._Model.SignValues, this._Model.SelectedSignValue);
        }

        private void SetTitleView()
        {
            _View.SetTitle(this._Model.SignName);
        }

        private void SetViewActionName()
        {
            _View.SetViewActionName(string.Format("Выберите {0}:", this._Model.SignName.ToLower(System.Globalization.CultureInfo.CurrentCulture)));
        }

        public void ShowView()
        {
            this._View.ShowView();
        }

        #region Event Handlers

        private void _View_SignValueChosen(object sender, EventArg<TSignValue> e)
        {
            this._Model.SelectedSignValue = e.Value;
        }

        #endregion

       


    }
}
