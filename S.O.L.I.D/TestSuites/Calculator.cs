using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.TestSuites
{
    public class Calculator
    {

        public void DoWork()
        {
            if (DateTime.Now.Ticks % 2 == 0)
                throw new ApplicationException("Simulated Bug");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }

        public double AddDouble(double a, double b)
        {
            return a + b;
        }

    }
}
