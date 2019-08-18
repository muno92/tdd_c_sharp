namespace nunit_money_example.money
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
            Currency = "CHF";
        }

        public override Money Times(int multipiler)
        {
            return new Franc(Amount * multipiler);
        }
    }
}