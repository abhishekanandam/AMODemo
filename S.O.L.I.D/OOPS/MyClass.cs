using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{
    public class BaseDemo
    {

        public string MyProperty { get; set; }
        protected BaseDemo()
        {
            Console.WriteLine("protected Base");
        }

        public static BaseDemo BaseInstance()
        {
            return new BaseDemo();
        }
        

    }

    public class DerivedDemo: BaseDemo
    {
        public DerivedDemo() : base()
        {
            Console.WriteLine("derived");
        }

        public void M1()
        {
            BaseDemo baseInstance = BaseInstance();
        }
    }
}
