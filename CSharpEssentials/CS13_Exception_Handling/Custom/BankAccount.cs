using System;

namespace CSharpEssentials.CS13_Exception_Handling.Custom
{
    /// <summary>
    /// BankAccount class representing a bank account
    /// </summary>
    public class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; private set; }

        /// <summary>
        /// Constructor to initialize the bank account
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="initialBalance"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                throw new ArgumentException("Account number cannot be null or empty.", nameof(accountNumber));
            }

            if (initialBalance < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance cannot be negative.");
            }

            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        /// <summary>
        /// Method to withdraw money from the account
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="InsufficientFundsException"></exception>
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be greater than zero.");
            }

            if (amount > Balance)
            {
                throw new InsufficientFundsException(amount, Balance);
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawal of {amount:C} successful. New balance: {Balance:C}");
        }
    }
}
