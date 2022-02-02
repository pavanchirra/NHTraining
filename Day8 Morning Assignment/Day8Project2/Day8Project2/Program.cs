using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day8Project2

{
    /// AUTHOR: PAVAN//
    /// PURPOSE: CREATING EMPLOYEE CLASS USING 4 LOOPS///

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
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {id = 11, name= "pavan",salary = 10000},

            };
            //USING FOR LOOP//
            for (int i = 0; i < employees.Count; i++)
            {

                Console.WriteLine($"id= {employees[i].id},name={employees[i].name},salary= {employees[i].salary}");


                //USING FOREACH LOOP//
                foreach (var e in employees)
                {
                    Console.WriteLine($"id ={e.id}, name = {e.name}, salary = {e.salary}");
                }
                //USING  LAMBDA EXPRESSION//
                employees.ForEach(e => Console.WriteLine($"id= ={e.id}, name = {e.name}, salary = {e.salary}"));


                //USING LINQ//
                var result = from e in employees
                             select e;
                result.ToList().ForEach(e => Console.WriteLine(e.name+e.salary+e.id));
                Console.ReadLine();
            }
        }

    }
}
