using System;

namespace MathProblems
{
    /// <summary>
    /// DONE BY: PAVAN
    /// </summary>
    class MathProblems
    {
        private int input;

        ///<summary>
        ///USER INPUT//
        ///<summary>
        public void ReadData()
        {
            Console.WriteLine("enter a number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        ///<summary>
        ///FIND FACTORIAL //
        ///<summary>
        public void Factorial()
        {
            int fact = 1;
            for (int i = 0; i < input; i++)
                fact = fact * i;
            Console.WriteLine($"Factors of {input} is {fact}");
        }


        ///<summary>
        ///Find Factors//
        ///<summary>
        public void Factors()
        {
            Console.WriteLine($"Factors of {input} ");
            for (int i = 0; i < input; i++)
            {
                if (input % 1 == 0)
                    Console.WriteLine($"{i}");
            }



            ///<summary>    
            ///Find Prime OR Not
            /// </summary>


        }
        public void Prime()
        {
            int i;
            for (i = 2; i <= input; i++)

            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
                Console.WriteLine($"{input} is Prime");
            else
                Console.WriteLine($"{input} is not a Prime number");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                MathProblems p = new MathProblems();
                p.ReadData();
                p.Factorial();
                p.Factors();
                p.Prime();
                Console.ReadLine();
            }
        }
    }
}