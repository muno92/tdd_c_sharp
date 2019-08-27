namespace mstest_money_example.money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override string Currency()
        {
            return "USD";
        }
    }
}