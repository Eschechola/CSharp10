namespace CSharp10.FieldKeyword
{
    public record Product
    {
        public string Name { get; init; }
        public int Amount { get; init; }

        // Price + 5% of value!
        public double Price { get; init => field = value + (value * 0.05); }
    }
}
