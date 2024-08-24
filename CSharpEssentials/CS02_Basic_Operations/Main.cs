using System;

namespace CSharpEssentials.CS02_Basic_Operations 
{
    public class Main
    {
        /// <summary>
        /// In this example we demonstrate basic operations on different data types in C#.
        /// It involves performing arithmetic, logical, and string operations.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS02_Basic_Operations");

            // Basic data types
            int age = 30;                                   // Integer
            double height = 1.78;                           // Double (for height in meters)
            decimal salary = 55000.75m;                     // Decimal (for salary)
            char initial = 'J';                             // Char (initial of the first name)
            bool isEmployed = true;                         // Boolean (employment status)
            string name = "John Doe";                       // String (full name)
            DateTime birthDate = new DateTime(1994, 5, 25); // DateTime (birth date)

            // Arithmetic operations
            int yearsUntilRetirement = 65 - age;            // Calculate years until retirement
            double heightInCentimeters = height * 100;      // Convert height to centimeters
            decimal annualSalary = salary * 12;             // Calculate annual salary

            // Division and remainder operations
            int daysWorked = 220;
            int weeksWorked = daysWorked / 7;               // Integer division to find the number of weeks worked
            int remainingDays = daysWorked % 7;             // Remainder of days after weeks worked

            double totalBill = 123.45;                      // Example bill amount
            double amountPaid = 100.00;                     // Amount paid
            double balance = totalBill - amountPaid;        // Calculate balance after payment

            // Display results
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Initial: {initial}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Height: {height} meters");
            Console.WriteLine($"Height in cm: {heightInCentimeters} cm");
            Console.WriteLine($"Salary: {salary:C}");
            Console.WriteLine($"Annual Salary: {annualSalary:C}");
            Console.WriteLine($"Years until retirement: {yearsUntilRetirement}");
            Console.WriteLine($"Weeks Worked: {weeksWorked}");
            Console.WriteLine($"Remaining Days After Weeks Worked: {remainingDays}");
            Console.WriteLine($"Total Bill: {totalBill:C}");
            Console.WriteLine($"Amount Paid: {amountPaid:C}");
            Console.WriteLine($"Balance: {balance:C}");
            Console.WriteLine($"Is Adult: {age >= 18}");
            Console.WriteLine($"Is Eligible for Benefits: {isEmployed && annualSalary > 50000}");
            Console.WriteLine($"Greeting: Hello, {name}!");
            Console.WriteLine($"Name in Upper Case: {name.ToUpper()}");
        }
    }
}
