using System;

namespace CSharpEssentials.CS11_Polymorphism
{
    /// <summary>
    /// Payment (Base Class): Contains a virtual method ProcessPayment which is overridden in derived classes.
    /// </summary>
    public abstract class Payment
    {
        public decimal Amount { get; set; }

        /// <summary>
        /// Constructor to initialize payment amount
        /// </summary>
        /// <param name="amount"></param>
        public Payment(decimal amount)
        {
            Amount = amount;
        }

        /// <summary>
        /// Virtual method to process the payment
        /// </summary>
        public abstract void ProcessPayment();
    }
}
