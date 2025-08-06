using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class StackEx1
    {
        
    static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("Apple");
            myStack.Push("Grapes");
            myStack.Push("Mango");
            myStack.Push("Orange");

            Console.WriteLine("Current Stack");
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Contains Apple" + myStack.Contains("Apple"));

            Console.WriteLine("Top in stack(Peek)" + myStack.Peek());   //Top

            Console.WriteLine("Removing in stack(Peek)" + myStack.Pop());   //Removing

            Console.WriteLine("Top in stack(Peek)" + myStack.Peek());   //Top

            Console.WriteLine("Current Stack");
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total remaining in stack" + myStack.Count);  //Top

            myStack.Clear();
            Console.WriteLine("Total remaining in stack" + myStack.Count);


            Console.ReadLine(); 
        }
    }
}
