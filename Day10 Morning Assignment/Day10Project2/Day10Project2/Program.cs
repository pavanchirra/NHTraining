using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project2
{
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
    }
    class AllOperations : TotalMaths
    {
        public string water()
        {
            return "h2o";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AllOperations obj = new AllOperations();
            Console.WriteLine("*** BY ADDITION TWO NUMBERS***:");
            Console.WriteLine(obj.Add(5, 6));
            Console.WriteLine("***formula for water:****");
            Console.WriteLine(obj.water());
            Console.ReadLine();
        }
    }
}
