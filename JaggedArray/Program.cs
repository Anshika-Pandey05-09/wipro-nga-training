using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedarray = new int[3][];
            jaggedarray[0] = new int[] { 1, 2, 3, 4 };
            jaggedarray[1] = new int[] { 5, 6 };
            jaggedarray[2] = new int[] { 7, 8, 9, 10, 11 };
            foreach (var array in jaggedarray)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
