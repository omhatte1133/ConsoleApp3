using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Generic_Hash_SetEx1
    {
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Grapes");
            fruits.Add("Apple");
            fruits.Add("Mango");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            fruits.Remove("Mango");
            Console.WriteLine("\nCurrent Fruits:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            HashSet<string> newfruits = new HashSet<string>()
            {
                "Jack fruit","Pineapple","Mango","Apple"
            };
            fruits.UnionWith(newfruits);
            //fruits.IntersectWith(newfruits);
            Console.WriteLine("\nAfter union Current Fruits: ");

            foreach (string fruit in newfruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
    }
}
