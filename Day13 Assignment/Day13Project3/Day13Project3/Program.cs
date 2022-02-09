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
            int[,] data = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9 } };
            int sum = 0;
            Console.WriteLine("**** TRACE VALUE ******");
            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 3; j++)
                {
                    if(i== j)
                        sum = sum + data[i, j]; 
                }

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}


