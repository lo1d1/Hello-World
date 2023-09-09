using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int oddNumberCount = 0;//непарні числа
            int evenNumberCount = 0;//парні числа

            Console.WriteLine("Від");
            int limit1 = int.Parse(Console.ReadLine());

            Console.WriteLine("До");
            int limit2 = int.Parse(Console.ReadLine());

            while (limit1 <= limit2)
            {
                if (limit1 % 2 == 0)
                {
                    evenNumberCount++;
                }
                else
                {
                    oddNumberCount++;

                }
                limit1++;
            }
                Console.WriteLine("Кількість непарних чисел = " + oddNumberCount);
                Console.WriteLine("Кількість парних чисел = " + evenNumberCount);
                Console.ReadLine();
            
        }
    }
}
