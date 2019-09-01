namespace mstest_money_example.money
{
    public interface Expression
    {
        Money Reduce(Bank bank, string to);
    }
}