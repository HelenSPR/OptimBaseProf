using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class PaymentMethodSignValueChoosingPresenter : SignValueChoosingPresenter<string>
    {
        private PaymentMethodSignValueChoosingPresenter(IRepository repository, int idorder)
            : base(new SignStringValueChoosingForm(), new PaymentMethodSignValueChoosingModel(repository, idorder))
        {

        }

        public static PaymentMethodSignValueChoosingPresenter CreatePresenter(IRepository repository, int idorder)
        {
            return new PaymentMethodSignValueChoosingPresenter(repository, idorder);
        }
    }
}
