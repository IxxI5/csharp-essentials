using System;

namespace CSharpEssentials.CS19_Events
{
    /// <summary>
    /// Stock Class: This class represents a stock with a symbol and price. It has an event PriceChanged that is triggered whenever the stock price is updated.
    /// </summary>
    public class Stock
    {
        private string _symbol;
        private decimal _price;

        // Define an event using EventHandler<T> delegate
        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="price"></param>
        public Stock(string symbol, decimal price)
        {
            _symbol = symbol;
            _price = price;
        }

        public string Symbol => _symbol;

        /// <summary>
        /// Method to set a price that will subsequently raise an event through the OnPriceChanged method
        /// </summary>
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    // If the price is different, update the price
                    _price = value;
                    // Trigger the event
                    OnPriceChanged(new PriceChangedEventArgs(_symbol, _price));
                }
            }
        }

        /// <summary>
        /// Method to raise the event
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }
}
