using System;

namespace CSharpEssentials.CS13_Exception_Handling.Central
{
    public class Main
    {
        /// <summary>
        /// We create a File Processing System where we read from a file, parse its contents, and perform operations based on the parsed data. 
        /// Multiple exceptions could occur during this process:
        /// 1. FileNotFoundException: If the file does not exist.
        /// 2. FormatException: If the file contains data in an incorrect format.
        /// 3. InvalidOperationException: If an operation is attempted on invalid data.
        /// These exceptions will be propagated upwards from the method where they occur and handled in one central location in the Demo method.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS13_Exception_Handling.Central");

            FileProcessor fileProcessor = new FileProcessor();
            string filePath = "input.txt";

            try
            {
                // Attempt to process the file
                fileProcessor.ProcessFile(filePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File Error: {ex.Message}");
                Console.WriteLine($"File Path: {ex.FileName}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format Error: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Operation Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catch any other unexpected exceptions
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("File processing completed.");
            }

            /* 1. FileProcessor Class:
             *    ProcessFile Method: This method orchestrates the file processing by calling ReadFile, ParseContent, and PerformOperation. 
             *    If any exception occurs, it is caught, and then rethrown using throw; to propagate the exception upwards to the caller (Main method).
             *    ReadFile Method: Reads the content of the specified file. If the file does not exist, it throws a FileNotFoundException.
             *    ParseContent Method: Parses the content of the file into an integer. If the content is empty, null, or cannot be parsed into an integer, it throws a FormatException.
             *    PerformOperation Method: Checks if the parsed value is negative. If it is, it throws an InvalidOperationException.
             * 2. Main Method:
             *    Try-Catch Blocks: The Main method attempts to process the file using fileProcessor.ProcessFile(filePath);. 
             *    Multiple catch blocks are used to handle the specific exceptions (FileNotFoundException, FormatException, InvalidOperationException).
             *    Finally Block: Regardless of whether an exception occurs, the finally block ensures that the message "File processing completed." is always displayed.
             * 
             * Exception Propagation: This example demonstrates how exceptions can be thrown in lower-level methods (ReadFile, ParseContent, PerformOperation) and 
             * propagated upwards to be handled in a central location (Main method).  
             * 
             * Centralized Error Handling: By handling exceptions in one place, the program's error-handling logic is more centralized, making it easier to manage and maintain.
             * 
             * Specific Exception Handling: The Main method uses specific catch blocks to handle different exceptions, ensuring that appropriate messages are displayed for each type of error.
             * 
             */
        }
    }
}
