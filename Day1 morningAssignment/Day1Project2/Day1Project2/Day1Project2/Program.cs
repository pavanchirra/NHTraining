using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basenumber, exponent, i, power;
            Console.WriteLine("Enter any number:");
            basenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any number:");
            exponent = Convert.ToInt32(Console.ReadLine());

            power = 1;

            for (i = 1; i <= exponent; i++)
                power = power * basenumber;

            Console.Write("Power : " + power);
            Console.ReadLine();






            {
            }
        }
    }
}
