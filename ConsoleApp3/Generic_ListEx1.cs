using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Generic_ListEx1
    {
        static void Main(string[] args)
        {
            List<string> Studentlist = new List<string>();
            Studentlist.Add("Anand");
            Studentlist.Add("Shyam");
            Studentlist.Add("Shital");
            Studentlist.Add("Om");

            Studentlist.AddRange(new List<string> { "Deepesh", "Pranav" });

            Console.WriteLine("All Students");
            foreach (string student in Studentlist)
            {
                Console.WriteLine(student);
            }

            Studentlist.Insert(2, "Vishal");
            Studentlist.Remove("Shital");
            Studentlist.RemoveAt(0);
            Console.WriteLine("All Students");
            foreach (string student in Studentlist)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n Contains 'Pranav' " + Studentlist.Contains("Pranav"));
            Console.WriteLine("\n Total Students' " + Studentlist.Count);

            int index = Studentlist.IndexOf("Om");
            Console.WriteLine("Index of Om" + index);

            Studentlist.Sort();

            Console.WriteLine("Sorted All Students");
            foreach (string student in Studentlist)
            {
                Console.WriteLine(student);
            }

            Studentlist.Reverse();

            Console.WriteLine("Sorted All Students");
            foreach (string student in Studentlist)
            {
                Console.WriteLine(student);
            }

            Studentlist.Clear();
            Console.WriteLine("Total Students: " + Studentlist.Count);
            Console.ReadLine();
        }
    }
}
