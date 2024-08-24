using System;

namespace CSharpEssentials.CS12_Abstraction.Interfaces
{
    /// <summary>
    /// IPaymentProcessor interface will define the contract that all payment processors must follow.
    /// It includes methods for validating payment details, authorizing payment, capturing payment, and sending a receipt.
    /// </summary>
    interface IPaymentProcessor
    {
        bool ValidatePaymentDetails();
        bool AuthorizePayment(decimal amount);
        void CapturePayment(decimal amount);
        void SendReceipt();
    }
}
