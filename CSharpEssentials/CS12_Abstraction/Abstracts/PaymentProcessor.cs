using System;

namespace CSharpEssentials.CS12_Abstraction.Abstracts
{
    /// <summary>
    /// Abstract class PaymentProcessor defines the template method ProcessPayment, which is a general sequence of steps that all payment processors must follow. 
    /// Specific payment methods will inherit from this class and implement the abstract methods.
    /// </summary>
    public abstract class PaymentProcessor
    {
        /// <summary>
        /// Template method defining the steps of payment processing.
        /// </summary>
        /// <param name="amount"></param>
        public void ProcessPayment(decimal amount)
        {
            if (ValidatePaymentDetails())
            {
                if (AuthorizePayment(amount))
                {
                    CapturePayment(amount);
                    SendReceipt();
                }
                else
                {
                    Console.WriteLine("Payment authorization failed.");
                }
            }
            else
            {
                Console.WriteLine("Payment details validation failed.");
            }
        }

        // Abstract methods that must be implemented by derived classes.
        protected abstract bool ValidatePaymentDetails();
        protected abstract bool AuthorizePayment(decimal amount);
        protected abstract void CapturePayment(decimal amount);

        /// <summary>
        /// A common method that may be used by all derived classes.
        /// </summary>
        protected virtual void SendReceipt()
        {
            Console.WriteLine("Receipt sent to customer.");
        }
    }
}
