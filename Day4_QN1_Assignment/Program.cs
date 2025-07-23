using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.LOGtoFILE("This is a file log message");
            fileLogger.ReadLog();
            DatabaseLogger dbLogger = new DatabaseLogger();
            dbLogger.LOGtoDatabase("This is a database log message");



        }
    }

}