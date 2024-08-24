using System;

namespace CSharpEssentials.CS13_Exception_Handling.Central
{
    public class FileProcessor
    {
        /// <summary>
        /// Method to process the file and throw exceptions upwards
        /// </summary>
        /// <param name="filePath"></param>
        public void ProcessFile(string filePath)
        {
            try
            {
                // Step 1: Read the file
                string content = ReadFile(filePath);

                // Step 2: Parse the file content
                int parsedValue = ParseContent(content);

                // Step 3: Perform an operation with the parsed value
                PerformOperation(parsedValue);
            }
            catch (Exception)
            {
                // Rethrow the exception to be handled by the caller
                throw;
            }
        }

        /// <summary>
        /// Method to read the file and return its content
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        private string ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file was not found.", filePath);
            }

            return File.ReadAllText(filePath);
        }

        /// <summary>
        /// Method to parse the file content and return an integer
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="FormatException"></exception>
        private int ParseContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new FormatException("The file content is empty or not in the expected format.");
            }

            if (!int.TryParse(content.Trim(), out int result))
            {
                throw new FormatException("Failed to parse the file content to an integer.");
            }

            return result;
        }

        /// <summary>
        /// Method to perform an operation on the parsed value
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="InvalidOperationException"></exception>
        private void PerformOperation(int value)
        {
            if (value < 0)
            {
                throw new InvalidOperationException("The parsed value cannot be negative.");
            }

            Console.WriteLine($"Successfully processed value: {value}");
        }
    }
}
