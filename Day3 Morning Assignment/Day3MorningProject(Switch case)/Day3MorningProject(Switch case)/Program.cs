using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3MorningProject_Switch_case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(ch))

            {
                case 'a':
                    Console.WriteLine("yes, vowel");
                    break;

                case 'e':
                    Console.WriteLine("yes, vowel");
                    break;

                case 'i':
                    Console.WriteLine("yes, vowel");
                    break;

                case 'o':
                    Console.WriteLine("yes, vowel");
                    break;

                case 'u':
                    Console.WriteLine("yes, vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;

            }
            Console.ReadLine();
        

            }
    }
}
