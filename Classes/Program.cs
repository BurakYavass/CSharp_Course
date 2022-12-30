using System;

namespace Classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Burak";
            customer.LastName = "Yavas";

            Customer customer2 = new Customer
            {
                Id = 2, City = "Istanbul",FirstName = "Meltem", LastName = "Ersoy"
            };
            
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    
}