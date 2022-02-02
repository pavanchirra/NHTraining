using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project4
{
    class Department
    {
        public int id;
        public string name;
        public int empcount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> dept = new List<Department>()
            {
                new Department() { id = 1111, name = "policestation",empcount= 50  },
                new Department() { id = 2222, name = "firestation", empcount= 75 },
                new Department() { id = 3333, name = "railway",empcount= 100 },
                new Department() { id = 4444, name = "navy", empcount=55 },
                new Department() { id = 5555, name = "army", empcount= 60 },
                };
            //USING FOR LOOP//
            Console.WriteLine("*****USING FOR LOOP*****");
            for (int i = 0; i < dept.Count; i++)
            {
                if (dept[i].empcount >= 60)
                    Console.WriteLine($"{dept[i].id},{dept[i].name}");
            }

            //USING FOREACH LOOP//
            Console.WriteLine("****USING FOREACH LOOP****");
            foreach (Department d in dept)
            {
                if (d.empcount >= 60)
                    Console.WriteLine($"{d.id},{d.name}");
            }

            Console.WriteLine("*****USING LAMBDA******");
            //USING LAMBDA EXPRESSION//
            dept.Where(d => d.empcount >= 60).ToList().ForEach(d => Console.WriteLine($"{d.id},{d.name}"));


            //USING LINQ EXPRESSION//
            Console.WriteLine("***USING LINQ****");
            var result = from d in dept
                         where d.empcount >= 60
                         select d;
            result.ToList().ForEach(d => Console.WriteLine($"{d.id},{d.name}"));
            Console.ReadLine();
        }
    }
}

