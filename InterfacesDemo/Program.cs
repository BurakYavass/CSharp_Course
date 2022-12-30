namespace InterfacesDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };

        }

        interface IWorker
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        
        interface ISalary
        {
            void GetSalary();
        }

        class Manager : IWorker,IEat,ISalary
        {
            public void Work()
            {
                throw new System.NotImplementedException();
            }

            public void Eat()
            {
                throw new System.NotImplementedException();
            }

            public void GetSalary()
            {
                throw new System.NotImplementedException();
            }
        }

        class Worker : IWorker , IEat , ISalary
        {
            public void Work()
            {
                throw new System.NotImplementedException();
            }

            public void Eat()
            {
                throw new System.NotImplementedException();
            }

            public void GetSalary()
            {
                throw new System.NotImplementedException();
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}