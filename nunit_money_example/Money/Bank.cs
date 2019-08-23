namespace nunit_money_example.money
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(to);
        }

        public void AddRate(string from, string to, int rate)
        {
        }
    }
}