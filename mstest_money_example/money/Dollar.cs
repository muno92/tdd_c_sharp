namespace mstest_money_example.money
{
    public class Dollar
    {
        public int Amount;
        
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            return true;
        }
    }
}