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
            int r = 1;
            foreach (var person in records)
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
            CreateContacts contact = new CreateContacts();

            string firstName, middleName, lastName, address, city, state, email;
            int zip;
            long phoneNumber;
            Console.WriteLine("Enter your First Name : ");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter your Middle Name");
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
    }
}
