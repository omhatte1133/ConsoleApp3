using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Animal
    {
        public void Eat() 
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog: Animal 
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    internal class Single_InheritanceEx1
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Eat();
            d.Bark();
            Console.ReadLine();
            
        }
    }
}
