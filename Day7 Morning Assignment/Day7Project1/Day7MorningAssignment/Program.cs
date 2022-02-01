using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7MorningAssignment
{
    //*****************************************//
    //****Done By : Pavan //
    //***** Purpose : Creating Class Employee;//
    class Employee
    {
        public int id;
        public string name;
        public string salary;
        public void ReadEmployee()
        {
            Console.WriteLine("enter id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name:");
            name = Console.ReadLine();

            Console.WriteLine("enter salary:");
            salary = Console.ReadLine();
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"id={id},name = {name},salary= {salary}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.ReadEmployee();
                emp.PrintEmployee();
                Console.ReadLine();

            }
        }
    }
}
