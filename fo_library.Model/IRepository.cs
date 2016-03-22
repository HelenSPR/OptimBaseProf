using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public interface IRepository
    {
        #region Orders

        IQueryable<order> Orders { get; }

        bool UpdateOrder(order instance);

        bool RemoveOrder(int idorder);

        #endregion Orders

        #region OrderItem

        IQueryable<orderitem> OrderItems { get; }

        bool UpdateOrderItem(orderitem instance);

        bool RemoveOrderItem(int idorderitem);

        #endregion

        #region Model

        IQueryable<model> Models { get; }

        bool UpdateModel(model instance);

        bool RemoveModel(int idmodel);

        #endregion

        #region
        IQueryable<color> Colors { get; }
        #endregion

        #region
        IQueryable<colorgroup> ColorGroups { get; }
        #endregion

        #region Sign

        IQueryable<sign> Signs { get; }

       

        bool UpdateSign(sign instance);

        bool RemoveSign(int idsign);

        #endregion

        #region OrderSign

        IQueryable<ordersign> OrdersSigns { get; }

        bool CreateOrderSign(ordersign instance);

        bool UpdateOrderSign(ordersign instance);

        bool RemoveOrderSign(int idordersign);

        #endregion

        #region SignValue

        IQueryable<signvalue> SignValues { get; }

        bool UpdateSignValue(signvalue instance);

        bool RemoveSignValue(int idsignvalue);

        #endregion

        #region People

        IQueryable<people> People { get; }

         people CurrentUser { get; }

        #endregion

        #region Setting

        IQueryable<setting> Settings { get; }

        #endregion
    }
}
