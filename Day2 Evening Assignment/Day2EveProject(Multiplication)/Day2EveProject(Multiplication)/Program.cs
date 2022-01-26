using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2EveProject_Multiplication_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Console.WriteLine("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("using concatination");

            for (i = 1; i <= 10; i++)
            {
                //Using Concatination Method//
                Console.WriteLine(input + "*" + i + "=" + input * i);
            }

            Console.WriteLine("space");

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1} ={2}",input, i, input * i );
                //*****_____*****//
}
            Console.ReadLine();
        }
    }
}
