using System;

namespace CSharpEssentials.CS01_Data_Types 
{
    /// <summary>
    /// Enum Role (Job Role).
    /// Note: It is always placed outside the class.
    /// </summary>
    enum Role { Manager, Developer, Designer, QA, HR }

    public class Main
    {
        /// <summary>
        /// This example simulates a simple payroll system with employee data and salary calculations.
        /// Demonstration of data types use.
        /// </summary>
        public static void Demo() 
        {
            Console.WriteLine("CS01_Data_Types");

            // Declare and initialize basic data types
            int employeeId = 12345;                                     // Employee ID
            string employeeName = "John Doe";                           // Employee Name
            char employeeGender = 'M';                                  // Employee Gender
            bool isActive = true;                                       // Employee status (active/inactive)
            DateTime dateOfJoining = new DateTime(2022, 1, 15);         // Date of joining
            float hoursWorked = 160.5f;                                 // Hours worked in a month
            decimal hourlyRate = 35.75m;                                // Hourly rate in decimal for precision
            Role employeeRole = Role.Developer;                         // Role of the employee

            // Display employee information
            Console.WriteLine("Employee Information");
            Console.WriteLine($"ID: {employeeId}");
            Console.WriteLine($"Name: {employeeName}");
            Console.WriteLine($"Gender: {employeeGender}");
            Console.WriteLine($"Active: {isActive}");
            Console.WriteLine($"Date of Joining: {dateOfJoining.ToShortDateString()}");
            Console.WriteLine($"Role: {employeeRole}");
            Console.WriteLine($"Hours Worked: {hoursWorked}");
            Console.WriteLine($"Hourly Rate: {hourlyRate:C}");

            // Calculate salary
            decimal salary = (decimal)hoursWorked * hourlyRate;

            // Display salary
            Console.WriteLine($"Salary: {salary:C}");

        }
    }
}
