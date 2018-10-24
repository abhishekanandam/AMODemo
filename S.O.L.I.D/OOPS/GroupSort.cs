using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{
    class GroupSort
    {

        public void GrpSrt()
        {
            List<int> lst = new List<int>() { 3, 7, 1, 5, 10, 4, 3, 2, 11, 5, 10, 4, 10, 4 };
            lst.Sort();

            //lst.ForEach(r => { Console.WriteLine(r); });

            var query = lst.GroupBy(x => x)
              .Select(y => new { Element = y.Key, Counter = y.Count() })
              .ToList();

            //query.ForEach(r => { Console.WriteLine(r.Element + " " + r.Counter); });

            var final = (from a in query
                         orderby a.Counter
                         select a).ToList();

            //final.ForEach(r => { Console.WriteLine(r.Element + " " + r.Counter); });

            for (int x = 0; x < final.Count; x++)
            {
                var result = final.ElementAt(x);
                for (int y = 1; y <= result.Counter; y++)
                {
                    Console.WriteLine(result.Element + "\n");
                }
            }

        }

    }
}
