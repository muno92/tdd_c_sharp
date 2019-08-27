namespace mstest_money_example.money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
            Currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}