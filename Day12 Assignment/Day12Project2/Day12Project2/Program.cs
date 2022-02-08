using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Project2
{
    /// <summary>
    /// DONE BY: PAVAN//
    /// PURPOSE: Use of "finally" block illustrate with an example.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// USING DIVIDEBYZERO EXCEPTION METHOD//
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                c = a + b;
                Console.WriteLine($"Addition of {a} and {b}, {c}");
                d = a / b;
                Console.WriteLine($"Div of {a} and {b}, {d}");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("The second number should not be zero:");
            }
            finally
            {
                e = a * b;
                Console.WriteLine($"Mul of {a} and {b},{e}");
                Console.ReadLine();
            }
        }
    }
}

