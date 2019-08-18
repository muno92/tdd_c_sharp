namespace nunit_money_example.money
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
        }

        public override Money Times(int multipiler)
        {
            return new Franc(Amount * multipiler);
        }

        public override string Currency()
        {
            return "CHF";
        }
    }
}