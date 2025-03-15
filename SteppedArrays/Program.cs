﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[6][];
            myArray[0] = new int[5];
            myArray[1] = new int[3];
            myArray[2] = new int[7];
            myArray[3] = new int[10];
            myArray[4] = new int[1];
            myArray[5] = new int[6];

            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
