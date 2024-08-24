using System;
using System.Linq;

namespace CSharpEssentials.CS16_Array_Methods
{
    public class Main 
    {
        /// <summary>
        /// We simulate an Employee Management System, where:
        /// a) It will manage a list of employees.
        /// b) It will use various array methods to manipulate and analyze the employee data.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS16_Array_Methods");

            // Initialize an array of employees
            Employee[] employees = new Employee[]
            {
                new Employee("Alice", 1, 70000m),
                new Employee("Bob", 2, 85000m),
                new Employee("Charlie", 3, 65000m),
                new Employee("David", 4, 90000m),
                new Employee("Eve", 5, 75000m)
            };

            // Display the original array
            Console.WriteLine("Original Employee Array:");
            PrintArray(employees);

            // 1. Sorting the array by salary in ascending order
            Array.Sort(employees, (e1, e2) => e1.Salary.CompareTo(e2.Salary));
            Console.WriteLine("\nSorted by Salary (Ascending):");
            PrintArray(employees);

            // 2. Reversing the array
            Array.Reverse(employees);
            Console.WriteLine("\nReversed Array:");
            PrintArray(employees);

            // 3. Finding an employee with a specific ID
            Employee foundEmployee = Array.Find(employees, e => e.Id == 3);
            Console.WriteLine($"\nFound Employee with ID 3: {foundEmployee}");

            // 4. Finding the index of an employee with a specific name
            int index = Array.FindIndex(employees, e => e.Name == "Eve");
            Console.WriteLine($"\nIndex of Employee with Name 'Eve': {index}");

            // 5. Copying part of the array
            Employee[] employeesSubset = new Employee[2];
            Array.Copy(employees, 1, employeesSubset, 0, 2);
            Console.WriteLine("\nCopied Subset of Employees:");
            PrintArray(employeesSubset);

            // 6. Checking if any employee earns more than 80,000
            bool highEarnerExists = Array.Exists(employees, e => e.Salary > 80000m);
            Console.WriteLine($"\nIs there an employee earning more than 80,000? {highEarnerExists}");

            // 7. Getting a new array of employee names
            string[] employeeNames = Array.ConvertAll(employees, e => e.Name);
            Console.WriteLine("\nEmployee Names:");
            foreach (var name in employeeNames)
            {
                Console.WriteLine(name);
            }

            // 8. Checking if all employees earn more than 60,000
            bool allEarnMoreThan60000 = Array.TrueForAll(employees, e => e.Salary > 60000m);
            Console.WriteLine($"\nDo all employees earn more than 60,000? {allEarnMoreThan60000}");
        }

        /// <summary>
        /// Helper method to print the array of employees
        /// </summary>
        /// <param name="array"></param>
        static void PrintArray(Employee[] array)
        {
            foreach (var employee in array)
            {
                Console.WriteLine(employee);
            }
        }

        /* Array Methods Used:
         * Array.Sort: Sorts the array of Employee objects based on their Salary in ascending order using a custom comparer.
         * Array.Reverse: Reverses the order of elements in the array, so the highest salaries appear first.
         * Array.Find: Finds the first Employee in the array with the specified Id (ID 3 in this case).
         * Array.FindIndex: Finds the index of the first Employee with the specified Name ("Eve").
         * Array.Copy: Copies a subset of the array (starting from index 1 and copying 2 elements) into a new array.
         * Array.Exists: Checks if there is any Employee in the array with a Salary greater than 80,000.
         * Array.ConvertAll: Converts the array of Employee objects to an array of their Name properties.
         * Array.TrueForAll: Checks if all Employee objects in the array have a Salary greater than 60,000.
         * 
         * Sort: Ordering elements based on a criterion.
         * Reverse: Reversing the order of elements.
         * Find: Locating an element based on a condition.
         * FindIndex: Finding the index of an element that matches a condition.
         * Copy: Creating a new array from a subset of the original.
         * Exists: Checking if any element matches a condition.
         * ConvertAll: Transforming elements into a different type or value.
         * TrueForAll: Verifying if all elements meet a condition.
         */
    }
}
