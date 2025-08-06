using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Example
    {
        string name;
        int age;

        public Example(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Example(Example e)
        {
            this.name = e.name;
            this.age = e.age;
        }
        public void getData()
        {
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Age is " + age);
            Console.WriteLine("---------------------------------");
        }
    }
    internal class Copy_constructor
    {
        static void Main(string[] args)
        {
            Example obj1 = new Example("Om",22);
            obj1.getData();
            Example obj2 = new Example(obj1);
            obj2.getData();
            Console.ReadLine();
        }
    }
}
