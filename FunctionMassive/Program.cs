using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionMassive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 435, 7, 567, 65, 35, 3, 42, 423, 24, 24, 23, 53, 46, 56, 456, };

            int result = myArray.Min();

            Console.WriteLine(result);
        }
    }
}
