using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo
{
    class PermanentEmployee : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetSalary()
        {
            return 20;
        }

        public decimal GetHRA()
        {
            return 15;
        }
    }
}
