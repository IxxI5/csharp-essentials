using System;

namespace CSharpEssentials.CS10_Inheritance
{
    /// <summary>
    /// Derived class representing a motorcycle
    /// </summary>
    public class Motorcycle : Vehicle
    {
        /// <summary>
        /// Property unique to motorcycles
        /// </summary>
        public bool HasSidecar { get; set; }

        /// <summary>
        /// Constructor for initializing the derived class
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="color"></param>
        /// <param name="hasSidecar"></param>
        public Motorcycle(string make, string model, int year, string color, bool hasSidecar)
            : base(make, model, year, color)  // Calling the base class constructor
        {
            HasSidecar = hasSidecar;
        }

        /// <summary>
        /// Overriding the DisplayInfo method to include motorcycle-specific details
        /// </summary>
        public override void DisplayInfo()
        {
            base.DisplayInfo();  // Call the base class method
            Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }

        /* Derived Class (Motorcycle):
         * Unique Property: HasSidecar indicates whether the motorcycle has a sidecar.
         * Constructor: Similar to the Car class, it calls the base class constructor and then initializes the motorcycle-specific property.
         * Overridden Method: The DisplayInfo() method is overridden to include motorcycle-specific details.
         */
    }
}
