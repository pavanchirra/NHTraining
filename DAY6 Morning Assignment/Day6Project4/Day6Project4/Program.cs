using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum1 =0,  sum2 = 0 , sum3 = 0;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("enter a value{0}:", i);
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }
            for (int i = 0; i < data.Count; i++)
            {
                sum1 = sum1 + data[i];
            }
            Console.WriteLine("{0}",sum1);
            Console.ReadLine();

            Console.WriteLine("*****_______******");

            foreach(var d in data)
            {
                sum2 += d;
            }
            Console.WriteLine("{0}",sum2);
            Console.ReadLine();
            Console.WriteLine("*****_______******");

            data.ForEach(d => sum3 = sum3 + d);
            Console.WriteLine("{0}",sum3);
            Console.ReadLine();
        }
    }
}
