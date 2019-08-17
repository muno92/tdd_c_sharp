namespace nunit_money_example.Money
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
        }

        public Franc Times(int multipiler)
        {
            return new Franc(Amount * multipiler);
        }
    }
}