using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class DepartmentSignValueChoosingPresenter : SignValueChoosingPresenter<string>
    {
        private DepartmentSignValueChoosingPresenter(IRepository repository, int idorder)
            : base(new SignStringValueChoosingForm()
            , new DepartmentSignValueChoosingModel(repository, idorder))
        {
        }

        public static DepartmentSignValueChoosingPresenter CreatePresenter(IRepository repository, int idorder)
        {
            return new DepartmentSignValueChoosingPresenter(repository, idorder);
        }
    }
}
