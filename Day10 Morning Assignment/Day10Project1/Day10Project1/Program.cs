using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project1
{
    /// <summary>
    /// SINGLE INHERITANCE
    /// DONE BY: PAVAN
    /// </summary>
    class Algebra
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }

    class TotalMaths : Algebra
    { 
        public int mul(int a, int b)
        { 
            return a * b; 
        }
    internal class Program
    {
            static void Main(string[] args)
            {
                TotalMaths tm = new TotalMaths();
                Console.WriteLine("*** BY ADDITION TWO NUMBERS***:");
                Console.WriteLine(tm.Add(5, 6));
                Console.WriteLine("**** MUL OF TWO NUMBERS:***");
                Console.WriteLine(tm.mul(5,6));
                Console.WriteLine("**** SUB OF TWO NUMBERS:***");
                Console.WriteLine(tm.sub(15, 6));
                Console.ReadLine();
            }
        }
    }
}
