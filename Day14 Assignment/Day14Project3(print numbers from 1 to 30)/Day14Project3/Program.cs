using System;
using System.Collections.Generic;
namespace Day14Project3
{
    internal class Program
    {
        /// <summary>
        /// DONE BY: PAVAN
        /// PURPOSE: USING CONTINUE KEY print numbers from 1 to 30 and skip the numbers divisible by 3
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1; i<= 30; i++)
            {
                if (i % 3 == 0)
                    continue;
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
