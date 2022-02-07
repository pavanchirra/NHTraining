using System;

/// <summary>
/// DONE BY: PAVAN
/// PURPOSE: Create a class Employee with only properties.
/// </summary>
namespace Day11Project3
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();
            e.Id = 20;
            e.Name = "JK";
            e.Salary = 80000;
            e.Designation = "MANAGER";
            Console.WriteLine($"{e.Id},{e.Name},{e.Salary},{e.Designation}");

           

            Console.ReadLine();
        }
    }
}