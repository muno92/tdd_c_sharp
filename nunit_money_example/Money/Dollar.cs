namespace nunit_money_example.Money
{
    public class Dollar
    {
        public int amount;
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multipiler)
        {
            return new Dollar(amount * multipiler);
        }

        public override bool Equals(object obj)
        {
            return true;
        }
    }
}