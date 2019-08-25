namespace mstest_money_example.money
{
    public class Money
    {
        protected int Amount;
        
        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && GetType() == money.GetType();
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }
    }
}