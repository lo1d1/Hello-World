using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        { int a, b;

            int result;


            Console.WriteLine("1. +");

            Console.WriteLine("2. -");

            Console.WriteLine("3. *");

            Console.WriteLine("4. /");

            Console.WriteLine("Выберите оператор");

            result = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 1"); 

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");

            b = int.Parse(Console.ReadLine());
             const string output = "Результат";


            switch (result)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine($"{output} сумирования ={result} " );
                    break;
                case 2:
                    Console.WriteLine($"{output} вычетания = " + (a - b));
                    break;
                case 3:
                    Console.WriteLine($"{output} умножения = "+ (a * b));
                    break;
                case 4:
                    Console.WriteLine($"{output} деления = "+ (a / b));
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;











            }
        }
    }
}
