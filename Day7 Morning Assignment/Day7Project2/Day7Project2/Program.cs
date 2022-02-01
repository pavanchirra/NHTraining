using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project2
{
    //**** DONE BY : PAVAN ****//
    //*** PURPOSE  : CREATING 3 PUBLIC VARIABLES AND INITIALIZING IT.****//
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { id = 12345, name = "PAVAN", salary = 25000 };
            Console.WriteLine($"id = {emp.id},name = {emp.name},salary = {emp.salary}");
            Console.ReadLine();
        }
    }
}
