namespace mstest_money_example.money
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
        }
    }
}