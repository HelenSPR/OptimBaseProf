using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    /// <summary>
    /// Модель для выбора строкового значения(strvalue) признака
    /// </summary>
    public abstract class SignStringValueChoosingModel : ISignValueChoosingModel<string>
    {
        protected readonly IRepository _Repository;
       

        #region Props and their private fields

        private ordersign OrderSign;
       
        private readonly sign Sign;
       
        private readonly order Order;
      
        #endregion Props and their private fields


        #region Interface Implementations

        public string SignName
        {
            get
            {
                return Sign.name;
            }
        }

        public string[] SignValues
        {
            get
            {
                return SignValueArray.Select(sv => sv.strvalue).ToArray();
            }
        }

        private signvalue[] SignValueArray
        {
            get
            {
                return _signvalueArray ?? (_signvalueArray = _Repository.SignValues.Where(sv => sv.sign == this.Sign).ToArray());
            }
        }

        private signvalue[] _signvalueArray;



        public string SelectedSignValue
        {
            get
            {
                if (OrderSign != null)
                    return OrderSign.signvalue.strvalue;
                else
                    return GetDefaultSignValue();
            }

            set
            {
                people currentUser = _Repository.CurrentUser;

                if (this.OrderSign == null)
                {
                   
                    this.OrderSign = new ordersign();

                    this.OrderSign.sign = this.Sign;

                    this.OrderSign.order = this.Order;

                    this.OrderSign.people = currentUser;

                    this.OrderSign.signvalue = SignValueArray.Single(sv => sv.strvalue == value);

                    this.OrderSign.dtcreate = DateTime.Now;

                    this.OrderSign.comment = string.Format("Создан пользователем {0} {1}.", currentUser.lastname, currentUser.name);

                    this._Repository.CreateOrderSign(this.OrderSign);

                }
                else
                {
                    // Не обновлять если строе значение равно новому)
                    if (OrderSign.signvalue.strvalue != value)
                    {
                        this.OrderSign.signvalue = SignValueArray.Single(sv => sv.strvalue == value);
                        this.OrderSign.comment = string.Format("Изменен пользователем {0} {1}. Дата изменения: {2}", currentUser.lastname, currentUser.name, DateTime.Now.ToString());
                        this._Repository.UpdateOrderSign(this.OrderSign);
                    }
                }
            }
        }
        #endregion Interface Implementations

        protected abstract string GetDefaultSignValue();

        public SignStringValueChoosingModel(IRepository repository, int idorder, int idsign)
        {
            this._Repository = repository;
           

            this.Sign = _Repository.Signs.First(s => s.idsign == idsign);
            this.Order = _Repository.Orders.First(o => o.idorder == idorder);
            this.OrderSign = _Repository.OrdersSigns.SingleOrDefault(os => os.idsign == idsign && os.idorder == idorder);
        }

    }


    /// <summary>
    /// Модель для выбора числового значения(intvalue) признака
    /// </summary>
    public abstract class SignIntValueChoosingModel : ISignValueChoosingModel<decimal>
    {
        protected readonly IRepository _Repository;


        #region Props and their private fields

        private ordersign OrderSign;

        private readonly sign Sign;

        private readonly order Order;

        #endregion Props and their private fields


        #region Interface Implementations

        public string SignName
        {
            get
            {
                return Sign.name;
            }
        }

        public decimal[] SignValues
        {
            get
            {
                return SignValueArray.Select(sv => (decimal)sv.intvalue).ToArray();
            }
        }

        private signvalue[] SignValueArray
        {
            get
            {
                return _signvalueArray ?? (_signvalueArray = _Repository.SignValues.Where(sv => sv.sign == this.Sign).ToArray());
            }
        }

        private signvalue[] _signvalueArray;

        public decimal SelectedSignValue
        {
            get
            {
                if (OrderSign != null)
                    return OrderSign.intvalue ?? GetDefaultSignIntValue();
                else
                    return GetDefaultSignIntValue();
            }

            set
            {
                people currentUser = _Repository.CurrentUser;

                if (this.OrderSign == null)
                {

                    this.OrderSign = new ordersign();

                    this.OrderSign.sign = this.Sign;

                    this.OrderSign.order = this.Order;

                    this.OrderSign.people = currentUser;

                    this.OrderSign.intvalue = value;

                    // this.OrderSign.signvalue = SignValueArray.Single(sv => sv.strvalue == value);

                    this.OrderSign.dtcreate = DateTime.Now;

                    this.OrderSign.comment = string.Format("Создан пользователем {0} {1}.", currentUser.lastname, currentUser.name);

                    this._Repository.CreateOrderSign(this.OrderSign);

                }
                else
                {
                    // Не обновлять если старое значение равно новому)
                    if (OrderSign.intvalue == null || OrderSign.intvalue != value)
                    {
                        this.OrderSign.intvalue = value;
                        this.OrderSign.comment = string.Format("Изменен пользователем {0} {1}. Дата изменения: {2}", currentUser.lastname, currentUser.name, DateTime.Now.ToString());
                        this._Repository.UpdateOrderSign(this.OrderSign);
                    }
                }
            }
        }
        
        #endregion Interface Implementations

        protected abstract decimal GetDefaultSignIntValue();


        public SignIntValueChoosingModel(IRepository repository, int idorder, int idsign)
        {
            this._Repository = repository;

            this.Sign = _Repository.Signs.First(s => s.idsign == idsign);
            this.Order = _Repository.Orders.First(o => o.idorder == idorder);
            this.OrderSign = _Repository.OrdersSigns.SingleOrDefault(os => os.idsign == idsign && os.idorder == idorder);
        }





    }
}
