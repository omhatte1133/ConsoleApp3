using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Generic_StackEx1
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<string> stack2 = new Stack<string>();
            stack1.Push(103);
            stack1.Push(27776);
            stack1.Push(455);
            stack1.Push(333);
            stack1.Push(432);
            stack1.Push(4345);
            stack1.Push(56772);
            stack1.Push(675);

            stack1.Pop();

            stack2.Push("OM");
            stack2.Push("Deepak");
            stack2.Push("Pranav");
            stack2.Push("Vishal");
            stack2.Push("Shyam");
            stack2.Push("Shital");

            Console.WriteLine("Current Stack Values");
            foreach (int i in stack1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Current Stack Values");
            foreach (string i1 in stack2)
            {
                Console.WriteLine(i1);
            }
        }
    }
}
