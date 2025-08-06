using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Array_Class_Object
    {
        int RollNo;
        string name;
        int age;
        string classname;

        public void SetStudent(int RollNo, string name, int age, string classname)
        {
            this.RollNo = RollNo;
            this.name = name;
            this.age = age;
            this.classname = classname;

        }
        public void GetStudent()
        {
            Console.WriteLine($"Your Roll Num is: {RollNo}");
            Console.WriteLine($"Your Name is: {name}");
            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine($"Your class is: {classname}");
            Console.WriteLine($"------------------------------------------------------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many Students you want enter?");
            int numstudent = int .Parse( Console.ReadLine() );

            Array_Class_Object[] students = new Array_Class_Object[numstudent];

            for (int i = 0; i < students.Length; i++) 
            {
                Console.WriteLine($"Enter Details of Students: {i + 1}");

                Console.WriteLine("Enter Your RollNo:");
                int RollNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your Name:");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter Your Age:");
                int Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your ClassName:");
                string ClassName = Console.ReadLine();

                students[i] = new Array_Class_Object();
                students[i].SetStudent(RollNo, Name, Age, ClassName);
            }

            Console.WriteLine("Students Record");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter Details of Students: {i + 1}");
                students[i].GetStudent();
            }


            Console.ReadLine();
        }
    }
}
