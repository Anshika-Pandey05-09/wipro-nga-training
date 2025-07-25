﻿using System;
using System.Collections.Generic;//Generic collection
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEmo_Collections_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            ////Step 3: Displaying the employee names
            //Console.WriteLine("Employee Names:");
            //foreach (var name in employeeNames)
            //{
            //    Console.WriteLine(name);
            //}
            ////Step 4: Removing an employee name from the list
            //employeeNames.Remove("Jane Smith");
            ////Step 5: Displaying the updated employee names
            //Console.WriteLine("\nUpdated Employee Names:");
            //foreach (var name in employeeNames)
            //{
            //    Console.WriteLine(name);
            //}
            ////Step 6: Searching for an employee name in the list using contains()
            //string searchName = "Alice Johnson";
            //if (employeeNames.Contains(searchName))
            //{
            //    Console.WriteLine($"\n{searchName} is found in the employee list.");
            //}
            //else
            //{
            //    Console.WriteLine($"\n{searchName} is not found in the employee list.");
            //}
            ////Step 7: Sorting the employee names in alphabetical order
            //employeeNames.Sort();
            ////Step 8: Displaying the sorted employee names
            //Console.WriteLine("\nSorted Employee Names:");
            //foreach (var name in employeeNames)
            //{
            //    Console.WriteLine(name);
            //}
            ////Step 9: Finding the count of employee names in the list Imp Diff beween Count and Size of the collection
            //int count = employeeNames.Count;
            //Console.WriteLine($"\nTotal number of employees: {count}");
            ////Step 10: Clearing the list of employee names
            ////employeeNames.Clear();
            ////Step 11: Displaying the count after clearing the list
            //Console.WriteLine($"\nTotal number of employees after clearing the list: {employeeNames.Count}");

            ////Updating the employee names in the list
            //Console.WriteLine("\nUpdating Employee Names:");



            ////Lets insert element in collection using input from user bases on int values ie salaries of an employee
            //List<int> salaries = new List<int>();//Step 1: Creating a list to store employee salaries
            //Console.WriteLine("\nEnter employee salaries (type 'done' to finish):");
            ////reading salaries from user input

            ////Step 2: Looping through the employee names to get salaries

            //foreach (var name in employeeNames)
            //{
            //    Console.Write($"Enter salary for {name}: ");
            //    string input = Console.ReadLine();
            //    if (input.ToLower() == "done")
            //    {
            //        break; // Exit the loop if user types 'done'
            //    }
            //    if (int.TryParse(input, out int salary))//here tryparse is used to check if the input can be converted to an integer
            //                                            //out int salary is used to store the converted integer value
            //    {
            //        salaries.Add(salary); // Add the salary to the list
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid salary.");
            //    }
            //    Console.WriteLine(employeeNames.Count > 0 ? "Salaries entered successfully." : "No salaries entered.");
            //    //Showing the count of the collection
            //    Console.WriteLine($"Total number of salaries entered: {salaries.Count}");
            //    //Showing the salaries entered
            //    Console.WriteLine("\nSalaries Entered:");
            //    foreach (var mysalary in salaries)
            //    {
            //        Console.WriteLine(mysalary);
            //    }
            //    //Showing the size of the collection in terms of memory
            //    Console.WriteLine(salaries.Capacity);// Capacity is the number of elements that the list can hold before it needs to resize by the logic 2^N
            //    //capacity is dynamically increased as elements are added to the list by doubling the current capacity by default (CLR)
            //    Console.WriteLine(salaries.Count);// Count is the number of elements that are currently in the list

            //}


            //Need to create a C# program that maintains Browser navigaion/URl history anf printout job queues using Stack and Queue
            //Stack and Queue are both collections in C# that are used to store a collection of objects, but they have different characteristics and use cases.


            // Step 1: Create a Stack for Browser Navigation History
            Stack<string> browserHistory = new Stack<string>();

            // Step 2: Create a Queue for Job Queues
            Queue<string> jobQueue = new Queue<string>();

            // Step 3: Push URLs to browser history (Stack)
            browserHistory.Push("https://www.google.com");
            browserHistory.Push("https://www.facebook.com");
            browserHistory.Push("https://www.github.com");

            // Step 4: Enqueue Jobs to job queue
            jobQueue.Enqueue("Print Document A");
            jobQueue.Enqueue("Scan Document B");
            jobQueue.Enqueue("Send Email C");

            // Step 5: Print contents of Stack 
            Console.WriteLine("Browser Navigation History (LIFO):");
            foreach (var url in browserHistory)
            {
                Console.WriteLine(url);
            }

            Console.WriteLine();

            // Print contents of Queue 
            Console.WriteLine("Job Queue (FIFO):");
            foreach (var job in jobQueue)
            {
                Console.WriteLine(job);
            }

        }
    }
}
