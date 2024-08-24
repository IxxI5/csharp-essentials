using System;

namespace CSharpEssentials.CS12_Abstraction.Abstracts
{
    /// <summary>
    /// CreditCardProcessor derived class
    /// </summary>
    public class CreditCardProcessor : PaymentProcessor
    {
        /// <summary>
        /// Implementation of the abstract method ValidatePaymentDetails
        /// </summary>
        /// <returns></returns>
        protected override bool ValidatePaymentDetails()
        {
            Console.WriteLine("Validating credit card details...");
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
            Console.WriteLine($"Authorizing credit card payment of {amount:C}...");
            // Add authorization logic here.
            return true;
        }

        /// <summary>
        /// Implementation of the abstract method CapturePayment
        /// </summary>
        /// <param name="amount"></param>
        protected override void CapturePayment(decimal amount)
        {
            Console.WriteLine($"Capturing credit card payment of {amount:C}...");
            // Add capture logic here.
        }
    }
}
