namespace nunit_money_example.money
{
    public abstract class Money
    {
        protected int Amount;

        public abstract Money Times(int multipiler);
        
        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && GetType() == money.GetType();
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }
    }
}