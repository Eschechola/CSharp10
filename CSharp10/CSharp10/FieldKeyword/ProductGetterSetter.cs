namespace CSharp10.FieldKeyword
{
    public record ProductGetterSetter
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        // Price + 5% of value!
        public double Price
        {
            get;
            set
            {
                if (value <= 5)
                    field = value + (value * 0.05);
                else
                    field = value + (value * 0.10);
            }
        }
    }
}
