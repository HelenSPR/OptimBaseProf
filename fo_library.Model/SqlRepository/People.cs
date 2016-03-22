using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public partial class SqlRepository
    {
        public IQueryable<people> People
        {
            get { return this.dbContext.peoples; }
        }

        public people CurrentUser
        {
            get
            {
                return this.People.Single(p => p.idpeople == Atechnology.ecad.Settings.idpeople);
            }
        }
    }
}
