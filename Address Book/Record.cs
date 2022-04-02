using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Record
    {
        List<CreateContacts> records = new List<CreateContacts>();

        public void print()
        {
            int r = 1; ///  For counting record 
            foreach (var person in records.ToList())
            {
                Console.WriteLine("\n\nRecord - " + r);
                Console.WriteLine("First Name : " + person.firstName);
                Console.WriteLine("Middle Name : " + person.middleName);
                Console.WriteLine("Last Name : " + person.lastName);
                Console.WriteLine("Address : " + person.address);
                Console.WriteLine("City : " + person.city);
                Console.WriteLine("State : " + person.state);
                Console.WriteLine("Email : " + person.email);
                Console.WriteLine("Zip code : " + person.zip);
                Console.WriteLine("Phone Number : " + person.phoneNumber);
                r++;

            }
        }
        public void AddRecord()
        {
            //Adding all contact details
            CreateContacts contact = new CreateContacts();
            Console.WriteLine("Enter your First Name : ");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter your Middle Name :");
            contact.middleName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            contact.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            contact.email = Console.ReadLine();

            records.Add(contact);

        }
        public void UpdateRecords(string name)
        { 
            foreach (var record in records.ToList())  // For checking record
            {
                if (record.firstName == name )
                {
                    
                    Console.WriteLine("\n\nWhich field you want to update : ");
                    Console.WriteLine("\n1:First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Email\n7.Zip Code\n8.PhoneNumber\n9.Exit");
                    Console.WriteLine("Enter your Choice : ");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("\nEnter new first name : ");
                            string f = Console.ReadLine();
                            record.firstName = f;
                            Console.WriteLine("\nFirst Name Updated Successfully");
                            break;
                        case 2:
                            Console.WriteLine("\nEnter new middle name : ");
                            string m = Console.ReadLine();
                            record.middleName = m;
                            Console.WriteLine("\nMiddle Name Updated Successfully");
                            break;
                        case 3:
                            Console.WriteLine("\nEnter new last name : ");
                            string l = Console.ReadLine();
                            record.lastName = l;
                            Console.WriteLine("\nLast Name Updated Successfully");
                            break;
                        case 4:
                            Console.WriteLine("\nEnter new address : ");
                            string a = Console.ReadLine();
                            record.address = a;
                            Console.WriteLine("\nAddress Updated Successfully");
                            break;
                        case 5:
                            Console.WriteLine("\nEnter new city name : ");
                            string c = Console.ReadLine();
                            record.city = c;
                            Console.WriteLine("\nCity Name Updated Successfully");
                            break;
                        case 6:
                            Console.WriteLine("\nEnter new state : ");
                            string s = Console.ReadLine();
                            record.state = s;
                            Console.WriteLine("\nState Name Updated Successfully");
                            break;
                        case 7:
                            Console.WriteLine("\nEnter new email : ");
                            string e = Console.ReadLine();
                            record.email = e;
                            Console.WriteLine("\nEmail Updated Successfully");
                            break;
                        case 8:
                            Console.WriteLine("\nEnter new Zip Code : ");
                            int z = Convert.ToInt32(Console.ReadLine());
                            record.zip = z;
                            Console.WriteLine("\nZip Code Updated Successfully");
                            break;
                        case 9:
                            Console.WriteLine("\nEnter new Phone Number : ");
                            int p = Convert.ToInt32(Console.ReadLine());
                            record.phoneNumber = p;
                            Console.WriteLine("\nPhone Number Updated Successfully");
                            break;
                        default:
                            Console.WriteLine("Enter valid choice");
                            break;
                    }
                    

                }
                else
                {
                    Console.WriteLine("Your entered details not match with any records");
                }
            }
        }
        public void Delete(string fn)
        {
            foreach (var record in records.ToList())  // For searching record
            {
                if (record.firstName == fn)
                {
                    records.Remove(record);
                    Console.WriteLine("Record deleted Successfully");

                }
                else
                {
                    Console.WriteLine("Record not found");
                }
            }
        }
    }
}
