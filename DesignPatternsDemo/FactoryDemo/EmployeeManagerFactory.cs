using DesignPatternsDemo.FactoryDemo.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo
{
    class EmployeeManagerFactory
    {
        IEmployeeManager empManager = null;

        public IEmployeeManager GetEmployeeManager(EmployeeType empType)
        {
            switch(empType)
            {
                case EmployeeType.PermanentEmployee:
                    empManager = new PermanentEmployee();
                    break;
                case EmployeeType.ContractEmployee:
                    empManager = new ContractEmployee();
                    break;
            }

            return empManager;
        }

    }
}
