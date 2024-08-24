using System;

namespace CSharpEssentials.CS12_Abstraction.Abstracts
{
    /// <summary>
    /// BankTransferProcessor derived class
    /// </summary>
    public class BankTransferProcessor : PaymentProcessor
    {
        /// <summary>
        /// Implementation of the abstract method ValidatePaymentDetails
        /// </summary>
        /// <returns></returns>
        protected override bool ValidatePaymentDetails()
        {
            Console.WriteLine("Validating bank transfer details...");
            // Add specific validation logic here.
            return true;
        }

        /// <summary>
        /// Implementation of the abstract method AuthorizePayment
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        protected override bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine($"Authorizing bank transfer of {amount:C}...");
            // Add authorization logic here.
            return true;
        }

        /// <summary>
        /// Implementation of the abstract method CapturePayment
        /// </summary>
        /// <param name="amount"></param>
        protected override void CapturePayment(decimal amount)
        {
            Console.WriteLine($"Capturing bank transfer of {amount:C}...");
            // Add capture logic here.
        }

        // No need to override SendReceipt unless specific behavior is required.
    }
}
