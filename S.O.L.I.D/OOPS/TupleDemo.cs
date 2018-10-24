using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OOPS
{
    class TupleDemo
    {
        public List<dynamic> DynamicListDemo()
        {
            var lstDynamic = new List<dynamic>();

            lstDynamic.Add(1);
            lstDynamic.Add("1");
            lstDynamic.Add(353453);
            lstDynamic.Add(1);

            return lstDynamic;
        }

        public Hashtable HashTableDemo()
        {
            Hashtable hash = new Hashtable();

            hash.Add(1, "sfdsdf");
            hash.Add("adsasda", 2);
            hash.Add(5, 3);
            hash.Add("sdfds", "sdad");

            return hash;
        }

        public Tuple<int, int, string> Tuple1()
        {
            Tuple<int, int, string> myTuple = new Tuple<int, int, string>(1,2,"abc");

            return myTuple;
        }

        public Tuple<int, int, string> Tuple2()
        {
            var myTuple = Tuple.Create<int, int, string>(1, 2, "abc");

            return myTuple;
        }

        public Tuple<int, int, int, int, int, int, int, Tuple<int>> Tuple3()
        {
            return Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
        }

        public void ValueTupleDemo()
        {

        }

    }
}
