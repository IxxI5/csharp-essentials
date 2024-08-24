using System;

namespace CSharpEssentials.CS13_Exception_Handling.Custom
{
    public class Main
    {
        /// <summary>
        /// Demonstration of a Banking System with Enhanced Exception Handling.
        /// Creation of bank accounts validated through Exception Handling.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS13_Exception_Handling.Custom");

            try
            {
                // Create a new bank account with an invalid initial balance
                BankAccount account1 = new BankAccount("123456789", -100.00m);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Range Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Error: {ex.Message}");
            }

            try
            {
                // Create a new bank account with a valid initial balance
                BankAccount account2 = new BankAccount("987654321", 500.00m);

                // Attempt to withdraw an invalid amount (negative amount)
                account2.Withdraw(-50.00m);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Range Error: {ex.Message}");
            }

            try
            {
                // Create another bank account
                BankAccount account3 = new BankAccount("555555555", 200.00m);

                // Attempt to withdraw more than the available balance
                account3.Withdraw(300.00m);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Details: {ex.GetDetails()}");
            }

            try
            {
                // Create a bank account with valid data
                BankAccount account4 = new BankAccount("123123123", 300.00m);

                // Withdraw a valid amount
                account4.Withdraw(100.00m);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Transaction processing completed.");
            }

            /* 1. System Exceptions:
             *    ArgumentException: Used in the BankAccount constructor to handle invalid account numbers.
             *    ArgumentOutOfRangeException: Used in the constructor to handle negative initial balances and in the Withdraw method for invalid withdrawal amounts.
             * 2. Custom Exception with Additional Information:
             *    InsufficientFundsException: This custom exception class now inherits from InvalidOperationException. 
             *    It accepts the attempted withdrawal amount and the current balance in its constructor and uses this information to build a detailed error message. 
             *    The GetDetails() method provides additional information about the exception, which can be useful for logging or debugging.
             * 3. Exception Handling in Main:
             *    First try-catch block: Attempts to create a bank account with an invalid initial balance, catching ArgumentException and ArgumentOutOfRangeException.
             *    Second try-catch block: Attempts to withdraw a negative amount, catching ArgumentOutOfRangeException.
             *    Third try-catch block: Attempts to withdraw more than the available balance, catching InsufficientFundsException and printing detailed error information.
             *    Fourth try-catch-finally block: Handles general exceptions while ensuring that transaction processing is always marked as completed using the finally block.
             */
        }
    }
}
