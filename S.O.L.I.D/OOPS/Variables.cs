using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{
    class Variables
    {
        //compile - time variable & can not be re-assigned
        const string co = "constant";

        readonly string re1 = "readonly1";
        readonly string re2;

        readonly static string sre = "static readonly ";

        public Variables()
        {
            re1 = re1 + " re-assign in default";
            re2 = " readonly2 in default";
            Console.WriteLine(co);
            Console.WriteLine(re1);
            Console.WriteLine(re2);
        }

        public Variables(string str)
        {
            re1 = re1 + " re-assign in parametralized";
            re2 = re2 + " re-assign in parametralized";
            Console.WriteLine(re1);
            Console.WriteLine(re2);
        }

        static Variables()
        {
            sre = sre + " re-assign in static";
            Console.WriteLine(sre);
        }

    }
}
