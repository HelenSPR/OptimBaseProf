using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Choosing.Common
{
    public interface IChoosingOrdersIdDialogView
    {
        // Отображения диалога выбора заказов
        DialogResult ShowDialog();

        // Номер сменного задания
        string TaskNumber { get; }

        // Массив идентификаторов заказов
        int[] OrderIdArray { get; }
    }
}
