using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_PALINDROME_OR_NOT_
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: CHECK if the given number is PALNDROME or not.
    /// </summary>
    class Palindrome
    {
        int num, pan, temp, sum = 0;
        public void ReadNumber()
        {
            Console.WriteLine("Enter any Number");
            num = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintPalindrome()
        {
            temp = num;
            while (num > 0)
            {
                pan = num % 10;
                sum = (sum * 10) + pan;
                num = num / 10;
            }
            if (temp == sum)
                Console.Write($"{temp} is Palindrome.");
            else
                Console.Write($"{temp} is not Palindrome");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome P = new Palindrome();
            P.ReadNumber();
            P.PrintPalindrome();
            Console.ReadLine();
        }
    }
}
