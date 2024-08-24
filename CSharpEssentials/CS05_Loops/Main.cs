using System;

namespace CSharpEssentials.CS05_Loops
{
    public class Main
    {
        /// <summary>
        /// This example involves a scenario where a user is interacting with an online course platform,
        /// and we'll use loops to manage different aspects of the platform, such as processing course enrollments, 
        /// calculating course progress, and generating reports.
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("CS05_Loops");

            // Course data
            string[] courses = { "Math", "Science", "History", "Art", "Computer Science" };
            int[] progress = new int[courses.Length]; // Array to store progress percentage for each course

            // Enroll in courses and update progress
            Console.WriteLine("Course Enrollment and Progress Tracking");

            // For loop: Enroll in courses and set initial progress
            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write($"Enter progress percentage for {courses[i]}: ");
                string? input = Console.ReadLine();

                progress[i] = int.TryParse(input, out int num) ? num: 0;
            }

            // While loop: Display progress until all courses are reviewed
            int index = 0;
            Console.WriteLine("\nReview Course Progress:");
            while (index < courses.Length)
            {
                Console.WriteLine($"{courses[index]}: {progress[index]}% completed");
                index++;
            }

            // Do-while loop: Update progress and continue until user decides to stop
            string updateAnotherCourse;
            do
            {
                Console.Write("Enter the name of the course to update progress: ");
                string? courseToUpdate = Console.ReadLine();

                // Find the index of the course
                int courseIndex = Array.IndexOf(courses, courseToUpdate);
                if (courseIndex >= 0)
                {
                    Console.Write($"Enter new progress percentage for {courseToUpdate}: ");
                    string? input = Console.ReadLine();

                    progress[courseIndex] = int.TryParse(input, out int num) ? num : 0;
                }
                else
                {
                    Console.WriteLine("Course not found.");
                }

                Console.Write("Do you want to update another course? (yes/no): ");
                updateAnotherCourse = Console.ReadLine().ToLower();
            }
            while (updateAnotherCourse == "yes");

            // Foreach loop: Generate a summary report of course progress
            Console.WriteLine("\nFinal Course Progress Report:");
            foreach (string course in courses)
            {
                int courseIndex = Array.IndexOf(courses, course);
                Console.WriteLine($"{course}: {progress[courseIndex]}% completed");
            }

        }
    }
}
