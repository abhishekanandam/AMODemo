using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.DelegatesEvents
{
    class FuncDelegate
    {

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static void VoidMethod()
        {
            Console.WriteLine();
        }

        public static bool IsUpper(string str)
        {
            return str.Equals(str.ToUpper());
        }

    }
}
