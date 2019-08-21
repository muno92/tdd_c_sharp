namespace nunit_money_example.money
{
    public interface Expression
    {
        Money Reduce(string to);
    }
}