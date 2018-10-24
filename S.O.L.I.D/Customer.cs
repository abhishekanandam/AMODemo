using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D
{
    class Customer : IDiscount, IDatabase
    {
        protected ILogger iLogger;

        public Customer(ILogger _iLogger)
        {
            iLogger = _iLogger;
        }

        public virtual void Add()
        {
            try
            {
                throw new NullReferenceException();
            }
            catch(Exception ex)
            {
                iLogger.Handler(ex.ToString());
            }
        }

        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }
    }
}
