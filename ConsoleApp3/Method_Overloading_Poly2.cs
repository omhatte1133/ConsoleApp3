using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Method_Overloading_Poly2
    {
        //Father
        public void Person(string role, string chaildname)
        {
            Console.WriteLine($"As a {role}, I Guide to my child {chaildname}");
        }

        //Son
        public void Person(string role, int ParentsAge)
        {
            Console.WriteLine($"As a {role}, I respect and support my parent who is {ParentsAge}");
        }

        //Husband
        public void Person(string role, string spousename, int yearmarried)
        {
            Console.WriteLine($"As a {role}, I take care my spouse {spousename}, and celebrating {yearmarried} years of marriage");
        }
        //Teacher
        public void Person(string role, int age, int Numberofstudent)
        {
            Console.WriteLine($"As a {role}, My age is {age}, in my class {Numberofstudent} student present");
        }
        static void Main(string[] args)
        {
            Method_Overloading_Poly2 m1 = new Method_Overloading_Poly2();
            m1.Person("Father", "Avir");
            m1.Person("Son", 34);
            m1.Person("Husband", "ABC", 5);
            m1.Person("Teacher", 30, 12);
        }
    }
}
