namespace nunit_money_example.Money
{
    public class Money
    {
        protected int Amount;
        
        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && GetType() == money.GetType();
        }
    }
}