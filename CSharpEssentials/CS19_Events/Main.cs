using System;

namespace CSharpEssentials.CS19_Events
{
    public class Main
    {
        /// <summary>
        /// Simulating a simple stock price monitoring system. In this example, we will have a Stock class that triggers an event whenever the stock price changes. 
        /// We will also have a StockMonitor class that subscribes to this event and takes action when the event is triggered and stores all the price changes in a list. 
        /// The stored changes can then be displayed on demand.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS19_Events");

            // Create a stock instance
            Stock appleStock = new Stock("AAPL", 150.00m);

            // Create a StockMonitor instance
            StockMonitor monitor = new StockMonitor();

            // Subscribe to the stock's price change event
            monitor.Subscribe(appleStock);

            // Change the price to trigger the event
            appleStock.Price = 155.00m;
            appleStock.Price = 160.00m;
            appleStock.Price = 158.00m;

            // Display the stored price changes on demand
            monitor.DisplayPriceChanges();

        }

        /* Execution Flow:
         * 1. Stock Initialization: The appleStock object is created with the symbol "AAPL" and price 150.00m.
         * 2. StockMonitor Initialization: The monitor object is created, initializing an empty list _priceChanges.
         * 3. Event Subscription: monitor.Subscribe(appleStock) subscribes the OnPriceChanged method of monitor to the PriceChanged event of appleStock.
         * 4. Price Changes: The Price property of appleStock is set to new values, triggering the PriceChanged event each time.
         * 5. Event Handling: Each time the PriceChanged event is triggered, the OnPriceChanged method of monitor stores the price change in _priceChanges.
         * 6. Display Price Changes: The DisplayPriceChanges method is called to display all the stored price changes.
         */
    }
}
