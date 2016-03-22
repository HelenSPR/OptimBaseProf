using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class LoggiaRecomendationObjectSignValueChoosingModel : SignStringValueChoosingModel
    {
        public LoggiaRecomendationObjectSignValueChoosingModel(IRepository repository, int idorder)
            : base(repository, idorder, 198)
        {
        }

        protected override string GetDefaultSignValue()
        {
            return _Repository.SignValues.First(sv => sv.idsignvalue == 694).strvalue;
        }
    }
}
