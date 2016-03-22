using Atechnology.DBConnections2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public partial class SqlRepository : IRepository
    {
        public WindrawDbDataContext dbContext { get; set; }
    }
}
