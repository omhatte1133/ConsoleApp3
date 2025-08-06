using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface Printer
    {
        void Process(int page, string pdf);
        void End(string type);
       
    }

    class InkPrinter : Printer
    {
        public void Process(int page, string pdf)
        {
            Console.WriteLine($"[InkPrinter] Printing {page} pages of {pdf}");
        }
        public void End(string type)
        {
            Console.WriteLine($"[InkPrinter] scanning {type} to pdf format");
        }
    }

    class LaserPrinter : Printer
    {
        public void Process(int page, string pdf)
        {
            Console.WriteLine($"[LaserPrinter] Printing {page} pages of {pdf}");
        }
        public void End(string type)
        {
            Console.WriteLine($"[LaserPrinter] scanning {type} to pdf format");
        }
    }

    class MatrixPrinter : Printer
    {
        public void Process(int page, string pdf)
        {
            Console.WriteLine($"[MatrixPrinter] Printing {page} pages of {pdf}");
        }
        public void End(string type)
        {
            Console.WriteLine($"[MatrixPrinter] scanning {type} to pdf format");
        }
    }
    internal class InterfaceEx2
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("====== Ink Printer ======");
            Printer p1 = new InkPrinter();
            p1.Process(8, "Report.pdf");
            p1.End("ID_Card.jpg");

            Console.WriteLine("====== Laser Printer ======");
            Printer p2 = new LaserPrinter();
            p2.Process(8, "Report.pdf");
            p2.End("ID_Card.jpg");

            Console.WriteLine("====== Matrix Printer ======");
            Printer p3 = new MatrixPrinter();
            p3.Process(8, "Report.pdf");
            p3.End("ID_Card.jpg");

            Console.ReadLine();
        }
    }
}
