using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{
    internal class Program
    {
        /// <summary>
        /// DONE BY: PAVAN
        /// PURPOSE: QUIZ PROGRAM WITH CREATING A FILE:
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string fileName = "C:\\C#\\Project\\Day15 Assignment\\Score.txt";

            int score = 0, answer;
            string name;

            Console.Write("Enter your Name: ");
            name = Console.ReadLine();

            Console.WriteLine($"Hi {name} welcome to quiz by Pavan");
            Console.WriteLine("**************************************");

            Console.WriteLine("\nQ1. Which sport does Sachin Tendulkar plays?. ");
            Console.WriteLine("1.Cricket 2.Football 3.Volleball ");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
                score += 20;

            Console.WriteLine("\nQ2. Who is the CEO of Facebook: ");
            Console.WriteLine("1.Bill Gates 2.Ambani 3.Mark Zuckerberg:");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 3)
                score += 20;

            Console.WriteLine("\nQ3. Who wrote C# ? ");
            Console.WriteLine("1.Anders Hejlsberg 2.Anders James 3.Newton ");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
                score += 20;

            Console.Write("\nQ4. Where is Charminar located: ");
            Console.WriteLine("1.Vijayawada 2.Hyderabad 3.Delhi:");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
                score += 20;

            Console.WriteLine("\nQ5. Which team won IPL cup in 2021: ");
            Console.WriteLine("1.MUMBAI  2.CSK 3.RCB");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
                score += 20;
            //Adding Score to File
            if (File.Exists(fileName))
                File.Delete(fileName);
            Console.WriteLine("\n*****File Deleted*****\n");

            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine(name);
            sw.WriteLine(score);
            sw.Close();
            Console.WriteLine("*****Score Added*****");
            Console.WriteLine($"\nYour score has been recorded, {name} Admin will reach out you: ");

            Console.ReadLine();
        }
    }
}