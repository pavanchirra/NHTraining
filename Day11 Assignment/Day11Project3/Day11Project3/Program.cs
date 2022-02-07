using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day11Project4
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: Create Mathematics class and add 3 static methods and call the  methods in main method
    /// </summary>
    internal class Program
    {
        class Mathematics
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static int Sub(int a, int b)
            { 
                return a - b; 
            }

            public static int Mul(int a, int b)
            { 
                return a * b;
            }
            public static int Div(int a, int b)
            { 
                return a / b; 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("****ADD*****");
            Console.WriteLine("Addition BY static Method       :  {0} ", Mathematics.Add(45, 55));

            Console.WriteLine("*****SUB*****");
            Console.WriteLine("Subtraction BY static Method    :  {0} ", Mathematics.Sub(56, 24));

            Console.WriteLine("*****MUL*****");
            Console.WriteLine("Multiplication BY static Method :  {0} ", Mathematics.Mul(24, 4));

            Console.WriteLine("*****DIV*****");
            Console.WriteLine("Division BY static Method       :  {0} ", Mathematics.Div(898, 5));

            Console.ReadLine();
        }
    }
}