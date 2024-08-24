using System;

namespace CSharpEssentials.CS09_Constructors
{
    public class Main
    {
        /// <summary>
        /// Demonstration of different constructor syntaxes.
        /// We use a Car class to model a car in a vehicle management system showcasing different types of constructors:
        /// 1. Default Constructor: A constructor with no parameters.
        /// 2. Parameterized Constructor: A constructor with parameters to initialize fields.
        /// 3. Constructor with Optional Parameters: A constructor where some parameters have default values.
        /// 4. Copy Constructor: A constructor that creates a new object as a copy of an existing object.
        /// 5. Static Constructor: A constructor that initializes static members of the class.
        /// 6. Chaining Constructors: Using this to call another constructor in the same class.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("S09_Constructors");

            // Using the default constructor
            Car car1 = new Car();
            car1.DisplayInfo();

            // Using the parameterized constructor
            Car car2 = new Car("Toyota", "Camry", 2022, "Black");
            car2.DisplayInfo();

            // Using the constructor with optional parameters
            Car car3 = new Car("Honda", "Civic", 2023);
            car3.DisplayInfo();

            // Using the copy constructor
            Car car4 = new Car(car2);
            car4.DisplayInfo();

            // Display total cars produced
            Console.WriteLine($"Total cars produced: {Car.TotalCarsProduced}");
        }
    }
}
