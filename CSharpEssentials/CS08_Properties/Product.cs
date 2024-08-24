using System;
using System.Collections.Generic;

namespace CSharpEssentials.CS08_Properties
{
    /// <summary>
    /// Product class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Auto-implemented property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Auto-implemented property
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Backing field
        /// </summary>
        private decimal price;

        /// <summary>
        /// Full property with backing field
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                price = value;
            }
        }

        /// <summary>
        /// Read-only property
        /// </summary>
        public bool IsAvailable { get; }

        /// <summary>
        /// Auto-implemented property with a private setter
        /// </summary>
        public int StockQuantity { get; private set; }

        /// <summary>
        /// Property with an expression-bodied member (lambda syntax)
        /// </summary>
        public decimal DiscountedPrice => Price * (1 - Discount / 100);

        /// <summary>
        /// Auto-implemented property for discount
        /// </summary>
        public decimal Discount { get; set; } = 0;  // Default discount is 0%

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="price"></param>
        /// <param name="stockQuantity"></param>
        public Product(string name, string category, decimal price, int stockQuantity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;

            // Read-only property can be set only in constructor
            IsAvailable = StockQuantity > 0;
        }

        /// <summary>
        /// Method to simulate selling a product and updating stock
        /// </summary>
        /// <param name="quantity"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public void Sell(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            if (quantity > StockQuantity)
                throw new InvalidOperationException("Not enough stock available.");

            StockQuantity -= quantity;

            // Update the availability based on the stock quantity
            if (StockQuantity == 0)
            {
                Console.WriteLine($"{Name} is now out of stock.");
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Category}) - Price: {Price:C}, Discounted Price: {DiscountedPrice:C}, Stock: {StockQuantity}, Available: {IsAvailable}";
        }
    }
}
