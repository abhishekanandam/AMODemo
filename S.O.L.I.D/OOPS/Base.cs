using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{
     class BaseClass
    {
        public virtual string Method1()
        {
            return "Override";
        }

        public virtual string Method2()
        {
            return "Hidden";
        }

        public void display()
        {
        }

    }
}
