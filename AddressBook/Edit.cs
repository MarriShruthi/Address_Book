using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Edit 
    {
        private Dictionary<string, Address> people = new Dictionary<string, Address>(); //create addressBook Dictionary

        //method of interface
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, string zip, string phoneNumber)
        {
            Address contact = new Address(); // creating object of person class
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.City = city;
            contact.State = state;
            contact.Zip = zip;
            contact.PhoneNumber = phoneNumber;
            contact.Email = email;
            people.Add(contact.FirstName, contact);
        }
        
    public void ViewContact()
        {
            //all Tvalues in dictionary access by KeyValuePair Class
            foreach (KeyValuePair<string, Address> item in people) //print all values using foreach  in addressBook Dictionary
            {
                Console.WriteLine("First Name : " + item.Value.FirstName);
                Console.WriteLine("Last Name : " + item.Value.LastName);
                Console.WriteLine("City : " + item.Value.City);
                Console.WriteLine("State : " + item.Value.State);
                Console.WriteLine("Email : " + item.Value.Email);
                Console.WriteLine("Zip : " + item.Value.Zip);
                Console.WriteLine("Phone Number : " + item.Value.PhoneNumber + "\n");

            }
        }

        internal void AddContact(string firstName, string lastName, string city, string state, string email, string zip, string phoneNumber)
        {
            Address contact = new Address(); // creating object of person class
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.City = city;
            contact.State = state;
            contact.Zip = zip;
            contact.PhoneNumber = phoneNumber;
            contact.Email = email;
            people.Add(contact.FirstName, contact);
        }

        public void EditContact(string name) //method in inteface pass argument name
        {
            foreach (KeyValuePair<string, Address> item in people) //use loop foreach
            {
                if (item.Key.Equals(name))
                {

                    Console.WriteLine("Choose What to Edit \n 1. FirstName\n2. LastName\n3. city\n4. State\n5. Email\n6. Zip \n7. PhoneNumber\n");

                    int choice = Convert.ToInt32(Console.ReadLine()); //convert string and store choice
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name :"); //take input
                            item.Value.FirstName = Console.ReadLine(); //store firstName string in iten.value
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name :");//take input
                            item.Value.LastName = Console.ReadLine();//store last name in value
                            break;
                        case 3:
                            Console.WriteLine("Enter City :");
                            item.Value.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter State :");
                            item.Value.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter Email :");
                            item.Value.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip :");
                            item.Value.Zip = Console.ReadLine(); //convert string into int and store it
                            break;
                        case 7:
                            Console.WriteLine("Enter Phone Number :");
                            item.Value.PhoneNumber = Console.ReadLine();
                            break;
                    }
                }
            }
        }
        public void DeleteContact(string name)
        {
            if (people.ContainsKey(name))
            {
                people.Remove(name);
                Console.WriteLine("\nDeleted Succesfully.\n");
            }
            else
            {
                Console.WriteLine("\nName you Entered  Not Found.\n");
            }
        }
    }
}
