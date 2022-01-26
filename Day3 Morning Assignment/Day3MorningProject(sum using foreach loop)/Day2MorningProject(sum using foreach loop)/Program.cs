using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2MorningProject_sum_using_foreach_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] data = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"enter {i + 1} number :");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in data)
            {
                sum = sum + i;
            }
            Console.WriteLine("(data)");
            Console.ReadLine();
        }
    }
}
