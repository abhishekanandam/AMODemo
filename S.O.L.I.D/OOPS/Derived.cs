using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{
    class DerivedClass : BaseClass
    {

        public override string Method1()
        {
            return "Derived";
        }

        public new string Method2()
        {
            return "Derived";
        }

        public void display()
        {
            
        }
    }
}
