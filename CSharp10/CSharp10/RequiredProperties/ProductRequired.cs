using System.Collections.Generic;

namespace CSharp10.RequiredProperties.Required
{
    public record Product
    {
        public required string Name { get; init; }
        public required double Price { get; init; }
        public required int Amount { get; init; }
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
                        // If i dont initialize, compiler error!
                        Amount = 1
                    }
                };
        }
    }
}
