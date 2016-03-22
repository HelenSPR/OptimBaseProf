using fo_library.Choosing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.reservation
{
    public partial class ReservationForm : Form,
        IDepartmentSignValueChoosingView,
        IPaymentMethodSignValueChoosingView,
        IGlassCoverMethodSignValueChoosingView,
        ILoggiaRecomendationMethodSignValueChoosingView,
        IApertureCountMethodSignIntValueChoosingView,
        IApertureToGlazingCountMethodSignIntValueChoosingView
    {
        public ReservationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        // Отдел
        #region DepartmentSignValueChoosing

        public event EventHandler<EventArg<string>> DepartmentSignValueChosen;

        public void SetDepartmentValues(string[] signValues, string selectedSignValue)
        {
            this._BindingSourceDepartment.DataSource = signValues;

            if (selectedSignValue != null)
            {
                _BindingSourceDepartment.Position = Array.IndexOf(signValues, selectedSignValue);
            }
        }

        public void SetDepartmentActionName(string actionName)
        {
            this._LblDepartment.Text = actionName;
        }

        #endregion DepartmentSignValueChoosing

        // Способ облаты
        #region PaymentMethodSignValueChoosing

        public event EventHandler<EventArg<string>> PaymentMethodSignValueChosen;

        public void SetPaymentMethodValues(string[] signValues, string selectedSignValue)
        {
            this._BindingSourcePaymentMethod.DataSource = signValues;

            if (selectedSignValue != null)
            {
                _BindingSourcePaymentMethod.Position = Array.IndexOf(signValues, selectedSignValue);
            }
        }

        public void SetPaymentMethodActionName(string actionName)
        {
            this._LblPaymentMethod.Text = actionName;
        }

        #endregion PaymentMethodSignValueChoosing

        // Способ остекления
        #region GlassCoverMethodSignValueChoosing

        public event EventHandler<EventArg<string>> GlassCoverMethodChosen;

        public void SetGlassCoverMethodValues(string[] signValues, string selectedSignValue)
        {
            this._BindingSourceGlassCoverObject.DataSource = signValues;

            if (selectedSignValue != null)
            {
                _BindingSourceGlassCoverObject.Position = Array.IndexOf(signValues, selectedSignValue);
            }
        }

        public void SetGlassCoverMethodActionName(string actionName)
        {
            this._LblGlassCoverMethod.Text = actionName;
        }

        #endregion GlassCoverMethodSignValueChoosing

        // Рекомендация остеклить лоджию
        #region LoggiaRecomendationMethodSignValueChoosing

        public event EventHandler<EventArg<string>> LoggiaRecomendationMethodChosen;

        public void SetLoggiaRecomendationMethodValues(string[] signValues, string selectedSignValue)
        {
            this._BindingSourceLoggiaRecomendationObject.DataSource = signValues;

            if (selectedSignValue != null)
            {
                _BindingSourceLoggiaRecomendationObject.Position = Array.IndexOf(signValues, selectedSignValue);
            }
        }

        public void SetLoggiaRecomendationMethodActionName(string actionName)
        {
            this._LblLoggiaRecomendationMethod.Text = actionName;
        }

        #endregion LoggiaRecomendationMethodSignValueChoosing

        // Всего проемов в квартире
        #region ApertureCountMethodSignValueChoosing

        public event EventHandler<EventArg<decimal>> ApertureCountMethodChosen;

        public void SetApertureCountMethodValue(decimal selectedSignIntValue)
        {
            this._NumUpDownApertureCountObject.Value = selectedSignIntValue;
        }

        public void SetApertureCountMethodActionName(string actionName)
        {
            this._LblApertureCountMethod.Text = actionName;
        }

        #endregion ApertureCountMethodSignValueChoosing

        // Осталось остеклить проемов
        #region ApertureToGlazingCountMethodSignValueChoosing

        public event EventHandler<EventArg<decimal>> ApertureToGlazingCountMethodChosen;

        public void SetApertureToGlazingCountMethodValue(decimal selectedSignIntValue)
        {
            this._NumUpDownApertureToGlazingCountObject.Value = selectedSignIntValue;
        }

        public void SetApertureToGlazingCountMethodActionName(string actionName)
        {
            this._LblApertureToGlazingCountMethod.Text = actionName;
        }

        #endregion ApertureToGlazingCountMethodSignValueChoosing


        private void _BtnApply_Click(object sender, EventArgs e)
        {
            var handler = this.DepartmentSignValueChosen;
            if (handler != null)
            {
                handler(null, new EventArg<string>(this._BindingSourceDepartment.Current as string));
            }

            handler = this.PaymentMethodSignValueChosen;
            if (handler != null)
            {
                handler(null, new EventArg<string>(this._BindingSourcePaymentMethod.Current as string));
            }

            handler = this.GlassCoverMethodChosen;
            if (handler != null)
            {
                handler(null, new EventArg<string>(this._BindingSourceGlassCoverObject.Current as string));
            }

            handler = this.LoggiaRecomendationMethodChosen;
            if (handler != null)
            {
                handler(null, new EventArg<string>(this._BindingSourceLoggiaRecomendationObject.Current as string));
            }

            if (this.ApertureCountMethodChosen != null)
            {
                this.ApertureCountMethodChosen(null, new EventArg<decimal>(this._NumUpDownApertureCountObject.Value));
            }

            if (this.ApertureToGlazingCountMethodChosen != null)
            {
                this.ApertureToGlazingCountMethodChosen(null, new EventArg<decimal>(this._NumUpDownApertureToGlazingCountObject.Value));
            }
           
        }

    }
}
