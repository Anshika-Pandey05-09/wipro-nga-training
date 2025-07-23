using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Step for handling exception in c# using try, catch and finally blocks");
            // Exception exp = new Exception("This is a custom exception message");
            //Exception is my base class for all exceptions in C#
            try
            {
                //Taking two numbers from user to check division by zero exception
                Console.WriteLine("Enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;

            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("An exception occurred: " + ex.Message);

                throw;
            }
            finally
            {
                // This block will always execute, regardless of whether an exception was thrown or not
                Console.WriteLine("This is the finally block, it always executes.");
            }
        }
    }
}
