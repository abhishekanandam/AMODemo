using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteImplementations
{
    public class Test : ITest
    {
        public string TestMethod()
        {
            return "my concrete method..";
        }
    }
}
