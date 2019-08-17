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
            Dollar product = five.times(2);
            Assert.AreEqual(10, product.amount);
            product = five.times(3);
            Assert.AreEqual(15, product.amount);
        }
    }
}