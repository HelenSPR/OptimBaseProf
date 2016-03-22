using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class ApertureToGlazingCountObjectSignValueChoosingModel : SignIntValueChoosingModel
    {
        public ApertureToGlazingCountObjectSignValueChoosingModel(IRepository repository, int idorder)
            : base(repository, idorder, 197)
        {
        }

        protected override decimal GetDefaultSignIntValue()
        {
            return (decimal)_Repository.SignValues.First(sv => sv.idsignvalue == 696).intvalue;
        }
    }
}
