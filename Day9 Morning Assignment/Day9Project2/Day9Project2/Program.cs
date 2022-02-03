using System;

// Author : PAVAN
// Purpose : Create a Class to Read Two inputs and print Sum, Difference, Product & Division.

namespace Day9Project2
{
    class MathsOps
    {
        private int a, b;
        private int temp;

        public void ReadData()
        {
            Console.WriteLine("\nEnter Any two inputs to perform all Arithametic Operations : \n");
            Console.Write("Enter a Value : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter b Value : ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        ///Sum Of Two Numbers///
        /// </summary>
        public void Addition()
        {
            temp = a + b;
            Console.WriteLine($"\nThe Sum Of Numbers {a} + {b} is : {temp}");
        }
        /// <summary>
        /// Difference of Two Numbers///
        /// </summary>
        public void Difference()
        {
            temp = a - b;
            Console.WriteLine($"\nThe Difference Of Numbers {a} - {b} is : {temp}");
        }
        /// <summary>
        ///   Product of Two Numbers///
        /// </summary>
        public void Product()
        {
            temp = a * b;
            Console.WriteLine($"The Product Of  Numbers {a} * {b} is : {temp}");
        }
        /// <summary>
        /// Division of Two Numbers///
        /// </summary>
        public void Division()
        {
            temp = a / b;
            Console.WriteLine($"The Division Of Numbers {a} / {b} is : {temp}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOps d = new MathsOps();
            d.ReadData();
            d.Addition();
            d.Difference();
            d.Product();
            d.Division();
            Console.WriteLine("******-THE END-*********");

            Console.ReadLine();
        }
    }
}