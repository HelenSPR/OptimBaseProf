using Atechnology.ecad.Document.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Validation.PositionValidation
{
    internal class PositionValidator
    {
        private OrderCalcPosition _orderCalcPosition;

        public PositionValidator(OrderCalcPosition orderCalcPosition)
        {
            if (orderCalcPosition == null)
            {
                OrderCalcPositionNullReferenceException exception = new OrderCalcPositionNullReferenceException("Ссылка на объект OrderCalcPosition не указывает на экземпляр объекта.");
                exception.Source = this.GetType().FullName;
                throw exception;
            }

            if (orderCalcPosition.NativeModel == null)
            {
                NativeModelNullReferenceException exception = new NativeModelNullReferenceException("Ссылка OrderCalcPosition.NativeModel на объект clsModel не указывает на экземпляр объекта.");
                exception.Source = this.GetType().FullName;
                throw exception;
            }

            if (orderCalcPosition.CalcModel == null)
            {
                CalcModelNullReferenceException exception = new CalcModelNullReferenceException("Ссылка OrderCalcPositioni.CalcModel на объект Constuction не указывает на экземпляр объекта.");
                exception.Source = this.GetType().FullName;
                throw exception;
            }

            this._orderCalcPosition = orderCalcPosition;
        }


        internal void AllVaidate()
        {
            // Список сообщений. Если какая нибудь валиция возвращает сообщений,
            // то это сообщение добавляется в список сообщений
            var msgs = new List<string>();

            var msg = string.Empty;

            // валидация внешнего цвета профиля
            msg = OutsideColorValidate();
            if (!string.IsNullOrEmpty(msg))
                msgs.Add(msg);

            // вылидация внутреннего цвета профиля
            msg = InsideColorValidate();
            if (!string.IsNullOrEmpty(msg))
                msgs.Add(msg);

            int msgCount = msgs.Count;
            // список сообщений имеет сообщения - вывести их пользователю.
            if (msgCount > 0)
            {
                // установить изменения модели
                this._orderCalcPosition.SetModels();

                string message = string.Format("Для изделия в позиции №{0} произошли следующие изменения:", this._orderCalcPosition.ItemRow.numpos);
               
                for (int i = 0; i < msgCount; i++)
                {
                    message += string.Format("\r\n{0}.  {1}",(i+1),  msgs[i]);
                }

                MessageBox.Show(message);
            }
        }

        private string OutsideColorValidate()
        {
            OutsideColorValidator ocv = new OutsideColorValidator(this._orderCalcPosition);
            return ocv.Validate();
        }

        private string InsideColorValidate()
        {
            InsideColorValidator icv = new InsideColorValidator(this._orderCalcPosition);
            return icv.Validate();
        }
    }

   

}
