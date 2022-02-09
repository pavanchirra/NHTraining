using System;
using System.Collections.Generic;

namespace Day13Project1
{
    /// <summary>
    /// DONE BY:PAVAN
    /// PURPOSE:DECLARING A 2-D ARRAY WITH (3,3) SIZE MATRICES USING NESTED LOOP FIND TRACE VALUE:
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            
            
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter any number ({i},{j}):  ");
                    data[i,j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j] + " ");

                }
                Console.Write("\n");

            }
            Console.ReadLine();
        }
    }
}


