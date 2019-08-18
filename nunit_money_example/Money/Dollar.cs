namespace nunit_money_example.Money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Money Times(int multipiler)
        {
            return new Dollar(Amount * multipiler);
        }
    }
}