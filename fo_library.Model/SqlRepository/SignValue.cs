using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public partial class SqlRepository
    {

        public IQueryable<signvalue> SignValues
        {
            get
            {
                return this.dbContext.signvalues;
            }
        }

        public bool UpdateSignValue(signvalue instance)
        {
            signvalue cache = dbContext.signvalues.FirstOrDefault(sv => sv.idsignvalue == instance.idsignvalue);

            if (cache != null)
            {
                dbContext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveSignValue(int idsignvalue)
        {
            signvalue instance = dbContext.signvalues.FirstOrDefault(sv => sv.idsignvalue == idsignvalue);

            if (instance != null)
            {
                dbContext.signvalues.DeleteOnSubmit(instance);
                dbContext.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
