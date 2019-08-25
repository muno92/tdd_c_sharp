namespace mstest_money_example.money
{
    public class Dollar
    {
        private readonly int _amount;
        
        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar) obj;
            return _amount == dollar._amount;
        }
    }
}