using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person
    {
        int id;
        string name;
        string address;
        int phone;

        public void SetPerson(int id, string name, string address, int phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public void GetPerson()
        {
            Console.WriteLine($"Your Sir id is: {id}");
            Console.WriteLine($"Your Sir name is: {name}");
            Console.WriteLine($"Your Sir address is: {address}");
            Console.WriteLine($"Your Sir phone num is: {phone}");
            Console.WriteLine($"----------------------------------------------");
        }
    }

    class Person1
    {
        int Sid;
        string Sname;
        string Saddress;
        int Sphone;

        public void SetPerson1(int Sid, string Sname, string Saddress, int Sphone)
        {
            this.Sid = Sid;
            this.Sname = Sname;
            this.Saddress = Saddress;
            this.Sphone = Sphone;
        }

        public void GetPerson1()
        {
            Console.WriteLine($"Your Student id is: {Sid}");
            Console.WriteLine($"Your Student name is: {Sname}");
            Console.WriteLine($"Your Student address is: {Saddress}");
            Console.WriteLine($"Your Student phone num is: {Sphone}");
            Console.WriteLine($"----------------------------------------------");
        }
    }

    class Student : Person
    { 
        string classroom;
        float marks;
        char grade;
        int fees;
        internal static readonly string Count;

        public void SetStudents(string classroom, float marks, char grade, int fees)
        {
            this.classroom = classroom;
            this.marks = marks;
            this.fees = fees;
            this.grade = grade;
        }

        public void GetStudents()
        {
            Console.WriteLine($"Your classroom is: {classroom}");
            Console.WriteLine($"Your marks are: {marks}");
            Console.WriteLine($"Your fees are: {fees}");
            Console.WriteLine($"Your grade is: {grade}");
        }

    }

    class staff : Person
    {
        string designation;
        int salary;

        public void SetStaff(string designation, int salary)
        { 
            this.designation = designation;
            this.salary = salary;
        }

        public void GetStaff()
        {
            Console.WriteLine($"Your Designation is: {designation}");
            Console.WriteLine($"Your Salary is: {salary}");
        }
    }

    class Teaching : Person1
    {
        string qualification;
        string subject;

        public void setTeaching(string qualification, string subject)
        {
            this.qualification = qualification;
            this.subject = subject;
        }

        public void getTeaching()
        {
            Console.WriteLine($"Your Qualification is: {qualification}");
            Console.WriteLine($"Your Course name is: {subject}");
        }
    }

    class Nonteaching : staff
    {
        string departmentname;
        string managerId;

        public void setNon(string departmentname, string managerId)
        {
            this.departmentname = departmentname;
            this.managerId = managerId;
        }

        public void getNon()
        {
            Console.WriteLine($"Your Departmentname is: {departmentname}");
            Console.WriteLine($"Your ManagerId is: {managerId}");
        }

    }

    internal class Person_InheritanceTask
    {
        static void Main(string[] args)
        {
            Nonteaching n = new Nonteaching();
            n.setNon("Fortune Cloud", "xyzid");
            n.getNon();
            n.SetStaff("IT professional Teacher", 25000);
            n.GetStaff();
            n.SetPerson(01,"Anand sir","Chikhali Pune",876072222);
            n.GetPerson();

            Teaching n1 = new Teaching();
            n1.setTeaching("BCA", "Dotnet FullStack");
            n1.getTeaching();
            n1.SetPerson1(02, "Om Hatte", "Chikhali Pune", 90525);
            n1.GetPerson1();

            Console.ReadLine();
        }
    }
}
