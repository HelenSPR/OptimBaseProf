using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace fo_library.Model
{
    public partial class SqlRepository
    {
        public IQueryable<sign> Signs
        {
            get { return this.dbContext.signs; }
        }

        public bool UpdateSign(sign instance)
        {
            sign cache = dbContext.signs.Where(s => s.idsign == instance.idsign).FirstOrDefault();
            if (cache != null)
            {
                dbContext.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveSign(int idsign)
        {
            sign instance = dbContext.signs.FirstOrDefault(s => s.idsign == idsign);
            if (instance != null)
            {
                dbContext.signs.DeleteOnSubmit(instance);
                dbContext.SubmitChanges();
                return true;
            }

            return false;
        }
    }
}
