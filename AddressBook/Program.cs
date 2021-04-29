using System;
using System.Text;
using System.Linq;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******WelCome To Address Book******");
            Edit addressBook = new Edit(); 
            Console.WriteLine("Enter First Name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter City :");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State :");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Zip :");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number :");
            string phoneNumber = Console.ReadLine();
            addressBook.AddContact(firstName, lastName, city, state, email, zip, phoneNumber);
            addressBook.ViewContact();//calling method
            addressBook.EditContact(firstName);
            addressBook.ViewContact();//calling method
            Console.Read();
        }
    }
}
