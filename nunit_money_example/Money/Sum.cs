namespace nunit_money_example.money
{
    public class Sum : Expression
    {
        public Money Augend;
        public Money Addend;

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }
    }
}