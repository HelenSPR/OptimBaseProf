using Atechnology.DBConnections2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Model
{
    public static class ModelSettings
    {
        public static IRepository CurrentRepository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new SqlRepository();
                    _repository.dbContext = new WindrawDbDataContext(dbinit.db);
                }
                return _repository;
            }
        }

        private static SqlRepository _repository;
    }
}
