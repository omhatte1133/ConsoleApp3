using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Hash_TableEx2
    {
        static void AddProduct(Hashtable ht)
        {
            try
            {
                Console.WriteLine("Enter Product ID(KEY)");
                int id = Convert.ToInt32(Console.ReadLine());

                if (ht.ContainsKey(id))
                {
                    Console.WriteLine("Product id already Exist");
                }
                else
                {
                    Console.WriteLine("Enter product name");
                    string name = Console.ReadLine();
                    ht.Add(id, name);
                    Console.WriteLine("Product Added Successfully");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input, ID must be Number");
            }
        }

        static void SearchProduct(Hashtable ht)
        {
            try
            {
                Console.WriteLine("Enter Product ID(Key) to update");
                int id = Convert.ToInt32(Console.ReadLine());

                if (ht.ContainsKey(id))
                {
                    Console.WriteLine($"Product count : {id} and name is {ht[id]}");
                    Console.WriteLine("Product search successfully");
                }
                else
                {
                    Console.WriteLine("Product ID is not found");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input, ID must be Number");
            }
        }

        static void UpdateProduct(Hashtable ht)
        {
            try
            {
                Console.WriteLine("Enter Product ID(Key) to update");
                int id = Convert.ToInt32(Console.ReadLine());

                if (ht.ContainsKey(id))
                {
                    Console.WriteLine("Enter your new product name");
                    string newname = Console.ReadLine();
                    ht[id] = newname;
                    Console.WriteLine("Product name updated successfully");
                }
                else
                {
                    Console.WriteLine("Product ID is not found");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input, ID must be Number");
            }
        }

        static void DeleteProduct(Hashtable ht)
        {
            try
            {
                Console.WriteLine("Enter Product ID(Key) to update");
                int id = Convert.ToInt32(Console.ReadLine());

                if (ht.ContainsKey(id))
                {
                    ht.Remove(id);
                    Console.WriteLine("Product Removed successfully");
                }
                else
                {
                    Console.WriteLine("Product ID is not found");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input, ID must be Number");
            }
        }

        static void DisplayProduct(Hashtable ht)
        {

            if (ht.Count == 0)
            {
                Console.WriteLine("Product not available");
            }
            else
            {
                Console.WriteLine("Product List");
                foreach (DictionaryEntry item in ht)
                {
                    Console.WriteLine($"ID is {item.Key}, Name is {item.Value}");
                }
                Console.WriteLine($"Total Products=cts {ht.Count}");   //count
            }
        }

        static void Main(string[] args)
        {
            Hashtable product = new Hashtable();
            while (true)
            {
                Console.WriteLine("-----------------Product Catlog Menu-------------------");
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Update Product");
                Console.WriteLine("3.Delete Product");
                Console.WriteLine("4.Search Product");
                Console.WriteLine("5.Display All Products List");
                Console.WriteLine("6.Clear All Products List");
                Console.WriteLine("0.Exit");

                Console.WriteLine("Enter Your Choice :");
                int choice = 0;

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input, Please enter number");
                }

                switch (choice)
                {
                    case 1:
                        AddProduct(product); break;
                    case 2:
                        UpdateProduct(product); break;
                    case 3:
                        DeleteProduct(product); break;
                    case 4:
                        SearchProduct(product); break;
                    case 5:
                        DisplayProduct(product); break;
                    case 6:
                        product.Clear();
                        Console.WriteLine("All products cleared");
                        break;

                    case 0:
                        Console.WriteLine("Existing");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }
    }
}
