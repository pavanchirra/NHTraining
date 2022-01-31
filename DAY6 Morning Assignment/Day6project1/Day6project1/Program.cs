using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            ArrayList data = new ArrayList();
            data.Add(10);
            data.Add(20);
            data.Add(30);

            foreach (var d in data)
                sum = sum + (int)d;
                Console.WriteLine(sum);
           
            Console.ReadLine(); 

            

        }
    }
}
