using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_QN3
{
    internal class CustomError : Exception
    {
        public CustomError(string message) : base(message)
        {
        }
    }
}
