using System;

namespace CSharpEssentials.CS10_Inheritance
{
    public class Main
    {
        /// <summary>
        /// We simulate a Vehicle Management System where we have a base class Vehicle, and two derived classes Car and Motorcycle. 
        /// The derived classes will inherit properties and methods from the base class and also have their own unique properties and methods.
        /// Vehicle (Base Class): Contains common properties and methods for all vehicles.
        /// Car (Derived Class): Inherits from Vehicle and adds properties specific to cars.
        /// Motorcycle (Derived Class): Inherits from Vehicle and adds properties specific to motorcycles.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS10_Inheritance");

            // Creating a Car object
            Car car = new Car("Toyota", "Camry", 2022, "Black", 4);
            car.DisplayInfo();          // Displaying car details

            Console.WriteLine();

            // Creating a Motorcycle object
            Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2021, "Red", false);
            motorcycle.DisplayInfo();   // Displaying motorcycle details
        }
    }
}
