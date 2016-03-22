using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public partial class SqlRepository
    {
        public IQueryable<model> Models
        {
            get { return this.dbContext.models; }
        }

        public bool UpdateModel(model instance)
        {
            model cache = dbContext.models.Where(m => m.idmodel == instance.idmodel).FirstOrDefault();
            if (cache != null)
            {
                dbContext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveModel(int idmodel)
        {
            model instance = dbContext.models.FirstOrDefault(m => m.idmodel == idmodel);
            if (instance != null)
            {
                dbContext.models.DeleteOnSubmit(instance);
                dbContext.SubmitChanges();
                return true;
            }
            return false;

        }
    }
}
