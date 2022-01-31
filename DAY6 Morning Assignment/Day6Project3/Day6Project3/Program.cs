using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("Hyderabad");
            data.Add("Mumbai");
            data.Add("Delhi");
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine("{0} ", data[i]);
            }
            Console.WriteLine("****____*****");


            foreach (var d in data)
            {
                Console.WriteLine("{0}", d);
            }
            Console.WriteLine("****------*****");

            data.ForEach(d => Console.WriteLine("{0}",d));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
