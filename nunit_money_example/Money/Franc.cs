namespace nunit_money_example.Money
{
    public class Franc
    {
        private int amount;
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multipiler)
        {
            return new Franc(amount * multipiler);
        }

        public override bool Equals(object obj)
        {
            Franc Franc = (Franc) obj;
            return amount == Franc.amount;
        }
    }
}