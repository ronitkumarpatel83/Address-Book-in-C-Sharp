using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Record records = new Record(); // Creating object record class
            while (true)
            {
                Console.WriteLine("<<<<<<<<<<<<<<<<< ADDRESS BOOK >>>>>>>>>>>>>>>>>>");
                Console.WriteLine("\nWelcome to Address Book System");
                Console.WriteLine("1. Add a new Record");
                Console.WriteLine("2. Update a Record");
                Console.WriteLine("3. Delete");
                Console.WriteLine("Press 0 for Exit");
                Console.WriteLine("<<<<<<<<<<<<<<<<< ADDRESS BOOK >>>>>>>>>>>>>>>>>>");
                Console.WriteLine("\nEnter your choice : ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)   // 
                {
                    case 1:
                        records.AddRecord();
                        records.print();
                        break;
                    case 2:
                        Console.WriteLine("Enter your First Name : ");
                        string name = Console.ReadLine();
                        records.UpdateRecords(name);
                        records.print();
                        break;
                    case 3:
                        Console.WriteLine("Enter your first name to delete the record : ");
                        string fn = Console.ReadLine();
                        records.Delete(fn);
                        records.print();
                        break;
                    case 0:
                        System.Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
