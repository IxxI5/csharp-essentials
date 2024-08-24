using System;

namespace CSharpEssentials.CS11_Polymorphism
{
    /// <summary>
    /// Derived class for PayPal Payment
    /// </summary>
    public class PayPalPayment : Payment
    {
        public string Email { get; set; }

        /// <summary>
        /// Parameterized constructor that calls the base constructor
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="email"></param>
        public PayPalPayment(decimal amount, string email)
            : base(amount)
        {
            Email = email;
        }

        /// <summary>
        /// Override method to process the PayPal payment
        /// </summary>
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing PayPal payment of {Amount:C}...");
            Console.WriteLine($"PayPal Account: {Email}");

            // Simulate payment processing logic
            Console.WriteLine("PayPal payment processed successfully.\n");
        }
    }
}
