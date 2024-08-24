using System;

namespace CSharpEssentials.CS19_Events
{
    /// <summary>
    /// PriceChangedEventArgs Class: This is a custom event argument class that holds the details of the event, specifically the stock symbol and the new price.
    /// </summary>
    public class PriceChangedEventArgs : EventArgs
    {
        // Properties
        public string Symbol { get; }
        public decimal NewPrice { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="newPrice"></param>
        public PriceChangedEventArgs(string symbol, decimal newPrice)
        {
            Symbol = symbol;
            NewPrice = newPrice;
        }
    }
}
