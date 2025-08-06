using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Method_Overloading_Poly1
    {
        public void add()
        {
            int a = 1;
            int b = 2;
            int c = a+b;
            Console.WriteLine(c);
        }

        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public void add(string a, string b)
        {
            string c = a + " " +  b;
            Console.WriteLine(c);
        }

        public void add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Method_Overloading_Poly1 m1 = new Method_Overloading_Poly1();
            m1.add();
            m1.add(3.5f, 1.5f);
            m1.add("Dipesh", "Pranav");
            m1.add("Dipesh", "My Friend");
            m1.add("My Friend", "Pranav");
            Console.ReadLine();

        }
    }
}
