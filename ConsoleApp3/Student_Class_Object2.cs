using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Student_Class_Object2
    {
        int RollNo;
        string Name;
        int Age;
        string ClassName;

        public void SetStudent(int RollNo, string Name, int Age, string ClassName)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Age = Age;
            this.ClassName = ClassName;
        }

        public void GetStudent()
        {
            Console.WriteLine($"Your Roll Num is: {RollNo}");
            Console.WriteLine($"Your Name is: {Name}");
            Console.WriteLine($"Your age is: {Age}");
            Console.WriteLine($"Your class is: {ClassName}");
        }

        static void Main(string[] args)
        {
            string confirm;
            do
            {
                Console.WriteLine("Enter Your RollNo:");
                int RollNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your Name:");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter Your Age:");
                int Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your ClassName:");
                string ClassName = Console.ReadLine();

                Student_Class_Object2 s2 = new Student_Class_Object2();
                s2.SetStudent(RollNo, Name, Age, ClassName);
                s2.GetStudent();

                Console.WriteLine("---------------------------------");
                Console.WriteLine("Do you want to really continue yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
            Console.WriteLine("Thank you");
            Console.ReadLine();
            
        }
    }
}
