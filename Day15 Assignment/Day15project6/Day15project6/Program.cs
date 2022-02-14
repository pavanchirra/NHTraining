using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15project6
{
    internal class Program
    {
        /// <summary>
        /// DONE BY: PAVAN
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        
            {
               

                // We are Creating a File using streamWriter Class. It will not over Ride Each time when we run the code.
                // Instead it will Append the Text of Lines, Each time We Run the Code.
                StreamWriter writer = new StreamWriter(@"C:\C#\hello.txt", true);

                writer.WriteLine("This is From New object of Stream Writer,");
                writer.WriteLine("using Append by assigning True, while creating object for StreamWriter");
                writer.Close();
                Console.WriteLine("\n Appending is done, by using Stream Writer Class, By Enabling Append Method(true).");

            // We Are Reading the File Content using Stream Writer Class From System.IO namespace.
            StreamReader reader = new StreamReader(@"C:\C#\hello.txt");

            reader.ReadToEnd();

            reader.Close();
            Console.WriteLine("\n Reading is done, by using Stream Writer Class, by ReadToEnd Method.");
            Console.ReadKey();
            }
        }
    
    
}
