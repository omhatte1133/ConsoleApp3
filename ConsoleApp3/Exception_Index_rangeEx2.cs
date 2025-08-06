using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Exception_Index_rangeEx2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the number of elements: ");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[size];
                arr[0] = 101;
                arr[1] = 201;
                arr[2] = 301;
                arr[3] = 401;
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("You are trying to access an index that does not exist in array");
                Console.WriteLine(ex.Message);  
            }
           
            Console.ReadLine();
        }
    }
}
