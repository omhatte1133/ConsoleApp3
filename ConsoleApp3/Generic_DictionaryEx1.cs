using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Generic_DictionaryEx1
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> stu = new Dictionary<int,string>();
            stu.Add(101, "OM");
            stu.Add(102, "Pranav");
            stu.Add(103, "Vishal");

           foreach(KeyValuePair<int,string> students in stu)
           {
               Console.WriteLine("Id is " + students.Key + ", name is " + students.Value);
           }

            Console.WriteLine("Student with id 102 " + stu[102]);

            Console.WriteLine("\n Total Students' " + stu.Count);
            Console.WriteLine("\n");

            stu.Remove(103);

            foreach (KeyValuePair<int, string> students in stu)
            {
                Console.WriteLine("Id is " + students.Key + ", name is " + students.Value);
            }

            Console.WriteLine("\n Total Students' " + stu.Count);

            Console.ReadLine();
        }
    }
}
