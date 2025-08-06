using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Hash_TableEx4
    {
        static void Adddata(Hashtable hash)
        {
            try
            {
                Console.WriteLine("Enter student Id(KEY)");
                int id = Convert.ToInt32(Console.ReadLine());

                if (hash.ContainsKey(id))
                {
                    Console.WriteLine("Student Id is Already exist");
                }
                else
                {
                    Console.WriteLine("Enter Student Name: ");
                    string newname = Console.ReadLine();

                    Console.WriteLine("Enter Marks");
                    int mark = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Subject");
                    string sub = Console.ReadLine();

                    hash.Add(id, newname);
                    hash.Add(mark, sub);
                    Console.WriteLine("Student Name Add Successfully");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Id, Id must be in numeric form");
            }

        }

        static void Updatedata(Hashtable hash)
        {
            try
            {
                Console.WriteLine("Enter Student Id(KEY) to update");
                int id = Convert.ToInt32(Console.ReadLine());

                if (hash.ContainsKey(id))
                {
                    Console.WriteLine("Student is is Available you can update it");
                    Console.WriteLine("Update Student Details");
                    string Uname = Console.ReadLine();

                    Console.WriteLine("Update Marks");
                    int mark = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Subject");
                    string sub = Console.ReadLine();


                    hash[id] = Uname;
                    hash[id] = mark;
                    hash[id] = sub;

                }
                else
                {
                    Console.WriteLine("Student Id(KEY) Not Found");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Id, Id must be in numeric form");
            }
        }

        static void DeleteData(Hashtable hash)
        {
            try
            {
                Console.WriteLine("Enter Student Id(KEY) to Delete");
                int id = Convert.ToInt32(Console.ReadLine());

                if (hash.ContainsKey(id))
                {
                    hash.Remove(id);
                    Console.WriteLine("Student details removed successfully");
                }
                else
                {
                    Console.WriteLine("Student Id(KEY) is not found");
                }

            }
            catch
            {
                Console.WriteLine("Invalid Id, Id must be in numeric form");
            }
        }

        static void Searchdata(Hashtable hash)
        {
            try
            {
                Console.WriteLine("Enter a Student Id(KEY) for Search");
                int id = Convert.ToInt32(Console.ReadLine());

                if (hash.ContainsKey(id))
                {
                    Console.WriteLine($"Student Id found {id} and name is{hash[id]}");
                    Console.WriteLine("Student Id Searched Successfully");
                }
                else
                {
                    Console.WriteLine("Student Id(KEY) not found");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Id, Id must be in numeric form");
            }
        }

        static void Displaydata(Hashtable hash)
        {
            if (hash.Count == 0)
            {
                Console.WriteLine("Student Data is not available");
            }
            else
            {
                Console.WriteLine("Student Details");
                foreach (DictionaryEntry item in hash)
                {
                    Console.WriteLine($"Student id {item.Key} Name is {item.Value} Student Marks id {item.Key} Subjects is {item.Value}");

                }
                Console.WriteLine($"Total Student: {hash.Count}");
            }
        }


        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();

            while (true)
            {
                Console.WriteLine("=======Student Details=======");
                Console.WriteLine("1 Add Student Details");
                Console.WriteLine("2 Update Student Details");
                Console.WriteLine("3 Delete Student Details");
                Console.WriteLine("4 Search Student Details");
                Console.WriteLine("5 Display Student Details");
                Console.WriteLine("6 Clear Student Details");
                Console.WriteLine("0 Exit");

                Console.WriteLine("Enter your Choice");
                int ch = 0;

                try
                {
                    ch= Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid data");
                }

                switch (ch)
                {
                    case 0: Console.WriteLine("Exit Successfully"); return;
                    case 1: Adddata(hash); break;
                    case 2: Updatedata(hash); break;
                    case 3: DeleteData(hash); break;
                    case 4: Searchdata(hash); break;
                    case 5: Displaydata(hash); break;
                    case 6:
                        hash.Clear();
                        Console.WriteLine("All products cleared");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }
    }
}
