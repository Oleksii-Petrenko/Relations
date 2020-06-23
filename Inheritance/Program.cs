using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.Id = 10;
            manager.Name = "Jonh";
            manager.Company = "Google";


            User user = new Manager();
            user.Id = 11;
            user.Name = "Bill";


            Console.WriteLine($" свойства мееджера {0} {1} {2}", manager.Id, manager.Name, manager.Company);

            Console.WriteLine($" свойства юсера {0} {1} {2}", user.Id, user.Name);

        }


        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Manager : User
        {
            public string Company { get; set; }
        }

    }
}
