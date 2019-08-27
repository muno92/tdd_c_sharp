namespace mstest_money_example.money
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            Amount = amount;
            Currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier, null);
        }
    }
}