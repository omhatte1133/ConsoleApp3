using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class StackEx2
    {
        static void AddFruit(Stack st)
        {
            try
            {
               
                Console.WriteLine("Enter Fruits Name:");
                string name = Console.ReadLine();

                if (st.Contains(name))
                {

                    Console.WriteLine("Fruits name already exist");
                }
                else
                {
                    st.Push(name);
                    Console.WriteLine($"{name} details added successfully");
                }

                
            }
            catch
            {
                Console.WriteLine("Invalid student name, Please enter name in string");

            }
        }
        static void DisplayFruit(Stack st)
        {
            if (st.Count == 0)
            {
                Console.WriteLine("Product not available");
            }
            else
            {
                Console.WriteLine("Fruit List");
                foreach (DictionaryEntry item in st)
                {
                    Console.WriteLine($"ID is {item.Key}, Name is {item.Value}");
                }
                Console.WriteLine($"Total Products=cts {st.Count}");   //count
            }
        }

        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            Console.WriteLine("Current Stack");
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            while (true)
            {

                Console.WriteLine("Enter Your Choice");
                int choice = 0;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input, Enter Valid Number");
                }

                switch (choice)
                {
                    case 1:
                        AddFruit(myStack);
                        break;
                    case 2:
                        DisplayFruit(myStack);
                        break;
                   

                }
            }
        }
    }
}
