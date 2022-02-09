using System;
using System.Collections.Generic;

namespace Day13Project1
{
    /// <summary>
    /// DONE BY:PAVAN
    /// PURPOSE:DECLARING A 2-D ARRAY WITH (3,2) SIZE MATRICES USING NESTED LOOP
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 6, 7 } };
           
            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 2; j++)
                   
                    Console.Write(data[i, j] + " ");
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}

