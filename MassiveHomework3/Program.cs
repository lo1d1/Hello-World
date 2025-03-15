using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveHomework3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = { 4, 5, 71, 7, 424, 2, 4565, 457, 48, 56, 97, 79, 57, 9 };
            int minNumber = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {               

                if (myArray[i] < minNumber)
                {
                    minNumber = myArray[i];
                }
            }
            Console.WriteLine("Наименьший елемент массива = " + minNumber);
        }
    }
}
