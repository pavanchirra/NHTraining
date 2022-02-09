using System;
using System.Collections.Generic;

namespace Day13Project1
{
    /// <summary>
    /// DONE BY:PAVAN
    /// PURPOSE:DECLARING A 2-D ARRAY WITH (2,2) SIZE MATRICES USING NESTED LOOP
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2,2];
            data[0,0] = 1;
            data[0,1] = 2;
            data[1,0] = 3;
            data[1,1] = 4;
            for(int i= 0; i<2; i++)
               
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(data[i,j]+ " ");
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
