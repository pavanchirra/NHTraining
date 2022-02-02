using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project5
{
    //*** Done BY : PAVAN****//
    //*** PURPOSE : CREATING A CLASS USING 4 LOOP CONCEPTS:****//
    class College
    {
        public int id;
        public string city;
        public int count;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<College> stu = new List<College>()
            {
                new College() { id = 7676, city ="MALLAREDDY",count = 155},
                 new College() { id = 1234, city ="NARSIMHAREDDY",count = 165},
                  new College() { id = 4321, city ="BVRIT",count = 175},
                   new College() { id = 9999, city ="CBIT",count = 115},
                    new College() { id = 5678, city ="MLRIT",count = 95},
                    };
            //USING FOR LOOP//

            for (int i = 0; i < stu.Count; i++)
            {
                if (stu[i].count >= 150)
                    Console.WriteLine($"{stu[i].id},{stu[i].city}");
            }
            //USING FOREACH LOOP//
            foreach (College s in stu)
            {
                if (s.count >= 150)
                    Console.WriteLine($"{s.id},{s.city}");
            }

            //USING LAMBDA//
            stu.Where(h => h.count >= 150).ToList().ForEach(s => Console.WriteLine($"{s.id},{s.city}"));

            //USING LINQ EXPRESSION//

            var result = from s in stu
                         where s.count >=150
                         select s;
            result.ToList().ForEach(s => Console.WriteLine($"{s.id},{s.city}"));
            Console.ReadLine();
        }
    }
}
