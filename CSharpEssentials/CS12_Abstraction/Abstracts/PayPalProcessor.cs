using System;

namespace CSharpEssentials.CS12_Abstraction.Abstracts
{
    /// <summary>
    /// PayPalProcessor derived class
    /// </summary>
    public class PayPalProcessor : PaymentProcessor
    {
        /// <summary>
        /// Implementation of the abstract method ValidatePaymentDetails
        /// </summary>
        /// <returns></returns>
        protected override bool ValidatePaymentDetails()
        {
            Console.WriteLine("Validating PayPal account details...");
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
            Console.WriteLine($"Authorizing PayPal payment of {amount:C}...");
            // Add authorization logic here.
            return true;
        }

        /// <summary>
        /// Implementation of the abstract method CapturePayment
        /// </summary>
        /// <param name="amount"></param>
        protected override void CapturePayment(decimal amount)
        {
            Console.WriteLine($"Capturing PayPal payment of {amount:C}...");
            // Add capture logic here.
        }

        /// <summary>
        /// Optionally override SendReceipt for specific behavior.
        /// </summary>
        protected override void SendReceipt()
        {
            Console.WriteLine("Sending PayPal receipt...");
        }
    }
}
