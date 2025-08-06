using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Device1
    {
        public virtual void TurnOn(string user, string time, string mode)
        {
            Console.WriteLine($"Starting generic device for {user} at {time} in {mode}");
        }
    }
    class TV : Device1 
    {
        public override void TurnOn(string user, string time, string mode)
        {
            Console.WriteLine($"TV is starting for {user} at {time} in {mode}");
        }
    }

    class AC : Device1
    {
        public override void TurnOn(string user, string time, string mode)
        {
            Console.WriteLine($"AC is starting for {user} at {time} in {mode}");
        }
    }

    class MusicSystem : Device1
    {
        public override void TurnOn(string user, string time, string mode)
        {
            Console.WriteLine($"MusicSystem is starting for {user}, at{time} in {mode}");
        }
    }
    internal class Method_OverridingEx1
    {
        static void Main(string[] args)
        {
            Device1 d = new TV();
            d.TurnOn("WithKadi", "08:00PM", "IPL"); 
            Device1 d1 = new AC();
            d1.TurnOn("InSummer", "11:00AM", "Hall");
            Device1 d2 = new MusicSystem();
            d.TurnOn("Ganpati", "07:00PM", "InHome");

            Console.ReadLine();
        }
    }
}
