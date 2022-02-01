using System;
using System.Linq;

// Author : PAVAN
// Purpose : Create Customer and Products class data in the form of Array while USING 3 LOOPS//
namespace Day7Project8
{
    class Customer
    {
        public int customerId;
        public string customerName;
        public string customerSubscription;
    }

    class Products
    {
        public int productId;
        public string productName;
        public int productPrice;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[]
            {
                new Customer(){ customerId = 1, customerName = "Manoj.Karnatapu", customerSubscription = "Prime User"},
                new Customer(){ customerId = 2, customerName = "Pavan Kumar", customerSubscription = "AHA"},
                new Customer(){ customerId = 3, customerName = "Vihar Dasari", customerSubscription = "NETFLIX"}
            };
            // Using For Loop
            
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine($"Customer Id = {customers[i].customerId},  Customer Name = {customers[i].customerName},  Customer Subscription = {customers[i].customerSubscription}");
            }

            // Using For Each Loop
            foreach (var e in customers)
            {
                Console.WriteLine($"Customer.ID = {e.customerId},  Customer.Name= {e.customerName},  Customer.Subscription = {e.customerSubscription}");
            }
            // Using Lambda Expression

            customers.ToList().ForEach(d => Console.WriteLine($"ID = {d.customerId},  Name = {d.customerName},  Subscription = {d.customerSubscription}"));


            // For Products Class
            Products[] products = new Products[]
            {
                new Products(){ productId = 1, productName = "SAMSUNG TV", productPrice = 40000},
                new Products(){ productId = 2, productName = "SONY", productPrice = 130000},
                new Products(){ productId = 3, productName = "OnePlus TV", productPrice = 48000}
            };
            // Using For Loop
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product Id = {products[i].productId},  Product Name = {products[i].productName},  Product price = {products[i].productPrice}");
            }

            // Using For Each Loop
            foreach (var p in products)
            {
                Console.WriteLine($"Product.ID = {p.productId},  Product.Name= {p.productName},  Product.Price = {p.productPrice}");
            }
            // Using Lambda Expression

            products.ToList().ForEach(d => Console.WriteLine($"ID = {d.productId},  Name = {d.productName},  Price = {d.productPrice}"));

            Console.ReadLine();

        }
    }
}