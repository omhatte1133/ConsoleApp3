using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee
    {
        public string name;
        public int age;
        public double gross_Salary;
        double tax = 0.1;  //10%
        double netSalary;

        public Employee(string name, int age, double gross_Salary)
        {
            this.name = name;
            this.age = age;
            this.gross_Salary = gross_Salary;
        }

        void CalSalary()
        {
            if (gross_Salary > 30000)
            {
                netSalary = gross_Salary - (tax * gross_Salary);
                Console.WriteLine($"Your Net Salary {netSalary}");
            }
            else
            {
                Console.WriteLine($"Your Net Salary {gross_Salary}");
            }
        }

        public void ShowEmpDetails()
        {
            Console.WriteLine($"Emp Name : {name}");
            Console.WriteLine($"Emp Age : {age}");
            this.CalSalary();

        }
    }
    internal class Abstraction_SalaryEx1
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Anand", 34, 40000);
            e1.ShowEmpDetails();
            Employee e2 = new Employee("Om", 22, 20000);
            e2.ShowEmpDetails();
            Console.ReadLine();
        }
    }
}
