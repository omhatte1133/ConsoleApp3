using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    public class Employee11
    {
         public string name;
         public int age;
         public string designation;
    }
    internal class Generic_ListEx3
    {
        static void Main(string[] args)
        {
            Stack<Employee11> stack = new Stack<Employee11>();

            Console.WriteLine("How many employees do you want to enter: ");
            int no = int.Parse(Console.ReadLine());

            for (int i = 0; i < no; i++)
            {
                Console.WriteLine($"Enter details for employees {i}");

                Employee11 emp1 = new Employee11();

                Console.WriteLine("Enter name:");
                emp1.name = Console.ReadLine();

                Console.WriteLine("Enter your age:");
                emp1.age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your designation:");
                emp1.designation = Console.ReadLine();

                stack.Push(emp1);
            }
            Console.WriteLine("\n===== Employee Details =====\n");

            foreach(var emp in stack)
            {
                Console.WriteLine($"Employee name is {emp.name}, age is {emp.age}, his designation is {emp.designation}");
            }

        }
    }
}
