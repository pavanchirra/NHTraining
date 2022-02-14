using System;
using System.Collections.Generic;


namespace Day16Project1
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: PRINT HELLO IN OBJECT ORIENTED PROGRAM//
    /// </summary>
    class Message
    {
        public static void PrintHello()
        {
            Console.WriteLine("*****HELLO WORLD*****");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Message.PrintHello();
            Console.ReadLine();
        }
    }
}
