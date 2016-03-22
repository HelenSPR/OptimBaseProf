using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public partial class SqlRepository
    {
        public IQueryable<color> Colors
        {
            get { return this.dbContext.colors; }
        }
    }
}
