using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double uah = 36.84;

            double usd;

            Console.WriteLine("Введите сумму usd");

            usd = double.Parse(Console.ReadLine());

            Console.WriteLine(usd + " usd в uah = " + (usd * uah) + "uah");
            
        }
    }
}  

