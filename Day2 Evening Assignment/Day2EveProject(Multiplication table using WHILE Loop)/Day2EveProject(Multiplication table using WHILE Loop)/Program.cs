using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2EveProject_Multiplication_table_using_WHILE_Loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = (int)Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(a + " * " + i + " = " + i * a);

                i++;
            }
            Console.WriteLine("press any to exit");

            Console.ReadLine();
            }
    }
}
