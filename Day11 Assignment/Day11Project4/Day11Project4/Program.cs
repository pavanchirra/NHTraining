using System;

/// <summary>
/// DONE BY: PAVAN
/// PURPOSE: Create a class Employee with only properties.
/// </summary>
namespace Day11Project3
{
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
            get => name;
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
                    return 75000;
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
            e.Id = 20;
            e.Name = "JK";
            e.Designation = "TL";
            Console.WriteLine($"{e.Id},{e.Name},{e.Salary}");

            Employee emp1 = new Employee();
            emp1.Id = 876;
            emp1.Name = "NARESH";
            emp1.Designation = "EMP";
            Console.WriteLine($"{emp1.Id},{emp1.Name}, {emp1.Salary}");

            Employee emp2 = new Employee();
            emp2.Id = 222;
            emp2.Name = "SINGH";
            emp2.Designation = "SECURITY";
            Console.WriteLine($"{emp2.Id},{emp2.Name},{emp2.Salary}");

            Console.ReadLine();
        }
    }
}