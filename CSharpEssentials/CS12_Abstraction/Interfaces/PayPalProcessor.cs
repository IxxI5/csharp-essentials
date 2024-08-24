using System;

namespace CSharpEssentials.CS12_Abstraction.Interfaces
{
    /// <summary>
    /// PayPalProcessor class that implements the IPaymentProcessor interface
    /// </summary>
    public class PayPalProcessor : IPaymentProcessor
    {
        /// <summary>
        /// Implementation of the interface IPaymentProcessor method ValidatePaymentDetails
        /// </summary>
        /// <returns></returns>
        public bool ValidatePaymentDetails()
        {
            Console.WriteLine("Validating PayPal account details...");
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
            Console.WriteLine($"Authorizing PayPal payment of {amount:C}...");
            // Add authorization logic here.
            return true;
        }

        /// <summary>
        /// Implementation of the interface IPaymentProcessor method CapturePayment
        /// </summary>
        /// <param name="amount"></param>
        public void CapturePayment(decimal amount)
        {
            Console.WriteLine($"Capturing PayPal payment of {amount:C}...");
            // Add capture logic here.
        }

        /// <summary>
        /// Method to send the receipt to customer
        /// </summary>
        public void SendReceipt()
        {
            Console.WriteLine("Sending PayPal receipt...");
        }
    }
}
