using Microsoft.VisualStudio.TestTools.UnitTesting;
using mstest_money_example.money;

namespace mstest_money_example
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [TestMethod]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency);
            Assert.AreEqual("CHF", Money.Franc(1).Currency);
        }

        [TestMethod]
        public void TestSimpleAddition()
        {
            Money five = Money.Dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [TestMethod]
        public void TestPlusReturnsSum()
        {
            Money five = Money.Dollar(5);
            Expression result = five.Plus(five);
            Sum sum = (Sum) result;
            Assert.AreEqual(five, sum.Augend);
            Assert.AreEqual(five, sum.Addend);
        }

        [TestMethod]
        public void TestReduceSum()
        {
            Expression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(7), result);
        }

        [TestMethod]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [TestMethod]
        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [TestMethod]
        public void TestIdentityRate()
        {
            Assert.AreEqual(1, new Bank().Rate("USD", "USD"));
        }

        [TestMethod]
        public void TestMixedAddition()
        {
            Expression fiveBucks = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.AreEqual(Money.Dollar(10), result);
        }

        [TestMethod]
        public void TestSumPlusMoney()
        {
            Expression fiveBucks = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).Plus(fiveBucks);
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(15), result);
        }

        [TestMethod]
        public void TestSumTimes()
        {
            Expression fiveBucks = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).Times(2);
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(20), result);
        }
    }
}