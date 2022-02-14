using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PavanLibrary1;

namespace Day16Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            Console.WriteLine(m.Add(5, 8));
            Console.WriteLine(m.Sub(12, 7));

            Physics p = new Physics();
            {
                p.FinalVelocity(9, 5, 8);
            }

            Chemistry c = new Chemistry();
            c.Benzene();
            c.Water();
            Console.ReadLine();
        }
    }
}
