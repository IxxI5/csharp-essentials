using System;
using System.Threading.Tasks;

namespace CSharpEssentials.CS21_Async_Await
{
    public class Main
    {
        /// <summary>
        /// An application fetches user data from a web service, processes the data, and then saves it to a database. 
        /// </summary>
        /// <returns></returns>
        public static async Task Demo()
        {
            Console.WriteLine("CS21_Async_Await");

            Console.WriteLine("Application started.");

            // Fetch, process, and save user data asynchronously
            await UserDataService.FetchProcessAndSaveUserDataAsync();

            Console.WriteLine("Operation completed. Press any key to exit.");
            Console.ReadKey();
        }

        /* Execution Flow:
         * The program fetches user data from the web asynchronously.
         * The fetched data is processed asynchronously.
         * The processed data is saved to the simulated database asynchronously.
         * Finally, the contents of the simulated database (the List<string>) are displayed to the console.
         */
    }
}
