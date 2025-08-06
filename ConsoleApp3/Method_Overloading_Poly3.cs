using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Method_Overloading_Poly3
    {
        public void payment(string Pname, int no, int cvv, int ammount)
        {
            Console.WriteLine($"My payment type is {Pname}, it card number is {no}, it cvv number is {cvv} and pay value is {ammount}");
        }

        public void payment(string Pname, int no, string period, int ammount)
        {
            Console.WriteLine($"My payment type is {Pname}, it card number is {no}, it card period {period} and pay value is {ammount}");
        }

        public void payment(string Pname, string user, int pass, int ammount)
        {
            Console.WriteLine($"My payment type is {Pname}, my upi id is {user}, their password is {pass} and pay value is{ammount}");
        }
        static void Main(string[] args)
        {
            Method_Overloading_Poly3 m1 = new Method_Overloading_Poly3();
            m1.payment("Debit Card", 663890, 197,300);
            m1.payment("Credit Card", 987456,"6 Months",3000);
            m1.payment("Phone Pay", "59498504@id",967804,30000);

            Console.ReadLine();
        }
    }
}
