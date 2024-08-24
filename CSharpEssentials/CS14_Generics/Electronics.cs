using System;

namespace CSharpEssentials.CS14_Generics
{
    /// <summary>
    /// Electronics class representing an electronic item
    /// </summary>
    public class Electronics
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        public Electronics(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }

        /// <summary>
        /// Method that overrides the ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Electronics: {Name} by {Brand}";
        }

        /// <summary>
        /// Override Equals and GetHashCode to allow proper comparison
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is Electronics electronics)
            {
                return Name == electronics.Name && Brand == electronics.Brand;
            }
            return false;
        }

        /// <summary>
        /// Method to create a HashCode combining two values the Title and Author
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Brand);
        }
    }
}
