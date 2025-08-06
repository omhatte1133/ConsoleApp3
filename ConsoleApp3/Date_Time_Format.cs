using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Date_Time_Format
    {
        static void Main (string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("--------------Standard format Date and Time----------------");
            Console.WriteLine("Short Date (d): " + now.ToString("d"));
            Console.WriteLine("Long Date (D): " + now.ToString ("D"));
            Console.WriteLine("Short Time (t): " + now.ToString ("t"));
            Console.WriteLine("Long Time (T): " + now.ToString ("T"));
            Console.WriteLine("Full date short time (f): " + now.ToString("f"));
            Console.WriteLine("Full date long time (F): " + now.ToString("F"));
            Console.WriteLine("General Short (g):" + now.ToString("g"));
            Console.WriteLine("General Long (G):" + now.ToString("G"));
            Console.WriteLine("Day/Month (M): " + now.ToString("M"));
            Console.WriteLine("Year/Month (Y): " + now.ToString("Y"));
            Console.WriteLine("Round Trip (o): " + now.ToString("o"));
            Console.WriteLine("RFC1123 (r): " + now.ToString("r"));
            Console.WriteLine("Sortable (s): " + now.ToString("s"));
            Console.WriteLine("Universal Sortable (u): " + now.ToString("u"));

            Console.WriteLine("-------------Custome Format Specifires------------");

            Console.WriteLine($"Date-Month-Year (dd-MM-yyyy): {now:dd-MM-yyyy}");
            Console.WriteLine($"Abrivated Weekday: {now:ddd}");
            Console.WriteLine($"Full Weekday: {now:dddd}");
            Console.WriteLine($"Abrivated Month: {now:MMM}");
            Console.WriteLine($"Full Month: {now:MMMM}");
            Console.WriteLine($"24 hrs time (HH:mm:ss): {now:HH:mm:ss}");
            Console.WriteLine($"12 hrs time (hh:mm:tt): {now:hh:mm:ss tt}");
            Console.WriteLine($"Full Date/Time (yyyy-MM-dd): {now:yyyy:MM-dd}");

            Console.WriteLine("------------------- Single Format ---------------------");
            Console.WriteLine($"Year : {now.Year}");
            Console.WriteLine($"Month : {now.Month}");
            Console.WriteLine($"Day : {now.Day}");
            Console.WriteLine($"Day of Week : {now.DayOfWeek}");
            Console.WriteLine($"Hour : {now.Hour}");
            Console.WriteLine($"Minute : {now.Minute}");
            Console.WriteLine($"Second : {now.Second}");
            Console.WriteLine($"Time : {now.TimeOfDay}");
            Console.ReadLine();

        }
        
    }
}
