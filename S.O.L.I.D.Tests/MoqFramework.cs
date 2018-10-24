using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using S.O.L.I.D.TestSuites;

namespace S.O.L.I.D.Tests
{
    [TestFixture]
    class MoqFramework
    {
        [Test]
        public void TestMoq()
        {
            var moqData = new Mock<ITestMoq>();
            moqData.Setup(x => x.IsTrueFalse(true));
            var sut = new MoqMain(moqData.Object);
            
            Assert.That(sut.MyMethod(), Is.False);

        }
    }
}
