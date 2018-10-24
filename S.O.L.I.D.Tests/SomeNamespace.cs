using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.Tests
{
    [SetUpFixture]
    class SomeNamespace
    {
        [OneTimeSetUp]
        public void RunBeforeAllTests()
        {
            Console.WriteLine("***Run Before All***");
        }

        [OneTimeTearDown]
        public void RunAfterAllTests()
        {
            Console.WriteLine("***Run After All***");
        }

    }
}
