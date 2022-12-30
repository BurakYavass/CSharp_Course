using System;

namespace Interfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //InterfacesIntro();

            //InterfaceDemo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlCustomerDal(), 
                new OracleCustomerDal()
            };

            foreach (var vaCustomerDal in customerDals)
            {
                vaCustomerDal.Add();
            }

            Console.ReadLine();
        }

        private static void InterfaceDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Yavas",
            };

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Meltem",
                LastName = "Ersoy",
            };

            manager.Add(customer);
            manager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            
            public string Address { get; set; }
            
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            
            public string Department { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}