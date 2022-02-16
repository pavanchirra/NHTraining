using System;
using System.Collections.Generic;

namespace MathematicsLibrary
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: CREATING AN ALGEBRA CLASS;
    /// </summary>
    public class Algebra
     {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
                return -9999;
            else if (n > 7)
                return -999;
            else
            {
                int fact = 1;
                for (int i = 0; i < +n; i++)
                    fact = fact * i;
                return fact;
            }

            
          
            
        }
    }
}
