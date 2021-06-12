using System.Collections.Generic;

namespace CSharp10.RequiredProperties
{
    public record Product
    {
        public string Name { get; init; }
        public double Price { get; init; }
        public int Amount { get; init; }
    }

    public class Order
    {
        public List<Product> OrderProducts { get; private set; }

        public Order()
        {
            OrderProducts = new List<Product>
            {
                new Product
                {
                    Name = "RTX 3060 TI",
                    Price = 7000,
                    // If you not initialize the value will be ever null
                    // Amount = 1
                }
            };
        }
    }
}
