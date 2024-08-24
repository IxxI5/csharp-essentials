using System;
using System.Collections.Generic;

namespace CSharpEssentials.CS19_Events
{
    /// <summary>
    /// StockMonitor Class: This class listens for the PriceChanged event. When the event is triggered, it reacts by storing any price changes in a list. 
    /// The stored changes can then be displayed on demand.
    /// </summary>
    public class StockMonitor
    {
        // List that stores any occuring _priceChanges
        private readonly List<PriceChangedEventArgs> _priceChanges = new List<PriceChangedEventArgs>();

        /// <summary>
        /// Subscribe to price change events
        /// </summary>
        /// <param name="stock"></param>
        public void Subscribe(Stock stock)
        {
            // Subscribe to the PriceChanged event
            stock.PriceChanged += OnPriceChanged;
        }

        private void OnPriceChanged(object sender, PriceChangedEventArgs e)
        {
            // Store the price change in the list
            _priceChanges.Add(e);
        }

        /// <summary>
        /// Method to display the stored price changes
        /// </summary>
        public void DisplayPriceChanges()
        {
            Console.WriteLine("Price changes recorded:");

            foreach (var change in _priceChanges)
            {
                Console.WriteLine($"Symbol: {change.Symbol}, New Price: {change.NewPrice:C}");
            }
        }
    }
}
