using System;
using System.Collections.Generic;


namespace Day16Project2
{
    /// <summary>
    /// DONE: PAVAN
    /// PURPOSE: WACP TO READ A NUMBER FROM USER AND PRNT FACTORIAL OF IT.
    /// </summary>
    class Mathematics
    {
        int input;
        public void ReadData()
        {
            Console.WriteLine("Enter any number:");
            input = Convert.ToInt32(Console.ReadLine());

        }

        public int GetFactorial()
        {
            int fact = 1;

            for (int i = 1; i <= input; i++)
            {
                
                    fact = fact * i;
                }
                return fact;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Mathematics m = new Mathematics();
                m.ReadData();
                Console.WriteLine(m.GetFactorial());
            }
        }
    }

