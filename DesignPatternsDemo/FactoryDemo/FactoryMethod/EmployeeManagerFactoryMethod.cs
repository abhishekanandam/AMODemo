using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo.FactoryMethod
{
    class EmployeeManagerFactoryMethod
    {
        public BaseEmployeeFactory CreateFactory(EmployeeType empType)
        {
            BaseEmployeeFactory baseEmpFact = null;

            switch(empType)
            {
                case EmployeeType.PermanentEmployee:
                    baseEmpFact = new PermanentEmployeeFactory();
                    break;
                case EmployeeType.ContractEmployee:
                    baseEmpFact = new ContractEmployeeFactory();
                    break;
            }

            return baseEmpFact;
        }
    }
}
