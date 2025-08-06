using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Generic_QueueEx1
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(145);
            queue.Enqueue(199);
            queue.Enqueue(245);
            queue.Enqueue(3455);
            queue.Enqueue(4466);
            queue.Enqueue(5435);
            queue.Enqueue(6464);
            queue.Enqueue(7966);

            Console.WriteLine("Current Queue Values");
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

        }
    }
}
