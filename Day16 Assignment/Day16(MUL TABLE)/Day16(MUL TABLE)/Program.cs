using System;
using System.Collections.Generic;

namespace Day16_MUL_TABLE_
{/// <summary>
/// DONE BY: PAVAN
/// PURPOSE: CREATING A MULTIPLICATIONTABLE USING OOPS//
/// </summary>
    class MultiplicationTable
    {
        /// <summary>
        /// Giving input and ReadData
        /// </summary>
        int input;
        public void ReadData()
        {
            Console.WriteLine("Enter any number:");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Print a  multiplication Table
        /// </summary>
        public void PrintTable()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{input} * {i}= {input * i}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTable t = new MultiplicationTable();
            t.ReadData();
            t.PrintTable();
            Console.ReadLine();
        }
    }
    }

