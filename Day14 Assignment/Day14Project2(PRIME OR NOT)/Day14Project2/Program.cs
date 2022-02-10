using System;
using System.Collections.Generic;

namespace Day14Project2
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: USING BREAK CHECK THE GIVEN NUMBER IS PRIME OR NOT PRIME//
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2, i;
            for (i = 2;i<n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if(i == n)
                
                Console.WriteLine(" ITS A PRIME NUMBER:");
            else
                Console.WriteLine("NOT A PRIME NUMBER:");
            Console.ReadLine();
        }
    }
}
