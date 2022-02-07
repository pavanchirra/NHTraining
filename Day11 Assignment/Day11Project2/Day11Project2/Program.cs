using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project2
{
    /// <summary>
    /// DONY BY: PAVAN
    /// PURPOSE: CREATING sample code to illustrate properties as discussed in class.
  // id
   //name
   //designation
  // salary
    /// </summary>
    class Employee
    {
        private int id;
        private string name;
        private string designation;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Designation
        {
            set { designation = value; }
        }
        public int Salary
        {
            get
            {
                if (designation == "M")
                    return 90000;
                else if (designation == "EMP")
                    return 50000;
                else if (designation == "SECURITY")
                    return 15000;
                else
                    return 30000;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine("******MANAGER DETAILS******");
            e.Id = 20;
            e.Name = "JK";
            e.Designation = "M";
            Console.WriteLine($" {e.Id} {e.Name} {e.Salary}");

            Employee emp1 = new Employee();
            Console.WriteLine("******EMPLOYEE DETAILS******");
            emp1.Id = 861;
            emp1.Name = "NARESH";
            emp1.Designation = "EMP";
            Console.WriteLine($" {emp1.Id} {emp1.Name} {emp1.Salary}");

            Employee emp2 = new Employee();
            Console.WriteLine("******SECURITY*****");
            emp2.Id = 222;
            emp2.Name = "SINGH";
            emp2.Designation = "SECURITY";
            Console.WriteLine($" {emp2.Id} {emp2.Name} {emp2.Salary}");

           
            Console.ReadLine();
        }
    }
}
