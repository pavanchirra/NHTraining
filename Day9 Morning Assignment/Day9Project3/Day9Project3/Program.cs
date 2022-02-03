using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author : PAVAN
//Purpose : Create an Employee Class with 4 variables,USE A SINGLE STATIC VOID//



namespace Day9Project3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NATIONSBEEFITS";

        public void ReadData()
        {
            Console.Write("Enter Employee ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Employee Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        {
            
            Console.WriteLine($" Id : {id}, Name : {name}, Salary : {salary}, Company : {company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            // READDATA
            emp1.ReadData();
            emp2.ReadData();

            Console.WriteLine(" Print Employee Data ");
            // PRINTDATA
            emp1.PrintData();
            emp2.PrintData();

            Console.ReadLine();
        }
    }
}