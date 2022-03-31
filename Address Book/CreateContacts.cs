using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class CreateContacts
    {
        public void CC() // Creating class method
        {
            string firstName,middleName, lastName, address, city, state, email;
            int zip;
            long phoneNumber;
            Console.WriteLine("Enter your First Name : ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your Middle Name");
            middleName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            email = Console.ReadLine();
            Console.ReadLine();
        }
        
    }
}
