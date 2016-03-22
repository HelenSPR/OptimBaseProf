using Atechnology.DBConnections2;
using Atechnology.ecad.Document.DataSets;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Choosing
{
    /// <summary>
    /// Модель для выбора строкового значения(strvalue) признака
    /// </summary>
    public abstract class SignStringValueChoosingModelDataSet : ISignValueChoosingModel<string>
    {
        protected readonly IRepository _Repository;

        protected readonly ds_order datasetOrder;
        #region Props and their private fields


        private ds_order.docsignRow OrderSign1;


        private readonly sign Sign;


        private readonly ds_order.ordersRow Order1;


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

        //--------------Переделавание реализации интерфейса

        public string SelectedSignValue
        {
            get
            {
                if (OrderSign1 != null)
                    return OrderSign1.signvalue_str;
                else
                    return GetDefaultSignValue();
            }

            set
            {
                people currentUser = _Repository.CurrentUser;

                if (this.OrderSign1 == null)
                {

                    this.OrderSign1 = this.datasetOrder.docsign.NewdocsignRow();

                    this.OrderSign1.idsign = this.Sign.idsign;

                    this.OrderSign1.sign_name = this.Sign.name;

                    this.OrderSign1.iddoc = this.Order1.idorder;

                    this.OrderSign1.idpeople = currentUser.idpeople;

                    this.OrderSign1.signvalue_str = SignValueArray.Single(sv => sv.strvalue == value).strvalue;

                    this.OrderSign1.idsignvalue = SignValueArray.Single(sv => sv.strvalue == value).idsignvalue;

                    this.OrderSign1.dtcreate = DateTime.Now;

                    this.OrderSign1.iddocsign = dbconn.GetGenId("gen_ordersign"); ;

                    this.datasetOrder.docsign.AdddocsignRow(this.OrderSign1);

                }
                else
                {
                    // Не обновлять если строе значение равно новому)
                    if (this.OrderSign1.signvalue_str != value)
                    {
                        this.OrderSign1.signvalue_str = SignValueArray.Single(sv => sv.strvalue == value).strvalue;

                        this.OrderSign1.idsignvalue = SignValueArray.Single(sv => sv.strvalue == value).idsignvalue;

                        this.OrderSign1.comment = string.Format("Изменен {0} {1}({2}). {3}", currentUser.lastname, currentUser.name, currentUser.idpeople, DateTime.Now.ToString());
                    }
                }


            }
        }
        #endregion Interface Implementations

        protected abstract string GetDefaultSignValue();


        public SignStringValueChoosingModelDataSet(IRepository repository, ds_order dataset, int idsign)
        {
            this._Repository = repository;

            this.Sign = _Repository.Signs.First(s => s.idsign == idsign);

            this.datasetOrder = dataset;

            this.Order1 = (ds_order.ordersRow)dataset.orders.Rows[0];

            this.OrderSign1 = ((DataTable)dataset.docsign).AsEnumerable().FirstOrDefault(docs => docs.Field<int>("idsign") == idsign) as ds_order.docsignRow;
        }

    }

    /// <summary>
    /// Модель для выбора числового значения(intvalue) признака
    /// </summary>
    public abstract class SignIntValueChoosingModelDataSet : ISignValueChoosingModel<decimal>
    {
        protected readonly IRepository _Repository;

        protected readonly ds_order datasetOrder;
        
        #region Props and their private fields

        private ds_order.docsignRow OrderSign1;

        private readonly sign Sign;

        private readonly ds_order.ordersRow Order1;

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

        //--------------Переделавание реализации интерфейса

        public decimal SelectedSignValue
        {
            get
            {
                if (OrderSign1 != null)
                    return (!OrderSign1.IsintvalueNull() ? OrderSign1.intvalue : GetDefaultSignIntValue());
                else
                    return GetDefaultSignIntValue();
            }

            set
            {
                people currentUser = _Repository.CurrentUser;

                if (this.OrderSign1 == null)
                {

                    this.OrderSign1 = this.datasetOrder.docsign.NewdocsignRow();

                    this.OrderSign1.idsign = this.Sign.idsign;

                    this.OrderSign1.sign_name = this.Sign.name;

                    this.OrderSign1.iddoc = this.Order1.idorder;

                    this.OrderSign1.idpeople = currentUser.idpeople;

                    this.OrderSign1.intvalue = value;

                    this.OrderSign1.dtcreate = DateTime.Now;

                    this.OrderSign1.iddocsign = dbconn.GetGenId("gen_ordersign"); ;

                    this.datasetOrder.docsign.AdddocsignRow(this.OrderSign1);

                }
                else
                {
                    // Не обновлять если строе значение равно новому)
                    if (this.OrderSign1.IsintvalueNull() || this.OrderSign1.intvalue != value)
                    {
                        this.OrderSign1.intvalue = value;

                        this.OrderSign1.comment = string.Format("Изменен {0} {1}({2}). {3}", currentUser.lastname, currentUser.name, currentUser.idpeople, DateTime.Now.ToString());
                    }
                }


            }
        }
        
        #endregion Interface Implementations

        protected abstract decimal GetDefaultSignIntValue();


        public SignIntValueChoosingModelDataSet(IRepository repository, ds_order dataset, int idsign)
        {
            this._Repository = repository;

            this.Sign = _Repository.Signs.First(s => s.idsign == idsign);

            this.datasetOrder = dataset;

            this.Order1 = (ds_order.ordersRow)dataset.orders.Rows[0];

            this.OrderSign1 = ((DataTable)dataset.docsign).AsEnumerable().FirstOrDefault(docs => docs.Field<int>("idsign") == idsign) as ds_order.docsignRow;
        }





    }
}
