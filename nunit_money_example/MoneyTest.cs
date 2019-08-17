using nunit_money_example.Money;
using NUnit.Framework;

namespace nunit_money_example
{
    public class MoneyTest
    {
        [Test]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.AreEqual(10, five.amount);
            five.times(3);
            Assert.AreEqual(15, five.amount);
        }
    }
}