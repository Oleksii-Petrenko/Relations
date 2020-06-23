using System;

namespace Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car();

            bmw.Move();

        }




    }

    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car moving");
        }

    }

}
