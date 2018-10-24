using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo
{
    class ContractEmployee : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetSalary()
        {
            return 10;
        }

        public decimal GetMedicalAllowance()
        {
            return 5;
        }
    }
}
