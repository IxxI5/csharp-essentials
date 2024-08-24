using System;

namespace CSharpEssentials.CS06_Methods
{
    public class Main
    {
        // Define the initial balance for the bank account
        static decimal balance = 1000.00m;

        /// <summary>
        /// This is a simple Bank Account Management System that performs operations such as depositing, withdrawing, and checking the balance.
        /// The example illustrates how to use methods to encapsulate functionality and manage state.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS06_Methods");

            // Display the main menu
            ShowMenu();
        }

        /// <summary>
        /// Method to display the main menu
        /// </summary>
        static void ShowMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Bank Account Management System");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CheckBalance();
                        break;
                    case "2":
                        Deposit();
                        break;
                    case "3":
                        Withdraw();
                        break;
                    case "4":
                        keepRunning = false;
                        Console.WriteLine("Thank you for using the Bank Account Management System.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (keepRunning)
                {
                    Console.WriteLine("Press Enter to return to the menu...");
                    Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// Method to check the balance
        /// </summary>
        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: {balance:C}");
        }

        /// <summary>
        /// Method to deposit money
        /// </summary>
        static void Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
            {
                balance += depositAmount;
                Console.WriteLine($"Successfully deposited {depositAmount:C}. Your new balance is {balance:C}.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }

        /// <summary>
        /// Method to withdraw money
        /// </summary>
        static void Withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0)
            {
                if (withdrawAmount <= balance)
                {
                    balance -= withdrawAmount;
                    Console.WriteLine($"Successfully withdrew {withdrawAmount:C}. Your new balance is {balance:C}.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }
    }
}
