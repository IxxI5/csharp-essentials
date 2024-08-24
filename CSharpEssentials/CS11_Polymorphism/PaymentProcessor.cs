using System;

namespace CSharpEssentials.CS11_Polymorphism
{
    /// <summary>
    /// PaymentProcessor class that processes payments using polymorphism
    /// </summary>
    public class PaymentProcessor
    {
        /// <summary>
        /// Method to process payments using polymorphism
        /// </summary>
        /// <param name="payment"></param>
        public void Process(Payment payment)
        {
            payment.ProcessPayment();
        }
    }
}
