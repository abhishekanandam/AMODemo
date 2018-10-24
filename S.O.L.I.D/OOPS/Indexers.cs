using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{
    class Indexers
    {
        public string[] range = new string[5];

        public string this[int index]
        {
            get
            {
                return range[index];
            }
            set
            {
                range[index] = value;
            }
        }
    }
}
