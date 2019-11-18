using Xunit;

namespace xunit_money_example
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar();
            five.times(2);
            Assert.Equal(10, five.amount);
        }
    }
}