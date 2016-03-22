using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Validation
{
    public class NativeModelNullReferenceException : ApplicationException
    {
        public NativeModelNullReferenceException(string Message)
            : base(Message)
        {

        }
    }
}
