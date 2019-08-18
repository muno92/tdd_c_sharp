namespace nunit_money_example.money
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override Money Times(int multipiler)
        {
            return Money.Franc(Amount * multipiler);
        }
    }
}