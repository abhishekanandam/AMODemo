using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{
    class OperatorOverloading
    {
        public OperatorOverloading()
        {
            Class1 obj1 = new Class1();
            obj1.a = 10;
            obj1.b = 10;

            Class1 obj2 = new Class1();
            obj2.a = 20;
            obj2.b = 20;

            Class1 obj = new Class1();
            obj = obj1 + obj2;

        }
        
    }

    class Class1
    {
        public int a;
        public int b;

        public static Class1 operator +(Class1 obj1, Class1 obj2)
        {
            Class1 obj = new Class1();
            obj.a = obj1.a + obj2.a;
            obj.b = obj1.b + obj2.b;

            return obj;
        }

        public static Class1 operator -(Class1 obj1, Class1 obj2)
        {
            Class1 obj = new Class1();
            obj.a = obj1.a - obj2.a;
            obj.b = obj1.b - obj2.b;

            return obj;
        }

    }
}
