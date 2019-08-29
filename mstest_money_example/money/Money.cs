namespace mstest_money_example.money
{
    public class Money : Expression
    {
        public int Amount;
        public string Currency { get; protected set; }
        
        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
        
        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && Currency == money.Currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override string ToString()
        {
            return Amount + " " + Currency;
        }

        public Expression Plus(Money addend)
        {
            return new Sum(this, addend);
        }
    }
}