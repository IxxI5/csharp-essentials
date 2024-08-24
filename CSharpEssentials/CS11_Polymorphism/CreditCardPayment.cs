using System;

namespace CSharpEssentials.CS11_Polymorphism
{
    /// <summary>
    /// Derived class for Credit Card Payment
    /// </summary>
    public class CreditCardPayment : Payment
    {
        // Properties
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Constructor for credit card payment that calls the base class
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="cardNumber"></param>
        /// <param name="cardHolderName"></param>
        /// <param name="expiryDate"></param>
        public CreditCardPayment(decimal amount, string cardNumber, string cardHolderName, string expiryDate)
            : base(amount)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpiryDate = expiryDate;
        }

        /// <summary>
        /// Override method to process the credit card payment
        /// </summary>
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing credit card payment of {Amount:C}...");
            Console.WriteLine($"Card Number: {CardNumber}, Card Holder: {CardHolderName}, Expiry Date: {ExpiryDate}");
            // Simulate payment processing logic
            Console.WriteLine("Credit card payment processed successfully.\n");
        }
    }
}
