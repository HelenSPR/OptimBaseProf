using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public interface ISignValueChoosingView<TSignValue>
    {
        event EventHandler<EventArg<TSignValue>> SignValueChosen;

        void SetSignValues(TSignValue[] signValues, TSignValue selectedSignValue);

        void SetViewActionName(string actionName);

    }

    public interface IDepartmentSignValueChoosingView
    {
        event EventHandler<EventArg<string>> DepartmentSignValueChosen;

        void SetDepartmentValues(string[] signValues, string selectedSignValue);

        void SetDepartmentActionName(string actionName);
    }

    public interface IPaymentMethodSignValueChoosingView
    {
        event EventHandler<EventArg<string>> PaymentMethodSignValueChosen;

        void SetPaymentMethodValues(string[] signValues, string selectedSignValue);

        void SetPaymentMethodActionName(string actionName);
    }

    public interface IGlassCoverMethodSignValueChoosingView
    {
        event EventHandler<EventArg<string>> GlassCoverMethodChosen;

        void SetGlassCoverMethodValues(string[] signValues, string selectedSignValue);

        void SetGlassCoverMethodActionName(string actionName);
    }

    public interface ILoggiaRecomendationMethodSignValueChoosingView
    {
        event EventHandler<EventArg<string>> LoggiaRecomendationMethodChosen;

        void SetLoggiaRecomendationMethodValues(string[] signValues, string selectedSignValue);

        void SetLoggiaRecomendationMethodActionName(string actionName);
    }

    public interface IApertureCountMethodSignIntValueChoosingView
    {
        event EventHandler<EventArg<decimal>> ApertureCountMethodChosen;

        void SetApertureCountMethodValue(decimal selectedSignIntValue);

        void SetApertureCountMethodActionName(string actionName);
    }

    public interface IApertureToGlazingCountMethodSignIntValueChoosingView
    {
        event EventHandler<EventArg<decimal>> ApertureToGlazingCountMethodChosen;

        void SetApertureToGlazingCountMethodValue(decimal selectedSignIntValue);

        void SetApertureToGlazingCountMethodActionName(string actionName);
    }



    public class EventArg<T> : EventArgs
    {
        private readonly T _value;

        public EventArg(T value)
        {
            _value = value;
        }

        public T Value
        {
            get { return _value; }
        }

    }

}
