using System;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aggregation");
        }
    }


    public abstract class Engine
    {

    }

    public class Car
    {
        Engine _engine;

        public Car(Engine eng)

        {
            _engine = eng;
            
        }

    }

}
