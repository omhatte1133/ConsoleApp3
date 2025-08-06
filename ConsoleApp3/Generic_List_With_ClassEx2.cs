using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee101
    {
        public string name;
        public int age;
        public string designation;
    }
    internal class Generic_List_With_ClassEx2
    {
        static void Main(string[] args)
        {
            Employee101 emp1 = new Employee101()
            {
                name = "Anand",
                age = 32,
                designation = "Manager"
            };

            Employee101 emp2 = new Employee101()
            {
                name = "Shyam",
                age = 22,
                designation = "Developer"
            };

            Employee101 emp3 = new Employee101()
            {
                name = "Om",
                age = 23,
                designation = "Tester"
            };


            Employee101 emp4 = new Employee101()
            {
                name = "Deepesh",
                age = 40,
                designation = "Senior Developer"
            };

            Employee101 emp5 = new Employee101()
            {
                name = "Pranav",
                age = 45,
                designation = "Team Leader"
            };

            List<Employee101> Emplist = new List<Employee101>();
            Emplist.Add(emp1);
            Emplist.Add(emp2);
            Emplist.Add(emp3);
            Emplist.Add(emp4);
            Emplist.Add(emp5);

            Console.WriteLine("Employee List");
            foreach (Employee101 emp in Emplist)
            {
                Console.WriteLine($"Employee name is {emp.name}, age is {emp.age}, his designation is {emp.designation}");
            }
        }
    }
}
