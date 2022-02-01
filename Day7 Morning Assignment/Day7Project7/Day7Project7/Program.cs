using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project3
{
    //**** DONE BY : PAVAN ****//
    //*** PURPOSE  : CALCULATING THE RANGE USING 3 LOOPS****//
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
            Employee[] employees = new Employee[]
            {

                    new Employee() { id = 1, name = "PAVAN", salary = 50000 },
                    new Employee() { id = 2, name = "MANOJ.K", salary = 45000 },
                    new Employee() { id = 3, name = "MANOJ.Y", salary = 43000 },
                    new Employee() { id = 4, name = "VAMSI", salary = 41000 },
                    new Employee() { id = 5, name = "VIHAR", salary = 42000 }
                };
            //for LOOP//
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].salary>= 43000)
                Console.WriteLine($"id ={employees[i].id},name = {employees[i].name},salary = {employees[i].salary}");
            }
            Console.ReadLine();
            // foreach loop//
            foreach (var e in employees)
            {
                if(e.salary>= 43000)
                Console.WriteLine($"id ={e.id},name = {e.name},salary = {e.salary}");
            }
            Console.ReadLine();

            //Lambda expression//
           
            employees.ToList().Where(e=>e.salary >= 43000).ToList().ForEach(e => Console.WriteLine($"id ={e.id},name = {e.name},salary = {e.salary}"));
            Console.ReadLine();
        }
    }
}

