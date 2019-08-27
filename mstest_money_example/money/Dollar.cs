namespace mstest_money_example.money
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(Amount * multiplier);
        }
    }
}