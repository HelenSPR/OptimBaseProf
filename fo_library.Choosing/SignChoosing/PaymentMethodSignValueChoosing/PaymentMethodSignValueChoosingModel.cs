using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class PaymentMethodSignValueChoosingModel : SignStringValueChoosingModel
    {
        public PaymentMethodSignValueChoosingModel(IRepository repository, int idorder):base(repository, idorder,177)
        {

        }

        protected override string GetDefaultSignValue()
        {
            // idsignvalue = 668(Способ оплаты: обычный)
            return _Repository.SignValues.First(sv => sv.idsignvalue == 668).strvalue;
        }
    }
}
