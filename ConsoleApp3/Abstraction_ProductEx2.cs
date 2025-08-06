using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Product
    {
        public string Cname;
        public string Pname;
        public int Prize;
        public int Process;
        double Tax;  //10%
        double Total;

        public Product(string Cname, string Pname, int Prize)
        {
            this.Cname = Cname;
            this.Pname = Pname;
            this.Prize = Prize;
            
        }

        void CalPay()
        {
            Tax = 0.1 * Prize;
            Process = 30;
            Total = Tax + Process;

        }


        public void Display()
        {
            Console.WriteLine($"Customer Name: {Cname}");
            Console.WriteLine($"Product Name: {Pname}");
            Console.WriteLine($"Product Prize: {Prize}");
            this.CalPay();
        }
    }

    
    internal class Abstraction_ProductEx2
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Om","Camera",10000);
            p1.Display();

            Console.ReadLine();
        }
    }
}
