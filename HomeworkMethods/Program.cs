using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMethods
{
    internal class Program
    {
        static void RomaLox(string symbol1, int a) 
        {         
            
            for (int i = 0; i <= a; i++)
            {
                Console.Write(symbol1 + "  ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество символов: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите символ: ");
            string symbol = Console.ReadLine();
            
            RomaLox(symbol,b);
        }
    }
}
