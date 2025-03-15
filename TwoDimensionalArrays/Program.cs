using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray =new int[4,5];
            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(100);
                }
            }

                    for (int i = 0; i < myArray.GetLength(0); i++)
            {
                   for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i,j] + "\t");
                }
                   Console.WriteLine();
            }
        }
    }
}
