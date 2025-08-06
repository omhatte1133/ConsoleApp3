using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student_Class_Object
    {
        int Roll;
        string name;
        int age;
        string classname;

        public void SetStudent(int Roll, string name, int age, string classname)
        {
            this.Roll = Roll;
            this.name = name;
            this.age = age;
            this.classname = classname;

        }
        public void GetStudent()
        {
            Console.WriteLine($"Your Roll Num is: {Roll}");
            Console.WriteLine($"Your Name is: {name}");
            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine($"Your class is: {classname}");
        }

        static void Main(string[] args)
        {
            Student_Class_Object s1 = new Student_Class_Object();
            s1.SetStudent(1001, "Anand", 35, "ENTC");
            s1.GetStudent();

            Console.WriteLine("-------------------------");

            Student_Class_Object s2 = new Student_Class_Object();
            s2.SetStudent(1002, "Pranav", 26, "DOT");
            s2.GetStudent();
            Console.ReadLine();

        }
    }
}
