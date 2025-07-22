using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping Constructs and variables types in c#");
            Console.WriteLine("Enter first no.:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second no.:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                    case "*":
                    result = firstNumber * secondNumber;
                    break;
                    case "/":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    return;

            }
        }
    }
}