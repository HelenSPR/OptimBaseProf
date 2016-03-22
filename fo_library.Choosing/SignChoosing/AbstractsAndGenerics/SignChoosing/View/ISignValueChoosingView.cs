using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
 

    public interface ISignValueChoosingForm<TSignValue> : ISignValueChoosingView<TSignValue>
    {
        void ShowView();
        void SetTitle(string title);
    }
   
}
