using NUnit.Framework;
using S.O.L.I.D.TestSuites;

namespace S.O.L.I.D.Tests
{
    [TestFixture]
    public class Class1 : CustomData
    {
        [Test]
        [Ignore("Test")]
        public void ShouldAddAndSub([Values(10, 20, 30)]int numToAdd, [Values(10, 5, 5)]int numToSub)
        {
            var sut = new Calculator();
        }

        [TestCaseSource(typeof(CustomData))]
        [Category("Calculations")]
        public void ShouldAddTwoNumbers(int a, int b, int expected)
        {
            var sut = new Calculator();
            var result = sut.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Category("Calculations")]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new Calculator();
            var result = sut.Multiply(10, 2);
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        [Category("Calculations")]
        public void ShouldAddDoubles()
        {
            var sut = new Calculator();
            var result = sut.AddDouble(1.1, 2.2);
            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        [Category("Player")]
        public void ShouldThrowErrorWhenDivideByZero()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Divide(10, 0), Throws.Exception);
        }

        [Test]
        [Category("Player")]
        public void CheckForPlayerHealth()
        {
            var sut = new PlayerCharecter() { Health = 100 };
            var result = sut.Sleep();
            Assert.That(result, Is.InRange(100, 200));
        }

        [Test]
        [Category("Player")]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            var sut = new PlayerCharecter();
            Assert.That(sut.Name, Is.Not.Empty);
        }

        [Test]
        [Category("Player")]
        public void ShouldNotHaveNickName()
        {
            var sut = new PlayerCharecter();
            Assert.That(sut.NickName, Is.Empty);
        }

        [Test]
        [Category("Player")]
        public void ShouldHaveNewBie()
        {
            var sut = new PlayerCharecter();
            Assert.That(sut.IsNoob, Is.True);
        }

        [Test]
        [Category("Player")]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            var sut = new PlayerCharecter();
            Assert.That(sut.Weapons, Is.All.Not.Empty);
        }

        [Test]
        [Category("Player")]
        public void ShouldContain()
        {
            var sut = new PlayerCharecter();
            Assert.That(sut.Weapons, Contains.Item("Short Bow"));
        }

        [Test]
        [Category("Player")]
        public void ShouldHaveAtleastOne()
        {
            var sut = new PlayerCharecter();
            Assert.That(sut.Weapons, Has.Some.Contains("Sword"));
        }

        [Test]
        [Category("Player")]
        public void ShouldHaveTwoBows()
        {
            var sut = new PlayerCharecter();
            Assert.That(sut.Weapons, Has.Exactly(2).EndsWith("Bow"));
        }

        [Test]
        [Category("Player")]
        public void ShouldBeUnique()
        {
            var sut = new PlayerCharecter();
            Assert.That(sut.Weapons, Is.Unique);
        }

        [Test]
        [Category("Player")]
        public void ShouldNotHave()
        {
            var sut = new PlayerCharecter();
            Assert.That(sut.Weapons, Has.None.EqualTo("abc"));
        }

        [Test]
        [Category("Player")]
        public void CheckRefEquality()
        {
            var sut1 = new PlayerCharecter();
            var sut2 = new PlayerCharecter();
            var somePlayer = sut1;
            Assert.That(somePlayer, Is.SameAs(sut1));
        }

        [Test]
        [Category("Player")]
        public void ShouldCreateNormalEnemy()
        {
            var sut = new EnemyFactory();
            object enemy = sut.Create(false);
            Assert.That(enemy, Is.TypeOf<NormalEnemy>());
        }

        [Test]
        [Repeat(2)]
        public void ShouldDoWork()
        {
            var sut = new Calculator();
            sut.DoWork();
        }

    }
}
