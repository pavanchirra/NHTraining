using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project5
{
    /// <summary>
    /// OVERRIDING METHOD USING VIRTUAL  KEYS//
    /// DONE BY: PAVAN
    /// </summary>
    class ENGLISHMESSAGE
    {
        public  virtual void PrintHI()
        {
            Console.WriteLine("HI");
        }
        public virtual void PrintGM()
        {
            Console.WriteLine("GOOD MORNING");

        }
    }
    class TELUGU : ENGLISHMESSAGE
    {
        public override void PrintGM()
        {
            Console.WriteLine("Namaskaaram:");
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
            TELUGU obj = new TELUGU();
            obj.PrintGM();
            Console.ReadLine();

            }
        }
    }
