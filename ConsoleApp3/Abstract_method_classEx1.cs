using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Emp
    {
        public int EmpID;
        public string EmpName;
        public decimal Salary;

        public abstract void CalculateBonus();

        public void Display()
        {
            Console.WriteLine($"EMP ID: {EmpID}");
            Console.WriteLine($"EMP Name: {EmpName}");
            Console.WriteLine($"EMP Salary: {Salary}");
        }
    }

    class Developer : Emp
    {
        public int Projects;
        public decimal BonusPerProject;

        public override void CalculateBonus()
        {
            decimal bonus = Projects * BonusPerProject;
            Console.WriteLine($"Developer Bonus: {bonus}"); 
        }
    }

    class Manager : Emp 
    {
        public decimal BonusPercentage;

        public override void CalculateBonus()
        {
            decimal bonus = Salary * BonusPercentage/100;
            Console.WriteLine($"Manager Bonus {bonus}");
        }
    }
    class Abstract_method_classEx1
    {
        static void Main(string[] args)
        {
            Emp dev = new Developer()
            {
                EmpID = 101,
                EmpName = "Anand",
                Salary = 30000,
                Projects = 5,
                BonusPerProject = 1000,
            };
            dev.Display();
            dev.CalculateBonus();
            
            Console.WriteLine("-----------------------");
            Manager man = new Manager()
            {
                EmpID = 101,
                EmpName = "Anand",
                Salary = 30000,
                BonusPercentage = 10,
            };
            man.Display();
            man.CalculateBonus();

            Console.ReadLine();
        }
    }
}
