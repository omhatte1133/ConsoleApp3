using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Constructor_overloading2
    { 
        public Constructor_overloading2()
        {
            Console.WriteLine("This is default Constructor");
        }

        public Constructor_overloading2(int a, int b)
        {
            Console.WriteLine($"Parameter 2 Sum= {a + b}");
        }

        public Constructor_overloading2(string a, string b)
        {
            Console.WriteLine($"Parameter 2 Sum= {a}  {b}");
        }

        public Constructor_overloading2(float d, string e)
        {
            Console.WriteLine($"Parameter 2 Sum= {d} {e}");
        }

        static void Main (string[] args)
        {
            Constructor_overloading2 s1 = new Constructor_overloading2();
            Constructor_overloading2 s2 = new Constructor_overloading2(20,30);
            Constructor_overloading2 s3 = new Constructor_overloading2("Om","Hatte");
            Constructor_overloading2 s4 = new Constructor_overloading2(82.82f, "Marks");

            Console.ReadLine();
        }
    }
}
