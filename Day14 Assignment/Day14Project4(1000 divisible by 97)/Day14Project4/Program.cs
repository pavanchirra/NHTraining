using System;
using System.Collections.Generic;

namespace Day14Project4
{
    internal class Program
    {
        /// <summary>
        /// DONE BY: PAVAN
        /// PURPOSE: Find the first number after 1000 which is divisible by 97.HINT : use for loop and break//
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1000; i<=1097; i++)
            {
                if (i % 97 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
