using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Non_Gen_ArrayListEx1
    {
        static void Ex1_StoreDifferentDataTypes()
        {
            ArrayList List = new ArrayList();
            List.Add(10);
            List.Add("Om");
            List.Add(3.50);

            Console.WriteLine("Example 1: Storing Different Dat Type: ");
            foreach (object item in List)  // or you can use var
            {
                Console.WriteLine(item);
            }
        }

        static void Ex2_RemoveDifferentDataType()
        {
            ArrayList Rem = new ArrayList();
            Rem.Add("Apple");
            Rem.Add("Banana");
            Rem.Add("Grapes");
            Rem.Add("Mango");

            Rem.RemoveAt(0);
            Rem.Remove("Mango");
        
            Console.WriteLine("Example 2: Remove Result:");
            foreach (object Frut in Rem)
            {
                Console.WriteLine(Frut);
            }

        }

        static void Ex3_SortingItems()
        {
            ArrayList no = new ArrayList()
            {
                35, 23, 90, 47, 12, 67, 27, 84, 50
            };
            no.Sort();
            Console.WriteLine("Example 3: Sorting");
            foreach (int item in no)
            {
                Console.WriteLine(item);
            }
        }

        static void Ex4_SearchingElements()
        {
            /* ArrayList Names = new ArrayList()
            {
                "Anand","Shyam","Dipesh","Dipak","Tanmay","Pranav"
            };
            Console.WriteLine("Searching Names"); */

            ArrayList names = new ArrayList();

            Console.WriteLine("=== Enter names to store in the list ===");


            while (true)
            {
                Console.Write("Enter a name (or type 'done' to finish): ");
                string name = Console.ReadLine();


                if (name.ToLower() == "done")
                    break;
                names.Add(name);

            }

            Console.WriteLine("Enter your name:");
            string Ename = Console.ReadLine();

            if(names.Contains(Ename))
            {
                Console.WriteLine($"{Ename} is in your list");

            }
            else
            {
                Console.WriteLine($"{Ename} not in your list");
            }
        }

        static void Ex5_CopyToArray()
        {
            ArrayList names = new ArrayList()
            {
                 "Anand","Shyam","Dipesh","Dipak","Tanmay","Pranav"
            };
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            string[] nameArray =new string[names.Count];
            {
                names.CopyTo(nameArray);
            }

            Console.WriteLine("Copying array example");
            foreach(string item in nameArray)
            {
                Console.WriteLine(item);
            }
            names.Clear();
            Console.WriteLine("Clear data");
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }


        }
        static void Main(string[] args)
        {
           // Ex1_StoreDifferentDataTypes();
           // Ex2_RemoveDifferentDataType();
           // Ex3_SortingItems();
           // Ex4_SearchingElements(); 
           Ex5_CopyToArray();
           

            Console.ReadLine();
        }
    }
}
