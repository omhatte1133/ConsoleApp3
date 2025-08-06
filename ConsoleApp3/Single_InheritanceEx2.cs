using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("The vehicle is starting");
        }
    }

    class Bike : Vehicle
    {
        public void Two()
        {
            Console.WriteLine("The bike are two wheels");
        }
    }

    class Car :Vehicle
    {
        public void Four()
        {
            Console.WriteLine("The car are four wheels");
        }
    }

    class Truk : Vehicle
    {
        public void Six()
        {
            Console.WriteLine("The truk are six wheels");
        }
    }
    internal class Single_InheritanceEx2
    {
        static void Main(string[] args)
        {
            Bike b = new Bike();
            b.Start();
            b.Two();

            Car c = new Car();
            c.Start();
            c.Four();

            Truk t = new Truk();
            t.Start();
            t.Six();

            Console.ReadLine();
        }
    }
}
