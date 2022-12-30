using System;

namespace VirtualMethods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }

        class DataBase
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }
            public void Delete()
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class SqlServer : DataBase
        {
            public override void Add()
            {
                Console.WriteLine("Added Sql Server");
                //base.Add();
            }
        }

        class MySql : DataBase
        {
            
        }
    }
}