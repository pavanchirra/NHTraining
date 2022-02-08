using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Project1
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: A SIMPLE DIVISION PROGRAM USING EXCEPTION HANDLING:
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a, b, c;
                Console.WriteLine("Enter first number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("{0}", c);
                Console.ReadLine();
            }
            //USING OVERFLOW EXCEPTION//
            catch (OverflowException)
            {
                Console.WriteLine("Enter the integer value from 0 to 50000: ");
            }
            //USING DIVIDE BY ZERO EXCEPTION//
            catch(DivideByZeroException)
            {
                Console.WriteLine("Enter the integer value greater than Zero: ");
            }
            //USING FORMAT EXCEPTION
            catch(FormatException)
            {
                Console.WriteLine(" Please Enter only integer value");
            }
            //USING GENERAL EXCEPTION//
            catch (Exception)
            {
                Console.WriteLine("Unable to display Output please contact admin@nbht.com");
                Console.ReadLine();
            }
        }
        
    }
}
