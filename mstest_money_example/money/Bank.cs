namespace mstest_money_example.money
{
    public class Bank
    {
        public Money reduce(Expression source, string to)
        {
            Sum sum = (Sum) source;
            return sum.Reduce(to);
        }
    }
}