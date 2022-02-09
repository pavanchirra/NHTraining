using System;
using System.Collections.Generic;

namespace Day13Project1
{
    /// <summary>
    /// DONE BY:PAVAN
    /// PURPOSE:USING QUEUE 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(16);
            data.Enqueue(78);
            data.Enqueue(54);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count);
            Console.ReadLine();
        }
    }
}



