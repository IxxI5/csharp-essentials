using System;

namespace CSharpEssentials.CS13_Exception_Handling.Custom
{
    /// <summary>
    /// Custom exception for insufficient funds
    /// </summary>
    public class InsufficientFundsException : InvalidOperationException
    {
        public decimal AttemptedWithdrawal { get; }
        public decimal CurrentBalance { get; }

        /// <summary>
        /// Constructor with custom message and data
        /// </summary>
        /// <param name="attemptedWithdrawal"></param>
        /// <param name="currentBalance"></param>
        public InsufficientFundsException(decimal attemptedWithdrawal, decimal currentBalance)
            : base($"Insufficient funds: Tried to withdraw {attemptedWithdrawal:C}, but only {currentBalance:C} is available.")
        {
            AttemptedWithdrawal = attemptedWithdrawal;
            CurrentBalance = currentBalance;
        }

        /// <summary>
        /// Method to get detailed information about the exception
        /// </summary>
        /// <returns></returns>
        public string GetDetails()
        {
            return $"Attempted Withdrawal: {AttemptedWithdrawal:C}, Available Balance: {CurrentBalance:C}";
        }
    }

}
