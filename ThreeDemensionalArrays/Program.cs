using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDemensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,,] myArray = new int[3, 4, 6];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = rnd.Next(100);
                    }
                }      
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Pade №: " + (i+1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + "   ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
