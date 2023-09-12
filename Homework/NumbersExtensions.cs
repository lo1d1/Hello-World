using System;

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
