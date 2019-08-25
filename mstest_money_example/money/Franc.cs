namespace mstest_money_example.money
{
    public class Franc
    {
        private readonly int _amount;
        
        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc Franc = (Franc) obj;
            return _amount == Franc._amount;
        }
    }
}