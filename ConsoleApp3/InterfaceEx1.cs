using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IPayment
    {
        void Pay(string from, string to, double amount);
        void SendReceipt(string from, double amount);
        void LogPayment(string method, string status, DateTime time);

    }

    class CreditCard1 : IPayment
    {
        public void Pay(string from, string to, double amount)
        {
            Console.WriteLine($"Credit card {from} paid rs.{amount} to {to}");

        }
        public void SendReceipt(string from, double amount)
        {
            Console.WriteLine($"Sending receipt {from} for rs. {amount}");
        }
        public void LogPayment(string method, string status, DateTime time)
        {
            Console.WriteLine($"Log - {method} Status: {status} Time - {time}");
        }

    }

    class UPI : IPayment
    {
        public void Pay(string from, string to, double amount)
        {
            Console.WriteLine($"UPI {from} paid rs.{amount} to {to}");

        }
        public void SendReceipt(string from, double amount)
        {
            Console.WriteLine($"Sending receipt {from} for rs. {amount}");
        }
        public void LogPayment(string method, string status, DateTime time)
        {
            Console.WriteLine($"Log - {method} Status: {status} Time - {time}");
        }

    }

    class Cash : IPayment
    {
        public void Pay(string from, string to, double amount)
        {
            Console.WriteLine($"Cash {from} paid rs.{amount} to {to}");

        }
        public void SendReceipt(string from, double amount)
        {
            Console.WriteLine($"Sending receipt {from} for rs. {amount}");
        }
        public void LogPayment(string method, string status, DateTime time)
        {
            Console.WriteLine($"Log - {method} Status: {status} Time - {time}");
        }

    }



    class InterfaceEx1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------Credit Card--------------------");
            IPayment pay1 = new CreditCard1();
            pay1.Pay("Om","Tanmay",10000);
            pay1.SendReceipt("Om", 10000);
            pay1.LogPayment("CreditCard","Success",DateTime.Now);

            Console.WriteLine("------------------UPI-----------------");
            IPayment pay2 = new UPI();
            pay2.Pay("Om", "Tanmay", 10000);
            pay2.SendReceipt("Om", 10000);
            pay2.LogPayment("CreditCard", "Success", DateTime.Now);

            Console.WriteLine("-----------------Cash-------------------");
            IPayment pay3 = new Cash();
            pay3.Pay("Om", "Tanmay", 10000);
            pay3.SendReceipt("Om", 10000);
            pay3.LogPayment("CreditCard", "Success", DateTime.Now);

            Console.ReadLine();
        }
    }
}
