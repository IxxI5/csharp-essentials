using System;
using System.Collections.Generic;

namespace CSharpEssentials.CS08_Properties
{
    public class Main
    {
        /// <summary>
        /// We use a Product class in an e-commerce context to showcase various kinds of properties including auto-implemented properties, 
        /// properties with custom logic, read-only properties, and properties with expressions (lambda syntax).
        /// Auto-Implemented Property: Name and Category.
        /// Full Property with Backing Field: Price, where we validate the value.
        /// Read-Only Property: IsAvailable, which is derived from another property.
        /// Calculated Property with Lambda: DiscountedPrice, which calculates a discounted price.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS08_Properties");

            // Create a product instance
            Product product = new Product("Laptop", "Electronics", 999.99m, 10);

            // Display product details
            Console.WriteLine(product);

            // Update discount
            product.Discount = 10; // 10% discount
            Console.WriteLine("After applying a 10% discount:");
            Console.WriteLine(product);

            // Sell some quantity
            product.Sell(3);
            Console.WriteLine("After selling 3 units:");
            Console.WriteLine(product);

            // Attempt to sell more units than available
            try
            {
                Console.WriteLine("Attempt to sell 8 units");
                product.Sell(8); // This will throw an exception
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Display final product details
            Console.WriteLine("Final product details:");
            Console.WriteLine(product);
        }
    }
}
