using System;

namespace CSharpEssentials.CS03_Conditional_Statements 
{
    public class Main
    {
        /// <summary>
        /// In this example we simulate a customer support system that processes service requests based on the type of request, 
        /// customer priority, and request urgency, showcasing different types of conditional logic to handle various cases.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS03_Conditional_Statements");

            // Example data for customer service request
            string requestType = "Technical Issue";                                 // Type of request (e.g., Technical Issue, Billing Inquiry)
            int customerPriority = 1;                                               // Priority level of the customer (1 = High, 2 = Medium, 3 = Low)
            DateTime requestDate = DateTime.Now;                                    // Date when the request was made
            TimeSpan timeSinceRequest = DateTime.Now - requestDate;                 // Time elapsed since request was made
            bool isUrgent = timeSinceRequest.TotalHours < 1;                        // Request is urgent if made within the last hour

            // Processing the request
            Console.WriteLine("Processing Customer Service Request:");

            // Check the type of request
            if (requestType == "Technical Issue")
            {
                Console.WriteLine("Request Type: Technical Issue");

                // Check customer priority and urgency
                if (customerPriority == 1)
                {
                    if (isUrgent)
                    {
                        Console.WriteLine("Priority: High");
                        Console.WriteLine("Status: Immediate Attention Required! Assign to top-tier technical support.");
                    }
                    else
                    {
                        Console.WriteLine("Priority: High");
                        Console.WriteLine("Status: Urgent, but can be handled within the next 2 hours.");
                    }
                }
                else if (customerPriority == 2)
                {
                    if (isUrgent)
                    {
                        Console.WriteLine("Priority: Medium");
                        Console.WriteLine("Status: Immediate Attention Required. Assign to technical support team.");
                    }
                    else
                    {
                        Console.WriteLine("Priority: Medium");
                        Console.WriteLine("Status: Will be addressed in the next 24 hours.");
                    }
                }
                else
                {
                    Console.WriteLine("Priority: Low");
                    Console.WriteLine("Status: Non-urgent Technical Issue. Will be addressed within the next 48 hours.");
                }
            }
            else if (requestType == "Billing Inquiry")
            {
                Console.WriteLine("Request Type: Billing Inquiry");

                // Check customer priority and urgency
                if (customerPriority == 1)
                {
                    if (isUrgent)
                    {
                        Console.WriteLine("Priority: High");
                        Console.WriteLine("Status: Immediate Attention Required! Escalate to billing specialist.");
                    }
                    else
                    {
                        Console.WriteLine("Priority: High");
                        Console.WriteLine("Status: Urgent, but will be handled within 24 hours.");
                    }
                }
                else if (customerPriority == 2)
                {
                    if (isUrgent)
                    {
                        Console.WriteLine("Priority: Medium");
                        Console.WriteLine("Status: Will be handled within 24 hours.");
                    }
                    else
                    {
                        Console.WriteLine("Priority: Medium");
                        Console.WriteLine("Status: Response expected within 3 business days.");
                    }
                }
                else
                {
                    Console.WriteLine("Priority: Low");
                    Console.WriteLine("Status: Response will be provided within 5 business days.");
                }
            }
            else
            {
                Console.WriteLine("Request Type: Other");
                Console.WriteLine("Status: Will be reviewed by the appropriate department.");
            }

            // End of request processing
            Console.WriteLine("Request Processing Completed.");
        }
    }
}
