using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Account
    {
        public void open()
        {
            Console.WriteLine("You can open bank account");
        }
    }

    class BankAccount : Account
    {
        public void Deposite()
        {
            Console.WriteLine("Account is open");
        }
    }

    class SavingAccount : BankAccount
    {
        public void AddInterest()
        {
            Console.WriteLine("Interest added to SavingAccount");
        }
    }

    class CurrentAccount : BankAccount
    {
        public void OverDraft()
        {
            Console.WriteLine("Overdraft is available in CurrentAccount");
        }
    }
    internal class Hybrid_InheritanceEx1
    {
        static void Main(string[] args)
        {
            SavingAccount a = new SavingAccount();
            a.AddInterest();
            a.Deposite();
            a.open();

            CurrentAccount c = new CurrentAccount();
            c.OverDraft();
            c.Deposite();
            c.open();

            Console.ReadLine();
        }
    }
}
