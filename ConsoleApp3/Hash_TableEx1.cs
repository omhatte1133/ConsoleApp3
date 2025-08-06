using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Hash_TableEx1
    {
        static void DisplayProducts(Hashtable ht)
        {
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"Id is {item.Key}, Name is {item.Value}");
            }
        }
        static void Main(string[] args)
        {
            Hashtable product = new Hashtable();
            product.Add(101, "Laptop");
            product.Add(102, "Mobile");
            product.Add(103, "Tablet");

            Console.WriteLine();
            DisplayProducts(product);
            Console.WriteLine($"Total Products {product.Count}");   //count

            Console.WriteLine($"Product with ID 102 - {product[102]}");  //access value using key

            product[102] = "Smart Phone";   //updated
            Console.WriteLine("Updated value for 102");
            Console.WriteLine($"Product with ID 102 - {product[102]}");  //updated value
            Console.WriteLine("Updated Products");
            DisplayProducts(product);

            //Contain key
            if(product.ContainsKey(102))
            {
                Console.WriteLine("Key Exist");
            }
            else
            {
                Console.WriteLine("Key does not exits");
            }

            //Contain value
            if (product.ContainsValue("Tablets"))
            {
                Console.WriteLine("Value Exist");
            }
            else
            {
                Console.WriteLine("Value does not exits");
            }

            product.Remove(101);
            DisplayProducts(product);
            Console.WriteLine($"Total Products {product.Count}");  //count

            product.Clear();
            DisplayProducts(product);
            Console.WriteLine($"Total Products {product.Count}");
            Console.ReadLine();
        }
    }
}
