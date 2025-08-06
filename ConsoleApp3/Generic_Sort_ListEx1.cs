using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Generic_Sort_ListEx1
    {
        static void Main(string[] args)
        {
            SortedList<int, string> stu = new SortedList<int, string>();
            stu.Add(130, "Om");
            stu.Add(110, "Pranav");
            stu.Add(120, "Tanmay");

            Console.WriteLine("Sorted Output:");
            foreach (KeyValuePair<int, string> student in stu)
            {
                Console.WriteLine("Id is" + student.Key + " , Name is " + student.Value);
            }

            SortedList<string, string> student1 = new SortedList<string, string>();
            student1.Add("UK", "Pranav");
            student1.Add("IND", "Om");
            student1.Add("SA", "Vishal");

            Console.WriteLine("Sorted Output:");
            foreach (KeyValuePair<string, string> stud in student1)
            {
                Console.WriteLine("Id is" + stud.Key + " , Name is " + stud.Value);
            }


            Console.ReadLine();
        }
    }
}
