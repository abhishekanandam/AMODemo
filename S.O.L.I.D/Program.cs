using S.O.L.I.D.AsyncProgramming;
using S.O.L.I.D.Covariance;
using S.O.L.I.D.DelegatesEvents;
using S.O.L.I.D.OOPS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace S.O.L.I.D
{
    class Program
    {
        public delegate void VoidDelegate();

        static void Main(string[] args)
        {
            #region old
            //IDatabase customer = new Customer(new EmailHandler());

            //customer.Add();

            //BaseClass obj = new BaseClass();
            //BaseClass baseRef = new DerivedClass();
            //DerivedClass derived = new DerivedClass();

            //obj.Method1();
            //obj.Method2();
            //baseRef.Method1();
            //baseRef.Method2();
            //baseRef.display();
            //derived.display();

            //Child obj = new Child();
            //obj.ChildMethod();

            //Func<int, int, int> SumFunc = FuncDelegate.Sum;
            //int result = SumFunc(10, 10);

            //VoidDelegate voidDelegate = FuncDelegate.VoidMethod;
            //voidDelegate();

            //Action voidAction = FuncDelegate.VoidMethod;
            //voidAction();

            //Predicate<string> predicate = FuncDelegate.IsUpper;
            //bool isUpper = predicate("abc");

            //Number num = new Number(100);
            //num.PrintMoney();
            //num.PrintNumber();

            //A a = new A();
            //A ab = new B();
            //B b = new B();

            //TupleDemo tupleDemo = new TupleDemo();

            //var dynamicResult = tupleDemo.DynamicListDemo();

            //foreach (var r in dynamicResult)
            //    Console.WriteLine(r);

            //var hashDemo = tupleDemo.HashTableDemo();

            //foreach (var k in hashDemo.Keys)
            //    Console.WriteLine("keys: " + k);

            //foreach (var v in hashDemo.Values)
            //    Console.WriteLine("values: " + v);

            //Console.WriteLine("count: " + hashDemo.Count);
            //Console.WriteLine("IsFixedSize: " + hashDemo.IsFixedSize);
            //Console.WriteLine("IsReadOnly: " + hashDemo.IsReadOnly);

            //foreach(var r in hashDemo)
            //    Console.WriteLine(r);

            //Tuple<int, int, string> myTuple1 =  tupleDemo.Tuple1();

            //Console.WriteLine(myTuple1.Item1);
            //Console.WriteLine(myTuple1.Item2);
            //Console.WriteLine(myTuple1.Item3);

            //Tuple<int, int, string> myTuple2 =  tupleDemo.Tuple2();

            //Console.WriteLine(myTuple2.Item1);
            //Console.WriteLine(myTuple2.Item2);
            //Console.WriteLine(myTuple2.Item3);

            //var myTuple3 =  tupleDemo.Tuple3();
            //Console.WriteLine($"{myTuple3.Rest.Item1}");

            //DerivedDemo derived = new DerivedDemo();


            //BaseCovariance baseCo = new DerivedCovariance();

            //DerivedCovariance derCo = new BaseCovariance();

            //MyAsync.M1();

            //MyAsync.DataParrellism();
            //MyAsync.TaskParellism();

            //Indexers indexers = new Indexers();
            //indexers[1] = "1";

            //foreach (var item in indexers.range)
            //{
            //    Console.WriteLine(item);
            //}

            //MyClass obj = new MyClass();
            //I2 i2 = new MyClass();
            //I1 i1 = new MyClass();

            //i2.M1();
            //i1.M1();

            //B b = new B(1);
            //A bRef = new B(1);
            // A a = new A(1);
            //C c = new C();
            //D d = new D();
            //E e = new E();
            //C e = new E();

            //using (new MyClass())
            //{
            //    try
            //    {

            //    }
            //    catch
            //    {
            //    }

            //}

            //int? i = null;
            //Console.WriteLine(i.GetValueOrDefault());

            //SortedList<int, string> sortedList1 = new SortedList<int, string>();
            //sortedList1.Add(3, "Three");
            //sortedList1.Add(4, "Four");
            //sortedList1.Add(1, "One");
            //sortedList1.Add(5, "Five");
            //sortedList1.Add(2, "Two");

            //foreach (var item in sortedList1)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //SortedList sortedList2 = new SortedList();
            //sortedList2.Add(1, 2);
            //sortedList2.Add("abc", "xyz");

            //foreach (var item in sortedList2)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();
            //sortedDict.Add(3, 1);
            //sortedDict.Add(1, 1);
            //foreach (var item in sortedDict)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //indexer example
            //List<int> lst = new List<int>() { 1, 2, 3};
            //Console.WriteLine(lst[1]);

            //Variables v = new Variables();
            //Variables v1 = new Variables("string");

            //string str = "India is my country";
            //Console.WriteLine(str.Split(' ').Length);

            //Garage carLot = new Garage();
            //IEnumerator car = carLot.GetEnumerator();

            //car.MoveNext();
            //Car myCar1 = (Car)car.Current;
            //Console.WriteLine(myCar1._nickName + myCar1._speed);
            //car.MoveNext();
            //Car myCar2 = (Car)car.Current;
            //Console.WriteLine(myCar2._nickName + myCar2._speed);
            //car.Reset();

            //Test myClass = new Test(1);

            #endregion

            //Polymorphism p = new Polymorphism();

            //OperatorOverloading operatorOverloading = new OperatorOverloading();

            //SwapStrings.Swap();

            //string str1 = "string";
            //char[] chr = { 's', 't', 'r',  'i', 'n', 'g' };
            //object str2 = new string(chr);
            //Console.WriteLine(str1 == str2);

            Console.ReadLine();

        }
    }

    public static class MyStatic
    {
        static MyStatic()
        {

        }

    }

    public class Test
    {
        public Test()
        {
            Console.WriteLine("Default");
        }

        public Test(int i)
        {
            Console.WriteLine("Parametraized");
        }

    }

    public class A
    {
        static A()
        {
            Console.WriteLine("SA");
        }
        public A(int t)
        {
            Console.WriteLine("A");
        }

        protected A(int i, int y)
        {
            Console.WriteLine("Protected A");
        }
    }

    public class B : A
    {
        //private B()
        //{
        //    Console.WriteLine("Private B");
        //}
        static B()
        {
            Console.WriteLine("SB");
        }
        public B(int t) : base(1, 2)
        {
            Console.WriteLine("B");
        }

        protected B() : base(1, 3)
        {
            Console.WriteLine("Protected B");
        }

    }

    class C
    {
        public C()
        {
            Console.WriteLine("C");
        }

    }

    class D : C
    {
        internal D()
        {
            Console.WriteLine("Interal");
        }
    }

    class E : D
    {
        public E()
        {
            Console.WriteLine("E");
        }
    }

    public class MyClass : IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TO DO: clean up managed objects
                }

                // TO DO: clean up unmanaged objects

                disposed = true;
            }
        }
    }
}
