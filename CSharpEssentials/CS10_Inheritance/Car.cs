using System;

namespace CSharpEssentials.CS10_Inheritance
{
    /// <summary>
    /// Derived class representing a car
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Property unique to cars
        /// </summary>
        public int NumberOfDoors { get; set; }

        /// <summary>
        /// Constructor for initializing the derived class
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="color"></param>
        /// <param name="numberOfDoors"></param>
        public Car(string make, string model, int year, string color, int numberOfDoors)
            : base(make, model, year, color)  // Calling the base class constructor
        {
            NumberOfDoors = numberOfDoors;
        }

        /// <summary>
        /// Overriding the DisplayInfo method to include car-specific details
        /// </summary>
        public override void DisplayInfo()
        {
            base.DisplayInfo();  // Call the base class method
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }

        /* Derived Class (Car):
         * Unique Property: NumberOfDoors represents the number of doors in a car.
         * Constructor: The constructor calls the base class constructor using : base(...) to initialize the common properties and then initializes the car-specific property.
         * Overridden Method: The DisplayInfo() method is overridden to include car-specific details, such as the number of doors. It calls the base class method using base.DisplayInfo() to reuse the common logic.
         */
    }
}
