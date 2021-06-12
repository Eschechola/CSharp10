namespace CSharp10.FileKeyword
{
    public record Product
    {
        public string Name { get; init; }
        public double Price { get; init; }

        // Amount + 5% of value!
        public int Amount { get; init => field = value + (value * 0.05); }
    }
}
