using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo.AbstractFactory
{
    class DELLDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new DELL();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    class DELLLaptopFactory : DELLDesktopFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }

}
