using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class NumbersExtensions
    {
        public static int ReadLine() 
            => int.Parse(Console.ReadLine());

        public static bool IsEven(int number)
            => number % 2 == 0;
    }
}
