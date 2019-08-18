namespace nunit_money_example.money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public override Money Times(int multipiler)
        {
            return new Dollar(Amount * multipiler);
        }
    }
}