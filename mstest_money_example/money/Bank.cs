namespace mstest_money_example.money
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            Sum sum = (Sum) source;
            return sum.Reduce(to);
        }
    }
}