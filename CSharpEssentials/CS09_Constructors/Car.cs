using System;

namespace CSharpEssentials.CS09_Constructors
{
    /// <summary>
    /// Car class demonstrating different types of constructors.
    /// </summary>
    public class Car
    {
        // Fields
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public static int TotalCarsProduced { get; private set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Car()
        {
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
            Color = "Unpainted";
            TotalCarsProduced++;
            Console.WriteLine("Default constructor called.");
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="color"></param>
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            TotalCarsProduced++;
            Console.WriteLine("Parameterized constructor called.");
        }

        /// <summary>
        /// Constructor with Optional Parameters
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        public Car(string make, string model, int year) : this(make, model, year, "White")
        {
            Console.WriteLine("Constructor with optional parameters called.");
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="existingCar"></param>
        public Car(Car existingCar)
        {
            Make = existingCar.Make;
            Model = existingCar.Model;
            Year = existingCar.Year;
            Color = existingCar.Color;
            TotalCarsProduced++;
            Console.WriteLine("Copy constructor called.");
        }

        /// <summary>
        /// Static Constructor. It is called just once (one the first instance). Subsequently instances do not call the static constructor.
        /// </summary>
        static Car()
        {
            TotalCarsProduced = 0;
            Console.WriteLine("Static constructor called.");
        }

        // Method to display car details
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Details: {Year} {Make} {Model}, Color: {Color}");
        }

        /* 1. Default Constructor: Car(). 
         *    Initializes the car with default values. 
         *    It increments the TotalCarsProduced static field and prints a message indicating that the default constructor was called.
         * 2. Parameterized Constructor: Car(string make, string model, int year, string color). 
         *    Initializes the car with specific values 
         *    for Make, Model, Year, and Color. This constructor is used when all car details are known.
         * 3. Constructor with Optional Parameters: Car(string make, string model, int year).
         *    This constructor initializes the car with a default color ("White") if the color is not provided. 
         *    It calls the parameterized constructor using this, demonstrating constructor chaining.
         * 4. Copy Constructor: Car(Car existingCar). 
         *    Creates a new Car object by copying the properties of an existing Car object. 
         *    This is useful when you want to duplicate an object with the same properties.
         * 5. Static Constructor: static Car().
         *    Initializes the static member TotalCarsProduced. The static constructor is called only once, before any instance of the Car class is created, 
         *    and it sets the initial value of TotalCarsProduced to 0.
         * 6. Constructor Chaining: Car(string make, string model, int year).
         *    This constructor demonstrates chaining by calling another constructor in the same class using this. 
         *    It passes the parameters to the full parameterized constructor and also prints a message.
         */
    }
}
