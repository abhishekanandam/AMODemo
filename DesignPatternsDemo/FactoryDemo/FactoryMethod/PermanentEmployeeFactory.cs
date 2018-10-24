using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo.FactoryMethod
{
    class PermanentEmployeeFactory : BaseEmployeeFactory
    {

        public PermanentEmployeeFactory(): base()
        {

        }

        public override IEmployeeManager Create()
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            return permanentEmployee;
        }

    }
}
