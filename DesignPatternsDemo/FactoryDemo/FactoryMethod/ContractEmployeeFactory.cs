using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo.FactoryMethod
{
    class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(): base()
        {

        }
        public override IEmployeeManager Create()
        {
            ContractEmployee contractEmployee = new ContractEmployee();
            return contractEmployee;
        }
    }
}
