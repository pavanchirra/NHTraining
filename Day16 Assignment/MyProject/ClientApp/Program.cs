using System;
using System.Collections.Generic;
using PavanLibrary2;
using PublicLibrary;
namespace ClientApp
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: CREATING A solution "MyProject"
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****FACTORIAL OF A NUMBER*****");
            Console.WriteLine(Mathematics.Factorial(6));
            Console.WriteLine("*******FINALVELOCITY IS********");
            Console.WriteLine(Physics.FinalVelocty(8, 9, 6));
            Console.ReadLine();
        }
    }
}
