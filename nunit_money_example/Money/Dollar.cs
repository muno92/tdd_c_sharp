namespace nunit_money_example.money
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multipiler)
        {
            return new Dollar(Amount * multipiler, Currency);
        }
    }
}