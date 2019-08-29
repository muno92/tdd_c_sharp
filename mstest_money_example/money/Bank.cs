namespace mstest_money_example.money
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            if (source is Money money)
            {
                return money.Reduce(to);
            }
            Sum sum = (Sum) source;
            return sum.Reduce(to);
        }
    }
}