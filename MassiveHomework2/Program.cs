using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість чисел масива:\t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];
            int result = 0; 

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\nВведите число массива {i}:");
                myArray[i] = int.Parse(Console.ReadLine());

                if (myArray[i] % 2 == 0)
                {
                    result = result + myArray[i];
                }

            }
            Console.WriteLine("Сумма четных чисел в массиве = "+result);
        }

    }
}
