using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project4
{
    internal class Products
    {
        private int productID;
        private string productName;
        private string productBrand;
        private int productPrice;

        public void CreateProductData()
        {
            Console.WriteLine("\nEnter the Product ID : ");
            productID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the Product Name : ");
            productName = Console.ReadLine();

            Console.WriteLine("\nEnter the Product Brand : ");
            productBrand = Console.ReadLine();

            Console.WriteLine("\nEnter the Product Price : ");
            productPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
        }

        public void DisplayProducts()
        {
            Console.WriteLine(" Product Details ");
            Console.WriteLine($"\n\tProduct Id : {productID}\n\tProduct Name : {productName}" +
                $"\n\tProduct Brand : {productBrand}\n\tProduct Price : {productPrice}");
        }
    }
}