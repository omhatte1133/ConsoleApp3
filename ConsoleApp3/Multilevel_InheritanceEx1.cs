using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3
{
    class Device
    {
        public void Charge()
        {
            Console.WriteLine("Device is use providing power");
        }
    }

    class Phone : Device
    {
        public void Call()
        {
            Console.WriteLine("Phone is use for calling");
        }
    }

    class Smart : Phone
    { 
        public void Brows()
        {
            Console.WriteLine("Smart phone is use for browsing");
        }
    }

    
    internal class Multilevel_InheritanceEx1
    {
        static void Main(string[] args)
        {
            Smart s = new Smart();
            s.Charge();
            s.Call();
            s.Brows();

            

            Console.ReadLine();
        }
    }
}
