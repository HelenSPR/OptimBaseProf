using Atechnology.DBConnections2;
using Atechnology.ecad.Document.DataSets;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class DepartmentSignValueChoosingModelDataSet : SignStringValueChoosingModelDataSet
    {
        // Словарь Идентификатор Департамента - Идентификатор значения признака
        private Dictionary<int, int> _DepartmentIdSignValueId;

        public DepartmentSignValueChoosingModelDataSet(Model.IRepository repository, ds_order dataset)
            : base(repository, dataset, 178)
        {
            _DepartmentIdSignValueId = new Dictionary<int, int>();

            // Дилерский отдел - Дилерский
            _DepartmentIdSignValueId.Add(66, 676);

            // Корпоративный отдел - Корпоративный
            _DepartmentIdSignValueId.Add(67, 677);

            // Диз и Арх - Диз и Арх
            _DepartmentIdSignValueId.Add(384, 678);

            // СКС - СКС
            _DepartmentIdSignValueId.Add(83, 679);
        }
        protected override string GetDefaultSignValue()
        {
            // Хранилище функций
            var fnRepository = new SqlFnRepository();

            // Установить контекст для хранилища функция
            fnRepository.FnContext = new WindrawFnDataContext(dbinit.db);

            // Получить идентификатор для текущего пользователя
            var departmentId = fnRepository.GetDepartmentId(_Repository.CurrentUser.idpeople);

            // Получить идентификатор для значения признака
            var signValueId = _DepartmentIdSignValueId.FirstOrDefault(dsv => dsv.Key == departmentId).Value;

            // если ноль установить 675(розница)
            if (signValueId == 0) signValueId = 675;


            return _Repository.SignValues.First(sv => sv.idsignvalue == signValueId).strvalue;
        }
    }
}
