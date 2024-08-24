using System;

namespace CSharpEssentials.CS12_Abstraction.Abstracts
{
    public class Main 
    {
        /// <summary>
        /// This example demonstrates the use of abstraction (using abstract classes) in a scenario involving a payment processing system.
        /// We have multiple payment methods such as credit cards, PayPal, and bank transfers. Each payment method 
        /// shares common behaviors (e.g., ProcessPayment, ValidatePaymentDetails, etc.) but also has specific behaviors or implementations.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS12_Abstraction.Abstracts");

            PaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentProcessor paypalProcessor = new PayPalProcessor();
            PaymentProcessor bankTransferProcessor = new BankTransferProcessor();

            Console.WriteLine("Processing Credit Card Payment:");
            creditCardProcessor.ProcessPayment(100.00m);
            Console.WriteLine();

            Console.WriteLine("Processing PayPal Payment:");
            paypalProcessor.ProcessPayment(50.00m);
            Console.WriteLine();

            Console.WriteLine("Processing Bank Transfer Payment:");
            bankTransferProcessor.ProcessPayment(200.00m);
        }

        /* Abstraction in C# is a fundamental concept of object-oriented programming (OOP) that involves hiding the complex 
         * implementation details of a system and exposing only the essential features or behaviors. 
         * This is often achieved using abstract classes and interfaces.     
         * 
         * 1. Abstraction: The PaymentProcessor class abstracts the common behavior of all payment processors. 
         *    It provides a template method ProcessPayment that defines the high-level algorithm for processing payments, 
         *    while the specific steps (ValidatePaymentDetails, AuthorizePayment, and CapturePayment) are left for the derived classes to implement.
         * 2. Encapsulation: The internal logic of validating, authorizing, and capturing payments is encapsulated within the derived classes. 
         *    The client code (e.g., Main method) doesn't need to know the details of how each payment method works; it just calls ProcessPayment.
         * 3. Polymorphism: The client code interacts with different types of payment processors (CreditCardProcessor, PayPalProcessor, and BankTransferProcessor) 
         *    through the common PaymentProcessor interface, allowing for polymorphic behavior.
         */
    }
}
