using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project4
{
    /// <summary>
/// METHOD OVERRIDING//
/// DONE BY: PAVAN
/// </summary>
    class ENGLISHMESSAGE
    { 
        public void PrintHI()
        { 
            Console.WriteLine("HI");
                }
        public void PrintPavan()
        {
            Console.WriteLine("Pavan");
        }
        public void PrintGM()
        {
            Console.WriteLine("GOOD MORNING");
        }
        }
    class TELUGUMESSAGE : ENGLISHMESSAGE
    {
        public new void PrintGM()
        {
            Console.WriteLine("Subhodayam");

        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            TELUGUMESSAGE obj = new TELUGUMESSAGE();
           obj.PrintGM();
            Console.ReadLine();
            
        }
    }
}
