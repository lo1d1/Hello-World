using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MassiveHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість чисел масива:\t");
            int elementsCount=int.Parse(Console.ReadLine());

            int[] Array = new int[elementsCount];

            for (int i = 0; i < Array.Length; i++) 
            {
                Console.WriteLine($"\nВведите число массива {i}:");
                Array[i]=int.Parse(Console.ReadLine());
            }

            int[] Array2 = {2, 24, 42, 65};
            Console.WriteLine("Вывод массива в обратном порядке:");

            for (int i =Array2.Length-1; i >= 0; i--)            
            {
                Console.WriteLine(Array2[i]);               
            }
            Math.Sqrt(16);
        }
    }
}
