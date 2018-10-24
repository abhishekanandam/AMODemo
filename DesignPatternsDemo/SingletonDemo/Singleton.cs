using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object obj = new object();

        private static Singleton instance = null;

        // Lazy instance with thrad-safe. This does not require lock 
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton());
        private Singleton()
        {
            counter++;
            Console.WriteLine("Number of instances: " + counter);
        }

        public static Singleton GetInstance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                        instance = new Singleton();
                }
                return instance;
            }
        }

        public void Display(string msg)
        {
            Console.WriteLine("This is Creational Design Pattern --> Singleton Demo: " + msg);
        }

    }
    
}
