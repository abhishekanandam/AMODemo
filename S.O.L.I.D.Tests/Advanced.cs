using NUnit.Framework;
using S.O.L.I.D.TestSuites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.Tests
{
    [TestFixture]
    class Advanced
    {
        PlayerCharecter playerChar;

        [Test]
        public void FirstHealthCheck()
        {
            var result = playerChar.Sleep();
            Assert.That(result, Is.InRange(100, 200));
        }

        [Test]
        public void LastHealthCheck()
        {
            var result = playerChar.Sleep();
            Assert.That(result, Is.InRange(100, 200));
        }

        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine("Before {0} ", TestContext.CurrentContext.Test.Name);
            playerChar = new PlayerCharecter() { Health = 100 };
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine("After {0} ", TestContext.CurrentContext.Test.Name);
            playerChar = null;
        }


    }
}
