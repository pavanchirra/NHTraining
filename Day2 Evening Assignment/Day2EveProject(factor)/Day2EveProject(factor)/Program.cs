using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2EveProject_factor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Console.WriteLine("entry of a number");
            input = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= input; i++)
            {
                if (input % i == 0) ;
        }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}