using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project2_List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0;
            data.Add(50);
            data.Add(50);
            data.Add(20);

            foreach (var d in data)
            {
                sum = sum + d;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
