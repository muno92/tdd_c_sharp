using nunit_money_example.money;
using NUnit.Framework;

namespace nunit_money_example
{
    public class MoneyTest
    {
        [Test]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Test]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency);
            Assert.AreEqual("CHF", Money.Franc(1).Currency);
        }

        [Test]
        public void TestSimpleAddition()
        {
            Money five = Money.Dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [Test]
        public void TestPlusReturnsSum()
        {
            Money five = Money.Dollar(5);
            Expression result = five.Plus(five);
            Sum sum = (Sum) result;
            Assert.Equals(five, sum.Augend);
            Assert.Equals(five, sum.Addend);
        }
    }
}