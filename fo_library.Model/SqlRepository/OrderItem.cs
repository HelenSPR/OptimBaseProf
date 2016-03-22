using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public partial class SqlRepository
    {
        public IQueryable<orderitem> OrderItems
        {
            get { return this.dbContext.orderitems; }
        }

        public bool UpdateOrderItem(orderitem instance)
        {
            orderitem cache = dbContext.orderitems.Where(oi => oi.idorderitem == instance.idorderitem).FirstOrDefault();
            if (cache != null)
            {
                dbContext.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveOrderItem(int idorderitem)
        {
            orderitem instance = dbContext.orderitems.FirstOrDefault<orderitem>(oi => oi.idorderitem == idorderitem);
            if (instance != null)
            {
                dbContext.orderitems.DeleteOnSubmit(instance);
                dbContext.SubmitChanges();
                return true;
            }

            return false;
        }
    }
}
