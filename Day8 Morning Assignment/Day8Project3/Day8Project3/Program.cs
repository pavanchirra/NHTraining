using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productprice
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product() { id = 1, name = "TV", price = 35000, brand = "samsung" },
                new Product() { id = 2, name = "MOBILE", price = 12000, brand = "OnePlus" },
                new Product() { id = 3, name = "CLOTHES", price = 4500, brand = "zara" },
                new Product() { id = 4, name = "LAPTOP", price = 40000, brand = "HP" },
                new Product() { id = 5, name = "WIFI", price = 5000, brand = "AIRTEL" },
                };
            //USING FOR LOOP//
            Console.WriteLine("*****USING FOR LOOP*****");
            for (int i = 0; i < product.Count; i++)
            {
                if (product[i].price >= 5000)
                    Console.WriteLine($"{product[i].name},{product[i].brand}");
            }

            //USING FOREACH LOOP//
            Console.WriteLine("****USING FOREACH LOOP****");
            foreach (Product p in product)
            {
                if (p.price >= 5000)
                    Console.WriteLine($"{p.name},{p.brand}");
            }

            Console.WriteLine("*****USING LAMBDA******");
            //USING LAMBDA EXPRESSION//
            product.Where(p => p.price >= 5000).ToList().ForEach(p => Console.WriteLine($"{p.name},{p.brand}"));


            //USING LINQ EXPRESSION//
            Console.WriteLine("***USING LINQ****");
            var result= from p in product
                        where p.price >= 5000
                        select p;
            result.ToList().ForEach(p => Console.WriteLine($"{p.name},{p.brand}"));
                Console.ReadLine();
        }
    }
}
