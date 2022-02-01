using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project4
{
    internal class Department
    {
        private int departmentId;
        private string departmentName;

        public void ReadDepartment()
        {
            Console.WriteLine("\n Enter Department ID : ");
            departmentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Department Name : ");
            departmentName = Console.ReadLine();
            Console.WriteLine("\n");
        }
        public void DisplayDepartment()
        {
            Console.WriteLine("Dept Details");
            Console.WriteLine($"\n\t Department Id : {departmentId}\n\t Department Name : {departmentName}");
        }
    }
}