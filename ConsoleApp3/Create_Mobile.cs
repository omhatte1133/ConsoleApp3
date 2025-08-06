using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Create_Mobile
    {
        string M_Type;
        string M_Name;
        string M_Ram;
        string M_Rom;
        string M_Color;
        int M_Size;
        int M_Prize;

        public void SetMobile(string M_Type, string M_Name, string M_Ram, string M_Rom, string M_Color, int M_Size, int M_Prize)
        {
            this.M_Type = M_Type;
            this.M_Name = M_Name;
            this.M_Ram = M_Ram;
            this.M_Rom = M_Rom;
            this.M_Color = M_Color;
            this.M_Size = M_Size;
            this.M_Prize = M_Prize;
        }

        public void Get_Mobile()
        {
            Console.WriteLine($"Your Mobile Type is :{M_Type}");
            Console.WriteLine($"Your Mobile Name is :{M_Name}");
            Console.WriteLine($"Your Mobile Ram is :{M_Ram}");
            Console.WriteLine($"Your Mobile Rom is :{M_Rom}");
            Console.WriteLine($"Your Mobile Color is :{M_Color}");
            Console.WriteLine($"Your Mobile Size is :{M_Size}");
            Console.WriteLine($"Your Mobile Prize is :{M_Prize}");
            Console.WriteLine($"------------------------------------------------------");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many Mobile you want enter?");
            int NoMobile = int.Parse(Console.ReadLine());

            Create_Mobile[] Mobile = new Create_Mobile[NoMobile];

            for (int i = 0; i < Mobile.Length; i++)
            {
                Console.WriteLine($"Enter Details of Mobiles : {i + 1}");

                Console.WriteLine("Enter your mobile Type(Android/IOS):");
                string M_Type = Console.ReadLine();

                Console.WriteLine("Enter your mobile Name:");
                string M_Name = Console.ReadLine();

                Console.WriteLine("Enter your mobile Ram(GB):");
                string M_Ram = Console.ReadLine();

                Console.WriteLine("Enter your mobile Rom(GB):");
                string M_Rom = Console.ReadLine();

                Console.WriteLine("Enter your mobile Color:");
                string M_Color = Console.ReadLine();

                Console.WriteLine("Enter your mobile Size:");
                int M_Size = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your mobile Prize(₹):");
                int M_Prize = int.Parse(Console.ReadLine());

                Mobile[i] = new Create_Mobile();
                Mobile[i].SetMobile(M_Type, M_Name, M_Ram, M_Rom, M_Color, M_Size, M_Prize);
            }

            Console.WriteLine($"\n------------------------------------------------------");
            Console.WriteLine("Mobile Record");
            for (int i = 0; i < Mobile.Length; i++)
            {
                Console.WriteLine($"Enter Details of Mobile : {i + 1}");
                Mobile[i].Get_Mobile();
            }
            Console.ReadLine();
        }

    }
}
