using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Bank_Account1
    {
        public string AccountHolder = "Om";
        //private double balance = 10000.00;
        protected string AccountType = "Savings";
        internal string Branch = "Main Branch";

        public void ShowAccountInfo()
        {
            Console.WriteLine("Account Info");
            Console.WriteLine($"Account Holder: {AccountHolder}");
            //Console.WriteLine($"Balance : {balance}");
            Console.WriteLine($"Branch : {Branch}");

        }
    }

        class savingAccount : Bank_Account1
        {
            public void DisplayDerivedInfo()
            {
                Console.WriteLine("Accessing from derived Class");
                Console.WriteLine($"Holder : {AccountHolder}");
                //Console.WriteLine($"Balance: {balance}");
                //Console.WriteLine($"Account Type : {AccountType}");
                Console.WriteLine($"Branch : {Branch}");
            }
        } 
    
    public class Bank_Account
    {
        static void Main(string[] args)
        {
            
            savingAccount account = new savingAccount();
            Console.WriteLine("Accessing Outside the Class");
            Console.WriteLine($"Holder : {account.AccountHolder}");
            //Console.WriteLine($"Balance : {account.balance}");
            //Console.WriteLine($"Account Type : {account.AccountType}");
            Console.WriteLine($"Branch : {account.Branch}");

            account.DisplayDerivedInfo();

            Console.ReadLine();
        }
    }
    
}
