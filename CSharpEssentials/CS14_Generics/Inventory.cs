using System;
using System.Collections.Generic;

namespace CSharpEssentials.CS14_Generics
{
    /// <summary>
    /// Generic Inventory class to manage different types of items
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Inventory<T>
    {
        private readonly List<T> items;

        public Inventory()
        {
            items = new List<T>();
        }

        /// <summary>
        /// Add an item to the inventory
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"Item added: {item}");
        }

        /// <summary>
        /// Remove an item from the inventory
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItem(T item)
        {
            if (items.Contains(item))       // Uses Equals implicitly and Equals uses GetHashCode implicitly both for objects comparison
            {
                items.Remove(item);         // Uses Equals implicitly and Equals uses GetHashCode implicitly both for objects comparison
                Console.WriteLine($"Item removed: {item}");
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }

            // Equals and GetHashCode methods must be overriden within the item classes (Book, Electronics, Clothing) in order to have correct objects comparison
            // while searching to find (see Contains) an object inside a list of objects
        }

        /// <summary>
        /// Display all items in the inventory
        /// </summary>
        public void DisplayItems()
        {
            Console.WriteLine("Inventory contains:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
