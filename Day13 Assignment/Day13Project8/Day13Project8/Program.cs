using System;
using System.Collections.Generic;

namespace RecursionFunction
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOUSE: USING RECURSION FIND FACTORIAL//
    /// </summary>
    internal class Program
    {
      public  static void PrintOutput(int n)
        {
            Console.WriteLine("Factorial of {0} is {1}", n, Factorial(n));
        }
        public static int Factorial(int input)
        {
            if (input == 0)
                return 1;
            else
                return input * Factorial(input - 1);
        }
        static void Main(string[] args)
        {
            int input;
            Console.Write("Enter any number:");
            input = Convert.ToInt32(Console.ReadLine());

            PrintOutput(input);
            Console.ReadLine();
        }
    }
}
