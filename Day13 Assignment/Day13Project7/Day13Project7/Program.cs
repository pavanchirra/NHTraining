using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project7
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOUSE:JAGGED ARRAY//
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[2][];
            names[0] = new char[] { 'P', 'A', 'V', 'A', 'N'};
            names[1] = new char[] { 'K', 'U', 'M','A', 'R'};

            Console.WriteLine(" ");
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                    Console.Write(names[i][j]);
                Console.ReadLine();
            }
        }
    }

}