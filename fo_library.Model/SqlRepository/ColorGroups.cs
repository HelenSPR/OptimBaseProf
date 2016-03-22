using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public partial class SqlRepository
    {
        public IQueryable<colorgroup> ColorGroups
        {
            get { return this.dbContext.colorgroups; }
        }
    }
}
