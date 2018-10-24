using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo
{
    interface IEmployeeManager
    {
        decimal GetSalary();
        decimal GetBonus();
    }
}
