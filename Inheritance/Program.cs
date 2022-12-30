using System;

namespace Inheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Customer customer = new Customer();

            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Burak"
                    , Id = 26
                },
                new Student
                {
                    FirstName = "Meltem", SchoolId = 06530
                },
                new Person
                {
                    FirstName = "Monster"
                }
            };

            foreach (var person in persons)
            {
                if (person.LastName != null)
                {
                    Console.WriteLine(person.LastName);
                }
                else if (person.FirstName != null)
                {
                    Console.WriteLine(person.FirstName);
                }
                
                if (person.Id != 0)
                {
                    Console.WriteLine(person.Id);
                }
                
            }

            Console.ReadLine();
        }
        
        

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }
        
        class Student : Person
        {
            public int SchoolId { get; set; }
        }
    }
}