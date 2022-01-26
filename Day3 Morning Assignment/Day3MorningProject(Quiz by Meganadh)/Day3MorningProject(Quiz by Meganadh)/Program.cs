using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3MorningProject_Quiz_by_Meganadh_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 9, ans;
            string name;
            Console.WriteLine("Enter your name:");
            name =Console.ReadLine();

            Console.WriteLine("****____****");

            Console.WriteLine("Hi {0}, Welcome to quiz by Meganadh",name);

            Console.WriteLine("****____****");

            Console.WriteLine("Q1. What is your favourite dish:");
            Console.WriteLine("1. Chicken Biriyani  2.Veg Palav 3. Sambhar Rice ");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score += 20;
            Console.WriteLine("Q2. What is your favourite food place:");
            Console.WriteLine("1. Mehfil  2.Mandi@36 3. Krishnapatnam Restaurant ");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;

            Console.WriteLine("Q3. Who is your favourite cricket player:");
            Console.WriteLine("1.Virat Kohli  2.MS Dhonii 3. Rahul Dravid ");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;

            Console.WriteLine("Q4. Which one is your favourite destination :");
            Console.WriteLine("1.Paris  2.Switzerland 3. Amesterdam : ");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;

            Console.WriteLine("Q5. Which one is your favourite Sport :");
            Console.WriteLine("1.Cricket  2.Volleyball 3.Candycrush : ");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;
            if (score >= 60)
               
                Console.WriteLine("Congratulations {0}, you got {1}% in this quiz",name,score);
            else
                Console.WriteLine("Sorry {0}, you are failed with{1}%.", name, score);
            Console.ReadLine();
        }
    }
}
