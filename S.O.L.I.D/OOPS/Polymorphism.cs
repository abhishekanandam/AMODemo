using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{

    class Polymorphism
    {
        public Polymorphism()
        {
            A a = new A();
            a.M1();
            a.M();

            B b = new B();
            b.M1();
            b.M();

            C c = new C();
            c.M1();
            c.M2();
            c.M();

            A aRefB = new B();
            aRefB.M1();
            aRefB.M();

            A aRefC = new C();
            aRefC.M1();
            aRefC.M();

            B bRefC = new C();
            bRefC.M1();
            bRefC.M();

            C child = aRefC as C;
            child.M2();
            child.M();
            child.M1();
        }
    }

    class A
    {

        public void M1()
        {
            Console.WriteLine("A.M1");
        }

        public virtual void M()
        {
            Console.WriteLine("A.M");
        }
    }

    class B:A
    {
        public override void M()
        {
            Console.WriteLine("B.M");
        }
    }

    class C : B
    {

        public void M2()
        {
            Console.WriteLine("C.M2");
        }

        public override void M()
        {
            Console.WriteLine("C.M");
        }
    }
}
