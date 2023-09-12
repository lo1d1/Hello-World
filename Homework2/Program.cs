using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] argsв)
        {
            Console.Write("Висота трикутника: ");
            int height = int .Parse(Console.ReadLine());

            for (int i = 0; i < height; i++) 
            {
                for (int j = 0; j <=i; j++)
                {                   
                    Console.Write("!");
                }
                Console.WriteLine();
            }


            Console.Write("Висота трикутника: ");
            int heighd2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < heighd2; i++)
            {                
                for (int j = heighd2; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.Write("Висота трикутника: ");
            int height3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < height3; i++)
            {
                for (int j = heighd2; j > i; j--)
                {
                    Console.Write(" ");
                }              

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("!");
                }
                Console.WriteLine();
            }

            Console.Write("Висота трикутника: ");
            int heighd4 = int.Parse(Console.ReadLine());

            for (int i = 0; i < heighd4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = heighd4; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }



        }

        
       
    }
}
