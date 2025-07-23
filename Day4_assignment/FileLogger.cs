using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day4_assignment
{
    public class FileLogger : IFileLogger
    {
        private readonly string _filePath = "Log.txt";
        public void LOGtoFILE(string message)
        {
            File.AppendAllText(_filePath, $"File Log: {message}\n");
            // Implementation for logging to a file
            Console.WriteLine($"Logged to file:");
        }
        public void ReadLog()
        {
            if (File.Exists(_filePath))
            {
                string logContent = File.ReadAllText(_filePath);
                Console.WriteLine("Reading file:");
                Console.WriteLine(logContent); 
            }
            else
            {
                Console.WriteLine("Log file does not exist.");
            }
            // Implementation for reading the log from a file
            //Console.WriteLine("Reading log from file...");
        }
    }
    // Remove this duplicate class definition if another DatabaseLogger exists elsewhere in the project.
    // If this is the only definition, ensure there is not another DatabaseLogger class in the same namespace
    public class DatabaseLogger : IDatabaseLogger
     {
         public void LOGtoDatabase(string message)
      {
             // Implementation for logging to a database
           Console.WriteLine($"Database Log: {message}");
      }
    }
}
