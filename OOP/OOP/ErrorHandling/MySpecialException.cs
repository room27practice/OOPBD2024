using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    public class MySpecialException:ApplicationException
    {
        
        public MySpecialException(string reason):base(reason)
        {
            Reason = reason;
        }

        public string Reason { get; set; }
    }
}
