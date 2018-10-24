using DesignPatternsDemo.FactoryDemo.AbstractFactory;
using DesignPatternsDemo.FactoryDemo.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo
{
    public class Employee
    {
        EmployeeManagerFactoryMethod empManagerFactory = new EmployeeManagerFactoryMethod();
        public void GetPermanentEmployeeDetails()
        {
            BaseEmployeeFactory empManager = empManagerFactory.CreateFactory(EmployeeType.PermanentEmployee);
            IComputerFactory factory = new EmployeeSystemFactory().Create(EmployeeType.PermanentEmployee, Enumerations.EmpJobDesc.Manager);
            EmployeeSystemManager empSystemManager = new EmployeeSystemManager(factory);
            empSystemManager.GetSystemDetails();
            empManager.Create().GetBonus();
            empManager.Create().GetSalary();
            empManager.Create();
        }

        public void GetContractEmployeeDetails()
        {
            BaseEmployeeFactory empManager = empManagerFactory.CreateFactory(EmployeeType.ContractEmployee);
            empManager.Create().GetBonus();
            empManager.Create().GetSalary();
        }
    }
}
