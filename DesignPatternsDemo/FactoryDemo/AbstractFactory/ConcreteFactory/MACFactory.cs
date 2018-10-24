using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryDemo.AbstractFactory
{
    class MACDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    class MACLaptopFactory : MACDesktopFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
