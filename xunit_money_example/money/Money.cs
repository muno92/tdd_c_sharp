namespace xunit_money_example.money
{
    public class Money
    {
        protected int Amount;

        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return money != null && Amount == money.Amount;
        }
    }
}