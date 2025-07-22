using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_Student_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade System");
            Console.WriteLine("Here goal is demonstrate conditions and logic");
            Console.WriteLine("Press any key to continue...");

            Console.WriteLine("Enter marks of the student (0-100)");
            int marks = Convert.ToInt32(Console.ReadLine());
            //creating a variable to store the marks of the student of type int

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks entered. Marks must be between 0 and 100.");
            }
            else
            {
                string result = (marks >= 40) ? "Passed" : "Failed";
                Console.WriteLine($"The student has {result} with marks: {marks}");
                if (marks >= 90)
                {
                    Console.WriteLine("Grade: A+");
                }
                else if (marks >= 80)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (marks >= 70)
                {
                    Console.WriteLine("Grade: B");
                }
                else if (marks >= 60)
                {
                    Console.WriteLine("Grade: C");
                }
                else if (marks >= 50)
                {
                    Console.WriteLine("Grade: D");
                }
                else
                {
                    Console.WriteLine("Grade: Fail");
                }
            }

        }
    }
}
