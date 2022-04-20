using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Record
    {
        List<string> records = new List<string>(); // Creating a list to maintain address book name
        List<string> cityName = new List<string>();
        List<string> stateName = new List<string>();
        Dictionary<string, List<CreateContact>> dict = new Dictionary<string, List<CreateContact>>(); // Creating dictionary to Maintain all the address book 
        Dictionary<string, List<CreateContact>> recordsByCity = new Dictionary<string, List<CreateContact>>();
        Dictionary<string, List<CreateContact>> recordsByState = new Dictionary<string, List<CreateContact>>();
        public void CreateAddressBook(string n) // class method to create new address book and store it in dictionary
        {
            records.Add(n); // Add address book name which is provided by user  in address book list

            if (dict.Count == 0) // Checking that dictionary is empty or not
            {
                dict.Add(n, new List<CreateContact>()); // // creating key value pair where address book name is key and all the redord of address book as value
            }
            else
            {
                if (dict.ContainsKey(n)) // Checking that address book given by user is already present in dictionary or not
                {
                    Console.WriteLine("This AddressBook is also present");
                }
                else
                {
                    dict.Add(n, new List<CreateContact>()); // creating key value pair where address book name is key and all the redord of address book as value
                }

            }
        }
        public void cityNames(string city)
        {
            if (cityName.Count == 0)
            {
                cityName.Add(city.ToLower());
            }
            else
            {
                if (cityName.Contains(city))
                {
                    return;
                }
                else
                {
                    cityName.Add(city.ToLower());
                }
            }
        }
        public void stateNames(string state)
        {
            if (stateName.Count == 0)
            {
                stateName.Add(state.ToLower());
            }
            else
            {
                if (stateName.Contains(state.ToLower()))
                {
                    return;
                }
                else
                {
                    stateName.Add(state.ToLower());
                }
            }
        }
        public int temp = 0;
        public void DiplayListOfAddressBook() // Class method to display name Address book
        {
            if (records.Count == 0) // Checking that address book list is empty or not
            {
                Console.WriteLine("\nThere is no address book avilable");
                temp = 1;
            }
            else
            {
                Console.WriteLine("\n\nList of existing Address Book Are : ");
                foreach (string list in records) // Accessing all the names in address book
                {
                    Console.WriteLine(list);
                    Console.WriteLine();
                }
            }
        }
        public void print() // Class method to display all the records of all address book
        {
            foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
            {
                Console.WriteLine("\n\nAddress Book : " + content);
                int i = 1;
                foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                {
                    Console.WriteLine("\nRecord - " + i);
                    Console.WriteLine("First Name : " + value.firstName);
                    Console.WriteLine("Middle Name : " + value.middleName);
                    Console.WriteLine("Last Name : " + value.lastName);
                    Console.WriteLine("Address : " + value.address);
                    Console.WriteLine("City : " + value.city);
                    Console.WriteLine("State : " + value.state);
                    Console.WriteLine("Email : " + value.email);
                    Console.WriteLine("Zip code : " + value.zip);
                    Console.WriteLine("Phone Number : " + value.phoneNumber);
                    i++;
                }
            }
        }
        public void AddRecords(string name) // Creating class method to add Person Record in List
        {
            CreateContact contact = new CreateContact(); // Creating a object of PersonInput Class
            // Getting all the details from user and store it in PersonInput Class variales through object                                              
            Console.WriteLine("\nEnter your First Name : ");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("\nEnter your Middle Name : ");
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
            foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
            {
                if (content == name) // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    if (dict[content].Count == 0)
                    {
                        dict[name].Add(contact);// Adding person record in Address book
                        cityNames(contact.city);
                        stateNames(contact.state);
                        Console.WriteLine("\nRecord Added successfully in Address Book");
                    }
                    else
                    {
                        foreach (var value in dict[content].ToList()) // Accessing all the record of address book by dictionary key
                        {
                            if (value.phoneNumber != contact.phoneNumber) // Checking that phone number provided by user is matching with Existing Reord or not
                            {
                                dict[name].Add(contact);// Adding person record in Address book 
                                cityNames(contact.city);
                                stateNames(contact.state);
                                Console.WriteLine("\nRecord Added successfully in Address Book");
                            }
                            else
                            {
                                Console.WriteLine($"\nThis Record is already present in {content} Address Book");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"\n{content} Address Book not found");
                }

            }

        }
        string fn, ln;
        public void UpdateRecords(string ab) // Creating class method to update record which takes first name and last name as parameter
        {
            foreach (var content in dict.Keys)  // Accessing all the record of address book by dictionary key
            {
                if (content == ab) // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine(); // Store the user firstname in variable
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine(); // Store the user lastname in variable
                    foreach (var value in dict[content].ToList())
                    {
                        if (value.firstName == fn && value.lastName == ln) // Checking that first name and last name provided by user is matching with Existing Reord or not
                        {
                            Console.WriteLine("\n\nWhich field you want to update : ");
                            Console.WriteLine("\n1:First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Email\n7.Zip Code\n8.PhoneNumber\n9.Exit");
                            Console.WriteLine("\nEnter your Choice : ");
                            int ch = Convert.ToInt32(Console.ReadLine()); // Store the user choice which want to update 
                            switch (ch)
                            {
                                case 1:
                                    Console.WriteLine("\nEnter new first name : ");
                                    string f = Console.ReadLine();
                                    value.firstName = f; // Update the first name of record in address book
                                    Console.WriteLine("\nFirst Name Updated Successfully");
                                    break;
                                case 2:
                                    Console.WriteLine("\nEnter new last name : ");
                                    string l = Console.ReadLine();
                                    value.lastName = l;  // Update the last name of record in address book
                                    Console.WriteLine("\nLast Name Updated Successfully");
                                    break;
                                case 3:
                                    Console.WriteLine("\nEnter new address : ");
                                    string a = Console.ReadLine();
                                    value.address = a; // Update the address of record in address book
                                    Console.WriteLine("\nAddress Updated Successfully");
                                    break;
                                case 4:
                                    Console.WriteLine("\nEnter new city name : ");
                                    string c = Console.ReadLine();
                                    value.city = c; // Update the city name of record in address book
                                    Console.WriteLine("\nCity Name Updated Successfully");
                                    break;
                                case 5:
                                    Console.WriteLine("\nEnter new state : ");
                                    string s = Console.ReadLine();
                                    value.state = s; // Update the state name of record in address book
                                    Console.WriteLine("\nState Name Updated Successfully");
                                    break;
                                case 6:
                                    Console.WriteLine("\nEnter new email : ");
                                    string e = Console.ReadLine();
                                    value.email = e; // Update the email name of record in address book
                                    Console.WriteLine("\nEmail Updated Successfully");
                                    break;
                                case 7:
                                    Console.WriteLine("\nEnter new Zip Code : ");
                                    int z = Convert.ToInt32(Console.ReadLine());
                                    value.zip = z; // Update the zipcode of record in address book
                                    Console.WriteLine("\nZip Code Updated Successfully");
                                    break;
                                case 8:
                                    Console.WriteLine("\nEnter new Phone Number : ");
                                    int p = Convert.ToInt32(Console.ReadLine());
                                    value.phoneNumber = p; // Update the phone number of record in address book
                                    Console.WriteLine("\nPhone Number Updated Successfully");
                                    break;
                                default:
                                    Console.WriteLine("\nEnter valid choice");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }
            }
        }
        public void DeleteRecord(string ab)  // Creating class method to delete record which takes first name as parameter
        {
            foreach (var content in dict.Keys) // Accessing address book name by dictionary key
            {
                if (content == ab)  // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine(); // Store the user firstname in variable
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine();
                    foreach (var value in dict[content].ToList())  // Accessing all the record of address book by dictionary key
                    {
                        if (value.firstName == fn && value.lastName == ln) // Checking that first name and last name provided by user is matching with Existing Reord or not
                        {
                            Console.WriteLine("\nEnter your first name which you want to delete : ");
                            string f = Console.ReadLine(); // Store the user firstname in variable
                            dict[content].Remove(value); // Deleting all the details of one user in Address Book
                            Console.WriteLine("\nRecord Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }
            }
        }
        public void DisplayPersonsByCityName(string cName) // Class method to display all the records of all address book
        {
            foreach (var city in cityName)
            {
                if (cName.Equals(city))
                {
                    Console.WriteLine($"\nAll records present in multiple address books where city name \"{city}\" are : ");
                    foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
                    {
                        Console.WriteLine("\n\nAddress Book : " + content);
                        int i = 1;
                        foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                        {
                            if (value.city == city)
                            {
                                Console.WriteLine("\nRecord - " + i);
                                Console.WriteLine("First Name : " + value.firstName);
                                Console.WriteLine("Middle Name : " + value.middleName);
                                Console.WriteLine("Last Name : " + value.lastName);
                                Console.WriteLine("Address : " + value.address);
                                Console.WriteLine("City : " + value.city);
                                Console.WriteLine("State : " + value.state);
                                Console.WriteLine("Email : " + value.email);
                                Console.WriteLine("Zip code : " + value.zip);
                                Console.WriteLine("Phone Number : " + value.phoneNumber);
                                i++;
                            }
                        }
                    }
                }
            }
        }
        public void AddPersonsInDictionaryByCityName() // Class method to display all the records of all address book
        {
            foreach (var city in cityName)
            {
                foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
                {
                    foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                    {
                        if (value.city == city)
                        {
                            recordsByCity[city].Add(value);
                        }
                    }
                }
            }
        }
        public void AddPersonsInDictionaByStateName() // Class method to display all the records of all address book
        {
            foreach (var state in stateName)
            {
                foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
                {
                    foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                    {
                        if (value.state == state)
                        {
                            recordsByState[state].Add(value);
                        }
                    }

                }
            }
        }
        public void DisplayPersonsByStateName(string sName) // Class method to display all the records of all address book
        {
            foreach (var state in stateName)
            {
                if (sName.Equals(state))
                {
                    Console.WriteLine($"\nAll records present in multiple address books where state name \"{state}\" are : ");
                    foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
                    {
                        Console.WriteLine("\n\nAddress Book : " + content);
                        int i = 1;
                        foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                        {
                            if (value.state == state)
                            {
                                Console.WriteLine("\nRecord - " + i);
                                Console.WriteLine("First Name : " + value.firstName);
                                Console.WriteLine("Middle Name : " + value.middleName);
                                Console.WriteLine("Last Name : " + value.lastName);
                                Console.WriteLine("Address : " + value.address);
                                Console.WriteLine("City : " + value.city);
                                Console.WriteLine("State : " + value.state);
                                Console.WriteLine("Email : " + value.email);
                                Console.WriteLine("Zip code : " + value.zip);
                                Console.WriteLine("Phone Number : " + value.phoneNumber);
                                i++;
                            }
                        }
                    }
                }
            }
        }
    }
}
