using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Atechnology.DBConnections2;

namespace fo_library.Model
{
    public partial class SqlRepository
    {
        public IQueryable<ordersign> OrdersSigns
        {
            get
            {
                return this.dbContext.ordersigns;
            }
        }

        public bool CreateOrderSign(ordersign instance)
        {
            if (instance.idordersign == 0)
            {
                instance.idordersign = dbconn.GetGenId("gen_ordersign");
                dbContext.ordersigns.InsertOnSubmit(instance);
                dbContext.SubmitChanges();
              
            }
            return false;
        }

        public bool UpdateOrderSign(ordersign instance)
        {
            ordersign cache = dbContext.ordersigns.FirstOrDefault(os => os.idordersign == instance.idordersign);

            if (cache != null)
            {
                dbContext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveOrderSign(int idordersign)
        {
            ordersign instance = dbContext.ordersigns.FirstOrDefault(os => os.idordersign == idordersign);

            if (instance != null)
            {
                dbContext.ordersigns.DeleteOnSubmit(instance);
                dbContext.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
