using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class MultithreadingEx1
    {
        public static void func1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Fun1 = " + i);
            }
        }

        public static void func2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Fun1 = " + i);
                Console.WriteLine("Thread is going to sleep");

            }
        }

        public static void func3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Fun1 = " + i);
                Console.WriteLine("Thread is going to sleep");
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);
            t1.Start();
            t2.Start();
            t3.Start();


            Console.ReadLine();
        }
    }
}
