using System;
using System.Collections.Generic;
using Pavan_Library;

namespace Day16Project_Partial_class_
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: CREATING A PARTIAL CLASS/
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****AIRTHEMATIC OPERATIONS****");
            Console.WriteLine("Addition of 9 and 11 is: ");
            Console.WriteLine(Mathematics.Add(9, 11)); 
            Console.WriteLine("****Subtraction of 8 and 2 is****");
            Console.WriteLine(Mathematics.Sub(8, 2));
            Console.WriteLine("****Multiplication of 8 and 2 is****");
            Console.WriteLine(Mathematics.Mul(8, 2));
            Console.WriteLine("****Division of 8 and 2 is****");
            Console.WriteLine(Mathematics.Div(8, 2));
            Console.ReadLine();

        }
    }
}
