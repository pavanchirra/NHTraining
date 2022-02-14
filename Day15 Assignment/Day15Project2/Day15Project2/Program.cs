using System;
using System.IO;
using System.Text;
namespace Day15Project1
{
    /// <summary>
    /// DONE: PAVAN
    /// PURPOSE: WRITING C# PROGRAM ON 10 METHODS IN FILE OPERATIONS:
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assigning a File Path using Verbatim String Manipulation method.
            string fileName = @"C:\C#\Project:c#\FileOperations.txt";

            // Creating a File with Given File Path
            StreamWriter sw = File.CreateText(fileName);

            sw.WriteLine("Hi this File Operations using C# code");

            sw.WriteLine("");
            sw.WriteLine(" using StringWriter, by using WriteLine Method.");

            sw.Write("This Line is by Write Method");
            sw.Write("This is Second Line using Write Method\n");
            sw.Close();

            // Appending a Text 
            sw = File.AppendText(fileName);
            sw.WriteLine("This");
            sw.WriteLine("is Extra");
            sw.WriteLine("Text");
            Console.WriteLine("\nFile Appending  is Done by Append_Text Method.");
            sw.Close();

            StreamReader sr = File.OpenText(fileName);
            string s;
            Console.WriteLine("\n");
            while ((s = sr.ReadLine()) != null)
                Console.WriteLine(s);

            sr.Close();
            
            Console.WriteLine("\nFile Appended with Extra Text , Successfully");

            string readText = File.ReadAllText(fileName);
            Console.WriteLine("\n\n Reading All Text From the File\n");
            Console.WriteLine(readText);

            Console.ReadLine();
        }
    }
}
