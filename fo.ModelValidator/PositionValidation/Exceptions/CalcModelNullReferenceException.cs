using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Validation
{
    public class CalcModelNullReferenceException : ApplicationException
    {
        public CalcModelNullReferenceException(string Message)
            : base(Message)
        {

        }
    }
}
