using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class BankAcc
    {
        private string accountholder;
        public double balance;
        private double initialbalance;
        public string name;
        public int accountno;

        public BankAcc(double initialbalance)
        {

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter account number:");
            int accountno = int .Parse(Console.ReadLine());


            this.balance = initialbalance;
            this.initialbalance += initialbalance;
        }
        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                this.balance = balance + amount;
                Console.WriteLine("Amount Deposit Rs : " + amount);
            }
            
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                this.balance = balance - amount;
                Console.WriteLine("Amount Withdraw Rs : " + amount);
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        public void balanceshow()
        {
            Console.WriteLine("Account Summery");
            Console.WriteLine("Acc Holder Name: " + name);
            Console.WriteLine("Initial Balance: " + initialbalance);
            Console.WriteLine("Total Balance: " + balance);
        }
    }
    
   
    internal class EncapsulationEx1
    {
        static void Main(string[] args)
        {
            BankAcc acc = new BankAcc(10000);
            acc.Deposit(5000);
            acc.Withdraw(1000);
            acc.balanceshow();
            Console.ReadLine();
        }
    }
}
