using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Validation
{
    public class OrderCalcPositionNullReferenceException : ApplicationException
    {
        public OrderCalcPositionNullReferenceException(string Message)
            : base(Message)
        {
            
        }

        
    }
}
