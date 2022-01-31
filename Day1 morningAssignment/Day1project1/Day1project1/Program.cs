using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num1, num2, result;
           
            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2" , num1, num2, result);
            Console.WriteLine(result);
            Console.ReadLine();
            

        }
    }
}
