using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class QueueEx1
    {

        static void Main(string[] args)
        {
            Queue myqueue = new Queue();
            myqueue.Enqueue("Person1");
            myqueue.Enqueue("Person2");
            myqueue.Enqueue("Person3");
            myqueue.Enqueue("Person4");

            Console.WriteLine("Current Queue");
            foreach (var item in myqueue)
            {
                Console.Write("\t" + item);
            }

            Console.WriteLine($"\n Peek {myqueue.Peek()}");

            myqueue.Dequeue();
            myqueue.Dequeue();

            Console.WriteLine("Current Queue");
            foreach(var item in myqueue)
            {
                Console.Write("\t" + item);
            }

            Console.WriteLine("Contains " + myqueue.Contains("Person3"));
            Console.WriteLine("Total remaining in Queue" + myqueue.Count); //Top

            Console.ReadLine();
        }
    }
}
