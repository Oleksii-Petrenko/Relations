using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Composition");
        }
    }

    public class ElecticEngine
    {


    }

    public class Car
    {
        ElecticEngine _engine;

        public Car()
        {
            _engine = new ElecticEngine();
        }
    }

}
