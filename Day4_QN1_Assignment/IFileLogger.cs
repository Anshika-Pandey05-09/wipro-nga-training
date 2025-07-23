using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_assignment
{
    internal interface IFileLogger
    {
        void LOGtoFILE(string message);


    }
    public interface IDatabaseLogger
    {
        void LOGtoDatabase(string message);
    }
}