using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Payment_InheritanceTask
    {
        class Card
        {
            string cardNum;
            string expDate;
            int cvv;
            int amount;

            public void SetCardDetails()
            {
                Console.Write("Enter Card Number: ");
                cardNum = Console.ReadLine();

                Console.Write("Enter Expiry Date (MM/YY): ");
                expDate = Console.ReadLine();

                Console.Write("Enter CVV Number: ");
                cvv = int.Parse(Console.ReadLine());

                Console.Write("Enter Amount: ");
                amount = int.Parse(Console.ReadLine());
            }

            public void GetCardDetails()
            {
                Console.WriteLine($"\nPayment of {amount} made using Card  {cardNum} ending with {expDate}");
                Console.WriteLine("Thank you for using the Payment Gateway");

            }
        }

        class UPI
        {
            string upiID;
            int amount;

            public void SetUPIDetails()
            {
                Console.Write("Enter UPI ID: ");
                upiID = Console.ReadLine();

                Console.Write("Enter Amount: ");
                amount = int.Parse(Console.ReadLine());
            }

            public void GetUPIDetails()
            {
                Console.WriteLine($"\nPayment of {amount} made via UPI ID:{upiID}");
                Console.WriteLine("Thank you for using the Payment Gateway");
            }
        }
        class Wallet
        {
            int balance;
            int discount;
            int beforeDiscount;
            int afterDiscount;

            public void SetWalletDetails()
            {
                Console.Write("Enter Wallet Balance: ");
                balance = int.Parse(Console.ReadLine());

                Console.Write("Enter Discount: ");
                discount = int.Parse(Console.ReadLine());

                beforeDiscount = (balance * discount) / 100;

                afterDiscount = beforeDiscount - discount;

                Console.Write($"Amount to pay: {afterDiscount}");


            }

            public void GetWalletDetails()
            {
                Console.WriteLine($"\nPayment of {afterDiscount} made using ({discount} applied).");
                Console.WriteLine("Thank you for using the Payment Gateway");

            }
        }

        static void Main(string[] args)
        {
            string yno = "y";
            while (yno == "y")
            {
                Console.WriteLine("\nSelect Payment Method: ");
                Console.WriteLine("1. Card");
                Console.WriteLine("2. UPI");
                Console.WriteLine("3. Wallet");
                Console.Write("Enter Your Choice (1-3): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Card cd = new Card();
                        cd.SetCardDetails();
                        cd.GetCardDetails();
                        break;

                    case 2:
                        UPI upi = new UPI();
                        upi.SetUPIDetails();
                        upi.GetUPIDetails();
                        break;

                    case 3:
                        Wallet wl = new Wallet();
                        wl.SetWalletDetails();
                        wl.GetWalletDetails();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice Number");
                        break;
                }

                Console.Write("\nDo you want to really continue (y/n): ");
                yno = Console.ReadLine();
            }

        }

    }
}
