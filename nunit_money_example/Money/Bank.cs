using System.Collections.Generic;

namespace nunit_money_example.money
{
    public class Bank
    {
        private Dictionary<Pair, int> _rates = new Dictionary<Pair, int>();
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            _rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            return _rates[new Pair(from, to)];
        }
    }
}