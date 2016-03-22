using Atechnology.ecad.Document.DataSets;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class ApertureCountObjectSignValueChoosingModelDataSet : SignIntValueChoosingModelDataSet
    {
        public ApertureCountObjectSignValueChoosingModelDataSet(IRepository repository, ds_order dataset)
            : base(repository, dataset, 204)
        {
        }
    
        protected override decimal GetDefaultSignIntValue()
        {
            return (decimal)_Repository.SignValues.First(sv => sv.idsignvalue == 697).intvalue;
        }
    }

}
