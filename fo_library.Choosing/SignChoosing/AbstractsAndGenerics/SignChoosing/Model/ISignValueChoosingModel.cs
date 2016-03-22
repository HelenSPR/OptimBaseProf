using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public interface ISignValueChoosingModel<TSignValue>
    {
        TSignValue[] SignValues { get; }

        TSignValue SelectedSignValue { get; set; }

        string SignName { get; }

    }
}
