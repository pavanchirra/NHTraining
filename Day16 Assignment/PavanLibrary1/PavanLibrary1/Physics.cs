using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavanLibrary1
{
    public class Physics
    {
        public void FinalVelocity(int u, int a, int t)
        {
            Console.WriteLine("FinalVelocity is : {0}", u + a * t);
        }
    }
}