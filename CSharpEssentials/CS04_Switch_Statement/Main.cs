using System;

namespace CSharpEssentials.CS04_Switch_Statement
{
    public class Main
    {
        /// <summary>
        /// This example simulates a simple restaurant order system where the program processes different types of food orders and
        /// calculates the total cost based on the selected menu items.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS04_Switch_Statement");

            // Sample order data
            string foodItem = "Pizza";  // Menu item chosen by the customer
            int quantity = 2;           // Number of items ordered
            double totalCost = 0.0;     // Total cost of the order

            // Calculate cost based on food item
            switch (foodItem)
            {
                case "Pizza":
                    totalCost = quantity * 12.99; // Price per Pizza
                    Console.WriteLine("You have ordered Pizza.");
                    break;

                case "Burger":
                    totalCost = quantity * 8.49;  // Price per Burger
                    Console.WriteLine("You have ordered Burger.");
                    break;

                case "Pasta":
                    totalCost = quantity * 10.99; // Price per Pasta
                    Console.WriteLine("You have ordered Pasta.");
                    break;

                case "Salad":
                    totalCost = quantity * 6.99;  // Price per Salad
                    Console.WriteLine("You have ordered Salad.");
                    break;

                case "Soda":
                    totalCost = quantity * 2.49;  // Price per Soda
                    Console.WriteLine("You have ordered Soda.");
                    break;

                default:
                    Console.WriteLine("Sorry, we don't have that item on the menu.");
                    totalCost = 0.0;
                    break;
            }

            // Display the total cost
            if (totalCost > 0)
            {
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total Cost: {totalCost:C}");
            }

            // Additional handling based on order quantity
            if (quantity > 10)
            {
                Console.WriteLine("Thank you for your large order! A discount will be applied.");
                totalCost *= 0.9; // Apply a 10% discount
                Console.WriteLine($"Discounted Total Cost: {totalCost:C}");
            }

            Console.WriteLine("Thank you for ordering with us!");
        }
    }
}
