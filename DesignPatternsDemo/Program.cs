using DesignPatternsDemo.SingletonDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () =>
                {
                    Singleton firstObj = Singleton.GetInstance;
                    firstObj.Display("first object");
                },
                () =>
                {
                    Singleton secondObj = Singleton.GetInstance;
                    secondObj.Display("second object");
                }
            );
            Console.ReadLine();
        }
    }
}
