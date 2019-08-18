namespace nunit_money_example.money
{
    public abstract class Money
    {
        protected int Amount;

        public abstract Money Times(int multipiler);
        public abstract string Currency();

        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && GetType() == money.GetType();
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Franc Franc(int amount)
        {
            return new Franc(amount);
        }
    }
}