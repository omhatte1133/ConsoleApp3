using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Create_Car
    {
        string Make;
        string Model;
        string Color;
        int Year;
        int Speed = 30;

        public void acceleration(int amount)
        {
            Speed = Speed + amount;
            Console.WriteLine($"After the acceleration the speed is {Speed}");
        }

        public void brake(int amount)
        {
            Speed = Speed - amount;
        }

        public void SetCarInfo(String Make, String Model, String Colour, int Year)
        {
            this.Make = Make;
            this.Model = Model;
            this.Color = Colour;
            this.Year = Year;

        }

        public void GetCarInfo()
        {
            Console.WriteLine($"Manufacturer is {Make}");
            Console.WriteLine($"Model is {Model}");
            Console.WriteLine($"Color of car is {Color}");
            Console.WriteLine($"Manufacturer date is {Year}");
        }


        public static void Main(String[] args)
        {
            int amount;
            Create_Car c1 = new Create_Car();

            Console.WriteLine("Enter Manufacturer of a Car:- ");
            String Make = Console.ReadLine();

            Console.WriteLine("Enter the Model of a Car:- ");
            String Model = Console.ReadLine();

            Console.WriteLine("Enter the color of a Car:- ");
            String Colour = Console.ReadLine();

            Console.WriteLine("Manufacturer date of a Car:- ");
            int Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an amount speed of a car on which you want to accelerate or brake:- ");
            amount = int.Parse(Console.ReadLine());

            c1.SetCarInfo(Make, Model, Colour, Year);

            c1.GetCarInfo();
            c1.acceleration(amount);

            Console.ReadLine();

        }
    }
}
