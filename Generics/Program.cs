using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("deneme");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Burak" }, new Customer { FirstName = "Meltem"}, new Customer {FirstName ="Monster"});

            foreach (var customer in result2)
            {
                result.Add(customer.FirstName);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }

        class Product
        {

        }

        interface IProductDal :IRepository<Product>
        {
            
        }

        class Customer : IEntity
        {
            public string FirstName { get; set; }
        }

        interface ICustomerDal:IRepository<Customer>
        {
          
        }

        interface IEntity 
        {

        }
        
        //Deger tiplere gore kisitlamak istersek 
        //interface IRepository<T> where T : struct
        // Referans tiplere gore kisitlamak istersek
        interface IRepository<T> where T :class,new()
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);
            void Update(T entity);
        }

        class ProductDal : IProductDal
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }
    }
}
