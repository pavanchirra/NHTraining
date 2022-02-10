using System;
using System.Collections.Generic;
namespace SealedDemo
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: CREATING A SEALED CLASS IN WHICH MANAGER CAN ACCESS EMPLOYEE CLASS//
    /// </summary>
    public class Employee
    {
        public int id;
        public string name;
        public virtual void GetEmployeeData()
        {
            Console.WriteLine("EMPLOYEE DETAILS:");
            Console.WriteLine("ENTER THE ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE NAME");
            name = Console.ReadLine();
        }
             public virtual void DisplayEmployeeData()
        {
            Console.WriteLine("\nEMPLOEE DETAILS ARE:");
            Console.WriteLine("EMPLOYEE ID IS: " + id);
            Console.WriteLine("EMPLOYEE NAME IS: " + name);
        }
    }
    public sealed class Manager : Employee
    {
        public override void GetEmployeeData()
        {
            Console.WriteLine("MANAGER DETAILS:");
            Console.WriteLine("ENTER THE ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE NAME");
            name = Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.GetEmployeeData();
            m.DisplayEmployeeData();
            Console.ReadLine();
        }
    }
}

