using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public class SqlFnRepository
    {
        public WindrawFnDataContext FnContext { get; set; }

        public int GetDepartmentId(int userId)
        {
            return FnContext.fo_get_root_department(userId).Value;
        }
    }
}
