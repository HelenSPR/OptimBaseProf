using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class ApertureCountObjectSignValueChoosingModel : SignIntValueChoosingModel
    {
        public ApertureCountObjectSignValueChoosingModel(IRepository repository, int idorder)
            : base(repository, idorder, 204)
        {
        }

        protected override decimal GetDefaultSignIntValue()
        {
            return (decimal)_Repository.SignValues.First(sv => sv.idsignvalue == 697).intvalue;
        }
    }
}
