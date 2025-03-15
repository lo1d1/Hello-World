using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylist
{
    internal class Program
    {
        static int IndexOf(int[] array, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == index)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int MinValue, int MaxValue)
        {
            Random r = new Random();
            int[] array = new int[length];
            for (int k = 0; k < array.Length; k++)
            {
                array[k] = r.Next(MinValue, MaxValue);
            }
            return array;
        }
        static void Main(string[] args)
        {
            {
                int[] myArray=GetRandomArray(100, 1, 1030);
                for (int i = 0;i < myArray.Length;i++)
                {
                    Console.Write(myArray[i] + "  ");
                }
                Console.WriteLine();
                Console.WriteLine("Введите елемент: ");
                int b = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Индекс елемента: " + IndexOf(myArray, b));
            }
        }
    }
}
