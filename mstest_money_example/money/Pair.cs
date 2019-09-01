namespace mstest_money_example.money
{
    public class Pair
    {
        private readonly string from;
        private readonly string to;

        public Pair(string @from, string to)
        {
            this.@from = @from;
            this.to = to;
        }

        public override bool Equals(object obj)
        {
            Pair pair = (Pair) obj;
            return @from.Equals(pair.@from) && to.Equals(pair.to);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}