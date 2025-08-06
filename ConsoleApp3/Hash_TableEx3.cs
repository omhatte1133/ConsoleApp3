
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Hash_TableEx3
    {
        static void AddStudent(Hashtable ht)
        {
            try
            {
                Console.WriteLine("Enter Student ID:");
                int id = int.Parse(Console.ReadLine());

                if(ht.ContainsKey(id))
                {
                    Console.WriteLine("Student id already exist");
                }
                else
                {
                    Console.WriteLine("Enter student name:");
                    string name = Console.ReadLine();
                    ht.Add(id, name);
                    Console.WriteLine("Student details added successfully");
                }
            }
            catch
            {
                Console.WriteLine("Invalid student id, Please enter id in number");
                
            }
        }

        static void DisplayStudent(Hashtable ht)
        {
            if (ht.Count == 0)
            {
                Console.WriteLine("Student id not available");
            }
            else
            {
                Console.WriteLine("Student List");
                foreach (DictionaryEntry item in ht)
                {
                    Console.WriteLine($"ID is {item.Key}, Student name is {item.Value}");
                }
                Console.WriteLine($"Total Students = {ht.Count}");
            } 
        }

        static void UpdateStudent(Hashtable ht)
        {
            try
            {
                Console.WriteLine("Enter Student ID(key) to Update");
                int id = int.Parse(Console.ReadLine());

                if (ht.ContainsKey(id))
                {
                    Console.WriteLine("Enter Student name:");
                    string sanme = Console.ReadLine();
                    ht[id] = sanme;
                    Console.WriteLine("Student ID Updated Successfully");
                }
                else
                {
                    Console.WriteLine("Student ID is not found");
                }
            }

            catch
            {
                Console.WriteLine("Invalid student id, Please enter id in number");
            }
        }

        static void DeleteStudent(Hashtable ht)
        {
            try
            {
                Console.WriteLine("Enter Student Id(key) to Update");
                int id = int.Parse(Console.ReadLine());
                if (ht.ContainsKey(id))
                {
                    ht.Remove(id);
                    Console.WriteLine("Student Removed Successfully");
                }
                else
                {
                    Console.WriteLine("Student ID is not found");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input, Enter Valid Number");
            }
        }


        static void SearchStudent(Hashtable ht)
        {
            try
            {
                Console.WriteLine("Enter Student ID to Search");
                int id = int.Parse(Console.ReadLine());
                if(ht.ContainsKey(id))
                {
                    Console.WriteLine($"Student Count : {id}, and name is {ht[id]}");
                    Console.WriteLine("Student Search Successfully");
                }
                else
                {
                    Console.WriteLine("Student id is not found");
                }

            }
            catch
            {
                Console.WriteLine("Invalid Input, Enter Valid Number");
            }
        }
        static void Main(string[] args)
        {
            Hashtable student = new Hashtable();
            while (true)
            {
                Console.WriteLine("------------Student List--------------");
                Console.WriteLine("1.Add Student Details");
                Console.WriteLine("2.Update Student Details ");
                Console.WriteLine("3.Search Student Details"); 
                Console.WriteLine("4.Delete Student Details");
                Console.WriteLine("5.Display Student Details");
                Console.WriteLine("6.Clear All Students List");

                Console.WriteLine("Enter Your Choice");
                int choice = 0;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input, Enter Valid Number");
                }

                switch (choice)
                {
                    case 1:
                        AddStudent(student);
                        break;
                    case 2:
                        UpdateStudent(student);
                        break;
                    case 3:
                        SearchStudent(student);
                        break;
                    case 4:
                        DeleteStudent(student);
                        break;
                    case 5:
                        DisplayStudent(student);
                        break;
                    case 6:
                        student.Clear();
                        Console.WriteLine("All Students are cleared");
                        break;

                    case 0:
                        Console.WriteLine("Existing");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
