using System;
using MyConsoleApp.ServiceReference1;

namespace MyConsoleApp
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: AIRTHEMATIC OPERATIONS USING WEB SERVICES
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient obj = new WebService1SoapClient();
            Console.WriteLine("****Factorial of a Number:***");
            Console.WriteLine(obj.Factorial(4));
            Console.WriteLine("****Addition of a Number:***");
            Console.WriteLine(obj.Add(6, 2));
            Console.WriteLine("***Subtraction of a Number:****");
            Console.WriteLine(obj.Sub(6, 2));
            Console.WriteLine("****Multiplication of a Number:*****");
            Console.WriteLine(obj.Mul(6, 2));
            Console.WriteLine("****Division of a Number:*****");
            Console.WriteLine(obj.Div(6, 2));
            Console.ReadLine();
        }
    }
}
