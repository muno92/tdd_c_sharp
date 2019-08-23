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
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [Test]
        public void TestPlusReturnsSum()
        {
            Money five = Money.Dollar(5);
            Expression result = five.Plus(five);
            Sum sum = (Sum) result;
            Assert.AreEqual(five, sum.Augend);
            Assert.AreEqual(five, sum.Addend);
        }

        [Test]
        public void TestReduceSum()
        {
            Expression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(7), result);
        }

        [Test]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [Test]
        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [Test]
        public void TestIdentityRate()
        {
            Assert.AreEqual(1, new Bank().Rate("USD", "USD"));
        }
    }
}