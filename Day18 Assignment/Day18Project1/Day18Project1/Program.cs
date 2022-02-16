using System;
using System.Collections.Generic;
using MathematicsLibrary;

namespace Day18Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter any number:");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Algebra.Factorial(n));
            Console.ReadLine();
        }
    }
}
