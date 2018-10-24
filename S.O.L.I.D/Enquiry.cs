using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D
{
    class Enquiry : IDiscount
    {
        public double GetDiscount(double totalSales)
        {
            return totalSales - 5;
        }
        
    }
}
