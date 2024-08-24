using System;

namespace CSharpEssentials.CS12_Abstraction.Interfaces
{
    /// <summary>
    /// CreditCardProcessor class that implements the IPaymentProcessor interface
    /// </summary>
    public class CreditCardProcessor : IPaymentProcessor
    {
        /// <summary>
        /// Implementation of the interface IPaymentProcessor method ValidatePaymentDetails
        /// </summary>
        /// <returns></returns>
        public bool ValidatePaymentDetails()
        {
            Console.WriteLine("Validating credit card details...");
            // Add specific validation logic here.
            return true;
        }

        /// <summary>
        /// Implementation of the interface IPaymentProcessor method AuthorizePayment
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine($"Authorizing credit card payment of {amount:C}...");
            // Add authorization logic here.
            return true;
        }

        /// <summary>
        /// Implementation of the interface IPaymentProcessor method CapturePayment
        /// </summary>
        /// <param name="amount"></param>
        public void CapturePayment(decimal amount)
        {
            Console.WriteLine($"Capturing credit card payment of {amount:C}...");
            // Add capture logic here.
        }

        /// <summary>
        /// Method to send the receipt to customer
        /// </summary>
        public void SendReceipt()
        {
            Console.WriteLine("Receipt sent to customer.");
        }
    }
}
