using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatternsDemo.FactoryDemo.AbstractFactory.Enumerations;

namespace DesignPatternsDemo.FactoryDemo.AbstractFactory
{
    class EmployeeSystemFactory
    {
        public IComputerFactory Create(EmployeeType empType, EmpJobDesc empJobDesc)
        {
            IComputerFactory computerFactory = null;

            switch(empType)
            {
                case EmployeeType.PermanentEmployee:
                    switch(empJobDesc)
                    {
                        case EmpJobDesc.Manager:
                            computerFactory = new MACLaptopFactory();
                            break;
                        case EmpJobDesc.Employee:
                            computerFactory = new MACDesktopFactory();
                            break;
                    }

                    break;
                case EmployeeType.ContractEmployee:
                    switch (empJobDesc)
                    {
                        case EmpJobDesc.Manager:
                            computerFactory = new DELLLaptopFactory();
                            break;
                        case EmpJobDesc.Employee:
                            computerFactory = new DELLDesktopFactory();
                            break;
                    }
                    break;
            }

            return computerFactory;

        }
    }
}
