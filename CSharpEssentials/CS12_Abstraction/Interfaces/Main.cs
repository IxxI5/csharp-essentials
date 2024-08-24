using System;

namespace CSharpEssentials.CS12_Abstraction.Interfaces
{
    public class Main 
    {
        /// <summary>
        /// This example demonstrates the use of abstraction (using interfaces) in a scenario involving a payment processing system.
        /// We have multiple payment methods such as credit cards, PayPal, and bank transfers. Each payment method 
        /// shares common behaviors (e.g., ProcessPayment, ValidatePaymentDetails, etc.) but also has specific behaviors or implementations.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS12_Abstraction.Interfaces");

            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            IPaymentProcessor paypalProcessor = new PayPalProcessor();
            IPaymentProcessor bankTransferProcessor = new BankTransferProcessor();

            ProcessPayment(creditCardProcessor, 100.00m);
            Console.WriteLine();

            ProcessPayment(paypalProcessor, 50.00m);
            Console.WriteLine();

            ProcessPayment(bankTransferProcessor, 200.00m);
        }

        static void ProcessPayment(IPaymentProcessor processor, decimal amount)
        {
            if (processor.ValidatePaymentDetails())
            {
                if (processor.AuthorizePayment(amount))
                {
                    processor.CapturePayment(amount);
                    processor.SendReceipt();
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

        /* Abstraction in C# is a fundamental concept of object-oriented programming (OOP) that involves hiding the complex 
         * implementation details of a system and exposing only the essential features or behaviors. 
         * This is often achieved using abstract classes and interfaces. 
         * 
         * 1. Interface: The IPaymentProcessor interface defines a contract that all payment processors must follow. 
         *    It specifies the methods ValidatePaymentDetails, AuthorizePayment, CapturePayment, and SendReceipt, but does not provide any implementation.
         * 2. Implementation: Each payment processor class (CreditCardProcessor, PayPalProcessor, BankTransferProcessor) implements the 
         *    IPaymentProcessor interface, providing specific logic for each method. This allows different payment processors to have their own implementations 
         *    while adhering to the same contract.
         * 3. Client Code: The ProcessPayment method in the client code accepts any object that implements the IPaymentProcessor interface. 
         *    This allows for flexible and polymorphic behavior, as different payment processors can be used interchangeably.
         * 4. Polymorphism: By using interfaces, the client code (Demo method) is decoupled from the specific implementations of the payment processors. 
         *    This allows for easy extension of the system by adding new payment processors without modifying the existing client code.
         */
    }
}
