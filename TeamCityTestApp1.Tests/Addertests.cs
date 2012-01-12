using NUnit.Framework;
using TeamCityTestApp1.Tools;

namespace TeamCityTestApp1.Tests
{
    [TestFixture]
    public class Addertests
    {
        [Test]
        public void add_test()
        {
            const int a = 1;
            const int b = 2;

            var adder = new Adder();
            var c = adder.Add(a, b);

            Assert.AreEqual(3, c);
        }
    }
}