using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{
    interface I1
    {
        void M1();
    }

    interface I2
    {
        void M1();
    }

    class MyClass : I1, I2
    {
        void I2.M1()
        {
            Console.WriteLine("I2.M1");
        }

        void I1.M1()
        {
            Console.WriteLine("I1.M1");
        }
    }

}
