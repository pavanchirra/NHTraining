using System;
using System.IO;


namespace Day15Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\C#\project\FileOperations.txt";
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine("Thsis");
            sw.WriteLine("This");
            sw.WriteLine("that");
            sw.Close();
            string TaskSchedularPath = @"C:\temp\MyTest.txt";
            if (File.Exists(TaskSchedularPath))
                File.Delete(TaskSchedularPath);

            File.Copy(filePath, TaskSchedularPath);

            Console.WriteLine("File Copying is Done");

            Console.ReadKey();
        }
    }
}