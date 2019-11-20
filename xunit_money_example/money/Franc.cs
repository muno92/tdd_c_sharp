namespace xunit_money_example.money
{
    public class Franc
    {
        private int Amount;

        public Franc(int amount)
        {
            Amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc Franc = (Franc) obj;
            return Franc != null && Amount == Franc.Amount;
        }
    }
}