using System;
using System.Collections.Generic;

namespace CSharpEssentials.CS14_Generics
{
    public class Main
    {
        /// <summary>
        /// In this example we create an Inventory Management System where we need to manage different types of items like Books, Electronics, and Clothing. 
        /// Using generics, we can create a single Inventory<T> class that can handle any type of item, making the system more flexible and reducing code duplication.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS14_Generics");

            // Create an inventory for books
            Inventory<Book> bookInventory = new Inventory<Book>();
            bookInventory.AddItem(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            bookInventory.AddItem(new Book("1984", "George Orwell"));
            bookInventory.DisplayItems();

            // Create an inventory for electronics
            Inventory<Electronics> electronicsInventory = new Inventory<Electronics>();
            electronicsInventory.AddItem(new Electronics("Smartphone", "Apple"));
            electronicsInventory.AddItem(new Electronics("Laptop", "Dell"));
            electronicsInventory.DisplayItems();

            // Create an inventory for clothing
            Inventory<Clothing> clothingInventory = new Inventory<Clothing>();
            clothingInventory.AddItem(new Clothing("T-Shirt", "M"));
            clothingInventory.AddItem(new Clothing("Jeans", "32"));
            clothingInventory.DisplayItems();

            // Removing an item
            clothingInventory.RemoveItem(new Clothing("T-Shirt", "M"));
            clothingInventory.DisplayItems();
        }

        /* Benefits
         * Code Reusability: Generics allow you to write a single class (Inventory<T>) that can be used with any type, reducing the need for duplicate code.
         * Type Safety: Generics ensure type safety at compile-time, preventing runtime errors related to type casting.
         * Flexibility: The generic inventory class can easily be extended to handle any new types of items without modifying existing code.
         * Maintainability: Changes or improvements to the Inventory<T> class automatically apply to all item types, simplifying maintenance.
         * 
         * Accurate Item Management: By defining equality based on the properties of the objects, you ensure that your inventory management system can correctly find, remove, and manage items.
         * Robust Comparison: Overriding Equals and GetHashCode is a common pattern in C# to enable meaningful comparisons of objects, especially when using collections.
         * Reusability and Flexibility: The generic Inventory<T> class can now reliably manage any type of object as long as that type properly implements equality and hash code generation.
         */
    }
}
