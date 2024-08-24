using System;

namespace CSharpEssentials.CS11_Polymorphism
{
    public class Main
    {
        /// <summary>
        /// We create a Payment Processing System that supports multiple payment methods, such as Credit Card and PayPal.
        /// Polymorphism can be demonstrated using a common base class (Payment) and overriding a method (ProcessPayment) in 
        /// derived classes (CreditCardPayment and PayPalPayment).
        /// Payment (Base Class): Contains a virtual method ProcessPayment which is overridden in derived classes.
        /// CreditCardPayment (Derived Class): Implements specific logic for processing credit card payments.
        /// PayPalPayment (Derived Class): Implements specific logic for processing PayPal payments.
        /// PaymentProcessor: A class that processes payments by working with objects of the base class type (Payment).
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS11_Polymorphism");

            // Create instances of different payment methods
            Payment creditCardPayment = new CreditCardPayment(100.50m, "1234-5678-9012-3456", "John Doe", "12/24");
            Payment payPalPayment = new PayPalPayment(250.75m, "john.doe@example.com");

            // Create a payment processor
            PaymentProcessor paymentProcessor = new PaymentProcessor();

            // Process payments using polymorphism
            paymentProcessor.Process(creditCardPayment);  // Processes the credit card payment
            paymentProcessor.Process(payPalPayment);      // Processes the PayPal payment
        }

        /* 1. Base Class (Payment):
         *    Abstract Class: Payment is an abstract class, meaning it cannot be instantiated directly. It serves as a base for specific payment methods.
         *    Abstract Method: The ProcessPayment method is declared as abstract, which means that it must be implemented by any non-abstract derived class.
         * 2. Derived Class (CreditCardPayment):
         *    Properties: It has additional properties specific to credit card payments, such as CardNumber, CardHolderName, and ExpiryDate.
         *    Overridden Method: The ProcessPayment method is overridden to implement the specific logic for processing credit card payments.
         * 3. Derived Class (PayPalPayment):
         *    Properties: It has an additional property specific to PayPal payments, Email.
         *    Overridden Method: The ProcessPayment method is overridden to implement the specific logic for processing PayPal payments.
         * 4. PaymentProcessor:
         *    Polymorphic Behavior: The Process method accepts a Payment object (base class) as a parameter, allowing it to work with any 
         *    derived class object (CreditCardPayment or PayPalPayment).
         *    When Process is called with a Payment object, it invokes the ProcessPayment method, which is executed based on the actual 
         *    type of the object passed in, demonstrating polymorphism.
         */
    }
}
