using System;
using System.Threading.Tasks;

namespace CSharpEssentials.CS21_Async_Await
{
    public static class UserDataService
    {
        // Simulate a database with a List
        private static List<string> database = new List<string>();

        /// <summary>
        /// FetchProcessAndSaveUserDataAsync Method: This method orchestrates the overall flow by calling three async methods:
        /// FetchUserDataAsync, ProcessUserDataAsync, SaveDataToDatabaseAsync
        /// </summary>
        /// <returns></returns>
        public static async Task FetchProcessAndSaveUserDataAsync()
        {
            // Step 1: Fetch user data from a web API
            var userData = await FetchUserDataAsync("https://jsonplaceholder.typicode.com/users/1");

            // Step 2: Process the user data (e.g., extracting and transforming)
            var processedData = await ProcessUserDataAsync(userData);

            // Step 3: Save the processed data to the simulated database
            await SaveDataToDatabaseAsync(processedData);

            // Display the contents of the simulated database
            DisplayDatabaseContents();
        }

        /// <summary>
        /// FetchUserDataAsync: Fetches user data from a given URL asynchronously.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static async Task<string> FetchUserDataAsync(string url)
        {
            using HttpClient client = new HttpClient();
            Console.WriteLine("Fetching user data...");

            // Simulate network delay
            await Task.Delay(2000);

            var response = await client.GetStringAsync(url);
            Console.WriteLine("User data fetched.");

            return response;
        }

        /// <summary>
        /// ProcessUserDataAsync: Simulates processing of the fetched data.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static async Task<string> ProcessUserDataAsync(string data)
        {
            Console.WriteLine("Processing user data...");

            // Simulate data processing delay
            await Task.Delay(1000);

            var processedData = data.ToUpper(); // Example of processing
            Console.WriteLine("User data processed.");

            return processedData;
        }

        /// <summary>
        /// SaveDataToDatabaseAsync: Simulates saving the processed data to a database.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static async Task SaveDataToDatabaseAsync(string data)
        {
            Console.WriteLine("Saving data to the simulated database...");

            // Simulate database save delay
            await Task.Delay(1000);

            database.Add(data);

            Console.WriteLine("Data saved to the simulated database.");
        }

        /// <summary>
        /// DisplayDatabaseContents: It shows the contents of the simulated database (which in this case is represented by a List<string>) to the console. 
        /// </summary>
        private static void DisplayDatabaseContents()
        {
            Console.WriteLine("\nContents of the simulated database:");
            foreach (var entry in database)
            {
                Console.WriteLine(entry);
            }
        }

        /* FetchProcessAndSaveUserDataAsync Method: This method orchestrates the overall flow by calling three async methods:
         * FetchUserDataAsync: Fetches user data from a given URL asynchronously.
         * ProcessUserDataAsync: Simulates processing of the fetched data.
         * SaveDataToDatabaseAsync: Simulates saving the processed data to a database.
         * DisplayDatabaseContents; Displays the content of the simulated database (in our case it is a List).
         * 
         * FetchUserDataAsync Method: Uses HttpClient to asynchronously fetch data from a web API. await Task.Delay(2000); simulates network latency.
         * ProcessUserDataAsync Method: Simulates some processing on the fetched data. The await Task.Delay(1000); simulates the time taken to process the data.
         * SaveDataToDatabaseAsync Method: Simulates saving data to a database with a delay.
         * 
         * Key Points:
         * async keyword allows a method to be asynchronous.
         * await keyword is used to asynchronously wait for a task to complete.
         * The application remains responsive while the tasks are being executed, as they do not block the main thread.
         * Each await call does not block the thread, instead, it allows other work to be done on the main thread.
         */
    }
}
