using System;

namespace CSharpEssentials.CS16_Array_Methods
{
    /// <summary>
    /// Employee class
    /// </summary>
    public class Employee
    {
        // Employee properties
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="salary"></param>
        public Employee(string name, int id, decimal salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        /// <summary>
        /// Method that overrides the ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, Salary: {Salary:C}";
        }
    }
}
