using System;

namespace CSharpEssentials.CS10_Inheritance
{
    /// <summary>
    /// Base class representing a general vehicle
    /// </summary>
    public class Vehicle
    {
        // Common properties for all vehicles
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /// <summary>
        /// Constructor for initializing the base class
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="color"></param>
        public Vehicle(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        /// <summary>
        /// Method to display vehicle details
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Year} {Make} {Model}, Color: {Color}");
        }

        /* Base Class (Vehicle):
         * Common Properties: Make, Model, Year, and Color are common properties shared by all vehicles.
         * Constructor: Initializes these common properties.
         * DisplayInfo() Method: A virtual method that displays the vehicle's details. It is marked as virtual to allow derived classes to override it.
         * Derived Class (Car):
         * Unique Property: NumberOfDoors represents the number of doors in a car.
         * Constructor: The constructor calls the base class constructor using : base(...) to initialize the common properties and then initializes the car-specific property.
         * Overridden Method: The DisplayInfo() method is overridden to include car-specific details, such as the number of doors. It calls the base class method using base.DisplayInfo() to reuse the common logic.
         *    
         */
    }
}
