using Atechnology.ecad.Document.DataSets;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class LoggiaRecomendationObjectSignValueChoosingModelDataSet : SignStringValueChoosingModelDataSet
    {
        public LoggiaRecomendationObjectSignValueChoosingModelDataSet(IRepository repository, ds_order dataset)
            : base(repository, dataset, 198)
        {
        }
    
        protected override string GetDefaultSignValue()
        {
            return _Repository.SignValues.First(sv => sv.idsignvalue == 694).strvalue;
        }
    }

}
