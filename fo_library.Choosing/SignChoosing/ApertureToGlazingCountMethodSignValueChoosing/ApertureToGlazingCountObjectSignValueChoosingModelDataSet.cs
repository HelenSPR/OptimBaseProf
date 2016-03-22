using Atechnology.ecad.Document.DataSets;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class ApertureToGlazingCountObjectSignValueChoosingModelDataSet : SignIntValueChoosingModelDataSet
    {
        public ApertureToGlazingCountObjectSignValueChoosingModelDataSet(IRepository repository, ds_order dataset)
            : base(repository, dataset, 197)
        {
        }
    
        protected override decimal GetDefaultSignIntValue()
        {
            return (decimal)_Repository.SignValues.First(sv => sv.idsignvalue == 696).intvalue;
        }
    }

}
