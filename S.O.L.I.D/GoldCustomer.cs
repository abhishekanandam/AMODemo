using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D
{
    class GoldCustomer : IDatabase
    {
        public double GetDiscount(double totalSales)
        {
            return totalSales - 50;
        }

        public void Add()
        {
            
        }

    }
}
