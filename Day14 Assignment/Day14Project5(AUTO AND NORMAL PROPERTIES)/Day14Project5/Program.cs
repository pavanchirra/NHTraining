using System;
using System.Collections.Generic;


namespace Day14Project5
{
    class SpeedCalculation
    {
        /// <summary>
        /// DONE BY: PAVAN
        /// PURPOSE: WRITE A C# PROGRAM ON AUTO-IMPLEMENTED PROPERTY.
        /// </summary>
        /// <param name="args"></param>
        private int time;
        private int distance;

        public int Time
        { set { time = value; } }
        public int Distance
        { set { distance = value; } }
        public int Speed 
        { get { return distance / time; } }
        public int Velocity
        { get { return distance / time; } set { } }
    }
    internal class program
    { 
    static void Main(string[] args)
        {
            SpeedCalculation sc = new SpeedCalculation();
            sc.Time = 57;
            sc.Distance = 684;
            Console.WriteLine("***** Calculating the Speed******");
            Console.WriteLine($"{sc.Speed}");
            Console.ReadLine();
        }
    }
}
