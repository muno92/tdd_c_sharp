using Xunit;
using xunit_money_example.money;

namespace xunit_money_example
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
            five.Times(3);
            Assert.Equal(15, five.Amount);
        }
    }
}