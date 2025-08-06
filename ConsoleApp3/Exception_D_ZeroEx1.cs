using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Exception_D_ZeroEx1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Division result is " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You can not divided by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();
        }
     }
}
