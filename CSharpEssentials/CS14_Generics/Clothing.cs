using System;

namespace CSharpEssentials.CS14_Generics
{
    /// <summary>
    /// Clothing class representing a clothing item
    /// </summary>
    public class Clothing
    {
        public string Description { get; set; }
        public string Size { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="description"></param>
        /// <param name="size"></param>
        public Clothing(string description, string size)
        {
            Description = description;
            Size = size;
        }

        /// <summary>
        /// Method that overrides the ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Clothing: {Description} (Size: {Size})";
        }

        /// <summary>
        /// Override Equals and GetHashCode to allow proper comparison
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is Clothing clothing)
            {
                return Description == clothing.Description && Size == clothing.Size;
            }
            return false;
        }

        /// <summary>
        /// Method to create a HashCode combining two values the Title and Author
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Description, Size);
        }
    }
}
