using System;

namespace CSharp10.NullCheck
{
    public class NullCheck
    {
        public double CalculateFeePriceDefaultNullCheck(string zipcode)
        {
            if (zipcode == null)
                throw new ArgumentNullException("Zipcode cannot be null!");

            // Logic here....
            var fee = new Random().NextDouble();

            return fee;
        }

        public double CalculateFeePriceNewNullCheck(string zipcode!!)
        {
            // Logic here....
            var fee = new Random().NextDouble();

            return fee;
        }
    }
}
