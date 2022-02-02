using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Day7Project3

{

    //**** DONE BY: PAVAN ****// 

    //*** PURPOSE: FINDING  EVEN NUMBERS USING 4 LOOPS****// 

   
    internal class Program

    {
        static void Main(string[] args)

        {
            List<int> data = new List<int>() { 42, 53, 64, 73, 86 };

            //USNG   FOR LOOP //
            for(int i = 0; i < data.Count; i++)
            { if(data[i]%2==0)
                    Console.WriteLine(data[i]);
            }
            

            //USING FOREACH LOOP//
            foreach(var d in data)
                { 
                if(d%2==0)
                Console.WriteLine(d); 
            }
            

            // USING LAMBDA EXPRESSION//
            data.Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine(d));
            

            // using LINQ //
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();

            




           

        }

    }

}