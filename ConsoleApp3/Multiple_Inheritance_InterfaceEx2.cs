using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IPhone
    {
        void MakeCall(string num, int duration);
        void SendSMS(string msg);
    }
    public interface ICamera
    {
        void TakePhoto(string mode, float resolution);
        void RecordVideo(string video);
    }

    class SmartDevice : IPhone, ICamera
    {
        public void MakeCall(string num, int duration)
        {
            Console.WriteLine($"My smart device number is {num} and calling time is {duration} seconds");
        }
        public void SendSMS(string msg)
        {
            Console.WriteLine($"In my calling in main message is {msg}");
        }
        public void TakePhoto(string mode, float resolution)
        {
            Console.WriteLine($"My smart device camera mode is {mode} and duration time is {resolution} hour");
        }
        public void RecordVideo(string video)
        {
            Console.WriteLine($"In my camera video using for {video}");
        }
    }
    internal class Multiple_Inheritance_InterfaceEx2
    {

        static void Main(string[] args)
        {
            SmartDevice s1 = new SmartDevice();
            s1.MakeCall("IP5957", 300);
            s1.SendSMS("Congratulation");
            s1.TakePhoto("High Definition", 7.5f);
            s1.RecordVideo("Wedding");
            Console.ReadLine();
        }
    }
}
