using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Exceptions
{
    public class ValidationException:Exception
    {
        public ValidationException():this ("Validation error ")
        {
            
        }
        public ValidationException(string message):base(message)
        {
            
        }
        public ValidationException(Exception ex):base(ex.Message)
        {
                
        }

    }
}
