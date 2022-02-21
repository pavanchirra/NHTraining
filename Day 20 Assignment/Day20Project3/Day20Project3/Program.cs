using System;

namespace RefAndOutParameters
{
    /// <summary>
    /// DONE: PAVAN
    /// PURPOSE: REF AND OUT KEYWORDS
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// This is a method for Ref Keyword Example
        /// </summary>
        /// <param name="id"> ref id</param>
        /// <returns>NextId</returns>
        public static string NextNameByRef(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }
   
        public static string NextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }
        /// <summary>
        /// Main Method, Code Starting point.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int i = 1;
            Console.WriteLine("Previous value of integer i : " + i.ToString());
            string testRef = NextNameByRef(ref i);
            Console.WriteLine("Current value of integer i : " + i.ToString());


            int j;
            string testOut = NextNameByOut(out j);
            Console.WriteLine("Current value of integer j:" + j.ToString());

            Console.ReadKey();
        }
    }
}
