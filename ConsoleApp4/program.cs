using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class program
    {
        static void main(string[] args)
        {
            LinkedList<int> num = new LinkedList<int>();
            num.AddFirst(10);
            num.AddLast(20);
            num.AddFirst(30);
            num.AddLast(5);

            Console.WriteLine("Linked List");

            foreach (int no in num)
            {
                Console.WriteLine(no + " ");
            }

            var position1 = num.Find(30);

            if (position1 != null)
            {
                num.AddAfter(position1, 7);
            }

            var position2 = num.Find(20);

            if (position2 != null)
            {
                num.AddBefore(position2, 10);
            }

            Console.WriteLine("LinkList Item");

            foreach (int no in num)
            {
                Console.WriteLine(no + " ");
            }



            Console.ReadLine();
        }


    }
}
