namespace nunit_money_example.money
{
    public class Money : Expression
    {
        public readonly int Amount;
        public string Currency { get; protected set; }

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public Expression Times(int multipiler)
        {
            return new Money(Amount * multipiler, Currency);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && Currency == money.Currency;
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }
    }
}