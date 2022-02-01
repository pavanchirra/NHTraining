using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project4
{
    internal class Customer
    {
        private int customerId;
        private string customerName;
        private string customerSubscriptionDetails;
       

        public void CreateCustomerData()
        {
            Console.WriteLine("\nEnter Customer ID : ");
            customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Customer Name : ");
            customerName = Console.ReadLine();

            Console.WriteLine("\nEnter Customer Subscription Type : ");
            customerSubscriptionDetails = Console.ReadLine();

            
        }

        public void DisplayCustomerProfile()
        {
            Console.WriteLine("Customer Details");
            Console.WriteLine($"\n\tCustomer Id : {customerId}\n\tCustomer Name : {customerName}" +
                $"\n\tSubscription Type : {customerSubscriptionDetails}\n\tMobile No. : ");

        }
    }
}
