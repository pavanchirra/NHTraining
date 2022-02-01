using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Author : Pavan
// Purpose : Creating an 4 different Class 
namespace Day7Project4
{
    internal class Program
    {
        // Customer Class
        // Products Class
        // Seller Class
        // Department Class
        static void Main(string[] args)
        { 
            // Customer Instance
            Customer customer1 = new Customer();
            Console.WriteLine("Enter Customer Details : ");
            customer1.CreateCustomerData();

            // Products Instance
            Products product1 = new Products();
            Console.WriteLine("Enter Product Details : ");
            product1.CreateProductData();

            // Seller instance
            Seller sell1 = new Seller();
            Console.WriteLine("Enter Seller Details : ");
            sell1.CreateSellerData();

            // Department instance
            Department dep1 = new Department();
            Console.WriteLine("Enter Department Details : ");
            dep1.ReadDepartment();

            customer1.DisplayCustomerProfile();

            product1.DisplayProducts();

            sell1.DisplaySellerData();

            dep1.DisplayDepartment();
            Console.WriteLine("\n--------------------- The End------------------------------------");

            Console.ReadLine();
        }
    }
}




