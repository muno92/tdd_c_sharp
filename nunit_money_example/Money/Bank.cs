namespace nunit_money_example.money
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            if (source.GetType() == typeof(Money))
            {
                return (Money) source;
            }
            Sum sum = (Sum) source;
            return sum.Reduce(to);
        }
    }
}