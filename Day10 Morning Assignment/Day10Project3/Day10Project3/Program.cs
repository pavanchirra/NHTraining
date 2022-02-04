using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project3
{
    /// <summary>
    /// METHOD OVERLOADING
    /// DONE BY: PAVAN
    /// </summary>
    class Algebra
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Algebra obj = new Algebra();
            Console.WriteLine("***** SUM OF 4 NUMBERS IS:");
            Console.WriteLine(obj.Add(4 ,6,7,8));
            Console.ReadLine();
        }
    }
}
