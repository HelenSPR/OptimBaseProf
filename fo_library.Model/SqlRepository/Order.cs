using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public partial class SqlRepository 
    {
        public IQueryable<order> Orders
        {
            get { return this.dbContext.orders; }
        }

        public bool UpdateOrder(order instance)
        {
            order cache = dbContext.orders.Where(o => o.idorder == instance.idorder).FirstOrDefault();
            if (cache != null)
            {
                dbContext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveOrder(int idorder)
        {
            order instance = dbContext.orders.FirstOrDefault<order>(o => o.idorder == idorder);
            if (instance != null)
            {
                dbContext.orders.DeleteOnSubmit(instance);
                dbContext.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
