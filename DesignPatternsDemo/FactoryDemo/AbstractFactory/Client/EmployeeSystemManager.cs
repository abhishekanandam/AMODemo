using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo.AbstractFactory
{
    class EmployeeSystemManager
    {
        IComputerFactory _iComputerFactory;

        public EmployeeSystemManager(IComputerFactory iComputerFactory)
        {
            _iComputerFactory = iComputerFactory;
        }

        public string GetSystemDetails()
        {
            IBrand iBrand = _iComputerFactory.Brand();
            IProcessor iProcessor = _iComputerFactory.Processor();
            ISystemType iSystemType = _iComputerFactory.SystemType();

            string systemDetails = string.Format("{0} {1} {2}", iBrand.GetType(), iSystemType.GetType(), iProcessor.GetProcessor());

            return systemDetails;
        }

    }
}
