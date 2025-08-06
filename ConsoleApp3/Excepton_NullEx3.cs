using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Excepton_NullEx3
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))

                {
                    Console.WriteLine("Error - Name cannot be empty");
                    name = null;
                }
                else
                {
                    Console.WriteLine("Hello " + name.ToLower());
                }
                    
            }
            catch (NullReferenceException ex) 
            {
                Console.WriteLine("Name is not null, please enter valid name" + ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
