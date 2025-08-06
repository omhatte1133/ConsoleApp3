using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Constructor1
    {
        string Name;
        int EmpId;
        int Age;
        string City;
        public Constructor1() 
        {
            Console.WriteLine("Default Constructor");        
        }
        public Constructor1(string Name, int EmpId, int Age, string City)
        {
            this .Name = Name;
            this .EmpId = EmpId;   
            this .Age = Age;
            this .City = City;
        }
        
        public void getDetails()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"EmpId : {EmpId}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"City : {City}");
        }
        static void Main(string[] args)
        {
            Constructor1 s1 = new Constructor1();

            Constructor1 s2 = new Constructor1("Anand",101,30,"Pune");
            Constructor1 s3 = new Constructor1("Sham", 102, 22, "Pune");
            Constructor1 s4 = new Constructor1("Om", 103, 22, "Pune");
            s2 .getDetails();
            s3 .getDetails();
            s4 .getDetails();

            Console.ReadLine();
        }
    }
}
