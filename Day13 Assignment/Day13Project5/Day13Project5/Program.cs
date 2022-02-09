using System;
using System.Collections.Generic;

namespace Day13Project1
{
    /// <summary>
    /// DONE BY:PAVAN
    /// PURPOSE:USING STACK 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(16);
            data.Push(78);
            data.Push(54);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count);
            Console.ReadLine();
        }
    }
}


